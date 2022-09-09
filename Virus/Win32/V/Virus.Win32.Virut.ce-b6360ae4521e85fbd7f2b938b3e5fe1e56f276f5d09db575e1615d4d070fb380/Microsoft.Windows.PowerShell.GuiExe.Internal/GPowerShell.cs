using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.PowerShell;

namespace Microsoft.Windows.PowerShell.GuiExe.Internal;

internal static class GPowerShell
{
	[TraceSource("PowerShellISEInitialization", "tracer for PowerShell ISE Initialization")]
	private static PSTraceSource tracer = PSTraceSource.GetTracer("PowerShellISEInitialization", "tracer for PowerShell ISE Initialization");

	private static Assembly LoadAssembly(string assemblyName)
	{
		Assembly result = null;
		Exception ex = null;
		try
		{
			result = Assembly.Load(assemblyName);
		}
		catch (FileNotFoundException ex2)
		{
			ex = ex2;
		}
		catch (FileLoadException ex3)
		{
			ex = ex3;
		}
		catch (BadImageFormatException ex4)
		{
			ex = ex4;
		}
		if (ex != null)
		{
			tracer.TraceException(ex);
		}
		return result;
	}

	private static string GetFullPath(string filePath)
	{
		if (Path.IsPathRooted(filePath))
		{
			return filePath;
		}
		Exception ex = null;
		try
		{
			filePath = Path.GetFullPath(filePath);
		}
		catch (ArgumentException ex2)
		{
			ex = ex2;
		}
		catch (SecurityException ex3)
		{
			ex = ex3;
		}
		catch (NotSupportedException ex4)
		{
			ex = ex4;
		}
		catch (PathTooLongException ex5)
		{
			ex = ex5;
		}
		if (ex != null)
		{
			tracer.TraceException(ex);
			return null;
		}
		return filePath;
	}

	private static void ShowErrorMessage(string error)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(error, Strings.GraphicalPowerShell, (MessageBoxButtons)0, (MessageBoxIcon)16, (MessageBoxDefaultButton)0, (MessageBoxOptions)(Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft ? 1572864 : 0));
	}

	private static string[] GetFileNames(string commaSeparatedFiles)
	{
		bool flag = false;
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in commaSeparatedFiles)
		{
			switch (c)
			{
			case '"':
				flag = !flag;
				break;
			case ',':
				if (!flag)
				{
					if (AddCurrentFile(stringBuilder, list))
					{
						stringBuilder = new StringBuilder();
						break;
					}
					return null;
				}
				goto default;
			default:
				stringBuilder.Append(c);
				break;
			}
		}
		if (!AddCurrentFile(stringBuilder, list))
		{
			return null;
		}
		return list.ToArray();
	}

	private static bool AddCurrentFile(StringBuilder currentFile, List<string> files)
	{
		string text = currentFile.ToString().Trim();
		if (text.Length != 0)
		{
			string fullPath = GetFullPath(text);
			if (fullPath == null)
			{
				ShowErrorMessage(Strings.Format(Strings.UnableToRetrieveFullPath, text));
				return false;
			}
			files.Add(fullPath);
		}
		return true;
	}

	private static Mutex SafeWaitMutex(Mutex mutex)
	{
		try
		{
			mutex.WaitOne();
			return mutex;
		}
		catch (AbandonedMutexException)
		{
			mutex.ReleaseMutex();
			((IDisposable)mutex).Dispose();
			mutex = new Mutex(initiallyOwned: false, "GPowerShellInitializationMutexName");
			mutex.WaitOne();
			return mutex;
		}
	}

	[STAThread]
	private static int Main(string[] args)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		Cursor.set_Current(Cursors.get_WaitCursor());
		WindowsErrorReporting.RegisterWindowsErrorReporting(false);
		Thread.CurrentThread.CurrentUICulture = NativeCultureResolver.get_UICulture();
		if (args.Length != 0 && args.Length != 1)
		{
			ShowErrorMessage(Strings.Usage);
			return -1;
		}
		string[] array = null;
		if (args.Length == 1 && args[0] != null)
		{
			array = GetFileNames(args[0]);
			if (array == null)
			{
				return -1;
			}
		}
		if (!FrameworkRegistryInstallation.IsFrameworkInstalled(3, 0, 0))
		{
			((Form)new WPFError()).ShowDialog();
			return -1;
		}
		NamedPipeServer namedPipeServer = null;
		Mutex initializationMutex = new Mutex(initiallyOwned: false, "GPowerShellInitializationMutexName");
		bool initializationMutexReleased = false;
		try
		{
			initializationMutex = SafeWaitMutex(initializationMutex);
			bool flag;
			if ((flag = NamedPipeClient.SendString("fe886c82-edda-4016-bcbb-bd5788201338")) && array != null)
			{
				string[] array2 = array;
				int num = 0;
				while (true)
				{
					if (num < array2.Length)
					{
						string str = array2[num];
						if (!NamedPipeClient.SendString(str))
						{
							break;
						}
						num++;
						continue;
					}
					return 0;
				}
				return -1;
			}
			Assembly assembly = LoadAssembly("Microsoft.PowerShell.GPowerShell,Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");
			if ((object)assembly == null)
			{
				ShowErrorMessage(string.Format(CultureInfo.CurrentCulture, Strings.AssemblyCorruptOrMissing, new object[1] { "Microsoft.PowerShell.GPowerShell,Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" }));
				return -1;
			}
			Type type = assembly.GetType("Microsoft.Windows.PowerShell.Gui.Internal.Program");
			MethodInfo method = type.GetMethod("Initialize", BindingFlags.Static | BindingFlags.Public);
			int num2 = 0;
			try
			{
				num2 = (int)method.Invoke(null, new object[0]);
			}
			catch (TargetInvocationException ex)
			{
				throw ex;
			}
			if (num2 < 0)
			{
				return -1;
			}
			MethodInfo method2 = type.GetMethod("ShowMainWindow", BindingFlags.Static | BindingFlags.Public);
			MethodInfo method3 = type.GetMethod("OpenFiles", BindingFlags.Static | BindingFlags.Public);
			namedPipeServer = new NamedPipeServer(method3);
			if (namedPipeServer.CreateNamedPipe(!flag))
			{
				namedPipeServer.StartListening();
			}
			try
			{
				SendOrPostCallback sendOrPostCallback = delegate
				{
					initializationMutexReleased = true;
					initializationMutex.ReleaseMutex();
				};
				method2.Invoke(null, new object[2] { array, sendOrPostCallback });
			}
			catch (TargetInvocationException ex2)
			{
				throw ex2;
			}
		}
		finally
		{
			if (!initializationMutexReleased)
			{
				initializationMutex.ReleaseMutex();
			}
			if (namedPipeServer != null)
			{
				initializationMutex = SafeWaitMutex(initializationMutex);
				namedPipeServer.StopListening();
				initializationMutex.ReleaseMutex();
			}
			((IDisposable)initializationMutex).Dispose();
			WindowsErrorReporting.WaitForPendingReports();
		}
		return Environment.ExitCode;
	}
}
