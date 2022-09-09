using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Contracts;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class AesCryptoServiceProvider : Aes
{
	private static KeySizes[] s_supportedKeySizes;

	private static int s_defaultKeySize;

	private SafeCspHandle m_cspHandle;

	private SafeCapiKeyHandle m_key;

	public override byte[] Key
	{
		[SecurityCritical]
		get
		{
			if (m_key == null || m_key.IsInvalid || m_key.IsClosed)
			{
				GenerateKey();
			}
			return CapiNative.ExportSymmetricKey(m_key);
		}
		[SecurityCritical]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			byte[] array = (byte[])value.Clone();
			if (!ValidKeySize(array.Length * 8))
			{
				throw new CryptographicException(SR.GetString("Cryptography_InvalidKeySize"));
			}
			SafeCapiKeyHandle key = CapiNative.ImportSymmetricKey(m_cspHandle, GetAlgorithmId(array.Length * 8), array);
			if (m_key != null)
			{
				m_key.Dispose();
			}
			m_key = key;
			KeySizeValue = array.Length * 8;
		}
	}

	public override int KeySize
	{
		get
		{
			return base.KeySize;
		}
		[SecurityCritical]
		set
		{
			base.KeySize = value;
			if (m_key != null)
			{
				m_key.Dispose();
			}
		}
	}

	[SecurityCritical]
	public AesCryptoServiceProvider()
	{
		string providerName = "Microsoft Enhanced RSA and AES Cryptographic Provider";
		if (Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor == 1)
		{
			providerName = "Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)";
		}
		m_cspHandle = CapiNative.AcquireCsp(null, providerName, CapiNative.ProviderType.RsaAes, CapiNative.CryptAcquireContextFlags.VerifyContext, throwPlatformException: true);
		FeedbackSizeValue = 8;
		int defaultKeySize = 0;
		KeySizes[] array = FindSupportedKeySizes(m_cspHandle, out defaultKeySize);
		if (array.Length == 0)
		{
			throw new PlatformNotSupportedException(SR.GetString("Cryptography_PlatformNotSupported"));
		}
		KeySizeValue = defaultKeySize;
	}

	[SecurityCritical]
	public override ICryptoTransform CreateDecryptor()
	{
		if (m_key == null || m_key.IsInvalid || m_key.IsClosed)
		{
			throw new CryptographicException(SR.GetString("Cryptography_DecryptWithNoKey"));
		}
		return CreateDecryptor(m_key, IVValue);
	}

	[SecurityCritical]
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!ValidKeySize(key.Length * 8))
		{
			throw new ArgumentException(SR.GetString("Cryptography_InvalidKeySize"), "key");
		}
		if (iv != null && iv.Length * 8 != BlockSizeValue)
		{
			throw new ArgumentException(SR.GetString("Cryptography_InvalidIVSize"), "iv");
		}
		byte[] array = (byte[])key.Clone();
		byte[] iv2 = null;
		if (iv != null)
		{
			iv2 = (byte[])iv.Clone();
		}
		using SafeCapiKeyHandle key2 = CapiNative.ImportSymmetricKey(m_cspHandle, GetAlgorithmId(array.Length * 8), array);
		return CreateDecryptor(key2, iv2);
	}

	[SecurityCritical]
	private ICryptoTransform CreateDecryptor(SafeCapiKeyHandle key, byte[] iv)
	{
		Contract.Requires(key != null);
		return new CapiSymmetricAlgorithm(BlockSizeValue, FeedbackSizeValue, m_cspHandle, key, iv, Mode, PaddingValue, EncryptionMode.Decrypt);
	}

	[SecurityCritical]
	public override ICryptoTransform CreateEncryptor()
	{
		if (m_key == null || m_key.IsInvalid || m_key.IsClosed)
		{
			GenerateKey();
		}
		if (Mode != CipherMode.ECB && IVValue == null)
		{
			GenerateIV();
		}
		return CreateEncryptor(m_key, IVValue);
	}

	[SecurityCritical]
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!ValidKeySize(key.Length * 8))
		{
			throw new ArgumentException(SR.GetString("Cryptography_InvalidKeySize"), "key");
		}
		if (iv != null && iv.Length * 8 != BlockSizeValue)
		{
			throw new ArgumentException(SR.GetString("Cryptography_InvalidIVSize"), "iv");
		}
		byte[] array = (byte[])key.Clone();
		byte[] iv2 = null;
		if (iv != null)
		{
			iv2 = (byte[])iv.Clone();
		}
		using SafeCapiKeyHandle key2 = CapiNative.ImportSymmetricKey(m_cspHandle, GetAlgorithmId(array.Length * 8), array);
		return CreateEncryptor(key2, iv2);
	}

	[SecurityCritical]
	private ICryptoTransform CreateEncryptor(SafeCapiKeyHandle key, byte[] iv)
	{
		Contract.Requires(key != null);
		return new CapiSymmetricAlgorithm(BlockSizeValue, FeedbackSizeValue, m_cspHandle, key, iv, Mode, PaddingValue, EncryptionMode.Encrypt);
	}

	[SecurityCritical]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing)
		{
			if (m_key != null)
			{
				m_key.Dispose();
			}
			if (m_cspHandle != null)
			{
				m_cspHandle.Dispose();
			}
		}
	}

	[SecurityCritical]
	private static KeySizes[] FindSupportedKeySizes(SafeCspHandle csp, out int defaultKeySize)
	{
		Contract.Requires(csp != null);
		if (s_supportedKeySizes == null)
		{
			List<KeySizes> list = new List<KeySizes>();
			int num = 0;
			CapiNative.PROV_ENUMALGS providerParameterStruct = CapiNative.GetProviderParameterStruct<CapiNative.PROV_ENUMALGS>(csp, CapiNative.ProviderParameter.EnumerateAlgorithms, CapiNative.ProviderParameterFlags.RestartEnumeration);
			while (providerParameterStruct.aiAlgId != 0)
			{
				switch (providerParameterStruct.aiAlgId)
				{
				case CapiNative.AlgorithmId.Aes128:
					list.Add(new KeySizes(128, 128, 0));
					if (128 > num)
					{
						num = 128;
					}
					break;
				case CapiNative.AlgorithmId.Aes192:
					list.Add(new KeySizes(192, 192, 0));
					if (192 > num)
					{
						num = 192;
					}
					break;
				case CapiNative.AlgorithmId.Aes256:
					list.Add(new KeySizes(256, 256, 0));
					if (256 > num)
					{
						num = 256;
					}
					break;
				}
				providerParameterStruct = CapiNative.GetProviderParameterStruct<CapiNative.PROV_ENUMALGS>(csp, CapiNative.ProviderParameter.EnumerateAlgorithms, CapiNative.ProviderParameterFlags.None);
			}
			s_supportedKeySizes = list.ToArray();
			s_defaultKeySize = num;
		}
		defaultKeySize = s_defaultKeySize;
		return s_supportedKeySizes;
	}

	[SecurityCritical]
	public override void GenerateKey()
	{
		SafeCapiKeyHandle phKey = null;
		if (!CapiNative.UnsafeNativeMethods.CryptGenKey(m_cspHandle, GetAlgorithmId(KeySizeValue), CapiNative.KeyFlags.Exportable, out phKey))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		if (m_key != null)
		{
			m_key.Dispose();
		}
		m_key = phKey;
	}

	[SecurityCritical]
	public override void GenerateIV()
	{
		byte[] array = new byte[BlockSizeValue / 8];
		if (!CapiNative.UnsafeNativeMethods.CryptGenRandom(m_cspHandle, array.Length, array))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		IVValue = array;
	}

	private static CapiNative.AlgorithmId GetAlgorithmId(int keySize)
	{
		return keySize switch
		{
			256 => CapiNative.AlgorithmId.Aes256, 
			192 => CapiNative.AlgorithmId.Aes192, 
			128 => CapiNative.AlgorithmId.Aes128, 
			_ => CapiNative.AlgorithmId.None, 
		};
	}
}
