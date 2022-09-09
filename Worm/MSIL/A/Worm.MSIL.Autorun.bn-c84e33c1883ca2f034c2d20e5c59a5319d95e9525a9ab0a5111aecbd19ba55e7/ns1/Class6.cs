using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace ns1;

[StandardModule]
internal sealed class Class6
{
	private static object object_0;

	private static string string_0;

	private static string string_1 = "SELECT * FROM Win32_VideoController";

	private static RegistryKey registryKey_0 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: false);

	private static object object_1 = RuntimeHelpers.GetObjectValue(registryKey_0.GetValue("ProductID"));

	private static string string_2 = "76487-337-8429955-22614";

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void Sleep(long dwMilliseconds);

	[DllImport("Kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpmodulename);

	public static bool smethod_0()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
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
					num2 = 2;
					flag = Process.GetProcessesByName("SbieSvc").Length >= 1;
					goto end_IL_0000;
				case 37:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_005b;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 37;
				continue;
			}
			break;
			IL_005b:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool smethod_1()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
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
					num2 = 2;
					flag = (Operators.ConditionalCompareObjectEqual(object_1, (object)string_2, false) ? true : false);
					goto end_IL_0000;
				case 40:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_005e;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 40;
				continue;
			}
			break;
			IL_005e:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static void smethod_2()
	{
		int try0000_dispatch = -1;
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
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					object @object = Interaction.GetObject("winmgmts:", (string)null);
					object[] array = new object[1] { string_1 };
					bool[] array2 = new bool[1] { true };
					object obj = NewLateBinding.LateGet(@object, (Type)null, "execquery", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						string_1 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					string text = Conversions.ToString(obj);
					string text2 = text;
					int i = 0;
					for (int length = text2.Length; i < length; i = checked(i + 1))
					{
						string_0 = text2[i].ToString();
					}
					goto end_IL_0000;
				}
				case 170:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_00e4;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 170;
				continue;
			}
			break;
			IL_00e4:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static bool smethod_3()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					smethod_2();
					string text = string_0;
					flag = ((Operators.CompareString(text, "VM Additions S3 Trio32/64", false) == 0) ? true : false);
					goto end_IL_0000;
				}
				case 48:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_0066;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 48;
				continue;
			}
			break;
			IL_0066:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool smethod_4()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					smethod_2();
					string text = string_0;
					flag = ((Operators.CompareString(text, "VNware SVGA II", false) == 0) ? true : false);
					goto end_IL_0000;
				}
				case 48:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_0066;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 48;
				continue;
			}
			break;
			IL_0066:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool smethod_5()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					smethod_2();
					string text = string_0;
					flag = ((Operators.CompareString(text, "VirtualBox Graphics Adapter", false) == 0) ? true : false);
					goto end_IL_0000;
				}
				case 48:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_0066;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 48;
				continue;
			}
			break;
			IL_0066:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void smethod_6()
	{
		string lpmodulename = "SBieDLL.dll";
		bool flag = default(bool);
		if ((ulong)GetModuleHandleA(ref lpmodulename) > 0uL)
		{
			flag = true;
		}
		if (flag)
		{
			ProjectData.EndApp();
		}
	}

	public static bool smethod_7()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					string startupPath = Application.get_StartupPath();
					string text = startupPath + "\\sample.exe";
					flag = ((Operators.CompareString(Application.get_ExecutablePath(), text, false) == 0) ? true : false);
					goto end_IL_0000;
				}
				case 55:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_006f;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 55;
				continue;
			}
			break;
			IL_006f:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
