using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComVisible(true)]
[Guid("5a804648-4f66-4867-9c43-4f5c822cf1b8")]
public interface IVMRFilterConfig9
{
	[PreserveSig]
	int SetImageCompositor([In] IntPtr lpVMRImgCompositor);

	[PreserveSig]
	int SetNumberOfStreams([In] uint dwMaxStreams);

	[PreserveSig]
	int GetNumberOfStreams(out uint pdwMaxStreams);

	[PreserveSig]
	int SetRenderingPrefs([In] uint dwRenderFlags);

	[PreserveSig]
	int GetRenderingPrefs(out uint pdwRenderFlags);

	[PreserveSig]
	int SetRenderingMode([In] VMRMode9 Mode);

	[PreserveSig]
	int GetRenderingMode(out VMRMode9 Mode);
}
