using System;

namespace DShowNET.Dvd;

[Flags]
public enum DvdStreamFlags
{
	None = 0,
	Video = 1,
	Audio = 2,
	SubPic = 4
}
