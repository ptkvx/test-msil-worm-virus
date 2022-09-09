using System.Runtime.InteropServices;

namespace DShowNET;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
[ComVisible(false)]
public class FilterInfo
{
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
	public string achName;

	[MarshalAs(UnmanagedType.IUnknown)]
	public object pUnk;
}
