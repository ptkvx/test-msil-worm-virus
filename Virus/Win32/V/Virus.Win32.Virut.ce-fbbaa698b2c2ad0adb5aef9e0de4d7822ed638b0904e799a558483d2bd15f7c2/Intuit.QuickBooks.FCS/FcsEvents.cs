using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

[Guid("72B015E7-FF8C-4193-902F-F56FB7C59636")]
[ComVisible(false)]
public class FcsEvents : IFcsEvents
{
	public void FileCopy(string FileName, bool Success)
	{
	}

	public void TransactionStart()
	{
	}

	public void TransactionEnd()
	{
	}
}
