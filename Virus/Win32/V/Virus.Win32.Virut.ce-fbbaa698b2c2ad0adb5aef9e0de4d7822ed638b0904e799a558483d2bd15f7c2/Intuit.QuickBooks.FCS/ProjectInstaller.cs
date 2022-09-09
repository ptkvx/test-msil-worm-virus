using System.ComponentModel;
using System.Configuration.Install;
using System.Runtime.InteropServices;
using System.ServiceProcess;

namespace Intuit.QuickBooks.FCS;

[RunInstaller(true)]
[ComVisible(false)]
public class ProjectInstaller : Installer
{
	private IContainer components;

	private ServiceProcessInstaller serviceProcessInstaller1;

	private ServiceInstaller serviceInstaller1;

	public ProjectInstaller()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Component)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		serviceProcessInstaller1 = new ServiceProcessInstaller();
		serviceInstaller1 = new ServiceInstaller();
		serviceProcessInstaller1.set_Account((ServiceAccount)2);
		serviceProcessInstaller1.set_Password((string)null);
		serviceProcessInstaller1.set_Username((string)null);
		serviceInstaller1.set_ServiceName("QBFCService");
		serviceInstaller1.set_StartType((ServiceStartMode)2);
		((Installer)serviceInstaller1).add_AfterInstall(new InstallEventHandler(serviceInstaller1_AfterInstall));
		((Installer)this).get_Installers().AddRange((Installer[])(object)new Installer[2]
		{
			(Installer)serviceProcessInstaller1,
			(Installer)serviceInstaller1
		});
	}

	private void serviceInstaller1_AfterInstall(object sender, InstallEventArgs e)
	{
	}
}
