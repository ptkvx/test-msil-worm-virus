using System;

namespace DirectX.Capture;

public class DeviceInUseException : SystemException
{
	public DeviceInUseException(string deviceName, int hResult)
		: base(deviceName + " is in use or cannot be rendered. (" + hResult + ")")
	{
	}
}
