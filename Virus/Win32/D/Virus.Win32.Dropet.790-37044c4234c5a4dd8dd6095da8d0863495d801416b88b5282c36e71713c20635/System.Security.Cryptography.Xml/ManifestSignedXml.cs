using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Xml;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.Xml;

internal sealed class ManifestSignedXml : SignedXml
{
	private ManifestKinds m_manifest;

	private XmlDocument m_manifestXml;

	private XmlNamespaceManager m_namespaceManager;

	public ManifestSignedXml(XmlDocument manifestXml, ManifestKinds manifest)
		: base(manifestXml)
	{
		m_manifest = manifest;
		m_manifestXml = manifestXml;
		m_namespaceManager = new XmlNamespaceManager(manifestXml.NameTable);
		m_namespaceManager.AddNamespace("as", "http://schemas.microsoft.com/windows/pki/2005/Authenticode");
		m_namespaceManager.AddNamespace("asm", "urn:schemas-microsoft-com:asm.v1");
		m_namespaceManager.AddNamespace("asmv2", "urn:schemas-microsoft-com:asm.v2");
		m_namespaceManager.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#");
		m_namespaceManager.AddNamespace("msrel", "http://schemas.microsoft.com/windows/rel/2005/reldata");
		m_namespaceManager.AddNamespace("r", "urn:mpeg:mpeg21:2003:01-REL-R-NS");
	}

	private static byte[] BackwardHexToBytes(string hex)
	{
		if (!string.IsNullOrEmpty(hex) && hex.Length % 2 == 0)
		{
			byte[] array = new byte[hex.Length / 2];
			int num = hex.Length - 2;
			int num2 = 0;
			while (true)
			{
				if (num2 < array.Length)
				{
					byte? b = HexToByte(hex[num]);
					byte? b2 = HexToByte(hex[num + 1]);
					if (!b.HasValue || !b2.HasValue)
					{
						break;
					}
					array[num2] = (byte)((b.Value << 4) | b2.Value);
					num -= 2;
					num2++;
					continue;
				}
				return array;
			}
			return null;
		}
		return null;
	}

	[SecurityCritical]
	[StorePermission(SecurityAction.Assert, EnumerateCertificates = true, OpenStore = true)]
	private X509Chain BuildSignatureChain(X509Native.AXL_AUTHENTICODE_SIGNER_INFO signer, XmlElement licenseNode, X509RevocationFlag revocationFlag, X509RevocationMode revocationMode)
	{
		X509Chain x509Chain = null;
		if (signer.dwError == -2146762487)
		{
			if (licenseNode.SelectSingleNode("r:issuer/ds:Signature/ds:KeyInfo/ds:X509Data", m_namespaceManager) is XmlElement xmlElement)
			{
				byte[] rawData = Convert.FromBase64String(xmlElement.InnerText.Trim());
				X509Certificate2 certificate = new X509Certificate2(rawData);
				x509Chain = new X509Chain();
				x509Chain.ChainPolicy.RevocationFlag = revocationFlag;
				x509Chain.ChainPolicy.RevocationMode = revocationMode;
				x509Chain.Build(certificate);
			}
		}
		else if (signer.pChainContext != IntPtr.Zero)
		{
			x509Chain = new X509Chain(signer.pChainContext);
		}
		return x509Chain;
	}

	private byte[] CalculateManifestPublicKeyToken()
	{
		if (!(m_manifestXml.SelectSingleNode("//asm:assembly/asm:assemblyIdentity", m_namespaceManager) is XmlElement xmlElement))
		{
			return null;
		}
		return HexStringToBytes(xmlElement.GetAttribute("publicKeyToken"));
	}

	[SecurityCritical]
	private unsafe static byte[] CalculateSignerPublicKeyToken(AsymmetricAlgorithm key)
	{
		if (!(key is ICspAsymmetricAlgorithm cspAsymmetricAlgorithm))
		{
			return null;
		}
		byte[] array = cspAsymmetricAlgorithm.ExportCspBlob(includePrivateParameters: false);
		SafeAxlBufferHandle ppwszPublicKeyToken;
		fixed (byte* value = array)
		{
			CapiNative.CRYPTOAPI_BLOB pCspPublicKeyBlob = default(CapiNative.CRYPTOAPI_BLOB);
			pCspPublicKeyBlob.cbData = array.Length;
			pCspPublicKeyBlob.pbData = new IntPtr(value);
			int num = CapiNative.UnsafeNativeMethods._AxlPublicKeyBlobToPublicKeyToken(ref pCspPublicKeyBlob, out ppwszPublicKeyToken);
			if (((uint)num & 0x80000000u) != 0)
			{
				return null;
			}
		}
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			ppwszPublicKeyToken.DangerousAddRef(ref success);
			return HexStringToBytes(Marshal.PtrToStringUni(ppwszPublicKeyToken.DangerousGetHandle()));
		}
		finally
		{
			if (success)
			{
				ppwszPublicKeyToken.DangerousRelease();
			}
		}
	}

	private static bool CompareBytes(byte[] lhs, byte[] rhs)
	{
		if (lhs != null && rhs != null)
		{
			int num = 0;
			while (true)
			{
				if (num < lhs.Length)
				{
					if (lhs[num] != rhs[num])
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public override XmlElement GetIdElement(XmlDocument document, string idValue)
	{
		if (((SignedXml)this).get_KeyInfo() != null && string.Compare(((SignedXml)this).get_KeyInfo().get_Id(), idValue, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return ((SignedXml)this).get_KeyInfo().GetXml();
		}
		return null;
	}

	[SecurityCritical]
	private TimestampInformation GetTimestampInformation(X509Native.AXL_AUTHENTICODE_TIMESTAMPER_INFO timestamper, XmlElement licenseNode)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		TimestampInformation result = null;
		if (timestamper.dwError == 0)
		{
			result = new TimestampInformation(timestamper);
		}
		else if (timestamper.dwError != -2146762748 && timestamper.dwError != -2146762496)
		{
			result = null;
		}
		else if (licenseNode.SelectSingleNode("r:issuer/ds:Signature/ds:Object/as:Timestamp", m_namespaceManager) is XmlElement xmlElement)
		{
			byte[] array = Convert.FromBase64String(xmlElement.InnerText);
			try
			{
				SignedCms val = new SignedCms();
				val.Decode(array);
				val.CheckSignature(true);
				return null;
			}
			catch (CryptographicException e)
			{
				return new TimestampInformation((SignatureVerificationResult)Marshal.GetHRForException(e));
			}
		}
		return result;
	}

	private static byte[] HexStringToBytes(string hex)
	{
		if (!string.IsNullOrEmpty(hex) && hex.Length % 2 == 0)
		{
			byte[] array = new byte[hex.Length / 2];
			int num = 0;
			while (true)
			{
				if (num < array.Length)
				{
					byte? b = HexToByte(hex[num]);
					byte? b2 = HexToByte(hex[num + 1]);
					if (!b.HasValue || !b2.HasValue)
					{
						break;
					}
					array[num] = (byte)((b.Value << 4) | b2.Value);
					num++;
					continue;
				}
				return array;
			}
			return null;
		}
		return null;
	}

	private static byte? HexToByte(char hex)
	{
		if (hex >= '0' && hex <= '9')
		{
			return (byte)(hex - 48);
		}
		if (hex >= 'a' && hex <= 'f')
		{
			return (byte)(hex - 97 + 10);
		}
		if (hex >= 'A' && hex <= 'F')
		{
			return (byte)(hex - 65 + 10);
		}
		return null;
	}

	private static X509Native.AxlVerificationFlags MapRevocationFlags(X509RevocationFlag revocationFlag, X509RevocationMode revocationMode)
	{
		X509Native.AxlVerificationFlags axlVerificationFlags = X509Native.AxlVerificationFlags.None;
		axlVerificationFlags = revocationFlag switch
		{
			X509RevocationFlag.EndCertificateOnly => axlVerificationFlags | X509Native.AxlVerificationFlags.RevocationCheckEndCertOnly, 
			X509RevocationFlag.EntireChain => axlVerificationFlags | X509Native.AxlVerificationFlags.RevocationCheckEntireChain, 
			_ => axlVerificationFlags, 
		};
		return revocationMode switch
		{
			X509RevocationMode.NoCheck => axlVerificationFlags | X509Native.AxlVerificationFlags.NoRevocationCheck, 
			X509RevocationMode.Offline => axlVerificationFlags | X509Native.AxlVerificationFlags.UrlOnlyCacheRetrieval, 
			_ => axlVerificationFlags, 
		};
	}

	private SignatureVerificationResult VerifyAuthenticodeExpectedHash(XmlElement licenseNode)
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		if (!(licenseNode.SelectSingleNode("r:grant/as:ManifestInformation", m_namespaceManager) is XmlElement xmlElement))
		{
			return SignatureVerificationResult.BadSignatureFormat;
		}
		string attribute = xmlElement.GetAttribute("Hash");
		if (string.IsNullOrEmpty(attribute))
		{
			return SignatureVerificationResult.BadSignatureFormat;
		}
		byte[] lhs = BackwardHexToBytes(attribute);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.PreserveWhitespace = true;
		XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
		xmlReaderSettings.ProhibitDtd = false;
		using (TextReader input = new StringReader(m_manifestXml.OuterXml))
		{
			using XmlReader reader = XmlReader.Create(input, xmlReaderSettings, m_manifestXml.BaseURI);
			xmlDocument.Load(reader);
		}
		XmlElement xmlElement2 = xmlDocument.SelectSingleNode("//asm:assembly/ds:Signature", m_namespaceManager) as XmlElement;
		xmlElement2.ParentNode!.RemoveChild(xmlElement2);
		XmlDsigExcC14NTransform val = new XmlDsigExcC14NTransform();
		((Transform)val).LoadInput((object)xmlDocument);
		byte[] rhs = null;
		using (SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider())
		{
			rhs = sHA1CryptoServiceProvider.ComputeHash(((Transform)val).GetOutput() as MemoryStream);
		}
		if (!CompareBytes(lhs, rhs))
		{
			return SignatureVerificationResult.BadDigest;
		}
		return SignatureVerificationResult.Valid;
	}

	[SecurityCritical]
	private SignatureVerificationResult VerifyAuthenticodePublisher(X509Certificate2 publisherCertificate)
	{
		if (!(m_manifestXml.SelectSingleNode("//asm:assembly/asmv2:publisherIdentity", m_namespaceManager) is XmlElement xmlElement))
		{
			return SignatureVerificationResult.BadSignatureFormat;
		}
		string attribute = xmlElement.GetAttribute("name");
		string attribute2 = xmlElement.GetAttribute("issuerKeyHash");
		if (!string.IsNullOrEmpty(attribute) && !string.IsNullOrEmpty(attribute2))
		{
			SafeAxlBufferHandle ppwszPublicKeyHash = null;
			int num = X509Native.UnsafeNativeMethods._AxlGetIssuerPublicKeyHash(publisherCertificate.Handle, out ppwszPublicKeyHash);
			if (num != 0)
			{
				return (SignatureVerificationResult)num;
			}
			string strB = null;
			bool success = false;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				ppwszPublicKeyHash.DangerousAddRef(ref success);
				strB = Marshal.PtrToStringUni(ppwszPublicKeyHash.DangerousGetHandle());
			}
			finally
			{
				if (success)
				{
					ppwszPublicKeyHash.DangerousRelease();
				}
			}
			if (string.Compare(attribute, publisherCertificate.SubjectName.Name, StringComparison.Ordinal) == 0 && string.Compare(attribute2, strB, StringComparison.Ordinal) == 0)
			{
				return SignatureVerificationResult.Valid;
			}
			return SignatureVerificationResult.PublisherMismatch;
		}
		return SignatureVerificationResult.BadSignatureFormat;
	}

	[SecurityCritical]
	private unsafe AuthenticodeSignatureInformation VerifyAuthenticodeSignature(XmlElement signatureNode, X509RevocationFlag revocationFlag, X509RevocationMode revocationMode)
	{
		if (!(signatureNode.SelectSingleNode("ds:KeyInfo/msrel:RelData/r:license", m_namespaceManager) is XmlElement xmlElement))
		{
			return null;
		}
		SignatureVerificationResult signatureVerificationResult = VerifyAuthenticodeSignatureIdentity(xmlElement);
		if (signatureVerificationResult != 0)
		{
			return new AuthenticodeSignatureInformation(signatureVerificationResult);
		}
		SignatureVerificationResult signatureVerificationResult2 = VerifyAuthenticodeExpectedHash(xmlElement);
		if (signatureVerificationResult2 != 0)
		{
			return new AuthenticodeSignatureInformation(signatureVerificationResult2);
		}
		AuthenticodeSignatureInformation authenticodeSignatureInformation = null;
		X509Native.AXL_AUTHENTICODE_SIGNER_INFO pSignerInfo = default(X509Native.AXL_AUTHENTICODE_SIGNER_INFO);
		pSignerInfo.cbSize = Marshal.SizeOf(typeof(X509Native.AXL_AUTHENTICODE_SIGNER_INFO));
		X509Native.AXL_AUTHENTICODE_TIMESTAMPER_INFO pTimestamperInfo = default(X509Native.AXL_AUTHENTICODE_TIMESTAMPER_INFO);
		pTimestamperInfo.cbsize = Marshal.SizeOf(typeof(X509Native.AXL_AUTHENTICODE_TIMESTAMPER_INFO));
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(xmlElement.OuterXml);
			X509Native.AxlVerificationFlags dwFlags = MapRevocationFlags(revocationFlag, revocationMode);
			try
			{
				fixed (byte* value = bytes)
				{
					CapiNative.CRYPTOAPI_BLOB pLicenseBlob = default(CapiNative.CRYPTOAPI_BLOB);
					pLicenseBlob.cbData = bytes.Length;
					pLicenseBlob.pbData = new IntPtr(value);
					int num = X509Native.UnsafeNativeMethods.CertVerifyAuthenticodeLicense(ref pLicenseBlob, dwFlags, ref pSignerInfo, ref pTimestamperInfo);
					if (num == -2146762496)
					{
						return new AuthenticodeSignatureInformation(SignatureVerificationResult.MissingSignature);
					}
				}
			}
			finally
			{
			}
			X509Chain signatureChain = BuildSignatureChain(pSignerInfo, xmlElement, revocationFlag, revocationMode);
			TimestampInformation timestampInformation = GetTimestampInformation(pTimestamperInfo, xmlElement);
			authenticodeSignatureInformation = new AuthenticodeSignatureInformation(pSignerInfo, signatureChain, timestampInformation);
		}
		finally
		{
			X509Native.UnsafeNativeMethods.CertFreeAuthenticodeSignerInfo(ref pSignerInfo);
			X509Native.UnsafeNativeMethods.CertFreeAuthenticodeTimestamperInfo(ref pTimestamperInfo);
		}
		if (authenticodeSignatureInformation.SigningCertificate == null)
		{
			return new AuthenticodeSignatureInformation(authenticodeSignatureInformation.VerificationResult);
		}
		SignatureVerificationResult signatureVerificationResult3 = VerifyAuthenticodePublisher(authenticodeSignatureInformation.SigningCertificate);
		if (signatureVerificationResult3 != 0)
		{
			return new AuthenticodeSignatureInformation(signatureVerificationResult3);
		}
		return authenticodeSignatureInformation;
	}

	private SignatureVerificationResult VerifyAuthenticodeSignatureIdentity(XmlElement licenseNode)
	{
		XmlElement xmlElement = licenseNode.SelectSingleNode("r:grant/as:ManifestInformation/as:assemblyIdentity", m_namespaceManager) as XmlElement;
		XmlElement xmlElement2 = m_manifestXml.SelectSingleNode("//asm:assembly/asm:assemblyIdentity", m_namespaceManager) as XmlElement;
		bool flag = xmlElement2?.HasAttributes ?? false;
		bool flag2 = xmlElement?.HasAttributes ?? false;
		if (flag && flag2 && xmlElement2.Attributes.Count == xmlElement.Attributes.Count)
		{
			foreach (XmlAttribute attribute2 in xmlElement2.Attributes)
			{
				string attribute = xmlElement.GetAttribute(attribute2.LocalName);
				if (attribute == null || string.Compare(attribute2.Value, attribute, StringComparison.Ordinal) != 0)
				{
					return SignatureVerificationResult.AssemblyIdentityMismatch;
				}
			}
			return SignatureVerificationResult.Valid;
		}
		return SignatureVerificationResult.BadSignatureFormat;
	}

	private static SignatureVerificationResult VerifyStrongNameSignatureId(XmlElement signatureNode)
	{
		string text = null;
		for (int i = 0; i < signatureNode.Attributes.Count; i++)
		{
			if (text != null)
			{
				break;
			}
			if (string.Compare(signatureNode.Attributes[i].LocalName, "id", StringComparison.OrdinalIgnoreCase) == 0)
			{
				text = signatureNode.Attributes[i].Value;
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			return SignatureVerificationResult.BadSignatureFormat;
		}
		if (string.Compare(text, "StrongNameSignature", StringComparison.Ordinal) != 0)
		{
			return SignatureVerificationResult.BadSignatureFormat;
		}
		return SignatureVerificationResult.Valid;
	}

	private static SignatureVerificationResult VerifyStrongNameSignatureTransforms(SignedInfo signedInfo)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		int num = 0;
		foreach (Reference reference in signedInfo.get_References())
		{
			Reference val = reference;
			TransformChain transformChain = val.get_TransformChain();
			bool flag = false;
			if (string.IsNullOrEmpty(val.get_Uri()))
			{
				num++;
				flag = transformChain != null && transformChain.get_Count() == 2 && string.Compare(transformChain.get_Item(0).get_Algorithm(), "http://www.w3.org/2000/09/xmldsig#enveloped-signature", StringComparison.Ordinal) == 0 && string.Compare(transformChain.get_Item(1).get_Algorithm(), "http://www.w3.org/2001/10/xml-exc-c14n#", StringComparison.Ordinal) == 0;
			}
			else if (string.Compare(val.get_Uri(), "#StrongNameKeyInfo", StringComparison.Ordinal) == 0)
			{
				num++;
				flag = transformChain != null && transformChain.get_Count() == 1 && string.Compare(transformChain.get_Item(0).get_Algorithm(), "http://www.w3.org/2001/10/xml-exc-c14n#", StringComparison.Ordinal) == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				return SignatureVerificationResult.BadSignatureFormat;
			}
		}
		if (num == 0)
		{
			return SignatureVerificationResult.BadSignatureFormat;
		}
		return SignatureVerificationResult.Valid;
	}

	[SecurityCritical]
	private StrongNameSignatureInformation VerifyStrongNameSignature(XmlElement signatureNode)
	{
		AsymmetricAlgorithm asymmetricAlgorithm = default(AsymmetricAlgorithm);
		if (!((SignedXml)this).CheckSignatureReturningKey(ref asymmetricAlgorithm))
		{
			return new StrongNameSignatureInformation(SignatureVerificationResult.BadDigest);
		}
		SignatureVerificationResult signatureVerificationResult = VerifyStrongNameSignatureId(signatureNode);
		if (signatureVerificationResult != 0)
		{
			return new StrongNameSignatureInformation(signatureVerificationResult);
		}
		SignatureVerificationResult signatureVerificationResult2 = VerifyStrongNameSignatureTransforms(((SignedXml)this).get_Signature().get_SignedInfo());
		if (signatureVerificationResult2 != 0)
		{
			return new StrongNameSignatureInformation(signatureVerificationResult2);
		}
		if (!CompareBytes(CalculateManifestPublicKeyToken(), CalculateSignerPublicKeyToken(asymmetricAlgorithm)))
		{
			return new StrongNameSignatureInformation(SignatureVerificationResult.PublicKeyTokenMismatch);
		}
		return new StrongNameSignatureInformation(asymmetricAlgorithm);
	}

	[SecurityCritical]
	public ManifestSignatureInformation VerifySignature(X509RevocationFlag revocationFlag, X509RevocationMode revocationMode)
	{
		if (!(m_manifestXml.SelectSingleNode("//ds:Signature", m_namespaceManager) is XmlElement xmlElement))
		{
			return new ManifestSignatureInformation(m_manifest, null, null);
		}
		((SignedXml)this).LoadXml(xmlElement);
		StrongNameSignatureInformation strongNameSignatureInformation = VerifyStrongNameSignature(xmlElement);
		AuthenticodeSignatureInformation authenticodeSignatureInformation = null;
		return new ManifestSignatureInformation(authenticodeSignature: (strongNameSignatureInformation.VerificationResult == SignatureVerificationResult.BadDigest) ? new AuthenticodeSignatureInformation(SignatureVerificationResult.ContainingSignatureInvalid) : VerifyAuthenticodeSignature(xmlElement, revocationFlag, revocationMode), manifest: m_manifest, strongNameSignature: strongNameSignatureInformation);
	}
}
