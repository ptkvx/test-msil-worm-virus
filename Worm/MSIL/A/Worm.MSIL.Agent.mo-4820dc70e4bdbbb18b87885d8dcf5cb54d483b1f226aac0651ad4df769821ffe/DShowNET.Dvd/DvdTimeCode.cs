using System.Runtime.InteropServices;

namespace DShowNET.Dvd;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
[ComVisible(false)]
public struct DvdTimeCode
{
	public byte bHours;

	public byte bMinutes;

	public byte bSeconds;

	public byte bFrames;
}
