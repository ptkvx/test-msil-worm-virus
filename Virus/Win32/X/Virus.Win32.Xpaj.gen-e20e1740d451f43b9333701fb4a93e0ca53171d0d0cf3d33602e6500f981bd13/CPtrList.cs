using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

[StructLayout(LayoutKind.Sequential, Size = 28)]
[MiscellaneousBits(64)]
[DebugInfoInPDB]
[NativeCppClass]
internal struct CPtrList
{
	[StructLayout(LayoutKind.Sequential, Size = 12)]
	[DebugInfoInPDB]
	[MiscellaneousBits(65)]
	[NativeCppClass]
	internal struct CNode
	{
	}
}
