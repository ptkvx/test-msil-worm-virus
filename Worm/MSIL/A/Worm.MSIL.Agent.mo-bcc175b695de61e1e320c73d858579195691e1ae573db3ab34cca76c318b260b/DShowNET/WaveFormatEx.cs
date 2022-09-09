using System.Runtime.InteropServices;

namespace DShowNET;

[StructLayout(LayoutKind.Sequential)]
[ComVisible(false)]
public class WaveFormatEx
{
	public short wFormatTag;

	public short nChannels;

	public int nSamplesPerSec;

	public int nAvgBytesPerSec;

	public short nBlockAlign;

	public short wBitsPerSample;

	public short cbSize;
}
