using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 12)]
[DebugInfoInPDB]
[MiscellaneousBits(64)]
[NativeCppClass]
internal struct Struct3
{
	[StructLayout(LayoutKind.Sequential, Size = 4)]
	[MiscellaneousBits(64)]
	[NativeCppClass]
	[CLSCompliant(false)]
	[DebugInfoInPDB]
	public struct const_iterator
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 4)]
	[CLSCompliant(false)]
	[NativeCppClass]
	[MiscellaneousBits(64)]
	[DebugInfoInPDB]
	public struct iterator
	{
	}
}
