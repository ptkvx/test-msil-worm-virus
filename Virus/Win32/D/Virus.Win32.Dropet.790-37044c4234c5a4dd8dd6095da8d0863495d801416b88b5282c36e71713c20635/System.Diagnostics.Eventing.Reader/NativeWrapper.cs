using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics.Eventing.Reader;

internal class NativeWrapper
{
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public class SystemProperties
	{
		public bool filled;

		public ushort? Id = null;

		public byte? Version = null;

		public ushort? Qualifiers = null;

		public byte? Level = null;

		public ushort? Task = null;

		public byte? Opcode = null;

		public ulong? Keywords = null;

		public ulong? RecordId = null;

		public string ProviderName;

		public Guid? ProviderId = null;

		public string ChannelName;

		public uint? ProcessId = null;

		public uint? ThreadId = null;

		public string ComputerName;

		public SecurityIdentifier UserId;

		public DateTime? TimeCreated = null;

		public Guid? ActivityId = null;

		public Guid? RelatedActivityId = null;
	}

	private static bool s_platformNotSupported = Environment.OSVersion.Version.Major < 6;

	[SecurityCritical]
	public static EventLogHandle EvtQuery(EventLogHandle session, string path, string query, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = UnsafeNativeMethods.EvtQuery(session, path, query, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static void EvtSeek(EventLogHandle resultSet, long position, EventLogHandle bookmark, int timeout, UnsafeNativeMethods.EvtSeekFlags flags)
	{
		bool flag = UnsafeNativeMethods.EvtSeek(resultSet, position, bookmark, timeout, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
	}

	[SecurityCritical]
	public static EventLogHandle EvtSubscribe(EventLogHandle session, SafeWaitHandle signalEvent, string path, string query, EventLogHandle bookmark, IntPtr context, IntPtr callback, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = UnsafeNativeMethods.EvtSubscribe(session, signalEvent, path, query, bookmark, context, callback, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static bool EvtNext(EventLogHandle queryHandle, int eventSize, IntPtr[] events, int timeout, int flags, ref int returned)
	{
		bool flag = UnsafeNativeMethods.EvtNext(queryHandle, eventSize, events, timeout, flags, ref returned);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag && lastWin32Error != 259)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return lastWin32Error == 0;
	}

	[SecurityTreatAsSafe]
	[SecurityCritical]
	public static void EvtCancel(EventLogHandle handle)
	{
		((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		if (!UnsafeNativeMethods.EvtCancel(handle))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			EventLogException.Throw(lastWin32Error);
		}
	}

	[SecurityCritical]
	public static void EvtClose(IntPtr handle)
	{
		UnsafeNativeMethods.EvtClose(handle);
	}

	[SecurityCritical]
	public static EventLogHandle EvtOpenProviderMetadata(EventLogHandle session, string ProviderId, string logFilePath, int locale, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = UnsafeNativeMethods.EvtOpenPublisherMetadata(session, ProviderId, logFilePath, locale, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static int EvtGetObjectArraySize(EventLogHandle objectArray)
	{
		int objectArraySize;
		bool flag = UnsafeNativeMethods.EvtGetObjectArraySize(objectArray, out objectArraySize);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return objectArraySize;
	}

	[SecurityCritical]
	public static EventLogHandle EvtOpenEventMetadataEnum(EventLogHandle ProviderMetadata, int flags)
	{
		EventLogHandle eventLogHandle = UnsafeNativeMethods.EvtOpenEventMetadataEnum(ProviderMetadata, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static EventLogHandle EvtNextEventMetadata(EventLogHandle eventMetadataEnum, int flags)
	{
		EventLogHandle eventLogHandle = UnsafeNativeMethods.EvtNextEventMetadata(eventMetadataEnum, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			if (lastWin32Error != 259)
			{
				EventLogException.Throw(lastWin32Error);
			}
			return null;
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static EventLogHandle EvtOpenChannelEnum(EventLogHandle session, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = UnsafeNativeMethods.EvtOpenChannelEnum(session, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static EventLogHandle EvtOpenProviderEnum(EventLogHandle session, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = UnsafeNativeMethods.EvtOpenPublisherEnum(session, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static EventLogHandle EvtOpenChannelConfig(EventLogHandle session, string channelPath, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = UnsafeNativeMethods.EvtOpenChannelConfig(session, channelPath, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	[SecurityTreatAsSafe]
	public static void EvtSaveChannelConfig(EventLogHandle channelConfig, int flags)
	{
		((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		bool flag = UnsafeNativeMethods.EvtSaveChannelConfig(channelConfig, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
	}

	[SecurityCritical]
	public static EventLogHandle EvtOpenLog(EventLogHandle session, string path, PathType flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = UnsafeNativeMethods.EvtOpenLog(session, path, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	[SecurityTreatAsSafe]
	public static void EvtExportLog(EventLogHandle session, string channelPath, string query, string targetFilePath, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		bool flag = UnsafeNativeMethods.EvtExportLog(session, channelPath, query, targetFilePath, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
	}

	[SecurityTreatAsSafe]
	[SecurityCritical]
	public static void EvtArchiveExportedLog(EventLogHandle session, string logFilePath, int locale, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		bool flag = UnsafeNativeMethods.EvtArchiveExportedLog(session, logFilePath, locale, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
	}

	[SecurityTreatAsSafe]
	[SecurityCritical]
	public static void EvtClearLog(EventLogHandle session, string channelPath, string targetFilePath, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		bool flag = UnsafeNativeMethods.EvtClearLog(session, channelPath, targetFilePath, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
	}

	[SecurityCritical]
	public static EventLogHandle EvtCreateRenderContext(int valuePathsCount, string[] valuePaths, UnsafeNativeMethods.EvtRenderContextFlags flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = UnsafeNativeMethods.EvtCreateRenderContext(valuePathsCount, valuePaths, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static void EvtRender(EventLogHandle context, EventLogHandle eventHandle, UnsafeNativeMethods.EvtRenderFlags flags, StringBuilder buffer)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		int buffUsed;
		int propCount;
		bool flag = UnsafeNativeMethods.EvtRender(context, eventHandle, flags, buffer.Capacity, buffer, out buffUsed, out propCount);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			if (lastWin32Error == 122)
			{
				buffer.Capacity = buffUsed;
				flag = UnsafeNativeMethods.EvtRender(context, eventHandle, flags, buffer.Capacity, buffer, out buffUsed, out propCount);
				lastWin32Error = Marshal.GetLastWin32Error();
			}
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
		}
	}

	[SecurityCritical]
	public static EventLogHandle EvtOpenSession(UnsafeNativeMethods.EvtLoginClass loginClass, ref UnsafeNativeMethods.EvtRpcLogin login, int timeout, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = UnsafeNativeMethods.EvtOpenSession(loginClass, ref login, timeout, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static EventLogHandle EvtCreateBookmark(string bookmarkXml)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = UnsafeNativeMethods.EvtCreateBookmark(bookmarkXml);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static void EvtUpdateBookmark(EventLogHandle bookmark, EventLogHandle eventHandle)
	{
		bool flag = UnsafeNativeMethods.EvtUpdateBookmark(bookmark, eventHandle);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
	}

	[SecurityCritical]
	[SecurityTreatAsSafe]
	public static object EvtGetEventInfo(EventLogHandle handle, UnsafeNativeMethods.EvtEventPropertyId enumType)
	{
		IntPtr intPtr = IntPtr.Zero;
		((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		try
		{
			bool flag = UnsafeNativeMethods.EvtGetEventInfo(handle, enumType, 0, IntPtr.Zero, out var bufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 0 && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(bufferUsed);
			flag = UnsafeNativeMethods.EvtGetEventInfo(handle, enumType, bufferUsed, intPtr, out bufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			UnsafeNativeMethods.EvtVariant val = (UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(UnsafeNativeMethods.EvtVariant));
			return ConvertToObject(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityCritical]
	public static object EvtGetQueryInfo(EventLogHandle handle, UnsafeNativeMethods.EvtQueryPropertyId enumType)
	{
		IntPtr intPtr = IntPtr.Zero;
		int bufferRequired = 0;
		try
		{
			bool flag = UnsafeNativeMethods.EvtGetQueryInfo(handle, enumType, 0, IntPtr.Zero, ref bufferRequired);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(bufferRequired);
			flag = UnsafeNativeMethods.EvtGetQueryInfo(handle, enumType, bufferRequired, intPtr, ref bufferRequired);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			UnsafeNativeMethods.EvtVariant val = (UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(UnsafeNativeMethods.EvtVariant));
			return ConvertToObject(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityTreatAsSafe]
	[SecurityCritical]
	public static object EvtGetPublisherMetadataProperty(EventLogHandle pmHandle, UnsafeNativeMethods.EvtPublisherMetadataPropertyId thePropertyId)
	{
		IntPtr intPtr = IntPtr.Zero;
		((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		try
		{
			bool flag = UnsafeNativeMethods.EvtGetPublisherMetadataProperty(pmHandle, thePropertyId, 0, 0, IntPtr.Zero, out var publisherMetadataPropertyBufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(publisherMetadataPropertyBufferUsed);
			flag = UnsafeNativeMethods.EvtGetPublisherMetadataProperty(pmHandle, thePropertyId, 0, publisherMetadataPropertyBufferUsed, intPtr, out publisherMetadataPropertyBufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			UnsafeNativeMethods.EvtVariant val = (UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(UnsafeNativeMethods.EvtVariant));
			return ConvertToObject(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityCritical]
	internal static EventLogHandle EvtGetPublisherMetadataPropertyHandle(EventLogHandle pmHandle, UnsafeNativeMethods.EvtPublisherMetadataPropertyId thePropertyId)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			bool flag = UnsafeNativeMethods.EvtGetPublisherMetadataProperty(pmHandle, thePropertyId, 0, 0, IntPtr.Zero, out var publisherMetadataPropertyBufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(publisherMetadataPropertyBufferUsed);
			flag = UnsafeNativeMethods.EvtGetPublisherMetadataProperty(pmHandle, thePropertyId, 0, publisherMetadataPropertyBufferUsed, intPtr, out publisherMetadataPropertyBufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			UnsafeNativeMethods.EvtVariant val = (UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(UnsafeNativeMethods.EvtVariant));
			return ConvertToSafeHandle(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityCritical]
	public static string EvtFormatMessage(EventLogHandle handle, uint msgId)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		StringBuilder stringBuilder = new StringBuilder(null);
		bool flag = UnsafeNativeMethods.EvtFormatMessage(handle, EventLogHandle.Zero, msgId, 0, null, UnsafeNativeMethods.EvtFormatMessageFlags.EvtFormatMessageId, 0, stringBuilder, out var bufferUsed);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			switch (lastWin32Error)
			{
			case 15027:
				return null;
			default:
				EventLogException.Throw(lastWin32Error);
				break;
			case 122:
			case 15029:
				break;
			}
		}
		stringBuilder.EnsureCapacity(bufferUsed);
		flag = UnsafeNativeMethods.EvtFormatMessage(handle, EventLogHandle.Zero, msgId, 0, null, UnsafeNativeMethods.EvtFormatMessageFlags.EvtFormatMessageId, bufferUsed, stringBuilder, out bufferUsed);
		lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			switch (lastWin32Error)
			{
			case 15027:
				return null;
			default:
				if (lastWin32Error == 15029)
				{
					return null;
				}
				EventLogException.Throw(lastWin32Error);
				break;
			case 15029:
				break;
			}
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	public static object EvtGetObjectArrayProperty(EventLogHandle objArrayHandle, int index, int thePropertyId)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			bool flag = UnsafeNativeMethods.EvtGetObjectArrayProperty(objArrayHandle, thePropertyId, index, 0, 0, IntPtr.Zero, out var propertyValueBufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(propertyValueBufferUsed);
			flag = UnsafeNativeMethods.EvtGetObjectArrayProperty(objArrayHandle, thePropertyId, index, 0, propertyValueBufferUsed, intPtr, out propertyValueBufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			UnsafeNativeMethods.EvtVariant val = (UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(UnsafeNativeMethods.EvtVariant));
			return ConvertToObject(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityCritical]
	public static object EvtGetEventMetadataProperty(EventLogHandle handle, UnsafeNativeMethods.EvtEventMetadataPropertyId enumType)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			bool flag = UnsafeNativeMethods.EvtGetEventMetadataProperty(handle, enumType, 0, 0, IntPtr.Zero, out var eventMetadataPropertyBufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(eventMetadataPropertyBufferUsed);
			flag = UnsafeNativeMethods.EvtGetEventMetadataProperty(handle, enumType, 0, eventMetadataPropertyBufferUsed, intPtr, out eventMetadataPropertyBufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			UnsafeNativeMethods.EvtVariant val = (UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(UnsafeNativeMethods.EvtVariant));
			return ConvertToObject(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityCritical]
	[SecurityTreatAsSafe]
	public static object EvtGetChannelConfigProperty(EventLogHandle handle, UnsafeNativeMethods.EvtChannelConfigPropertyId enumType)
	{
		IntPtr intPtr = IntPtr.Zero;
		((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		try
		{
			bool flag = UnsafeNativeMethods.EvtGetChannelConfigProperty(handle, enumType, 0, 0, IntPtr.Zero, out var propertyValueBufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(propertyValueBufferUsed);
			flag = UnsafeNativeMethods.EvtGetChannelConfigProperty(handle, enumType, 0, propertyValueBufferUsed, intPtr, out propertyValueBufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			UnsafeNativeMethods.EvtVariant val = (UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(UnsafeNativeMethods.EvtVariant));
			return ConvertToObject(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityTreatAsSafe]
	[SecurityCritical]
	public static void EvtSetChannelConfigProperty(EventLogHandle handle, UnsafeNativeMethods.EvtChannelConfigPropertyId enumType, object val)
	{
		((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		UnsafeNativeMethods.EvtVariant propertyValue = default(UnsafeNativeMethods.EvtVariant);
		CoTaskMemSafeHandle coTaskMemSafeHandle = new CoTaskMemSafeHandle();
		using (coTaskMemSafeHandle)
		{
			if (val != null)
			{
				switch (enumType)
				{
				case UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigEnabled:
					propertyValue.Type = 13u;
					if ((bool)val)
					{
						propertyValue.Bool = 1u;
					}
					else
					{
						propertyValue.Bool = 0u;
					}
					break;
				default:
					throw new InvalidOperationException();
				case UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigAccess:
					propertyValue.Type = 1u;
					coTaskMemSafeHandle.SetMemory(Marshal.StringToCoTaskMemAuto((string)val));
					propertyValue.StringVal = coTaskMemSafeHandle.GetMemory();
					break;
				case UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigRetention:
					propertyValue.Type = 13u;
					if ((bool)val)
					{
						propertyValue.Bool = 1u;
					}
					else
					{
						propertyValue.Bool = 0u;
					}
					break;
				case UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigAutoBackup:
					propertyValue.Type = 13u;
					if ((bool)val)
					{
						propertyValue.Bool = 1u;
					}
					else
					{
						propertyValue.Bool = 0u;
					}
					break;
				case UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigMaxSize:
					propertyValue.Type = 10u;
					propertyValue.ULong = (ulong)(long)val;
					break;
				case UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigLogFilePath:
					propertyValue.Type = 1u;
					coTaskMemSafeHandle.SetMemory(Marshal.StringToCoTaskMemAuto((string)val));
					propertyValue.StringVal = coTaskMemSafeHandle.GetMemory();
					break;
				case UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigLevel:
					propertyValue.Type = 8u;
					propertyValue.UInteger = (uint)(int)val;
					break;
				case UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigKeywords:
					propertyValue.Type = 10u;
					propertyValue.ULong = (ulong)(long)val;
					break;
				}
			}
			else
			{
				propertyValue.Type = 0u;
			}
			bool flag = UnsafeNativeMethods.EvtSetChannelConfigProperty(handle, enumType, 0, ref propertyValue);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
		}
	}

	[SecurityCritical]
	public static string EvtNextChannelPath(EventLogHandle handle, ref bool finish)
	{
		StringBuilder stringBuilder = new StringBuilder(null);
		bool flag = UnsafeNativeMethods.EvtNextChannelPath(handle, 0, stringBuilder, out var channelPathBufferUsed);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			switch (lastWin32Error)
			{
			case 259:
				finish = true;
				return null;
			default:
				EventLogException.Throw(lastWin32Error);
				break;
			case 122:
				break;
			}
		}
		stringBuilder.EnsureCapacity(channelPathBufferUsed);
		flag = UnsafeNativeMethods.EvtNextChannelPath(handle, channelPathBufferUsed, stringBuilder, out channelPathBufferUsed);
		lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	public static string EvtNextPublisherId(EventLogHandle handle, ref bool finish)
	{
		StringBuilder stringBuilder = new StringBuilder(null);
		bool flag = UnsafeNativeMethods.EvtNextPublisherId(handle, 0, stringBuilder, out var publisherIdBufferUsed);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			switch (lastWin32Error)
			{
			case 259:
				finish = true;
				return null;
			default:
				EventLogException.Throw(lastWin32Error);
				break;
			case 122:
				break;
			}
		}
		stringBuilder.EnsureCapacity(publisherIdBufferUsed);
		flag = UnsafeNativeMethods.EvtNextPublisherId(handle, publisherIdBufferUsed, stringBuilder, out publisherIdBufferUsed);
		lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	public static object EvtGetLogInfo(EventLogHandle handle, UnsafeNativeMethods.EvtLogPropertyId enumType)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			bool flag = UnsafeNativeMethods.EvtGetLogInfo(handle, enumType, 0, IntPtr.Zero, out var propertyValueBufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(propertyValueBufferUsed);
			flag = UnsafeNativeMethods.EvtGetLogInfo(handle, enumType, propertyValueBufferUsed, intPtr, out propertyValueBufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			UnsafeNativeMethods.EvtVariant val = (UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(UnsafeNativeMethods.EvtVariant));
			return ConvertToObject(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityCritical]
	[SecurityTreatAsSafe]
	public static void EvtRenderBufferWithContextSystem(EventLogHandle contextHandle, EventLogHandle eventHandle, UnsafeNativeMethods.EvtRenderFlags flag, SystemProperties systemProperties, int SYSTEM_PROPERTY_COUNT)
	{
		IntPtr intPtr = IntPtr.Zero;
		IntPtr zero = IntPtr.Zero;
		((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		try
		{
			bool flag2;
			if (!(flag2 = UnsafeNativeMethods.EvtRender(contextHandle, eventHandle, flag, 0, IntPtr.Zero, out var buffUsed, out var propCount)))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error != 122)
				{
					EventLogException.Throw(lastWin32Error);
				}
			}
			intPtr = Marshal.AllocHGlobal(buffUsed);
			flag2 = UnsafeNativeMethods.EvtRender(contextHandle, eventHandle, flag, buffUsed, intPtr, out buffUsed, out propCount);
			int lastWin32Error2 = Marshal.GetLastWin32Error();
			if (!flag2)
			{
				EventLogException.Throw(lastWin32Error2);
			}
			if (propCount != SYSTEM_PROPERTY_COUNT)
			{
				throw new InvalidOperationException("We do not have " + SYSTEM_PROPERTY_COUNT + " variants given for the  UnsafeNativeMethods.EvtRenderFlags.EvtRenderEventValues flag. (System Properties)");
			}
			zero = intPtr;
			for (int i = 0; i < propCount; i++)
			{
				UnsafeNativeMethods.EvtVariant evtVariant = (UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(zero, typeof(UnsafeNativeMethods.EvtVariant));
				switch (i)
				{
				case 0:
					systemProperties.ProviderName = (string)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeString);
					break;
				case 1:
					systemProperties.ProviderId = (Guid?)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeGuid);
					break;
				case 2:
					systemProperties.Id = (ushort?)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeUInt16);
					break;
				case 3:
					systemProperties.Qualifiers = (ushort?)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeUInt16);
					break;
				case 4:
					systemProperties.Level = (byte?)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeByte);
					break;
				case 5:
					systemProperties.Task = (ushort?)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeUInt16);
					break;
				case 6:
					systemProperties.Opcode = (byte?)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeByte);
					break;
				case 7:
					systemProperties.Keywords = (ulong?)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeHexInt64);
					break;
				case 8:
					systemProperties.TimeCreated = (DateTime?)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeFileTime);
					break;
				case 9:
					systemProperties.RecordId = (ulong?)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeUInt64);
					break;
				case 10:
					systemProperties.ActivityId = (Guid?)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeGuid);
					break;
				case 11:
					systemProperties.RelatedActivityId = (Guid?)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeGuid);
					break;
				case 12:
					systemProperties.ProcessId = (uint?)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeUInt32);
					break;
				case 13:
					systemProperties.ThreadId = (uint?)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeUInt32);
					break;
				case 14:
					systemProperties.ChannelName = (string)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeString);
					break;
				case 15:
					systemProperties.ComputerName = (string)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeString);
					break;
				case 16:
					systemProperties.UserId = (SecurityIdentifier)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeSid);
					break;
				case 17:
					systemProperties.Version = (byte?)ConvertToObject(evtVariant, UnsafeNativeMethods.EvtVariantType.EvtVarTypeByte);
					break;
				}
				zero = new IntPtr((long)zero + Marshal.SizeOf((object)evtVariant));
			}
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityCritical]
	[SecurityTreatAsSafe]
	public static IList<object> EvtRenderBufferWithContextUserOrValues(EventLogHandle contextHandle, EventLogHandle eventHandle)
	{
		IntPtr intPtr = IntPtr.Zero;
		IntPtr zero = IntPtr.Zero;
		UnsafeNativeMethods.EvtRenderFlags flags = UnsafeNativeMethods.EvtRenderFlags.EvtRenderEventValues;
		((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		try
		{
			bool flag;
			if (!(flag = UnsafeNativeMethods.EvtRender(contextHandle, eventHandle, flags, 0, IntPtr.Zero, out var buffUsed, out var propCount)))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error != 122)
				{
					EventLogException.Throw(lastWin32Error);
				}
			}
			intPtr = Marshal.AllocHGlobal(buffUsed);
			flag = UnsafeNativeMethods.EvtRender(contextHandle, eventHandle, flags, buffUsed, intPtr, out buffUsed, out propCount);
			int lastWin32Error2 = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error2);
			}
			List<object> list = new List<object>(propCount);
			if (propCount > 0)
			{
				zero = intPtr;
				for (int i = 0; i < propCount; i++)
				{
					UnsafeNativeMethods.EvtVariant evtVariant = (UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(zero, typeof(UnsafeNativeMethods.EvtVariant));
					list.Add(ConvertToObject(evtVariant));
					zero = new IntPtr((long)zero + Marshal.SizeOf((object)evtVariant));
				}
			}
			return list;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityCritical]
	[SecurityTreatAsSafe]
	public static string EvtFormatMessageRenderName(EventLogHandle pmHandle, EventLogHandle eventHandle, UnsafeNativeMethods.EvtFormatMessageFlags flag)
	{
		((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		StringBuilder stringBuilder = new StringBuilder(null);
		bool flag2 = UnsafeNativeMethods.EvtFormatMessage(pmHandle, eventHandle, 0u, 0, null, flag, 0, stringBuilder, out var bufferUsed);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag2 && lastWin32Error != 15029)
		{
			switch (lastWin32Error)
			{
			case 1815:
			case 15027:
			case 15028:
			case 15033:
			case 15100:
				return null;
			}
			if (lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
		}
		stringBuilder.EnsureCapacity(bufferUsed);
		flag2 = UnsafeNativeMethods.EvtFormatMessage(pmHandle, eventHandle, 0u, 0, null, flag, bufferUsed, stringBuilder, out bufferUsed);
		lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag2 && lastWin32Error != 15029)
		{
			switch (lastWin32Error)
			{
			case 1815:
			case 15027:
			case 15028:
			case 15033:
			case 15100:
				return null;
			}
			EventLogException.Throw(lastWin32Error);
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	[SecurityTreatAsSafe]
	public static IEnumerable<string> EvtFormatMessageRenderKeywords(EventLogHandle pmHandle, EventLogHandle eventHandle, UnsafeNativeMethods.EvtFormatMessageFlags flag)
	{
		((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			List<string> list = new List<string>();
			bool flag2 = UnsafeNativeMethods.EvtFormatMessage_1(pmHandle, eventHandle, 0u, 0, IntPtr.Zero, flag, 0, IntPtr.Zero, out var bufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag2)
			{
				switch (lastWin32Error)
				{
				case 1815:
				case 15027:
				case 15028:
				case 15033:
				case 15100:
					return list.AsReadOnly();
				}
				if (lastWin32Error != 122)
				{
					EventLogException.Throw(lastWin32Error);
				}
			}
			intPtr = Marshal.AllocHGlobal(bufferUsed * 2);
			flag2 = UnsafeNativeMethods.EvtFormatMessage_1(pmHandle, eventHandle, 0u, 0, IntPtr.Zero, flag, bufferUsed, intPtr, out bufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag2)
			{
				switch (lastWin32Error)
				{
				case 1815:
				case 15027:
				case 15028:
				case 15033:
				case 15100:
					return list;
				}
				EventLogException.Throw(lastWin32Error);
			}
			IntPtr intPtr2 = intPtr;
			while (true)
			{
				string text = Marshal.PtrToStringAuto(intPtr2);
				if (string.IsNullOrEmpty(text))
				{
					break;
				}
				list.Add(text);
				intPtr2 = new IntPtr((long)intPtr2 + text.Length * 2 + 2L);
			}
			return list.AsReadOnly();
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityCritical]
	public static string EvtRenderBookmark(EventLogHandle eventHandle)
	{
		IntPtr intPtr = IntPtr.Zero;
		UnsafeNativeMethods.EvtRenderFlags flags = UnsafeNativeMethods.EvtRenderFlags.EvtRenderBookmark;
		try
		{
			bool flag = UnsafeNativeMethods.EvtRender(EventLogHandle.Zero, eventHandle, flags, 0, IntPtr.Zero, out var buffUsed, out var propCount);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(buffUsed);
			flag = UnsafeNativeMethods.EvtRender(EventLogHandle.Zero, eventHandle, flags, buffUsed, intPtr, out buffUsed, out propCount);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			return Marshal.PtrToStringAuto(intPtr);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityCritical]
	[SecurityTreatAsSafe]
	public static string EvtFormatMessageFormatDescription(EventLogHandle handle, EventLogHandle eventHandle, string[] values)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		UnsafeNativeMethods.EvtStringVariant[] array = new UnsafeNativeMethods.EvtStringVariant[values.Length];
		for (int i = 0; i < values.Length; i++)
		{
			array[i].Type = 1u;
			array[i].StringVal = values[i];
		}
		StringBuilder stringBuilder = new StringBuilder(null);
		bool flag = UnsafeNativeMethods.EvtFormatMessage(handle, eventHandle, uint.MaxValue, values.Length, array, UnsafeNativeMethods.EvtFormatMessageFlags.EvtFormatMessageEvent, 0, stringBuilder, out var bufferUsed);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag && lastWin32Error != 15029)
		{
			switch (lastWin32Error)
			{
			case 1815:
			case 15027:
			case 15028:
			case 15033:
			case 15100:
				return null;
			}
			if (lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
		}
		stringBuilder.EnsureCapacity(bufferUsed);
		flag = UnsafeNativeMethods.EvtFormatMessage(handle, eventHandle, uint.MaxValue, values.Length, array, UnsafeNativeMethods.EvtFormatMessageFlags.EvtFormatMessageEvent, bufferUsed, stringBuilder, out bufferUsed);
		lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			switch (lastWin32Error)
			{
			case 15027:
				return null;
			default:
				EventLogException.Throw(lastWin32Error);
				break;
			case 15029:
				break;
			}
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	private static object ConvertToObject(UnsafeNativeMethods.EvtVariant val)
	{
		switch (val.Type)
		{
		case 136u:
			return ConvertToIntArray(val);
		case 129u:
			return ConvertToStringArray(val);
		case 0u:
			return null;
		case 1u:
			return ConvertToString(val);
		case 2u:
			return ConvertToAnsiString(val);
		case 3u:
			return val.SByte;
		case 4u:
			return val.UInt8;
		case 5u:
			return val.SByte;
		case 6u:
			return val.UShort;
		case 7u:
			return val.Integer;
		case 8u:
			return val.UInteger;
		case 9u:
			return val.Long;
		case 10u:
			return val.ULong;
		case 12u:
			return val.Double;
		case 13u:
			if (val.Bool != 0)
			{
				return true;
			}
			return false;
		case 14u:
			return ConvertToBinaryArray(val);
		case 15u:
			return ConvertToGuid(val);
		case 17u:
			return ConvertFileTimeToDateTime(val);
		case 19u:
			return ConvertToSid(val);
		case 20u:
			return val.Integer;
		case 21u:
			return val.ULong;
		default:
			throw new EventLogInvalidDataException();
		case 32u:
			return ConvertToSafeHandle(val);
		}
	}

	[SecurityCritical]
	public static object ConvertToObject(UnsafeNativeMethods.EvtVariant val, UnsafeNativeMethods.EvtVariantType desiredType)
	{
		if (val.Type == 0)
		{
			return null;
		}
		if ((ulong)val.Type != (ulong)desiredType)
		{
			throw new EventLogInvalidDataException();
		}
		return ConvertToObject(val);
	}

	[SecurityCritical]
	public static string ConvertToString(UnsafeNativeMethods.EvtVariant val)
	{
		if (val.Type != 1)
		{
			throw new EventLogInvalidDataException();
		}
		if (val.StringVal == IntPtr.Zero)
		{
			return string.Empty;
		}
		return Marshal.PtrToStringAuto(val.StringVal);
	}

	[SecurityCritical]
	public static string ConvertToAnsiString(UnsafeNativeMethods.EvtVariant val)
	{
		if (val.Type != 2)
		{
			throw new EventLogInvalidDataException();
		}
		if (val.AnsiString == IntPtr.Zero)
		{
			return string.Empty;
		}
		return Marshal.PtrToStringAuto(val.AnsiString);
	}

	[SecurityCritical]
	public static SecurityIdentifier ConvertToSid(UnsafeNativeMethods.EvtVariant val)
	{
		if (val.Type != 19)
		{
			throw new EventLogInvalidDataException();
		}
		if (val.SidVal == IntPtr.Zero)
		{
			return null;
		}
		return new SecurityIdentifier(val.SidVal);
	}

	[SecurityCritical]
	public static Guid ConvertToGuid(UnsafeNativeMethods.EvtVariant val)
	{
		if (val.Type != 15)
		{
			throw new EventLogInvalidDataException();
		}
		if (val.GuidReference == IntPtr.Zero)
		{
			return Guid.Empty;
		}
		return (Guid)Marshal.PtrToStructure(val.GuidReference, typeof(Guid));
	}

	[SecurityCritical]
	public static DateTime ConvertFileTimeToDateTime(UnsafeNativeMethods.EvtVariant val)
	{
		if (val.Type != 17)
		{
			throw new EventLogInvalidDataException();
		}
		return DateTime.FromFileTime((long)val.FileTime);
	}

	[SecurityCritical]
	public static EventLogHandle ConvertToSafeHandle(UnsafeNativeMethods.EvtVariant val)
	{
		if (val.Type != 32)
		{
			throw new EventLogInvalidDataException();
		}
		if (val.Handle == IntPtr.Zero)
		{
			return EventLogHandle.Zero;
		}
		return new EventLogHandle(val.Handle, ownsHandle: true);
	}

	[SecurityCritical]
	public static int[] ConvertToIntArray(UnsafeNativeMethods.EvtVariant val)
	{
		if (val.Type != 136)
		{
			throw new EventLogInvalidDataException();
		}
		if (val.Reference == IntPtr.Zero)
		{
			return new int[0];
		}
		IntPtr reference = val.Reference;
		int[] array = new int[val.Count];
		Marshal.Copy(reference, array, 0, (int)val.Count);
		return array;
	}

	[SecurityCritical]
	public static byte[] ConvertToBinaryArray(UnsafeNativeMethods.EvtVariant val)
	{
		if (val.Type != 14)
		{
			throw new EventLogInvalidDataException();
		}
		if (val.Binary == IntPtr.Zero)
		{
			return new byte[0];
		}
		IntPtr binary = val.Binary;
		byte[] array = new byte[val.Count];
		Marshal.Copy(binary, array, 0, (int)val.Count);
		return array;
	}

	[SecurityCritical]
	public static string[] ConvertToStringArray(UnsafeNativeMethods.EvtVariant val)
	{
		if (val.Type != 129)
		{
			throw new EventLogInvalidDataException();
		}
		if (val.Reference == IntPtr.Zero)
		{
			return new string[0];
		}
		IntPtr reference = val.Reference;
		IntPtr[] array = new IntPtr[val.Count];
		Marshal.Copy(reference, array, 0, (int)val.Count);
		string[] array2 = new string[val.Count];
		for (int i = 0; i < val.Count; i++)
		{
			array2[i] = Marshal.PtrToStringAuto(array[i]);
		}
		return array2;
	}
}
