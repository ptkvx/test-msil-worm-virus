using System.Runtime.InteropServices;

namespace DShowNET;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[ComVisible(false)]
public struct BitmapInfoHeader
{
	public int Size;

	public int Width;

	public int Height;

	public short Planes;

	public short BitCount;

	public int Compression;

	public int ImageSize;

	public int XPelsPerMeter;

	public int YPelsPerMeter;

	public int ClrUsed;

	public int ClrImportant;
}
