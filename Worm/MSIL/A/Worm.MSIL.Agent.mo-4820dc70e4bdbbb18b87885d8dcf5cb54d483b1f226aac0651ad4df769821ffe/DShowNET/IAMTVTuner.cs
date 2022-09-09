using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("211A8766-03AC-11d1-8D13-00AA00BD8339")]
[ComVisible(true)]
public interface IAMTVTuner
{
	int Channel
	{
		[PreserveSig]
		get;
	}

	int CountryCode
	{
		[PreserveSig]
		get;
	}

	int TuningSpace
	{
		[PreserveSig]
		get;
	}

	int Mode
	{
		[PreserveSig]
		get;
	}

	int AvailableTVFormats
	{
		[PreserveSig]
		get;
	}

	int TVFormat
	{
		[PreserveSig]
		get;
	}

	int NumInputConnections
	{
		[PreserveSig]
		get;
	}

	int InputType
	{
		[PreserveSig]
		get;
	}

	int ConnectInput
	{
		[PreserveSig]
		get;
	}

	int VideoFrequency
	{
		[PreserveSig]
		get;
	}

	int AudioFrequency
	{
		[PreserveSig]
		get;
	}

	[PreserveSig]
	int put_Channel(int lChannel, AMTunerSubChannel lVideoSubChannel, AMTunerSubChannel lAudioSubChannel);

	[PreserveSig]
	int ChannelMinMax(out int lChannelMin, out int lChannelMax);

	[PreserveSig]
	int put_CountryCode(int lCountryCode);

	[PreserveSig]
	int put_TuningSpace(int lTuningSpace);

	[PreserveSig]
	int Logon(IntPtr hCurrentUser);

	[PreserveSig]
	int Logout();

	[PreserveSig]
	int SignalPresent(out AMTunerSignalStrength plSignalStrength);

	[PreserveSig]
	int put_Mode(AMTunerModeType lMode);

	[PreserveSig]
	int GetAvailableModes(out AMTunerModeType plModes);

	[PreserveSig]
	int RegisterNotificationCallBack(IAMTunerNotification pNotify, AMTunerEventType lEvents);

	[PreserveSig]
	int UnRegisterNotificationCallBack(IAMTunerNotification pNotify);

	[PreserveSig]
	int AutoTune(int lChannel, out int plFoundSignal);

	[PreserveSig]
	int StoreAutoTune();

	[PreserveSig]
	int put_InputType(int lIndex, TunerInputType inputType);

	[PreserveSig]
	int put_ConnectInput(int lIndex);
}
