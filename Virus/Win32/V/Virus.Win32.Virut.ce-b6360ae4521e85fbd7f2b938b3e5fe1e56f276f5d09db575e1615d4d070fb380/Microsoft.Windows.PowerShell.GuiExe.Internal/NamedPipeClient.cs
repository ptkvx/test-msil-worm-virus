using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Microsoft.Windows.PowerShell.GuiExe.Internal;

internal static class NamedPipeClient
{
	private const int ServerBusyTimeout = 3000;

	private static NamedPipeSafeHandle pipeHandle;

	private static AutoResetEvent testClientPauseEvent;

	private static AutoResetEvent testPauseEvent;

	internal static NamedPipeSafeHandle PipeHandle => pipeHandle;

	internal static AutoResetEvent TestClientPauseEvent
	{
		get
		{
			return testClientPauseEvent;
		}
		set
		{
			testClientPauseEvent = value;
		}
	}

	internal static AutoResetEvent TestPauseEvent
	{
		get
		{
			return testPauseEvent;
		}
		set
		{
			testPauseEvent = value;
		}
	}

	internal static bool SendString(string str)
	{
		string pipeName;
		int lastWin32Error;
		do
		{
			pipeName = GetPipeName();
			if (pipeName != null)
			{
				pipeHandle = NativeMethods.CreateFile(pipeName, 1073741824u, 0u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
				lastWin32Error = Marshal.GetLastWin32Error();
				TestPause();
				if (pipeHandle.IsInvalid)
				{
					if (lastWin32Error != 231L)
					{
						NamedPipeServer.Tracer.TraceError("Client: Invalid Handle and error is not ERROR_PIPE_BUSY, it is {0}.", new object[1] { lastWin32Error });
						return false;
					}
					continue;
				}
				NamedPipeServer.Tracer.WriteLine("Client: Successfully opened the pipe without waiting.", new object[0]);
				byte[] bytes = Encoding.Unicode.GetBytes(str);
				uint lpNumberOfBytesWritten;
				bool flag = NativeMethods.WriteFile(pipeHandle, bytes, (uint)bytes.Length, out lpNumberOfBytesWritten, IntPtr.Zero) && lpNumberOfBytesWritten == bytes.Length;
				lastWin32Error = Marshal.GetLastWin32Error();
				if (flag)
				{
					NamedPipeServer.Tracer.WriteLine("Client: Successfully sent message", new object[0]);
				}
				else
				{
					NamedPipeServer.Tracer.TraceError("Client: Could not send message. Error: {0}", new object[1] { lastWin32Error });
				}
				TestPause();
				pipeHandle.Close();
				return flag;
			}
			NamedPipeServer.Tracer.TraceError("Client: could not retrieve a pipe name", new object[0]);
			return false;
		}
		while (NativeMethods.WaitNamedPipe(pipeName, 3000u));
		lastWin32Error = Marshal.GetLastWin32Error();
		NamedPipeServer.Tracer.TraceError("Client: Timed out while waiting for the server. Error: {0}", new object[1] { lastWin32Error });
		return false;
	}

	private static void TestPause()
	{
		if (testClientPauseEvent != null && testPauseEvent != null)
		{
			testPauseEvent.Set();
			testClientPauseEvent.WaitOne();
		}
	}

	private static string GetPipeName()
	{
		if (NamedPipeServer.LogonSid == null)
		{
			return null;
		}
		DirectoryInfo applicationDataPath = NamedPipeServer.GetApplicationDataPath(NamedPipeServer.GetLogonSidPath());
		if (applicationDataPath == null)
		{
			return null;
		}
		FileInfo firstFileInfoStartingWith = NamedPipeServer.GetFirstFileInfoStartingWith(applicationDataPath, NamedPipeServer.GetPipeNameStart());
		if (firstFileInfoStartingWith != null)
		{
			return "\\\\.\\pipe\\" + firstFileInfoStartingWith.Name;
		}
		return null;
	}
}
