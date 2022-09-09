using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace hotfile_link_generator;

public class main : Form
{
	private IContainer icontainer_0 = null;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private Button button1;

	private TextBox textBox1;

	private TextBox textBox2;

	private Label label1;

	private ProgressBar progressBar1;

	private NotifyIcon notifyIcon_0;

	private Button button2;

	private WebBrowser webBrowser1;

	private LinkLabel linkLabel1;

	private Timer timer_0;

	private LinkLabel linkLabel2;

	private Label label2;

	private Label label3;

	private Label hjtlpAbLi;

	private Button button3;

	private Button button4;

	private GroupBox groupBox1;

	private TextBox textBox3;

	private Button button5;

	private Button button6;

	private Class0 class0_0 = new Class0();

	public static string adf_link_to_use;

	public static string value_to_use;

	private Random random_0;

	private code[] code_0;

	private bool bool_0 = true;

	private string[] string_0;

	private string[] string_1;

	private Thread thread_0;

	private Thread fpPxtYnouw;

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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected O, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected O, but got Unknown
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected O, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Expected O, but got Unknown
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected O, but got Unknown
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected O, but got Unknown
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected O, but got Unknown
		//IL_0d58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d62: Expected O, but got Unknown
		//IL_0d75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7f: Expected O, but got Unknown
		//IL_0da4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dae: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(main));
		button1 = new Button();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		label1 = new Label();
		progressBar1 = new ProgressBar();
		notifyIcon_0 = new NotifyIcon(icontainer_0);
		button2 = new Button();
		webBrowser1 = new WebBrowser();
		linkLabel1 = new LinkLabel();
		timer_0 = new Timer(icontainer_0);
		linkLabel2 = new LinkLabel();
		label2 = new Label();
		label3 = new Label();
		hjtlpAbLi = new Label();
		button3 = new Button();
		button4 = new Button();
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		groupBox1 = new GroupBox();
		textBox3 = new TextBox();
		button5 = new Button();
		button6 = new Button();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)groupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)button1).set_Enabled(false);
		((Control)button1).set_Location(new Point(268, 250));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(98, 31));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("Convert");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox1).set_Location(new Point(59, 143));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		textBox1.set_ScrollBars((ScrollBars)3);
		((Control)textBox1).set_Size(new Size(485, 90));
		((Control)textBox1).set_TabIndex(3);
		((TextBoxBase)textBox1).set_WordWrap(false);
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)textBox2).set_Location(new Point(58, 313));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		textBox2.set_ScrollBars((ScrollBars)3);
		((Control)textBox2).set_Size(new Size(485, 87));
		((Control)textBox2).set_TabIndex(4);
		((TextBoxBase)textBox2).set_WordWrap(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(76, 250));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(14, 15));
		((Control)label1).set_TabIndex(5);
		((Control)label1).set_Text("0");
		((Control)progressBar1).set_Location(new Point(2, 431));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(541, 24));
		((Control)progressBar1).set_TabIndex(6);
		notifyIcon_0.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon1.Icon"));
		notifyIcon_0.set_Text("notifyIcon1");
		notifyIcon_0.set_Visible(true);
		notifyIcon_0.add_MouseDoubleClick(new MouseEventHandler(notifyIcon_0_MouseDoubleClick));
		((Control)button2).set_Location(new Point(280, 290));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(67, 22));
		((Control)button2).set_TabIndex(7);
		((Control)button2).set_Text("Clear");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)webBrowser1).set_Location(new Point(113, 13));
		((Control)webBrowser1).set_MinimumSize(new Size(23, 23));
		((Control)webBrowser1).set_Name("webBrowser1");
		webBrowser1.set_ScriptErrorsSuppressed(true);
		((Control)webBrowser1).set_Size(new Size(479, 245));
		((Control)webBrowser1).set_TabIndex(8);
		((Control)webBrowser1).set_Visible(false);
		webBrowser1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted));
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		linkLabel1.set_LinkColor(Color.Red);
		((Control)linkLabel1).set_Location(new Point(96, 458));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(457, 18));
		((Control)linkLabel1).set_TabIndex(9);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("Want to find us on facebook  , make Donation  ,  send account : Clickhere ");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		timer_0.set_Enabled(true);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((Control)linkLabel2).set_AutoSize(true);
		((Control)linkLabel2).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		linkLabel2.set_LinkColor(Color.Red);
		((Control)linkLabel2).set_Location(new Point(87, 13));
		((Control)linkLabel2).set_Name("linkLabel2");
		((Control)linkLabel2).set_Size(new Size(103, 18));
		((Control)linkLabel2).set_TabIndex(10);
		((Label)linkLabel2).set_TabStop(true);
		((Control)linkLabel2).set_Text("Click me to stop");
		linkLabel2.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked));
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Comic Sans MS", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(4, 144));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(55, 16));
		((Control)label2).set_TabIndex(11);
		((Control)label2).set_Text("MU links");
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Comic Sans MS", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(-1, 306));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(61, 32));
		((Control)label3).set_TabIndex(12);
		((Control)label3).set_Text("Premium\r\n   links  :");
		((Control)hjtlpAbLi).set_AutoSize(true);
		((Control)hjtlpAbLi).set_Location(new Point(3, 250));
		((Control)hjtlpAbLi).set_Name("label4");
		((Control)hjtlpAbLi).set_Size(new Size(67, 15));
		((Control)hjtlpAbLi).set_TabIndex(13);
		((Control)hjtlpAbLi).set_Text("Link Count :");
		((Control)button3).set_Location(new Point(226, 403));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(140, 26));
		((Control)button3).set_TabIndex(14);
		((Control)button3).set_Text("Copy Premium Links");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button4).set_Location(new Point(459, 243));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(85, 38));
		((Control)button4).set_TabIndex(15);
		((Control)button4).set_Text("add your\r\n own cookies");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)pictureBox2).set_Cursor(Cursors.get_Hand());
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(2, 14));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(290, 102));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox2).add_Click((EventHandler)pictureBox2_Click);
		((Control)pictureBox1).set_Cursor(Cursors.get_Hand());
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(242, -12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(366, 153));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox3);
		((Control)groupBox1).get_Controls().Add((Control)(object)button5);
		((Control)groupBox1).set_Location(new Point(106, 243));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(155, 64));
		((Control)groupBox1).set_TabIndex(18);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("auth code");
		((Control)textBox3).set_Location(new Point(6, 15));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(138, 23));
		((Control)textBox3).set_TabIndex(16);
		((Control)button5).set_Location(new Point(36, 41));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(75, 23));
		((Control)button5).set_TabIndex(15);
		((Control)button5).set_Text("Get Code");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)button6).set_Location(new Point(459, 287));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(85, 23));
		((Control)button6).set_TabIndex(19);
		((Control)button6).set_Text("Refresh");
		((ButtonBase)button6).set_UseVisualStyleBackColor(true);
		((Control)button6).add_Click((EventHandler)button6_Click);
		((Form)this).set_AcceptButton((IButtonControl)(object)button1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 15f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(551, 479));
		((Control)this).get_Controls().Add((Control)(object)button6);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)hjtlpAbLi);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)linkLabel2);
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).set_Font(new Font("Comic Sans MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("main");
		((Control)this).set_Text("HF premium link Generator v1.4");
		((Form)this).add_FormClosing(new FormClosingEventHandler(main_FormClosing));
		((Form)this).add_Load((EventHandler)main_Load);
		((Control)this).add_Resize((EventHandler)main_Resize);
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void method_0(string string_2)
	{
		string[] array = Class1.smethod_4(string_2);
		for (int i = 0; i < array.Length; i++)
		{
			string text = "";
			string string_3 = "";
			Class1.smethod_3(array[i], ref text, ref string_3);
			switch (text)
			{
			case "URL":
				class0_0.string_1 = string_3;
				break;
			case "cookies_to_check":
				class0_0.string_4 = string_3;
				break;
			case "logedin":
				class0_0.string_2 = string_3;
				break;
			case "premium":
				class0_0.string_5 = string_3;
				break;
			case "free":
				class0_0.string_3 = string_3;
				break;
			}
		}
	}

	private string method_1(string string_2)
	{
		byte[] bytes = new byte[0];
		try
		{
			WebRequest webRequest = WebRequest.Create(string_2);
			WebResponse response = webRequest.GetResponse();
			Stream responseStream = response.GetResponseStream();
			byte[] array = new byte[1024];
			_ = response.ContentLength;
			MemoryStream memoryStream = new MemoryStream();
			while (true)
			{
				int num = responseStream.Read(array, 0, array.Length);
				Application.DoEvents();
				if (num == 0)
				{
					break;
				}
				memoryStream.Write(array, 0, num);
			}
			bytes = memoryStream.ToArray();
			responseStream.Close();
			memoryStream.Close();
		}
		catch (Exception)
		{
		}
		return Encoding.ASCII.GetString(bytes);
	}

	public main()
	{
		InitializeComponent();
	}

	public string method_2(string input)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.UTF8.GetBytes(input);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = bytes;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	private void method_3()
	{
		progressBar1.set_Maximum(((TextBoxBase)textBox1).get_Lines().Length);
		progressBar1.set_Value(0);
		string[] lines = ((TextBoxBase)textBox1).get_Lines();
		for (int i = 0; i < lines.Length; i++)
		{
			progressBar1.set_Maximum(((TextBoxBase)textBox1).get_Lines().Length);
			progressBar1.set_Value(i + 1);
			if (lines[i] == "" || !lines[i].Contains("http://"))
			{
				continue;
			}
			string text = "";
			if (add_cookies.cookie != "")
			{
				text = method_8("PHPSESSID=" + add_cookies.cookie, lines[i]);
			}
			else if (Form2.cookie != "")
			{
				for (int j = 0; j < string_0.Length; j++)
				{
					text = method_8("PHPSESSID=" + string_0[j], lines[i]);
					if (text != lines[i])
					{
						break;
					}
				}
				if (text == lines[i] && string_1 != null)
				{
					text = method_6(string_1, lines[i]);
				}
			}
			else if (string_1 != null)
			{
				text = method_6(string_1, lines[i]);
			}
			if (text == lines[i])
			{
				text = "Account is dead OR Your link is deleted";
			}
			TextBox obj = textBox2;
			((Control)obj).set_Text(((Control)obj).get_Text() + text + "\r\n");
		}
		if (Form2.use_auth_code)
		{
			((Control)button1).set_Enabled(false);
		}
		((Control)button1).set_Text("Convert");
		notifyIcon_0.set_BalloonTipTitle("");
		notifyIcon_0.set_BalloonTipText("Done....");
		notifyIcon_0.ShowBalloonTip(5000);
		try
		{
			thread_0.Abort();
		}
		catch
		{
		}
	}

	private void method_4()
	{
		try
		{
			webBrowser1.Navigate(Form2.adf_link2);
			Thread.Sleep(15000);
		}
		catch
		{
		}
		try
		{
			webBrowser1.Navigate(Form2.adf_link3);
			Thread.Sleep(15000);
		}
		catch
		{
		}
		try
		{
			webBrowser1.Navigate(Form2.adf_link);
			Thread.Sleep(15000);
		}
		catch
		{
		}
		try
		{
			webBrowser1.Navigate("");
		}
		catch
		{
		}
		try
		{
			fpPxtYnouw.Abort();
		}
		catch
		{
		}
	}

	private void method_5()
	{
		string text = method_1(Form2.codes_control_link);
		text = Class1.smethod_12(text, "<ahmed>", "</ahmed>");
		text = text.Replace("<div>", "");
		text = text.Replace("</div>", "");
		text = text.Replace("<br />", "\r\n");
		for (int i = 0; i < 5; i++)
		{
			text = text.Replace("\r\n\r\n", "\r\n");
		}
		code_0 = new code[int.Parse(Class1.smethod_13(ref text, "\r\n"))];
		string text2 = Class1.smethod_13(ref text, "</code123>");
		text2 = text2.Replace("<code123>", "");
		int num = 0;
		while (text2 != null && num < code_0.Length)
		{
			text2 = text2.Replace("\r\n<code123>", "");
			text2 = text2.Replace("<code123>", "");
			string text3 = Class1.smethod_13(ref text2, "\r\n");
			text3 = text3.Replace("link=", "");
			string text4 = text2;
			text4 = text4.Replace("value=", "");
			code_0[num] = new code(text3, text4);
			text2 = Class1.smethod_13(ref text, "</code123>");
			num++;
		}
	}

	private void main_Load(object sender, EventArgs e)
	{
		((Control)this).set_Text(Form2.program_name);
		notifyIcon_0.set_Text(Form2.program_name);
		method_0("config");
		if (Form2.use_auth_code)
		{
			method_5();
		}
		else
		{
			((Control)groupBox1).set_Visible(false);
			((Control)button1).set_Enabled(true);
		}
		random_0 = new Random();
		Control.set_CheckForIllegalCrossThreadCalls(false);
		string_0 = Class1.smethod_2(Form2.cookie, "<br />\n", bool_0: true);
		string_1 = Class1.smethod_2(Form2.accounts, "<br />\n", bool_0: true);
		thread_0 = new Thread(method_3);
		fpPxtYnouw = new Thread(method_4);
		fpPxtYnouw.Start();
	}

	private string method_6(string[] string_2, string string_3)
	{
		string text = string_3;
		if (string_2 == null)
		{
			return text;
		}
		int num = 0;
		while (true)
		{
			if (num < string_1.Length)
			{
				string string_4 = string_1[num];
				text = method_7(Class1.smethod_13(ref string_4, ":"), string_4, string_3);
				if (text != string_3)
				{
					break;
				}
				num++;
				continue;
			}
			return text;
		}
		return text;
	}

	private string method_7(string string_2, string string_3, string string_4)
	{
		WebRequest webRequest = WebRequest.Create(string_4);
		string s = string_2 + ":" + string_3;
		CredentialCache credentialCache = new CredentialCache();
		credentialCache.Add(new Uri(string_4), "Basic", new NetworkCredential(string_2, string_3));
		webRequest.Credentials = credentialCache;
		webRequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes(s)));
		try
		{
			WebResponse response = webRequest.GetResponse();
			Uri responseUri = response.ResponseUri;
			return responseUri.AbsoluteUri;
		}
		catch
		{
			return "error";
		}
	}

	private string method_8(string string_2, string string_3)
	{
		WebRequest webRequest = WebRequest.Create(string_3);
		webRequest.Headers.Add("Cookie", string_2);
		string text = "";
		try
		{
			WebResponse response = webRequest.GetResponse();
			Uri responseUri = response.ResponseUri;
			return responseUri.AbsoluteUri;
		}
		catch
		{
			return "error";
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (Form2.use_auth_code && ((Control)textBox3).get_Text().Trim() == "")
		{
			MessageBox.Show("a link will open , get the code from it and post it here \r\n example 'klijuhgtyf'");
		}
		else if (Form2.use_auth_code && ((Control)textBox3).get_Text().Trim() != value_to_use)
		{
			MessageBox.Show("worng code");
			((Control)button1).set_Enabled(false);
		}
		else if (((Control)button1).get_Text() == "Convert")
		{
			((Control)textBox2).set_Text("");
			thread_0 = new Thread(method_3);
			thread_0.Start();
			((Control)button1).set_Text("Stop");
		}
		else if (((Control)button1).get_Text() == "Stop")
		{
			thread_0.Abort();
			((Control)button1).set_Text("Convert");
			if (Form2.use_auth_code)
			{
				((Control)button1).set_Enabled(false);
			}
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		((Control)label1).set_Text(((TextBoxBase)textBox1).get_Lines().Length.ToString());
	}

	private void notifyIcon_0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		((Control)this).Show();
		((Form)this).set_WindowState((FormWindowState)0);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		TextBox obj = textBox1;
		string text;
		((Control)textBox2).set_Text(text = "");
		((Control)obj).set_Text(text);
		progressBar1.set_Value(progressBar1.get_Maximum());
	}

	private void main_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			fpPxtYnouw.Abort();
		}
		catch
		{
		}
		Application.Exit();
	}

	private void pictureBox2_Click(object sender, EventArgs e)
	{
		((Control)linkLabel2).set_Visible(false);
		timer_0.set_Enabled(false);
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
		try
		{
			Process.Start(Form2.website_link);
		}
		catch
		{
		}
	}

	private void main_Resize(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Form)this).get_WindowState() == 1)
		{
			((Control)this).Hide();
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		about about2 = new about();
		((Control)about2).Show();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (bool_0)
		{
			((Control)linkLabel2).set_Visible(true);
			PictureBox obj = pictureBox2;
			((Control)obj).set_Width(((Control)obj).get_Width() - 10);
			PictureBox obj2 = pictureBox2;
			((Control)obj2).set_Height(((Control)obj2).get_Height() - 10);
			bool_0 = false;
		}
		else
		{
			((Control)linkLabel2).set_Visible(false);
			PictureBox obj3 = pictureBox2;
			((Control)obj3).set_Width(((Control)obj3).get_Width() + 10);
			PictureBox obj4 = pictureBox2;
			((Control)obj4).set_Height(((Control)obj4).get_Height() + 10);
			bool_0 = true;
		}
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		pictureBox2_Click(null, null);
	}

	private void method_9(object sender, CancelEventArgs e)
	{
	}

	private void button3_Click(object sender, EventArgs e)
	{
		try
		{
			Clipboard.SetText(((Control)textBox2).get_Text());
		}
		catch
		{
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
		add_cookies add_cookies2 = new add_cookies();
		((Control)add_cookies2).Show();
	}

	private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
	}

	private void button5_Click(object sender, EventArgs e)
	{
		((Control)textBox3).set_Text("");
		int num = random_0.Next(0, code_0.Length - 1);
		adf_link_to_use = code_0[num].link;
		value_to_use = code_0[num].value;
		((Control)button1).set_Enabled(true);
		Process.Start(adf_link_to_use);
	}

	private void button6_Click(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("the program may be stop working while updating");
		method_11(Form2.control_link);
		MessageBox.Show("update complete");
	}

	private bool method_10(string string_2)
	{
		Class0 @class = class0_0;
		string value = @class.string_4 + string_2;
		WebRequest webRequest = WebRequest.Create(@class.string_1);
		webRequest.Headers.Add("Cookie", value);
		WebResponse response;
		try
		{
			response = webRequest.GetResponse();
		}
		catch
		{
			return false;
		}
		string text;
		using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
		{
			text = streamReader.ReadToEnd();
		}
		if (text.Contains(@class.string_2) && (text.Contains(@class.string_5) || !text.Contains(@class.string_3)))
		{
			return true;
		}
		return false;
	}

	private void method_11(string string_2)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		string text = method_1(Form2.control_link);
		text = Class1.smethod_12(text, "<ahmed>", "</ahmed>");
		if (!text.Contains("start this program"))
		{
			string text2 = Class1.smethod_12(text, "show this link:", "endoflink");
			if (text2 == "")
			{
				MessageBox.Show("this program will close now , restart it ");
				Application.Exit();
			}
			DialogResult val = MessageBox.Show("there is a NEW update for this program \r\n download this update ?? \r\n if press NO the program will exit  ", "update", (MessageBoxButtons)4);
			if ((int)val == 6)
			{
				Process.Start(text2);
				Application.Exit();
			}
			else
			{
				Application.Exit();
			}
		}
		Form2.cookie = Class1.smethod_12(text, "<cookie>", "</cookie>");
		string_0 = Class1.smethod_2(Form2.cookie, "<br />\n", bool_0: true);
		Form2.accounts = Class1.smethod_12(text, "<ac>", "</ac>");
		string_1 = Class1.smethod_2(Form2.accounts, "<br />\n", bool_0: true);
		string text3 = Class1.smethod_12(text, "<auth>", "</auth>");
		if (text3 == "yes")
		{
			Form2.use_auth_code = true;
			((Control)groupBox1).set_Visible(true);
			((Control)button1).set_Enabled(false);
		}
		else
		{
			Form2.use_auth_code = false;
			((Control)groupBox1).set_Visible(false);
			((Control)button1).set_Enabled(true);
		}
	}

	private void method_12()
	{
		if (add_cookies.cookie != "" && method_10(add_cookies.cookie))
		{
			return;
		}
		int num = 0;
		while (string_0 != null && num < string_0.Length)
		{
			if (!method_10(string_0[num]))
			{
				num++;
				continue;
			}
			string text = string_0[num];
			string_0[num] = string_0[0];
			string_0[0] = text;
			break;
		}
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	static main()
	{
		adf_link_to_use = "";
		value_to_use = "";
	}
}
