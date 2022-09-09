using System;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace Intuit.QuickBooks.XmlDigitalSignature;

public sealed class XmlVerifier
{
	public static bool VerifyXmlFile(string xmlFilePath, ref XmlSigner.ErrorCodes errorCode)
	{
		bool result = false;
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.PreserveWhitespace = true;
		try
		{
			xmlDocument.Load(xmlFilePath);
			result = VerifyXmlFile(xmlDocument, ref errorCode);
			return result;
		}
		catch (XmlException)
		{
			errorCode = XmlSigner.ErrorCodes.XmlError;
			return result;
		}
	}

	public static bool VerifyXmlFile(XmlDocument xmlDocument, ref XmlSigner.ErrorCodes errorCode)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		bool result = false;
		try
		{
			SignedXml val = new SignedXml(xmlDocument);
			XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("Signature");
			val.LoadXml((XmlElement)elementsByTagName[0]);
			if (result = val.CheckSignature())
			{
				if (!(result = VerifyKeyInfo(xmlDocument, "<KeyValue xmlns=\"http://www.w3.org/2000/09/xmldsig#\"><RSAKeyValue><Modulus>8XSM4Suvw9ClwcBXxdNC0+KOnKct1Z4GDNr5ZSpnQ99nlRYavwMiJ+pOVWrLSuHARNBulqD5RtDyUDckf59iYLhKabXe44vuU01qg6rbs/uaWzxdzcWtlrf7BpiFpB9ggP+9qbJ5lkU7WFB3kiAEOJRSoEVKIiwGzf9vr1cpw0s=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue></KeyValue>")))
				{
					errorCode = XmlSigner.ErrorCodes.XmlError;
					return result;
				}
				return result;
			}
			errorCode = XmlSigner.ErrorCodes.InvalidSignatureError;
			return result;
		}
		catch (XmlException)
		{
			errorCode = XmlSigner.ErrorCodes.XmlError;
			return result;
		}
		catch (CryptographicException)
		{
			errorCode = XmlSigner.ErrorCodes.CryptoError;
			return result;
		}
		catch (ArgumentNullException)
		{
			errorCode = XmlSigner.ErrorCodes.ArgumentNullError;
			return result;
		}
	}

	private static bool VerifyKeyInfo(XmlDocument doc, string expectedKeyInfo)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		bool result = false;
		XmlNodeList elementsByTagName = doc.GetElementsByTagName("KeyInfo");
		KeyInfo val = new KeyInfo();
		try
		{
			val.LoadXml((XmlElement)elementsByTagName[0]);
			XmlElement xml = val.GetXml();
			if (expectedKeyInfo.CompareTo(xml.InnerXml) == 0)
			{
				return true;
			}
			return result;
		}
		catch (ArgumentNullException)
		{
			return false;
		}
	}
}
