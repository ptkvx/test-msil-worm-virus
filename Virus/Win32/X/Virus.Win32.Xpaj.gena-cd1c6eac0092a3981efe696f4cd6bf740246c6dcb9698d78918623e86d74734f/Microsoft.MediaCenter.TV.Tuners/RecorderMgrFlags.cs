using System;

namespace Microsoft.MediaCenter.TV.Tuners;

[Flags]
public enum RecorderMgrFlags
{
	rmf_EnumMissingConfiguredRecorders = int.MinValue,
	rmf_RecorderInfoOnly = 0x10,
	rmf_WaitBuildAll = 8,
	rmf_Infinite = 4,
	rmf_WaitAll = 2,
	rmf_WaitOne = 1,
	rmf_WaitNone = 0
}
