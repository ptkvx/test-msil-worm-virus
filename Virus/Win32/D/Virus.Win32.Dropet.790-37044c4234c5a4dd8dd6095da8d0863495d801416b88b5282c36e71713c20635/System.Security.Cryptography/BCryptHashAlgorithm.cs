using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Contracts;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal sealed class BCryptHashAlgorithm : IDisposable
{
	private SafeBCryptAlgorithmHandle m_algorithmHandle;

	private SafeBCryptHashHandle m_hashHandle;

	[SecurityCritical]
	public BCryptHashAlgorithm(CngAlgorithm algorithm, string implementation)
	{
		Contract.Requires(algorithm != null);
		Contract.Requires(!string.IsNullOrEmpty(implementation));
		if (!BCryptNative.BCryptSupported)
		{
			throw new PlatformNotSupportedException(SR.GetString("Cryptography_PlatformNotSupported"));
		}
		m_algorithmHandle = BCryptNative.OpenAlgorithm(algorithm.Algorithm, implementation);
		Initialize();
	}

	[SecurityCritical]
	public void Dispose()
	{
		if (m_hashHandle != null)
		{
			m_hashHandle.Dispose();
		}
		if (m_algorithmHandle != null)
		{
			m_algorithmHandle.Dispose();
		}
	}

	[SecurityCritical]
	public void Initialize()
	{
		SafeBCryptHashHandle phHash = null;
		IntPtr intPtr = IntPtr.Zero;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			int int32Property = BCryptNative.GetInt32Property(m_algorithmHandle, "ObjectLength");
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				intPtr = Marshal.AllocCoTaskMem(int32Property);
			}
			BCryptNative.ErrorCode errorCode = BCryptNative.UnsafeNativeMethods.BCryptCreateHash(m_algorithmHandle, out phHash, intPtr, int32Property, IntPtr.Zero, 0, 0);
			if (errorCode != 0)
			{
				throw new CryptographicException((int)errorCode);
			}
			phHash.HashObject = intPtr;
		}
		finally
		{
			if (intPtr != IntPtr.Zero && (phHash == null || phHash.HashObject == IntPtr.Zero))
			{
				Marshal.FreeCoTaskMem(intPtr);
			}
		}
		if (m_hashHandle != null)
		{
			m_hashHandle.Dispose();
		}
		m_hashHandle = phHash;
	}

	[SecurityCritical]
	public void HashCore(byte[] array, int ibStart, int cbSize)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (ibStart >= 0 && ibStart <= array.Length - cbSize)
		{
			if (cbSize >= 0 && cbSize <= array.Length)
			{
				byte[] array2 = new byte[cbSize];
				Buffer.BlockCopy(array, ibStart, array2, 0, cbSize);
				BCryptNative.ErrorCode errorCode = BCryptNative.UnsafeNativeMethods.BCryptHashData(m_hashHandle, array2, array2.Length, 0);
				if (errorCode != 0)
				{
					throw new CryptographicException((int)errorCode);
				}
				return;
			}
			throw new ArgumentOutOfRangeException("cbSize");
		}
		throw new ArgumentOutOfRangeException("ibStart");
	}

	[SecurityCritical]
	public byte[] HashFinal()
	{
		int int32Property = BCryptNative.GetInt32Property(m_hashHandle, "HashDigestLength");
		byte[] array = new byte[int32Property];
		BCryptNative.ErrorCode errorCode = BCryptNative.UnsafeNativeMethods.BCryptFinishHash(m_hashHandle, array, array.Length, 0);
		if (errorCode != 0)
		{
			throw new CryptographicException((int)errorCode);
		}
		return array;
	}

	[SecurityCritical]
	public void HashStream(Stream stream)
	{
		Contract.Requires(stream != null);
		byte[] array = new byte[4096];
		int num = 0;
		do
		{
			num = stream.Read(array, 0, array.Length);
			if (num > 0)
			{
				HashCore(array, 0, num);
			}
		}
		while (num > 0);
	}
}
