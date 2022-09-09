using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ODPReg;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[SuppressUnmanagedCodeSecurity]
[Guid("e707dcde-d1cd-11d2-bab9-00c04f8eceae")]
internal interface IRegister
{
	[PreserveSig]
	int UninstallAssembly(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, IntPtr pvReserved, out uint pulDisposition);

	[PreserveSig]
	int QueryAssemblyInfo(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, IntPtr pAsmInfo);

	[PreserveSig]
	int CreateAssemblyCacheItem(uint dwFlags, IntPtr pvReserved, out IntPtr ppAsmItem, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName);

	[PreserveSig]
	int CreateAssemblyScavenger(out object ppAsmScavenger);

	[PreserveSig]
	int InstallAssembly(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszManifestFilePath, IntPtr pvReserved);
}
