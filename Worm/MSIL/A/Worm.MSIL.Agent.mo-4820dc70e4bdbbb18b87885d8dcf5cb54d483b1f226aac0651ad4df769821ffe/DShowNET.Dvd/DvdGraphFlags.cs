using System;

namespace DShowNET.Dvd;

[Flags]
public enum DvdGraphFlags
{
	Default = 0,
	HwDecPrefer = 1,
	HwDecOnly = 2,
	SwDecPrefer = 4,
	SwDecOnly = 8,
	NoVpe = 0x100
}
