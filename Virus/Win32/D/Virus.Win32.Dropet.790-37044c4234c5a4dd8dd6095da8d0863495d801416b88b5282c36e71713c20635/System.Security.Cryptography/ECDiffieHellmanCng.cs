using System.Security.Permissions;
using Microsoft.Contracts;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ECDiffieHellmanCng : ECDiffieHellman
{
	private static KeySizes[] s_legalKeySizes = new KeySizes[2]
	{
		new KeySizes(256, 384, 128),
		new KeySizes(521, 521, 0)
	};

	private CngAlgorithm m_hashAlgorithm = CngAlgorithm.Sha256;

	private byte[] m_hmacKey;

	private CngKey m_key;

	private ECDiffieHellmanKeyDerivationFunction m_kdf;

	private byte[] m_label;

	private byte[] m_secretAppend;

	private byte[] m_secretPrepend;

	private byte[] m_seed;

	public CngAlgorithm HashAlgorithm
	{
		get
		{
			return m_hashAlgorithm;
		}
		set
		{
			if (m_hashAlgorithm == null)
			{
				throw new ArgumentNullException("value");
			}
			m_hashAlgorithm = value;
		}
	}

	public byte[] HmacKey
	{
		get
		{
			return m_hmacKey;
		}
		set
		{
			m_hmacKey = value;
		}
	}

	public ECDiffieHellmanKeyDerivationFunction KeyDerivationFunction
	{
		get
		{
			return m_kdf;
		}
		set
		{
			if (value < ECDiffieHellmanKeyDerivationFunction.Hash || value > ECDiffieHellmanKeyDerivationFunction.Tls)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			m_kdf = value;
		}
	}

	public byte[] Label
	{
		get
		{
			return m_label;
		}
		set
		{
			m_label = value;
		}
	}

	public byte[] SecretAppend
	{
		get
		{
			return m_secretAppend;
		}
		set
		{
			m_secretAppend = value;
		}
	}

	public byte[] SecretPrepend
	{
		get
		{
			return m_secretPrepend;
		}
		set
		{
			m_secretPrepend = value;
		}
	}

	public byte[] Seed
	{
		get
		{
			return m_seed;
		}
		set
		{
			m_seed = value;
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
					algorithm = CngAlgorithm.ECDiffieHellmanP521;
					break;
				case 384:
					algorithm = CngAlgorithm.ECDiffieHellmanP384;
					break;
				case 256:
					algorithm = CngAlgorithm.ECDiffieHellmanP256;
					break;
				}
				m_key = CngKey.Create(algorithm);
			}
			return m_key;
		}
		private set
		{
			Contract.Requires(value != null);
			if (value.AlgorithmGroup != CngAlgorithmGroup.ECDiffieHellman)
			{
				throw new ArgumentException(SR.GetString("Cryptography_ArgECDHRequiresECDHKey"));
			}
			if (m_key != null)
			{
				m_key.Dispose();
			}
			m_key = value;
			KeySize = m_key.KeySize;
		}
	}

	public override ECDiffieHellmanPublicKey PublicKey
	{
		[SecurityCritical]
		get
		{
			return new ECDiffieHellmanCngPublicKey(Key);
		}
	}

	public bool UseSecretAgreementAsHmacKey => HmacKey == null;

	public ECDiffieHellmanCng()
		: this(521)
	{
	}

	[SecurityCritical]
	public ECDiffieHellmanCng(int keySize)
	{
		if (!NCryptNative.NCryptSupported)
		{
			throw new PlatformNotSupportedException(SR.GetString("Cryptography_PlatformNotSupported"));
		}
		LegalKeySizesValue = s_legalKeySizes;
		KeySize = keySize;
	}

	[SecurityCritical]
	public ECDiffieHellmanCng(CngKey key)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (key.AlgorithmGroup != CngAlgorithmGroup.ECDiffieHellman)
		{
			throw new ArgumentException(SR.GetString("Cryptography_ArgECDHRequiresECDHKey"), "key");
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

	public override byte[] DeriveKeyMaterial(ECDiffieHellmanPublicKey otherPartyPublicKey)
	{
		if (otherPartyPublicKey == null)
		{
			throw new ArgumentNullException("otherPartyPublicKey");
		}
		ECDiffieHellmanCngPublicKey eCDiffieHellmanCngPublicKey = otherPartyPublicKey as ECDiffieHellmanCngPublicKey;
		if (otherPartyPublicKey == null)
		{
			throw new ArgumentException(SR.GetString("Cryptography_ArgExpectedECDiffieHellmanCngPublicKey"));
		}
		using CngKey otherPartyPublicKey2 = eCDiffieHellmanCngPublicKey.Import();
		return DeriveKeyMaterial(otherPartyPublicKey2);
	}

	[SecurityCritical]
	public byte[] DeriveKeyMaterial(CngKey otherPartyPublicKey)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (otherPartyPublicKey == null)
		{
			throw new ArgumentNullException("otherPartyPublicKey");
		}
		if (otherPartyPublicKey.AlgorithmGroup != CngAlgorithmGroup.ECDiffieHellman)
		{
			throw new ArgumentException(SR.GetString("Cryptography_ArgECDHRequiresECDHKey"), "otherPartyPublicKey");
		}
		if (otherPartyPublicKey.KeySize != KeySize)
		{
			throw new ArgumentException(SR.GetString("Cryptography_ArgECDHKeySizeMismatch"), "otherPartyPublicKey");
		}
		NCryptNative.SecretAgreementFlags flags = (UseSecretAgreementAsHmacKey ? NCryptNative.SecretAgreementFlags.UseSecretAsHmacKey : NCryptNative.SecretAgreementFlags.None);
		((CodeAccessPermission)new SecurityPermission(SecurityPermissionFlag.UnmanagedCode)).Assert();
		SafeNCryptKeyHandle handle = Key.Handle;
		SafeNCryptKeyHandle handle2 = otherPartyPublicKey.Handle;
		CodeAccessPermission.RevertAssert();
		using SafeNCryptSecretHandle secretAgreement = NCryptNative.DeriveSecretAgreement(handle, handle2);
		if (KeyDerivationFunction == ECDiffieHellmanKeyDerivationFunction.Hash)
		{
			byte[] secretAppend = ((SecretAppend == null) ? null : (SecretAppend.Clone() as byte[]));
			byte[] secretPrepend = ((SecretPrepend == null) ? null : (SecretPrepend.Clone() as byte[]));
			return NCryptNative.DeriveKeyMaterialHash(secretAgreement, HashAlgorithm.Algorithm, secretPrepend, secretAppend, flags);
		}
		if (KeyDerivationFunction == ECDiffieHellmanKeyDerivationFunction.Hmac)
		{
			byte[] hmacKey = ((HmacKey == null) ? null : (HmacKey.Clone() as byte[]));
			byte[] secretAppend2 = ((SecretAppend == null) ? null : (SecretAppend.Clone() as byte[]));
			byte[] secretPrepend2 = ((SecretPrepend == null) ? null : (SecretPrepend.Clone() as byte[]));
			return NCryptNative.DeriveKeyMaterialHmac(secretAgreement, HashAlgorithm.Algorithm, hmacKey, secretPrepend2, secretAppend2, flags);
		}
		byte[] array = ((Label == null) ? null : (Label.Clone() as byte[]));
		byte[] array2 = ((Seed == null) ? null : (Seed.Clone() as byte[]));
		if (array == null || array2 == null)
		{
			throw new InvalidOperationException(SR.GetString("Cryptography_TlsRequiresLabelAndSeed"));
		}
		return NCryptNative.DeriveKeyMaterialTls(secretAgreement, array, array2, flags);
	}

	public SafeNCryptSecretHandle DeriveSecretAgreementHandle(ECDiffieHellmanPublicKey otherPartyPublicKey)
	{
		if (otherPartyPublicKey == null)
		{
			throw new ArgumentNullException("otherPartyPublicKey");
		}
		ECDiffieHellmanCngPublicKey eCDiffieHellmanCngPublicKey = otherPartyPublicKey as ECDiffieHellmanCngPublicKey;
		if (otherPartyPublicKey == null)
		{
			throw new ArgumentException(SR.GetString("Cryptography_ArgExpectedECDiffieHellmanCngPublicKey"));
		}
		using CngKey otherPartyPublicKey2 = eCDiffieHellmanCngPublicKey.Import();
		return DeriveSecretAgreementHandle(otherPartyPublicKey2);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public SafeNCryptSecretHandle DeriveSecretAgreementHandle(CngKey otherPartyPublicKey)
	{
		if (otherPartyPublicKey == null)
		{
			throw new ArgumentNullException("otherPartyPublicKey");
		}
		if (otherPartyPublicKey.AlgorithmGroup != CngAlgorithmGroup.ECDiffieHellman)
		{
			throw new ArgumentException(SR.GetString("Cryptography_ArgECDHRequiresECDHKey"), "otherPartyPublicKey");
		}
		if (otherPartyPublicKey.KeySize != KeySize)
		{
			throw new ArgumentException(SR.GetString("Cryptography_ArgECDHKeySizeMismatch"), "otherPartyPublicKey");
		}
		return NCryptNative.DeriveSecretAgreement(Key.Handle, otherPartyPublicKey.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && m_key != null)
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
}
