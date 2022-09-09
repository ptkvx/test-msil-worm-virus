using System.Runtime.InteropServices;
using System.Text;

namespace DShowNET;

[ComVisible(false)]
public class DsHlp
{
	public const int OATRUE = -1;

	public const int OAFALSE = 0;

	[DllImport("quartz.dll", CharSet = CharSet.Auto)]
	public static extern int AMGetErrorText(int hr, StringBuilder buf, int max);
}
