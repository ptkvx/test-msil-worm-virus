using System.Runtime.InteropServices;

namespace DShowNET;

[StructLayout(LayoutKind.Sequential)]
[ComVisible(false)]
public class VideoInfoHeader
{
	public DsRECT SrcRect;

	public DsRECT TargetRect;

	public int BitRate;

	public int BitErrorRate;

	public long AvgTimePerFrame;

	public BitmapInfoHeader BmiHeader;
}
