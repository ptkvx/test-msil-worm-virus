using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace MBackMonitor;

[RunInstaller(true)]
public class ProjectInstaller : Installer
{
	private ServiceProcessInstaller serviceProcessInstaller1;

	private ServiceInstaller serviceInstaller1;

	private Container components = null;

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
		((Installer)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		serviceProcessInstaller1 = new ServiceProcessInstaller();
		serviceInstaller1 = new ServiceInstaller();
		serviceProcessInstaller1.set_Account((ServiceAccount)2);
		serviceProcessInstaller1.set_Password((string)null);
		serviceProcessInstaller1.set_Username((string)null);
		serviceInstaller1.set_ServiceName("MBackMonitor");
		serviceInstaller1.set_StartType((ServiceStartMode)2);
		((Installer)this).get_Installers().AddRange((Installer[])(object)new Installer[2]
		{
			(Installer)serviceProcessInstaller1,
			(Installer)serviceInstaller1
		});
	}
}
