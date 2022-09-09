using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("56a86893-0ad4-11ce-b03a-0020af0ba770")]
[ComVisible(true)]
public interface IEnumFilters
{
	[PreserveSig]
	int Next([In] uint cFilters, out IBaseFilter x, out uint pcFetched);

	[PreserveSig]
	int Skip([In] int cFilters);

	void Reset();

	void Clone(out IEnumFilters ppEnum);
}
