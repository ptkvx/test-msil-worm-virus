using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComVisible(true)]
[Guid("9e5530c5-7034-48b4-bb46-0b8a6efc8e36")]
public interface IVMRFilterConfig
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
	int SetRenderingMode([In] uint Mode);

	[PreserveSig]
	int GetRenderingMode(out VMRMode Mode);
}
