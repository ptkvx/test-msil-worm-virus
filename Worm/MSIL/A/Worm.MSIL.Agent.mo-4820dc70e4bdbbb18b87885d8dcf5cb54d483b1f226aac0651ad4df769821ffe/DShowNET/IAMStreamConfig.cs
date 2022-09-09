using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("C6E13340-30AC-11d0-A18C-00A0C9118956")]
[ComVisible(true)]
public interface IAMStreamConfig
{
	[PreserveSig]
	int SetFormat([In][MarshalAs(UnmanagedType.LPStruct)] AMMediaType pmt);

	[PreserveSig]
	int GetFormat(out IntPtr pmt);

	[PreserveSig]
	int GetNumberOfCapabilities(out int piCount, out int piSize);

	[PreserveSig]
	int GetStreamCaps(int iIndex, out IntPtr pmt, [In] IntPtr pSCC);
}
