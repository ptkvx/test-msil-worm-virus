using System.Web;
using System.Windows.Forms;
using ns13;

namespace ns14;

internal sealed class Class35
{
	private static bool bool_0;

	internal static void smethod_0()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (bool_0)
		{
			return;
		}
		bool_0 = true;
		try
		{
			MessageBox.Show(Class34.smethod_0(586));
		}
		catch
		{
			try
			{
				if (HttpContext.get_Current() != null && HttpContext.get_Current().get_Response() != null)
				{
					HttpContext.get_Current().get_Response().Write(Class34.smethod_0(752));
				}
			}
			catch
			{
			}
		}
	}
}
