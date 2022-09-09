using System.Runtime.InteropServices;

namespace DShowNET.Dvd;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
[ComVisible(false)]
public struct DvdMenuAttr
{
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	public bool[] compatibleRegion;

	public DvdVideoAttr videoAt;

	public bool audioPresent;

	public DvdAudioAttr audioAt;

	public bool subPicPresent;

	public DvdSubPicAttr subPicAt;
}
