using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Reflection;
using System.Xml;
using Logging;
using Microsoft.Win32;

namespace WinDefrag;

internal static class Program
{
	private const string SUCCESS = "success";

	private const string FAILURE = "failure";

	[STAThread]
	private static void Main(string[] args)
	{
		if (args.Length > 0 && args[0].ToLower().Equals("/cancel"))
		{
			cancelProcess("defrag.exe");
			cancelProcess("dfrgntfs.exe");
			cancelProcess("WinDefrag.exe");
		}
		else
		{
			int exitCode = defrag();
			writeLog(exitCode);
			Environment.Exit(exitCode);
		}
	}

	private static int defrag()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		string value = Environment.ExpandEnvironmentVariables("%SystemDrive%");
		try
		{
			object[] array = new object[2];
			ManagementObjectCollection val = wmiCall("Select * from Win32_Volume where DriveType = 3");
			ManagementObjectEnumerator enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					string text = "";
					if (((ManagementBaseObject)val2).get_Item("DriveLetter") != null)
					{
						text = ((ManagementBaseObject)val2).get_Item("DriveLetter").ToString();
					}
					if (text.Equals(value))
					{
						val2.InvokeMethod("DefragAnalysis", array);
						ManagementBaseObject val3 = (ManagementBaseObject)array[1];
						int num = Convert.ToInt32(val3.GetPropertyValue("FilePercentFragmentation"));
						if (num >= 5)
						{
							return (int)val2.InvokeMethod("Defrag", array);
						}
						return 0;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return -1;
		}
		catch (Exception)
		{
			return -1;
		}
	}

	private static ManagementObjectCollection wmiCall(string query)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		try
		{
			ManagementScope val = new ManagementScope("\\\\localhost\\root\\cimv2");
			ObjectQuery val2 = new ObjectQuery(query);
			ManagementObjectSearcher val3 = new ManagementObjectSearcher(val, val2);
			return val3.Get();
		}
		catch
		{
			return null;
		}
	}

	private static void cancelProcess(string appName)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "taskkill.exe";
		processStartInfo.Arguments = "/f /im " + appName;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
		process.WaitForExit();
	}

	private static void writeLog(int exitCode)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		LogWriter val = new LogWriter();
		switch (exitCode)
		{
		case 0:
			val.setResult(getTranslatedMessage("success"));
			break;
		case -1:
			val.setResult(getTranslatedMessage("failure"));
			break;
		}
		val.setErrorCode(exitCode.ToString());
		val.write();
	}

	private static string getTranslatedMessage(string type)
	{
		string language = getLanguage();
		string text = "";
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("WinDefrag.logMessages.xml");
			XmlDocument xmlDocument = new XmlDocument();
			StreamReader streamReader = new StreamReader(manifestResourceStream);
			xmlDocument.LoadXml(streamReader.ReadToEnd());
			streamReader.Close();
			XmlNode xmlNode = xmlDocument.SelectSingleNode("messages/" + language + "/" + type);
			XmlNode xmlNode2 = xmlDocument.SelectSingleNode("messages/en-US/" + type);
			return (xmlNode != null) ? xmlNode.InnerText : xmlNode2.InnerText;
		}
		catch
		{
			return "Error retrieving results.";
		}
	}

	private static string getLanguage()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\" + set64BitPath() + "Hewlett-Packard\\HPActiveSupport\\HPHC");
			object value = registryKey.GetValue("Lang");
			return (string)value;
		}
		catch
		{
			return "en-US";
		}
	}

	private static string set64BitPath()
	{
		try
		{
			if (Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Hewlett-Packard\\HPActiveSupport") != null)
			{
				return "Wow6432Node\\";
			}
			return "";
		}
		catch
		{
			return "";
		}
	}
}
