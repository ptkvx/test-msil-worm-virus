using System.Security.Permissions;

namespace System.Threading;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class ReaderWriterLockSlim : IDisposable
{
	private const int LockSpinCycles = 20;

	private const int LockSpinCount = 10;

	private const int LockSleep0Count = 5;

	private const int hashTableSize = 255;

	private const int MaxSpinCount = 20;

	private const uint WRITER_HELD = 2147483648u;

	private const uint WAITING_WRITERS = 1073741824u;

	private const uint WAITING_UPGRADER = 536870912u;

	private const uint MAX_READER = 268435454u;

	private const uint READER_MASK = 268435455u;

	private bool fIsReentrant;

	private int myLock;

	private uint numWriteWaiters;

	private uint numReadWaiters;

	private uint numWriteUpgradeWaiters;

	private uint numUpgradeWaiters;

	private bool fNoWaiters;

	private int upgradeLockOwnerId;

	private int writeLockOwnerId;

	private EventWaitHandle writeEvent;

	private EventWaitHandle readEvent;

	private EventWaitHandle upgradeEvent;

	private EventWaitHandle waitUpgradeEvent;

	private ReaderWriterCount[] rwc;

	private bool fUpgradeThreadHoldingRead;

	private uint owners;

	private bool fDisposed;

	public bool IsReadLockHeld
	{
		get
		{
			if (RecursiveReadCount > 0)
			{
				return true;
			}
			return false;
		}
	}

	public bool IsUpgradeableReadLockHeld
	{
		get
		{
			if (RecursiveUpgradeCount > 0)
			{
				return true;
			}
			return false;
		}
	}

	public bool IsWriteLockHeld
	{
		get
		{
			if (RecursiveWriteCount > 0)
			{
				return true;
			}
			return false;
		}
	}

	public LockRecursionPolicy RecursionPolicy
	{
		get
		{
			if (fIsReentrant)
			{
				return LockRecursionPolicy.SupportsRecursion;
			}
			return LockRecursionPolicy.NoRecursion;
		}
	}

	public int CurrentReadCount
	{
		get
		{
			int numReaders = (int)GetNumReaders();
			if (upgradeLockOwnerId != -1)
			{
				return numReaders - 1;
			}
			return numReaders;
		}
	}

	public int RecursiveReadCount
	{
		get
		{
			int managedThreadId = Thread.CurrentThread.ManagedThreadId;
			int result = 0;
			EnterMyLock();
			ReaderWriterCount threadRWCount = GetThreadRWCount(managedThreadId, DontAllocate: true);
			if (threadRWCount != null)
			{
				result = threadRWCount.readercount;
			}
			ExitMyLock();
			return result;
		}
	}

	public int RecursiveUpgradeCount
	{
		get
		{
			int managedThreadId = Thread.CurrentThread.ManagedThreadId;
			if (fIsReentrant)
			{
				int result = 0;
				EnterMyLock();
				ReaderWriterCount threadRWCount = GetThreadRWCount(managedThreadId, DontAllocate: true);
				if (threadRWCount != null)
				{
					result = threadRWCount.rc.upgradecount;
				}
				ExitMyLock();
				return result;
			}
			if (managedThreadId == upgradeLockOwnerId)
			{
				return 1;
			}
			return 0;
		}
	}

	public int RecursiveWriteCount
	{
		get
		{
			int managedThreadId = Thread.CurrentThread.ManagedThreadId;
			int result = 0;
			if (fIsReentrant)
			{
				EnterMyLock();
				ReaderWriterCount threadRWCount = GetThreadRWCount(managedThreadId, DontAllocate: true);
				if (threadRWCount != null)
				{
					result = threadRWCount.rc.writercount;
				}
				ExitMyLock();
				return result;
			}
			if (managedThreadId == writeLockOwnerId)
			{
				return 1;
			}
			return 0;
		}
	}

	public int WaitingReadCount => (int)numReadWaiters;

	public int WaitingUpgradeCount => (int)numUpgradeWaiters;

	public int WaitingWriteCount => (int)numWriteWaiters;

	private void InitializeThreadCounts()
	{
		rwc = new ReaderWriterCount[256];
		for (int i = 0; i < rwc.Length; i++)
		{
			rwc[i] = new ReaderWriterCount(fIsReentrant);
		}
		upgradeLockOwnerId = -1;
		writeLockOwnerId = -1;
	}

	public ReaderWriterLockSlim()
		: this(LockRecursionPolicy.NoRecursion)
	{
	}

	public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy)
	{
		if (recursionPolicy == LockRecursionPolicy.SupportsRecursion)
		{
			fIsReentrant = true;
		}
		InitializeThreadCounts();
	}

	private static bool IsRWEntryEmpty(ReaderWriterCount rwc)
	{
		if (rwc.threadid == -1)
		{
			return true;
		}
		if (rwc.readercount == 0 && rwc.rc == null)
		{
			return true;
		}
		if (rwc.readercount == 0 && rwc.rc.writercount == 0 && rwc.rc.upgradecount == 0)
		{
			return true;
		}
		return false;
	}

	private static bool IsRwHashEntryChanged(ReaderWriterCount lrwc, int id)
	{
		return lrwc.threadid != id;
	}

	private ReaderWriterCount GetThreadRWCount(int id, bool DontAllocate)
	{
		int num = id & 0xFF;
		ReaderWriterCount readerWriterCount = null;
		if (rwc[num].threadid == id)
		{
			return rwc[num];
		}
		if (IsRWEntryEmpty(rwc[num]) && !DontAllocate)
		{
			if (rwc[num].next == null)
			{
				rwc[num].threadid = id;
				return rwc[num];
			}
			readerWriterCount = rwc[num];
		}
		ReaderWriterCount next = rwc[num].next;
		while (true)
		{
			if (next != null)
			{
				if (next.threadid == id)
				{
					break;
				}
				if (readerWriterCount == null && IsRWEntryEmpty(next))
				{
					readerWriterCount = next;
				}
				next = next.next;
				continue;
			}
			if (DontAllocate)
			{
				return null;
			}
			if (readerWriterCount == null)
			{
				next = new ReaderWriterCount(fIsReentrant);
				next.threadid = id;
				next.next = rwc[num].next;
				rwc[num].next = next;
				return next;
			}
			readerWriterCount.threadid = id;
			return readerWriterCount;
		}
		return next;
	}

	public void EnterReadLock()
	{
		TryEnterReadLock(-1);
	}

	public bool TryEnterReadLock(TimeSpan timeout)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1L || num > 2147483647L)
		{
			throw new ArgumentOutOfRangeException("timeout");
		}
		int millisecondsTimeout = (int)timeout.TotalMilliseconds;
		return TryEnterReadLock(millisecondsTimeout);
	}

	public bool TryEnterReadLock(int millisecondsTimeout)
	{
		if (millisecondsTimeout < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout");
		}
		if (fDisposed)
		{
			throw new ObjectDisposedException(null);
		}
		ReaderWriterCount readerWriterCount = null;
		int managedThreadId = Thread.CurrentThread.ManagedThreadId;
		if (!fIsReentrant)
		{
			if (managedThreadId == writeLockOwnerId)
			{
				throw new LockRecursionException(SR.GetString("LockRecursionException_ReadAfterWriteNotAllowed"));
			}
			EnterMyLock();
			readerWriterCount = GetThreadRWCount(managedThreadId, DontAllocate: false);
			if (readerWriterCount.readercount > 0)
			{
				ExitMyLock();
				throw new LockRecursionException(SR.GetString("LockRecursionException_RecursiveReadNotAllowed"));
			}
			if (managedThreadId == upgradeLockOwnerId)
			{
				readerWriterCount.readercount++;
				owners++;
				ExitMyLock();
				return true;
			}
		}
		else
		{
			EnterMyLock();
			readerWriterCount = GetThreadRWCount(managedThreadId, DontAllocate: false);
			if (readerWriterCount.readercount > 0)
			{
				readerWriterCount.readercount++;
				ExitMyLock();
				return true;
			}
			if (managedThreadId == upgradeLockOwnerId)
			{
				readerWriterCount.readercount++;
				owners++;
				ExitMyLock();
				fUpgradeThreadHoldingRead = true;
				return true;
			}
			if (managedThreadId == writeLockOwnerId)
			{
				readerWriterCount.readercount++;
				owners++;
				ExitMyLock();
				return true;
			}
		}
		bool result = true;
		int num = 0;
		while (true)
		{
			if (owners >= 268435454)
			{
				if (num < 20)
				{
					ExitMyLock();
					if (millisecondsTimeout == 0)
					{
						return false;
					}
					num++;
					SpinWait(num);
					EnterMyLock();
					if (IsRwHashEntryChanged(readerWriterCount, managedThreadId))
					{
						readerWriterCount = GetThreadRWCount(managedThreadId, DontAllocate: false);
					}
				}
				else if (readEvent == null)
				{
					LazyCreateEvent(ref readEvent, makeAutoResetEvent: false);
					if (IsRwHashEntryChanged(readerWriterCount, managedThreadId))
					{
						readerWriterCount = GetThreadRWCount(managedThreadId, DontAllocate: false);
					}
				}
				else
				{
					if (!(result = WaitOnEvent(readEvent, ref numReadWaiters, millisecondsTimeout)))
					{
						break;
					}
					if (IsRwHashEntryChanged(readerWriterCount, managedThreadId))
					{
						readerWriterCount = GetThreadRWCount(managedThreadId, DontAllocate: false);
					}
				}
				continue;
			}
			owners++;
			readerWriterCount.readercount++;
			ExitMyLock();
			return result;
		}
		return false;
	}

	public void EnterWriteLock()
	{
		TryEnterWriteLock(-1);
	}

	public bool TryEnterWriteLock(TimeSpan timeout)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1L || num > 2147483647L)
		{
			throw new ArgumentOutOfRangeException("timeout");
		}
		int millisecondsTimeout = (int)timeout.TotalMilliseconds;
		return TryEnterWriteLock(millisecondsTimeout);
	}

	public bool TryEnterWriteLock(int millisecondsTimeout)
	{
		if (millisecondsTimeout < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout");
		}
		if (fDisposed)
		{
			throw new ObjectDisposedException(null);
		}
		int managedThreadId = Thread.CurrentThread.ManagedThreadId;
		bool flag = false;
		ReaderWriterCount threadRWCount;
		if (!fIsReentrant)
		{
			if (managedThreadId == writeLockOwnerId)
			{
				throw new LockRecursionException(SR.GetString("LockRecursionException_RecursiveWriteNotAllowed"));
			}
			if (managedThreadId == upgradeLockOwnerId)
			{
				flag = true;
			}
			EnterMyLock();
			threadRWCount = GetThreadRWCount(managedThreadId, DontAllocate: true);
			if (threadRWCount != null && threadRWCount.readercount > 0)
			{
				ExitMyLock();
				throw new LockRecursionException(SR.GetString("LockRecursionException_WriteAfterReadNotAllowed"));
			}
		}
		else
		{
			EnterMyLock();
			threadRWCount = GetThreadRWCount(managedThreadId, DontAllocate: false);
			if (managedThreadId == writeLockOwnerId)
			{
				threadRWCount.rc.writercount++;
				ExitMyLock();
				return true;
			}
			if (managedThreadId == upgradeLockOwnerId)
			{
				flag = true;
			}
			else if (threadRWCount.readercount > 0)
			{
				ExitMyLock();
				throw new LockRecursionException(SR.GetString("LockRecursionException_WriteAfterReadNotAllowed"));
			}
		}
		int num = 0;
		while (true)
		{
			if (!IsWriterAcquired())
			{
				if (flag)
				{
					uint numReaders = GetNumReaders();
					if (numReaders == 1)
					{
						SetWriterAcquired();
						goto IL_01cd;
					}
					if (numReaders == 2 && threadRWCount != null)
					{
						if (IsRwHashEntryChanged(threadRWCount, managedThreadId))
						{
							threadRWCount = GetThreadRWCount(managedThreadId, DontAllocate: false);
						}
						if (threadRWCount.readercount > 0)
						{
							SetWriterAcquired();
							goto IL_01cd;
						}
					}
				}
				if (num < 20)
				{
					ExitMyLock();
					if (millisecondsTimeout == 0)
					{
						return false;
					}
					num++;
					SpinWait(num);
					EnterMyLock();
				}
				else if (flag)
				{
					if (waitUpgradeEvent == null)
					{
						LazyCreateEvent(ref waitUpgradeEvent, makeAutoResetEvent: true);
					}
					else if (!WaitOnEvent(waitUpgradeEvent, ref numWriteUpgradeWaiters, millisecondsTimeout))
					{
						return false;
					}
				}
				else if (writeEvent == null)
				{
					LazyCreateEvent(ref writeEvent, makeAutoResetEvent: true);
				}
				else if (!WaitOnEvent(writeEvent, ref numWriteWaiters, millisecondsTimeout))
				{
					break;
				}
				continue;
			}
			SetWriterAcquired();
			goto IL_01cd;
			IL_01cd:
			if (fIsReentrant)
			{
				if (IsRwHashEntryChanged(threadRWCount, managedThreadId))
				{
					threadRWCount = GetThreadRWCount(managedThreadId, DontAllocate: false);
				}
				threadRWCount.rc.writercount++;
			}
			ExitMyLock();
			writeLockOwnerId = managedThreadId;
			return true;
		}
		return false;
	}

	public void EnterUpgradeableReadLock()
	{
		TryEnterUpgradeableReadLock(-1);
	}

	public bool TryEnterUpgradeableReadLock(TimeSpan timeout)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1L || num > 2147483647L)
		{
			throw new ArgumentOutOfRangeException("timeout");
		}
		int millisecondsTimeout = (int)timeout.TotalMilliseconds;
		return TryEnterUpgradeableReadLock(millisecondsTimeout);
	}

	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout)
	{
		if (millisecondsTimeout < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout");
		}
		if (fDisposed)
		{
			throw new ObjectDisposedException(null);
		}
		int managedThreadId = Thread.CurrentThread.ManagedThreadId;
		ReaderWriterCount threadRWCount;
		if (!fIsReentrant)
		{
			if (managedThreadId == upgradeLockOwnerId)
			{
				throw new LockRecursionException(SR.GetString("LockRecursionException_RecursiveUpgradeNotAllowed"));
			}
			if (managedThreadId == writeLockOwnerId)
			{
				throw new LockRecursionException(SR.GetString("LockRecursionException_UpgradeAfterWriteNotAllowed"));
			}
			EnterMyLock();
			threadRWCount = GetThreadRWCount(managedThreadId, DontAllocate: true);
			if (threadRWCount != null && threadRWCount.readercount > 0)
			{
				ExitMyLock();
				throw new LockRecursionException(SR.GetString("LockRecursionException_UpgradeAfterReadNotAllowed"));
			}
		}
		else
		{
			EnterMyLock();
			threadRWCount = GetThreadRWCount(managedThreadId, DontAllocate: false);
			if (managedThreadId == upgradeLockOwnerId)
			{
				threadRWCount.rc.upgradecount++;
				ExitMyLock();
				return true;
			}
			if (managedThreadId == writeLockOwnerId)
			{
				owners++;
				upgradeLockOwnerId = managedThreadId;
				threadRWCount.rc.upgradecount++;
				if (threadRWCount.readercount > 0)
				{
					fUpgradeThreadHoldingRead = true;
				}
				ExitMyLock();
				return true;
			}
			if (threadRWCount.readercount > 0)
			{
				ExitMyLock();
				throw new LockRecursionException(SR.GetString("LockRecursionException_UpgradeAfterReadNotAllowed"));
			}
		}
		int num = 0;
		while (true)
		{
			if (upgradeLockOwnerId != -1 || owners >= 268435454)
			{
				if (num < 20)
				{
					ExitMyLock();
					if (millisecondsTimeout == 0)
					{
						return false;
					}
					num++;
					SpinWait(num);
					EnterMyLock();
				}
				else if (upgradeEvent == null)
				{
					LazyCreateEvent(ref upgradeEvent, makeAutoResetEvent: true);
				}
				else if (!WaitOnEvent(upgradeEvent, ref numUpgradeWaiters, millisecondsTimeout))
				{
					break;
				}
				continue;
			}
			owners++;
			upgradeLockOwnerId = managedThreadId;
			if (fIsReentrant)
			{
				if (IsRwHashEntryChanged(threadRWCount, managedThreadId))
				{
					threadRWCount = GetThreadRWCount(managedThreadId, DontAllocate: false);
				}
				threadRWCount.rc.upgradecount++;
			}
			ExitMyLock();
			return true;
		}
		return false;
	}

	public void ExitReadLock()
	{
		int managedThreadId = Thread.CurrentThread.ManagedThreadId;
		ReaderWriterCount readerWriterCount = null;
		EnterMyLock();
		readerWriterCount = GetThreadRWCount(managedThreadId, DontAllocate: true);
		if (!fIsReentrant)
		{
			if (readerWriterCount == null)
			{
				ExitMyLock();
				throw new SynchronizationLockException(SR.GetString("SynchronizationLockException_MisMatchedRead"));
			}
		}
		else
		{
			if (readerWriterCount == null || readerWriterCount.readercount < 1)
			{
				ExitMyLock();
				throw new SynchronizationLockException(SR.GetString("SynchronizationLockException_MisMatchedRead"));
			}
			if (readerWriterCount.readercount > 1)
			{
				readerWriterCount.readercount--;
				ExitMyLock();
				return;
			}
			if (managedThreadId == upgradeLockOwnerId)
			{
				fUpgradeThreadHoldingRead = false;
			}
		}
		owners--;
		readerWriterCount.readercount--;
		ExitAndWakeUpAppropriateWaiters();
	}

	public void ExitWriteLock()
	{
		int managedThreadId = Thread.CurrentThread.ManagedThreadId;
		if (!fIsReentrant)
		{
			if (managedThreadId != writeLockOwnerId)
			{
				throw new SynchronizationLockException(SR.GetString("SynchronizationLockException_MisMatchedWrite"));
			}
			EnterMyLock();
		}
		else
		{
			EnterMyLock();
			ReaderWriterCount threadRWCount = GetThreadRWCount(managedThreadId, DontAllocate: false);
			if (threadRWCount == null)
			{
				ExitMyLock();
				throw new SynchronizationLockException(SR.GetString("SynchronizationLockException_MisMatchedWrite"));
			}
			RecursiveCounts rc = threadRWCount.rc;
			if (rc.writercount < 1)
			{
				ExitMyLock();
				throw new SynchronizationLockException(SR.GetString("SynchronizationLockException_MisMatchedWrite"));
			}
			rc.writercount--;
			if (rc.writercount > 0)
			{
				ExitMyLock();
				return;
			}
		}
		ClearWriterAcquired();
		writeLockOwnerId = -1;
		ExitAndWakeUpAppropriateWaiters();
	}

	public void ExitUpgradeableReadLock()
	{
		int managedThreadId = Thread.CurrentThread.ManagedThreadId;
		if (!fIsReentrant)
		{
			if (managedThreadId != upgradeLockOwnerId)
			{
				throw new SynchronizationLockException(SR.GetString("SynchronizationLockException_MisMatchedUpgrade"));
			}
			EnterMyLock();
		}
		else
		{
			EnterMyLock();
			ReaderWriterCount threadRWCount = GetThreadRWCount(managedThreadId, DontAllocate: true);
			if (threadRWCount == null)
			{
				ExitMyLock();
				throw new SynchronizationLockException(SR.GetString("SynchronizationLockException_MisMatchedUpgrade"));
			}
			RecursiveCounts rc = threadRWCount.rc;
			if (rc.upgradecount < 1)
			{
				ExitMyLock();
				throw new SynchronizationLockException(SR.GetString("SynchronizationLockException_MisMatchedUpgrade"));
			}
			rc.upgradecount--;
			if (rc.upgradecount > 0)
			{
				ExitMyLock();
				return;
			}
			fUpgradeThreadHoldingRead = false;
		}
		owners--;
		upgradeLockOwnerId = -1;
		ExitAndWakeUpAppropriateWaiters();
	}

	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent)
	{
		ExitMyLock();
		EventWaitHandle eventWaitHandle = ((!makeAutoResetEvent) ? ((EventWaitHandle)new ManualResetEvent(initialState: false)) : ((EventWaitHandle)new AutoResetEvent(initialState: false)));
		EnterMyLock();
		if (waitEvent == null)
		{
			waitEvent = eventWaitHandle;
		}
		else
		{
			eventWaitHandle.Close();
		}
	}

	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, int millisecondsTimeout)
	{
		waitEvent.Reset();
		numWaiters++;
		fNoWaiters = false;
		if (numWriteWaiters == 1)
		{
			SetWritersWaiting();
		}
		if (numWriteUpgradeWaiters == 1)
		{
			SetUpgraderWaiting();
		}
		bool flag = false;
		ExitMyLock();
		try
		{
			flag = waitEvent.WaitOne(millisecondsTimeout, exitContext: false);
		}
		finally
		{
			EnterMyLock();
			numWaiters--;
			if (numWriteWaiters == 0 && numWriteUpgradeWaiters == 0 && numUpgradeWaiters == 0 && numReadWaiters == 0)
			{
				fNoWaiters = true;
			}
			if (numWriteWaiters == 0)
			{
				ClearWritersWaiting();
			}
			if (numWriteUpgradeWaiters == 0)
			{
				ClearUpgraderWaiting();
			}
			if (!flag)
			{
				ExitMyLock();
			}
		}
		return flag;
	}

	private void ExitAndWakeUpAppropriateWaiters()
	{
		if (fNoWaiters)
		{
			ExitMyLock();
		}
		else
		{
			ExitAndWakeUpAppropriateWaitersPreferringWriters();
		}
	}

	private void ExitAndWakeUpAppropriateWaitersPreferringWriters()
	{
		bool flag = false;
		bool flag2 = false;
		uint numReaders = GetNumReaders();
		if (fIsReentrant && numWriteUpgradeWaiters != 0 && fUpgradeThreadHoldingRead && numReaders == 2)
		{
			ExitMyLock();
			waitUpgradeEvent.Set();
			return;
		}
		if (numReaders == 1 && numWriteUpgradeWaiters != 0)
		{
			ExitMyLock();
			waitUpgradeEvent.Set();
			return;
		}
		if (numReaders == 0 && numWriteWaiters != 0)
		{
			ExitMyLock();
			writeEvent.Set();
			return;
		}
		if (numReadWaiters == 0 && numUpgradeWaiters == 0)
		{
			ExitMyLock();
			return;
		}
		if (numReadWaiters != 0)
		{
			flag2 = true;
		}
		if (numUpgradeWaiters != 0 && upgradeLockOwnerId == -1)
		{
			flag = true;
		}
		ExitMyLock();
		if (flag2)
		{
			readEvent.Set();
		}
		if (flag)
		{
			upgradeEvent.Set();
		}
	}

	private bool IsWriterAcquired()
	{
		return (owners & 0xBFFFFFFFu) == 0;
	}

	private void SetWriterAcquired()
	{
		owners |= 2147483648u;
	}

	private void ClearWriterAcquired()
	{
		owners &= 2147483647u;
	}

	private void SetWritersWaiting()
	{
		owners |= 1073741824u;
	}

	private void ClearWritersWaiting()
	{
		owners &= 3221225471u;
	}

	private void SetUpgraderWaiting()
	{
		owners |= 536870912u;
	}

	private void ClearUpgraderWaiting()
	{
		owners &= 3758096383u;
	}

	private uint GetNumReaders()
	{
		return owners & 0xFFFFFFFu;
	}

	private void EnterMyLock()
	{
		if (Interlocked.CompareExchange(ref myLock, 1, 0) != 0)
		{
			EnterMyLockSpin();
		}
	}

	private void EnterMyLockSpin()
	{
		int processorCount = Environment.ProcessorCount;
		int num = 0;
		while (true)
		{
			if (num >= 10 || processorCount <= 1)
			{
				if (num < 15)
				{
					Thread.Sleep(0);
				}
				else
				{
					Thread.Sleep(1);
				}
			}
			else
			{
				Thread.SpinWait(20 * (num + 1));
			}
			if (myLock != 0 || Interlocked.CompareExchange(ref myLock, 1, 0) != 0)
			{
				num++;
				continue;
			}
			break;
		}
	}

	private void ExitMyLock()
	{
		myLock = 0;
	}

	private static void SpinWait(int SpinCount)
	{
		if (SpinCount < 5 && Environment.ProcessorCount > 1)
		{
			Thread.SpinWait(20 * SpinCount);
		}
		else if (SpinCount < 17)
		{
			Thread.Sleep(0);
		}
		else
		{
			Thread.Sleep(1);
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	private void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (fDisposed)
			{
				throw new ObjectDisposedException(null);
			}
			if (WaitingReadCount > 0 || WaitingUpgradeCount > 0 || WaitingWriteCount > 0)
			{
				throw new SynchronizationLockException(SR.GetString("SynchronizationLockException_IncorrectDispose"));
			}
			if (IsReadLockHeld || IsUpgradeableReadLockHeld || IsWriteLockHeld)
			{
				throw new SynchronizationLockException(SR.GetString("SynchronizationLockException_IncorrectDispose"));
			}
			if (writeEvent != null)
			{
				writeEvent.Close();
				writeEvent = null;
			}
			if (readEvent != null)
			{
				readEvent.Close();
				readEvent = null;
			}
			if (upgradeEvent != null)
			{
				upgradeEvent.Close();
				upgradeEvent = null;
			}
			if (waitUpgradeEvent != null)
			{
				waitUpgradeEvent.Close();
				waitUpgradeEvent = null;
			}
			fDisposed = true;
		}
	}
}
