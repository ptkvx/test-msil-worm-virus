using System.Runtime.InteropServices;

namespace DShowNET;

[ComVisible(false)]
public enum VMRMode : uint
{
	Windowed = 1u,
	Windowless = 2u,
	Renderless = 4u
}
