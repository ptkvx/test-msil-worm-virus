using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[Guid("C6E13380-30AC-11d0-A18C-00A0C9118956")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComVisible(true)]
public interface IAMCrossbar
{
	int PinCounts
	{
		[PreserveSig]
		get;
	}

	int IsRoutedTo
	{
		[PreserveSig]
		get;
	}

	int CrossbarPinInfo
	{
		[PreserveSig]
		get;
	}

	[PreserveSig]
	int CanRoute([In] int OutputPinIndex, [In] int InputPinIndex);

	[PreserveSig]
	int Route([In] int OutputPinIndex, [In] int InputPinIndex);
}
