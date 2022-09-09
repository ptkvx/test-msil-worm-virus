using System.Security.Permissions;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public abstract class ECDiffieHellman : AsymmetricAlgorithm
{
	public override string KeyExchangeAlgorithm => "ECDiffieHellman";

	public override string SignatureAlgorithm => null;

	public abstract ECDiffieHellmanPublicKey PublicKey { get; }

	public new static ECDiffieHellman Create()
	{
		return Create(typeof(ECDiffieHellmanCng).FullName);
	}

	public new static ECDiffieHellman Create(string algorithm)
	{
		if (algorithm == null)
		{
			throw new ArgumentNullException("algorithm");
		}
		return CoreCryptoConfig.CreateFromName<ECDiffieHellman>(algorithm);
	}

	public abstract byte[] DeriveKeyMaterial(ECDiffieHellmanPublicKey otherPartyPublicKey);
}
