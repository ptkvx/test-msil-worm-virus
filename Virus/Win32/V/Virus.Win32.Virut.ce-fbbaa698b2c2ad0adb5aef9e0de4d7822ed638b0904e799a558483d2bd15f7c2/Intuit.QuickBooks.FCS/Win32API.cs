using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

internal class Win32API
{
	public const int MOVEFILE_REPLACE_EXISTING = 1;

	public const int MOVEFILE_COPY_ALLOWED = 2;

	public const int MOVEFILE_DELAY_UNTIL_REBOOT = 4;

	public const int MOVEFILE_WRITE_THROUGH = 8;

	public const int MOVEFILE_CREATE_HARDLINK = 16;

	public const int MOVEFILE_FAIL_IF_NOT_TRACKABLE = 32;

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool MoveFileEx(string lpExistingFileName, string lpNewFileName, int dwFlags);
}
