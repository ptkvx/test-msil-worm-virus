using System;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;

namespace DHD_Patch;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		try
		{
			SkinManager.get_Default().RegisterAssembly(typeof(SkinProject2).Assembly);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			SkinManager.EnableFormSkins();
			Application.Run((Form)(object)new main_patch());
		}
		catch
		{
		}
	}
}
