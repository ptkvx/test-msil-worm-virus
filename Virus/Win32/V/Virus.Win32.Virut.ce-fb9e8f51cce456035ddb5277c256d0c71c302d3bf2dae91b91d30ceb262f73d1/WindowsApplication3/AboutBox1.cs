using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using WindowsApplication3.My;

namespace WindowsApplication3;

[DesignerGenerated]
public sealed class AboutBox1 : Form
{
	[AccessedThroughProperty("TableLayoutPanel")]
	private TableLayoutPanel _TableLayoutPanel;

	[AccessedThroughProperty("LogoPictureBox")]
	private PictureBox _LogoPictureBox;

	[AccessedThroughProperty("LabelProductName")]
	private Label _LabelProductName;

	[AccessedThroughProperty("LabelVersion")]
	private Label _LabelVersion;

	[AccessedThroughProperty("LabelCompanyName")]
	private Label _LabelCompanyName;

	[AccessedThroughProperty("TextBoxDescription")]
	private TextBox _TextBoxDescription;

	[AccessedThroughProperty("OKButton")]
	private Button _OKButton;

	[AccessedThroughProperty("LabelCopyright")]
	private Label _LabelCopyright;

	private IContainer components;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("CheckBox3")]
	private CheckBox _CheckBox3;

	[AccessedThroughProperty("CheckBox4")]
	private CheckBox _CheckBox4;

	[AccessedThroughProperty("CheckBox5")]
	private CheckBox _CheckBox5;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[AccessedThroughProperty("Button9")]
	private Button _Button9;

	[AccessedThroughProperty("Button10")]
	private Button _Button10;

	[AccessedThroughProperty("Button11")]
	private Button _Button11;

	[AccessedThroughProperty("Button12")]
	private Button _Button12;

	[AccessedThroughProperty("Button13")]
	private Button _Button13;

	[AccessedThroughProperty("Button14")]
	private Button _Button14;

	[AccessedThroughProperty("Button15")]
	private Button _Button15;

	[AccessedThroughProperty("Button16")]
	private Button _Button16;

	[AccessedThroughProperty("Button17")]
	private Button _Button17;

	internal virtual TableLayoutPanel TableLayoutPanel
	{
		get
		{
			return _TableLayoutPanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TableLayoutPanel = value;
		}
	}

	internal virtual PictureBox LogoPictureBox
	{
		get
		{
			return _LogoPictureBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LogoPictureBox = value;
		}
	}

	internal virtual Label LabelProductName
	{
		get
		{
			return _LabelProductName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LabelProductName = value;
		}
	}

	internal virtual Label LabelVersion
	{
		get
		{
			return _LabelVersion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LabelVersion = value;
		}
	}

	internal virtual Label LabelCompanyName
	{
		get
		{
			return _LabelCompanyName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LabelCompanyName = value;
		}
	}

	internal virtual TextBox TextBoxDescription
	{
		get
		{
			return _TextBoxDescription;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBoxDescription = value;
		}
	}

	internal virtual Button OKButton
	{
		get
		{
			return _OKButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = OKButton_Click;
			if (_OKButton != null)
			{
				((Control)_OKButton).remove_Click(eventHandler);
			}
			_OKButton = value;
			if (_OKButton != null)
			{
				((Control)_OKButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label LabelCopyright
	{
		get
		{
			return _LabelCopyright;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LabelCopyright = value;
		}
	}

	internal virtual CheckBox CheckBox1
	{
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual CheckBox CheckBox2
	{
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox2 = value;
		}
	}

	internal virtual CheckBox CheckBox3
	{
		get
		{
			return _CheckBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox3 = value;
		}
	}

	internal virtual CheckBox CheckBox4
	{
		get
		{
			return _CheckBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox4 = value;
		}
	}

	internal virtual CheckBox CheckBox5
	{
		get
		{
			return _CheckBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox5 = value;
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button1 = value;
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button2 = value;
		}
	}

	internal virtual Button Button3
	{
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button3 = value;
		}
	}

	internal virtual Button Button4
	{
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button4 = value;
		}
	}

	internal virtual Button Button5
	{
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button5 = value;
		}
	}

	internal virtual Button Button6
	{
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button6 = value;
		}
	}

	internal virtual Button Button7
	{
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button7 = value;
		}
	}

	internal virtual Button Button8
	{
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button8 = value;
		}
	}

	internal virtual Button Button9
	{
		get
		{
			return _Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button9 = value;
		}
	}

	internal virtual Button Button10
	{
		get
		{
			return _Button10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button10 = value;
		}
	}

	internal virtual Button Button11
	{
		get
		{
			return _Button11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button11 = value;
		}
	}

	internal virtual Button Button12
	{
		get
		{
			return _Button12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button12 = value;
		}
	}

	internal virtual Button Button13
	{
		get
		{
			return _Button13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button13 = value;
		}
	}

	internal virtual Button Button14
	{
		get
		{
			return _Button14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button14 = value;
		}
	}

	internal virtual Button Button15
	{
		get
		{
			return _Button15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button15 = value;
		}
	}

	internal virtual Button Button16
	{
		get
		{
			return _Button16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button16 = value;
		}
	}

	internal virtual Button Button17
	{
		get
		{
			return _Button17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button17 = value;
		}
	}

	public AboutBox1()
	{
		((Form)this).add_Load((EventHandler)AboutBox1_Load);
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
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1322: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutBox1));
		TableLayoutPanel = new TableLayoutPanel();
		LogoPictureBox = new PictureBox();
		LabelProductName = new Label();
		LabelVersion = new Label();
		LabelCopyright = new Label();
		LabelCompanyName = new Label();
		TextBoxDescription = new TextBox();
		OKButton = new Button();
		CheckBox1 = new CheckBox();
		CheckBox2 = new CheckBox();
		CheckBox3 = new CheckBox();
		CheckBox4 = new CheckBox();
		CheckBox5 = new CheckBox();
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		Button4 = new Button();
		Button5 = new Button();
		Button6 = new Button();
		Button7 = new Button();
		Button8 = new Button();
		Button9 = new Button();
		Button10 = new Button();
		Button11 = new Button();
		Button12 = new Button();
		Button13 = new Button();
		Button14 = new Button();
		Button15 = new Button();
		Button16 = new Button();
		Button17 = new Button();
		((Control)TableLayoutPanel).SuspendLayout();
		((ISupportInitialize)LogoPictureBox).BeginInit();
		((Control)this).SuspendLayout();
		TableLayoutPanel.set_ColumnCount(2);
		TableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33f));
		TableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 67f));
		TableLayoutPanel.get_Controls().Add((Control)(object)LogoPictureBox, 0, 0);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelProductName, 1, 0);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelVersion, 1, 1);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelCopyright, 1, 2);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelCompanyName, 1, 3);
		TableLayoutPanel.get_Controls().Add((Control)(object)TextBoxDescription, 1, 4);
		TableLayoutPanel.get_Controls().Add((Control)(object)OKButton, 1, 5);
		((Control)TableLayoutPanel).set_Dock((DockStyle)5);
		TableLayoutPanel tableLayoutPanel = TableLayoutPanel;
		Point location = new Point(9, 9);
		((Control)tableLayoutPanel).set_Location(location);
		((Control)TableLayoutPanel).set_Name("TableLayoutPanel");
		TableLayoutPanel.set_RowCount(6);
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel tableLayoutPanel2 = TableLayoutPanel;
		Size size = new Size(396, 258);
		((Control)tableLayoutPanel2).set_Size(size);
		((Control)TableLayoutPanel).set_TabIndex(0);
		((Control)LogoPictureBox).set_Dock((DockStyle)5);
		LogoPictureBox.set_Image((Image)componentResourceManager.GetObject("LogoPictureBox.Image"));
		PictureBox logoPictureBox = LogoPictureBox;
		location = new Point(3, 3);
		((Control)logoPictureBox).set_Location(location);
		((Control)LogoPictureBox).set_Name("LogoPictureBox");
		TableLayoutPanel.SetRowSpan((Control)(object)LogoPictureBox, 6);
		PictureBox logoPictureBox2 = LogoPictureBox;
		size = new Size(124, 252);
		((Control)logoPictureBox2).set_Size(size);
		LogoPictureBox.set_SizeMode((PictureBoxSizeMode)1);
		LogoPictureBox.set_TabIndex(0);
		LogoPictureBox.set_TabStop(false);
		((Control)LabelProductName).set_Dock((DockStyle)5);
		Label labelProductName = LabelProductName;
		location = new Point(136, 0);
		((Control)labelProductName).set_Location(location);
		Label labelProductName2 = LabelProductName;
		Padding val = default(Padding);
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)labelProductName2).set_Margin(val);
		Label labelProductName3 = LabelProductName;
		size = new Size(0, 17);
		((Control)labelProductName3).set_MaximumSize(size);
		((Control)LabelProductName).set_Name("LabelProductName");
		Label labelProductName4 = LabelProductName;
		size = new Size(257, 17);
		((Control)labelProductName4).set_Size(size);
		((Control)LabelProductName).set_TabIndex(0);
		LabelProductName.set_Text("Product Name");
		LabelProductName.set_TextAlign((ContentAlignment)16);
		((Control)LabelVersion).set_Dock((DockStyle)5);
		Label labelVersion = LabelVersion;
		location = new Point(136, 25);
		((Control)labelVersion).set_Location(location);
		Label labelVersion2 = LabelVersion;
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)labelVersion2).set_Margin(val);
		Label labelVersion3 = LabelVersion;
		size = new Size(0, 17);
		((Control)labelVersion3).set_MaximumSize(size);
		((Control)LabelVersion).set_Name("LabelVersion");
		Label labelVersion4 = LabelVersion;
		size = new Size(257, 17);
		((Control)labelVersion4).set_Size(size);
		((Control)LabelVersion).set_TabIndex(0);
		LabelVersion.set_Text("Version");
		LabelVersion.set_TextAlign((ContentAlignment)16);
		((Control)LabelCopyright).set_Dock((DockStyle)5);
		Label labelCopyright = LabelCopyright;
		location = new Point(136, 50);
		((Control)labelCopyright).set_Location(location);
		Label labelCopyright2 = LabelCopyright;
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)labelCopyright2).set_Margin(val);
		Label labelCopyright3 = LabelCopyright;
		size = new Size(0, 17);
		((Control)labelCopyright3).set_MaximumSize(size);
		((Control)LabelCopyright).set_Name("LabelCopyright");
		Label labelCopyright4 = LabelCopyright;
		size = new Size(257, 17);
		((Control)labelCopyright4).set_Size(size);
		((Control)LabelCopyright).set_TabIndex(0);
		LabelCopyright.set_Text("Copyright");
		LabelCopyright.set_TextAlign((ContentAlignment)16);
		((Control)LabelCompanyName).set_Dock((DockStyle)5);
		Label labelCompanyName = LabelCompanyName;
		location = new Point(136, 75);
		((Control)labelCompanyName).set_Location(location);
		Label labelCompanyName2 = LabelCompanyName;
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)labelCompanyName2).set_Margin(val);
		Label labelCompanyName3 = LabelCompanyName;
		size = new Size(0, 17);
		((Control)labelCompanyName3).set_MaximumSize(size);
		((Control)LabelCompanyName).set_Name("LabelCompanyName");
		Label labelCompanyName4 = LabelCompanyName;
		size = new Size(257, 17);
		((Control)labelCompanyName4).set_Size(size);
		((Control)LabelCompanyName).set_TabIndex(0);
		LabelCompanyName.set_Text("Company Name");
		LabelCompanyName.set_TextAlign((ContentAlignment)16);
		((Control)TextBoxDescription).set_Dock((DockStyle)5);
		TextBox textBoxDescription = TextBoxDescription;
		location = new Point(136, 103);
		((Control)textBoxDescription).set_Location(location);
		TextBox textBoxDescription2 = TextBoxDescription;
		((Padding)(ref val))._002Ector(6, 3, 3, 3);
		((Control)textBoxDescription2).set_Margin(val);
		TextBoxDescription.set_Multiline(true);
		((Control)TextBoxDescription).set_Name("TextBoxDescription");
		((TextBoxBase)TextBoxDescription).set_ReadOnly(true);
		TextBoxDescription.set_ScrollBars((ScrollBars)3);
		TextBox textBoxDescription3 = TextBoxDescription;
		size = new Size(257, 123);
		((Control)textBoxDescription3).set_Size(size);
		((Control)TextBoxDescription).set_TabIndex(0);
		((Control)TextBoxDescription).set_TabStop(false);
		TextBoxDescription.set_Text(componentResourceManager.GetString("TextBoxDescription.Text"));
		((Control)OKButton).set_Anchor((AnchorStyles)10);
		OKButton.set_DialogResult((DialogResult)2);
		Button oKButton = OKButton;
		location = new Point(318, 232);
		((Control)oKButton).set_Location(location);
		((Control)OKButton).set_Name("OKButton");
		Button oKButton2 = OKButton;
		size = new Size(75, 23);
		((Control)oKButton2).set_Size(size);
		((Control)OKButton).set_TabIndex(0);
		((ButtonBase)OKButton).set_Text("&OK");
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(0, 0);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(79, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(1);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		CheckBox checkBox3 = CheckBox2;
		location = new Point(8, 8);
		((Control)checkBox3).set_Location(location);
		((Control)CheckBox2).set_Name("CheckBox2");
		CheckBox checkBox4 = CheckBox2;
		size = new Size(79, 17);
		((Control)checkBox4).set_Size(size);
		((Control)CheckBox2).set_TabIndex(2);
		((ButtonBase)CheckBox2).set_Text("CheckBox2");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox3).set_AutoSize(true);
		CheckBox checkBox5 = CheckBox3;
		location = new Point(16, 16);
		((Control)checkBox5).set_Location(location);
		((Control)CheckBox3).set_Name("CheckBox3");
		CheckBox checkBox6 = CheckBox3;
		size = new Size(79, 17);
		((Control)checkBox6).set_Size(size);
		((Control)CheckBox3).set_TabIndex(3);
		((ButtonBase)CheckBox3).set_Text("CheckBox3");
		((ButtonBase)CheckBox3).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox4).set_AutoSize(true);
		CheckBox checkBox7 = CheckBox4;
		location = new Point(24, 24);
		((Control)checkBox7).set_Location(location);
		((Control)CheckBox4).set_Name("CheckBox4");
		CheckBox checkBox8 = CheckBox4;
		size = new Size(79, 17);
		((Control)checkBox8).set_Size(size);
		((Control)CheckBox4).set_TabIndex(4);
		((ButtonBase)CheckBox4).set_Text("CheckBox4");
		((ButtonBase)CheckBox4).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox5).set_AutoSize(true);
		CheckBox checkBox9 = CheckBox5;
		location = new Point(32, 32);
		((Control)checkBox9).set_Location(location);
		((Control)CheckBox5).set_Name("CheckBox5");
		CheckBox checkBox10 = CheckBox5;
		size = new Size(79, 17);
		((Control)checkBox10).set_Size(size);
		((Control)CheckBox5).set_TabIndex(5);
		((ButtonBase)CheckBox5).set_Text("CheckBox5");
		((ButtonBase)CheckBox5).set_UseVisualStyleBackColor(true);
		Button button = Button1;
		location = new Point(40, 40);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(6);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(48, 48);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(7);
		((ButtonBase)Button2).set_Text("Button2");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button button5 = Button3;
		location = new Point(56, 56);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(75, 23);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(8);
		((ButtonBase)Button3).set_Text("Button3");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		Button button7 = Button4;
		location = new Point(64, 64);
		((Control)button7).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button8 = Button4;
		size = new Size(75, 23);
		((Control)button8).set_Size(size);
		((Control)Button4).set_TabIndex(9);
		((ButtonBase)Button4).set_Text("Button4");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		Button button9 = Button5;
		location = new Point(72, 72);
		((Control)button9).set_Location(location);
		((Control)Button5).set_Name("Button5");
		Button button10 = Button5;
		size = new Size(75, 23);
		((Control)button10).set_Size(size);
		((Control)Button5).set_TabIndex(10);
		((ButtonBase)Button5).set_Text("Button5");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(true);
		Button button11 = Button6;
		location = new Point(80, 80);
		((Control)button11).set_Location(location);
		((Control)Button6).set_Name("Button6");
		Button button12 = Button6;
		size = new Size(75, 23);
		((Control)button12).set_Size(size);
		((Control)Button6).set_TabIndex(11);
		((ButtonBase)Button6).set_Text("Button6");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		Button button13 = Button7;
		location = new Point(88, 88);
		((Control)button13).set_Location(location);
		((Control)Button7).set_Name("Button7");
		Button button14 = Button7;
		size = new Size(75, 23);
		((Control)button14).set_Size(size);
		((Control)Button7).set_TabIndex(12);
		((ButtonBase)Button7).set_Text("Button7");
		((ButtonBase)Button7).set_UseVisualStyleBackColor(true);
		Button button15 = Button8;
		location = new Point(96, 96);
		((Control)button15).set_Location(location);
		((Control)Button8).set_Name("Button8");
		Button button16 = Button8;
		size = new Size(75, 23);
		((Control)button16).set_Size(size);
		((Control)Button8).set_TabIndex(13);
		((ButtonBase)Button8).set_Text("Button8");
		((ButtonBase)Button8).set_UseVisualStyleBackColor(true);
		Button button17 = Button9;
		location = new Point(104, 104);
		((Control)button17).set_Location(location);
		((Control)Button9).set_Name("Button9");
		Button button18 = Button9;
		size = new Size(75, 23);
		((Control)button18).set_Size(size);
		((Control)Button9).set_TabIndex(14);
		((ButtonBase)Button9).set_Text("Button9");
		((ButtonBase)Button9).set_UseVisualStyleBackColor(true);
		Button button19 = Button10;
		location = new Point(112, 112);
		((Control)button19).set_Location(location);
		((Control)Button10).set_Name("Button10");
		Button button20 = Button10;
		size = new Size(75, 23);
		((Control)button20).set_Size(size);
		((Control)Button10).set_TabIndex(15);
		((ButtonBase)Button10).set_Text("Button10");
		((ButtonBase)Button10).set_UseVisualStyleBackColor(true);
		Button button21 = Button11;
		location = new Point(120, 120);
		((Control)button21).set_Location(location);
		((Control)Button11).set_Name("Button11");
		Button button22 = Button11;
		size = new Size(75, 23);
		((Control)button22).set_Size(size);
		((Control)Button11).set_TabIndex(16);
		((ButtonBase)Button11).set_Text("Button11");
		((ButtonBase)Button11).set_UseVisualStyleBackColor(true);
		Button button23 = Button12;
		location = new Point(128, 128);
		((Control)button23).set_Location(location);
		((Control)Button12).set_Name("Button12");
		Button button24 = Button12;
		size = new Size(75, 23);
		((Control)button24).set_Size(size);
		((Control)Button12).set_TabIndex(17);
		((ButtonBase)Button12).set_Text("Button12");
		((ButtonBase)Button12).set_UseVisualStyleBackColor(true);
		Button button25 = Button13;
		location = new Point(136, 136);
		((Control)button25).set_Location(location);
		((Control)Button13).set_Name("Button13");
		Button button26 = Button13;
		size = new Size(75, 23);
		((Control)button26).set_Size(size);
		((Control)Button13).set_TabIndex(18);
		((ButtonBase)Button13).set_Text("Button13");
		((ButtonBase)Button13).set_UseVisualStyleBackColor(true);
		Button button27 = Button14;
		location = new Point(144, 144);
		((Control)button27).set_Location(location);
		((Control)Button14).set_Name("Button14");
		Button button28 = Button14;
		size = new Size(75, 23);
		((Control)button28).set_Size(size);
		((Control)Button14).set_TabIndex(19);
		((ButtonBase)Button14).set_Text("Button14");
		((ButtonBase)Button14).set_UseVisualStyleBackColor(true);
		Button button29 = Button15;
		location = new Point(152, 152);
		((Control)button29).set_Location(location);
		((Control)Button15).set_Name("Button15");
		Button button30 = Button15;
		size = new Size(75, 23);
		((Control)button30).set_Size(size);
		((Control)Button15).set_TabIndex(20);
		((ButtonBase)Button15).set_Text("Button15");
		((ButtonBase)Button15).set_UseVisualStyleBackColor(true);
		Button button31 = Button16;
		location = new Point(160, 160);
		((Control)button31).set_Location(location);
		((Control)Button16).set_Name("Button16");
		Button button32 = Button16;
		size = new Size(75, 23);
		((Control)button32).set_Size(size);
		((Control)Button16).set_TabIndex(21);
		((ButtonBase)Button16).set_Text("Button16");
		((ButtonBase)Button16).set_UseVisualStyleBackColor(true);
		Button button33 = Button17;
		location = new Point(168, 168);
		((Control)button33).set_Location(location);
		((Control)Button17).set_Name("Button17");
		Button button34 = Button17;
		size = new Size(75, 23);
		((Control)button34).set_Size(size);
		((Control)Button17).set_TabIndex(22);
		((ButtonBase)Button17).set_Text("Button17");
		((ButtonBase)Button17).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)OKButton);
		size = new Size(414, 276);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button17);
		((Control)this).get_Controls().Add((Control)(object)Button16);
		((Control)this).get_Controls().Add((Control)(object)Button15);
		((Control)this).get_Controls().Add((Control)(object)Button14);
		((Control)this).get_Controls().Add((Control)(object)Button13);
		((Control)this).get_Controls().Add((Control)(object)Button12);
		((Control)this).get_Controls().Add((Control)(object)Button11);
		((Control)this).get_Controls().Add((Control)(object)Button10);
		((Control)this).get_Controls().Add((Control)(object)Button9);
		((Control)this).get_Controls().Add((Control)(object)Button8);
		((Control)this).get_Controls().Add((Control)(object)Button7);
		((Control)this).get_Controls().Add((Control)(object)Button6);
		((Control)this).get_Controls().Add((Control)(object)Button5);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox5);
		((Control)this).get_Controls().Add((Control)(object)CheckBox4);
		((Control)this).get_Controls().Add((Control)(object)CheckBox3);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)TableLayoutPanel);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AboutBox1");
		((Padding)(ref val))._002Ector(9);
		((Control)this).set_Padding(val);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("AboutBox1");
		((Control)TableLayoutPanel).ResumeLayout(false);
		((Control)TableLayoutPanel).PerformLayout();
		((ISupportInitialize)LogoPictureBox).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void AboutBox1_Load(object sender, EventArgs e)
	{
		string arg = ((Operators.CompareString(((ApplicationBase)MyProject.Application).get_Info().get_Title(), "", false) == 0) ? Path.GetFileNameWithoutExtension(((ApplicationBase)MyProject.Application).get_Info().get_AssemblyName()) : ((ApplicationBase)MyProject.Application).get_Info().get_Title());
		((Form)this).set_Text($"About {arg}");
		LabelProductName.set_Text(((ApplicationBase)MyProject.Application).get_Info().get_ProductName());
		LabelVersion.set_Text($"Version {((ApplicationBase)MyProject.Application).get_Info().get_Version().ToString()}");
		LabelCopyright.set_Text(((ApplicationBase)MyProject.Application).get_Info().get_Copyright());
		LabelCompanyName.set_Text(((ApplicationBase)MyProject.Application).get_Info().get_CompanyName());
		TextBoxDescription.set_Text(((ApplicationBase)MyProject.Application).get_Info().get_Description());
	}

	private void OKButton_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
