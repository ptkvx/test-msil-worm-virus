using System;
using System.Runtime.InteropServices;

namespace DShowNET.Dvd;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComVisible(true)]
[Guid("FCC152B6-F372-11d0-8E00-00C04FD7C08B")]
public interface IDvdGraphBuilder
{
	[PreserveSig]
	int GetFiltergraph(out IGraphBuilder ppGB);

	[PreserveSig]
	int GetDvdInterface([In] ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvIF);

	[PreserveSig]
	int RenderDvdVideoVolume([In][MarshalAs(UnmanagedType.LPWStr)] string lpcwszPathName, DvdGraphFlags dwFlags, out DvdRenderStatus pStatus);
}
