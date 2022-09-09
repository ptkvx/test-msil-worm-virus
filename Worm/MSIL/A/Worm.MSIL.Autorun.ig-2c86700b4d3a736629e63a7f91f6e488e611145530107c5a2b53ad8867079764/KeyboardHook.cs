using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows.Forms;

public class KeyboardHook : IDisposable
{
	public enum Parameters
	{
		None,
		AllowAltTab,
		AllowWindowsKey,
		AllowAltTabAndWindows,
		PassAllKeysToNextApp
	}

	internal delegate IntPtr HookHandlerDelegate(int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);

	internal struct KBDLLHOOKSTRUCT
	{
		public int vkCode;

		private int scanCode;

		public int flags;

		private int time;

		private int dwExtraInfo;
	}

	public delegate void KeyboardHookEventHandler(KeyboardHookEventArgs e);

	public class KeyboardHookEventArgs : EventArgs
	{
		private string keyName;

		private int keyCode;

		private bool passThrough;

		public string KeyName => keyName;

		public int KeyCode => keyCode;

		public bool PassThrough => passThrough;

		public KeyboardHookEventArgs(int evtKeyCode, bool evtPassThrough)
		{
			keyName = ((object)(Keys)evtKeyCode).ToString();
			keyCode = evtKeyCode;
			passThrough = evtPassThrough;
		}
	}

	[ComVisible(false)]
	[SuppressUnmanagedCodeSecurity]
	internal class NativeMethods
	{
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr SetWindowsHookEx(int idHook, HookHandlerDelegate lpfn, IntPtr hMod, uint dwThreadId);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UnhookWindowsHookEx(IntPtr hhk);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);

		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		public static extern short GetKeyState(int keyCode);
	}

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYUP = 257;

	private const int WM_SYSKEYUP = 261;

	private const int VK_SHIFT = 16;

	private const int VK_CONTROL = 17;

	private const int VK_MENU = 18;

	private const int VK_CAPITAL = 20;

	private bool PassAllKeysToNextApp;

	private bool AllowAltTab;

	private bool AllowWindowsKey;

	private HookHandlerDelegate proc;

	private IntPtr hookID = IntPtr.Zero;

	public event KeyboardHookEventHandler KeyIntercepted;

	public KeyboardHook()
	{
		proc = HookCallback;
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		hookID = NativeMethods.SetWindowsHookEx(13, proc, NativeMethods.GetModuleHandle(processModule.ModuleName), 0u);
	}

	public KeyboardHook(string param)
		: this()
	{
		if (!string.IsNullOrEmpty(param) && Enum.IsDefined(typeof(Parameters), param))
		{
			SetParameters((Parameters)Enum.Parse(typeof(Parameters), param));
		}
	}

	public KeyboardHook(Parameters param)
		: this()
	{
		SetParameters(param);
	}

	private void SetParameters(Parameters param)
	{
		switch (param)
		{
		case Parameters.AllowAltTab:
			AllowAltTab = true;
			break;
		case Parameters.AllowWindowsKey:
			AllowWindowsKey = true;
			break;
		case Parameters.AllowAltTabAndWindows:
			AllowAltTab = true;
			AllowWindowsKey = true;
			break;
		case Parameters.PassAllKeysToNextApp:
			PassAllKeysToNextApp = true;
			break;
		case Parameters.None:
			break;
		}
	}

	private void CheckModifiers()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (((uint)NativeMethods.GetKeyState(20) & (true ? 1u : 0u)) != 0)
		{
			stringBuilder.AppendLine("Capslock is enabled.");
		}
		if (((uint)NativeMethods.GetKeyState(16) & 0x8000u) != 0)
		{
			stringBuilder.AppendLine("Shift is pressed.");
		}
		if (((uint)NativeMethods.GetKeyState(17) & 0x8000u) != 0)
		{
			stringBuilder.AppendLine("Control is pressed.");
		}
		if (((uint)NativeMethods.GetKeyState(18) & 0x8000u) != 0)
		{
			stringBuilder.AppendLine("Alt is pressed.");
		}
		Console.WriteLine(stringBuilder.ToString());
	}

	private IntPtr HookCallback(int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam)
	{
		bool flag = PassAllKeysToNextApp;
		if (nCode >= 0)
		{
			if (wParam == (IntPtr)257 || wParam == (IntPtr)261)
			{
				if (lParam.vkCode < 160 || lParam.vkCode > 164)
				{
					CheckModifiers();
				}
				if (AllowWindowsKey)
				{
					switch (lParam.flags)
					{
					case 0:
						if (lParam.vkCode == 27)
						{
							flag = true;
						}
						break;
					case 1:
						if (lParam.vkCode == 91 || lParam.vkCode == 92)
						{
							flag = true;
						}
						break;
					}
				}
				if (AllowAltTab && lParam.flags == 32 && lParam.vkCode == 9)
				{
					flag = true;
				}
				OnKeyIntercepted(new KeyboardHookEventArgs(lParam.vkCode, flag));
			}
			if (!flag)
			{
				return (IntPtr)1;
			}
		}
		return NativeMethods.CallNextHookEx(hookID, nCode, wParam, ref lParam);
	}

	public void OnKeyIntercepted(KeyboardHookEventArgs e)
	{
		if (this.KeyIntercepted != null)
		{
			this.KeyIntercepted(e);
		}
	}

	public void Dispose()
	{
		NativeMethods.UnhookWindowsHookEx(hookID);
	}
}
