using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("670d1d20-a068-11d0-b3f0-00aa003761c5")]
[ComVisible(true)]
public interface IAMCopyCaptureFileProgress
{
	[PreserveSig]
	int Progress(int iProgress);
}
