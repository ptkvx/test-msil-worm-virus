using System.Globalization;
using System.IO;
using System.Numeric;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using Microsoft.Contracts;

namespace System.Security.Cryptography;

internal static class Rfc4050KeyFormatter
{
	private const string DomainParametersRoot = "DomainParameters";

	private const string ECDHRoot = "ECDHKeyValue";

	private const string ECDsaRoot = "ECDSAKeyValue";

	private const string NamedCurveElement = "NamedCurve";

	private const string Namespace = "http://www.w3.org/2001/04/xmldsig-more#";

	private const string PublicKeyRoot = "PublicKey";

	private const string UrnAttribute = "URN";

	private const string ValueAttribute = "Value";

	private const string XElement = "X";

	private const string YElement = "Y";

	private const string Prime256CurveUrn = "urn:oid:1.2.840.10045.3.1.7";

	private const string Prime384CurveUrn = "urn:oid:1.3.132.0.34";

	private const string Prime521CurveUrn = "urn:oid:1.3.132.0.35";

	internal static CngKey FromXml(string xml)
	{
		Contract.Requires(xml != null);
		using TextReader input = new StringReader(xml);
		using XmlTextReader reader = new XmlTextReader(input);
		XPathDocument xPathDocument = new XPathDocument(reader);
		XPathNavigator xPathNavigator = xPathDocument.CreateNavigator();
		if (!xPathNavigator.MoveToFirstChild())
		{
			throw new ArgumentException(SR.GetString("Cryptography_MissingDomainParameters"));
		}
		if (xPathNavigator.NamespaceURI != "http://www.w3.org/2001/04/xmldsig-more#")
		{
			throw new ArgumentException(SR.GetString("Cryptography_UnexpectedXmlNamespace", xPathNavigator.NamespaceURI, "http://www.w3.org/2001/04/xmldsig-more#"));
		}
		CngAlgorithm cngAlgorithm = ReadAlgorithm(xPathNavigator);
		if (!xPathNavigator.MoveToNext(XPathNodeType.Element))
		{
			throw new ArgumentException(SR.GetString("Cryptography_MissingPublicKey"));
		}
		ReadPublicKey(xPathNavigator, out var x, out var y);
		byte[] keyBlob = NCryptNative.BuildEccPublicBlob(cngAlgorithm.Algorithm, x, y);
		return CngKey.Import(keyBlob, CngKeyBlobFormat.EccPublicBlob);
	}

	private static int GetKeySize(string urn)
	{
		Contract.Requires(!string.IsNullOrEmpty(urn));
		return urn switch
		{
			"urn:oid:1.3.132.0.35" => 521, 
			"urn:oid:1.3.132.0.34" => 384, 
			"urn:oid:1.2.840.10045.3.1.7" => 256, 
			_ => throw new ArgumentException(SR.GetString("Cryptography_UnknownEllipticCurve"), "algorithm"), 
		};
	}

	private static string GetCurveUrn(CngAlgorithm algorithm)
	{
		Contract.Requires(algorithm != null);
		if (!(algorithm == CngAlgorithm.ECDsaP256) && !(algorithm == CngAlgorithm.ECDiffieHellmanP256))
		{
			if (!(algorithm == CngAlgorithm.ECDsaP384) && !(algorithm == CngAlgorithm.ECDiffieHellmanP384))
			{
				if (!(algorithm == CngAlgorithm.ECDsaP521) && !(algorithm == CngAlgorithm.ECDiffieHellmanP521))
				{
					throw new ArgumentException(SR.GetString("Cryptography_UnknownEllipticCurve"), "algorithm");
				}
				return "urn:oid:1.3.132.0.35";
			}
			return "urn:oid:1.3.132.0.34";
		}
		return "urn:oid:1.2.840.10045.3.1.7";
	}

	private static CngAlgorithm ReadAlgorithm(XPathNavigator navigator)
	{
		Contract.Requires(navigator != null);
		if (navigator.NamespaceURI != "http://www.w3.org/2001/04/xmldsig-more#")
		{
			throw new ArgumentException(SR.GetString("Cryptography_UnexpectedXmlNamespace", navigator.NamespaceURI, "http://www.w3.org/2001/04/xmldsig-more#"));
		}
		bool flag = navigator.Name == "ECDHKeyValue";
		bool flag2 = navigator.Name == "ECDSAKeyValue";
		if (!flag && !flag2)
		{
			throw new ArgumentException(SR.GetString("Cryptography_UnknownEllipticCurveAlgorithm"));
		}
		if (navigator.MoveToFirstChild() && !(navigator.Name != "DomainParameters"))
		{
			if (navigator.MoveToFirstChild() && !(navigator.Name != "NamedCurve"))
			{
				if (navigator.MoveToFirstAttribute() && !(navigator.Name != "URN") && !string.IsNullOrEmpty(navigator.Value))
				{
					int keySize = GetKeySize(navigator.Value);
					navigator.MoveToParent();
					navigator.MoveToParent();
					if (flag)
					{
						return keySize switch
						{
							256 => CngAlgorithm.ECDiffieHellmanP256, 
							384 => CngAlgorithm.ECDiffieHellmanP384, 
							_ => CngAlgorithm.ECDiffieHellmanP521, 
						};
					}
					return keySize switch
					{
						256 => CngAlgorithm.ECDsaP256, 
						384 => CngAlgorithm.ECDsaP384, 
						_ => CngAlgorithm.ECDsaP521, 
					};
				}
				throw new ArgumentException(SR.GetString("Cryptography_MissingDomainParameters"));
			}
			throw new ArgumentException(SR.GetString("Cryptography_MissingDomainParameters"));
		}
		throw new ArgumentException(SR.GetString("Cryptography_MissingDomainParameters"));
	}

	private static void ReadPublicKey(XPathNavigator navigator, out BigInteger x, out BigInteger y)
	{
		Contract.Requires(navigator != null);
		if (navigator.NamespaceURI != "http://www.w3.org/2001/04/xmldsig-more#")
		{
			throw new ArgumentException(SR.GetString("Cryptography_UnexpectedXmlNamespace", navigator.NamespaceURI, "http://www.w3.org/2001/04/xmldsig-more#"));
		}
		if (navigator.Name != "PublicKey")
		{
			throw new ArgumentException(SR.GetString("Cryptography_MissingPublicKey"));
		}
		if (navigator.MoveToFirstChild() && !(navigator.Name != "X"))
		{
			if (navigator.MoveToFirstAttribute() && !(navigator.Name != "Value") && !string.IsNullOrEmpty(navigator.Value))
			{
				x = BigInteger.Parse(navigator.Value, CultureInfo.InvariantCulture);
				navigator.MoveToParent();
				if (navigator.MoveToNext(XPathNodeType.Element) && !(navigator.Name != "Y"))
				{
					if (!navigator.MoveToFirstAttribute() || navigator.Name != "Value" || string.IsNullOrEmpty(navigator.Value))
					{
						throw new ArgumentException(SR.GetString("Cryptography_MissingPublicKey"));
					}
					y = BigInteger.Parse(navigator.Value, CultureInfo.InvariantCulture);
					return;
				}
				throw new ArgumentException(SR.GetString("Cryptography_MissingPublicKey"));
			}
			throw new ArgumentException(SR.GetString("Cryptography_MissingPublicKey"));
		}
		throw new ArgumentException(SR.GetString("Cryptography_MissingPublicKey"));
	}

	private static void WriteDomainParameters(XmlWriter writer, CngKey key)
	{
		Contract.Requires(writer != null);
		Contract.Requires(key != null && (key.AlgorithmGroup == CngAlgorithmGroup.ECDsa || key.AlgorithmGroup == CngAlgorithmGroup.ECDiffieHellman));
		writer.WriteStartElement("DomainParameters");
		writer.WriteStartElement("NamedCurve");
		writer.WriteAttributeString("URN", GetCurveUrn(key.Algorithm));
		writer.WriteEndElement();
		writer.WriteEndElement();
	}

	private static void WritePublicKeyValue(XmlWriter writer, CngKey key)
	{
		Contract.Requires(writer != null);
		Contract.Requires(key != null && (key.AlgorithmGroup == CngAlgorithmGroup.ECDsa || key.AlgorithmGroup == CngAlgorithmGroup.ECDiffieHellman));
		writer.WriteStartElement("PublicKey");
		byte[] blob = key.Export(CngKeyBlobFormat.EccPublicBlob);
		NCryptNative.UnpackEccPublicBlob(blob, out var x, out var y);
		writer.WriteStartElement("X");
		writer.WriteAttributeString("Value", x.ToString(CultureInfo.InvariantCulture));
		writer.WriteEndElement();
		writer.WriteStartElement("Y");
		writer.WriteAttributeString("Value", y.ToString(CultureInfo.InvariantCulture));
		writer.WriteEndElement();
		writer.WriteEndElement();
	}

	internal static string ToXml(CngKey key)
	{
		Contract.Requires(key != null && (key.AlgorithmGroup == CngAlgorithmGroup.ECDsa || key.AlgorithmGroup == CngAlgorithmGroup.ECDiffieHellman));
		StringBuilder stringBuilder = new StringBuilder();
		XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
		xmlWriterSettings.Indent = true;
		xmlWriterSettings.IndentChars = "  ";
		xmlWriterSettings.OmitXmlDeclaration = true;
		using (XmlWriter xmlWriter = XmlWriter.Create(stringBuilder, xmlWriterSettings))
		{
			string localName = ((key.AlgorithmGroup == CngAlgorithmGroup.ECDsa) ? "ECDSAKeyValue" : "ECDHKeyValue");
			xmlWriter.WriteStartElement(localName, "http://www.w3.org/2001/04/xmldsig-more#");
			WriteDomainParameters(xmlWriter, key);
			WritePublicKeyValue(xmlWriter, key);
			xmlWriter.WriteEndElement();
		}
		return stringBuilder.ToString();
	}
}
