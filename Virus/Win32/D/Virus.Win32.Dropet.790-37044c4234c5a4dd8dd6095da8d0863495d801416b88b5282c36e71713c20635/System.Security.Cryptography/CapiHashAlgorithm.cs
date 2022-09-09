using System.Runtime.InteropServices;
using Microsoft.Contracts;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal sealed class CapiHashAlgorithm : IDisposable
{
	private CapiNative.AlgorithmId m_algorithmId;

	private SafeCspHandle m_cspHandle;

	private SafeCapiHashHandle m_hashHandle;

	[SecurityCritical]
	public CapiHashAlgorithm(string provider, CapiNative.ProviderType providerType, CapiNative.AlgorithmId algorithm)
	{
		Contract.Requires(!string.IsNullOrEmpty(provider));
		Contract.Requires((algorithm & (CapiNative.AlgorithmId)32768) == (CapiNative.AlgorithmId)32768);
		m_algorithmId = algorithm;
		m_cspHandle = CapiNative.AcquireCsp(null, provider, providerType, CapiNative.CryptAcquireContextFlags.VerifyContext, throwPlatformException: true);
		Initialize();
	}

	[SecurityCritical]
	public void Dispose()
	{
		if (m_hashHandle != null)
		{
			m_hashHandle.Dispose();
		}
		if (m_cspHandle != null)
		{
			m_cspHandle.Dispose();
		}
	}

	[SecurityCritical]
	public void Initialize()
	{
		SafeCapiHashHandle phHash = null;
		if (!CapiNative.UnsafeNativeMethods.CryptCreateHash(m_cspHandle, m_algorithmId, SafeCapiKeyHandle.InvalidHandle, 0, out phHash))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == -2146893816)
			{
				throw new PlatformNotSupportedException(SR.GetString("Cryptography_PlatformNotSupported"));
			}
			throw new CryptographicException(lastWin32Error);
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
				if (!CapiNative.UnsafeNativeMethods.CryptHashData(m_hashHandle, array2, cbSize, 0))
				{
					throw new CryptographicException(Marshal.GetLastWin32Error());
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
		return CapiNative.GetHashParameter(m_hashHandle, CapiNative.HashParameter.HashValue);
	}
}
