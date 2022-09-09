using System.Runtime.InteropServices;

namespace DShowNET;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
[ComVisible(false)]
public struct PinInfo
{
	public IBaseFilter filter;

	public PinDirection dir;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
	public string name;
}
