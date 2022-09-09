using System;
using System.Drawing;
using System.Runtime.InteropServices;
using DShowNET;

namespace DirectX.Capture;

public class VideoCapabilities
{
	public Size InputSize;

	public Size MinFrameSize;

	public Size MaxFrameSize;

	public int FrameSizeGranularityX;

	public int FrameSizeGranularityY;

	public double MinFrameRate;

	public double MaxFrameRate;

	internal VideoCapabilities(IAMStreamConfig videoStreamConfig)
	{
		AMMediaType aMMediaType = null;
		VideoStreamConfigCaps videoStreamConfigCaps = null;
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			int numberOfCapabilities = videoStreamConfig.GetNumberOfCapabilities(out var piCount, out var _);
			if (numberOfCapabilities != 0)
			{
				Marshal.ThrowExceptionForHR(numberOfCapabilities);
			}
			if (piCount <= 1)
			{
			}
			intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(VideoStreamConfigCaps)));
			numberOfCapabilities = videoStreamConfig.GetStreamCaps(0, out var pmt, intPtr);
			if (numberOfCapabilities != 0)
			{
				Marshal.ThrowExceptionForHR(numberOfCapabilities);
			}
			aMMediaType = (AMMediaType)Marshal.PtrToStructure(pmt, typeof(AMMediaType));
			videoStreamConfigCaps = (VideoStreamConfigCaps)Marshal.PtrToStructure(intPtr, typeof(VideoStreamConfigCaps));
			InputSize = videoStreamConfigCaps.InputSize;
			MinFrameSize = videoStreamConfigCaps.MinOutputSize;
			MaxFrameSize = videoStreamConfigCaps.MaxOutputSize;
			FrameSizeGranularityX = videoStreamConfigCaps.OutputGranularityX;
			FrameSizeGranularityY = videoStreamConfigCaps.OutputGranularityY;
			MinFrameRate = 10000000.0 / (double)videoStreamConfigCaps.MaxFrameInterval;
			MaxFrameRate = 10000000.0 / (double)videoStreamConfigCaps.MinFrameInterval;
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
