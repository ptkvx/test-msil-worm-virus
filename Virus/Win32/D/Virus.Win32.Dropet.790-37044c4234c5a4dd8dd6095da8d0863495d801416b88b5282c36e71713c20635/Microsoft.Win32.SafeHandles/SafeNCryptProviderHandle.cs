using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using Microsoft.Contracts;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
public sealed class SafeNCryptProviderHandle : SafeNCryptHandle
{
	[DllImport("ncrypt.dll")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int NCryptFreeObject(IntPtr hObject);

	internal SafeNCryptProviderHandle Duplicate()
	{
		return Duplicate<SafeNCryptProviderHandle>();
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal void SetHandleValue(IntPtr newHandleValue)
	{
		Contract.Requires(newHandleValue != IntPtr.Zero);
		Contract.Requires(!base.IsClosed);
		SetHandle(newHandleValue);
	}

	protected override bool ReleaseNativeHandle()
	{
		return NCryptFreeObject(handle) == 0;
	}
}
