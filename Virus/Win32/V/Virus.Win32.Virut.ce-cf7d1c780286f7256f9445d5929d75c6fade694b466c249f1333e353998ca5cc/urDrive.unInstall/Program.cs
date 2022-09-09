using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace urDrive.unInstall;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		if (!OneInstanceManager.CheckDuplicateInstance("UnInstaller"))
		{
			Application.ExitThread();
			return;
		}
		bool flag = false;
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.ToLower().Trim() == "autoupdate" || process.ProcessName.ToLower().Trim() == "uninstall2" || process.ProcessName.ToLower().Trim() == "unInstaller")
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			Application.Exit();
			return;
		}
		Application.EnableVisualStyles();
		LanguageManager.GetDefaultLanguage();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new frmSysInformation());
	}
}
