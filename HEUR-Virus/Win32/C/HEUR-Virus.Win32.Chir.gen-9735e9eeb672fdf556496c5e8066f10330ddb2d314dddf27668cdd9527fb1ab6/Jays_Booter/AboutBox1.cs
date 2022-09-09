using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Jays_Booter;

[DesignerGenerated]
public sealed class AboutBox1 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("TableLayoutPanel")]
	private TableLayoutPanel _TableLayoutPanel;

	[AccessedThroughProperty("LabelVersion")]
	private Label _LabelVersion;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("OKButton")]
	private Button _OKButton;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("LinkLabel2")]
	private LinkLabel _LinkLabel2;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("LabelX3")]
	private LabelX vDonobce4;

	internal virtual TableLayoutPanel TableLayoutPanel
	{
		[DebuggerNonUserCode]
		get
		{
			return _TableLayoutPanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TableLayoutPanel = value;
		}
	}

	internal virtual Label LabelVersion
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelVersion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelVersion = value;
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

	internal virtual Button OKButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _OKButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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
			_LinkLabel1 = value;
		}
	}

	internal virtual LinkLabel LinkLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(LinkLabel2_LinkClicked);
			if (_LinkLabel2 != null)
			{
				_LinkLabel2.remove_LinkClicked(val);
			}
			_LinkLabel2 = value;
			if (_LinkLabel2 != null)
			{
				_LinkLabel2.add_LinkClicked(val);
			}
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

	internal virtual LabelX LabelX1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX1 = value;
		}
	}

	internal virtual LabelX LabelX2
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX2 = value;
		}
	}

	internal virtual LabelX LabelX3
	{
		[DebuggerNonUserCode]
		get
		{
			return vDonobce4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			vDonobce4 = value;
		}
	}

	[DebuggerNonUserCode]
	public AboutBox1()
	{
		Class7.smethod_0();
		((Form)this)._002Ector();
		((Form)this).add_Load((EventHandler)AboutBox1_Load);
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected O, but got Unknown
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Expected O, but got Unknown
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Expected O, but got Unknown
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected O, but got Unknown
		//IL_0965: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Expected O, but got Unknown
		//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd5: Expected O, but got Unknown
		//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutBox1));
		TableLayoutPanel = new TableLayoutPanel();
		LabelX2 = new LabelX();
		Label4 = new Label();
		LinkLabel1 = new LinkLabel();
		LabelVersion = new Label();
		Label1 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		OKButton = new Button();
		LinkLabel2 = new LinkLabel();
		LabelX3 = new LabelX();
		LabelX1 = new LabelX();
		((Control)TableLayoutPanel).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)TableLayoutPanel).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)TableLayoutPanel).set_BackgroundImage((Image)componentResourceManager.GetObject("TableLayoutPanel.BackgroundImage"));
		TableLayoutPanel.set_ColumnCount(2);
		TableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 2.272727f));
		TableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 97.72727f));
		TableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelX2, 0, 0);
		TableLayoutPanel.get_Controls().Add((Control)(object)Label4, 0, 7);
		TableLayoutPanel.get_Controls().Add((Control)(object)LinkLabel1, 0, 5);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelVersion, 1, 1);
		TableLayoutPanel.get_Controls().Add((Control)(object)Label1, 1, 2);
		TableLayoutPanel.get_Controls().Add((Control)(object)Label3, 1, 4);
		TableLayoutPanel.get_Controls().Add((Control)(object)Label2, 1, 3);
		TableLayoutPanel.get_Controls().Add((Control)(object)OKButton, 1, 8);
		TableLayoutPanel.get_Controls().Add((Control)(object)LinkLabel2, 1, 5);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelX3, 1, 6);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelX1, 1, 7);
		((Control)TableLayoutPanel).set_Dock((DockStyle)1);
		TableLayoutPanel tableLayoutPanel = TableLayoutPanel;
		Point location = new Point(9, 9);
		((Control)tableLayoutPanel).set_Location(location);
		((Control)TableLayoutPanel).set_Name("TableLayoutPanel");
		TableLayoutPanel.set_RowCount(9);
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 4.263566f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 8.914729f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 7.751938f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 8.914729f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 63.63636f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 7.272727f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 26f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 17f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 27f));
		TableLayoutPanel tableLayoutPanel2 = TableLayoutPanel;
		Size size = new Size(396, 291);
		((Control)tableLayoutPanel2).set_Size(size);
		((Control)TableLayoutPanel).set_TabIndex(1);
		((Control)LabelX2).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX2).set_ForeColor(SystemColors.ButtonFace);
		LabelX labelX = LabelX2;
		location = new Point(3, 3);
		((Control)labelX).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX2 = LabelX2;
		size = new Size(2, 2);
		((Control)labelX2).set_Size(size);
		((Control)LabelX2).set_TabIndex(8);
		LabelX2.set_Text("THIS is the ONLY thread about my shell booter, all the other ones are fake!");
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Dock((DockStyle)5);
		((Control)Label4).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.DeepSkyBlue);
		Label label = Label4;
		location = new Point(6, 244);
		((Control)label).set_Location(location);
		Label label2 = Label4;
		Padding val = default(Padding);
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)label2).set_Margin(val);
		Label label3 = Label4;
		size = new Size(0, 17);
		((Control)label3).set_MaximumSize(size);
		((Control)Label4).set_Name("Label4");
		Label label4 = Label4;
		size = new Size(1, 17);
		((Control)label4).set_Size(size);
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("Version: 4.8.4");
		Label4.set_TextAlign((ContentAlignment)16);
		LinkLabel1.set_ActiveLinkColor(Color.Transparent);
		((Control)LinkLabel1).set_BackColor(Color.Transparent);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(3, 203);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(2, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(4);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("LinkLabel1");
		((Control)LabelVersion).set_BackColor(Color.Transparent);
		((Control)LabelVersion).set_Dock((DockStyle)5);
		((Control)LabelVersion).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LabelVersion).set_ForeColor(Color.DeepSkyBlue);
		Label labelVersion = LabelVersion;
		location = new Point(14, 9);
		((Control)labelVersion).set_Location(location);
		Label labelVersion2 = LabelVersion;
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)labelVersion2).set_Margin(val);
		Label labelVersion3 = LabelVersion;
		size = new Size(0, 17);
		((Control)labelVersion3).set_MaximumSize(size);
		((Control)LabelVersion).set_Name("LabelVersion");
		Label labelVersion4 = LabelVersion;
		size = new Size(379, 17);
		((Control)labelVersion4).set_Size(size);
		((Control)LabelVersion).set_TabIndex(0);
		LabelVersion.set_Text("Version: 5.6.3");
		LabelVersion.set_TextAlign((ContentAlignment)16);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.DeepSkyBlue);
		Label label5 = Label1;
		location = new Point(11, 28);
		((Control)label5).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label6 = Label1;
		size = new Size(267, 14);
		((Control)label6).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Contact: jtheboss95@aol.com   AIM: jtheboss95");
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.Cyan);
		Label label7 = Label3;
		location = new Point(11, 64);
		((Control)label7).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label8 = Label3;
		size = new Size(381, 126);
		((Control)label8).set_Size(size);
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text(componentResourceManager.GetString("Label3.Text"));
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.DeepSkyBlue);
		Label label9 = Label2;
		location = new Point(11, 45);
		((Control)label9).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label10 = Label2;
		size = new Size(72, 14);
		((Control)label10).set_Size(size);
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Coders: Jay");
		((Control)OKButton).set_Anchor((AnchorStyles)10);
		((ButtonBase)OKButton).set_BackColor(SystemColors.ControlDarkDark);
		OKButton.set_DialogResult((DialogResult)2);
		((ButtonBase)OKButton).set_FlatStyle((FlatStyle)0);
		((Control)OKButton).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button oKButton = OKButton;
		location = new Point(11, 267);
		((Control)oKButton).set_Location(location);
		((Control)OKButton).set_Name("OKButton");
		Button oKButton2 = OKButton;
		size = new Size(382, 21);
		((Control)oKButton2).set_Size(size);
		((Control)OKButton).set_TabIndex(0);
		((ButtonBase)OKButton).set_Text("&OK");
		((ButtonBase)OKButton).set_UseVisualStyleBackColor(false);
		LinkLabel2.set_ActiveLinkColor(Color.Transparent);
		((Control)LinkLabel2).set_BackColor(Color.Transparent);
		((Control)LinkLabel2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)LinkLabel2).set_ForeColor(Color.Yellow);
		LinkLabel2.set_LinkColor(Color.White);
		LinkLabel linkLabel3 = LinkLabel2;
		location = new Point(11, 203);
		((Control)linkLabel3).set_Location(location);
		((Control)LinkLabel2).set_Name("LinkLabel2");
		LinkLabel linkLabel4 = LinkLabel2;
		size = new Size(310, 15);
		((Control)linkLabel4).set_Size(size);
		((Control)LinkLabel2).set_TabIndex(5);
		((Label)LinkLabel2).set_TabStop(true);
		((Control)LinkLabel2).set_Tag((object)"http://www.hackforums.net/showthread.php?tid=962179");
		LinkLabel2.set_Text("http://www.hackforums.net/showthread.php?tid=962179");
		((Label)LinkLabel2).set_TextAlign((ContentAlignment)2);
		((Control)LabelX3).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX3).set_ForeColor(Color.Yellow);
		LabelX labelX3 = LabelX3;
		location = new Point(11, 221);
		((Control)labelX3).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX4 = LabelX3;
		size = new Size(381, 20);
		((Control)labelX4).set_Size(size);
		((Control)LabelX3).set_TabIndex(9);
		LabelX3.set_Text("ABOVE is the ONLY OFFICIAL thread about my shell booter.");
		((Control)LabelX1).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_ForeColor(Color.Yellow);
		LabelX labelX5 = LabelX1;
		location = new Point(11, 247);
		((Control)labelX5).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX6 = LabelX1;
		size = new Size(381, 11);
		((Control)labelX6).set_Size(size);
		((Control)LabelX1).set_TabIndex(7);
		LabelX1.set_Text("Bookmark the thread below for instant updates! This is a FREE booter");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveCaptionText);
		size = new Size(414, 312);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TableLayoutPanel);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AboutBox1");
		((Padding)(ref val))._002Ector(9);
		((Control)this).set_Padding(val);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("About Jays shell booter");
		((Control)TableLayoutPanel).ResumeLayout(false);
		((Control)TableLayoutPanel).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void AboutBox1_Load(object sender, EventArgs e)
	{
		string arg = ((Operators.CompareString(((ApplicationBase)Class2.Form0_0).get_Info().get_Title(), "", false) == 0) ? Path.GetFileNameWithoutExtension(((ApplicationBase)Class2.Form0_0).get_Info().get_AssemblyName()) : ((ApplicationBase)Class2.Form0_0).get_Info().get_Title());
		((Form)this).set_Text($"About {arg}");
		LinkLabel2.get_Links().get_Item(0).set_LinkData((object)"http://visualbasic.about.com");
	}

	private void OKButton_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.hackforums.net/showthread.php?tid=962179m");
	}
}
