using System.Runtime.InteropServices;

namespace DShowNET.Dvd;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
[ComVisible(false)]
public struct DvdPlayLocation
{
	public int TitleNum;

	public int ChapterNum;

	public DvdTimeCode timeCode;

	public int TimeCodeFlags;
}
