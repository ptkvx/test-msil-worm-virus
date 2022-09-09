using System;

namespace DShowNET;

[Flags]
internal enum CLSCTX
{
	Inproc = 3,
	Server = 0x15,
	All = 0x17
}
