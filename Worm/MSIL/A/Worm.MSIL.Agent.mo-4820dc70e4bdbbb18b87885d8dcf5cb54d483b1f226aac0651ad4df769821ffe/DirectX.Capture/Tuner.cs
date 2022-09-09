using System;
using System.Runtime.InteropServices;
using DShowNET;

namespace DirectX.Capture;

public class Tuner : IDisposable
{
	protected IAMTVTuner tvTuner = null;

	public int Channel
	{
		get
		{
			tvTuner.get_Channel(out int plChannel, out int _, out int _);
			return plChannel;
		}
		set
		{
			tvTuner.put_Channel(value, AMTunerSubChannel.Default, AMTunerSubChannel.Default);
		}
	}

	public TunerInputType InputType
	{
		get
		{
			tvTuner.get_InputType(0, out DShowNET.TunerInputType inputType);
			return (TunerInputType)inputType;
		}
		set
		{
			tvTuner.put_InputType(0, (DShowNET.TunerInputType)value);
		}
	}

	public bool SignalPresent
	{
		get
		{
			AMTunerSignalStrength plSignalStrength;
			int num = tvTuner.SignalPresent(out plSignalStrength);
			if (num != 0)
			{
				Marshal.ThrowExceptionForHR(num);
			}
			return plSignalStrength == AMTunerSignalStrength.SignalPresent;
		}
	}

	public Tuner(IAMTVTuner tuner)
	{
		tvTuner = tuner;
	}

	public void Dispose()
	{
		if (tvTuner != null)
		{
			Marshal.ReleaseComObject(tvTuner);
		}
		tvTuner = null;
	}
}
