using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using Microsoft.Contracts;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal sealed class SafeCapiKeyHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeCapiKeyHandle InvalidHandle
	{
		get
		{
			SafeCapiKeyHandle safeCapiKeyHandle = new SafeCapiKeyHandle();
			safeCapiKeyHandle.SetHandle(IntPtr.Zero);
			return safeCapiKeyHandle;
		}
	}

	private SafeCapiKeyHandle()
		: base(ownsHandle: true)
	{
	}

	[DllImport("advapi32")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptDestroyKey(IntPtr hKey);

	internal SafeCapiKeyHandle Duplicate()
	{
		Contract.Requires(!IsInvalid && !base.IsClosed);
		SafeCapiKeyHandle phKey = null;
		if (!CapiNative.UnsafeNativeMethods.CryptDuplicateKey(this, IntPtr.Zero, 0, out phKey))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		return phKey;
	}

	protected override bool ReleaseHandle()
	{
		return CryptDestroyKey(handle);
	}
}
