using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[ComVisible(true)]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("D8D715A3-6E5E-11D0-B3F0-00AA003761C5")]
public interface IAMVfwCompressDialogs
{
	[PreserveSig]
	int ShowDialog([In] VfwCompressDialogs iDialog, [In] IntPtr hwnd);

	int GetState([Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pState, ref int pcbState);

	int SetState([In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pState, [In] int cbState);

	int SendDriverMessage(int uMsg, long dw1, long dw2);
}
