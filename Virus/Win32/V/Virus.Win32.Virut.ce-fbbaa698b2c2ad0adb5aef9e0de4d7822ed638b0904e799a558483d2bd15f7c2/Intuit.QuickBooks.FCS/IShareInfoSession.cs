using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

[ComVisible(true)]
[Guid("9193A58C-BFDD-4788-80A5-F1D08EC78D44")]
public interface IShareInfoSession
{
	FCSErrors GetLocalSharePath(string ShareName, out string SharePath);
}
