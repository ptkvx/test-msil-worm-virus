using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[StructLayout(LayoutKind.Sequential)]
[ComVisible(false)]
public class AudioStreamConfigCaps
{
	public Guid Guid;

	public int MinimumChannels;

	public int MaximumChannels;

	public int ChannelsGranularity;

	public int MinimumBitsPerSample;

	public int MaximumBitsPerSample;

	public int BitsPerSampleGranularity;

	public int MinimumSampleFrequency;

	public int MaximumSampleFrequency;

	public int SampleFrequencyGranularity;
}
