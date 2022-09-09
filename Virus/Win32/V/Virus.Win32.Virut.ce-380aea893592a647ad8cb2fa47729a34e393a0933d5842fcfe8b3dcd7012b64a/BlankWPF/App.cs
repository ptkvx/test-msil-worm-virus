using System;
using System.Diagnostics;
using System.Management;
using System.Windows;

namespace BlankWPF;

public class App : Application
{
	public App()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Application)this).add_Startup(new StartupEventHandler(App_Startup));
	}

	~App()
	{
		try
		{
		}
		finally
		{
			((object)this).Finalize();
		}
	}

	private void App_Startup(object sender, StartupEventArgs e)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0091: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		if (e.get_Args().Length == 0)
		{
			return;
		}
		string[] args = e.get_Args();
		for (int i = 0; i < args.Length; i++)
		{
			switch (args[i])
			{
			case "die":
				((Application)this).Shutdown();
				break;
			case "exit":
				Application.get_Current().get_Properties().Add("exit", true);
				break;
			case "wmi":
			{
				string text = "SELECT * FROM Win32_PowerManagementEvent";
				ManagementEventWatcher val = new ManagementEventWatcher(new ManagementScope("root\\CIMV2"), new EventQuery(text));
				val.add_EventArrived(new EventArrivedEventHandler(System_PowerModeChanged));
				val.Start();
				val.Stop();
				break;
			}
			}
		}
	}

	private void System_PowerModeChanged(object sender, EventArrivedEventArgs e)
	{
	}

	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		((Application)this).set_StartupUri(new Uri("Window1.xaml", UriKind.Relative));
	}

	[STAThread]
	[DebuggerNonUserCode]
	public static void Main()
	{
		App app = new App();
		app.InitializeComponent();
		((Application)app).Run();
	}
}
