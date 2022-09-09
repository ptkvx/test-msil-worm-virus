using System;
using System.Security;
using System.Security.Permissions;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
public sealed class SafePipeHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafePipeHandle()
		: base(ownsHandle: true)
	{
	}

	public SafePipeHandle(IntPtr preexistingHandle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(preexistingHandle);
	}

	protected override bool ReleaseHandle()
	{
		return UnsafeNativeMethods.CloseHandle(handle);
	}
}
