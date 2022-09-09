using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;

namespace HP.CUE.Gallery.StubApp;

public class Application
{
	internal const string PHOTOCENTER_CLASSNAME = "HPQTHB08";

	internal static string programToExecute = null;

	internal static string commandLine = null;

	internal static string fileOrDirectoryToBrowse = null;

	[STAThread]
	private static void Main(string[] args)
	{
		try
		{
			if (args.Length > 0)
			{
				switch (args[0].ToLower(CultureInfo.InvariantCulture))
				{
				case "/memdisc":
				case "-memdisc":
				{
					int num3 = args[1].IndexOf(':');
					if (num3 != -1)
					{
						string text7 = args[1].Substring(0, num3);
						commandLine = "-activate hpqmyimg -param \"-dir " + text7 + ":\\pictures\"";
					}
					break;
				}
				case "/open":
				case "-open":
				{
					if (args.Length <= 1)
					{
						break;
					}
					int num = args[1].LastIndexOf('.');
					if (num == -1)
					{
						break;
					}
					string text5 = args[1].Substring(num + 1);
					switch (text5.ToLower(CultureInfo.InvariantCulture))
					{
					case "jpg":
					case "jpeg":
					case "tif":
					case "tiff":
					case "bmp":
					case "fpx":
					case "dcx":
					case "pcx":
					case "gif":
					case "png":
					case "avi":
					case "mov":
					case "mpg":
					case "mpeg":
						commandLine = "-activate hpqieshl -AddToTray \"" + args[1] + "\"";
						break;
					case "hpphotogallery":
					{
						int num2 = args[1].IndexOf(':');
						if (num2 != -1)
						{
							string text6 = args[1].Substring(0, num2);
							commandLine = "-activate hpqmyimg -param \"-dir " + text6 + ":\\pictures\"";
						}
						break;
					}
					}
					break;
				}
				case "/mpv":
				case "-mpv":
					if (args.Length > 1)
					{
						commandLine = "-activate hpqmyimg -param \"-mpv '" + args[1] + "'\"";
					}
					break;
				case "/album":
				case "-album":
					if (args.Length > 1)
					{
						commandLine = "-activate hpqmyimg -param \"-album '" + args[1] + "'\"";
					}
					break;
				case "/camcard":
				case "-camcard":
				{
					MainWindow mainWindow = new MainWindow();
					Application.Run((Form)(object)mainWindow);
					break;
				}
				case "/scan":
				case "-scan":
				{
					MainWindow mainWindow = new MainWindow();
					Application.Run((Form)(object)mainWindow);
					break;
				}
				case "/unload":
				case "-unload":
				{
					if (args.Length <= 1)
					{
						break;
					}
					commandLine = commandLine + "-activate hpqmyimg -param \"-unload " + args[1] + "\"";
					if (args.Length <= 2)
					{
						break;
					}
					for (int j = 2; j < args.Length; j++)
					{
						if (args[j].ToLower().IndexOf("orderprints") <= 0 || args.Length <= 3)
						{
							commandLine = commandLine + "/" + args[j];
							continue;
						}
						string text4 = commandLine;
						commandLine = text4 + "/" + args[j] + "\"/" + args[j + 1] + "\"";
						break;
					}
					break;
				}
				case "mpvfile.pvm":
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\hpqPhUnl.exe", writable: true);
					string text2 = (string)registryKey.GetValue("");
					string text3 = text2.Substring(0, text2.LastIndexOf("\\"));
					object obj = commandLine;
					commandLine = string.Concat(obj, "-activate hpqmyimg -param \"-unload ", text3, Path.DirectorySeparatorChar, args[0], "\"");
					break;
				}
				case "/recentlyused":
				case "-recentlyused":
					if (args.Length > 1)
					{
						commandLine = commandLine + "-activate hpqmyimg -param \"-recentlyused " + args[1] + "\"";
					}
					break;
				default:
				{
					for (int i = 0; i < args.Length; i++)
					{
						string text = args[i];
						if (text.StartsWith("/"))
						{
							text = "-" + text.Substring(1);
						}
						if (text.IndexOf(" ") != -1)
						{
							commandLine = commandLine + "\"" + text + "\"";
						}
						else
						{
							commandLine += text;
						}
						commandLine += " ";
					}
					break;
				}
				}
			}
			RegistryKey registryKey2 = null;
			try
			{
				RegistryKey localMachine = Registry.LocalMachine;
				RegistryKey registryKey3 = localMachine.OpenSubKey("Software");
				registryKey2 = registryKey3.OpenSubKey("Classes\\CLSID\\{B2847E28-5D7D-4DEB-8B67-05D28BCF79F5}\\InProcServer32");
				if (registryKey2 != null)
				{
					try
					{
						string text8 = (string)registryKey2.GetValue("");
						text8 = text8.ToLower(CultureInfo.InvariantCulture);
						if (text8.IndexOf("hpdtlk02.dll") < 0)
						{
							registryKey2 = null;
						}
					}
					catch
					{
						registryKey2 = null;
					}
				}
			}
			catch
			{
			}
			string location = Assembly.GetExecutingAssembly().Location;
			if (registryKey2 != null)
			{
				programToExecute = "hpqimzone.exe";
				if (commandLine != null && !(commandLine == string.Empty))
				{
					commandLine = commandLine.Insert(0, "-cpc ");
				}
				else
				{
					commandLine = "-cpc";
				}
				ProcessStartInfo processStartInfo = new ProcessStartInfo(programToExecute, commandLine);
				processStartInfo.WorkingDirectory = Path.GetDirectoryName(location);
				Process.Start(processStartInfo);
				return;
			}
			try
			{
				programToExecute = "hpqimzone.exe";
				ProcessStartInfo processStartInfo2 = new ProcessStartInfo(programToExecute, commandLine);
				processStartInfo2.WorkingDirectory = Path.GetDirectoryName(location);
				Process.Start(processStartInfo2);
			}
			catch (Win32Exception)
			{
				ErrorMsg();
			}
		}
		catch
		{
			ErrorMsg();
		}
	}

	private static void ErrorMsg()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		ErrorDialog errorDialog = new ErrorDialog();
		((Form)errorDialog).ShowDialog();
	}
}
