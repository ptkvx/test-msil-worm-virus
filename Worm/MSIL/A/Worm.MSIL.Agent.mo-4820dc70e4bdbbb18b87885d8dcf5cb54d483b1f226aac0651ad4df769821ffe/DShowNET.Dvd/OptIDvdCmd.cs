using System.Runtime.InteropServices;

namespace DShowNET.Dvd;

[StructLayout(LayoutKind.Sequential)]
[ComVisible(false)]
public class OptIDvdCmd
{
	public IDvdCmd dvdCmd;
}
