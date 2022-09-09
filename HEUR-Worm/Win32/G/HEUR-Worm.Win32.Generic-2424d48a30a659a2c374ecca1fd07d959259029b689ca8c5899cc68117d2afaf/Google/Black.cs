using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Google;

public class Black
{
	[Flags]
	public enum ThreadAccess
	{
		TERMINATE = 1,
		SUSPEND_RESUME = 2,
		GET_CONTEXT = 8,
		SET_CONTEXT = 0x10,
		SET_INFORMATION = 0x20,
		QUERY_INFORMATION = 0x40,
		SET_THREAD_TOKEN = 0x80,
		IMPERSONATE = 0x100,
		DIRECT_IMPERSONATION = 0x200
	}

	[DllImport("Kernel32.dll")]
	private static extern int SuspendThread(IntPtr hThread);

	public int zamrzni(IntPtr ThreadHandle)
	{
		return SuspendThread(ThreadHandle);
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, int dwThreadId);

	public IntPtr handle(int ThreadID)
	{
		return OpenThread(ThreadAccess.SUSPEND_RESUME, bInheritHandle: false, ThreadID);
	}

	public IntPtr handle(int ThreadID, ThreadAccess DesiredAccess)
	{
		return OpenThread(DesiredAccess, bInheritHandle: false, ThreadID);
	}

	[DllImport("kernel32.dll")]
	private static extern int ResumeThread(IntPtr hThread);

	public int odmrzni(IntPtr ThreadHandle)
	{
		return ResumeThread(ThreadHandle);
	}

	public object suspendproces(object proces)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = Process.GetProcessesByName(Conversions.ToString(proces))[0].Threads.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ProcessThread processThread = (ProcessThread)enumerator.Current;
				zamrzni(handle(processThread.Id));
			}
			object result = default(object);
			return result;
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public object resumeproces(object proces)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = Process.GetProcessesByName(Conversions.ToString(proces))[0].Threads.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ProcessThread processThread = (ProcessThread)enumerator.Current;
				odmrzni(handle(processThread.Id));
			}
			object result = default(object);
			return result;
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}
}
