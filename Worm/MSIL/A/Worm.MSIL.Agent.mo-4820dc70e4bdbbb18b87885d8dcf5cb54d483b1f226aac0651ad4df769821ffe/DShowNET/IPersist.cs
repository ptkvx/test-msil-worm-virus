using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[Guid("0000010c-0000-0000-C000-000000000046")]
[ComVisible(true)]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IPersist
{
	[PreserveSig]
	int GetClassID(out Guid pClassID);
}
