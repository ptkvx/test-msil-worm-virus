using System.Security.Permissions;
using Microsoft.Contracts;

namespace System.Security.Cryptography;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ECDiffieHellmanCngPublicKey : ECDiffieHellmanPublicKey
{
	[NonSerialized]
	private CngKey m_key;

	private CngKeyBlobFormat m_format;

	public CngKeyBlobFormat BlobFormat => m_format;

	[SecurityCritical]
	internal ECDiffieHellmanCngPublicKey(CngKey key)
		: base(key.Export(CngKeyBlobFormat.EccPublicBlob))
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		Contract.Requires(key != null && key.AlgorithmGroup == CngAlgorithmGroup.ECDiffieHellman);
		m_format = CngKeyBlobFormat.EccPublicBlob;
		((CodeAccessPermission)new SecurityPermission(SecurityPermissionFlag.UnmanagedCode)).Assert();
		m_key = CngKey.Open(key.Handle, key.IsEphemeral ? CngKeyHandleOpenOptions.EphemeralKey : CngKeyHandleOpenOptions.None);
		CodeAccessPermission.RevertAssert();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing && m_key != null)
		{
			m_key.Dispose();
		}
	}

	[SecurityCritical]
	public static ECDiffieHellmanPublicKey FromByteArray(byte[] publicKeyBlob, CngKeyBlobFormat format)
	{
		if (publicKeyBlob == null)
		{
			throw new ArgumentNullException("publicKeyBlob");
		}
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		using CngKey cngKey = CngKey.Import(publicKeyBlob, format);
		if (cngKey.AlgorithmGroup != CngAlgorithmGroup.ECDiffieHellman)
		{
			throw new ArgumentException(SR.GetString("Cryptography_ArgECDHRequiresECDHKey"));
		}
		return new ECDiffieHellmanCngPublicKey(cngKey);
	}

	[SecurityCritical]
	public static ECDiffieHellmanCngPublicKey FromXmlString(string xml)
	{
		if (xml == null)
		{
			throw new ArgumentNullException("xml");
		}
		using CngKey cngKey = Rfc4050KeyFormatter.FromXml(xml);
		if (cngKey.AlgorithmGroup != CngAlgorithmGroup.ECDiffieHellman)
		{
			throw new ArgumentException(SR.GetString("Cryptography_ArgECDHRequiresECDHKey"), "xml");
		}
		return new ECDiffieHellmanCngPublicKey(cngKey);
	}

	public CngKey Import()
	{
		return CngKey.Import(ToByteArray(), BlobFormat);
	}

	public override string ToXmlString()
	{
		if (m_key == null)
		{
			m_key = Import();
		}
		return Rfc4050KeyFormatter.ToXml(m_key);
	}
}
