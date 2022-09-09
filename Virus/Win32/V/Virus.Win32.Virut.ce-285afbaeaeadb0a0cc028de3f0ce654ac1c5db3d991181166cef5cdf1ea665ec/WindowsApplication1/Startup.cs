using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

[StandardModule]
internal sealed class Startup
{
	private static Cconnection objconnection;

	public static SqlConnection dBcon;

	[STAThread]
	public static void main()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		objconnection = new Cconnection();
		dBcon = new SqlConnection();
		objconnection.initialise();
		if (Operators.ConditionalCompareObjectEqual(objconnection.ConnectionStatus, (object)false, false))
		{
			Application.Run((Form)(object)new frmConnectionInterface());
		}
		objconnection = null;
		frmMain frmMain2 = new frmMain();
		((Form)frmMain2).set_WindowState((FormWindowState)2);
		((Form)frmMain2).set_MinimizeBox(false);
		((Form)frmMain2).set_MaximizeBox(false);
		Application.Run((Form)(object)frmMain2);
	}
}
