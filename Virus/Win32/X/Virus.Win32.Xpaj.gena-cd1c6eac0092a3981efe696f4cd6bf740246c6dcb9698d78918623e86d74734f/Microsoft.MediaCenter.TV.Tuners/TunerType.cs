using System;

namespace Microsoft.MediaCenter.TV.Tuners;

[Flags]
public enum TunerType
{
	tt_Digital = 1,
	tt_Analog = 4,
	tt_WDM = 2,
	tt_BDA = 1,
	tt_None = 0
}
