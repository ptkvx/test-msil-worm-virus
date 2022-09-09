using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace ATL;

[StructLayout(LayoutKind.Sequential, Size = 4)]
[MiscellaneousBits(64)]
[NativeCppClass]
[DebugInfoInPDB]
internal struct Struct13
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct13* pStruct13_0, Struct13* pStruct13_1)
	{
		_003CModule_003E.smethod_61(pStruct13_0, pStruct13_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct13* pStruct13_0)
	{
		_003CModule_003E.smethod_62(pStruct13_0);
	}
}
