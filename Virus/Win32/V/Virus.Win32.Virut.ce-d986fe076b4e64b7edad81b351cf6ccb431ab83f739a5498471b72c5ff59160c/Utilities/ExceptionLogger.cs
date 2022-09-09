using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Utilities;

public class ExceptionLogger
{
	private delegate void LogExceptionDelegate(Exception e);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private class MEMORYSTATUSEX
	{
		public uint dwLength;

		public uint dwMemoryLoad;

		public ulong ullTotalPhys;

		public ulong ullAvailPhys;

		public ulong ullTotalPageFile;

		public ulong ullAvailPageFile;

		public ulong ullTotalVirtual;

		public ulong ullAvailVirtual;

		public ulong ullAvailExtendedVirtual;

		public MEMORYSTATUSEX()
		{
			dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
		}
	}

	private List<LoggerImplementation> loggers;

	public ExceptionLogger()
	{
		Application.add_ThreadException((ThreadExceptionEventHandler)OnThreadException);
		AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
		loggers = new List<LoggerImplementation>();
	}

	public void AddLogger(LoggerImplementation logger)
	{
		loggers.Add(logger);
	}

	private void HandleException(Exception e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("An unexpected error occurred - " + e.Message + ". Do you wish to log the error?", "Error", (MessageBoxButtons)4) != 7)
		{
			LogExceptionDelegate logExceptionDelegate = LogException;
			logExceptionDelegate.BeginInvoke(e, LogCallBack, null);
		}
	}

	private void OnThreadException(object sender, ThreadExceptionEventArgs e)
	{
		HandleException(e.Exception);
	}

	private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
		HandleException((Exception)e.ExceptionObject);
	}

	private void LogCallBack(IAsyncResult result)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		AsyncResult val = (AsyncResult)result;
		LogExceptionDelegate logExceptionDelegate = (LogExceptionDelegate)val.get_AsyncDelegate();
		if (!val.get_EndInvokeCalled())
		{
			logExceptionDelegate.EndInvoke(result);
		}
	}

	private string GetExceptionTypeStack(Exception e)
	{
		if (e.InnerException != null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(GetExceptionTypeStack(e.InnerException));
			return stringBuilder.ToString();
		}
		return "   " + e.GetType().ToString();
	}

	private string GetExceptionMessageStack(Exception e)
	{
		if (e.InnerException != null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(GetExceptionMessageStack(e.InnerException));
			return stringBuilder.ToString();
		}
		return "   " + e.Message;
	}

	private string GetExceptionCallStack(Exception e)
	{
		if (e.InnerException != null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(GetExceptionCallStack(e.InnerException));
			stringBuilder.AppendLine("--- Next Call Stack:");
			return stringBuilder.ToString();
		}
		return e.StackTrace;
	}

	private TimeSpan GetSystemUpTime()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		PerformanceCounter val = new PerformanceCounter("System", "System Up Time");
		val.NextValue();
		return TimeSpan.FromSeconds(val.NextValue());
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GlobalMemoryStatusEx([In][Out] MEMORYSTATUSEX lpBuffer);

	public void LogException(Exception exception)
	{
		_ = DateTime.Now;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Application:       " + Application.get_ProductName());
		stringBuilder.AppendLine("Version:           " + Application.get_ProductVersion());
		stringBuilder.AppendLine("Date:              " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
		stringBuilder.AppendLine("Computer name:     " + SystemInformation.get_ComputerName());
		stringBuilder.AppendLine("User name:         " + SystemInformation.get_UserName());
		stringBuilder.AppendLine("OS:                " + Environment.OSVersion.ToString());
		stringBuilder.AppendLine("Culture:           " + CultureInfo.CurrentCulture.Name);
		stringBuilder.AppendLine("Resolution:        " + SystemInformation.get_PrimaryMonitorSize());
		stringBuilder.AppendLine("System up time:    " + GetSystemUpTime());
		stringBuilder.AppendLine("App up time:       " + (DateTime.Now - Process.GetCurrentProcess().StartTime));
		MEMORYSTATUSEX mEMORYSTATUSEX = new MEMORYSTATUSEX();
		if (GlobalMemoryStatusEx(mEMORYSTATUSEX))
		{
			stringBuilder.AppendLine("Total memory:      " + mEMORYSTATUSEX.ullTotalPhys / 1048576uL + "Mb");
			stringBuilder.AppendLine("Available memory:  " + mEMORYSTATUSEX.ullAvailPhys / 1048576uL + "Mb");
		}
		stringBuilder.AppendLine("");
		stringBuilder.AppendLine("Exception classes:   ");
		stringBuilder.Append(GetExceptionTypeStack(exception));
		stringBuilder.AppendLine("");
		stringBuilder.AppendLine("Exception messages: ");
		stringBuilder.Append(GetExceptionMessageStack(exception));
		stringBuilder.AppendLine("");
		stringBuilder.AppendLine("Stack Traces:");
		stringBuilder.Append(GetExceptionCallStack(exception));
		stringBuilder.AppendLine("");
		stringBuilder.AppendLine("Loaded Modules:");
		Process currentProcess = Process.GetCurrentProcess();
		foreach (ProcessModule module in currentProcess.Modules)
		{
			stringBuilder.AppendLine(module.FileName + " " + module.FileVersionInfo.FileVersion);
		}
		for (int i = 0; i < loggers.Count; i++)
		{
			loggers[i].LogError(stringBuilder.ToString());
		}
	}
}
