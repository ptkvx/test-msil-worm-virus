using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 28)]
[NativeCppClass]
[UnsafeValueType]
[DebugInfoInPDB]
[MiscellaneousBits(64)]
internal struct Struct7
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct7* pStruct7_0, Struct7* pStruct7_1)
	{
		_003CModule_003E.smethod_5(pStruct7_0, pStruct7_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct7* pStruct7_0)
	{
		_003CModule_003E.smethod_31(pStruct7_0, _Built: true, 0u);
	}
}
