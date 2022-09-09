using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace HTTPAgent;

public class Agent
{
	public CookieContainer cookieJar = new CookieContainer();

	private static string[] accepts = new string[4] { ",text/html;q=0.9,text/plain;q=0.8,image/png,*/*;q=0.5", ",text/html,text/plain,image/png,*/*", ",text/html;q=0.8,text/plain;q=0.6,image/png,image/jpg,image/gif,*/*;q=0.4", ",text/html,text/plain,image/*,*/*" };

	private static string[] userAgentsIE = new string[6] { "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; InfoPath.2; FDM; OfficeLiveConnector.1.4; OfficeLivePatch.1.3; .NET CLR 1.1.4322)", "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; Zune 3.0)", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0; WOW64; SLCC1; .NET CLR 2.0.50727; .NET CLR 3.0.04506; Media Center PC 5.0)", "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET CLR 4.0.20402; MS-RTC LM 8)", "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; InfoPath.2; OfficeLiveConnector.1.3; OfficeLivePatch.0.0; MS-RTC LM 8; Zune 4.0)", "Mozilla/5.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0; SLCC1; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; .NET CLR 1.1.4322)" };

	private static string[] userAgentsFF = new string[6] { "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 ( .NET CLR 3.0.4506.2152; .NET4.0C)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.8) Gecko/20100722 BTRS86393 Firefox/3.6.8 ( .NET CLR 3.5.30729; .NET4.0C)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 ( .NET CLR 3.5.30729; .NET4.0C)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4 ( .NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 (.NET CLR 3.5.30729)" };

	private string _lastResponseText;

	private HttpWebResponse _lastResponse;

	private string _accept;

	private string _userAgent;

	private string _referer;

	private bool _handleReferer;

	private string _acceptLanguage;

	private string _acceptEncoding;

	private string _acceptCharset;

	public string LastResponseText => _lastResponseText;

	public HttpWebResponse LastResponse => _lastResponse;

	public string Accept
	{
		get
		{
			return _accept;
		}
		set
		{
			_accept = value;
		}
	}

	public string UserAgent
	{
		get
		{
			return _userAgent;
		}
		set
		{
			_userAgent = value;
		}
	}

	public string Referer
	{
		get
		{
			return _referer;
		}
		set
		{
			_referer = value;
		}
	}

	public bool HandleReferer
	{
		get
		{
			return _handleReferer;
		}
		set
		{
			_handleReferer = value;
		}
	}

	public string AcceptLanguage
	{
		get
		{
			return _acceptLanguage;
		}
		set
		{
			_acceptLanguage = value;
		}
	}

	public string AcceptEncoding
	{
		get
		{
			return _acceptEncoding;
		}
		set
		{
			_acceptEncoding = value;
		}
	}

	public string AcceptCharset
	{
		get
		{
			return _acceptCharset;
		}
		set
		{
			_acceptCharset = value;
		}
	}

	public void EmulateBrowser()
	{
		Random random = new Random();
		string text = "text/xml,application/xml,application/xhtml+xml";
		text = (Accept = text + accepts[random.Next(accepts.Length)]);
		AcceptLanguage = "en";
		int num = random.Next(100);
		string text4 = (UserAgent = ((num >= 80) ? userAgentsIE[random.Next(userAgentsIE.Length)] : userAgentsFF[random.Next(userAgentsFF.Length)]));
		HandleReferer = true;
	}

	public string postURL(string URL, NameValueCollection formValues)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
		SetupRequest(httpWebRequest, "POST");
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
		if (formValues != null)
		{
			string[] allKeys = formValues.AllKeys;
			foreach (string text in allKeys)
			{
				streamWriter.Write("&" + text + "=");
				streamWriter.Write(HttpUtility.UrlEncode(formValues[text]));
			}
		}
		streamWriter.Close();
		HandleResponse(httpWebRequest);
		if (HandleReferer)
		{
			Referer = _lastResponse.ResponseUri.ToString();
		}
		return _lastResponseText;
	}

	public string GetURL(string URL)
	{
		HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
		SetupRequest(request, "GET");
		HandleResponse(request);
		if (HandleReferer)
		{
			Referer = _lastResponse.ResponseUri.ToString();
		}
		return _lastResponseText;
	}

	public string GetURL(string URL, NameValueCollection formValues)
	{
		string text = "";
		if (formValues != null)
		{
			string[] allKeys = formValues.AllKeys;
			foreach (string text2 in allKeys)
			{
				string text3 = text;
				text = text3 + "&" + text2 + "=" + HttpUtility.UrlEncode(formValues[text2]);
			}
		}
		text = text.Substring(1);
		HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL + "?" + text);
		SetupRequest(request, "GET");
		HandleResponse(request);
		if (HandleReferer)
		{
			Referer = _lastResponse.ResponseUri.ToString();
		}
		return _lastResponseText;
	}

	public void getURL2File(string url, string dateiname)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		SetupRequest(httpWebRequest, "GET");
		_lastResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = _lastResponse.GetResponseStream();
		if (dateiname.IndexOf("\\") != -1)
		{
			string path = dateiname.Substring(0, dateiname.LastIndexOf("\\"));
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
		}
		FileStream fileStream = new FileStream(dateiname, FileMode.Create);
		byte[] array = new byte[1024];
		while (true)
		{
			int num = responseStream.Read(array, 0, array.Length);
			if (num == 0)
			{
				break;
			}
			fileStream.Write(array, 0, num);
		}
		responseStream.Close();
		_lastResponse.Close();
		fileStream.Close();
	}

	private void HandleResponse(HttpWebRequest request)
	{
		_lastResponse = (HttpWebResponse)request.GetResponse();
		Stream responseStream = _lastResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
		_lastResponseText = streamReader.ReadToEnd();
		streamReader.Close();
		_lastResponse.Close();
	}

	private void SetupRequest(HttpWebRequest request, string method)
	{
		request.Method = method;
		request.CookieContainer = cookieJar;
		request.Accept = _accept;
		request.UserAgent = _userAgent;
		request.Referer = _referer;
		if (_acceptCharset != null)
		{
			request.Headers.Add("Accept-Charset", _acceptCharset);
		}
		if (_acceptEncoding != null)
		{
			request.Headers.Add("Accept-Encoding", _acceptEncoding);
		}
		if (_acceptLanguage != null)
		{
			request.Headers.Add("Accept-Language", _acceptLanguage);
		}
	}

	public static string UrlEncode(string str)
	{
		return HttpUtility.UrlEncode(str);
	}

	public static string UrlDecode(string str)
	{
		return HttpUtility.UrlDecode(str);
	}

	public static string HtmlEncode(string str)
	{
		return HttpUtility.HtmlEncode(str);
	}

	public static string HtmlDecode(string str)
	{
		return HttpUtility.HtmlDecode(str);
	}
}
