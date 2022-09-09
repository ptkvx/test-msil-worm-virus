using System.Runtime.InteropServices;

namespace DShowNET.Dvd;

[ComImport]
[ComVisible(true)]
[Guid("5a4a97e4-94ee-4a55-9751-74b5643aa27d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IDvdCmd
{
	[PreserveSig]
	int WaitForStart();

	[PreserveSig]
	int WaitForEnd();
}
