using System;
using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

[Serializable]
[ComVisible(false)]
public struct FcsLogRecord
{
	public string Source;

	public string Destination;

	public Actions Actions;
}
