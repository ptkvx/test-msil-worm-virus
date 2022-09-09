using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using msclr;

namespace Microsoft.MediaCenter.TV.Tuners;

public class TunerCollection : ITunerCollection
{
	private object m_SyncRoot = new object();

	private Tuner[] m_Collection;

	public virtual object SyncRoot => m_SyncRoot;

	public virtual bool IsSynchronized
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			return false;
		}
	}

	public virtual bool IsReadOnly
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			return true;
		}
	}

	public virtual int Count => m_Collection.Length;

	private TunerEnumerator BuildEnumerator()
	{
		return new TunerEnumerator(m_Collection);
	}

	private void method_0()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_SyncRoot);
		try
		{
			@lock = lock2;
			Tuner[] collection = m_Collection;
			if (collection != null)
			{
				Tuner[] array = collection;
				int num = 0;
				if (0 < (nint)array.LongLength)
				{
					do
					{
						((IDisposable)array[num])?.Dispose();
						num++;
					}
					while (num < (nint)array.LongLength);
				}
				m_Collection = null;
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	internal unsafe TunerCollection(TunerManager pManager, delegate*<Tuner, byte> pPred)
	{
		m_Collection = pManager.GetCachedCollection(pPred, RecorderMgrFlags.rmf_WaitNone);
		base._002Ector();
	}

	internal TunerCollection(TunerManager pManager)
	{
		m_Collection = pManager.GetCachedCollection(RecorderMgrFlags.rmf_WaitNone);
		base._002Ector();
	}

	private void method_1()
	{
		method_0();
	}

	public virtual IEnumerator<Tuner> Generic_GetEnumerator()
	{
		return BuildEnumerator();
	}

	IEnumerator<Tuner> IEnumerable<Tuner>.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Generic_GetEnumerator
		return this.Generic_GetEnumerator();
	}

	public virtual IEnumerator IEnumerable_GetEnumerator()
	{
		return BuildEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in IEnumerable_GetEnumerator
		return this.IEnumerable_GetEnumerator();
	}

	public virtual void Add(Tuner t)
	{
		throw new NotSupportedException();
	}

	public virtual void Clear()
	{
		throw new NotSupportedException();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public virtual bool Contains(Tuner t)
	{
		throw new NotSupportedException();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public virtual bool Remove(Tuner t)
	{
		throw new NotSupportedException();
	}

	public virtual void CopyTo(Array a, int i)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_SyncRoot);
		try
		{
			@lock = lock2;
			IEnumerator enumerator = IEnumerable_GetEnumerator();
			int num = i;
			if (enumerator.MoveNext())
			{
				do
				{
					SafeComWrapper safeComWrapper = (SafeComWrapper)enumerator.Current;
					if (safeComWrapper != null && !safeComWrapper.IsInvalid)
					{
						a.SetValue(safeComWrapper, num);
						num++;
						continue;
					}
					throw new ApplicationException("unexpected failure to clone tuner collection member");
				}
				while (enumerator.MoveNext());
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		try
		{
			return;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
	}

	public virtual void CopyTo(Tuner[] a, int i)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_SyncRoot);
		try
		{
			@lock = lock2;
			IEnumerator<Tuner> enumerator = Generic_GetEnumerator();
			int num = i;
			if (enumerator.MoveNext())
			{
				do
				{
					Tuner current = enumerator.Current;
					if (current != null && !current.IsInvalid)
					{
						a[num] = current;
						num++;
						continue;
					}
					throw new ApplicationException("unexpected failure to clone tuner collection member");
				}
				while (enumerator.MoveNext());
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		try
		{
			return;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
	}

	public virtual object Clone()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_SyncRoot);
		Tuner[] array;
		try
		{
			@lock = lock2;
			Tuner[] collection = m_Collection;
			int num = collection.Length;
			array = new Tuner[num];
			int num2 = 0;
			if (0 < num)
			{
				do
				{
					Tuner tuner = _003CModule_003E.smethod_113(collection[num2]);
					if (tuner != null && !tuner.IsInvalid)
					{
						array.SetValue(tuner, num2);
						num2++;
						collection = m_Collection;
						continue;
					}
					throw new ApplicationException("unexpected failure to clone tuner collection member");
				}
				while (num2 < (nint)collection.LongLength);
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return array;
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool bool_0)
	{
		if (bool_0)
		{
			method_0();
			return;
		}
		try
		{
			method_0();
		}
		finally
		{
			base.Finalize();
		}
	}

	public sealed override void Dispose()
	{
		Dispose(bool_0: true);
		GC.SuppressFinalize(this);
	}

	~TunerCollection()
	{
		Dispose(bool_0: false);
	}
}
