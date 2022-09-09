using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComVisible(false)]
public struct DsCAUUID
{
	public int cElems;

	public IntPtr pElems;
}
