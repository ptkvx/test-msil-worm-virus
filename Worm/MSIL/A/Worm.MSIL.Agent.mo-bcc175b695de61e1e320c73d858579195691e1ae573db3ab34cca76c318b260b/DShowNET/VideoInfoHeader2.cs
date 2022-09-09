using System.Runtime.InteropServices;

namespace DShowNET;

[StructLayout(LayoutKind.Sequential)]
[ComVisible(false)]
public class VideoInfoHeader2
{
	public DsRECT SrcRect;

	public DsRECT TargetRect;

	public int BitRate;

	public int BitErrorRate;

	public long AvgTimePerFrame;

	public int InterlaceFlags;

	public int CopyProtectFlags;

	public int PictAspectRatioX;

	public int PictAspectRatioY;

	public int ControlFlags;

	public int Reserved2;

	public BitmapInfoHeader BmiHeader;
}
