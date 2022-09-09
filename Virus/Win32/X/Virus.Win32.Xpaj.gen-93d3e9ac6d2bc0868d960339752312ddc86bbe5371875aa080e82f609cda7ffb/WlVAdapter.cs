using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

[StructLayout(LayoutKind.Sequential, Size = 88)]
[DebugInfoInPDB]
[NativeCppClass]
[UnsafeValueType]
[MiscellaneousBits(64)]
internal struct WlVAdapter
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	[NativeCppClass]
	[CLSCompliant(false)]
	[MiscellaneousBits(65)]
	[DebugInfoInPDB]
	public struct _tWL_QUERY_OID_HEADER
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 12)]
	[DebugInfoInPDB]
	[CLSCompliant(false)]
	[MiscellaneousBits(65)]
	[NativeCppClass]
	public struct _tWL_SET_OID_HEADER
	{
	}
}
