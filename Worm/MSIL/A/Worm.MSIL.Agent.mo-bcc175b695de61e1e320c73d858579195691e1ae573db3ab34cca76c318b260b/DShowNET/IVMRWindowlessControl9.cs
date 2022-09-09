using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComVisible(true)]
[Guid("8f537d09-f85e-4414-b23b-502e54c79927")]
public interface IVMRWindowlessControl9
{
	int GetNativeVideoSize(out int lpWidth, out int lpHeight, out int lpARWidth, out int lpARHeight);

	int GetMinIdealVideoSize(out int lpHeight);

	int GetMaxIdealVideoSize(out int lpWidth, out int lpHeight);

	int SetVideoPosition([In][MarshalAs(UnmanagedType.LPStruct)] RECT lpSRCRect, [In][MarshalAs(UnmanagedType.LPStruct)] RECT lpDSTRect);

	int GetVideoPosition([MarshalAs(UnmanagedType.LPStruct)] out RECT lpSRCRect, [MarshalAs(UnmanagedType.LPStruct)] out RECT lpDSTRect);

	int GetAspectRatioMode(out VMR9AspectRatioMode lpAspectRatioMode);

	int SetAspectRatioMode([In] VMR9AspectRatioMode AspectRatioMode);

	int SetVideoClippingWindow([In] IntPtr hwnd);

	int RepaintVideo([In] IntPtr hwnd, [In] IntPtr hdc);

	int DisplayModeChanged();

	int GetCurrentImage(out IntPtr lpDib);

	int SetBorderColor([In] uint Clr);

	int GetBorderColor(out uint lpClr);
}
