using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using ATL;
using Microsoft.MediaCenter.TV.Tuning;
using msclr;

namespace Microsoft.MediaCenter.TV.Tuners;

public class Tuner : MTASafeComWrapper
{
	public class TunerNotificationEventArgs1<A1> : EventArgs
	{
		public A1 a1;

		public TunerNotificationEventArgs1()
		{
		}

		public TunerNotificationEventArgs1(A1 a1i)
		{
			a1 = a1i;
			base._002Ector();
		}
	}

	public class TunerNotificationEventArgs2<A1, A2> : EventArgs
	{
		public A1 a1;

		public A2 a2;

		public TunerNotificationEventArgs2()
		{
		}

		public TunerNotificationEventArgs2(A1 a1i, A2 a2i)
		{
			a1 = a1i;
			a2 = a2i;
			base._002Ector();
		}
	}

	public class TunerNotificationEventArgs3<A1, A2, A3> : EventArgs
	{
		public A1 a1;

		public A2 a2;

		public A3 a3;

		public TunerNotificationEventArgs3()
		{
		}

		public TunerNotificationEventArgs3(A1 a1i, A2 a2i, A3 a3i)
		{
			a1 = a1i;
			a2 = a2i;
			a3 = a3i;
			base._002Ector();
		}
	}

	public class TunerNotificationEventArgs6<A1, A2, A3, A4, A5, A6> : EventArgs
	{
		public A1 a1;

		public A2 a2;

		public A3 a3;

		public A4 a4;

		public A5 a5;

		public A6 a6;

		public TunerNotificationEventArgs6()
		{
		}

		public TunerNotificationEventArgs6(A1 a1i, A2 a2i, A3 a3i, A4 a4i, A5 a5i, A6 a6i)
		{
			a1 = a1i;
			a2 = a2i;
			a3 = a3i;
			a4 = a4i;
			a5 = a5i;
			a6 = a6i;
			base._002Ector();
		}
	}

	public struct Evt<A1> where A1 : EventArgs
	{
		private EventHandler<A1> _event;

		[SpecialName]
		public event EventHandler<A1> Event
		{
			add
			{
				_event = (EventHandler<A1>)Delegate.Combine(_event, value);
			}
			remove
			{
				_event = (EventHandler<A1>)Delegate.Remove(_event, value);
			}
		}

		[SpecialName]
		public void raise_Event(object sender, A1 e)
		{
			_event?.Invoke(sender, e);
		}
	}

	private string _profile;

	private static int s_nextInstanceLabel = 0;

	private int _instanceLabel;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs2<Guid, ESEvent>> ESEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs1<string>> ProfileChangedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs1<bool>> UsageChangedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs2<uint, uint>> EncoderSettingsChangedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs1<TuneRequest>> TuningChangedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs1<int>> ErrorEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs2<ushort, ushort>> StateChangedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs1<bool>> ReadyEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs1<bool>> CertificateEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs1<bool>> EncryptionEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<EventArgs> WriteFailureEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs1<int>> ContentSIIDChangedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs3<RecorderStreamType, RecorderBitRateChangeType, ulong>> BitRateChangedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs1<bool>> ChannelAvailableEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<EventArgs> StatusChangedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs6<EnTvRat_System, EnTvRat_GenericLevel, BfEnTvRat_GenericAttributes, EnTvRat_System, EnTvRat_GenericLevel, BfEnTvRat_GenericAttributes>> RatingChangedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs1<ProtType>> ProtectionTypeChangedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs2<uint, EasPriorityType>> EasReceivedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs2<bool, uint>> MMIReceivedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs1<CasCardStatusType>> CasCardStatusChangedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs1<DrmPairingStatus>> DrmPairingStatusChangedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs1<CasEntitlementType>> CasEntitlementChangedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<EventArgs> WriteFailureClearEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Evt<TunerNotificationEventArgs1<SignalAndServiceStatusState>> SignalAndServiceStatusChangedEvent;

	private SafeRecorder m_Recorder;

	private uint m_dwId;

	private Guid m_GuidId;

	private string m_DeviceName;

	private string m_RootDeviceName;

	private string m_RootDeviceNameInstanceId;

	private bool? m_bConfigured;

	private string m_FriendlyName;

	private uint m_dwViewOrder;

	private bool m_bPrefView;

	private uint m_dwRecordOrder;

	private bool m_bPrefRecord;

	private string[] m_ConfiguredTSNames;

	private int? m_State;

	private TuneRequest m_CurrentTR;

	private int? m_SIID;

	private int? m_hr;

	private string[] m_ClientIDs;

	private bool? m_Busy;

	private TunerType? m_TunerType;

	private uint m_TVFormats;

	private uint m_NumAuxInputs;

	private Guid[] m_HWSupportedNetworkTypes;

	private ProtType? m_CPType;

	private uint? m_EncoderMin;

	private uint m_EncoderMax;

	private uint m_EncoderDelta;

	private TuneRequest m_ConfiguredDefaultTR;

	private bool? m_bUseSTB;

	private byte[] m_IRControlBlob;

	private RecorderUse? m_Use;

	private bool? m_DoesDiseqC;

	private bool? m_SupportsConditionalAccess;

	private Guid m_GuideTypeGuid;

	private bool? m_SupportsPBDAScanning;

	private bool? m_PassiveClientsExist;

	private bool? m_IsPbda;

	private bool? m_IsMandatoryParentalControl;

	private string m_PbdaId;

	private string m_BcasId;

	private string m_SupportedLanguages;

	private uint m_Strength;

	private TuneRequest m_EASTR;

	private uint m_StartTime;

	private ushort m_Duration;

	private string m_ActivationNature;

	private string m_AlertMessage;

	private CasCardStatusType m_CasStatus;

	private CasCardAssociationType m_CasAssoc;

	private DrmPairingStatus m_DrmStatus;

	private uint m_DialogRequest;

	private byte[] m_CaptureToken;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool IsTV
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			int num = ((CurrentTuneRequest != null && !IsRecording && IsBusy && !IsRadio) ? 1 : 0);
			return (byte)num != 0;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool IsRadio
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			int num = ((CurrentTuneRequest != null && typeof(AnalogRadioTuningSpace).IsAssignableFrom(((object)CurrentTuneRequest.get_TuningSpace()).GetType())) ? 1 : 0);
			return (byte)num != 0;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool IsRecording
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			return SIID != -1;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public string BcasId
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			string bcasId;
			try
			{
				@lock = lock3;
				if (m_BcasId != null)
				{
					bcasId = m_BcasId;
					goto IL_0035;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			string text = "";
			try
			{
				string pbdaDeviceLanguage = PbdaDeviceLanguage;
				text = this.get_GPNVSValue(GpnvsNames.BcasId, pbdaDeviceLanguage);
			}
			catch (NotImplementedException)
			{
			}
			@lock lock4 = new @lock(m_Lock);
			try
			{
				lock2 = lock4;
				m_BcasId = text;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return text;
			IL_0035:
			((IDisposable)@lock).Dispose();
			return bcasId;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool IsPbda
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			@lock @lock = null;
			string text = null;
			@lock lock2 = null;
			@lock lock3 = null;
			COMException ex = null;
			@lock lock4 = null;
			@lock lock5 = null;
			@lock lock6 = new @lock(m_Lock);
			bool value;
			try
			{
				@lock = lock6;
				if (m_IsPbda.HasValue)
				{
					value = m_IsPbda.Value;
					goto IL_0046;
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
				string pbdaDeviceLanguage = PbdaDeviceLanguage;
				text = this.get_GPNVSValue(GpnvsNames.DeviceId, pbdaDeviceLanguage);
				@lock lock7 = new @lock(m_Lock);
				try
				{
					lock2 = lock7;
					if (text != null)
					{
						bool? flag = (m_IsPbda = true);
					}
				}
				catch
				{
					//try-fault
					((IDisposable)lock2).Dispose();
					throw;
				}
				((IDisposable)lock2).Dispose();
			}
			catch (COMException ex2)
			{
				@lock lock8 = new @lock(m_Lock);
				try
				{
					lock3 = lock8;
					if (ex2.ErrorCode != -2147467262)
					{
						bool? flag2 = (m_IsPbda = false);
					}
					else
					{
						bool? flag3 = (m_IsPbda = true);
					}
				}
				catch
				{
					//try-fault
					((IDisposable)lock3).Dispose();
					throw;
				}
				((IDisposable)lock3).Dispose();
			}
			catch (NotImplementedException)
			{
				@lock lock9 = new @lock(m_Lock);
				try
				{
					lock4 = lock9;
					bool? flag4 = (m_IsPbda = false);
				}
				catch
				{
					//try-fault
					((IDisposable)lock4).Dispose();
					throw;
				}
				((IDisposable)lock4).Dispose();
			}
			@lock lock10 = new @lock(m_Lock);
			bool value2;
			try
			{
				lock5 = lock10;
				value2 = m_IsPbda.Value;
			}
			catch
			{
				//try-fault
				((IDisposable)lock5).Dispose();
				throw;
			}
			((IDisposable)lock5).Dispose();
			return value2;
			IL_0046:
			((IDisposable)@lock).Dispose();
			return value;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool PassiveClientsExist
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			bool value;
			try
			{
				@lock = lock3;
				if (m_PassiveClientsExist.HasValue)
				{
					value = m_PassiveClientsExist.Value;
					goto IL_0039;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			bool flag = InteropHelper.smethod_38(new d0<bool>(TPPassiveClientsExist).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::PassiveClientsExist::get");
			@lock lock4 = new @lock(m_Lock);
			bool value2;
			try
			{
				lock2 = lock4;
				bool? flag2 = (m_PassiveClientsExist = flag);
				value2 = m_PassiveClientsExist.Value;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return value2;
			IL_0039:
			((IDisposable)@lock).Dispose();
			return value;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool SupportsConditionalAccess
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			bool value;
			try
			{
				@lock = lock3;
				if (m_SupportsConditionalAccess.HasValue)
				{
					value = m_SupportsConditionalAccess.Value;
					goto IL_0039;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			bool flag = InteropHelper.smethod_38(new d0<bool>(TPSupportsConditionalAccess).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::SupportsConditionalAccess::get");
			@lock lock4 = new @lock(m_Lock);
			bool value2;
			try
			{
				lock2 = lock4;
				bool? flag2 = (m_SupportsConditionalAccess = flag);
				value2 = m_SupportsConditionalAccess.Value;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return value2;
			IL_0039:
			((IDisposable)@lock).Dispose();
			return value;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool DoesSupportDiseqc
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			bool value;
			try
			{
				@lock = lock3;
				if (m_DoesDiseqC.HasValue)
				{
					value = m_DoesDiseqC.Value;
					goto IL_0039;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			bool flag = InteropHelper.smethod_38(new d0<bool>(TPDoesSupportDiseqC).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::DoesSupportDiseqc::get");
			@lock lock4 = new @lock(m_Lock);
			bool value2;
			try
			{
				lock2 = lock4;
				bool? flag2 = (m_DoesDiseqC = flag);
				value2 = m_DoesDiseqC.Value;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return value2;
			IL_0039:
			((IDisposable)@lock).Dispose();
			return value;
		}
	}

	public string GPNVSValue => InteropHelper.smethod_45(new d2<string, string, string>(TPGetGPNVSValue).BeginInvoke(name, language, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::GPNVSValue::get");

	public string GPNVSName => InteropHelper.smethod_44(new d1<string, uint>(TPGPNVSNameByIndex).BeginInvoke(eventID, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::GPNVSName::get");

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public object Diagnostic => InteropHelper.smethod_40(new d1<object, string>(TPGetDiagnosticProperty).BeginInvoke(propertyName, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::Diagnostic::get");

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public SmartCardApplication[] SmartCardApplications => InteropHelper.smethod_39(new d0<SmartCardApplication[]>(TPGetSmartCardApplications).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::SmartCardApplications::get");

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public string MMIMessage => InteropHelper.smethod_37(new d1<string, byte>(TPGetMMIMessage).BeginInvoke(dialogNumber, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::MMIMessage::get");

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public int SignalStrength => InteropHelper.smethod_36(new d0<int>(TPGetSignalStrength).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::SignalStrength::get");

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public ulong BitRate => InteropHelper.smethod_35(new d1<ulong, RecorderStreamType>(TPGetBitRate).BeginInvoke(rst, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::BitRate::get");

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public TuneRequest ConfiguredDefaultTuneRequest
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			TuneRequest result;
			try
			{
				@lock = lock3;
				if (m_bUseSTB.HasValue)
				{
					result = _003CModule_003E.smethod_60(m_ConfiguredDefaultTR);
					goto IL_0039;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			InteropHelper.smethod_1(new dv0(TPGetRecorderConfig).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::ConfiguredDefaultTuneRequest::get");
			@lock lock4 = new @lock(m_Lock);
			TuneRequest result2;
			try
			{
				lock2 = lock4;
				result2 = _003CModule_003E.smethod_60(m_ConfiguredDefaultTR);
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return result2;
			IL_0039:
			((IDisposable)@lock).Dispose();
			return result;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public byte[] IRControlBlob
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			byte[] result;
			try
			{
				@lock = lock3;
				if (m_bUseSTB.HasValue)
				{
					result = _003CModule_003E.smethod_61(m_IRControlBlob);
					goto IL_0039;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			InteropHelper.smethod_1(new dv0(TPGetRecorderConfig).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::IRControlBlob::get");
			@lock lock4 = new @lock(m_Lock);
			byte[] result2;
			try
			{
				lock2 = lock4;
				result2 = _003CModule_003E.smethod_61(m_IRControlBlob);
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return result2;
			IL_0039:
			((IDisposable)@lock).Dispose();
			return result;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool UseSTB
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			bool value;
			try
			{
				@lock = lock3;
				if (m_bUseSTB.HasValue)
				{
					value = m_bUseSTB.Value;
					goto IL_0039;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			InteropHelper.smethod_1(new dv0(TPGetRecorderConfig).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::UseSTB::get");
			@lock lock4 = new @lock(m_Lock);
			bool value2;
			try
			{
				lock2 = lock4;
				value2 = m_bUseSTB.Value;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return value2;
			IL_0039:
			((IDisposable)@lock).Dispose();
			return value;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public string Profile
	{
		get
		{
			if (string.IsNullOrEmpty(_profile))
			{
				IAsyncResult r = new d0<string>(TPGetProfile).BeginInvoke(null, null);
				_profile = InteropHelper.smethod_34(r, "Microsoft::MediaCenter::TV::Tuners::Tuner::Profile::get");
			}
			return _profile;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public uint NumAuxInputs
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			uint numAuxInputs;
			try
			{
				@lock = lock3;
				if (m_TunerType.HasValue)
				{
					numAuxInputs = m_NumAuxInputs;
					goto IL_0034;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			InteropHelper.smethod_1(new dv0(TPGetCapabilities).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::NumAuxInputs::get");
			@lock lock4 = new @lock(m_Lock);
			uint numAuxInputs2;
			try
			{
				lock2 = lock4;
				numAuxInputs2 = m_NumAuxInputs;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return numAuxInputs2;
			IL_0034:
			((IDisposable)@lock).Dispose();
			return numAuxInputs;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public uint TVFormats
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			uint tVFormats;
			try
			{
				@lock = lock3;
				if (m_TunerType.HasValue)
				{
					tVFormats = m_TVFormats;
					goto IL_0034;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			InteropHelper.smethod_1(new dv0(TPGetCapabilities).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::TVFormats::get");
			@lock lock4 = new @lock(m_Lock);
			uint tVFormats2;
			try
			{
				lock2 = lock4;
				tVFormats2 = m_TVFormats;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return tVFormats2;
			IL_0034:
			((IDisposable)@lock).Dispose();
			return tVFormats;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public TunerType TVTunerType
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			TunerType value;
			try
			{
				@lock = lock3;
				if (m_TunerType.HasValue)
				{
					value = m_TunerType.Value;
					goto IL_0039;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			InteropHelper.smethod_1(new dv0(TPGetCapabilities).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::TVTunerType::get");
			@lock lock4 = new @lock(m_Lock);
			TunerType value2;
			try
			{
				lock2 = lock4;
				value2 = m_TunerType.Value;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return value2;
			IL_0039:
			((IDisposable)@lock).Dispose();
			return value;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool IsBusy
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			bool value;
			try
			{
				@lock = lock3;
				if (m_Busy.HasValue)
				{
					value = m_Busy.Value;
					goto IL_0039;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			InteropHelper.smethod_1(new dv0(TPGetBusy).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::IsBusy::get");
			@lock lock4 = new @lock(m_Lock);
			bool value2;
			try
			{
				lock2 = lock4;
				value2 = m_Busy.Value;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return value2;
			IL_0039:
			((IDisposable)@lock).Dispose();
			return value;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public string[] ClientIDs
	{
		get
		{
			@lock @lock = null;
			InteropHelper.smethod_1(new dv0(TPGetClientIDs).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::ClientIDs::get");
			@lock lock2 = new @lock(m_Lock);
			string[] result;
			try
			{
				@lock = lock2;
				result = _003CModule_003E.smethod_62(m_ClientIDs);
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			return result;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public int SIID
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			int value;
			try
			{
				@lock = lock3;
				if (m_SIID.HasValue)
				{
					value = m_SIID.Value;
					goto IL_0039;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			InteropHelper.smethod_1(new dv0(TPGetState).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::SIID::get");
			@lock lock4 = new @lock(m_Lock);
			int value2;
			try
			{
				lock2 = lock4;
				value2 = m_SIID.Value;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return value2;
			IL_0039:
			((IDisposable)@lock).Dispose();
			return value;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public TuneRequest CurrentTuneRequest
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			TuneRequest result;
			try
			{
				@lock = lock3;
				TuneRequest currentTR = m_CurrentTR;
				if (currentTR != null)
				{
					result = _003CModule_003E.smethod_66(currentTR);
					goto IL_0031;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			InteropHelper.smethod_1(new dv0(TPGetState).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::CurrentTuneRequest::get");
			@lock lock4 = new @lock(m_Lock);
			TuneRequest result2;
			try
			{
				lock2 = lock4;
				result2 = _003CModule_003E.smethod_60(m_CurrentTR);
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return result2;
			IL_0031:
			((IDisposable)@lock).Dispose();
			return result;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public int HR
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			int value;
			try
			{
				@lock = lock3;
				if (m_hr.HasValue)
				{
					value = m_hr.Value;
					goto IL_0039;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			InteropHelper.smethod_1(new dv0(TPGetState).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::HR::get");
			@lock lock4 = new @lock(m_Lock);
			int value2;
			try
			{
				lock2 = lock4;
				value2 = m_hr.Value;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return value2;
			IL_0039:
			((IDisposable)@lock).Dispose();
			return value;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public int State
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			int value;
			try
			{
				@lock = lock3;
				if (m_State.HasValue)
				{
					value = m_State.Value;
					goto IL_0039;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			InteropHelper.smethod_1(new dv0(TPGetState).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::State::get");
			@lock lock4 = new @lock(m_Lock);
			int value2;
			try
			{
				lock2 = lock4;
				value2 = m_State.Value;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return value2;
			IL_0039:
			((IDisposable)@lock).Dispose();
			return value;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public string[] ConfiguredTuningSpaces
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			string[] result;
			try
			{
				@lock = lock3;
				string[] configuredTSNames = m_ConfiguredTSNames;
				if (configuredTSNames != null)
				{
					result = _003CModule_003E.smethod_62(configuredTSNames);
					goto IL_0031;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			InteropHelper.smethod_1(new dv0(TPGetConfiguredTuningSpaceNames).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::ConfiguredTuningSpaces::get");
			@lock lock4 = new @lock(m_Lock);
			string[] result2;
			try
			{
				lock2 = lock4;
				result2 = _003CModule_003E.smethod_62(m_ConfiguredTSNames);
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return result2;
			IL_0031:
			((IDisposable)@lock).Dispose();
			return result;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool Ready
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			return HR >= 0;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool PrefRecord
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			bool bPrefRecord;
			try
			{
				@lock = lock3;
				if (m_bConfigured.HasValue)
				{
					bPrefRecord = m_bPrefRecord;
					goto IL_0034;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			GetConfigInfo();
			@lock lock4 = new @lock(m_Lock);
			bool bPrefRecord2;
			try
			{
				lock2 = lock4;
				bPrefRecord2 = m_bPrefRecord;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return bPrefRecord2;
			IL_0034:
			((IDisposable)@lock).Dispose();
			return bPrefRecord;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public uint RecordOrder
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			uint dwRecordOrder;
			try
			{
				@lock = lock3;
				if (m_bConfigured.HasValue)
				{
					dwRecordOrder = m_dwRecordOrder;
					goto IL_0034;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			GetConfigInfo();
			@lock lock4 = new @lock(m_Lock);
			uint dwRecordOrder2;
			try
			{
				lock2 = lock4;
				dwRecordOrder2 = m_dwRecordOrder;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return dwRecordOrder2;
			IL_0034:
			((IDisposable)@lock).Dispose();
			return dwRecordOrder;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool PrefView
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			bool bPrefView;
			try
			{
				@lock = lock3;
				if (m_bConfigured.HasValue)
				{
					bPrefView = m_bPrefView;
					goto IL_0034;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			GetConfigInfo();
			@lock lock4 = new @lock(m_Lock);
			bool bPrefView2;
			try
			{
				lock2 = lock4;
				bPrefView2 = m_bPrefView;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return bPrefView2;
			IL_0034:
			((IDisposable)@lock).Dispose();
			return bPrefView;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public uint ViewOrder
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			uint dwViewOrder;
			try
			{
				@lock = lock3;
				if (m_bConfigured.HasValue)
				{
					dwViewOrder = m_dwViewOrder;
					goto IL_0034;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			GetConfigInfo();
			@lock lock4 = new @lock(m_Lock);
			uint dwViewOrder2;
			try
			{
				lock2 = lock4;
				dwViewOrder2 = m_dwViewOrder;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return dwViewOrder2;
			IL_0034:
			((IDisposable)@lock).Dispose();
			return dwViewOrder;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool IsConnected
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			@lock @lock = null;
			@lock lock2 = new @lock(m_Lock);
			bool result;
			try
			{
				@lock = lock2;
				result = m_Recorder != null;
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			return result;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public string FriendlyName
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			string result;
			try
			{
				@lock = lock3;
				if (m_bConfigured.HasValue)
				{
					result = _003CModule_003E.smethod_65(m_FriendlyName);
					goto IL_0039;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			GetConfigInfo();
			@lock lock4 = new @lock(m_Lock);
			string result2;
			try
			{
				lock2 = lock4;
				result2 = _003CModule_003E.smethod_65(m_FriendlyName);
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return result2;
			IL_0039:
			((IDisposable)@lock).Dispose();
			return result;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool IsConfigured
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			bool value;
			try
			{
				@lock = lock3;
				if (m_bConfigured.HasValue)
				{
					value = m_bConfigured.Value;
					goto IL_0039;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			GetConfigInfo();
			@lock lock4 = new @lock(m_Lock);
			bool value2;
			try
			{
				lock2 = lock4;
				if (!m_bConfigured.HasValue)
				{
					bool? flag = (m_bConfigured = false);
				}
				value2 = m_bConfigured.Value;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return value2;
			IL_0039:
			((IDisposable)@lock).Dispose();
			return value;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool IsMandatoryParentalControl
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			bool value;
			try
			{
				@lock = lock3;
				if (m_IsMandatoryParentalControl.HasValue)
				{
					value = m_IsMandatoryParentalControl.Value;
					goto IL_0039;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			string text = null;
			try
			{
				text = this.get_GPNVSValue(GpnvsNames.ConfigureParentalControl, PbdaDeviceLanguage);
			}
			catch (TimeoutException)
			{
			}
			catch (COMException)
			{
			}
			if (text != null)
			{
				@lock lock4 = new @lock(m_Lock);
				bool value2;
				try
				{
					lock2 = lock4;
					byte b = (byte)((!string.IsNullOrEmpty(text) && text != "0") ? 1 : 0);
					bool? flag = (m_IsMandatoryParentalControl = b != 0);
					value2 = m_IsMandatoryParentalControl.Value;
				}
				catch
				{
					//try-fault
					((IDisposable)lock2).Dispose();
					throw;
				}
				((IDisposable)lock2).Dispose();
				return value2;
			}
			return false;
			IL_0039:
			((IDisposable)@lock).Dispose();
			return value;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public string RootDeviceNameInstanceId
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			string result;
			try
			{
				@lock = lock3;
				if (m_RootDeviceNameInstanceId != null)
				{
					result = _003CModule_003E.smethod_65(m_RootDeviceNameInstanceId);
					goto IL_003a;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			GetIdentity();
			@lock lock4 = new @lock(m_Lock);
			string result2;
			try
			{
				lock2 = lock4;
				result2 = _003CModule_003E.smethod_65(m_RootDeviceNameInstanceId);
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return result2;
			IL_003a:
			((IDisposable)@lock).Dispose();
			return result;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public string RootDeviceName
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			string result;
			try
			{
				@lock = lock3;
				if (m_RootDeviceName != null)
				{
					result = _003CModule_003E.smethod_65(m_RootDeviceName);
					goto IL_003a;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			GetIdentity();
			@lock lock4 = new @lock(m_Lock);
			string result2;
			try
			{
				lock2 = lock4;
				result2 = _003CModule_003E.smethod_65(m_RootDeviceName);
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return result2;
			IL_003a:
			((IDisposable)@lock).Dispose();
			return result;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public string DeviceName
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			string result;
			try
			{
				@lock = lock3;
				if (m_DeviceName != null)
				{
					result = _003CModule_003E.smethod_65(m_DeviceName);
					goto IL_003a;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			GetIdentity();
			@lock lock4 = new @lock(m_Lock);
			string result2;
			try
			{
				lock2 = lock4;
				result2 = _003CModule_003E.smethod_65(m_DeviceName);
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return result2;
			IL_003a:
			((IDisposable)@lock).Dispose();
			return result;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public string PbdaSupportedLanguages
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			string supportedLanguages;
			try
			{
				@lock = lock3;
				if (m_SupportedLanguages != null)
				{
					supportedLanguages = m_SupportedLanguages;
					goto IL_0035;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			string text = null;
			try
			{
				text = this.get_GPNVSValue(GpnvsNames.SupportedLanguages, string.Empty);
			}
			catch (TimeoutException)
			{
			}
			catch (COMException)
			{
			}
			if (text != null)
			{
				@lock lock4 = new @lock(m_Lock);
				try
				{
					lock2 = lock4;
					m_SupportedLanguages = text;
				}
				catch
				{
					//try-fault
					((IDisposable)lock2).Dispose();
					throw;
				}
				((IDisposable)lock2).Dispose();
			}
			return text;
			IL_0035:
			((IDisposable)@lock).Dispose();
			return supportedLanguages;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public string PbdaTunerId
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			string pbdaId;
			try
			{
				@lock = lock3;
				if (m_PbdaId != null)
				{
					pbdaId = m_PbdaId;
					goto IL_0035;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			string text = null;
			try
			{
				text = this.get_GPNVSValue(GpnvsNames.TunerId, PbdaDeviceLanguage);
			}
			catch (TimeoutException)
			{
			}
			catch (COMException)
			{
			}
			if (text != null)
			{
				@lock lock4 = new @lock(m_Lock);
				try
				{
					lock2 = lock4;
					m_PbdaId = text;
				}
				catch
				{
					//try-fault
					((IDisposable)lock2).Dispose();
					throw;
				}
				((IDisposable)lock2).Dispose();
			}
			return text;
			IL_0035:
			((IDisposable)@lock).Dispose();
			return pbdaId;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public string PbdaDeviceLanguage
	{
		get
		{
			string text = null;
			string text2 = null;
			try
			{
				text = PbdaSupportedLanguages;
				text2 = string.Concat(CultureInfo.CurrentUICulture.ThreeLetterISOLanguageName + "-", RegionInfo.CurrentRegion.TwoLetterISORegionName);
				if (!string.IsNullOrEmpty(text) && !text.Contains(text2))
				{
					return text.Substring(0, 6);
				}
				return text2;
			}
			catch (TimeoutException)
			{
			}
			catch (COMException)
			{
			}
			return string.Empty;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Guid DeviceId
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			Guid guidId;
			try
			{
				@lock = lock3;
				if (m_GuidId != Guid.Empty)
				{
					guidId = m_GuidId;
					goto IL_0043;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			GetIdentity();
			@lock lock4 = new @lock(m_Lock);
			Guid guidId2;
			try
			{
				lock2 = lock4;
				guidId2 = m_GuidId;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return guidId2;
			IL_0043:
			((IDisposable)@lock).Dispose();
			return guidId;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public uint Id
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			uint result;
			try
			{
				@lock = lock3;
				uint dwId = m_dwId;
				if (dwId != uint.MaxValue)
				{
					result = dwId;
					goto IL_002d;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			GetIdentity();
			@lock lock4 = new @lock(m_Lock);
			uint dwId2;
			try
			{
				lock2 = lock4;
				dwId2 = m_dwId;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return dwId2;
			IL_002d:
			((IDisposable)@lock).Dispose();
			return result;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool IsPassive
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			int num = ((m_Recorder != null && CurrentUse == RecorderUse.ru_Passive) ? 1 : 0);
			return (byte)num != 0;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool IsActive
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			int num = ((m_Recorder != null && CurrentUse == RecorderUse.ru_Active) ? 1 : 0);
			return (byte)num != 0;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool IsScanning
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			int num = ((m_Recorder != null && CurrentUse == RecorderUse.ru_Scanning) ? 1 : 0);
			return (byte)num != 0;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool IsExclusive
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			int num = ((m_Recorder != null && CurrentUse == RecorderUse.ru_Exclusive) ? 1 : 0);
			return (byte)num != 0;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool IsFree
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			return !IsBusy;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public RecorderUse CurrentUse
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = null;
			@lock lock3 = new @lock(m_Lock);
			RecorderUse value;
			try
			{
				@lock = lock3;
				if (m_Use.HasValue)
				{
					value = m_Use.Value;
					goto IL_0039;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			RecorderUse recorderUse = InteropHelper.smethod_32(new d0<RecorderUse>(TPGetRecorderUse).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::CurrentUse::get");
			@lock lock4 = new @lock(m_Lock);
			RecorderUse value2;
			try
			{
				lock2 = lock4;
				RecorderUse? recorderUse2 = (m_Use = recorderUse);
				value2 = m_Use.Value;
			}
			catch
			{
				//try-fault
				((IDisposable)lock2).Dispose();
				throw;
			}
			((IDisposable)lock2).Dispose();
			return value2;
			IL_0039:
			((IDisposable)@lock).Dispose();
			return value;
		}
	}

	public unsafe override Guid PrimaryIID => *(Guid*)(int)(ref _003CModule_003E._GUID_379848e6_2751_42c0_8de6_9457cdc61d60);

	public IntPtr H => handle;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal SafeRecorder Recorder
	{
		get
		{
			return _003CModule_003E.smethod_64(m_Recorder);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentException("can't be nullptr");
			}
			InteropHelper.smethod_2(new dv1<SafeRecorder>(TPSetRecorder).BeginInvoke(value, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::Recorder::set");
		}
	}

	private unsafe CComPtr_003CIRecorderInfo_003E* TPGetRecInfoPtr(CComPtr_003CIRecorderInfo_003E* pCcomPtr_003CIRecorderInfo_003E_0)
	{
		uint num = 0u;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderInfo_003E cComPtr_003CIRecorderInfo_003E);
		CComPtr_003CIRecorderInfo_003E* nativePtr_003CIRecorderInfo_003E = SafeComWrapper.GetNativePtr_003CIRecorderInfo_003E(&cComPtr_003CIRecorderInfo_003E, this);
		try
		{
			try
			{
				_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bctor_007D(pCcomPtr_003CIRecorderInfo_003E_0, nativePtr_003CIRecorderInfo_003E);
				num = 1u;
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
			return pCcomPtr_003CIRecorderInfo_003E_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), pCcomPtr_003CIRecorderInfo_003E_0);
			}
			throw;
		}
	}

	private unsafe CComPtr_003CIRecorderEx2_003E* TPGetRecorderPtr(CComPtr_003CIRecorderEx2_003E* pCcomPtr_003CIRecorderEx2_003E_0)
	{
		uint num = 0u;
		SafeRecorder recorder = m_Recorder;
		if (recorder != null && !recorder.IsInvalid)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
			CComPtr_003CIRecorderEx2_003E* nativePtr_003CIRecorderEx2_003E = SafeComWrapper.GetNativePtr_003CIRecorderEx2_003E(&cComPtr_003CIRecorderEx2_003E, m_Recorder);
			try
			{
				try
				{
					_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bctor_007D(pCcomPtr_003CIRecorderEx2_003E_0, nativePtr_003CIRecorderEx2_003E);
					num = 1u;
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
					throw;
				}
				_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
				return pCcomPtr_003CIRecorderEx2_003E_0;
			}
			catch
			{
				//try-fault
				if ((num & (true ? 1u : 0u)) != 0)
				{
					num &= 0xFFFFFFFEu;
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), pCcomPtr_003CIRecorderEx2_003E_0);
				}
				throw;
			}
		}
		*(int*)pCcomPtr_003CIRecorderEx2_003E_0 = 0;
		try
		{
			num = 1u;
			return pCcomPtr_003CIRecorderEx2_003E_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), pCcomPtr_003CIRecorderEx2_003E_0);
			}
			throw;
		}
	}

	private unsafe void TPGetIdentityInfo()
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
		*(int*)(&cComBSTR) = 0;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR2);
			*(int*)(&cComBSTR2) = 0;
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR3);
				*(int*)(&cComBSTR3) = 0;
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderInfo_003E cComPtr_003CIRecorderInfo_003E);
					CComPtr_003CIRecorderInfo_003E* ptr = TPGetRecInfoPtr(&cComPtr_003CIRecorderInfo_003E);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out uint dwId);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out _GUID gUID);
					try
					{
						int num = *(int*)ptr;
						MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint*, _GUID*, ushort**, ushort**, ushort**, int>)(int)(*(uint*)(*(int*)num + 56)))((IntPtr)num, &dwId, &gUID, (ushort**)(&cComBSTR), (ushort**)(&cComBSTR2), (ushort**)(&cComBSTR3)));
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
						throw;
					}
					_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
					@lock lock2 = new @lock(m_Lock);
					try
					{
						@lock = lock2;
						m_dwId = dwId;
						ref Guid guidId = ref m_GuidId;
						guidId = *(Guid*)(int)(ref gUID);
						if (*(int*)(&cComBSTR) != 0)
						{
							m_DeviceName = new string((char*)(int)(*(uint*)(&cComBSTR)));
						}
						else
						{
							m_DeviceName = null;
						}
						if (*(int*)(&cComBSTR2) != 0)
						{
							m_RootDeviceName = new string((char*)(int)(*(uint*)(&cComBSTR2)));
						}
						else
						{
							m_RootDeviceName = null;
						}
						if (*(int*)(&cComBSTR3) != 0)
						{
							m_RootDeviceNameInstanceId = new string((char*)(int)(*(uint*)(&cComBSTR3)));
						}
						else
						{
							m_RootDeviceNameInstanceId = null;
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
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR3);
					throw;
				}
				_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR3)));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR2);
				throw;
			}
			_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR2)));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
	}

	private unsafe void TPGetConfigInfo()
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
		*(int*)(&cComBSTR) = 0;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderInfo_003E cComPtr_003CIRecorderInfo_003E);
			CComPtr_003CIRecorderInfo_003E* ptr = TPGetRecInfoPtr(&cComPtr_003CIRecorderInfo_003E);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint dwViewOrder);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out short num2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint dwRecordOrder);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out short num3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out short num4);
			try
			{
				int num = *(int*)ptr;
				MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ushort**, uint*, short*, uint*, short*, short*, int>)(int)(*(uint*)(*(int*)num + 32)))((IntPtr)num, (ushort**)(&cComBSTR), &dwViewOrder, &num2, &dwRecordOrder, &num3, &num4));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
			@lock lock2 = new @lock(m_Lock);
			try
			{
				@lock = lock2;
				if (!(*(int*)(&cComBSTR) == 0))
				{
					m_FriendlyName = new string((char*)(int)(*(uint*)(&cComBSTR)));
				}
				else
				{
					m_FriendlyName = null;
				}
				m_dwViewOrder = dwViewOrder;
				int num5 = ((m_bPrefView = num2 == -1) ? 1 : 0);
				m_dwRecordOrder = dwRecordOrder;
				int num6 = ((m_bPrefRecord = num3 == -1) ? 1 : 0);
				byte b = ((num4 == -1) ? ((byte)1) : ((byte)0));
				bool? flag = (m_bConfigured = b != 0);
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
	}

	private void GetIdentity()
	{
		dv0 dv11 = TPGetIdentityInfo;
		try
		{
			InteropHelper.smethod_1(dv11.BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::GetIdentity");
		}
		catch (Exception)
		{
		}
	}

	private void GetConfigInfo()
	{
		dv0 dv11 = TPGetConfigInfo;
		try
		{
			InteropHelper.smethod_1(dv11.BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::GetConfigInfo");
		}
		catch (Exception)
		{
		}
	}

	private unsafe void TPGetConfiguredTuningSpaceNames()
	{
		@lock @lock = null;
		tagSAFEARRAY* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderInfo_003E cComPtr_003CIRecorderInfo_003E);
		CComPtr_003CIRecorderInfo_003E* ptr2 = TPGetRecInfoPtr(&cComPtr_003CIRecorderInfo_003E);
		try
		{
			int num = *(int*)ptr2;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, tagSAFEARRAY**, int>)(int)(*(uint*)(*(int*)num + 36)))((IntPtr)num, &ptr));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
		string[] array = null;
		if (ptr != null)
		{
			array = InteropHelper.SafeArrayToStringArray(&ptr);
		}
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			if (array != null)
			{
				m_ConfiguredTSNames = array;
			}
			else
			{
				m_ConfiguredTSNames = new string[0];
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

	private unsafe void TPGetState()
	{
		@lock @lock = null;
		int num = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CITuneRequest_003E cComPtr_003CITuneRequest_003E);
		*(int*)(&cComPtr_003CITuneRequest_003E) = 0;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderInfo_003E cComPtr_003CIRecorderInfo_003E);
			CComPtr_003CIRecorderInfo_003E* ptr = TPGetRecInfoPtr(&cComPtr_003CIRecorderInfo_003E);
			int num5;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
			try
			{
				int num2 = *(int*)ptr;
				num5 = ((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ITuneRequest**, int*, int*, int*, int>)(int)(*(uint*)(*(int*)num2 + 40)))((IntPtr)num2, (ITuneRequest**)(&cComPtr_003CITuneRequest_003E), &num3, &num4, &num);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
			if (num5 < 0 && num >= 0)
			{
				MarshalHelper.ComException(num5);
			}
			TuneRequest currentTR = _003CModule_003E.smethod_58((IUnknown*)(int)(*(uint*)(&cComPtr_003CITuneRequest_003E)));
			@lock lock2 = new @lock(m_Lock);
			try
			{
				@lock = lock2;
				int? num6 = (m_hr = num);
				int? num7 = (m_State = num3);
				int? num8 = (m_SIID = num4);
				m_CurrentTR = currentTR;
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CITuneRequest_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CITuneRequest_003E_002E_007Bdtor_007D), &cComPtr_003CITuneRequest_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CITuneRequest_003E_002E_007Bdtor_007D((CComPtrBase_003CITuneRequest_003E*)(&cComPtr_003CITuneRequest_003E));
	}

	private unsafe void TPGetClientIDs()
	{
		@lock @lock = null;
		@lock lock2 = null;
		@lock lock3 = new @lock(m_Lock);
		try
		{
			@lock = lock3;
			m_ClientIDs = new string[0];
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		tagSAFEARRAY* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderInfo_003E cComPtr_003CIRecorderInfo_003E);
		CComPtr_003CIRecorderInfo_003E* ptr2 = TPGetRecInfoPtr(&cComPtr_003CIRecorderInfo_003E);
		try
		{
			int num = *(int*)ptr2;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, tagSAFEARRAY**, int>)(int)(*(uint*)(*(int*)num + 48)))((IntPtr)num, &ptr));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
		string[] array = null;
		if (ptr != null)
		{
			array = InteropHelper.SafeArrayToStringArray(&ptr);
		}
		@lock lock4 = new @lock(m_Lock);
		try
		{
			lock2 = lock4;
			if (array != null)
			{
				m_ClientIDs = array;
			}
			else
			{
				m_ClientIDs = new string[0];
			}
		}
		catch
		{
			//try-fault
			((IDisposable)lock2).Dispose();
			throw;
		}
		((IDisposable)lock2).Dispose();
	}

	private unsafe void TPGetBusy()
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderInfo_003E cComPtr_003CIRecorderInfo_003E);
		CComPtr_003CIRecorderInfo_003E* ptr = TPGetRecInfoPtr(&cComPtr_003CIRecorderInfo_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num2);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, short*, int>)(int)(*(uint*)(*(int*)num + 44)))((IntPtr)num, &num2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			byte b = ((num2 == -1) ? ((byte)1) : ((byte)0));
			bool? flag = (m_Busy = b != 0);
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	private unsafe void TPGetCapabilities()
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderInfo_003E cComPtr_003CIRecorderInfo_003E);
		CComPtr_003CIRecorderInfo_003E* ptr = TPGetRecInfoPtr(&cComPtr_003CIRecorderInfo_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out global::TunerType tunerType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint tVFormats);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint numAuxInputs);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, global::TunerType*, uint*, uint*, int>)(int)(*(uint*)(*(int*)num + 52)))((IntPtr)num, &tunerType, &tVFormats, &numAuxInputs));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			TunerType? tunerType2 = (m_TunerType = (TunerType)tunerType);
			m_TVFormats = tVFormats;
			m_NumAuxInputs = numAuxInputs;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	private unsafe void TPOpenMedia(TuneRequest tr)
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct8 @struct);
		_003CModule_003E.smethod_9(&@struct, _003CModule_003E.smethod_59(tr));
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
			CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
			try
			{
				int num = *(int*)ptr;
				int num2 = *(int*)(&@struct);
				MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ITuneRequest*, int>)(int)(*(uint*)(*(int*)num + 16)))((IntPtr)num, (ITuneRequest*)num2));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
			@lock lock2 = new @lock(m_Lock);
			try
			{
				@lock = lock2;
				((IDisposable)m_CurrentTR)?.Dispose();
				m_CurrentTR = null;
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct8*, void>)(&_003CModule_003E.smethod_3), &@struct);
			throw;
		}
		_003CModule_003E.smethod_3(&@struct);
	}

	private unsafe void TPCloseMedia()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, int>)(int)(*(uint*)(*(int*)num + 20)))((IntPtr)num));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
	}

	[return: MarshalAs(UnmanagedType.U1)]
	private unsafe bool TPValidateTuneRequest(TuneRequest tr)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct8 @struct);
		_003CModule_003E.smethod_9(&@struct, _003CModule_003E.smethod_59(tr));
		bool result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
			CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out short num3);
			try
			{
				int num = *(int*)ptr;
				int num2 = *(int*)(&@struct);
				MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ITuneRequest*, short*, int>)(int)(*(uint*)(*(int*)num + 24)))((IntPtr)num, (ITuneRequest*)num2, &num3));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
			result = num3 == -1;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct8*, void>)(&_003CModule_003E.smethod_3), &@struct);
			throw;
		}
		_003CModule_003E.smethod_3(&@struct);
		return result;
	}

	private unsafe string TPGetProfile()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort* ptr2);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ushort**, int>)(int)(*(uint*)(*(int*)num + 28)))((IntPtr)num, &ptr2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		object result = null;
		if (ptr2 != null)
		{
			result = new string((char*)ptr2);
		}
		_003CModule_003E.CoTaskMemFree(ptr2);
		return (string)result;
	}

	private unsafe void TPSetContentSIID(int SIID)
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, int, int>)(int)(*(uint*)(*(int*)num + 36)))((IntPtr)num, SIID));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			int? num2 = (m_SIID = SIID);
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	private unsafe void TPStop()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, int>)(int)(*(uint*)(*(int*)num + 40)))((IntPtr)num));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
	}

	private unsafe void TPRecord([MarshalAs(UnmanagedType.U1)] bool bAsync)
	{
		int num = -1;
		if (!bAsync)
		{
			num = ~num;
		}
		short num2 = (short)num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num3 = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, short, int>)(int)(*(uint*)(*(int*)num3 + 44)))((IntPtr)num3, num2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
	}

	private unsafe void TPRecordEx([MarshalAs(UnmanagedType.U1)] bool bOn, uint dwQuality)
	{
		int num = -1;
		if (!bOn)
		{
			num = ~num;
		}
		short num2 = (short)num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num3 = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, short, uint, int>)(int)(*(uint*)(*(int*)num3 + 48)))((IntPtr)num3, num2, dwQuality));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
	}

	private unsafe void TPPause()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, int>)(int)(*(uint*)(*(int*)num + 52)))((IntPtr)num));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
	}

	private unsafe void TPSAP([MarshalAs(UnmanagedType.U1)] bool bOn)
	{
		int num = -1;
		if (!bOn)
		{
			num = ~num;
		}
		short num2 = (short)num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num3 = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, short, int>)(int)(*(uint*)(*(int*)num3 + 56)))((IntPtr)num3, num2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
	}

	[return: MarshalAs(UnmanagedType.U1)]
	private unsafe bool TPChannelAvailable(TuneRequest tr)
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct8 @struct);
		_003CModule_003E.smethod_9(&@struct, _003CModule_003E.smethod_59(tr));
		bool result;
		try
		{
			uint strength = 0u;
			short num = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
			CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
			try
			{
				int num2 = *(int*)ptr;
				int num3 = *(int*)(&@struct);
				MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ITuneRequest*, uint*, short*, int>)(int)(*(uint*)(*(int*)num2 + 64)))((IntPtr)num2, (ITuneRequest*)num3, &strength, &num));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
			@lock lock2 = new @lock(m_Lock);
			try
			{
				@lock = lock2;
				m_Strength = strength;
				result = num == -1;
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct8*, void>)(&_003CModule_003E.smethod_3), &@struct);
			throw;
		}
		_003CModule_003E.smethod_3(&@struct);
		return result;
	}

	private unsafe void TPSetMaxVideoEncoderQuality(uint dwQuality)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint, int>)(int)(*(uint*)(*(int*)num + 68)))((IntPtr)num, dwQuality));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
	}

	private unsafe void TPSetRecorderConfigEx(TuneRequest tr, [MarshalAs(UnmanagedType.U1)] bool useSTB, byte[] IRBlob, string name, uint viewOrder, uint recordOrder, [MarshalAs(UnmanagedType.U1)] bool prefView, [MarshalAs(UnmanagedType.U1)] bool prefRecord, [MarshalAs(UnmanagedType.U1)] bool configured, string[] configuredTSNames)
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct8 @struct);
		_003CModule_003E.smethod_9(&@struct, _003CModule_003E.smethod_59(tr));
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
			_003CModule_003E.ATL_002ECComBSTR_002E_007Bctor_007D(&cComBSTR);
			try
			{
				if (IRBlob != null)
				{
					InteropHelper.ByteArrayToBSTR(_003CModule_003E.smethod_2(&cComBSTR), IRBlob);
				}
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR2);
				_003CModule_003E.ATL_002ECComBSTR_002E_007Bctor_007D(&cComBSTR2);
				try
				{
					if (name != null)
					{
						_003CModule_003E.ATL_002ECComBSTR_002EAttach(&cComBSTR2, (ushort*)Marshal.StringToBSTR(name).ToPointer());
					}
					tagSAFEARRAY* ptr = null;
					if (configuredTSNames != null)
					{
						InteropHelper.StringArrayToSafeArray(&ptr, configuredTSNames);
					}
					int num = -1;
					if (!configured)
					{
						num = ~num;
					}
					short num2 = (short)num;
					int num3 = -1;
					if (!prefRecord)
					{
						num3 = ~num3;
					}
					short num4 = (short)num3;
					int num5 = -1;
					if (!prefView)
					{
						num5 = ~num5;
					}
					short num6 = (short)num5;
					int num7 = -1;
					if (!useSTB)
					{
						num7 = ~num7;
					}
					short num8 = (short)num7;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
					CComPtr_003CIRecorderEx2_003E* pCcomPtrBase_003CIRecorderEx2_003E_ = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
					try
					{
						_NoAddRefReleaseOnCComPtr_003CIRecorderEx2_003E* ptr2 = _003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_002D_003E((CComPtrBase_003CIRecorderEx2_003E*)pCcomPtrBase_003CIRecorderEx2_003E_);
						ITuneRequest* intPtr = _003CModule_003E.smethod_8((CComPtrBase_003CITuneRequest_003E*)(&@struct));
						ushort* intPtr2 = _003CModule_003E.ATL_002ECComBSTR_002E_002EPAG(&cComBSTR);
						ushort* intPtr3 = _003CModule_003E.ATL_002ECComBSTR_002E_002EPAG(&cComBSTR2);
						tagSAFEARRAY* intPtr4 = ptr;
						MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ITuneRequest*, short, ushort*, ushort*, uint, uint, short, short, short, tagSAFEARRAY*, int>)(int)(*(uint*)(*(int*)ptr2 + 128)))((nint)ptr2, intPtr, num8, intPtr2, intPtr3, viewOrder, recordOrder, num6, num4, num2, intPtr4));
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
						throw;
					}
					_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D(&cComPtr_003CIRecorderEx2_003E);
					MarshalHelper.ComException(_003CModule_003E.SafeArrayDestroy(ptr));
					@lock lock2 = new @lock(m_Lock);
					try
					{
						@lock = lock2;
						((IDisposable)m_ConfiguredDefaultTR)?.Dispose();
						m_ConfiguredDefaultTR = _003CModule_003E.smethod_60(tr);
						bool? flag = (m_bUseSTB = useSTB);
						m_IRControlBlob = _003CModule_003E.smethod_61(IRBlob);
						m_FriendlyName = name;
						m_dwViewOrder = viewOrder;
						m_dwRecordOrder = recordOrder;
						m_bPrefView = prefView;
						m_bPrefRecord = prefRecord;
						bool? flag2 = (m_bConfigured = configured);
						m_ConfiguredTSNames = _003CModule_003E.smethod_62(configuredTSNames);
					}
					catch
					{
						//try-fault
						((IDisposable)@lock).Dispose();
						throw;
					}
					((IDisposable)@lock).Dispose();
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR2);
					throw;
				}
				_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR2)));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
				throw;
			}
			_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct8*, void>)(&_003CModule_003E.smethod_3), &@struct);
			throw;
		}
		_003CModule_003E.smethod_3(&@struct);
	}

	private unsafe void TPGetRecorderConfig()
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CITuneRequest_003E cComPtr_003CITuneRequest_003E);
		*(int*)(&cComPtr_003CITuneRequest_003E) = 0;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
			*(int*)(&cComBSTR) = 0;
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR2);
				*(int*)(&cComBSTR2) = 0;
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
					CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out short num2);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out uint dwViewOrder);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out uint dwRecordOrder);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out short num3);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out short num4);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out short num5);
					try
					{
						int num = *(int*)ptr;
						MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ITuneRequest**, short*, ushort**, ushort**, uint*, uint*, short*, short*, short*, int>)(int)(*(uint*)(*(int*)num + 76)))((IntPtr)num, (ITuneRequest**)(&cComPtr_003CITuneRequest_003E), &num2, (ushort**)(&cComBSTR), (ushort**)(&cComBSTR2), &dwViewOrder, &dwRecordOrder, &num3, &num4, &num5));
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
						throw;
					}
					_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
					TuneRequest configuredDefaultTR = _003CModule_003E.smethod_58((IUnknown*)(int)(*(uint*)(&cComPtr_003CITuneRequest_003E)));
					byte[] @ref = null;
					if (!(*(int*)(&cComBSTR) == 0))
					{
						@ref = InteropHelper.BSTRToByteArray((ushort*)(int)(*(uint*)(&cComBSTR)));
					}
					string friendlyName = null;
					if (_003CModule_003E.smethod_103(&cComBSTR2, 0))
					{
						friendlyName = new string((char*)(int)(*(uint*)(&cComBSTR2)));
					}
					@lock lock2 = new @lock(m_Lock);
					try
					{
						@lock = lock2;
						m_ConfiguredDefaultTR = configuredDefaultTR;
						byte b = ((num2 == -1) ? ((byte)1) : ((byte)0));
						bool? flag = (m_bUseSTB = b != 0);
						m_IRControlBlob = _003CModule_003E.smethod_61(@ref);
						m_FriendlyName = friendlyName;
						m_dwViewOrder = dwViewOrder;
						m_dwRecordOrder = dwRecordOrder;
						int num6 = ((m_bPrefView = num3 == -1) ? 1 : 0);
						int num7 = ((m_bPrefRecord = num4 == -1) ? 1 : 0);
						byte b2 = ((num5 == -1) ? ((byte)1) : ((byte)0));
						bool? flag2 = (m_bConfigured = b2 != 0);
					}
					catch
					{
						//try-fault
						((IDisposable)@lock).Dispose();
						throw;
					}
					((IDisposable)@lock).Dispose();
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR2);
					throw;
				}
				_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR2)));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
				throw;
			}
			_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CITuneRequest_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CITuneRequest_003E_002E_007Bdtor_007D), &cComPtr_003CITuneRequest_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CITuneRequest_003E_002E_007Bdtor_007D((CComPtrBase_003CITuneRequest_003E*)(&cComPtr_003CITuneRequest_003E));
	}

	private unsafe ulong TPGetBitRate(RecorderStreamType rst)
	{
		ulong result = 0uL;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, global::RecorderStreamType, ulong*, int>)(int)(*(uint*)(*(int*)num + 88)))((IntPtr)num, (global::RecorderStreamType)rst, &result));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		return result;
	}

	private unsafe RecorderUse TPGetRecorderUse()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out global::RecorderUse result);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, global::RecorderUse*, int>)(int)(*(uint*)(*(int*)num + 92)))((IntPtr)num, &result));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		return (RecorderUse)result;
	}

	private unsafe int TPGetSignalStrength()
	{
		int result = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, int*, int>)(int)(*(uint*)(*(int*)num + 96)))((IntPtr)num, &result));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		return result;
	}

	private unsafe string TPGetMMIMessage(byte dialogNumber)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
		*(int*)(&cComBSTR) = 0;
		string result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
			CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
			try
			{
				int num = *(int*)ptr;
				MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, byte, ushort**, int>)(int)(*(uint*)(*(int*)num + 100)))((IntPtr)num, dialogNumber, (ushort**)(&cComBSTR)));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
			if (!(*(int*)(&cComBSTR) == 0))
			{
				result = new string((char*)(int)(*(uint*)(&cComBSTR)));
				goto IL_0063;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		string result2;
		try
		{
			result2 = null;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		return result2;
		IL_0063:
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		return result;
	}

	private unsafe void TPNotifyMMIClosed(byte dialogNumber, MMICloseReasonType closeReason)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, byte, global::MMICloseReasonType, int>)(int)(*(uint*)(*(int*)num + 104)))((IntPtr)num, dialogNumber, (global::MMICloseReasonType)closeReason));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
	}

	private unsafe void TPGetEASEventInfo(uint eventID, string ISO639Code)
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CITuneRequest_003E cComPtr_003CITuneRequest_003E);
		*(int*)(&cComPtr_003CITuneRequest_003E) = 0;
		try
		{
			uint startTime = 0u;
			ushort duration = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
			*(int*)(&cComBSTR) = 0;
			try
			{
				if (ISO639Code != null)
				{
					ushort* ptr = (ushort*)Marshal.StringToBSTR(ISO639Code).ToPointer();
					if (null != ptr)
					{
						_003CModule_003E.SysFreeString(null);
						*(int*)(&cComBSTR) = (int)ptr;
					}
				}
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR2);
				*(int*)(&cComBSTR2) = 0;
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR3);
					*(int*)(&cComBSTR3) = 0;
					try
					{
						System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
						CComPtr_003CIRecorderEx2_003E* ptr2 = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
						try
						{
							int num = *(int*)ptr2;
							int num2 = *(int*)(&cComBSTR);
							MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint, ITuneRequest**, uint*, ushort*, ushort*, ushort**, ushort**, int>)(int)(*(uint*)(*(int*)num + 108)))((IntPtr)num, eventID, (ITuneRequest**)(&cComPtr_003CITuneRequest_003E), &startTime, &duration, (ushort*)num2, (ushort**)(&cComBSTR2), (ushort**)(&cComBSTR3)));
						}
						catch
						{
							//try-fault
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
							throw;
						}
						_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
						TuneRequest eASTR = _003CModule_003E.smethod_58((IUnknown*)(int)(*(uint*)(&cComPtr_003CITuneRequest_003E)));
						@lock lock2 = new @lock(m_Lock);
						try
						{
							@lock = lock2;
							m_EASTR = eASTR;
							m_StartTime = startTime;
							m_Duration = duration;
							if (!(*(int*)(&cComBSTR2) == 0))
							{
								m_ActivationNature = new string((char*)(int)(*(uint*)(&cComBSTR2)));
							}
							else
							{
								m_ActivationNature = null;
							}
							if (!(*(int*)(&cComBSTR3) == 0))
							{
								m_AlertMessage = new string((char*)(int)(*(uint*)(&cComBSTR3)));
							}
							else
							{
								m_AlertMessage = null;
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
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR3);
						throw;
					}
					_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR3)));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR2);
					throw;
				}
				_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR2)));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
				throw;
			}
			_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CITuneRequest_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CITuneRequest_003E_002E_007Bdtor_007D), &cComPtr_003CITuneRequest_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CITuneRequest_003E_002E_007Bdtor_007D((CComPtrBase_003CITuneRequest_003E*)(&cComPtr_003CITuneRequest_003E));
	}

	[return: MarshalAs(UnmanagedType.U1)]
	private unsafe bool TPGetCASCardStatus()
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out global::CasCardStatusType casStatus);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out global::CasCardAssociationType casAssoc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num2);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, global::CasCardStatusType*, global::CasCardAssociationType*, short*, int>)(int)(*(uint*)(*(int*)num + 112)))((IntPtr)num, &casStatus, &casAssoc, &num2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		@lock lock2 = new @lock(m_Lock);
		bool result;
		try
		{
			@lock = lock2;
			m_CasStatus = (CasCardStatusType)casStatus;
			m_CasAssoc = (CasCardAssociationType)casAssoc;
			result = num2 == -1;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return result;
	}

	private unsafe SmartCardApplication[] TPGetSmartCardApplications()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num2);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint*, int>)(int)(*(uint*)(*(int*)num + 116)))((IntPtr)num, &num2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		SmartCardApplication[] array = new SmartCardApplication[num2];
		uint num3 = 0u;
		if (0 < num2)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out global::SmartCardApplication smartCardApplication);
			do
			{
				CComPtr_003CIRecorderEx2_003E* ptr2 = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E2);
				try
				{
					int num4 = *(int*)ptr2;
					MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint, global::SmartCardApplication*, int>)(int)(*(uint*)(*(int*)num4 + 120)))((IntPtr)num4, num3, &smartCardApplication));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E2);
					throw;
				}
				_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D(&cComPtr_003CIRecorderEx2_003E2);
				SmartCardApplication value = _003CModule_003E.smethod_63(&smartCardApplication);
				array.SetValue(value, (int)num3);
				num3++;
			}
			while (num3 < num2);
		}
		return array;
	}

	private unsafe object TPGetDiagnosticProperty(string propertyName)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
		*(int*)(&cComBSTR) = 0;
		object objectForNativeVariant;
		try
		{
			ushort* ptr = (ushort*)Marshal.StringToBSTR(propertyName).ToPointer();
			if (null != ptr)
			{
				_003CModule_003E.SysFreeString(null);
				*(int*)(&cComBSTR) = (int)ptr;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComVariant cComVariant);
			_003CModule_003E.VariantInit((tagVARIANT*)(&cComVariant));
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
				CComPtr_003CIRecorderEx2_003E* ptr2 = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
				try
				{
					int num = *(int*)ptr2;
					int num2 = *(int*)(&cComBSTR);
					MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ushort*, tagVARIANT*, int>)(int)(*(uint*)(*(int*)num + 124)))((IntPtr)num, (ushort*)num2, (tagVARIANT*)(&cComVariant)));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
					throw;
				}
				_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
				objectForNativeVariant = Marshal.GetObjectForNativeVariant((IntPtr)(&cComVariant));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComVariant*, void>)(&_003CModule_003E.ATL_002ECComVariant_002E_007Bdtor_007D), &cComVariant);
				throw;
			}
			_003CModule_003E.VariantClear((tagVARIANT*)(&cComVariant));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		return objectForNativeVariant;
	}

	private unsafe void TPPerformDRMPairing()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, int>)(int)(*(uint*)(*(int*)num + 136)))((IntPtr)num));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
	}

	private unsafe int TPGetDRMPairingStatus()
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out global::DrmPairingStatus drmStatus);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num2);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, global::DrmPairingStatus*, int*, int>)(int)(*(uint*)(*(int*)num + 132)))((IntPtr)num, &drmStatus, &num2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		@lock lock2 = new @lock(m_Lock);
		int result;
		try
		{
			@lock = lock2;
			m_DrmStatus = (DrmPairingStatus)drmStatus;
			result = num2;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return result;
	}

	private unsafe uint TPCheckEntitlementToken(BDA_CONDITIONALACCESS_REQUESTTYPE request, byte[] token, [MarshalAs(UnmanagedType.U1)] bool expectDialog, string language)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected I4, but got Unknown
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
		*(int*)(&cComBSTR) = 0;
		uint result;
		try
		{
			if (language != null)
			{
				_003CModule_003E.ATL_002ECComBSTR_002EAttach(&cComBSTR, (ushort*)Marshal.StringToBSTR(language).ToPointer());
			}
			tagSAFEARRAY* ptr = null;
			InteropHelper.ByteArrayToSafeArray(&ptr, token);
			int num = -1;
			if (!expectDialog)
			{
				num = ~num;
			}
			short num2 = (short)num;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
			CComPtr_003CIRecorderEx2_003E* ptr2 = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint dialogRequest);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num5);
			try
			{
				int num3 = *(int*)ptr2;
				tagSAFEARRAY* intPtr = ptr;
				int num4 = *(int*)(&cComBSTR);
				MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, BDA_CONDITIONALACCESS_REQUESTTYPE, tagSAFEARRAY*, short, ushort*, uint*, uint*, int>)(int)(*(uint*)(*(int*)num3 + 144)))((IntPtr)num3, (BDA_CONDITIONALACCESS_REQUESTTYPE)request, intPtr, num2, (ushort*)num4, &dialogRequest, &num5));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
			MarshalHelper.ComException(_003CModule_003E.SafeArrayDestroy(ptr));
			@lock lock2 = new @lock(m_Lock);
			try
			{
				@lock = lock2;
				m_DialogRequest = dialogRequest;
				result = num5;
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		return result;
	}

	private unsafe void TPSetCaptureToken(byte[] token)
	{
		tagSAFEARRAY* ptr = null;
		InteropHelper.ByteArrayToSafeArray(&ptr, token);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr2 = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num = *(int*)ptr2;
			tagSAFEARRAY* intPtr = ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, tagSAFEARRAY*, int>)(int)(*(uint*)(*(int*)num + 148)))((IntPtr)num, intPtr));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		MarshalHelper.ComException(_003CModule_003E.SafeArrayDestroy(ptr));
	}

	private unsafe uint TPOpenBroadcastMmi(uint eventID, [MarshalAs(UnmanagedType.U1)] bool expectDialog, string language)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
		*(int*)(&cComBSTR) = 0;
		uint result;
		try
		{
			if (language != null)
			{
				ushort* ptr = (ushort*)Marshal.StringToBSTR(language).ToPointer();
				if (null != ptr)
				{
					_003CModule_003E.SysFreeString(null);
					*(int*)(&cComBSTR) = (int)ptr;
				}
			}
			uint num = 0u;
			int num2 = -1;
			if (!expectDialog)
			{
				num2 = ~num2;
			}
			short num3 = (short)num2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
			CComPtr_003CIRecorderEx2_003E* ptr2 = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
			try
			{
				int num4 = *(int*)ptr2;
				int num5 = *(int*)(&cComBSTR);
				MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint, short, ushort*, uint*, int>)(int)(*(uint*)(*(int*)num4 + 152)))((IntPtr)num4, eventID, num3, (ushort*)num5, &num));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
			result = num;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		return result;
	}

	private unsafe uint TPCloseMmiDialog(uint dialogNumber, BDA_CONDITIONALACCESS_MMICLOSEREASON reason, [MarshalAs(UnmanagedType.U1)] bool expectDialog, string language)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected I4, but got Unknown
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
		*(int*)(&cComBSTR) = 0;
		uint result;
		try
		{
			if (language != null)
			{
				_003CModule_003E.ATL_002ECComBSTR_002EAttach(&cComBSTR, (ushort*)Marshal.StringToBSTR(language).ToPointer());
			}
			int num = -1;
			if (!expectDialog)
			{
				num = ~num;
			}
			short num2 = (short)num;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
			CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint dialogRequest);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num5);
			try
			{
				int num3 = *(int*)ptr;
				int num4 = *(int*)(&cComBSTR);
				MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint, BDA_CONDITIONALACCESS_MMICLOSEREASON, short, ushort*, uint*, uint*, int>)(int)(*(uint*)(*(int*)num3 + 156)))((IntPtr)num3, dialogNumber, (BDA_CONDITIONALACCESS_MMICLOSEREASON)reason, num2, (ushort*)num4, &dialogRequest, &num5));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
			@lock lock2 = new @lock(m_Lock);
			try
			{
				@lock = lock2;
				m_DialogRequest = dialogRequest;
				result = num5;
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		return result;
	}

	private unsafe string TPGPNVSNameByIndex(uint index)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
		*(int*)(&cComBSTR) = 0;
		string result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
			CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
			try
			{
				int num = *(int*)ptr;
				MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint, ushort**, int>)(int)(*(uint*)(*(int*)num + 160)))((IntPtr)num, index, (ushort**)(&cComBSTR)));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
			if (!(*(int*)(&cComBSTR) == 0))
			{
				result = new string((char*)(int)(*(uint*)(&cComBSTR)));
				goto IL_0066;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		string result2;
		try
		{
			result2 = null;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		return result2;
		IL_0066:
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		return result;
	}

	private unsafe string TPGetGPNVSValue(string name, string language)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
		*(int*)(&cComBSTR) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		string result;
		try
		{
			if (name != null)
			{
				ushort* ptr = (ushort*)Marshal.StringToBSTR(name).ToPointer();
				if (null != ptr)
				{
					_003CModule_003E.SysFreeString(null);
					*(int*)(&cComBSTR) = (int)ptr;
				}
			}
			*(int*)(&cComBSTR2) = 0;
			try
			{
				if (language != null)
				{
					ushort* ptr2 = (ushort*)Marshal.StringToBSTR(language).ToPointer();
					if (null != ptr2)
					{
						_003CModule_003E.SysFreeString(null);
						*(int*)(&cComBSTR2) = (int)ptr2;
					}
				}
				*(int*)(&cComBSTR3) = 0;
				try
				{
					TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
					try
					{
						int num = *(int*)(&cComPtr_003CIRecorderEx2_003E);
						int num2 = *(int*)(&cComBSTR);
						int num3 = *(int*)(&cComBSTR2);
						MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ushort*, ushort*, ushort**, int>)(int)(*(uint*)(*(int*)(int)(*(uint*)(&cComPtr_003CIRecorderEx2_003E)) + 168)))((IntPtr)num, (ushort*)num2, (ushort*)num3, (ushort**)(&cComBSTR3)));
						if (!(*(int*)(&cComBSTR3) == 0))
						{
							result = new string((char*)(int)(*(uint*)(&cComBSTR3)));
							goto IL_009f;
						}
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
						throw;
					}
					goto end_IL_004e;
					IL_009f:
					_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
					goto IL_00b6;
					end_IL_004e:;
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR3);
					throw;
				}
				goto end_IL_0029;
				IL_00b6:
				_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR3)));
				goto IL_00ce;
				end_IL_0029:;
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR2);
				throw;
			}
			goto end_IL_0004;
			IL_00ce:
			_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR2)));
			goto IL_00e6;
			end_IL_0004:;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		string result2;
		try
		{
			try
			{
				try
				{
					try
					{
						result2 = null;
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
						throw;
					}
					_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR3);
					throw;
				}
				_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR3)));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR2);
				throw;
			}
			_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR2)));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		return result2;
		IL_00e6:
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		return result;
	}

	private unsafe uint TPSetGPNVSValue(string name, string language, [MarshalAs(UnmanagedType.U1)] bool expectDialog, string value)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
		*(int*)(&cComBSTR) = 0;
		uint result;
		try
		{
			if (name != null)
			{
				_003CModule_003E.ATL_002ECComBSTR_002EAttach(&cComBSTR, (ushort*)Marshal.StringToBSTR(name).ToPointer());
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR2);
			*(int*)(&cComBSTR2) = 0;
			try
			{
				if (language != null)
				{
					_003CModule_003E.ATL_002ECComBSTR_002EAttach(&cComBSTR2, (ushort*)Marshal.StringToBSTR(language).ToPointer());
				}
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR3);
				*(int*)(&cComBSTR3) = 0;
				try
				{
					if (language != null)
					{
						ushort* ptr = (ushort*)Marshal.StringToBSTR(value).ToPointer();
						if (null != ptr)
						{
							_003CModule_003E.SysFreeString(null);
							*(int*)(&cComBSTR3) = (int)ptr;
						}
					}
					int num = -1;
					if (!expectDialog)
					{
						num = ~num;
					}
					short num2 = (short)num;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
					CComPtr_003CIRecorderEx2_003E* ptr2 = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num7);
					try
					{
						int num3 = *(int*)ptr2;
						int num4 = *(int*)(&cComBSTR);
						int num5 = *(int*)(&cComBSTR3);
						int num6 = *(int*)(&cComBSTR2);
						MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ushort*, ushort*, short, ushort*, uint*, int>)(int)(*(uint*)(*(int*)num3 + 164)))((IntPtr)num3, (ushort*)num4, (ushort*)num5, num2, (ushort*)num6, &num7));
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
						throw;
					}
					_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
					result = num7;
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR3);
					throw;
				}
				_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR3)));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR2);
				throw;
			}
			_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR2)));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		return result;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	private unsafe bool TPDoesSupportDiseqC()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num2);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, short*, int>)(int)(*(uint*)(*(int*)num + 172)))((IntPtr)num, &num2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		return num2 == -1;
	}

	private unsafe void TPSetIsdbCasRequest(uint requestID, byte[] command)
	{
		tagSAFEARRAY* ptr = null;
		InteropHelper.ByteArrayToSafeArray(&ptr, command);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr2 = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num = *(int*)ptr2;
			tagSAFEARRAY* intPtr = ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint, tagSAFEARRAY*, int>)(int)(*(uint*)(*(int*)num + 176)))((IntPtr)num, requestID, intPtr));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		MarshalHelper.ComException(_003CModule_003E.SafeArrayDestroy(ptr));
	}

	private unsafe uint TPPurchaseEntitlement([MarshalAs(UnmanagedType.U1)] bool expectDialog, byte[] token, string language)
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
		*(int*)(&cComBSTR) = 0;
		uint result;
		try
		{
			if (language != null)
			{
				ushort* ptr = (ushort*)Marshal.StringToBSTR(language).ToPointer();
				if (null != ptr)
				{
					_003CModule_003E.SysFreeString(null);
					*(int*)(&cComBSTR) = (int)ptr;
				}
			}
			tagSAFEARRAY* ptr2 = null;
			tagSAFEARRAY* ptr3 = null;
			InteropHelper.ByteArrayToSafeArray(&ptr2, token);
			int num = -1;
			if (!expectDialog)
			{
				num = ~num;
			}
			short num2 = (short)num;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
			CComPtr_003CIRecorderEx2_003E* ptr4 = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint dialogRequest);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num5);
			try
			{
				int num3 = *(int*)ptr4;
				tagSAFEARRAY* intPtr = ptr2;
				int num4 = *(int*)(&cComBSTR);
				MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, short, tagSAFEARRAY*, ushort*, uint*, tagSAFEARRAY**, uint*, int>)(int)(*(uint*)(*(int*)num3 + 180)))((IntPtr)num3, num2, intPtr, (ushort*)num4, &dialogRequest, &ptr3, &num5));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
			MarshalHelper.ComException(_003CModule_003E.SafeArrayDestroy(ptr2));
			byte[] @ref = null;
			if (ptr3 != null)
			{
				@ref = InteropHelper.SafeArrayToByteArray(&ptr3);
			}
			@lock lock2 = new @lock(m_Lock);
			try
			{
				@lock = lock2;
				m_DialogRequest = dialogRequest;
				m_CaptureToken = _003CModule_003E.smethod_61(@ref);
				result = num5;
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		return result;
	}

	private unsafe void TPCancelCaptureToken(byte[] token)
	{
		tagSAFEARRAY* ptr = null;
		InteropHelper.ByteArrayToSafeArray(&ptr, token);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr2 = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num = *(int*)ptr2;
			tagSAFEARRAY* intPtr = ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, tagSAFEARRAY*, int>)(int)(*(uint*)(*(int*)num + 184)))((IntPtr)num, intPtr));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		MarshalHelper.ComException(_003CModule_003E.SafeArrayDestroy(ptr));
	}

	[return: MarshalAs(UnmanagedType.U1)]
	private unsafe bool TPSupportsConditionalAccess()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num2);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, short*, int>)(int)(*(uint*)(*(int*)num + 188)))((IntPtr)num, &num2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		return num2 == -1;
	}

	private unsafe void TPRenewLicenses(string fileName, string expiredKid, uint callersId, [MarshalAs(UnmanagedType.U1)] bool highPriority)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
		*(int*)(&cComBSTR) = 0;
		try
		{
			if (fileName != null)
			{
				_003CModule_003E.ATL_002ECComBSTR_002EAttach(&cComBSTR, (ushort*)Marshal.StringToBSTR(fileName).ToPointer());
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR2);
			*(int*)(&cComBSTR2) = 0;
			try
			{
				if (expiredKid != null)
				{
					ushort* ptr = (ushort*)Marshal.StringToBSTR(expiredKid).ToPointer();
					if (null != ptr)
					{
						_003CModule_003E.SysFreeString(null);
						*(int*)(&cComBSTR2) = (int)ptr;
					}
				}
				int num = (highPriority ? 1 : 0);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
				CComPtr_003CIRecorderEx2_003E* ptr2 = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
				try
				{
					int num2 = *(int*)ptr2;
					int num3 = *(int*)(&cComBSTR);
					int num4 = *(int*)(&cComBSTR2);
					MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ushort*, ushort*, uint, int, int>)(int)(*(uint*)(*(int*)num2 + 192)))((IntPtr)num2, (ushort*)num3, (ushort*)num4, callersId, num));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
					throw;
				}
				_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR2);
				throw;
			}
			_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR2)));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
	}

	[return: MarshalAs(UnmanagedType.U1)]
	private unsafe bool TPSupportsPBDAScanning()
	{
		m_GuideTypeGuid = Guid.Empty;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _GUID gUID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num2);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, _GUID*, short*, int>)(int)(*(uint*)(*(int*)num + 200)))((IntPtr)num, &gUID, &num2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		ref Guid guideTypeGuid = ref m_GuideTypeGuid;
		guideTypeGuid = *(Guid*)(int)(ref gUID);
		return num2 == -1;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	private unsafe bool TPPassiveClientsExist()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num2);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, short*, int>)(int)(*(uint*)(*(int*)num + 204)))((IntPtr)num, &num2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		return num2 == -1;
	}

	private unsafe void TPSetTunerUseReason(TunerUseReason useReason)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, global::TunerUseReason, int>)(int)(*(uint*)(*(int*)num + 208)))((IntPtr)num, (global::TunerUseReason)useReason));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
	}

	private unsafe uint TPGetUserActivityInterval()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint result);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint*, int>)(int)(*(uint*)(*(int*)num + 212)))((IntPtr)num, &result));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		return result;
	}

	private unsafe void TPUserActivityDetected()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* ptr = TPGetRecorderPtr(&cComPtr_003CIRecorderEx2_003E);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, int>)(int)(*(uint*)(*(int*)num + 216)))((IntPtr)num));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
	}

	private void TPAdvise(Guid g)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			m_Recorder?.TPAdvise(g);
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	private void TPDtor(IntPtr hTuner, SafeRecorder rec)
	{
		try
		{
			if (rec != null)
			{
				rec.TPUnadvise(this);
				((IDisposable)rec).Dispose();
			}
			TPDtor(hTuner);
		}
		catch (COMException)
		{
		}
	}

	private void CloneCache(Tuner from)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			m_dwId = from.m_dwId;
			ref Guid guidId = ref m_GuidId;
			guidId = from.m_GuidId;
			m_DeviceName = from.m_DeviceName;
			m_RootDeviceName = from.m_RootDeviceName;
			m_RootDeviceNameInstanceId = from.m_RootDeviceNameInstanceId;
			ref bool? bConfigured = ref m_bConfigured;
			bConfigured = from.m_bConfigured;
			m_FriendlyName = from.m_FriendlyName;
			m_dwViewOrder = from.m_dwViewOrder;
			m_bPrefView = from.m_bPrefView;
			m_dwRecordOrder = from.m_dwRecordOrder;
			m_bPrefRecord = from.m_bPrefRecord;
			m_ConfiguredTSNames = _003CModule_003E.smethod_62(from.m_ConfiguredTSNames);
			ref int? state = ref m_State;
			state = from.m_State;
			((IDisposable)m_CurrentTR)?.Dispose();
			_003CModule_003E.smethod_60(from.m_CurrentTR);
			ref int? sIID = ref m_SIID;
			sIID = from.m_SIID;
			ref int? hr = ref m_hr;
			hr = from.m_hr;
			m_ClientIDs = _003CModule_003E.smethod_62(from.m_ClientIDs);
			ref bool? busy = ref m_Busy;
			busy = from.m_Busy;
			ref TunerType? tunerType = ref m_TunerType;
			tunerType = from.m_TunerType;
			m_TVFormats = from.m_TVFormats;
			m_NumAuxInputs = from.m_NumAuxInputs;
			m_HWSupportedNetworkTypes = _003CModule_003E.smethod_70(from.m_HWSupportedNetworkTypes);
			ref ProtType? cPType = ref m_CPType;
			cPType = from.m_CPType;
			ref uint? encoderMin = ref m_EncoderMin;
			encoderMin = from.m_EncoderMin;
			m_EncoderMax = from.m_EncoderMax;
			m_EncoderDelta = from.m_EncoderDelta;
			((IDisposable)m_ConfiguredDefaultTR)?.Dispose();
			m_ConfiguredDefaultTR = _003CModule_003E.smethod_60(from.m_ConfiguredDefaultTR);
			ref bool? bUseSTB = ref m_bUseSTB;
			bUseSTB = from.m_bUseSTB;
			m_IRControlBlob = _003CModule_003E.smethod_61(from.m_IRControlBlob);
			ref RecorderUse? use = ref m_Use;
			use = from.m_Use;
			ref bool? doesDiseqC = ref m_DoesDiseqC;
			doesDiseqC = from.m_DoesDiseqC;
			ref bool? supportsConditionalAccess = ref m_SupportsConditionalAccess;
			supportsConditionalAccess = from.m_SupportsConditionalAccess;
			ref bool? passiveClientsExist = ref m_PassiveClientsExist;
			passiveClientsExist = from.m_PassiveClientsExist;
			ref bool? isPbda = ref m_IsPbda;
			isPbda = from.m_IsPbda;
			ref bool? isMandatoryParentalControl = ref m_IsMandatoryParentalControl;
			isMandatoryParentalControl = from.m_IsMandatoryParentalControl;
			m_PbdaId = from.m_PbdaId;
			m_BcasId = from.m_BcasId;
			m_SupportedLanguages = from.m_SupportedLanguages;
			ref Evt<TunerNotificationEventArgs2<Guid, ESEvent>> eSEvent = ref ESEvent;
			eSEvent = from.ESEvent;
			ref Evt<TunerNotificationEventArgs1<string>> profileChangedEvent = ref ProfileChangedEvent;
			profileChangedEvent = from.ProfileChangedEvent;
			ref Evt<TunerNotificationEventArgs1<bool>> usageChangedEvent = ref UsageChangedEvent;
			usageChangedEvent = from.UsageChangedEvent;
			ref Evt<TunerNotificationEventArgs2<uint, uint>> encoderSettingsChangedEvent = ref EncoderSettingsChangedEvent;
			encoderSettingsChangedEvent = from.EncoderSettingsChangedEvent;
			ref Evt<TunerNotificationEventArgs1<TuneRequest>> tuningChangedEvent = ref TuningChangedEvent;
			tuningChangedEvent = from.TuningChangedEvent;
			ref Evt<TunerNotificationEventArgs1<int>> errorEvent = ref ErrorEvent;
			errorEvent = from.ErrorEvent;
			ref Evt<TunerNotificationEventArgs2<ushort, ushort>> stateChangedEvent = ref StateChangedEvent;
			stateChangedEvent = from.StateChangedEvent;
			ref Evt<TunerNotificationEventArgs1<bool>> readyEvent = ref ReadyEvent;
			readyEvent = from.ReadyEvent;
			ref Evt<TunerNotificationEventArgs1<bool>> certificateEvent = ref CertificateEvent;
			certificateEvent = from.CertificateEvent;
			ref Evt<TunerNotificationEventArgs1<bool>> encryptionEvent = ref EncryptionEvent;
			encryptionEvent = from.EncryptionEvent;
			ref Evt<EventArgs> writeFailureEvent = ref WriteFailureEvent;
			writeFailureEvent = from.WriteFailureEvent;
			ref Evt<TunerNotificationEventArgs1<int>> contentSIIDChangedEvent = ref ContentSIIDChangedEvent;
			contentSIIDChangedEvent = from.ContentSIIDChangedEvent;
			ref Evt<TunerNotificationEventArgs3<RecorderStreamType, RecorderBitRateChangeType, ulong>> bitRateChangedEvent = ref BitRateChangedEvent;
			bitRateChangedEvent = from.BitRateChangedEvent;
			ref Evt<TunerNotificationEventArgs1<bool>> channelAvailableEvent = ref ChannelAvailableEvent;
			channelAvailableEvent = from.ChannelAvailableEvent;
			ref Evt<EventArgs> statusChangedEvent = ref StatusChangedEvent;
			statusChangedEvent = from.StatusChangedEvent;
			ref Evt<TunerNotificationEventArgs6<EnTvRat_System, EnTvRat_GenericLevel, BfEnTvRat_GenericAttributes, EnTvRat_System, EnTvRat_GenericLevel, BfEnTvRat_GenericAttributes>> ratingChangedEvent = ref RatingChangedEvent;
			ratingChangedEvent = from.RatingChangedEvent;
			ref Evt<TunerNotificationEventArgs1<ProtType>> protectionTypeChangedEvent = ref ProtectionTypeChangedEvent;
			protectionTypeChangedEvent = from.ProtectionTypeChangedEvent;
			ref Evt<TunerNotificationEventArgs2<uint, EasPriorityType>> easReceivedEvent = ref EasReceivedEvent;
			easReceivedEvent = from.EasReceivedEvent;
			ref Evt<TunerNotificationEventArgs2<bool, uint>> mMIReceivedEvent = ref MMIReceivedEvent;
			mMIReceivedEvent = from.MMIReceivedEvent;
			ref Evt<TunerNotificationEventArgs1<CasCardStatusType>> casCardStatusChangedEvent = ref CasCardStatusChangedEvent;
			casCardStatusChangedEvent = from.CasCardStatusChangedEvent;
			ref Evt<TunerNotificationEventArgs1<DrmPairingStatus>> drmPairingStatusChangedEvent = ref DrmPairingStatusChangedEvent;
			drmPairingStatusChangedEvent = from.DrmPairingStatusChangedEvent;
			ref Evt<TunerNotificationEventArgs1<CasEntitlementType>> casEntitlementChangedEvent = ref CasEntitlementChangedEvent;
			casEntitlementChangedEvent = from.CasEntitlementChangedEvent;
			ref Evt<EventArgs> writeFailureClearEvent = ref WriteFailureClearEvent;
			writeFailureClearEvent = from.WriteFailureClearEvent;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	public unsafe Tuner(IntPtr ptr)
	{
		Guid primaryIID = PrimaryIID;
		base._002Ector((_GUID*)(int)(ref primaryIID), (IUnknown*)ptr.ToPointer());
		try
		{
			_instanceLabel = Interlocked.Increment(ref s_nextInstanceLabel);
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(disposing: true);
			throw;
		}
	}

	public unsafe Tuner(IRecorderInfo* pTuner, Guid g)
	{
		m_GuidId = g;
		base._002Ector((_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_379848e6_2751_42c0_8de6_9457cdc61d60), (IUnknown*)pTuner);
		try
		{
			_instanceLabel = Interlocked.Increment(ref s_nextInstanceLabel);
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(disposing: true);
			throw;
		}
	}

	private Tuner()
	{
		try
		{
			_instanceLabel = Interlocked.Increment(ref s_nextInstanceLabel);
			_profile = string.Empty;
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(disposing: true);
			throw;
		}
	}

	private void method_2()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		IntPtr hTuner;
		SafeRecorder recorder;
		try
		{
			@lock = lock2;
			hTuner = handle;
			handle = IntPtr.Zero;
			recorder = m_Recorder;
			m_Recorder = null;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		TPDtor(hTuner, recorder);
	}

	internal void TPSetRecorder(SafeRecorder pRecorder)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			SafeRecorder recorder = m_Recorder;
			if (recorder != null)
			{
				recorder.TPUnadvise(this);
				((IDisposable)m_Recorder)?.Dispose();
				m_Recorder = null;
			}
			if (pRecorder != null)
			{
				(m_Recorder = (SafeRecorder)pRecorder.ReferenceClone()).TPAdvise(this);
				NLClearCachedRecorderState();
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

	internal void Disconnect()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			((IDisposable)m_Recorder)?.Dispose();
			m_Recorder = null;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	internal void NLClearCachedRecorderState()
	{
		((IDisposable)m_CurrentTR)?.Dispose();
		m_CurrentTR = null;
		((IDisposable)m_ConfiguredDefaultTR)?.Dispose();
		m_ConfiguredDefaultTR = null;
		m_bUseSTB = null;
		m_IRControlBlob = null;
		m_Use = null;
		m_DoesDiseqC = null;
		m_SupportsConditionalAccess = null;
		m_SupportsPBDAScanning = null;
		m_PassiveClientsExist = null;
		m_ConfiguredTSNames = null;
		m_BcasId = null;
		((IDisposable)m_EASTR)?.Dispose();
		m_EASTR = null;
	}

	internal void SetCurrentUse(RecorderUse ru)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			RecorderUse? recorderUse = (m_Use = ru);
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	internal void ClearCurrentUse()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			m_Use = null;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	internal static void Delete(Tuner t)
	{
		((IDisposable)t)?.Dispose();
	}

	public void ClearCache()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			m_dwId = uint.MaxValue;
			m_DeviceName = null;
			m_RootDeviceName = null;
			m_RootDeviceNameInstanceId = null;
			m_State = null;
			m_SIID = null;
			m_hr = null;
			m_ClientIDs = null;
			m_Busy = null;
			NLClearCachedRecorderState();
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	private void method_3()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		IntPtr a;
		SafeRecorder recorder;
		try
		{
			@lock = lock2;
			a = handle;
			handle = IntPtr.Zero;
			recorder = m_Recorder;
			m_Recorder = null;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		dv2<IntPtr, SafeRecorder> dv11 = TPDtor;
		dv11.BeginInvoke(a, recorder, InteropHelper.smethod_67, dv11);
	}

	public override SafeComWrapper ReferenceClone()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		Tuner tuner;
		try
		{
			@lock = lock2;
			tuner = (Tuner)base.ReferenceClone();
			SafeRecorder recorder = m_Recorder;
			if (recorder != null)
			{
				tuner.Recorder = recorder;
			}
			tuner.CloneCache(this);
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return tuner;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool IsSupportedTuneRequest(TuneRequest tr)
	{
		int num = ((tr != null && ((IList)ConfiguredTuningSpaces).Contains((object?)tr.get_TuningSpace().get_UniqueName())) ? 1 : 0);
		return (byte)num != 0;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool IsSameTuneRequest(TuneRequest tr, [MarshalAs(UnmanagedType.U1)] bool componentCheck)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		BDA_Comp_Flags val = (BDA_Comp_Flags)(componentCheck ? 6 : 2);
		int num = ((tr != null && CurrentTuneRequest != null && CurrentTuneRequest.CompareEquivalent((object)tr, (BDA_Comp_Flags)(int)val) == 0) ? 1 : 0);
		return (byte)num != 0;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool IsSameTuningSpace(TuneRequest tr)
	{
		int num = ((tr != null && CurrentTuneRequest != null && CurrentTuneRequest.get_TuningSpace().get_UniqueName() == tr.get_TuningSpace().get_UniqueName()) ? 1 : 0);
		return (byte)num != 0;
	}

	public void OpenMedia(TuneRequest tr)
	{
		InteropHelper.smethod_3(new dv1<TuneRequest>(TPOpenMedia).BeginInvoke(tr, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::OpenMedia");
	}

	public void CloseMedia()
	{
		InteropHelper.smethod_1(new dv0(TPCloseMedia).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::CloseMedia");
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool ValidateTuneRequest(TuneRequest tr)
	{
		return InteropHelper.smethod_33(new d1<bool, TuneRequest>(TPValidateTuneRequest).BeginInvoke(tr, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::ValidateTuneRequest");
	}

	public void SetContentSIID(int SIID)
	{
		InteropHelper.smethod_4(new dv1<int>(TPSetContentSIID).BeginInvoke(SIID, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::SetContentSIID");
	}

	public void Stop()
	{
		InteropHelper.smethod_1(new dv0(TPStop).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::Stop");
	}

	public void Record([MarshalAs(UnmanagedType.U1)] bool bAsync)
	{
		InteropHelper.smethod_5(new dv1<bool>(TPRecord).BeginInvoke(bAsync, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::Record");
	}

	public void RecordEx([MarshalAs(UnmanagedType.U1)] bool bOn, uint dwQuality)
	{
		InteropHelper.smethod_6(new dv2<bool, uint>(TPRecordEx).BeginInvoke(bOn, dwQuality, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::RecordEx");
	}

	public void Pause()
	{
		InteropHelper.smethod_1(new dv0(TPPause).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::Pause");
	}

	public void SAP([MarshalAs(UnmanagedType.U1)] bool bOn)
	{
		InteropHelper.smethod_5(new dv1<bool>(TPSAP).BeginInvoke(bOn, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::SAP");
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool ChannelAvailable(TuneRequest tr, out uint strength)
	{
		@lock @lock = null;
		bool result = InteropHelper.smethod_33(new d1<bool, TuneRequest>(TPChannelAvailable).BeginInvoke(tr, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::ChannelAvailable");
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			strength = m_Strength;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return result;
	}

	public void SetMaxVideoEncoderQuality(uint dwQuality)
	{
		InteropHelper.smethod_7(new dv1<uint>(TPSetMaxVideoEncoderQuality).BeginInvoke(dwQuality, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::SetMaxVideoEncoderQuality");
	}

	public void SetRecorderConfig(TuneRequest tr, [MarshalAs(UnmanagedType.U1)] bool useSTB, byte[] IRBlob, string name, uint viewOrder, uint recordOrder, [MarshalAs(UnmanagedType.U1)] bool prefView, [MarshalAs(UnmanagedType.U1)] bool prefRecord, [MarshalAs(UnmanagedType.U1)] bool configured)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		string[] configuredTSNames;
		try
		{
			@lock = lock2;
			configuredTSNames = m_ConfiguredTSNames;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		SetRecorderConfig(tr, useSTB, IRBlob, name, viewOrder, recordOrder, prefView, prefRecord, configured, configuredTSNames);
	}

	public void SetRecorderConfig(TuneRequest tr, [MarshalAs(UnmanagedType.U1)] bool useSTB, byte[] IRBlob, string name, uint viewOrder, uint recordOrder, [MarshalAs(UnmanagedType.U1)] bool prefView, [MarshalAs(UnmanagedType.U1)] bool prefRecord, [MarshalAs(UnmanagedType.U1)] bool configured, string[] configuredTSNames)
	{
		InteropHelper.smethod_8(new dv10<TuneRequest, bool, byte[], string, uint, uint, bool, bool, bool, string[]>(TPSetRecorderConfigEx).BeginInvoke(tr, useSTB, IRBlob, name, viewOrder, recordOrder, prefView, prefRecord, configured, configuredTSNames, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::SetRecorderConfig");
	}

	public void NotifyMMIClosed(byte dialogNumber, MMICloseReasonType closeReason)
	{
		InteropHelper.smethod_9(new dv2<byte, MMICloseReasonType>(TPNotifyMMIClosed).BeginInvoke(dialogNumber, closeReason, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::NotifyMMIClosed");
	}

	public void GetEASEventInfo(uint eventID, string ISO639Code, out TuneRequest tr, out uint startTime, out ushort duration, out string activationNature, out string alertMessage)
	{
		@lock @lock = null;
		InteropHelper.smethod_10(new dv2<uint, string>(TPGetEASEventInfo).BeginInvoke(eventID, ISO639Code, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::GetEASEventInfo");
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			tr = _003CModule_003E.smethod_60(m_EASTR);
			startTime = m_StartTime;
			duration = m_Duration;
			activationNature = m_ActivationNature;
			alertMessage = m_AlertMessage;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool GetCasCardStatus(out CasCardStatusType status, out CasCardAssociationType assoc)
	{
		@lock @lock = null;
		bool result = InteropHelper.smethod_38(new d0<bool>(TPGetCASCardStatus).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::GetCasCardStatus");
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			status = m_CasStatus;
			assoc = m_CasAssoc;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return result;
	}

	public void PerformDRMPairing()
	{
		InteropHelper.smethod_1(new dv0(TPPerformDRMPairing).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::PerformDRMPairing");
	}

	public int GetDRMPairingStatus(out DrmPairingStatus status)
	{
		@lock @lock = null;
		int result = InteropHelper.smethod_36(new d0<int>(TPGetDRMPairingStatus).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::GetDRMPairingStatus");
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			status = m_DrmStatus;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return result;
	}

	public uint CheckEntitlementToken(BDA_CONDITIONALACCESS_REQUESTTYPE request, byte[] token, [MarshalAs(UnmanagedType.U1)] bool expectDialog, string language, out uint dialogRequest)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		@lock @lock = null;
		uint result = InteropHelper.smethod_41(new d4<uint, BDA_CONDITIONALACCESS_REQUESTTYPE, byte[], bool, string>(TPCheckEntitlementToken).BeginInvoke(request, token, expectDialog, language, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::CheckEntitlementToken");
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			dialogRequest = m_DialogRequest;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return result;
	}

	public void SetCaptureToken(byte[] token)
	{
		InteropHelper.smethod_11(new dv1<byte[]>(TPSetCaptureToken).BeginInvoke(token, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::SetCaptureToken");
	}

	public uint OpenBroadcastMmi(uint eventID, [MarshalAs(UnmanagedType.U1)] bool expectDialog, string language)
	{
		return InteropHelper.smethod_42(new d3<uint, uint, bool, string>(TPOpenBroadcastMmi).BeginInvoke(eventID, expectDialog, language, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::OpenBroadcastMmi");
	}

	public uint CloseMmiDialog(uint dialogNumber, BDA_CONDITIONALACCESS_MMICLOSEREASON reason, [MarshalAs(UnmanagedType.U1)] bool expectDialog, string language, out uint dialogRequest)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		@lock @lock = null;
		uint result = InteropHelper.smethod_43(new d4<uint, uint, BDA_CONDITIONALACCESS_MMICLOSEREASON, bool, string>(TPCloseMmiDialog).BeginInvoke(dialogNumber, reason, expectDialog, language, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::CloseMmiDialog");
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			dialogRequest = m_DialogRequest;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return result;
	}

	public uint SetGPNVSValue(string name, string language, [MarshalAs(UnmanagedType.U1)] bool expectDialog, string value)
	{
		return InteropHelper.smethod_46(new d4<uint, string, string, bool, string>(TPSetGPNVSValue).BeginInvoke(name, language, expectDialog, value, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::SetGPNVSValue");
	}

	public void SetIsdbCasRequest(uint requestID, byte[] command)
	{
		InteropHelper.smethod_12(new dv2<uint, byte[]>(TPSetIsdbCasRequest).BeginInvoke(requestID, command, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::SetIsdbCasRequest");
	}

	public uint PurchaseEntitlement([MarshalAs(UnmanagedType.U1)] bool expectDialog, byte[] token, string language, out uint dialogRequest, out byte[] captureToken)
	{
		@lock @lock = null;
		uint result = InteropHelper.smethod_47(new d3<uint, bool, byte[], string>(TPPurchaseEntitlement).BeginInvoke(expectDialog, token, language, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::PurchaseEntitlement");
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			dialogRequest = m_DialogRequest;
			captureToken = _003CModule_003E.smethod_61(m_CaptureToken);
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return result;
	}

	public void CancelCaptureToken(byte[] token)
	{
		InteropHelper.smethod_11(new dv1<byte[]>(TPCancelCaptureToken).BeginInvoke(token, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::CancelCaptureToken");
	}

	public void RenewLicenses(string fileName, string expiredKid, uint callersId, [MarshalAs(UnmanagedType.U1)] bool highPriority)
	{
		InteropHelper.smethod_13(new dv4<string, string, uint, bool>(TPRenewLicenses).BeginInvoke(fileName, expiredKid, callersId, highPriority, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::RenewLicenses");
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool SupportsPBDAScanning(out Guid guid)
	{
		@lock @lock = null;
		if (m_SupportsPBDAScanning.HasValue)
		{
			guid = m_GuideTypeGuid;
			return m_SupportsPBDAScanning.Value;
		}
		bool flag = InteropHelper.smethod_38(new d0<bool>(TPSupportsPBDAScanning).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::SupportsPBDAScanning");
		@lock lock2 = new @lock(m_Lock);
		bool value;
		try
		{
			@lock = lock2;
			guid = m_GuideTypeGuid;
			bool? flag2 = (m_SupportsPBDAScanning = flag);
			value = m_SupportsPBDAScanning.Value;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return value;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool IsConfiguredTuningSpace(string name)
	{
		string[] configuredTuningSpaces = ConfiguredTuningSpaces;
		if (configuredTuningSpaces != null)
		{
			int num = 0;
			if (0 < (nint)configuredTuningSpaces.LongLength)
			{
				do
				{
					string text = configuredTuningSpaces[num];
					if (!(name == text))
					{
						num++;
						continue;
					}
					return true;
				}
				while (num < (nint)configuredTuningSpaces.LongLength);
			}
		}
		return false;
	}

	public void SetTunerUseReason(TunerUseReason useReason)
	{
		InteropHelper.smethod_14(new dv1<TunerUseReason>(TPSetTunerUseReason).BeginInvoke(useReason, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::SetTunerUseReason");
	}

	public uint GetUserActivityInterval()
	{
		return InteropHelper.smethod_48(new d0<uint>(TPGetUserActivityInterval).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::GetUserActivityInterval");
	}

	public void UserActivityDetected()
	{
		InteropHelper.smethod_1(new dv0(TPUserActivityDetected).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::UserActivityDetected");
	}

	public void Advise(Guid g)
	{
		InteropHelper.smethod_15(new dv1<Guid>(TPAdvise).BeginInvoke(g, null, null), "Microsoft::MediaCenter::TV::Tuners::Tuner::Advise");
	}

	internal void OnESEvent(Guid gtype, ESEvent ese)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if (ese == null)
		{
			return;
		}
		if (typeof(ESValueUpdatedEvent).IsAssignableFrom(((object)ese).GetType()))
		{
			string[] valueNames = ((ESValueUpdatedEvent)ese).GetValueNames();
			int num = 0;
			if (0 < (nint)valueNames.LongLength)
			{
				do
				{
					string strA = valueNames[num];
					if (0 == string.Compare(strA, GpnvsNames.BcasId, StringComparison.Ordinal))
					{
						m_BcasId = null;
					}
					num++;
				}
				while (num < (nint)valueNames.LongLength);
			}
		}
		if (typeof(ESSignalAndServiceStatusEvent).IsAssignableFrom(((object)ese).GetType()))
		{
			TunerNotificationEventArgs1<SignalAndServiceStatusState> e = new TunerNotificationEventArgs1<SignalAndServiceStatusState>(((ESSignalAndServiceStatusEvent)ese).get_State());
			SignalAndServiceStatusChangedEvent.raise_Event(this, e);
		}
		else
		{
			TunerNotificationEventArgs2<Guid, ESEvent> e2 = new TunerNotificationEventArgs2<Guid, ESEvent>(gtype, ese);
			ESEvent.raise_Event(this, e2);
		}
		((IDisposable)ese).Dispose();
	}

	internal void OnProfileChanged(string profile)
	{
		_profile = profile;
		TunerNotificationEventArgs1<string> e = new TunerNotificationEventArgs1<string>(profile);
		ProfileChangedEvent.raise_Event(this, e);
	}

	internal void OnUsageChanged([MarshalAs(UnmanagedType.U1)] bool busy)
	{
		TunerNotificationEventArgs1<bool> e = new TunerNotificationEventArgs1<bool>(busy);
		UsageChangedEvent.raise_Event(this, e);
	}

	internal void OnEncoderSettingsChanged(uint video, uint audio)
	{
		TunerNotificationEventArgs2<uint, uint> e = new TunerNotificationEventArgs2<uint, uint>(video, audio);
		EncoderSettingsChangedEvent.raise_Event(this, e);
	}

	internal void OnTuningChanged(TuneRequest tr)
	{
		TunerNotificationEventArgs1<TuneRequest> e = new TunerNotificationEventArgs1<TuneRequest>(tr);
		TuningChangedEvent.raise_Event(this, e);
	}

	internal void OnError(int hr)
	{
		TunerNotificationEventArgs1<int> e = new TunerNotificationEventArgs1<int>(hr);
		ErrorEvent.raise_Event(this, e);
	}

	internal void OnStateChanged(ushort oldState, ushort newState)
	{
		TunerNotificationEventArgs2<ushort, ushort> e = new TunerNotificationEventArgs2<ushort, ushort>(oldState, newState);
		StateChangedEvent.raise_Event(this, e);
	}

	internal void OnReady([MarshalAs(UnmanagedType.U1)] bool ready)
	{
		TunerNotificationEventArgs1<bool> e = new TunerNotificationEventArgs1<bool>(ready);
		ClearCache();
		ReadyEvent.raise_Event(this, e);
	}

	internal void OnCertificate([MarshalAs(UnmanagedType.U1)] bool success)
	{
		TunerNotificationEventArgs1<bool> e = new TunerNotificationEventArgs1<bool>(success);
		CertificateEvent.raise_Event(this, e);
	}

	internal void OnEncryption([MarshalAs(UnmanagedType.U1)] bool on)
	{
		TunerNotificationEventArgs1<bool> e = new TunerNotificationEventArgs1<bool>(on);
		EncryptionEvent.raise_Event(this, e);
	}

	internal void OnWriteFailure()
	{
		EventArgs e = new EventArgs();
		WriteFailureEvent.raise_Event(this, e);
	}

	internal void OnContentSIIDChanged(int siid)
	{
		TunerNotificationEventArgs1<int> e = new TunerNotificationEventArgs1<int>(siid);
		ContentSIIDChangedEvent.raise_Event(this, e);
	}

	internal void OnBitRateChanged(RecorderStreamType st, RecorderBitRateChangeType brt, ulong rate)
	{
		TunerNotificationEventArgs3<RecorderStreamType, RecorderBitRateChangeType, ulong> e = new TunerNotificationEventArgs3<RecorderStreamType, RecorderBitRateChangeType, ulong>(st, brt, rate);
		BitRateChangedEvent.raise_Event(this, e);
	}

	internal void OnChannelAvailable([MarshalAs(UnmanagedType.U1)] bool available)
	{
		TunerNotificationEventArgs1<bool> e = new TunerNotificationEventArgs1<bool>(available);
		ChannelAvailableEvent.raise_Event(this, e);
	}

	internal void OnStatusChanged(RecorderUse prev, RecorderUse current)
	{
		EventArgs e = new EventArgs();
		StatusChangedEvent.raise_Event(this, e);
	}

	internal void OnRatingChanged(EnTvRat_System PrevRatingSystem, EnTvRat_GenericLevel PrevLevel, BfEnTvRat_GenericAttributes PrevAttributes, EnTvRat_System NewRatingSystem, EnTvRat_GenericLevel NewLevel, BfEnTvRat_GenericAttributes NewAttributes)
	{
		TunerNotificationEventArgs6<EnTvRat_System, EnTvRat_GenericLevel, BfEnTvRat_GenericAttributes, EnTvRat_System, EnTvRat_GenericLevel, BfEnTvRat_GenericAttributes> e = new TunerNotificationEventArgs6<EnTvRat_System, EnTvRat_GenericLevel, BfEnTvRat_GenericAttributes, EnTvRat_System, EnTvRat_GenericLevel, BfEnTvRat_GenericAttributes>(PrevRatingSystem, PrevLevel, PrevAttributes, NewRatingSystem, NewLevel, NewAttributes);
		RatingChangedEvent.raise_Event(this, e);
	}

	internal void OnProtectionTypeChanged(ProtType protType)
	{
		TunerNotificationEventArgs1<ProtType> e = new TunerNotificationEventArgs1<ProtType>(protType);
		ProtectionTypeChangedEvent.raise_Event(this, e);
	}

	internal void OnEasReceived(uint eventID, EasPriorityType priority)
	{
		TunerNotificationEventArgs2<uint, EasPriorityType> e = new TunerNotificationEventArgs2<uint, EasPriorityType>(eventID, priority);
		EasReceivedEvent.raise_Event(this, e);
	}

	internal void OnMMIReceived([MarshalAs(UnmanagedType.U1)] bool open, uint dialogNumber)
	{
		TunerNotificationEventArgs2<bool, uint> e = new TunerNotificationEventArgs2<bool, uint>(open, dialogNumber);
		MMIReceivedEvent.raise_Event(this, e);
	}

	internal void OnCasCardStatusChanged(CasCardStatusType cardStatus)
	{
		TunerNotificationEventArgs1<CasCardStatusType> e = new TunerNotificationEventArgs1<CasCardStatusType>(cardStatus);
		CasCardStatusChangedEvent.raise_Event(this, e);
	}

	internal void OnDrmPairingStatusChanged(DrmPairingStatus cardStatus)
	{
		TunerNotificationEventArgs1<DrmPairingStatus> e = new TunerNotificationEventArgs1<DrmPairingStatus>(cardStatus);
		DrmPairingStatusChangedEvent.raise_Event(this, e);
	}

	internal void OnCasEntitlementChanged(CasEntitlementType cardStatus)
	{
		TunerNotificationEventArgs1<CasEntitlementType> e = new TunerNotificationEventArgs1<CasEntitlementType>(cardStatus);
		CasEntitlementChangedEvent.raise_Event(this, e);
	}

	internal void OnWriteFailureClear()
	{
		EventArgs e = new EventArgs();
		WriteFailureClearEvent.raise_Event(this, e);
	}

	internal unsafe int NativeESEventReceived(_GUID gtype, IESEvent* pESEvent)
	{
		ESEvent ese = _003CModule_003E.smethod_67(pESEvent);
		OnESEvent(*(Guid*)(int)(ref gtype), ese);
		return 0;
	}

	internal unsafe int NativeProfileChanged(ushort* wzProfile)
	{
		dv1<string> dv11 = OnProfileChanged;
		string a = null;
		if (wzProfile != null)
		{
			a = new string((char*)wzProfile);
		}
		dv11.BeginInvoke(a, InteropHelper.smethod_68, dv11);
		return 0;
	}

	internal int NativeUsageChanged(short isBusy)
	{
		@lock @lock = null;
		bool flag = isBusy == -1;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			bool? flag2 = (m_Busy = flag);
			m_Use = null;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		dv1<bool> dv11 = OnUsageChanged;
		dv11.BeginInvoke(flag, InteropHelper.smethod_69, dv11);
		return 0;
	}

	internal int NativeEncoderSettingsChanged(uint dwVideo, uint dwAudio)
	{
		dv2<uint, uint> dv11 = OnEncoderSettingsChanged;
		dv11.BeginInvoke(dwVideo, dwAudio, InteropHelper.smethod_70, dv11);
		return 0;
	}

	internal unsafe int NativeTuningChanged(ITuneRequest* pTuneRequest)
	{
		@lock @lock = null;
		TuneRequest val = _003CModule_003E.smethod_68(pTuneRequest);
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			((IDisposable)m_CurrentTR)?.Dispose();
			m_CurrentTR = _003CModule_003E.smethod_60(val);
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		dv1<TuneRequest> dv11 = OnTuningChanged;
		dv11.BeginInvoke(val, InteropHelper.smethod_71, dv11);
		return 0;
	}

	internal int NativeTunerError(int hr)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			int? num = (m_hr = hr);
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		dv1<int> dv11 = OnError;
		dv11.BeginInvoke(hr, InteropHelper.smethod_72, dv11);
		return 0;
	}

	internal int NativeTunerStateChanged(short oldState, short newState)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			int? num = (m_State = (int)newState);
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		dv2<ushort, ushort> dv11 = OnStateChanged;
		dv11.BeginInvoke((ushort)oldState, (ushort)newState, InteropHelper.smethod_73, dv11);
		return 0;
	}

	internal int NativeTunerAvailable(short bAvailable)
	{
		@lock @lock = null;
		bool flag = bAvailable == -1;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			if (!flag)
			{
				int? num = (m_hr = -2147024841);
			}
			else
			{
				int? num2 = (m_hr = 0);
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		dv1<bool> dv11 = OnReady;
		dv11.BeginInvoke(flag, InteropHelper.smethod_69, dv11);
		return 0;
	}

	internal int NativeCertificate(short bSuccess)
	{
		dv1<bool> dv11 = OnCertificate;
		int num = ((bSuccess == -1) ? 1 : 0);
		dv11.BeginInvoke((byte)num != 0, InteropHelper.smethod_69, dv11);
		return 0;
	}

	internal int NativeEncryption(short bOn)
	{
		dv1<bool> dv11 = OnEncryption;
		int num = ((bOn == -1) ? 1 : 0);
		dv11.BeginInvoke((byte)num != 0, InteropHelper.smethod_69, dv11);
		return 0;
	}

	internal int NativeWriteFailure()
	{
		dv0 dv11 = OnWriteFailure;
		dv11.BeginInvoke(InteropHelper.smethod_74, dv11);
		return 0;
	}

	internal int NativeContentSIIDChanged(int SIID)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			int? num = (m_SIID = SIID);
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		dv1<int> dv11 = OnContentSIIDChanged;
		dv11.BeginInvoke(SIID, InteropHelper.smethod_75, dv11);
		return 0;
	}

	internal int NativeBitRateChanged(global::RecorderStreamType st, global::RecorderBitRateChangeType brt, ulong rate)
	{
		dv3<RecorderStreamType, RecorderBitRateChangeType, ulong> dv11 = OnBitRateChanged;
		dv11.BeginInvoke((RecorderStreamType)st, (RecorderBitRateChangeType)brt, rate, InteropHelper.smethod_76, dv11);
		return 0;
	}

	internal int NativeChannelAvailable(short bAvailable)
	{
		int num = ((bAvailable == -1) ? 1 : 0);
		dv1<bool> dv11 = OnChannelAvailable;
		dv11.BeginInvoke((byte)num != 0, InteropHelper.smethod_69, dv11);
		return 0;
	}

	internal int NativeStatusChanged(global::RecorderUse prevStatus, global::RecorderUse currentStatus)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			RecorderUse? recorderUse = (m_Use = (RecorderUse)currentStatus);
			((IDisposable)m_CurrentTR)?.Dispose();
			m_CurrentTR = null;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		dv2<RecorderUse, RecorderUse> dv11 = OnStatusChanged;
		dv11.BeginInvoke((RecorderUse)prevStatus, (RecorderUse)currentStatus, InteropHelper.smethod_77, dv11);
		return 0;
	}

	internal int NativeRatingChanged(global::EnTvRat_System PrevRatingSystem, global::EnTvRat_GenericLevel PrevLevel, global::BfEnTvRat_GenericAttributes PrevAttributes, global::EnTvRat_System NewRatingSystem, global::EnTvRat_GenericLevel NewLevel, global::BfEnTvRat_GenericAttributes NewAttributes)
	{
		dv6<EnTvRat_System, EnTvRat_GenericLevel, BfEnTvRat_GenericAttributes, EnTvRat_System, EnTvRat_GenericLevel, BfEnTvRat_GenericAttributes> dv11 = OnRatingChanged;
		dv11.BeginInvoke((EnTvRat_System)PrevRatingSystem, (EnTvRat_GenericLevel)PrevLevel, (BfEnTvRat_GenericAttributes)PrevAttributes, (EnTvRat_System)NewRatingSystem, (EnTvRat_GenericLevel)NewLevel, (BfEnTvRat_GenericAttributes)NewAttributes, InteropHelper.smethod_78, dv11);
		return 0;
	}

	internal int NativeProtectionType(global::ProtType dwType)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			ProtType? protType = (m_CPType = (ProtType)dwType);
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		dv1<ProtType> dv11 = OnProtectionTypeChanged;
		dv11.BeginInvoke((ProtType)dwType, InteropHelper.smethod_79, dv11);
		return 0;
	}

	internal int NativeEasReceived(uint dwEventId, global::EasPriorityType Priority)
	{
		dv2<uint, EasPriorityType> dv11 = OnEasReceived;
		dv11.BeginInvoke(dwEventId, (EasPriorityType)Priority, InteropHelper.smethod_80, dv11);
		return 0;
	}

	internal int NativeMMIReceived(short fOpen, uint dwDialogNumber)
	{
		dv2<bool, uint> dv11 = OnMMIReceived;
		int num = ((fOpen == -1) ? 1 : 0);
		dv11.BeginInvoke((byte)num != 0, dwDialogNumber, InteropHelper.smethod_81, dv11);
		return 0;
	}

	internal int NativeCasCardStatusChanged(global::CasCardStatusType CardStatus)
	{
		dv1<CasCardStatusType> dv11 = OnCasCardStatusChanged;
		dv11.BeginInvoke((CasCardStatusType)CardStatus, InteropHelper.smethod_82, dv11);
		return 0;
	}

	internal int NativeDrmPairingStatusChanged(global::DrmPairingStatus DrmPairingState)
	{
		dv1<DrmPairingStatus> dv11 = OnDrmPairingStatusChanged;
		dv11.BeginInvoke((DrmPairingStatus)DrmPairingState, InteropHelper.smethod_83, dv11);
		return 0;
	}

	internal int NativeEntitlementChanged(global::CasEntitlementType CasEntitlementStatus)
	{
		dv1<CasEntitlementType> dv11 = OnCasEntitlementChanged;
		dv11.BeginInvoke((CasEntitlementType)CasEntitlementStatus, InteropHelper.smethod_84, dv11);
		return 0;
	}

	internal int NativeWriteFailureClear()
	{
		dv0 dv11 = OnWriteFailureClear;
		dv11.BeginInvoke(InteropHelper.smethod_74, dv11);
		return 0;
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool disposing)
	{
		if (disposing)
		{
			try
			{
				method_3();
				return;
			}
			finally
			{
				base.Dispose(disposing: true);
			}
		}
		try
		{
			method_2();
		}
		finally
		{
			base.Dispose(disposing: false);
		}
	}

	~Tuner()
	{
		Dispose(disposing: false);
	}
}
