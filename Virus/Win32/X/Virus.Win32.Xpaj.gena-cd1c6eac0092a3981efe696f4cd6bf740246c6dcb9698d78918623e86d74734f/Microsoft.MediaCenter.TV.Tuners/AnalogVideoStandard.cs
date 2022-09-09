using System;

namespace Microsoft.MediaCenter.TV.Tuners;

[Flags]
public enum AnalogVideoStandard
{
	AnalogVideoMask_MCE_SECAM = 0xFF000,
	AnalogVideoMask_MCE_PAL = 0x1F0,
	AnalogVideoMask_MCE_NTSC = 0x100E07,
	AnalogVideo_PAL_N_COMBO = 0x100000,
	AnalogVideo_SECAM_L1 = 0x80000,
	AnalogVideo_SECAM_L = 0x40000,
	AnalogVideo_SECAM_K1 = 0x20000,
	AnalogVideo_SECAM_K = 0x10000,
	AnalogVideo_SECAM_H = 0x8000,
	AnalogVideo_SECAM_G = 0x4000,
	AnalogVideo_SECAM_D = 0x2000,
	AnalogVideo_SECAM_B = 0x1000,
	AnalogVideo_PAL_60 = 0x800,
	AnalogVideo_PAL_N = 0x400,
	AnalogVideo_PAL_M = 0x200,
	AnalogVideo_PAL_I = 0x100,
	AnalogVideo_PAL_H = 0x80,
	AnalogVideo_PAL_G = 0x40,
	AnalogVideo_PAL_D = 0x20,
	AnalogVideo_PAL_B = 0x10,
	AnalogVideo_NTSC_433 = 4,
	AnalogVideo_NTSC_M_J = 2,
	AnalogVideo_NTSC_M = 1,
	AnalogVideo_None = 0
}
