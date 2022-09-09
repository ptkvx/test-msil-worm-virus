using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 4)]
[NativeCppClass]
[DebugInfoInPDB]
[MiscellaneousBits(64)]
internal struct locale
{
	[StructLayout(LayoutKind.Sequential, Size = 4)]
	[CLSCompliant(false)]
	[DebugInfoInPDB]
	[NativeCppClass]
	[MiscellaneousBits(64)]
	public struct id
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 52)]
	[UnsafeValueType]
	[DebugInfoInPDB]
	[CLSCompliant(false)]
	[NativeCppClass]
	[MiscellaneousBits(64)]
	public struct _Locimp
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 8)]
	[NativeCppClass]
	[MiscellaneousBits(64)]
	[DebugInfoInPDB]
	[CLSCompliant(false)]
	public struct facet
	{
	}
}
