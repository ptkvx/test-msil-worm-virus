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
using hotfile_link_generator.Properties;

namespace hotfile_link_generator;

public class main : Form
{
	public static string adf_link_to_use = "";

	public static string value_to_use = "";

	private Random random;

	private code[] codes;

	private bool habl = true;

	private Thread convert_th;

	private Thread adf_th;

	private IContainer components = null;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private Button button1;

	private TextBox textBox1;

	private TextBox textBox2;

	private Label label1;

	private ProgressBar progressBar1;

	private NotifyIcon notifyIcon1;

	private Button button2;

	private WebBrowser webBrowser1;

	private LinkLabel linkLabel1;

	private Timer timer1;

	private LinkLabel linkLabel2;

	private Label label2;

	private Label label3;

	private Label label4;

	private Button button3;

	private Button button4;

	private TextBox textBox3;

	private GroupBox groupBox1;

	private string DownloadData(string url)
	{
		byte[] bytes = new byte[0];
		try
		{
			WebRequest webRequest = WebRequest.Create(url);
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

	private void readcodes()
	{
		string text = DownloadData("http://livecookiescodes.blogspot.com/2011/03/control.html");
		text = myfn2.stringpart(text, "<ahmed>", "</ahmed>");
		text = text.Replace("<div>", "");
		text = text.Replace("</div>", "");
		text = text.Replace("<br />", "\r\n");
		for (int i = 0; i < 5; i++)
		{
			text = text.Replace("\r\n\r\n", "\r\n");
		}
		codes = new code[int.Parse(myfn2.cut_this(ref text, "\r\n"))];
		string text2 = myfn2.cut_this(ref text, "</code123>");
		text2 = text2.Replace("<code123>", "");
		int num = 0;
		while (text2 != null && num < codes.Length)
		{
			text2 = text2.Replace("\r\n<code123>", "");
			text2 = text2.Replace("<code123>", "");
			string text3 = myfn2.cut_this(ref text2, "\r\n");
			text3 = text3.Replace("link=", "");
			string text4 = text2;
			text4 = text4.Replace("value=", "");
			codes[num] = new code(text3, text4);
			text2 = myfn2.cut_this(ref text, "</code123>");
			num++;
		}
	}

	public main()
	{
		InitializeComponent();
	}

	public string GetMD5Hash(string input)
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

	private void convert()
	{
		progressBar1.set_Maximum(((TextBoxBase)textBox1).get_Lines().Length);
		progressBar1.set_Value(0);
		string[] lines = ((TextBoxBase)textBox1).get_Lines();
		for (int i = 0; i < lines.Length; i++)
		{
			progressBar1.set_Maximum(((TextBoxBase)textBox1).get_Lines().Length);
			progressBar1.set_Value(i + 1);
			if (!(lines[i] == "") && lines[i].Contains("http://"))
			{
				string text = Get_direct_link(Form2.hf_user, Form2.hf_pass, lines[i]);
				TextBox obj = textBox2;
				((Control)obj).set_Text(((Control)obj).get_Text() + text + "\r\n");
			}
		}
		((Control)button1).set_Text("Convert");
		if (Form2.use_auth_code)
		{
			((Control)button1).set_Enabled(false);
		}
		notifyIcon1.set_BalloonTipTitle("");
		notifyIcon1.set_BalloonTipText("Done....");
		notifyIcon1.ShowBalloonTip(5000);
		try
		{
			convert_th.Abort();
		}
		catch
		{
		}
	}

	private void adf()
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
			adf_th.Abort();
		}
		catch
		{
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		if (Form2.use_auth_code)
		{
			readcodes();
		}
		else
		{
			((Control)groupBox1).set_Visible(false);
			((Control)button1).set_Enabled(true);
		}
		random = new Random();
		notifyIcon1.set_Text("FS premium link Generator");
		Control.set_CheckForIllegalCrossThreadCalls(false);
		convert_th = new Thread(convert);
		adf_th = new Thread(adf);
		adf_th.Start();
	}

	private string Get_direct_link(string username, string password, string url)
	{
		WebRequest webRequest = WebRequest.Create(url);
		string s = username + ":" + password;
		CredentialCache credentialCache = new CredentialCache();
		credentialCache.Add(new Uri(url), "Basic", new NetworkCredential(username, password));
		webRequest.Credentials = credentialCache;
		webRequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes(s)));
		try
		{
			WebResponse response = webRequest.GetResponse();
			Uri responseUri = response.ResponseUri;
			string absoluteUri = responseUri.AbsoluteUri;
			if (absoluteUri == url)
			{
				return "acount is dead OR Your link deleted";
			}
			return absoluteUri;
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
			convert_th = new Thread(convert);
			convert_th.Start();
			((Control)button1).set_Text("Stop");
		}
		else if (((Control)button1).get_Text() == "Stop")
		{
			convert_th.Abort();
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

	private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
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
			adf_th.Abort();
		}
		catch
		{
		}
		Application.Exit();
	}

	private void pictureBox2_Click(object sender, EventArgs e)
	{
		((Control)linkLabel2).set_Visible(false);
		timer1.set_Enabled(false);
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

	private void timer1_Tick(object sender, EventArgs e)
	{
		if (habl)
		{
			((Control)linkLabel2).set_Visible(true);
			PictureBox obj = pictureBox2;
			((Control)obj).set_Width(((Control)obj).get_Width() - 10);
			PictureBox obj2 = pictureBox2;
			((Control)obj2).set_Height(((Control)obj2).get_Height() - 10);
			habl = false;
		}
		else
		{
			((Control)linkLabel2).set_Visible(false);
			PictureBox obj3 = pictureBox2;
			((Control)obj3).set_Width(((Control)obj3).get_Width() + 10);
			PictureBox obj4 = pictureBox2;
			((Control)obj4).set_Height(((Control)obj4).get_Height() + 10);
			habl = true;
		}
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		pictureBox2_Click(null, null);
	}

	private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
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

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void button4_Click(object sender, EventArgs e)
	{
		((Control)textBox3).set_Text("");
		int num = random.Next(0, codes.Length - 1);
		adf_link_to_use = codes[num].link;
		value_to_use = codes[num].value;
		((Control)button1).set_Enabled(true);
		Process.Start(adf_link_to_use);
	}

	private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
	}

	private void groupBox1_Enter(object sender, EventArgs e)
	{
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
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected O, but got Unknown
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected O, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected O, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected O, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected O, but got Unknown
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected O, but got Unknown
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c35: Expected O, but got Unknown
		//IL_0c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c52: Expected O, but got Unknown
		//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c81: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(main));
		button1 = new Button();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		label1 = new Label();
		progressBar1 = new ProgressBar();
		notifyIcon1 = new NotifyIcon(components);
		button2 = new Button();
		webBrowser1 = new WebBrowser();
		linkLabel1 = new LinkLabel();
		timer1 = new Timer(components);
		linkLabel2 = new LinkLabel();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		button3 = new Button();
		pictureBox1 = new PictureBox();
		pictureBox2 = new PictureBox();
		button4 = new Button();
		textBox3 = new TextBox();
		groupBox1 = new GroupBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)groupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)button1).set_Enabled(false);
		((Control)button1).set_Location(new Point(260, 250));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(135, 28));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("Convert");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox1).set_Location(new Point(58, 147));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		textBox1.set_ScrollBars((ScrollBars)3);
		((Control)textBox1).set_Size(new Size(524, 97));
		((Control)textBox1).set_TabIndex(3);
		((TextBoxBase)textBox1).set_WordWrap(false);
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)textBox2).set_Location(new Point(58, 312));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		textBox2.set_ScrollBars((ScrollBars)3);
		((Control)textBox2).set_Size(new Size(524, 113));
		((Control)textBox2).set_TabIndex(4);
		((TextBoxBase)textBox2).set_WordWrap(false);
		((Control)textBox2).add_TextChanged((EventHandler)textBox2_TextChanged);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(72, 251));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(14, 15));
		((Control)label1).set_TabIndex(5);
		((Control)label1).set_Text("0");
		((Control)progressBar1).set_Location(new Point(0, 457));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(602, 24));
		((Control)progressBar1).set_TabIndex(6);
		notifyIcon1.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon1.Icon"));
		notifyIcon1.set_Text("notifyIcon1");
		notifyIcon1.set_Visible(true);
		notifyIcon1.add_MouseDoubleClick(new MouseEventHandler(notifyIcon1_MouseDoubleClick));
		((Control)button2).set_Location(new Point(289, 283));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(70, 22));
		((Control)button2).set_TabIndex(7);
		((Control)button2).set_Text("Clear");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)webBrowser1).set_Location(new Point(151, 13));
		((Control)webBrowser1).set_MinimumSize(new Size(23, 23));
		((Control)webBrowser1).set_Name("webBrowser1");
		webBrowser1.set_ScriptErrorsSuppressed(true);
		((Control)webBrowser1).set_Size(new Size(441, 169));
		((Control)webBrowser1).set_TabIndex(8);
		((Control)webBrowser1).set_Visible(false);
		webBrowser1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted));
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		linkLabel1.set_LinkColor(Color.Red);
		((Control)linkLabel1).set_Location(new Point(96, 484));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(457, 18));
		((Control)linkLabel1).set_TabIndex(9);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("Want to find us on facebook  , make Donation  ,  send account : Clickhere ");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		timer1.set_Enabled(true);
		timer1.add_Tick((EventHandler)timer1_Tick);
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
		((Control)label2).set_Location(new Point(8, 150));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(54, 32));
		((Control)label2).set_TabIndex(11);
		((Control)label2).set_Text("Fileserve\r\n Links:");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Comic Sans MS", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(1, 336));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(61, 32));
		((Control)label3).set_TabIndex(12);
		((Control)label3).set_Text("Premium\r\n   links  :");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(-1, 251));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(67, 15));
		((Control)label4).set_TabIndex(13);
		((Control)label4).set_Text("Link Count :");
		((Control)button3).set_Location(new Point(236, 425));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(140, 26));
		((Control)button3).set_TabIndex(14);
		((Control)button3).set_Text("Copy Premium Links");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)pictureBox1).set_Cursor(Cursors.get_Hand());
		pictureBox1.set_Image((Image)(object)Resources.fileserves);
		((Control)pictureBox1).set_Location(new Point(302, -8));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(331, 169));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((Control)pictureBox2).set_Cursor(Cursors.get_Hand());
		pictureBox2.set_Image((Image)(object)Resources._111);
		((Control)pictureBox2).set_Location(new Point(2, 14));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(327, 127));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox2).add_Click((EventHandler)pictureBox2_Click);
		((Control)button4).set_Location(new Point(36, 41));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(75, 23));
		((Control)button4).set_TabIndex(15);
		((Control)button4).set_Text("Get Code");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)textBox3).set_Location(new Point(6, 15));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(138, 23));
		((Control)textBox3).set_TabIndex(16);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox3);
		((Control)groupBox1).get_Controls().Add((Control)(object)button4);
		((Control)groupBox1).set_Location(new Point(99, 242));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(155, 64));
		((Control)groupBox1).set_TabIndex(17);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("auth code");
		((Control)groupBox1).add_Enter((EventHandler)groupBox1_Enter);
		((Form)this).set_AcceptButton((IButtonControl)(object)button1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 15f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(614, 511));
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label4);
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
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).set_Font(new Font("Comic Sans MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("main");
		((Control)this).set_Text("FS premium link Generator V1.2");
		((Form)this).add_FormClosing(new FormClosingEventHandler(main_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_Resize((EventHandler)main_Resize);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
