using System;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;

namespace Intuit.QuickBooks.XmlDigitalSignature;

public sealed class XmlSigner
{
	public enum ErrorCodes
	{
		NoError,
		XmlError,
		ArgumentNullError,
		PfxError,
		CryptoError,
		ArgumentError,
		InvalidOperationError,
		UnitializedError,
		InvalidSignatureError
	}

	private static int AT_SIGNATURE = 2;

	private static RSACryptoServiceProvider RetrieveRsaKeyFromPfx(string pfxFile, string pfxPassword, ref ErrorCodes errorCode)
	{
		errorCode = ErrorCodes.UnitializedError;
		RSACryptoServiceProvider result;
		if (Pfx.pfx(pfxFile, pfxPassword, exportCertificate: true) == Pfx.pfxError.PFX_OK)
		{
			int providerType = Pfx.ProviderType;
			string providerName = Pfx.ProviderName;
			string container = Pfx.Container;
			CspParameters cspParameters = new CspParameters(providerType, providerName, container);
			cspParameters.KeyNumber = AT_SIGNATURE;
			result = new RSACryptoServiceProvider(cspParameters);
			errorCode = ErrorCodes.NoError;
		}
		else
		{
			result = null;
			errorCode = ErrorCodes.PfxError;
		}
		return result;
	}

	public static string RetrieveRsaPublicKey(string pfxFile, string pfxPassword, ref ErrorCodes errorCode)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		errorCode = ErrorCodes.UnitializedError;
		RSACryptoServiceProvider rSACryptoServiceProvider = RetrieveRsaKeyFromPfx(pfxFile, pfxPassword, ref errorCode);
		string innerXml;
		if (errorCode == ErrorCodes.NoError)
		{
			KeyInfo val = new KeyInfo();
			val.AddClause((KeyInfoClause)new RSAKeyValue((RSA)rSACryptoServiceProvider));
			try
			{
				XmlElement xml = val.GetXml();
				innerXml = xml.InnerXml;
				errorCode = ErrorCodes.NoError;
				return innerXml;
			}
			catch (XmlException)
			{
				innerXml = "";
				errorCode = ErrorCodes.XmlError;
				return innerXml;
			}
		}
		innerXml = "";
		errorCode = ErrorCodes.PfxError;
		return innerXml;
	}

	public static bool SignXmlFile(string FileName, string SignedFileName, string pfxFile, string pfxPassword, ref ErrorCodes errorCode)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.PreserveWhitespace = true;
		xmlDocument.Load(new XmlTextReader(FileName));
		xmlDocument = SignXmlDocument(xmlDocument, pfxFile, pfxPassword, ref errorCode);
		XmlTextWriter xmlTextWriter = new XmlTextWriter(SignedFileName, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlDocument.WriteTo(xmlTextWriter);
		xmlTextWriter.Close();
		if (errorCode == ErrorCodes.NoError)
		{
			return true;
		}
		return false;
	}

	public static XmlDocument SignXmlDocument(XmlDocument xmlToSign, string pfxFile, string pfxPassword, ref ErrorCodes errorCode)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		try
		{
			errorCode = ErrorCodes.NoError;
			SignedXml val = new SignedXml(xmlToSign);
			RSACryptoServiceProvider rSACryptoServiceProvider = RetrieveRsaKeyFromPfx(pfxFile, pfxPassword, ref errorCode);
			if (errorCode == ErrorCodes.NoError)
			{
				val.set_SigningKey((AsymmetricAlgorithm)rSACryptoServiceProvider);
				Reference val2 = new Reference();
				val2.set_Uri("");
				XmlDsigEnvelopedSignatureTransform val3 = new XmlDsigEnvelopedSignatureTransform();
				val2.AddTransform((Transform)(object)val3);
				val.AddReference(val2);
				KeyInfo val4 = new KeyInfo();
				val4.AddClause((KeyInfoClause)new RSAKeyValue((RSA)rSACryptoServiceProvider));
				val.set_KeyInfo(val4);
				val.ComputeSignature();
				XmlElement xml = val.GetXml();
				xmlToSign.DocumentElement!.AppendChild(xmlToSign.ImportNode(xml, deep: true));
				if (xmlToSign.FirstChild is XmlDeclaration)
				{
					xmlToSign.RemoveChild(xmlToSign.FirstChild);
				}
				errorCode = ErrorCodes.NoError;
				return xmlToSign;
			}
			return xmlToSign;
		}
		catch (XmlException)
		{
			errorCode = ErrorCodes.XmlError;
			return xmlToSign;
		}
		catch (ArgumentNullException)
		{
			errorCode = ErrorCodes.ArgumentNullError;
			return xmlToSign;
		}
		catch (ArgumentException)
		{
			errorCode = ErrorCodes.ArgumentError;
			return xmlToSign;
		}
		catch (CryptographicException)
		{
			errorCode = ErrorCodes.CryptoError;
			return xmlToSign;
		}
		catch (InvalidOperationException)
		{
			errorCode = ErrorCodes.InvalidOperationError;
			return xmlToSign;
		}
	}
}
