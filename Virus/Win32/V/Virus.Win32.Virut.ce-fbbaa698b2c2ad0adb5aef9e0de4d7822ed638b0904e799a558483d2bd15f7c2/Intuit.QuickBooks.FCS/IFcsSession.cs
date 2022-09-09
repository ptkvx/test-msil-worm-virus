using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

[ComVisible(true)]
[Guid("B1453A02-A0B8-349F-9371-CEAB24C8AC7D")]
public interface IFcsSession
{
	FCSErrors CopyFiles([MarshalAs(UnmanagedType.SafeArray)] COPYREC[] CopyRecords, string AuthFile);

	FCSErrors MoveFiles(COPYREC[] CopyRecords, bool bOverWrite, string AuthFile);
}
