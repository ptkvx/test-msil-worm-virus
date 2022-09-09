using System;

namespace DShowNET.Dvd;

[Flags]
public enum DvdCmdFlags
{
	None = 0,
	Flush = 1,
	SendEvt = 2,
	Block = 4,
	StartWRendered = 8,
	EndARendered = 0x10
}
