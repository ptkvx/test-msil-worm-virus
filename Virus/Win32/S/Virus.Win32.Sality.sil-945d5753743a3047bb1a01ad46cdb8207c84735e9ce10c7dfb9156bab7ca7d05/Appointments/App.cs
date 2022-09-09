using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace Appointments;

[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
public class App : Application
{
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		((Application)this).set_StartupUri(new Uri("MainWindow.xaml", UriKind.Relative));
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
