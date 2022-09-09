using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[StructLayout(LayoutKind.Sequential)]
[ComVisible(false)]
public class AMMediaType
{
	public Guid majorType;

	public Guid subType;

	[MarshalAs(UnmanagedType.Bool)]
	public bool fixedSizeSamples;

	[MarshalAs(UnmanagedType.Bool)]
	public bool temporalCompression;

	public int sampleSize;

	public Guid formatType;

	public IntPtr unkPtr;

	public int formatSize;

	public IntPtr formatPtr;
}
