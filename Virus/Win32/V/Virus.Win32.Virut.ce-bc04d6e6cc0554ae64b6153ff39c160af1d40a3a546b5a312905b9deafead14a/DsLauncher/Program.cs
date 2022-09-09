using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DsLauncher;

internal static class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if (IsUserGuest())
		{
			MessageBox.Show("DataSafe cannot be launched in guest account");
			Process.GetCurrentProcess().Kill();
		}
		if (IsAuditMode())
		{
			return;
		}
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		ProcessStartInfo processStartInfo = new ProcessStartInfo("DataSafe.exe");
		Process process;
		if (args.Length == 1 && args[0] == "IAMADMIN")
		{
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Dell\\datasafe");
				object value = registryKey.GetValue("UserPath");
				if (value != null)
				{
					processStartInfo.Arguments = processStartInfo.Arguments + "UserPath=\"" + value.ToString() + "\"";
					process = new Process();
					process.StartInfo = processStartInfo;
					Application.Exit();
				}
				registryKey.Close();
			}
			catch
			{
				return;
			}
		}
		foreach (string text in args)
		{
			processStartInfo.Arguments = processStartInfo.Arguments + text + " ";
		}
		string text2 = "";
		text2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		text2 = text2.Substring(0, text2.LastIndexOf("\\"));
		processStartInfo.Arguments = processStartInfo.Arguments + "UserPath=\"" + text2 + "\"";
		process = new Process();
		process.StartInfo = processStartInfo;
		try
		{
			process.Start();
		}
		catch (Exception)
		{
		}
		finally
		{
			Application.Exit();
		}
	}

	private static bool IsUserGuest()
	{
		try
		{
			_ = WindowsIdentity.GetCurrent().Token;
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			if (current.IsGuest)
			{
				return true;
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool IsAuditMode()
	{
		string text = "0";
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("system\\Setup\\Status\\");
			text = registryKey.GetValue("auditboot")!.ToString();
			registryKey.Close();
		}
		catch
		{
			return false;
		}
		return !(text == "0");
	}
}
