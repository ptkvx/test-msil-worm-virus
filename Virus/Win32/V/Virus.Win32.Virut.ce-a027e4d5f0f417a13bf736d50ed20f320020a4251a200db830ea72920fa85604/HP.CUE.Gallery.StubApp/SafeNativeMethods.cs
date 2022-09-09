using System.Runtime.InteropServices;

namespace HP.CUE.Gallery.StubApp;

public class SafeNativeMethods
{
	[DllImport("kernel32.Dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern int GetLastError();
}
