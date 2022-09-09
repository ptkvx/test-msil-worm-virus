using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ASInstanceRename;

internal static class EntryPoint
{
	[STAThread]
	private static void Main()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process currentProcess = Process.GetCurrentProcess();
			Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
			int num = 0;
			while (true)
			{
				if (num < processesByName.Length)
				{
					Process process = processesByName[num];
					if (currentProcess.Id != process.Id)
					{
						break;
					}
					num++;
					continue;
				}
				Application.Run((Form)(object)new InstanceRenameForm());
				return;
			}
			MessageBox.Show(SR.ProgramIsRunning(SR.RenameInstanceDialogTitle), SR.RenameInstanceDialogTitle, (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, SR.RenameInstanceDialogTitle, (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}
}
