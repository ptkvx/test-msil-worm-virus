using System;
using System.Runtime.InteropServices;

namespace DShowNET.Device;

[ComImport]
[Guid("29840822-5B84-11D0-BD3B-00A0C911CE86")]
[ComVisible(true)]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICreateDevEnum
{
	[PreserveSig]
	int CreateClassEnumerator([In] ref Guid pType, out UCOMIEnumMoniker ppEnumMoniker, [In] int dwFlags);
}
