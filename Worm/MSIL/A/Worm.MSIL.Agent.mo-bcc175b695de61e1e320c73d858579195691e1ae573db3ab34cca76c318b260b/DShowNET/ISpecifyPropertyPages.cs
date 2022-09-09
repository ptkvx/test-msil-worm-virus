using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[Guid("B196B28B-BAB4-101A-B69C-00AA00341D07")]
[ComVisible(true)]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ISpecifyPropertyPages
{
	[PreserveSig]
	int GetPages(out DsCAUUID pPages);
}
