using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace hotfile_link_generator;

public class Form2 : Form
{
	public static string program_name;

	public static string control_link;

	public static string codes_control_link;

	private Thread thread_0;

	public string update_link;

	private int int_0;

	public static string img1;

	public static string img2;

	public static string img3;

	public static string img4;

	public static string img5;

	public static string img6;

	public static string link1;

	public static string link2;

	public static string link3;

	public static string link4;

	public static string link5;

	public static string link6;

	public static string force_start_link;

	public static string mail_from_user;

	public static string mail_from_pass;

	public static string mail_to_user;

	public static string mail_to_user2;

	public static string mail_from_user2;

	public static string mail_from_pass2;

	public static string website_link;

	public static string adf_link;

	public static string adf_link2;

	public static string adf_link3;

	public static string hf_user;

	public static string hf_pass;

	public static string cookie;

	public static bool use_auth_code;

	public static string accounts;

	public bool auto_start = false;

	public int count_down = 10;

	private IContainer icontainer_0;

	private TextBox textBox1;

	private Timer timer_0;

	private Button button1;

	private WebBrowser webBrowser1;

	private LinkLabel linkLabel1;

	private Button about;

	private LinkLabel linkLabel2;

	private string method_0(string string_0)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		byte[] bytes = new byte[0];
		try
		{
			WebRequest webRequest = WebRequest.Create(string_0);
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
			MessageBox.Show("you need to be connected to the net so u can use this program");
		}
		return Encoding.ASCII.GetString(bytes);
	}

	private void method_1()
	{
		Thread.Sleep(15000);
		try
		{
			webBrowser1.Navigate("");
		}
		catch
		{
		}
	}

	public static string secu_coder(string str_to_enc, int k)
	{
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		byte[] bytes = aSCIIEncoding.GetBytes(str_to_enc);
		byte[] array = new byte[bytes.Length];
		string text = "";
		for (int i = 0; i < bytes.Length; i++)
		{
			array[i] = Convert.ToByte(bytes[i] ^ Convert.ToByte(k));
			text += Convert.ToChar(array[i]);
		}
		return text;
	}

	private string method_2(string string_0)
	{
		string text = "";
		for (int i = 0; i < string_0.Length; i++)
		{
			text = text + (string_0[i] + 7) * 3 + " ";
		}
		return text;
	}

	public static string dexor2(string x)
	{
		string text = "";
		try
		{
			for (string text2 = Class1.smethod_13(ref x, " "); text2 != null; text2 = Class1.smethod_13(ref x, " "))
			{
				int num = int.Parse(text2);
				num = num / 3 - 7;
				text += (char)num;
			}
		}
		catch
		{
		}
		return text;
	}

	public void auth()
	{
		((Control)button1).set_Enabled(false);
		string string_ = method_0(control_link);
		string_ = Class1.smethod_12(string_, "<ahmed>", "</ahmed>");
		int_0 = string_.IndexOf("start this program");
		int num = string_.IndexOf("show this msg:");
		string text = "";
		if (num != -1)
		{
			int num2 = string_.IndexOf("endofmsg");
			text = string_.Substring(num + 14, num2 - (num + 14));
			num = string_.IndexOf("show this msg2:");
			if (num != -1)
			{
				num2 = string_.IndexOf("endofmsg2");
				string text2 = string_.Substring(num + 15, num2 - (num + 15));
				num = string_.IndexOf("show this link:");
				if (num != -1)
				{
					num2 = string_.IndexOf("endoflink");
					update_link = string_.Substring(num + 15, num2 - (num + 15));
					((Control)linkLabel1).set_Visible(true);
				}
				text = text + '\r' + '\n' + text2;
			}
		}
		website_link = Class1.smethod_12(string_, "<website_link>", "</website_link>");
		adf_link = Class1.smethod_12(string_, "<adf_link>", "</adf_link>");
		adf_link2 = Class1.smethod_12(string_, "<adf_link2>", "</adf_link2>");
		adf_link3 = Class1.smethod_12(string_, "<adf_link3>", "</adf_link3>");
		string text3 = Class1.smethod_12(string_, "<codes_control_link>", "</codes_control_link>");
		if (text3 != "")
		{
			codes_control_link = text3;
		}
		accounts = Class1.smethod_12(string_, "<ac>", "</ac>");
		cookie = Class1.smethod_12(string_, "<cookie>", "</cookie>");
		force_start_link = Class1.smethod_12(string_, "<forcelink>", "</forcelink>");
		string text4 = Class1.smethod_12(string_, "<auth>", "</auth>");
		if (text4 == "yes")
		{
			use_auth_code = true;
		}
		else
		{
			use_auth_code = false;
		}
		try
		{
			((Control)linkLabel2).set_Text(website_link);
		}
		catch
		{
		}
		if (force_start_link.Trim() != "")
		{
			try
			{
				Process.Start(force_start_link);
			}
			catch
			{
			}
		}
		if (int_0 == -1)
		{
			((Control)button1).set_Enabled(false);
			auto_start = false;
		}
		else
		{
			((Control)button1).set_Enabled(true);
			auto_start = string_.Contains("auto_start_program");
		}
		((Control)textBox1).set_Text(text + "\r\n");
		if (auto_start)
		{
			TextBox obj3 = textBox1;
			((Control)obj3).set_Text(((Control)obj3).get_Text() + "auto open in ");
		}
		if (adf_link.Trim() != "")
		{
			try
			{
				webBrowser1.Navigate(adf_link);
			}
			catch
			{
			}
			Thread thread = new Thread(method_1);
			thread.Start();
		}
	}

	public Form2()
	{
		InitializeComponent();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		((Control)this).set_Text(program_name);
		((Control)button1).set_Enabled(false);
		((Control)linkLabel1).set_Visible(false);
		Control.set_CheckForIllegalCrossThreadCalls(false);
		timer_0.set_Enabled(true);
		thread_0 = new Thread(auth);
		thread_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (((Control)textBox1).get_Text() == "please wait.")
		{
			((Control)textBox1).set_Text("please wait..");
		}
		else if (((Control)textBox1).get_Text() == "please wait..")
		{
			((Control)textBox1).set_Text("please wait...");
		}
		else if (((Control)textBox1).get_Text() == "please wait...")
		{
			((Control)textBox1).set_Text("please wait....");
		}
		else if (((Control)textBox1).get_Text() == "please wait....")
		{
			((Control)textBox1).set_Text("please wait.");
		}
		if (auto_start)
		{
			TextBox obj = textBox1;
			((Control)obj).set_Text(((Control)obj).get_Text() + count_down-- + "  ");
			if (count_down < 0)
			{
				button1_Click(null, null);
				timer_0.set_Enabled(false);
			}
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (int_0 != -1)
		{
			((Control)this).Hide();
			main main2 = new main();
			auto_start = false;
			timer_0.set_Enabled(false);
			((Control)main2).Show();
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (update_link != null)
		{
			Process.Start(update_link);
		}
	}

	private void about_Click(object sender, EventArgs e)
	{
		about about2 = new about();
		((Control)about2).Show();
	}

	private void method_3(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start(website_link);
		}
		catch
		{
		}
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start(website_link);
		}
		catch
		{
		}
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		Application.Exit();
		try
		{
			thread_0.Abort();
		}
		catch
		{
		}
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
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
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected O, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		textBox1 = new TextBox();
		timer_0 = new Timer(icontainer_0);
		button1 = new Button();
		webBrowser1 = new WebBrowser();
		linkLabel1 = new LinkLabel();
		about = new Button();
		linkLabel2 = new LinkLabel();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(11, 12));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		textBox1.set_ScrollBars((ScrollBars)3);
		((Control)textBox1).set_Size(new Size(274, 89));
		((Control)textBox1).set_TabIndex(0);
		((Control)textBox1).set_Text("please wait.");
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		timer_0.set_Interval(500);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((Control)button1).set_Location(new Point(25, 128));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(136, 30));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Enter");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)webBrowser1).set_Location(new Point(24, 12));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		webBrowser1.set_ScriptErrorsSuppressed(true);
		((Control)webBrowser1).set_Size(new Size(225, 105));
		((Control)webBrowser1).set_TabIndex(2);
		webBrowser1.set_Url(new Uri("", UriKind.Relative));
		((Control)webBrowser1).set_Visible(false);
		webBrowser1.set_WebBrowserShortcutsEnabled(false);
		webBrowser1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted));
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Font(new Font("Comic Sans MS", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)linkLabel1).set_Location(new Point(36, 99));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(204, 26));
		((Control)linkLabel1).set_TabIndex(12);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("press here for update");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((Control)about).set_Location(new Point(177, 133));
		((Control)about).set_Name("about");
		((Control)about).set_Size(new Size(86, 22));
		((Control)about).set_TabIndex(14);
		((Control)about).set_Text("About");
		((ButtonBase)about).set_UseVisualStyleBackColor(true);
		((Control)about).add_Click((EventHandler)about_Click);
		((Control)linkLabel2).set_AutoSize(true);
		((Control)linkLabel2).set_ForeColor(SystemColors.ActiveCaptionText);
		linkLabel2.set_LinkColor(Color.Red);
		((Control)linkLabel2).set_Location(new Point(160, 315));
		((Control)linkLabel2).set_Name("linkLabel2");
		((Control)linkLabel2).set_Size(new Size(0, 15));
		((Control)linkLabel2).set_TabIndex(15);
		linkLabel2.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 15f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(294, 175));
		((Control)this).get_Controls().Add((Control)(object)linkLabel2);
		((Control)this).get_Controls().Add((Control)(object)about);
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).set_Font(new Font("Comic Sans MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("HF premium link Generator v1.4");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	static Form2()
	{
		program_name = "FS premium link Generator V1.3";
		control_link = "http://uleech.blogspot.com/2011/05/fsv13.html";
		codes_control_link = "http://livecookiescodes.blogspot.com/2011/03/control.html";
		img1 = "";
		img2 = "";
		img3 = "";
		img4 = "";
		img5 = "";
		img6 = "";
		link1 = "";
		link2 = "";
		link3 = "";
		link4 = "";
		link5 = "";
		link6 = "";
		force_start_link = "";
		mail_from_user = "";
		mail_from_pass = "";
		mail_to_user = "";
		mail_to_user2 = "";
		mail_from_user2 = "";
		mail_from_pass2 = "";
		website_link = "";
		adf_link = "";
		adf_link2 = "";
		adf_link3 = "";
		hf_user = "";
		hf_pass = "";
		cookie = "";
		use_auth_code = false;
		accounts = "";
	}
}
