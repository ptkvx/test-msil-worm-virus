namespace Microsoft.MediaCenter.TV.Tuners;

public enum RecorderUse
{
	ru_AdviseOnly = 6,
	ru_Disconnected = 5,
	ru_Passive = 4,
	ru_Active = 3,
	ru_Exclusive = 2,
	ru_Scanning = 1,
	ru_Free = 0,
	ru_Any = -1
}
