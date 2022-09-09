using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

[ComVisible(false)]
public enum Actions
{
	CopyFile,
	Rename,
	CreateDirectory,
	DeleteFile
}
