using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

[StructLayout(LayoutKind.Sequential, Size = 32)]
[DebugInfoInPDB]
[MiscellaneousBits(65)]
[NativeCppClass]
internal struct EHExceptionRecord
{
	[StructLayout(LayoutKind.Sequential, Size = 12)]
	[NativeCppClass]
	[CLSCompliant(false)]
	[DebugInfoInPDB]
	[MiscellaneousBits(65)]
	public struct EHParameters
	{
	}
}
