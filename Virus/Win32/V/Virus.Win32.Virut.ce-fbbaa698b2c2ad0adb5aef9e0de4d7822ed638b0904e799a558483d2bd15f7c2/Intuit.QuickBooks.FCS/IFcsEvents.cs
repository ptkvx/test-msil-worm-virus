using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

[ComVisible(false)]
[Guid("C2010827-4367-4058-8757-BF8696EF0CFB")]
public interface IFcsEvents
{
	void FileCopy(string FileName, bool Success);

	void TransactionStart();

	void TransactionEnd();
}
