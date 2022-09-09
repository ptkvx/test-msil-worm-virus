using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class EventLogConfiguration : IDisposable
{
	private EventLogHandle handle = EventLogHandle.Zero;

	private EventLogSession session;

	private string channelName;

	public string LogName => channelName;

	public EventLogType LogType => (EventLogType)(uint)NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigType);

	public EventLogIsolation LogIsolation => (EventLogIsolation)(uint)NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigIsolation);

	public bool IsEnabled
	{
		get
		{
			return (bool)NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigEnabled);
		}
		set
		{
			NativeWrapper.EvtSetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigEnabled, value);
		}
	}

	public bool IsClassicLog => (bool)NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigClassicEventlog);

	public string SecurityDescriptor
	{
		get
		{
			return (string)NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigAccess);
		}
		set
		{
			NativeWrapper.EvtSetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigAccess, value);
		}
	}

	public string LogFilePath
	{
		get
		{
			return (string)NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigLogFilePath);
		}
		set
		{
			NativeWrapper.EvtSetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigLogFilePath, value);
		}
	}

	public long MaximumSizeInBytes
	{
		get
		{
			return (long)(ulong)NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigMaxSize);
		}
		set
		{
			NativeWrapper.EvtSetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigMaxSize, value);
		}
	}

	public EventLogMode LogMode
	{
		get
		{
			object obj = NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigRetention);
			object obj2 = NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigAutoBackup);
			bool flag = obj != null && (bool)obj;
			if (obj2 != null && (bool)obj2)
			{
				return EventLogMode.AutoBackup;
			}
			if (flag)
			{
				return EventLogMode.Retain;
			}
			return EventLogMode.Circular;
		}
		set
		{
			switch (value)
			{
			case EventLogMode.Circular:
				NativeWrapper.EvtSetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigAutoBackup, false);
				NativeWrapper.EvtSetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigRetention, false);
				break;
			case EventLogMode.AutoBackup:
				NativeWrapper.EvtSetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigAutoBackup, true);
				NativeWrapper.EvtSetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigRetention, true);
				break;
			case EventLogMode.Retain:
				NativeWrapper.EvtSetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigAutoBackup, false);
				NativeWrapper.EvtSetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigRetention, true);
				break;
			}
		}
	}

	public string OwningProviderName => (string)NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigOwningPublisher);

	public IEnumerable<string> ProviderNames => (string[])NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublisherList);

	public int? ProviderLevel
	{
		get
		{
			return (int?)(uint?)NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigLevel);
		}
		set
		{
			NativeWrapper.EvtSetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigLevel, value);
		}
	}

	public long? ProviderKeywords
	{
		get
		{
			return (long?)(ulong?)NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigKeywords);
		}
		set
		{
			NativeWrapper.EvtSetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigKeywords, value);
		}
	}

	public int? ProviderBufferSize => (int?)(uint?)NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigBufferSize);

	public int? ProviderMinimumNumberOfBuffers => (int?)(uint?)NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigMinBuffers);

	public int? ProviderMaximumNumberOfBuffers => (int?)(uint?)NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigMaxBuffers);

	public int? ProviderLatency => (int?)(uint?)NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigLatency);

	public Guid? ProviderControlGuid => (Guid?)NativeWrapper.EvtGetChannelConfigProperty(handle, UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigControlGuid);

	public EventLogConfiguration(string logName)
		: this(logName, null)
	{
	}

	[SecurityCritical]
	public EventLogConfiguration(string logName, EventLogSession session)
	{
		((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		if (session == null)
		{
			session = EventLogSession.GlobalSession;
		}
		this.session = session;
		channelName = logName;
		handle = NativeWrapper.EvtOpenChannelConfig(this.session.Handle, channelName, 0);
	}

	public void SaveChanges()
	{
		NativeWrapper.EvtSaveChannelConfig(handle, 0);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[SecurityCritical]
	[SecurityTreatAsSafe]
	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			((CodeAccessPermission)EventLogPermissionHolder.GetEventLogPermission()).Demand();
		}
		if (handle != null && !handle.IsInvalid)
		{
			handle.Dispose();
		}
	}
}
