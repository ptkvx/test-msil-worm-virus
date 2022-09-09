using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace svchost;

[RunInstaller(true)]
public class ProjectInstaller : Installer
{
	private IContainer icontainer_0;

	private ServiceProcessInstaller serviceProcessInstaller_0;

	private ServiceInstaller serviceInstaller_0;

	public ProjectInstaller()
	{
		Class3.xfxU1RjzuVJwO();
		((Installer)this)._002Ector();
		method_0();
	}

	private void serviceInstaller_0_AfterInstall(object sender, InstallEventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Component)this).Dispose(disposing);
	}

	private void method_0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		serviceProcessInstaller_0 = new ServiceProcessInstaller();
		serviceInstaller_0 = new ServiceInstaller();
		serviceProcessInstaller_0.set_Account((ServiceAccount)2);
		serviceProcessInstaller_0.set_Password((string)null);
		serviceProcessInstaller_0.set_Username((string)null);
		serviceInstaller_0.set_ServiceName("Telephone");
		serviceInstaller_0.set_StartType((ServiceStartMode)2);
		((Installer)serviceInstaller_0).add_AfterInstall(new InstallEventHandler(serviceInstaller_0_AfterInstall));
		((Installer)this).get_Installers().AddRange((Installer[])(object)new Installer[2]
		{
			(Installer)serviceProcessInstaller_0,
			(Installer)serviceInstaller_0
		});
	}
}
