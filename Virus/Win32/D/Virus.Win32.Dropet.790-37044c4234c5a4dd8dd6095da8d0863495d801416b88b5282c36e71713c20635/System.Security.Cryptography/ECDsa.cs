using System.Security.Permissions;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public abstract class ECDsa : AsymmetricAlgorithm
{
	public override string KeyExchangeAlgorithm => null;

	public override string SignatureAlgorithm => "ECDsa";

	public new static ECDsa Create()
	{
		return Create(typeof(ECDsaCng).FullName);
	}

	public new static ECDsa Create(string algorithm)
	{
		if (algorithm == null)
		{
			throw new ArgumentNullException("algorithm");
		}
		return CoreCryptoConfig.CreateFromName<ECDsa>(algorithm);
	}

	public abstract byte[] SignHash(byte[] hash);

	public abstract bool VerifyHash(byte[] hash, byte[] signature);
}
