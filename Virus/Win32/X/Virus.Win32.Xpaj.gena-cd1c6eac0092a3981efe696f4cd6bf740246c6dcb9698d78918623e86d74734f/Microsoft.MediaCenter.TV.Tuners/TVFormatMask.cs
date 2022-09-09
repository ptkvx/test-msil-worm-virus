using System;

namespace Microsoft.MediaCenter.TV.Tuners;

[Flags]
public enum TVFormatMask
{
	SECAM_Mask = 0xFF000,
	PAL_Mask = 0x1F0,
	NTSC_Mask = 0x100E07
}
