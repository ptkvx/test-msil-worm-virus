using System.Security.Permissions;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class SHA384CryptoServiceProvider : SHA384
{
	private CapiHashAlgorithm m_hashAlgorithm;

	[SecurityCritical]
	public SHA384CryptoServiceProvider()
	{
		m_hashAlgorithm = new CapiHashAlgorithm("Microsoft Enhanced RSA and AES Cryptographic Provider", CapiNative.ProviderType.RsaAes, CapiNative.AlgorithmId.Sha384);
	}

	[SecurityCritical]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing)
		{
			m_hashAlgorithm.Dispose();
		}
	}

	[SecurityCritical]
	public override void Initialize()
	{
		m_hashAlgorithm.Initialize();
	}

	[SecurityCritical]
	protected override void HashCore(byte[] array, int ibStart, int cbSize)
	{
		m_hashAlgorithm.HashCore(array, ibStart, cbSize);
	}

	[SecurityCritical]
	protected override byte[] HashFinal()
	{
		return m_hashAlgorithm.HashFinal();
	}
}
