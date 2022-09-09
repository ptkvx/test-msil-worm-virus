using System;
using System.Runtime.InteropServices;
using DShowNET;

namespace DirectX.Capture;

public class AudioSource : Source
{
	internal IPin Pin;

	public override bool Enabled
	{
		get
		{
			IAMAudioInputMixer iAMAudioInputMixer = (IAMAudioInputMixer)Pin;
			iAMAudioInputMixer.get_Enable(out bool pfEnable);
			return pfEnable;
		}
		set
		{
			IAMAudioInputMixer iAMAudioInputMixer = (IAMAudioInputMixer)Pin;
			iAMAudioInputMixer.put_Enable(value);
		}
	}

	internal AudioSource(IPin pin)
	{
		if (!(pin is IAMAudioInputMixer))
		{
			throw new NotSupportedException("The input pin does not support the IAMAudioInputMixer interface");
		}
		Pin = pin;
		name = getName(pin);
	}

	private string getName(IPin pin)
	{
		string result = "Unknown pin";
		PinInfo pInfo = default(PinInfo);
		int num = pin.QueryPinInfo(out pInfo);
		if (num == 0)
		{
			result = pInfo.name ?? "";
		}
		else
		{
			Marshal.ThrowExceptionForHR(num);
		}
		if (pInfo.filter != null)
		{
			Marshal.ReleaseComObject(pInfo.filter);
		}
		pInfo.filter = null;
		return result;
	}

	public override void Dispose()
	{
		if (Pin != null)
		{
			Marshal.ReleaseComObject(Pin);
		}
		Pin = null;
		base.Dispose();
	}
}
