using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComVisible(true)]
[Guid("56a86892-0ad4-11ce-b03a-0020af0ba770")]
public interface IEnumPins
{
	[PreserveSig]
	int Next([In] int cPins, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IPin[] ppPins, out int pcFetched);

	[PreserveSig]
	int Skip([In] int cPins);

	void Reset();

	void Clone(out IEnumPins ppEnum);
}
