using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[StructLayout(LayoutKind.Sequential)]
[ComVisible(false)]
public class DsOptIntPtr
{
	public IntPtr Pointer;
}
