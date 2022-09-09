using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[MiscellaneousBits(64)]
[NativeCppClass]
[DebugInfoInPDB]
internal struct Struct13
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[NativeCppClass]
	[MiscellaneousBits(65)]
	[CLSCompliant(false)]
	[DebugInfoInPDB]
	public struct Struct14
	{
	}

	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct13* pStruct13_0, Struct13* pStruct13_1)
	{
	}
}
