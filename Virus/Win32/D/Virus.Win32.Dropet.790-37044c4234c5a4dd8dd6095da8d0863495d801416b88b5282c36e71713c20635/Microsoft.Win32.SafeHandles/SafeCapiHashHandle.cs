using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal sealed class SafeCapiHashHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	public static SafeCapiHashHandle InvalidHandle
	{
		get
		{
			SafeCapiHashHandle safeCapiHashHandle = new SafeCapiHashHandle();
			safeCapiHashHandle.SetHandle(IntPtr.Zero);
			return safeCapiHashHandle;
		}
	}

	private SafeCapiHashHandle()
		: base(ownsHandle: true)
	{
	}

	[DllImport("advapi32")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptDestroyHash(IntPtr hHash);

	protected override bool ReleaseHandle()
	{
		return CryptDestroyHash(handle);
	}
}
