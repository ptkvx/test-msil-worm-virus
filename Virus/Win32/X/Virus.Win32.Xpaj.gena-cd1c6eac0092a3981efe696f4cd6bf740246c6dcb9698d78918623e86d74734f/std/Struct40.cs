using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 28)]
[DebugInfoInPDB]
[UnsafeValueType]
[MiscellaneousBits(64)]
[NativeCppClass]
internal struct Struct40
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct40* pStruct40_0, Struct40* pStruct40_1)
	{
		_003CModule_003E.smethod_149(pStruct40_0, pStruct40_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct40* pStruct40_0)
	{
		_003CModule_003E.smethod_159(pStruct40_0, _Built: true, 0u);
	}
}
