using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace urDrive.unInstall;

public class SystemInfo
{
	public static string DefaultLanguage = "EN";

	public static ResourceManager MyResManager = null;

	public static CultureInfo MyCulture = null;

	public static DialogResult SysInformation(string strInfo)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(strInfo))
		{
			return (DialogResult)1;
		}
		try
		{
			frmSysInformation frmSysInformation2 = new frmSysInformation();
			((Form)frmSysInformation2).set_StartPosition((FormStartPosition)4);
			return ((Form)frmSysInformation2).ShowDialog();
		}
		catch
		{
			return (DialogResult)1;
		}
	}
}
