using System.Runtime.InteropServices;

namespace DShowNET.Dvd;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("86303d6d-1c4a-4087-ab42-f711167048ef")]
[ComVisible(true)]
public interface IDvdState
{
	[PreserveSig]
	int GetDiscID(out long pullUniqueID);

	[PreserveSig]
	int GetParentalLevel(out int pulParentalLevel);
}
