using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace hotfile_link_generator;

public class about : Form
{
	private IContainer icontainer_0;

	private TextBox textBox1;

	private TextBox textBox2;

	private LinkLabel linkLabel3;

	private PictureBox pictureBox1;

	private TabControl tabControl1;

	private TabPage tabPage2;

	private TabPage tabPage1;

	private TextBox textBox4;

	private LinkLabel linkLabel1;

	private TextBox textBox3;

	private LinkLabel linkLabel2;

	public about()
	{
		InitializeComponent();
	}

	private void method_0(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	private void about_Load(object sender, EventArgs e)
	{
		((Control)this).set_Text(Form2.program_name);
		((Control)linkLabel3).set_Text(Form2.website_link);
		((Control)textBox2).set_Text(Form2.program_name);
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start(Form2.website_link);
		}
		catch
		{
		}
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void method_2(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.alertpay.com/SendMoney.aspx");
	}

	private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start(Form2.website_link);
		}
		catch
		{
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		Process.Start("http://www.facebook.com/home.php?sk=group_160444817342561&ap=1");
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.moneybookers.com/app/send.pl");
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void method_6(object sender, EventArgs e)
	{
	}

	private void tabPage2_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

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
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected O, but got Unknown
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected O, but got Unknown
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected O, but got Unknown
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(about));
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		linkLabel3 = new LinkLabel();
		tabControl1 = new TabControl();
		tabPage2 = new TabPage();
		pictureBox1 = new PictureBox();
		tabPage1 = new TabPage();
		textBox4 = new TextBox();
		linkLabel1 = new LinkLabel();
		textBox3 = new TextBox();
		linkLabel2 = new LinkLabel();
		((Control)tabControl1).SuspendLayout();
		((Control)tabPage2).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)tabPage1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)textBox1).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(18, 9));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(252, 55));
		((Control)textBox1).set_TabIndex(2);
		((Control)textBox1).set_Text("\r\nwebsite:");
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)textBox2).set_BackColor(SystemColors.ControlLightLight);
		((Control)textBox2).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_Location(new Point(41, 79));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		((Control)textBox2).set_Size(new Size(196, 26));
		((Control)textBox2).set_TabIndex(4);
		((Control)textBox2).set_TabStop(false);
		((Control)textBox2).set_Text("HF premium link Generator v1.4");
		((Control)textBox2).add_TextChanged((EventHandler)textBox2_TextChanged);
		((Control)linkLabel3).set_AutoSize(true);
		((Control)linkLabel3).set_BackColor(SystemColors.ControlLightLight);
		((Control)linkLabel3).set_Location(new Point(70, 30));
		((Control)linkLabel3).set_Name("linkLabel3");
		((Control)linkLabel3).set_Size(new Size(13, 13));
		((Control)linkLabel3).set_TabIndex(20);
		((Label)linkLabel3).set_TabStop(true);
		((Control)linkLabel3).set_Text("d");
		linkLabel3.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel3_LinkClicked));
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage2);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage1);
		((Control)tabControl1).set_Dock((DockStyle)5);
		((Control)tabControl1).set_Location(new Point(0, 0));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedIndex(0);
		((Control)tabControl1).set_Size(new Size(282, 195));
		((Control)tabControl1).set_TabIndex(22);
		((Control)tabPage2).get_Controls().Add((Control)(object)linkLabel3);
		((Control)tabPage2).get_Controls().Add((Control)(object)textBox1);
		((Control)tabPage2).get_Controls().Add((Control)(object)pictureBox1);
		((Control)tabPage2).get_Controls().Add((Control)(object)textBox2);
		tabPage2.set_Location(new Point(4, 22));
		((Control)tabPage2).set_Name("tabPage2");
		((Control)tabPage2).set_Padding(new Padding(3));
		((Control)tabPage2).set_Size(new Size(274, 169));
		tabPage2.set_TabIndex(1);
		((Control)tabPage2).set_Text("Findus");
		tabPage2.set_UseVisualStyleBackColor(true);
		((Control)tabPage2).add_Click((EventHandler)tabPage2_Click);
		((Control)pictureBox1).set_Cursor(Cursors.get_Hand());
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(56, 116));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(150, 45));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(21);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox4);
		((Control)tabPage1).get_Controls().Add((Control)(object)linkLabel1);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox3);
		((Control)tabPage1).get_Controls().Add((Control)(object)linkLabel2);
		tabPage1.set_Location(new Point(4, 22));
		((Control)tabPage1).set_Name("tabPage1");
		((Control)tabPage1).set_Padding(new Padding(3));
		((Control)tabPage1).set_Size(new Size(274, 169));
		tabPage1.set_TabIndex(2);
		((Control)tabPage1).set_Text("help us");
		tabPage1.set_UseVisualStyleBackColor(true);
		((Control)textBox4).set_Location(new Point(88, 102));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(135, 20));
		((Control)textBox4).set_TabIndex(23);
		((Control)textBox4).set_Text("taha.tata123@gmail.com");
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_BackColor(SystemColors.ControlLightLight);
		((Control)linkLabel1).set_Font(new Font("Comic Sans MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)linkLabel1).set_ForeColor(Color.Red);
		linkLabel1.set_LinkColor(Color.Red);
		((Control)linkLabel1).set_Location(new Point(3, 84));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(160, 15));
		((Control)linkLabel1).set_TabIndex(22);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("Donate Using Moneybooker to");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((Control)textBox3).set_Location(new Point(89, 43));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(137, 20));
		((Control)textBox3).set_TabIndex(21);
		((Control)textBox3).set_Text("a.shawky.1@gmail.com");
		((Control)linkLabel2).set_AutoSize(true);
		((Control)linkLabel2).set_BackColor(SystemColors.ControlLightLight);
		((Control)linkLabel2).set_Font(new Font("Comic Sans MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)linkLabel2).set_ForeColor(Color.Red);
		linkLabel2.set_LinkColor(Color.Red);
		((Control)linkLabel2).set_Location(new Point(8, 16));
		((Control)linkLabel2).set_Name("linkLabel2");
		((Control)linkLabel2).set_Size(new Size(145, 15));
		((Control)linkLabel2).set_TabIndex(20);
		((Label)linkLabel2).set_TabStop(true);
		((Control)linkLabel2).set_Text("Donate using  Alertpay  to :\r\n");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(282, 195));
		((Control)this).get_Controls().Add((Control)(object)tabControl1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("about");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("HF premium link Generator v1.4");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)about_Load);
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPage2).ResumeLayout(false);
		((Control)tabPage2).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)tabPage1).ResumeLayout(false);
		((Control)tabPage1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
