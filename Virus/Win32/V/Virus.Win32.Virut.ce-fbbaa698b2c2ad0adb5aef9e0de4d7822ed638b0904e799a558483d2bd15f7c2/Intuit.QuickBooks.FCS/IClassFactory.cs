using System;
using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("00000001-0000-0000-C000-000000000046")]
internal interface IClassFactory
{
	[PreserveSig]
	int CreateInstance(IntPtr pUnkOuter, ref Guid riid, out IntPtr ppvObject);

	[PreserveSig]
	int LockServer(bool fLock);
}
