using System.Runtime.InteropServices;

namespace DShowNET.Dvd;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
[ComVisible(false)]
public struct DvdVideoAttr
{
	public bool panscanPermitted;

	public bool letterboxPermitted;

	public int aspectX;

	public int aspectY;

	public int frameRate;

	public int frameHeight;

	public DvdVideoCompress compression;

	public bool line21Field1InGOP;

	public bool line21Field2InGOP;

	public int sourceResolutionX;

	public int sourceResolutionY;

	public bool isSourceLetterboxed;

	public bool isFilmMode;
}
