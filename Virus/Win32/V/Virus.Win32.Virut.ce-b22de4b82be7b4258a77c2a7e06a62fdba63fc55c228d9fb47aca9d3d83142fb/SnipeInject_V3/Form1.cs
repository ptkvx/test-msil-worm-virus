using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SnipeInject_V3;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("OpenFileDialog1")]
	private OpenFileDialog _OpenFileDialog1;

	[AccessedThroughProperty("Dlls")]
	private ListBox _Dlls;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("CheckBox3")]
	private CheckBox _CheckBox3;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	private int TargetProcessHandle;

	private int pfnStartAddr;

	private string pszLibFileRemote;

	private int TargetBufferSize;

	public const int PROCESS_VM_READ = 16;

	public const int TH32CS_SNAPPROCESS = 2;

	public const int MEM_COMMIT = 4096;

	public const int PAGE_READWRITE = 4;

	public const int PROCESS_CREATE_THREAD = 2;

	public const int PROCESS_VM_OPERATION = 8;

	public const int PROCESS_VM_WRITE = 32;

	private string DLLFileName;

	private string ExeName;

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
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

	internal virtual OpenFileDialog OpenFileDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CancelEventHandler cancelEventHandler = OpenFileDialog1_FileOk;
			if (_OpenFileDialog1 != null)
			{
				((FileDialog)_OpenFileDialog1).remove_FileOk(cancelEventHandler);
			}
			_OpenFileDialog1 = value;
			if (_OpenFileDialog1 != null)
			{
				((FileDialog)_OpenFileDialog1).add_FileOk(cancelEventHandler);
			}
		}
	}

	internal virtual ListBox Dlls
	{
		[DebuggerNonUserCode]
		get
		{
			return _Dlls;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Dlls = value;
		}
	}

	internal virtual CheckBox CheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual CheckBox CheckBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CheckBox2_CheckedChanged;
			if (_CheckBox2 != null)
			{
				_CheckBox2.remove_CheckedChanged(eventHandler);
			}
			_CheckBox2 = value;
			if (_CheckBox2 != null)
			{
				_CheckBox2.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual CheckBox CheckBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CheckBox3_CheckedChanged;
			if (_CheckBox3 != null)
			{
				_CheckBox3.remove_CheckedChanged(eventHandler);
			}
			_CheckBox3 = value;
			if (_CheckBox3 != null)
			{
				_CheckBox3.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button3_Click;
			if (_Button3 != null)
			{
				((Control)_Button3).remove_Click(eventHandler);
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				((Control)_Button3).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button4_Click;
			if (_Button4 != null)
			{
				((Control)_Button4).remove_Click(eventHandler);
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				((Control)_Button4).add_Click(eventHandler);
			}
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual GroupBox GroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox2 = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		ExeName = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Expected O, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected O, but got Unknown
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected O, but got Unknown
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_0931: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Label2 = new Label();
		Label4 = new Label();
		TextBox1 = new TextBox();
		Timer1 = new Timer(components);
		OpenFileDialog1 = new OpenFileDialog();
		Dlls = new ListBox();
		CheckBox1 = new CheckBox();
		CheckBox2 = new CheckBox();
		CheckBox3 = new CheckBox();
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		Button4 = new Button();
		GroupBox1 = new GroupBox();
		GroupBox2 = new GroupBox();
		Label6 = new Label();
		Label1 = new Label();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		Label2.set_AutoSize(true);
		Label label = Label2;
		Point location = new Point(22, 187);
		((Control)label).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label2 = Label2;
		Size size = new Size(30, 13);
		((Control)label2).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("DLL:");
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.Teal);
		Label label3 = Label4;
		location = new Point(13, 26);
		((Control)label3).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label4 = Label4;
		size = new Size(40, 13);
		((Control)label4).set_Size(size);
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("Status:");
		TextBox textBox = TextBox1;
		location = new Point(92, 160);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(148, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(4);
		((FileDialog)OpenFileDialog1).set_FileName("OpenFileDialog1");
		OpenFileDialog1.set_Multiselect(true);
		((ListControl)Dlls).set_FormattingEnabled(true);
		ListBox dlls = Dlls;
		location = new Point(92, 187);
		((Control)dlls).set_Location(location);
		((Control)Dlls).set_Name("Dlls");
		ListBox dlls2 = Dlls;
		size = new Size(148, 134);
		((Control)dlls2).set_Size(size);
		((Control)Dlls).set_TabIndex(5);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(17, 19);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(135, 20);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(6);
		((ButtonBase)CheckBox1).set_Text("Close After Injection");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		CheckBox checkBox3 = CheckBox2;
		location = new Point(17, 42);
		((Control)checkBox3).set_Location(location);
		((Control)CheckBox2).set_Name("CheckBox2");
		CheckBox checkBox4 = CheckBox2;
		size = new Size(130, 20);
		((Control)checkBox4).set_Size(size);
		((Control)CheckBox2).set_TabIndex(7);
		((ButtonBase)CheckBox2).set_Text("Automatic Injection");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox3).set_AutoSize(true);
		CheckBox checkBox5 = CheckBox3;
		location = new Point(17, 65);
		((Control)checkBox5).set_Location(location);
		((Control)CheckBox3).set_Name("CheckBox3");
		CheckBox checkBox6 = CheckBox3;
		size = new Size(115, 20);
		((Control)checkBox6).set_Size(size);
		((Control)CheckBox3).set_TabIndex(8);
		((ButtonBase)CheckBox3).set_Text("Manual Injection");
		((ButtonBase)CheckBox3).set_UseVisualStyleBackColor(true);
		Button button = Button1;
		location = new Point(12, 218);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(9);
		((ButtonBase)Button1).set_Text("Browse");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(11, 247);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(10);
		((ButtonBase)Button2).set_Text("Clear");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button button5 = Button3;
		location = new Point(11, 276);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(75, 45);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(11);
		((ButtonBase)Button3).set_Text("Clear Selected");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		Button button7 = Button4;
		location = new Point(128, 327);
		((Control)button7).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button8 = Button4;
		size = new Size(75, 36);
		((Control)button8).set_Size(size);
		((Control)Button4).set_TabIndex(12);
		((ButtonBase)Button4).set_Text("Inject");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((Control)GroupBox1).set_BackColor(Color.Transparent);
		((Control)GroupBox1).get_Controls().Add((Control)(object)CheckBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)CheckBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)CheckBox3);
		((Control)GroupBox1).set_Font(new Font("Arial Narrow", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_ForeColor(Color.DarkOrange);
		GroupBox groupBox = GroupBox1;
		location = new Point(246, 236);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(150, 116);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(13);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Settings");
		((Control)GroupBox2).set_BackColor(Color.Transparent);
		((Control)GroupBox2).set_Font(new Font("Arial Narrow", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox3 = GroupBox2;
		location = new Point(246, 155);
		((Control)groupBox3).set_Location(location);
		((Control)GroupBox2).set_Name("GroupBox2");
		GroupBox groupBox4 = GroupBox2;
		size = new Size(152, 75);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox2).set_TabIndex(14);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Credits: Snipermon For MPGH");
		Label6.set_AutoSize(true);
		Label label5 = Label6;
		location = new Point(22, 163);
		((Control)label5).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label6 = Label6;
		size = new Size(48, 13);
		((Control)label6).set_Size(size);
		((Control)Label6).set_TabIndex(16);
		Label6.set_Text("Process:");
		Label1.set_AutoSize(true);
		Label label7 = Label1;
		location = new Point(68, 26);
		((Control)label7).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label8 = Label1;
		size = new Size(0, 13);
		((Control)label8).set_Size(size);
		((Control)Label1).set_TabIndex(17);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		size = new Size(401, 371);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Dlls);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("SnipeInject V3");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ReadProcessMemory(int hProcess, int lpBaseAddress, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpLibFileName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int VirtualAllocEx(int hProcess, int lpAddress, int dwSize, int flAllocationType, int flProtect);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int WriteProcessMemory(int hProcess, int lpBaseAddress, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetProcAddress(int hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpProcName);

	[DllImport("Kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpModuleName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int CreateRemoteThread(int hProcess, int lpThreadAttributes, int dwStackSize, int lpStartAddress, int lpParameter, int dwCreationFlags, ref int lpThreadId);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CloseHandleA(int hObject);

	private void Inject()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num4 = default(int);
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
					Timer1.Stop();
					Process[] processesByName = Process.GetProcessesByName(TextBox1.get_Text());
					TargetProcessHandle = OpenProcess(42, 0, processesByName[0].Id);
					pszLibFileRemote = ((FileDialog)OpenFileDialog1).get_FileName();
					string lpModuleName = "Kernel32";
					int moduleHandleA = GetModuleHandleA(ref lpModuleName);
					string lpProcName = "LoadLibraryA";
					pfnStartAddr = GetProcAddress(moduleHandleA, ref lpProcName);
					TargetBufferSize = checked(1 + Strings.Len(pszLibFileRemote));
					int num3 = VirtualAllocEx(TargetProcessHandle, 0, TargetBufferSize, 4096, 4);
					int targetProcessHandle = TargetProcessHandle;
					ref string lpBuffer = ref pszLibFileRemote;
					int targetBufferSize = TargetBufferSize;
					int lpNumberOfBytesWritten = 0;
					WriteProcessMemory(targetProcessHandle, num3, ref lpBuffer, targetBufferSize, ref lpNumberOfBytesWritten);
					int targetProcessHandle2 = TargetProcessHandle;
					int lpStartAddress = pfnStartAddr;
					lpNumberOfBytesWritten = 0;
					CreateRemoteThread(targetProcessHandle2, 0, 0, lpStartAddress, num3, 0, ref lpNumberOfBytesWritten);
					CloseHandleA(TargetProcessHandle);
					break;
				}
				case 233:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0001;
					}
					break;
				}
				num4 = 1;
				((Control)this).Show();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj, num4);
				try0001_dispatch = 233;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((ButtonBase)Button1).set_Text("Browse");
		Label1.set_Text("Process");
		Timer1.set_Interval(50);
		Timer1.Start();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (!File.Exists(((FileDialog)OpenFileDialog1).get_FileName()))
		{
			return;
		}
		Process[] processesByName = Process.GetProcessesByName(TextBox1.get_Text());
		if (processesByName.Length == 0)
		{
			Label1.set_Text("Waiting For " + TextBox1.get_Text() + ".exe...");
			return;
		}
		Timer1.Stop();
		Label1.set_Text("Succefully Injected!");
		Inject();
		if (CheckBox1.get_Checked())
		{
			((Form)this).Close();
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		checked
		{
			for (int i = Dlls.get_SelectedItems().get_Count() - 1; i >= 0; i += -1)
			{
				Dlls.get_Items().Remove(RuntimeHelpers.GetObjectValue(Dlls.get_SelectedItems().get_Item(i)));
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Dlls.get_Items().Clear();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		((FileDialog)OpenFileDialog1).set_Filter("DLL (*.dll) |*.dll|(*.*) |*.*");
		((CommonDialog)OpenFileDialog1).ShowDialog();
		string text = ((FileDialog)OpenFileDialog1).get_FileName().Substring(((FileDialog)OpenFileDialog1).get_FileName().LastIndexOf("\\"));
		string text2 = text.Replace("\\", "");
		Dlls.get_Items().Add((object)text2);
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (!File.Exists(((FileDialog)OpenFileDialog1).get_FileName()))
		{
			return;
		}
		Process[] processesByName = Process.GetProcessesByName(TextBox1.get_Text());
		if (processesByName.Length == 0)
		{
			Label1.set_Text("Waiting for " + TextBox1.get_Text() + ".exe Injekcjia(F12)...");
			return;
		}
		Timer1.Stop();
		Label1.set_Text("Pomyslna Injekcjia!");
		Inject();
		if (CheckBox1.get_Checked())
		{
			((Form)this).Close();
		}
	}

	private void CheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		((Control)Button4).set_Enabled(false);
		Timer1.set_Enabled(true);
	}

	private void CheckBox3_CheckedChanged(object sender, EventArgs e)
	{
		((Control)Button4).set_Enabled(true);
		Timer1.set_Enabled(false);
	}

	private short GetAsyncKeyState(int vKey)
	{
		if (GetAsyncKeyState(123) != 0 && File.Exists(((FileDialog)OpenFileDialog1).get_FileName()))
		{
			Process[] processesByName = Process.GetProcessesByName(TextBox1.get_Text());
			if (processesByName.Length == 0)
			{
				Label1.set_Text("Waiting for " + TextBox1.get_Text() + ".exe Injekcjia(F12)...");
			}
			else
			{
				Timer1.Stop();
				Label1.set_Text("Succefully Injected!");
				Inject();
			}
		}
		short result = default(short);
		return result;
	}
}
