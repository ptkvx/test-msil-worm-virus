using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[ComVisible(true)]
[Guid("93E5A4E0-2D50-11d2-ABFA-00A0C9C6E38D")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICaptureGraphBuilder2
{
	[PreserveSig]
	int SetFiltergraph([In] IGraphBuilder pfg);

	[PreserveSig]
	int GetFiltergraph(out IGraphBuilder ppfg);

	[PreserveSig]
	int SetOutputFileName([In] ref Guid pType, [In][MarshalAs(UnmanagedType.LPWStr)] string lpstrFile, out IBaseFilter ppbf, out IFileSinkFilter ppSink);

	[PreserveSig]
	int FindInterface([In] ref Guid pCategory, [In] ref Guid pType, [In] IBaseFilter pbf, [In] ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppint);

	[PreserveSig]
	int RenderStream([In] ref Guid pCategory, [In] ref Guid pType, [In][MarshalAs(UnmanagedType.IUnknown)] object pSource, [In] IBaseFilter pfCompressor, [In] IBaseFilter pfRenderer);

	[PreserveSig]
	int ControlStream([In] ref Guid pCategory, [In] ref Guid pType, [In] IBaseFilter pFilter, [In] long pstart, [In] long pstop, [In] short wStartCookie, [In] short wStopCookie);

	[PreserveSig]
	int AllocCapFile([In][MarshalAs(UnmanagedType.LPWStr)] string lpstrFile, [In] long dwlSize);

	[PreserveSig]
	int CopyCaptureFile([In][MarshalAs(UnmanagedType.LPWStr)] string lpwstrOld, [In][MarshalAs(UnmanagedType.LPWStr)] string lpwstrNew, [In] int fAllowEscAbort, [In] IAMCopyCaptureFileProgress pFilter);

	[PreserveSig]
	int FindPin([In] object pSource, [In] int pindir, [In] ref Guid pCategory, [In] ref Guid pType, [In][MarshalAs(UnmanagedType.Bool)] bool fUnconnected, [In] int num, out IPin ppPin);
}
