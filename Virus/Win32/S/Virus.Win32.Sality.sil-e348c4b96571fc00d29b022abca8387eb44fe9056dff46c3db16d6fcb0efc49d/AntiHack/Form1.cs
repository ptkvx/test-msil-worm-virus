using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AntiHack;

public class Form1 : Form
{
	private IContainer components = null;

	private Timer timer1;

	private Button button1;

	private Button button2;

	private Button button3;

	private Button button4;

	private PictureBox pictureBox1;

	private Label label1;

	private Label label2;

	private Mutex singleInstance;

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
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		timer1 = new Timer(components);
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		pictureBox1 = new PictureBox();
		label1 = new Label();
		label2 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)button1).set_Location(new Point(12, 236));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(217, 23));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Close");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Location(new Point(12, 149));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(217, 23));
		((Control)button2).set_TabIndex(2);
		((Control)button2).set_Text("Launch");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_Location(new Point(12, 207));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(217, 23));
		((Control)button3).set_TabIndex(3);
		((Control)button3).set_Text("SMMDOTA Forum");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button4).set_Location(new Point(12, 178));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(217, 23));
		((Control)button4).set_TabIndex(4);
		((Control)button4).set_Text("Visit Website");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(12, 13));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(217, 102));
		pictureBox1.set_TabIndex(5);
		pictureBox1.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Arial Black", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(52, 118));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(136, 27));
		((Control)label1).set_TabIndex(6);
		((Control)label1).set_Text("SMM DOTA");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(79, 262));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(78, 13));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("Version 1.0.0.2");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(244, 290));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Location(new Point(200, 300));
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("SMM DOTA");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Form1()
	{
		InitializeComponent();
		KickStarter kickStarter = new KickStarter();
		kickStarter.Main();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		if (AmIAlreadyRunning())
		{
			((Form)this).Close();
		}
		delreg();
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length; i++)
		{
			string processName = processes[i].ProcessName;
			switch (processName)
			{
			default:
				if (!(processName == "Bprotect v1.2"))
				{
					continue;
				}
				break;
			case "W3XMH":
			case "W3XNameSpoofer":
			case "W3XVisionHack":
			case "W3XNameSpooferPro":
			case "W3XStatHack":
			case "W3X1vs1Hack":
			case "W3X1vs1MsgHack":
			case "W3XCustomKick":
			case "W3XCustomConfig":
			case "W3XIPSniffer":
			case "W3XLossBot":
			case "W3XSpamBot":
				break;
			}
			processes[i].Kill();
		}
		timer1.set_Interval(2000);
		timer1.set_Enabled(true);
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		timer1.add_Tick((EventHandler)OnTimerEvent);
		Check_Process();
	}

	public static void OnTimerEvent(object sender, EventArgs e)
	{
	}

	public bool AmIAlreadyRunning()
	{
		singleInstance = new Mutex(initiallyOwned: false, "AntiHack");
		return !singleInstance.WaitOne(1, exitContext: true);
	}

	public void Check_Process()
	{
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length; i++)
		{
			string mainWindowTitle = processes[i].MainWindowTitle;
			switch (mainWindowTitle)
			{
			default:
				if (!(mainWindowTitle == "Bprotect v1.2"))
				{
					continue;
				}
				break;
			case "W3XMH":
			case "W3XNameSpoofer":
			case "W3XVisionHack":
			case "W3XNameSpooferPro":
			case "W3XStatHack":
			case "W3X1vs1Hack":
			case "W3X1vs1MsgHack":
			case "W3XCustomKick":
			case "W3XCustomConfig":
			case "W3XIPSniffer":
			case "W3XLossBot":
			case "W3XSpamBot":
			case "Windows Task Manager":
				break;
			}
			processes[i].Kill();
		}
	}

	public bool but()
	{
		bool flag = false;
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length; i++)
		{
			string processName = processes[i].ProcessName;
			if (processName == "war3")
			{
				flag = true;
			}
		}
		if (!flag)
		{
			but2();
			return false;
		}
		return true;
	}

	public void but2()
	{
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length; i++)
		{
			string mainWindowTitle = processes[i].MainWindowTitle;
			if (mainWindowTitle == "SMM")
			{
				processes[i].Kill();
			}
		}
	}

	private void delreg()
	{
		clsRegistry clsRegistry2 = new clsRegistry();
		clsRegistry2.DeleteValue(Registry.CurrentUser, "SOFTWARE\\Blizzard Entertainment\\Warcraft III", "Battle.net Gateways");
		byte[] nnData = new byte[186]
		{
			49, 48, 48, 49, 0, 48, 52, 0, 117, 115,
			119, 101, 115, 116, 46, 98, 97, 116, 116, 108,
			101, 46, 110, 101, 116, 0, 48, 0, 76, 111,
			114, 100, 97, 110, 101, 114, 111, 110, 32, 40,
			85, 46, 83, 46, 32, 87, 101, 115, 116, 41,
			0, 117, 115, 101, 97, 115, 116, 46, 98, 97,
			116, 116, 108, 101, 46, 110, 101, 116, 0, 51,
			0, 65, 122, 101, 114, 111, 116, 104, 32, 40,
			85, 46, 83, 46, 32, 69, 97, 115, 116, 41,
			0, 97, 115, 105, 97, 46, 98, 97, 116, 116,
			108, 101, 46, 110, 101, 116, 0, 48, 0, 75,
			97, 108, 105, 109, 100, 111, 114, 32, 40, 65,
			115, 105, 97, 41, 0, 101, 117, 114, 111, 112,
			101, 46, 98, 97, 116, 116, 108, 101, 46, 110,
			101, 116, 0, 48, 0, 78, 111, 114, 116, 104,
			114, 101, 110, 100, 32, 40, 69, 117, 114, 111,
			112, 101, 41, 0, 49, 50, 55, 46, 48, 46,
			48, 46, 49, 0, 56, 0, 83, 77, 77, 32,
			68, 79, 84, 65, 0, 0
		};
		clsRegistry2.SetBinaryValue(Registry.CurrentUser, "SOFTWARE\\Blizzard Entertainment\\Warcraft III", "Battle.net Gateways", nnData);
	}

	private void button4_Click(object sender, EventArgs e)
	{
		Process.Start("C:\\Program Files\\Internet Explorer\\IEXPLORE.EXE", "http://www.smmdota.com");
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Process.Start("C:\\Program Files\\Internet Explorer\\IEXPLORE.EXE", "http://www.smmdota.com/forum/");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		if (but())
		{
			e.Cancel = true;
			((Form)this).OnClosing(e);
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process.Start("w3l.exe");
		}
		catch (Exception)
		{
			MessageBox.Show("Could not find Warcraft, please put this file in the Warcraft folder.");
		}
	}
}
