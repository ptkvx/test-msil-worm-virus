using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;

namespace Microsoft.MediaCenter.TV.Tuners;

internal static class Log
{
	private enum Level
	{
		Verbose = 4,
		Warning = 2,
		Error = 1,
		Off = 0,
		Info = 3
	}

	private static string fileBaseName;

	private static string logSubPath;

	private static TextWriter traceWriter;

	private static Level debugSwitchLevel;

	unsafe static Log()
	{
		string text = null;
		ValueType valueType = null;
		string text2 = null;
		FileStream fileStream = null;
		int num = (int)stackalloc byte[_003CModule_003E.__CxxQueryExceptionSize()];
		fileBaseName = "TunerInterop";
		logSubPath = "\\Microsoft\\eHome\\Logs\\";
		try
		{
			debugSwitchLevel = Level.Info;
			text = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + logSubPath;
			valueType = DateTime.Now;
			text2 = text + string.Format(args: new object[3]
			{
				((DateTime)valueType).ToString("yyyy'-'MM'-'dd'-'HH'-'mm'-'ss", CultureInfo.InvariantCulture),
				Path.GetFileNameWithoutExtension(Process.GetCurrentProcess().MainModule!.FileName),
				Process.GetCurrentProcess().Id
			}, provider: CultureInfo.InvariantCulture, format: fileBaseName + "Managed_{0}_{1}_{2}.log");
			UpdateTraceLevel();
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			fileStream = File.Open(text2, FileMode.Append, FileAccess.Write, FileShare.Read);
			traceWriter = TextWriter.Synchronized(new StreamWriter(fileStream));
		}
		catch when (((Func<bool>)delegate
		{
			// Could not convert BlockContainer to single expression
			Marshal.GetExceptionCode();
			return (byte)_003CModule_003E.__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
		}).Invoke())
		{
			uint num2 = 0u;
			_003CModule_003E.__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
			try
			{
				try
				{
					return;
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num2 = (uint)_003CModule_003E.__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
					return (byte)num2 != 0;
				}).Invoke())
				{
				}
				if (num2 != 0)
				{
					throw;
				}
			}
			finally
			{
				_003CModule_003E.__CxxUnregisterExceptionObject((void*)num, (int)num2);
			}
		}
	}

	public static void TraceError(string message)
	{
		TraceWorker(Level.Error, message);
	}

	public static void TraceWarning(string message)
	{
		TraceWorker(Level.Warning, message);
	}

	public static void TraceInfo(string message)
	{
		TraceWorker(Level.Info, message);
	}

	public static void TraceVerbose(string message)
	{
		TraceWorker(Level.Verbose, message);
	}

	private unsafe static void TraceWorker(Level level, string message)
	{
		ValueType valueType = null;
		string text = null;
		int num = (int)stackalloc byte[_003CModule_003E.__CxxQueryExceptionSize()];
		if (debugSwitchLevel < level || traceWriter == null)
		{
			return;
		}
		try
		{
			valueType = DateTime.Now;
			text = string.Format(args: new object[3]
			{
				((DateTime)valueType).ToString("o", CultureInfo.InvariantCulture),
				Thread.CurrentThread.ManagedThreadId,
				message
			}, provider: CultureInfo.InvariantCulture, format: "{0}:{1}:{2}");
			traceWriter.WriteLine(text);
			traceWriter.Flush();
		}
		catch (ObjectDisposedException)
		{
			debugSwitchLevel = Level.Off;
		}
		catch when (((Func<bool>)delegate
		{
			// Could not convert BlockContainer to single expression
			Marshal.GetExceptionCode();
			return (byte)_003CModule_003E.__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
		}).Invoke())
		{
			uint num2 = 0u;
			_003CModule_003E.__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
			try
			{
				try
				{
					return;
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num2 = (uint)_003CModule_003E.__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
					return (byte)num2 != 0;
				}).Invoke())
				{
				}
				if (num2 != 0)
				{
					throw;
				}
			}
			finally
			{
				_003CModule_003E.__CxxUnregisterExceptionObject((void*)num, (int)num2);
			}
		}
	}

	private unsafe static void UpdateTraceLevel()
	{
		RegistryKey registryKey = null;
		RegistryKey registryKey2 = null;
		object obj = null;
		int num = (int)stackalloc byte[_003CModule_003E.__CxxQueryExceptionSize()];
		try
		{
			registryKey = Registry.LocalMachine;
			if (registryKey == null)
			{
				return;
			}
			registryKey2 = registryKey.OpenSubKey("SOFTWARE\\debug\\" + fileBaseName);
			if (registryKey2 != null)
			{
				int num2 = 0;
				obj = registryKey2.GetValue("TraceLevel");
				if (obj != null)
				{
					switch ((int)obj)
					{
					default:
						debugSwitchLevel = Level.Verbose;
						break;
					case 4:
						debugSwitchLevel = Level.Verbose;
						break;
					case 3:
						debugSwitchLevel = Level.Info;
						break;
					case 2:
						debugSwitchLevel = Level.Warning;
						break;
					case 1:
						debugSwitchLevel = Level.Error;
						break;
					case 0:
						debugSwitchLevel = Level.Off;
						break;
					}
				}
				registryKey2.Close();
			}
			registryKey.Close();
		}
		catch when (((Func<bool>)delegate
		{
			// Could not convert BlockContainer to single expression
			Marshal.GetExceptionCode();
			return (byte)_003CModule_003E.__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
		}).Invoke())
		{
			uint num3 = 0u;
			_003CModule_003E.__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
			try
			{
				try
				{
					return;
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num3 = (uint)_003CModule_003E.__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
					return (byte)num3 != 0;
				}).Invoke())
				{
				}
				if (num3 != 0)
				{
					throw;
				}
			}
			finally
			{
				_003CModule_003E.__CxxUnregisterExceptionObject((void*)num, (int)num3);
			}
		}
	}
}
