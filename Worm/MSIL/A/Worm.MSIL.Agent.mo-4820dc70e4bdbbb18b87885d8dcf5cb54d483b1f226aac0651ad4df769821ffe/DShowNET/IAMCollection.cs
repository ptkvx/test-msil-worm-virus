using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[Guid("56a868b9-0ad4-11ce-b03a-0020af0ba770")]
[ComVisible(true)]
public interface IAMCollection
{
	int Count
	{
		[PreserveSig]
		get;
	}

	int NewEnum
	{
		[PreserveSig]
		get;
	}

	[PreserveSig]
	int Item(int lItem, [MarshalAs(UnmanagedType.IUnknown)] out object ppUnk);
}
