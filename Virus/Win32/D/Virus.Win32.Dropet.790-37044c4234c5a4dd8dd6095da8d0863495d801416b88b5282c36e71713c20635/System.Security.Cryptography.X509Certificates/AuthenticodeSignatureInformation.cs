using System.Security.Permissions;

namespace System.Security.Cryptography.X509Certificates;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class AuthenticodeSignatureInformation
{
	private string m_description;

	private Uri m_descriptionUrl;

	private CapiNative.AlgorithmId m_hashAlgorithmId;

	private X509Chain m_signatureChain;

	private TimestampInformation m_timestamp;

	private SignatureVerificationResult m_verificationResult;

	private X509Certificate2 m_signingCertificate;

	public string Description => m_description;

	public Uri DescriptionUrl => m_descriptionUrl;

	public string HashAlgorithm => CapiNative.GetAlgorithmName(m_hashAlgorithmId);

	public int HResult => CapiNative.HResultForVerificationResult(m_verificationResult);

	public X509Chain SignatureChain
	{
		[StorePermission(SecurityAction.Demand, OpenStore = true, EnumerateCertificates = true)]
		get
		{
			return m_signatureChain;
		}
	}

	public X509Certificate2 SigningCertificate
	{
		[StorePermission(SecurityAction.Demand, OpenStore = true, EnumerateCertificates = true)]
		get
		{
			if (m_signingCertificate == null && SignatureChain != null)
			{
				m_signingCertificate = SignatureChain.ChainElements[0].Certificate;
			}
			return m_signingCertificate;
		}
	}

	public TimestampInformation Timestamp => m_timestamp;

	public TrustStatus TrustStatus => VerificationResult switch
	{
		SignatureVerificationResult.Valid => TrustStatus.Trusted, 
		SignatureVerificationResult.CertificateExplicitlyDistrusted => TrustStatus.Untrusted, 
		SignatureVerificationResult.CertificateNotExplicitlyTrusted => TrustStatus.KnownIdentity, 
		_ => TrustStatus.UnknownIdentity, 
	};

	public SignatureVerificationResult VerificationResult => m_verificationResult;

	internal AuthenticodeSignatureInformation(X509Native.AXL_AUTHENTICODE_SIGNER_INFO signer, X509Chain signatureChain, TimestampInformation timestamp)
	{
		m_verificationResult = (SignatureVerificationResult)signer.dwError;
		m_hashAlgorithmId = signer.algHash;
		if (signer.pwszDescription != null)
		{
			m_description = signer.pwszDescription;
		}
		if (signer.pwszDescriptionUrl != null)
		{
			Uri.TryCreate(signer.pwszDescriptionUrl, UriKind.RelativeOrAbsolute, out m_descriptionUrl);
		}
		m_signatureChain = signatureChain;
		if (timestamp != null && timestamp.VerificationResult != SignatureVerificationResult.MissingSignature)
		{
			if (timestamp.IsValid)
			{
				m_timestamp = timestamp;
			}
			else
			{
				m_verificationResult = SignatureVerificationResult.InvalidTimestamp;
			}
		}
		else
		{
			m_timestamp = null;
		}
	}

	internal AuthenticodeSignatureInformation(SignatureVerificationResult error)
	{
		m_verificationResult = error;
	}
}
