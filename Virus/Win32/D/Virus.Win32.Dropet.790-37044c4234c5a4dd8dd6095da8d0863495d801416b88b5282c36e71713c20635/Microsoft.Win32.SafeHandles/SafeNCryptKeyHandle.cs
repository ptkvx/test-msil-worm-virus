using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
public sealed class SafeNCryptKeyHandle : SafeNCryptHandle
{
	[DllImport("ncrypt.dll")]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern int NCryptFreeObject(IntPtr hObject);

	internal SafeNCryptKeyHandle Duplicate()
	{
		return Duplicate<SafeNCryptKeyHandle>();
	}

	protected override bool ReleaseNativeHandle()
	{
		return NCryptFreeObject(handle) == 0;
	}
}
