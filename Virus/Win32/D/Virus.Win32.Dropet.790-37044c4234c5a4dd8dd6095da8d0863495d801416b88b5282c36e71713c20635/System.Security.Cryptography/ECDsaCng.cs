using System.IO;
using System.Security.Permissions;
using Microsoft.Contracts;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ECDsaCng : ECDsa
{
	private static KeySizes[] s_legalKeySizes = new KeySizes[2]
	{
		new KeySizes(256, 384, 128),
		new KeySizes(521, 521, 0)
	};

	private CngKey m_key;

	private CngAlgorithm m_hashAlgorithm = CngAlgorithm.Sha256;

	public CngAlgorithm HashAlgorithm
	{
		get
		{
			return m_hashAlgorithm;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			m_hashAlgorithm = value;
		}
	}

	public CngKey Key
	{
		get
		{
			if (m_key != null && m_key.KeySize != KeySize)
			{
				m_key.Dispose();
				m_key = null;
			}
			if (m_key == null)
			{
				CngAlgorithm algorithm = null;
				switch (KeySize)
				{
				case 521:
					algorithm = CngAlgorithm.ECDsaP521;
					break;
				case 384:
					algorithm = CngAlgorithm.ECDsaP384;
					break;
				case 256:
					algorithm = CngAlgorithm.ECDsaP256;
					break;
				}
				m_key = CngKey.Create(algorithm);
			}
			return m_key;
		}
		private set
		{
			Contract.Requires(value != null);
			if (value.AlgorithmGroup != CngAlgorithmGroup.ECDsa)
			{
				throw new ArgumentException(SR.GetString("Cryptography_ArgECDsaRequiresECDsaKey"));
			}
			if (m_key != null)
			{
				m_key.Dispose();
			}
			m_key = value;
			KeySize = m_key.KeySize;
		}
	}

	public ECDsaCng()
		: this(521)
	{
	}

	[SecurityCritical]
	public ECDsaCng(int keySize)
	{
		if (!NCryptNative.NCryptSupported)
		{
			throw new PlatformNotSupportedException(SR.GetString("Cryptography_PlatformNotSupported"));
		}
		LegalKeySizesValue = s_legalKeySizes;
		KeySize = keySize;
	}

	[SecurityCritical]
	public ECDsaCng(CngKey key)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (key.AlgorithmGroup != CngAlgorithmGroup.ECDsa)
		{
			throw new ArgumentException(SR.GetString("Cryptography_ArgECDsaRequiresECDsaKey"), "key");
		}
		if (!NCryptNative.NCryptSupported)
		{
			throw new PlatformNotSupportedException(SR.GetString("Cryptography_PlatformNotSupported"));
		}
		LegalKeySizesValue = s_legalKeySizes;
		((CodeAccessPermission)new SecurityPermission(SecurityPermissionFlag.UnmanagedCode)).Assert();
		Key = CngKey.Open(key.Handle, key.IsEphemeral ? CngKeyHandleOpenOptions.EphemeralKey : CngKeyHandleOpenOptions.None);
		CodeAccessPermission.RevertAssert();
		KeySize = m_key.KeySize;
	}

	protected override void Dispose(bool disposing)
	{
		if (m_key != null)
		{
			m_key.Dispose();
		}
	}

	public override void FromXmlString(string xmlString)
	{
		throw new NotImplementedException(SR.GetString("Cryptography_ECXmlSerializationFormatRequired"));
	}

	public void FromXmlString(string xml, ECKeyXmlFormat format)
	{
		if (xml == null)
		{
			throw new ArgumentNullException("xml");
		}
		if (format != 0)
		{
			throw new ArgumentOutOfRangeException("format");
		}
		Key = Rfc4050KeyFormatter.FromXml(xml);
	}

	public byte[] SignData(byte[] data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return SignData(data, 0, data.Length);
	}

	[SecurityCritical]
	public byte[] SignData(byte[] data, int offset, int count)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (offset >= 0 && offset <= data.Length)
		{
			if (count >= 0 && count <= data.Length - offset)
			{
				using (BCryptHashAlgorithm bCryptHashAlgorithm = new BCryptHashAlgorithm(HashAlgorithm, "Microsoft Primitive Provider"))
				{
					bCryptHashAlgorithm.HashCore(data, offset, count);
					byte[] hash = bCryptHashAlgorithm.HashFinal();
					return SignHash(hash);
				}
			}
			throw new ArgumentOutOfRangeException("count");
		}
		throw new ArgumentOutOfRangeException("offset");
	}

	[SecurityCritical]
	public byte[] SignData(Stream data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		using BCryptHashAlgorithm bCryptHashAlgorithm = new BCryptHashAlgorithm(HashAlgorithm, "Microsoft Primitive Provider");
		bCryptHashAlgorithm.HashStream(data);
		byte[] hash = bCryptHashAlgorithm.HashFinal();
		return SignHash(hash);
	}

	[SecurityCritical]
	public override byte[] SignHash(byte[] hash)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (hash == null)
		{
			throw new ArgumentNullException("hash");
		}
		KeyContainerPermission val = Key.BuildKeyContainerPermission((KeyContainerPermissionFlags)256);
		if (val != null)
		{
			((CodeAccessPermission)val).Demand();
		}
		((CodeAccessPermission)new SecurityPermission(SecurityPermissionFlag.UnmanagedCode)).Assert();
		SafeNCryptKeyHandle handle = Key.Handle;
		CodeAccessPermission.RevertAssert();
		return NCryptNative.SignHash(handle, hash);
	}

	public override string ToXmlString(bool includePrivateParameters)
	{
		throw new NotImplementedException(SR.GetString("Cryptography_ECXmlSerializationFormatRequired"));
	}

	public string ToXmlString(ECKeyXmlFormat format)
	{
		if (format != 0)
		{
			throw new ArgumentOutOfRangeException("format");
		}
		return Rfc4050KeyFormatter.ToXml(Key);
	}

	public bool VerifyData(byte[] data, byte[] signature)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return VerifyData(data, 0, data.Length, signature);
	}

	[SecurityCritical]
	public bool VerifyData(byte[] data, int offset, int count, byte[] signature)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (offset >= 0 && offset <= data.Length)
		{
			if (count >= 0 && count <= data.Length - offset)
			{
				if (signature == null)
				{
					throw new ArgumentNullException("signature");
				}
				using BCryptHashAlgorithm bCryptHashAlgorithm = new BCryptHashAlgorithm(HashAlgorithm, "Microsoft Primitive Provider");
				bCryptHashAlgorithm.HashCore(data, offset, count);
				byte[] hash = bCryptHashAlgorithm.HashFinal();
				return VerifyHash(hash, signature);
			}
			throw new ArgumentOutOfRangeException("count");
		}
		throw new ArgumentOutOfRangeException("offset");
	}

	[SecurityCritical]
	public bool VerifyData(Stream data, byte[] signature)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		using BCryptHashAlgorithm bCryptHashAlgorithm = new BCryptHashAlgorithm(HashAlgorithm, "Microsoft Primitive Provider");
		bCryptHashAlgorithm.HashStream(data);
		byte[] hash = bCryptHashAlgorithm.HashFinal();
		return VerifyHash(hash, signature);
	}

	[SecurityCritical]
	public override bool VerifyHash(byte[] hash, byte[] signature)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (hash == null)
		{
			throw new ArgumentNullException("hash");
		}
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		((CodeAccessPermission)new SecurityPermission(SecurityPermissionFlag.UnmanagedCode)).Assert();
		SafeNCryptKeyHandle handle = Key.Handle;
		CodeAccessPermission.RevertAssert();
		return NCryptNative.VerifySignature(handle, hash, signature);
	}
}
