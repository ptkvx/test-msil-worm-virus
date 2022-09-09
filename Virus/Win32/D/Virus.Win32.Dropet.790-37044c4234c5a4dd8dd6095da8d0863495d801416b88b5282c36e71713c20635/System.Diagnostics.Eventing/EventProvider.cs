using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;

namespace System.Diagnostics.Eventing;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class EventProvider : IDisposable
{
	public enum WriteEventErrorCode
	{
		NoError,
		NoFreeBuffers,
		EventTooBig
	}

	[StructLayout(LayoutKind.Explicit, Size = 16)]
	private struct EventData
	{
		[FieldOffset(0)]
		internal ulong DataPointer;

		[FieldOffset(8)]
		internal uint Size;

		[FieldOffset(12)]
		internal int Reserved;
	}

	private enum ActivityControl : uint
	{
		EVENT_ACTIVITY_CTRL_GET_ID = 1u,
		EVENT_ACTIVITY_CTRL_SET_ID,
		EVENT_ACTIVITY_CTRL_CREATE_ID,
		EVENT_ACTIVITY_CTRL_GET_SET_ID,
		EVENT_ACTIVITY_CTRL_CREATE_SET_ID
	}

	private const int s_basicTypeAllocationBufferSize = 16;

	private const int s_etwMaxMumberArguments = 32;

	private const int s_etwAPIMaxStringCount = 8;

	private const int s_maxEventDataDescriptors = 128;

	private const int s_traceEventMaximumSize = 65482;

	private const int s_traceEventMaximumStringSize = 32724;

	private UnsafeNativeMethods.EtwEnableCallback m_etwCallback;

	private long m_regHandle;

	private byte m_level;

	private long m_anyKeywordMask;

	private long m_allKeywordMask;

	private int m_enabled;

	private Guid m_providerId;

	private int m_disposed;

	private static LocalDataStoreSlot s_returnCodeSlot;

	private static bool s_platformNotSupported = Environment.OSVersion.Version.Major < 6;

	[SecurityCritical]
	[PermissionSet(SecurityAction.Demand, Unrestricted = true)]
	public EventProvider(Guid providerGuid)
	{
		m_providerId = providerGuid;
		s_returnCodeSlot = Thread.AllocateDataSlot();
		Thread.SetData(s_returnCodeSlot, 0);
		EtwRegister();
	}

	[SecurityCritical]
	private unsafe void EtwRegister()
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException(SR.GetString("NotSupported_DownLevelVista"));
		}
		m_etwCallback = EtwEnableCallBack;
		uint num = UnsafeNativeMethods.EventRegister(ref m_providerId, m_etwCallback, null, ref m_regHandle);
		if (num != 0)
		{
			throw new Win32Exception((int)num);
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[SecurityTreatAsSafe]
	[SecurityCritical]
	protected virtual void Dispose(bool disposing)
	{
		if (m_disposed != 1 && Interlocked.Exchange(ref m_disposed, 1) == 0)
		{
			m_enabled = 0;
			Deregister();
		}
	}

	public virtual void Close()
	{
		Dispose();
	}

	~EventProvider()
	{
		Dispose(disposing: false);
	}

	[SecurityCritical]
	private void Deregister()
	{
		if (m_regHandle != 0L)
		{
			UnsafeNativeMethods.EventUnregister(m_regHandle);
			m_regHandle = 0L;
		}
	}

	[SecurityCritical]
	private unsafe void EtwEnableCallBack([In] ref Guid sourceId, [In] int isEnabled, [In] byte setLevel, [In] long anyKeyword, [In] long allKeyword, [In] void* filterData, [In] void* callbackContext)
	{
		m_enabled = isEnabled;
		m_level = setLevel;
		m_anyKeywordMask = anyKeyword;
		m_allKeywordMask = allKeyword;
	}

	public bool IsEnabled()
	{
		if (m_enabled == 0)
		{
			return false;
		}
		return true;
	}

	public bool IsEnabled(byte level, long keywords)
	{
		if (m_enabled == 0)
		{
			return false;
		}
		if ((level > m_level && m_level != 0) || (keywords != 0L && ((keywords & m_anyKeywordMask) == 0L || (keywords & m_allKeywordMask) != m_allKeywordMask)))
		{
			return false;
		}
		return true;
	}

	public static WriteEventErrorCode GetLastWriteEventError()
	{
		object data = Thread.GetData(s_returnCodeSlot);
		if (data == null)
		{
			return WriteEventErrorCode.NoError;
		}
		return (WriteEventErrorCode)(int)data;
	}

	private static void SetLastError(int error)
	{
		switch (error)
		{
		case 234:
		case 534:
			Thread.SetData(s_returnCodeSlot, 2);
			break;
		case 8:
			Thread.SetData(s_returnCodeSlot, 1);
			break;
		}
	}

	[SecurityCritical]
	private unsafe static string EncodeObject(ref object data, EventData* dataDescriptor, byte* dataBuffer)
	{
		dataDescriptor->Reserved = 0;
		if (data is string text)
		{
			dataDescriptor->Size = (uint)((text.Length + 1) * 2);
			return text;
		}
		if (data is IntPtr)
		{
			dataDescriptor->Size = (uint)sizeof(IntPtr);
			*(IntPtr*)dataBuffer = (IntPtr)data;
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		else if (data is int)
		{
			dataDescriptor->Size = 4u;
			*(int*)dataBuffer = (int)data;
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		else if (data is long)
		{
			dataDescriptor->Size = 8u;
			*(long*)dataBuffer = (long)data;
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		else if (data is uint)
		{
			dataDescriptor->Size = 4u;
			*(uint*)dataBuffer = (uint)data;
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		else if (data is ulong)
		{
			dataDescriptor->Size = 8u;
			*(ulong*)dataBuffer = (ulong)data;
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		else if (data is char)
		{
			dataDescriptor->Size = 2u;
			*(char*)dataBuffer = (char)data;
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		else if (data is byte)
		{
			dataDescriptor->Size = 1u;
			*dataBuffer = (byte)data;
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		else if (data is short)
		{
			dataDescriptor->Size = 2u;
			*(short*)dataBuffer = (short)data;
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		else if (data is sbyte)
		{
			dataDescriptor->Size = 1u;
			*dataBuffer = (byte)(sbyte)data;
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		else if (data is ushort)
		{
			dataDescriptor->Size = 2u;
			*(ushort*)dataBuffer = (ushort)data;
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		else if (data is float)
		{
			dataDescriptor->Size = 4u;
			*(float*)dataBuffer = (float)data;
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		else if (data is double)
		{
			dataDescriptor->Size = 8u;
			*(double*)dataBuffer = (double)data;
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		else if (data is bool)
		{
			dataDescriptor->Size = 1u;
			*dataBuffer = (((bool)data) ? ((byte)1) : ((byte)0));
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		else if (data is Guid)
		{
			dataDescriptor->Size = (uint)sizeof(Guid);
			*(Guid*)dataBuffer = (Guid)data;
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		else if (data is decimal)
		{
			dataDescriptor->Size = 16u;
			*(decimal*)dataBuffer = (decimal)data;
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		else
		{
			if (!(data is bool))
			{
				string text2 = data.ToString();
				dataDescriptor->Size = (uint)((text2.Length + 1) * 2);
				return text2;
			}
			dataDescriptor->Size = 1u;
			*dataBuffer = (((bool)data) ? ((byte)1) : ((byte)0));
			dataDescriptor->DataPointer = (ulong)dataBuffer;
		}
		return null;
	}

	[SecurityCritical]
	public unsafe bool WriteMessageEvent(string eventMessage, byte eventLevel, long eventKeywords)
	{
		int num = 0;
		if (eventMessage == null)
		{
			throw new ArgumentNullException("eventMessage");
		}
		if (IsEnabled(eventLevel, eventKeywords))
		{
			if (eventMessage.Length > 32724)
			{
				Thread.SetData(s_returnCodeSlot, 2);
				return false;
			}
			fixed (char* message = eventMessage)
			{
				num = (int)UnsafeNativeMethods.EventWriteString(m_regHandle, eventLevel, eventKeywords, message);
			}
			if (num != 0)
			{
				SetLastError(num);
				return false;
			}
		}
		return true;
	}

	public bool WriteMessageEvent(string eventMessage)
	{
		return WriteMessageEvent(eventMessage, 0, 0L);
	}

	[SecurityCritical]
	public unsafe bool WriteEvent(ref EventDescriptor eventDescriptor, params object[] eventPayload)
	{
		uint num = 0u;
		if (IsEnabled(eventDescriptor.Level, eventDescriptor.Keywords))
		{
			int num2 = 0;
			if (eventPayload != null && eventPayload.Length != 0 && eventPayload.Length != 1)
			{
				num2 = eventPayload.Length;
				if (num2 > 32)
				{
					throw new ArgumentOutOfRangeException("eventPayload", SR.GetString("ArgumentOutOfRange_MaxArgExceeded", 32));
				}
				uint num3 = 0u;
				int num4 = 0;
				int[] array = new int[8];
				string[] array2 = new string[8];
				EventData* ptr = (EventData*)stackalloc byte[sizeof(EventData) * num2];
				EventData* ptr2 = ptr;
				byte* ptr3 = stackalloc byte[16 * num2];
				byte* ptr4 = ptr3;
				for (int i = 0; i < eventPayload.Length; i++)
				{
					if (eventPayload[i] == null)
					{
						continue;
					}
					string text = EncodeObject(ref eventPayload[i], ptr2, ptr4);
					ptr4 += 16;
					num3 += ptr2->Size;
					ptr2++;
					if (text != null)
					{
						if (num4 >= 8)
						{
							throw new ArgumentOutOfRangeException("eventPayload", SR.GetString("ArgumentOutOfRange_MaxStringsExceeded", 8));
						}
						array2[num4] = text;
						array[num4] = i;
						num4++;
					}
				}
				if (num3 > 65482)
				{
					Thread.SetData(s_returnCodeSlot, 2);
					return false;
				}
				fixed (char* ptr5 = array2[0])
				{
					fixed (char* ptr6 = array2[1])
					{
						fixed (char* ptr7 = array2[2])
						{
							fixed (char* ptr8 = array2[3])
							{
								fixed (char* ptr9 = array2[4])
								{
									fixed (char* ptr10 = array2[5])
									{
										fixed (char* ptr11 = array2[6])
										{
											fixed (char* ptr12 = array2[7])
											{
												ptr2 = ptr;
												if (array2[0] != null)
												{
													ptr2[array[0]].DataPointer = (ulong)ptr5;
												}
												if (array2[1] != null)
												{
													ptr2[array[1]].DataPointer = (ulong)ptr6;
												}
												if (array2[2] != null)
												{
													ptr2[array[2]].DataPointer = (ulong)ptr7;
												}
												if (array2[3] != null)
												{
													ptr2[array[3]].DataPointer = (ulong)ptr8;
												}
												if (array2[4] != null)
												{
													ptr2[array[4]].DataPointer = (ulong)ptr9;
												}
												if (array2[5] != null)
												{
													ptr2[array[5]].DataPointer = (ulong)ptr10;
												}
												if (array2[6] != null)
												{
													ptr2[array[6]].DataPointer = (ulong)ptr11;
												}
												if (array2[7] != null)
												{
													ptr2[array[7]].DataPointer = (ulong)ptr12;
												}
												num = UnsafeNativeMethods.EventWrite(m_regHandle, ref eventDescriptor, (uint)num2, ptr);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				string text2 = null;
				byte* dataBuffer = stackalloc byte[16];
				EventData eventData = default(EventData);
				eventData.Size = 0u;
				if (eventPayload != null && eventPayload.Length != 0)
				{
					text2 = EncodeObject(ref eventPayload[0], &eventData, dataBuffer);
					num2 = 1;
				}
				if (eventData.Size > 65482)
				{
					Thread.SetData(s_returnCodeSlot, 2);
					return false;
				}
				if (text2 == null)
				{
					num = ((num2 != 0) ? UnsafeNativeMethods.EventWrite(m_regHandle, ref eventDescriptor, (uint)num2, &eventData) : UnsafeNativeMethods.EventWrite(m_regHandle, ref eventDescriptor, 0u, null));
				}
				else
				{
					fixed (char* ptr13 = text2)
					{
						eventData.DataPointer = (ulong)ptr13;
						num = UnsafeNativeMethods.EventWrite(m_regHandle, ref eventDescriptor, (uint)num2, &eventData);
					}
				}
			}
		}
		if (num != 0)
		{
			SetLastError((int)num);
			return false;
		}
		return true;
	}

	[SecurityCritical]
	public unsafe bool WriteEvent(ref EventDescriptor eventDescriptor, string data)
	{
		uint num = 0u;
		if (data == null)
		{
			throw new ArgumentNullException("dataString");
		}
		if (IsEnabled(eventDescriptor.Level, eventDescriptor.Keywords))
		{
			if (data.Length > 32724)
			{
				Thread.SetData(s_returnCodeSlot, 2);
				return false;
			}
			EventData eventData = default(EventData);
			eventData.Size = (uint)((data.Length + 1) * 2);
			eventData.Reserved = 0;
			fixed (char* ptr = data)
			{
				eventData.DataPointer = (ulong)ptr;
				num = UnsafeNativeMethods.EventWrite(m_regHandle, ref eventDescriptor, 1u, &eventData);
			}
		}
		if (num != 0)
		{
			SetLastError((int)num);
			return false;
		}
		return true;
	}

	[SecurityCritical]
	protected unsafe bool WriteEvent(ref EventDescriptor eventDescriptor, int dataCount, IntPtr data)
	{
		uint num = 0u;
		num = UnsafeNativeMethods.EventWrite(m_regHandle, ref eventDescriptor, (uint)dataCount, (void*)data);
		if (num != 0)
		{
			SetLastError((int)num);
			return false;
		}
		return true;
	}

	[SecurityCritical]
	public unsafe bool WriteTransferEvent(ref EventDescriptor eventDescriptor, Guid relatedActivityId, params object[] eventPayload)
	{
		uint num = 0u;
		if (IsEnabled(eventDescriptor.Level, eventDescriptor.Keywords))
		{
			Guid activityId = GetActivityId();
			if (eventPayload != null && eventPayload.Length != 0)
			{
				int num2 = eventPayload.Length;
				if (num2 > 32)
				{
					throw new ArgumentOutOfRangeException("eventPayload", SR.GetString("ArgumentOutOfRange_MaxArgExceeded", 32));
				}
				uint num3 = 0u;
				int num4 = 0;
				int[] array = new int[8];
				string[] array2 = new string[8];
				EventData* ptr = (EventData*)stackalloc byte[sizeof(EventData) * num2];
				EventData* ptr2 = ptr;
				byte* ptr3 = stackalloc byte[16 * num2];
				byte* ptr4 = ptr3;
				for (int i = 0; i < eventPayload.Length; i++)
				{
					if (eventPayload[i] == null)
					{
						continue;
					}
					string text = EncodeObject(ref eventPayload[i], ptr2, ptr4);
					ptr4 += 16;
					num3 += ptr2->Size;
					ptr2++;
					if (text != null)
					{
						if (num4 >= 8)
						{
							throw new ArgumentOutOfRangeException("eventPayload", SR.GetString("ArgumentOutOfRange_MaxStringsExceeded", 8));
						}
						array2[num4] = text;
						array[num4] = i;
						num4++;
					}
				}
				if (num3 > 65482)
				{
					Thread.SetData(s_returnCodeSlot, 2);
					return false;
				}
				fixed (char* ptr5 = array2[0])
				{
					fixed (char* ptr6 = array2[1])
					{
						fixed (char* ptr7 = array2[2])
						{
							fixed (char* ptr8 = array2[3])
							{
								fixed (char* ptr9 = array2[4])
								{
									fixed (char* ptr10 = array2[5])
									{
										fixed (char* ptr11 = array2[6])
										{
											fixed (char* ptr12 = array2[7])
											{
												ptr2 = ptr;
												if (array2[0] != null)
												{
													ptr2[array[0]].DataPointer = (ulong)ptr5;
												}
												if (array2[1] != null)
												{
													ptr2[array[1]].DataPointer = (ulong)ptr6;
												}
												if (array2[2] != null)
												{
													ptr2[array[2]].DataPointer = (ulong)ptr7;
												}
												if (array2[3] != null)
												{
													ptr2[array[3]].DataPointer = (ulong)ptr8;
												}
												if (array2[4] != null)
												{
													ptr2[array[4]].DataPointer = (ulong)ptr9;
												}
												if (array2[5] != null)
												{
													ptr2[array[5]].DataPointer = (ulong)ptr10;
												}
												if (array2[6] != null)
												{
													ptr2[array[6]].DataPointer = (ulong)ptr11;
												}
												if (array2[7] != null)
												{
													ptr2[array[7]].DataPointer = (ulong)ptr12;
												}
												num = UnsafeNativeMethods.EventWriteTransfer(m_regHandle, ref eventDescriptor, ref activityId, ref relatedActivityId, (uint)num2, ptr);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				num = UnsafeNativeMethods.EventWriteTransfer(m_regHandle, ref eventDescriptor, ref activityId, ref relatedActivityId, 0u, null);
			}
		}
		if (num != 0)
		{
			SetLastError((int)num);
			return false;
		}
		return true;
	}

	[SecurityCritical]
	protected unsafe bool WriteTransferEvent(ref EventDescriptor eventDescriptor, Guid relatedActivityId, int dataCount, IntPtr data)
	{
		uint num = 0u;
		Guid activityId = GetActivityId();
		num = UnsafeNativeMethods.EventWriteTransfer(m_regHandle, ref eventDescriptor, ref activityId, ref relatedActivityId, (uint)dataCount, (void*)data);
		if (num != 0)
		{
			SetLastError((int)num);
			return false;
		}
		return true;
	}

	[SecurityCritical]
	private static Guid GetActivityId()
	{
		object obj = Trace.CorrelationManager.ActivityId;
		if (obj != null)
		{
			return (Guid)obj;
		}
		return Guid.Empty;
	}

	[SecurityCritical]
	public static void SetActivityId(ref Guid id)
	{
		UnsafeNativeMethods.EventActivityIdControl(2, ref id);
	}

	[SecurityCritical]
	public static Guid CreateActivityId()
	{
		Guid ActivityId = default(Guid);
		UnsafeNativeMethods.EventActivityIdControl(3, ref ActivityId);
		return ActivityId;
	}
}
