using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using hotfile_link_generator.Properties;

namespace hotfile_link_generator;

public class about : Form
{
	private IContainer components;

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

	private TabPage tabPage3;

	private Label label2;

	private Label label1;

	private Button button2;

	private TextBox textBox6;

	private TextBox textBox5;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
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
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected O, but got Unknown
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected O, but got Unknown
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected O, but got Unknown
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Expected O, but got Unknown
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
		tabPage3 = new TabPage();
		label2 = new Label();
		label1 = new Label();
		button2 = new Button();
		textBox6 = new TextBox();
		textBox5 = new TextBox();
		((Control)tabControl1).SuspendLayout();
		((Control)tabPage2).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)tabPage1).SuspendLayout();
		((Control)tabPage3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)textBox1).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(18, 29));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(252, 71));
		((Control)textBox1).set_TabIndex(2);
		((Control)textBox1).set_Text("ahmed shawky\r\nmail: a.shawky.1@gmail.com\r\nwebsite:");
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)textBox2).set_BackColor(SystemColors.ControlLightLight);
		((Control)textBox2).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_Location(new Point(41, 128));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		((Control)textBox2).set_Size(new Size(204, 26));
		((Control)textBox2).set_TabIndex(4);
		((Control)textBox2).set_TabStop(false);
		((Control)textBox2).set_Text("FS premium link Generator V1.2");
		((Control)textBox2).add_TextChanged((EventHandler)textBox2_TextChanged);
		((Control)linkLabel3).set_AutoSize(true);
		((Control)linkLabel3).set_BackColor(SystemColors.ControlLightLight);
		((Control)linkLabel3).set_Location(new Point(70, 65));
		((Control)linkLabel3).set_Name("linkLabel3");
		((Control)linkLabel3).set_Size(new Size(13, 13));
		((Control)linkLabel3).set_TabIndex(20);
		((Label)linkLabel3).set_TabStop(true);
		((Control)linkLabel3).set_Text("d");
		linkLabel3.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel3_LinkClicked));
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage2);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage1);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage3);
		((Control)tabControl1).set_Dock((DockStyle)5);
		((Control)tabControl1).set_Location(new Point(0, 0));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedIndex(0);
		((Control)tabControl1).set_Size(new Size(314, 289));
		((Control)tabControl1).set_TabIndex(22);
		((Control)tabPage2).get_Controls().Add((Control)(object)linkLabel3);
		((Control)tabPage2).get_Controls().Add((Control)(object)textBox1);
		((Control)tabPage2).get_Controls().Add((Control)(object)pictureBox1);
		((Control)tabPage2).get_Controls().Add((Control)(object)textBox2);
		tabPage2.set_Location(new Point(4, 22));
		((Control)tabPage2).set_Name("tabPage2");
		((Control)tabPage2).set_Padding(new Padding(3));
		((Control)tabPage2).set_Size(new Size(306, 263));
		tabPage2.set_TabIndex(1);
		((Control)tabPage2).set_Text("Findus");
		tabPage2.set_UseVisualStyleBackColor(true);
		((Control)pictureBox1).set_Cursor(Cursors.get_Hand());
		pictureBox1.set_Image((Image)(object)Resources.facebook);
		((Control)pictureBox1).set_Location(new Point(56, 189));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(150, 45));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)2);
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
		((Control)tabPage1).set_Size(new Size(306, 263));
		tabPage1.set_TabIndex(2);
		((Control)tabPage1).set_Text("help us");
		tabPage1.set_UseVisualStyleBackColor(true);
		((Control)textBox4).set_Location(new Point(168, 121));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(135, 20));
		((Control)textBox4).set_TabIndex(23);
		((Control)textBox4).set_Text("taha.tata123@gmail.com");
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_BackColor(SystemColors.ControlLightLight);
		((Control)linkLabel1).set_Font(new Font("Comic Sans MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)linkLabel1).set_ForeColor(Color.Red);
		linkLabel1.set_LinkColor(Color.Red);
		((Control)linkLabel1).set_Location(new Point(2, 123));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(160, 15));
		((Control)linkLabel1).set_TabIndex(22);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("Donate Using Moneybooker to");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked_2));
		((Control)textBox3).set_Location(new Point(166, 48));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(137, 20));
		((Control)textBox3).set_TabIndex(21);
		((Control)textBox3).set_Text("a.shawky.1@gmail.com");
		((Control)linkLabel2).set_AutoSize(true);
		((Control)linkLabel2).set_BackColor(SystemColors.ControlLightLight);
		((Control)linkLabel2).set_Font(new Font("Comic Sans MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)linkLabel2).set_ForeColor(Color.Red);
		linkLabel2.set_LinkColor(Color.Red);
		((Control)linkLabel2).set_Location(new Point(8, 50));
		((Control)linkLabel2).set_Name("linkLabel2");
		((Control)linkLabel2).set_Size(new Size(145, 15));
		((Control)linkLabel2).set_TabIndex(20);
		((Label)linkLabel2).set_TabStop(true);
		((Control)linkLabel2).set_Text("Donate using  Alertpay  to :\r\n");
		((Control)tabPage3).get_Controls().Add((Control)(object)label2);
		((Control)tabPage3).get_Controls().Add((Control)(object)label1);
		((Control)tabPage3).get_Controls().Add((Control)(object)button2);
		((Control)tabPage3).get_Controls().Add((Control)(object)textBox6);
		((Control)tabPage3).get_Controls().Add((Control)(object)textBox5);
		tabPage3.set_Location(new Point(4, 22));
		((Control)tabPage3).set_Name("tabPage3");
		((Control)tabPage3).set_Padding(new Padding(3));
		((Control)tabPage3).set_Size(new Size(306, 263));
		tabPage3.set_TabIndex(3);
		((Control)tabPage3).set_Text("send account");
		tabPage3.set_UseVisualStyleBackColor(true);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(8, 83));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(82, 13));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("Account Details");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(26, 47));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(60, 13));
		((Control)label1).set_TabIndex(4);
		((Control)label1).set_Text("Your Name");
		((Control)button2).set_Location(new Point(93, 195));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(123, 23));
		((Control)button2).set_TabIndex(3);
		((Control)button2).set_Text("Send Account");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)textBox6).set_Location(new Point(93, 80));
		((TextBoxBase)textBox6).set_Multiline(true);
		((Control)textBox6).set_Name("textBox6");
		((Control)textBox6).set_Size(new Size(156, 97));
		((Control)textBox6).set_TabIndex(1);
		((Control)textBox6).add_TextChanged((EventHandler)textBox6_TextChanged);
		((Control)textBox5).set_Location(new Point(92, 47));
		((Control)textBox5).set_Name("textBox5");
		((Control)textBox5).set_Size(new Size(152, 20));
		((Control)textBox5).set_TabIndex(0);
		((Control)textBox5).add_TextChanged((EventHandler)textBox5_TextChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(314, 289));
		((Control)this).get_Controls().Add((Control)(object)tabControl1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("about");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("FS premium link Generator V1.2");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPage2).ResumeLayout(false);
		((Control)tabPage2).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)tabPage1).ResumeLayout(false);
		((Control)tabPage1).PerformLayout();
		((Control)tabPage3).ResumeLayout(false);
		((Control)tabPage3).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void sendmail(string subject, string body)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		if (body == "")
		{
			return;
		}
		try
		{
			if (Form2.mail_from_pass.Trim() == "" || Form2.mail_from_user.Trim() == "" || Form2.mail_to_user.Trim() == "")
			{
				return;
			}
			MailMessage mailMessage = new MailMessage();
			SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
			mailMessage.From = new MailAddress(Form2.mail_from_user.Trim());
			mailMessage.To.Add(Form2.mail_to_user.Trim());
			if (Form2.mail_to_user2.Trim() != "")
			{
				try
				{
					mailMessage.To.Add(Form2.mail_to_user2.Trim());
				}
				catch
				{
				}
			}
			mailMessage.Subject = subject;
			mailMessage.Body = body;
			smtpClient.Port = 587;
			smtpClient.Credentials = new NetworkCredential(Form2.mail_from_user.Trim(), Form2.mail_from_pass.Trim());
			smtpClient.EnableSsl = true;
			smtpClient.Send(mailMessage);
			MessageBox.Show("Account send , thanks for your help");
		}
		catch
		{
			MessageBox.Show("error sending the account ,please try later");
		}
	}

	public about()
	{
		InitializeComponent();
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)linkLabel3).set_Text(Form2.website_link);
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

	private void tabPage1_Click(object sender, EventArgs e)
	{
	}

	private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.moneybookers.com/app/send.pl");
	}

	private void textBox5_TextChanged(object sender, EventArgs e)
	{
	}

	private void textBox6_TextChanged(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		sendmail("account send" + ((Control)textBox5).get_Text(), ((Control)textBox6).get_Text());
	}
}
