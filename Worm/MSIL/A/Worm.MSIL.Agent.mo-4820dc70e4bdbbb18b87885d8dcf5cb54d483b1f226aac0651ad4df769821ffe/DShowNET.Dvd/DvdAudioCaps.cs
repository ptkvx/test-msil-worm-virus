using System;

namespace DShowNET.Dvd;

[Flags]
public enum DvdAudioCaps
{
	Ac3 = 1,
	Mpeg2 = 2,
	Lpcm = 4,
	Dts = 8,
	Sdds = 0x10
}
