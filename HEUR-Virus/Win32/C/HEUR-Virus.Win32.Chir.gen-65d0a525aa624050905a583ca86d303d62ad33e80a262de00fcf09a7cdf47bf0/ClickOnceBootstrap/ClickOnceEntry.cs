using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Web;
using System.Windows.Forms;

namespace ClickOnceBootstrap;

internal static class ClickOnceEntry
{
	[STAThread]
	private static void Main()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			new PermissionSet(PermissionState.Unrestricted).Demand();
			if (ApplicationDeployment.get_IsNetworkDeployed())
			{
				string query = ApplicationDeployment.get_CurrentDeployment().get_ActivationUri().Query;
				if (query.Length >= 2)
				{
					query = query.Substring(1);
					query = HttpUtility.UrlDecode(query);
					string fileName = Path.Combine(Application.get_StartupPath(), "GoogleUpdateSetup.exe");
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = fileName;
					processStartInfo.Verb = "open";
					processStartInfo.Arguments = "/installsource clickonce /install \"";
					processStartInfo.Arguments += query;
					processStartInfo.Arguments += "\"";
					Process.Start(processStartInfo);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}
}
