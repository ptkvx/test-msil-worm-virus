using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Jays_Booter;

[StandardModule]
public sealed class antis
{
	private static string string_0;

	private static object object_0;

	private static string string_1;

	private static string string_2;

	private static RegistryKey registryKey_0;

	private static object object_1;

	private static string string_3;

	static antis()
	{
		Class7.smethod_0();
		string_0 = Conversions.ToString(false);
		string_2 = "SELECT * FROM Win32_VideoController";
		registryKey_0 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: false);
		object_1 = RuntimeHelpers.GetObjectValue(registryKey_0.GetValue("ProductId"));
		string_3 = "76487-337-8429955-22614";
	}

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool SetWindowText(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstring);

	public static object AllAntis()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object obj = antiAnubis2();
			if (Operators.ConditionalCompareObjectEqual(obj, (object)true, false))
			{
				ProjectData.EndApp();
				return true;
			}
			smethod_0();
			return false;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Error checking anti's", (MsgBoxStyle)0, (object)null);
			ProjectData.EndApp();
			object result = true;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static void smethod_0()
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			string mainWindowTitle = process.MainWindowTitle;
			if (mainWindowTitle.Contains("Wireshark"))
			{
				process.Kill();
				string_0 = Conversions.ToString(true);
			}
			else if (mainWindowTitle.Contains("Fiddler"))
			{
				process.Kill();
				string_0 = Conversions.ToString(true);
			}
			else if (mainWindowTitle.Contains("Fiddler2"))
			{
				process.Kill();
				string_0 = Conversions.ToString(true);
			}
			else if (mainWindowTitle.Contains("Reflector"))
			{
				process.Kill();
				string_0 = Conversions.ToString(true);
			}
			else if (mainWindowTitle.Contains("Ollydb"))
			{
				process.Kill();
				string_0 = Conversions.ToString(true);
			}
			else if (Conversions.ToBoolean(string_0))
			{
				IntPtr mainWindowHandle = process.MainWindowHandle;
				string lpstring = "You failz at haxoring my HWID";
				SetWindowText(mainWindowHandle, ref lpstring);
				Clipboard.SetText("Failz at haxoring my HWID");
			}
		}
	}

	public static bool antiAnubis2()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag;
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					flag = (Operators.ConditionalCompareObjectEqual(object_1, (object)string_3, false) ? true : false);
					goto end_IL_0001;
				case 38:
					num = -1;
					switch (num2)
					{
					case 2:
						flag = true;
						goto end_IL_0001;
					}
					break;
				}
				goto IL_005c;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 38;
				continue;
			}
			break;
			IL_005c:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool AntiVirtualBox()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag;
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					smethod_1();
					string text = string_1;
					flag = ((Operators.CompareString(text, "VirtualBox Graphics Adapter", false) == 0) ? true : false);
					goto end_IL_0001;
				}
				case 46:
					num = -1;
					switch (num2)
					{
					case 2:
						flag = true;
						goto end_IL_0001;
					}
					break;
				}
				goto IL_0064;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 46;
				continue;
			}
			break;
			IL_0064:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static void smethod_1()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					object @object = Interaction.GetObject("winmgmts:", (string)null);
					object[] array = new object[1] { string_2 };
					bool[] array2 = new bool[1] { true };
					object obj = NewLateBinding.LateGet(@object, (Type)null, "ExecQuery", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						string_2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					object_0 = RuntimeHelpers.GetObjectValue(obj);
					IEnumerator enumerator = ((IEnumerable)object_0).GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						string_1 = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "Description", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					break;
				}
				case 210:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_010a;
					}
					break;
				}
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 210;
				continue;
			}
			break;
			IL_010a:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
