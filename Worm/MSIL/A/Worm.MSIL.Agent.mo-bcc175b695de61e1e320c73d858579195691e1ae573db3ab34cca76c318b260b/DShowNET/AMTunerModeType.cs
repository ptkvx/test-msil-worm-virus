using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[Flags]
[ComVisible(false)]
public enum AMTunerModeType
{
	Default = 0,
	TV = 1,
	FMRadio = 2,
	AMRadio = 4,
	Dss = 8
}
