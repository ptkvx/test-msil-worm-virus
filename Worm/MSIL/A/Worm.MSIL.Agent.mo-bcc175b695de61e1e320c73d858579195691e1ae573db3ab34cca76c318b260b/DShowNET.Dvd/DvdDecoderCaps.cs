using System.Runtime.InteropServices;

namespace DShowNET.Dvd;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
[ComVisible(false)]
public struct DvdDecoderCaps
{
	public int size;

	public DvdAudioCaps audioCaps;

	public double fwdMaxRateVideo;

	public double fwdMaxRateAudio;

	public double fwdMaxRateSP;

	public double bwdMaxRateVideo;

	public double bwdMaxRateAudio;

	public double bwdMaxRateSP;

	public int res1;

	public int res2;

	public int res3;

	public int res4;
}
