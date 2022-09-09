using System.Security.Permissions;

namespace System.Security.Cryptography;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public abstract class ECDiffieHellmanPublicKey : IDisposable
{
	private byte[] m_keyBlob;

	protected ECDiffieHellmanPublicKey(byte[] keyBlob)
	{
		if (keyBlob == null)
		{
			throw new ArgumentNullException("keyBlob");
		}
		m_keyBlob = keyBlob.Clone() as byte[];
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public virtual byte[] ToByteArray()
	{
		return m_keyBlob.Clone() as byte[];
	}

	public abstract string ToXmlString();
}
