using System;
using System.Threading;
using System.Windows.Forms;
using GenericPolicy;
using hpCasl.Properties;

namespace hpCasl;

internal static class Class1
{
	private const string string_0 = "hpNotification.GlobalMutex";

	internal static Class0 class0_0 = new Class0(GClass0.enPolicyType.Global, Resources.PolicyToaster);

	[STAThread]
	private static void Main(string[] args)
	{
		if (args.Length == 1)
		{
			Mutex mutex = new Mutex(initiallyOwned: false, "hpNotification.GlobalMutex");
			mutex.WaitOne();
			if (Notification.smethod_0(args[0]))
			{
				mutex.ReleaseMutex();
				return;
			}
			Application.add_ThreadException((ThreadExceptionEventHandler)smethod_0);
			Application.SetUnhandledExceptionMode((UnhandledExceptionMode)2);
			AppDomain.CurrentDomain.UnhandledException += smethod_1;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Notification notification = new Notification(args[0]);
			((Control)notification).Show();
			mutex.ReleaseMutex();
			Application.Run();
		}
	}

	private static void smethod_0(object sender, ThreadExceptionEventArgs e)
	{
		Application.Exit();
	}

	private static void smethod_1(object sender, UnhandledExceptionEventArgs e)
	{
		Application.Exit();
	}

	private static DialogResult smethod_2(string string_1, Exception exception_0)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		string text = "An application error occurred. Please contact the adminstrator with the following information:\n\n";
		text = text + exception_0.Message + "\n\nStack Trace:\n" + exception_0.StackTrace;
		return MessageBox.Show(text, string_1, (MessageBoxButtons)2, (MessageBoxIcon)16);
	}
}
