using System;
using System.Runtime.InteropServices;
using DShowNET;

namespace DirectX.Capture;

public class AudioCapabilities
{
	public int MinimumChannels;

	public int MaximumChannels;

	public int ChannelsGranularity;

	public int MinimumSampleSize;

	public int MaximumSampleSize;

	public int SampleSizeGranularity;

	public int MinimumSamplingRate;

	public int MaximumSamplingRate;

	public int SamplingRateGranularity;

	internal AudioCapabilities(IAMStreamConfig audioStreamConfig)
	{
		if (audioStreamConfig == null)
		{
			throw new ArgumentNullException("audioStreamConfig");
		}
		AMMediaType aMMediaType = null;
		AudioStreamConfigCaps audioStreamConfigCaps = null;
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			int numberOfCapabilities = audioStreamConfig.GetNumberOfCapabilities(out var piCount, out var piSize);
			if (numberOfCapabilities != 0)
			{
				Marshal.ThrowExceptionForHR(numberOfCapabilities);
			}
			if (piCount <= 0)
			{
				throw new NotSupportedException("This audio device does not report capabilities.");
			}
			if (piSize > Marshal.SizeOf(typeof(AudioStreamConfigCaps)))
			{
				throw new NotSupportedException("Unable to retrieve audio device capabilities. This audio device requires a larger AudioStreamConfigCaps structure.");
			}
			if (piCount <= 1)
			{
			}
			intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(AudioStreamConfigCaps)));
			numberOfCapabilities = audioStreamConfig.GetStreamCaps(0, out var pmt, intPtr);
			if (numberOfCapabilities != 0)
			{
				Marshal.ThrowExceptionForHR(numberOfCapabilities);
			}
			aMMediaType = (AMMediaType)Marshal.PtrToStructure(pmt, typeof(AMMediaType));
			audioStreamConfigCaps = (AudioStreamConfigCaps)Marshal.PtrToStructure(intPtr, typeof(AudioStreamConfigCaps));
			MinimumChannels = audioStreamConfigCaps.MinimumChannels;
			MaximumChannels = audioStreamConfigCaps.MaximumChannels;
			ChannelsGranularity = audioStreamConfigCaps.ChannelsGranularity;
			MinimumSampleSize = audioStreamConfigCaps.MinimumBitsPerSample;
			MaximumSampleSize = audioStreamConfigCaps.MaximumBitsPerSample;
			SampleSizeGranularity = audioStreamConfigCaps.BitsPerSampleGranularity;
			MinimumSamplingRate = audioStreamConfigCaps.MinimumSampleFrequency;
			MaximumSamplingRate = audioStreamConfigCaps.MaximumSampleFrequency;
			SamplingRateGranularity = audioStreamConfigCaps.SampleFrequencyGranularity;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(intPtr);
			}
			intPtr = IntPtr.Zero;
			if (aMMediaType != null)
			{
				DsUtils.FreeAMMediaType(aMMediaType);
			}
			aMMediaType = null;
		}
	}
}
