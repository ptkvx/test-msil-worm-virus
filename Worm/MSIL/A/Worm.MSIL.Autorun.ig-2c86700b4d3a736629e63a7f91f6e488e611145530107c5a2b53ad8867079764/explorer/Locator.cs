using System.IO;
using System.Net;
using System.Xml.Linq;

namespace explorer;

public class Locator
{
	private const string ApiUrl = "http://ipinfodb.com/ip_query.php";

	public static string getIP()
	{
		string requestUriString = "http://ipinfodb.com/ip_query.php";
		HttpWebRequest httpWebRequest = WebRequest.Create(requestUriString) as HttpWebRequest;
		string s = string.Empty;
		try
		{
			HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
			{
				s = streamReader.ReadToEnd();
			}
			StringReader stringReader = new StringReader(s);
			XElement val = XElement.Load((TextReader)stringReader);
			string strA = (string)((XContainer)val).Element(XName.op_Implicit("Status"));
			if (string.Compare(strA, "OK", ignoreCase: true) != 0)
			{
				return null;
			}
			return (string)((XContainer)val).Element(XName.op_Implicit("Ip"));
		}
		catch
		{
			return "UNKW";
		}
	}

	public static string getLoc()
	{
		string requestUriString = "http://ipinfodb.com/ip_query.php";
		HttpWebRequest httpWebRequest = WebRequest.Create(requestUriString) as HttpWebRequest;
		string s = string.Empty;
		try
		{
			HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
			{
				s = streamReader.ReadToEnd();
			}
			StringReader stringReader = new StringReader(s);
			XElement val = XElement.Load((TextReader)stringReader);
			string strA = (string)((XContainer)val).Element(XName.op_Implicit("Status"));
			if (string.Compare(strA, "OK", ignoreCase: true) != 0)
			{
				return null;
			}
			return (string)((XContainer)val).Element(XName.op_Implicit("CountryCode"));
		}
		catch
		{
			return "UNKW";
		}
	}
}
