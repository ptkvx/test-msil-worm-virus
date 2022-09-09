using System.Runtime.InteropServices;

namespace DShowNET.Dvd;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
[ComVisible(false)]
public struct DvdTitleAttr
{
	public DvdTitleAppMode appMode;

	public DvdVideoAttr videoAt;

	public int numberOfAudioStreams;
}
