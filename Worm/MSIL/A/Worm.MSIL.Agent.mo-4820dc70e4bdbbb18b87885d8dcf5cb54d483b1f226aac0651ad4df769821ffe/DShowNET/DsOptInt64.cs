using System.Runtime.InteropServices;

namespace DShowNET;

[StructLayout(LayoutKind.Sequential)]
[ComVisible(false)]
public class DsOptInt64
{
	public long Value;

	public DsOptInt64(long Value)
	{
		this.Value = Value;
	}
}
