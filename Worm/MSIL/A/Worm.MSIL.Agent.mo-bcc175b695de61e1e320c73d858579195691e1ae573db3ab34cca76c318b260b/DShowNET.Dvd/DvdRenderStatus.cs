using System.Runtime.InteropServices;

namespace DShowNET.Dvd;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
[ComVisible(false)]
public struct DvdRenderStatus
{
	public int vpeStatus;

	public bool volInvalid;

	public bool volUnknown;

	public bool noLine21In;

	public bool noLine21Out;

	public int numStreams;

	public int numStreamsFailed;

	public DvdStreamFlags failedStreams;
}
