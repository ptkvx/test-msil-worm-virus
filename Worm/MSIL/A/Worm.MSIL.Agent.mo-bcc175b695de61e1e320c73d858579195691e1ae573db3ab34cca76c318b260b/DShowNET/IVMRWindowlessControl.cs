using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComVisible(true)]
[Guid("0eb1088c-4dcd-46f0-878f-39dae86a51b7")]
public interface IVMRWindowlessControl
{
	int GetNativeVideoSize(out int lpWidth, out int lpHeight, out int lpARWidth, out int lpARHeight);

	int GetMinIdealVideoSize(out int lpHeight);

	int GetMaxIdealVideoSize(out int lpWidth, out int lpHeight);

	int SetVideoPosition([In][MarshalAs(UnmanagedType.LPStruct)] RECT lpSRCRect, [In][MarshalAs(UnmanagedType.LPStruct)] RECT lpDSTRect);

	int GetVideoPosition([MarshalAs(UnmanagedType.LPStruct)] out RECT lpSRCRect, [MarshalAs(UnmanagedType.LPStruct)] out RECT lpDSTRect);

	int GetAspectRatioMode(out uint lpAspectRatioMode);

	int SetAspectRatioMode([In] uint AspectRatioMode);

	int SetVideoClippingWindow([In] IntPtr hwnd);

	int RepaintVideo([In] IntPtr hwnd, [In] IntPtr hdc);

	int DisplayModeChanged();

	int GetCurrentImage(out IntPtr lpDib);

	int SetBorderColor([In] uint Clr);

	int GetBorderColor(out uint lpClr);

	int SetColorKey([In] uint Clr);

	int GetColorKey(out uint lpClr);
}
