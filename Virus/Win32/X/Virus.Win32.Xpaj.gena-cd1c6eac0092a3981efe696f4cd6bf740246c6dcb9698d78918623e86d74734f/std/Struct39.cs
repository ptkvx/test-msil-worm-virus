using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 28)]
[NativeCppClass]
[UnsafeValueType]
[MiscellaneousBits(64)]
[DebugInfoInPDB]
internal struct Struct39
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct39* pStruct39_0, Struct39* pStruct39_1)
	{
		_003CModule_003E.smethod_148(pStruct39_0, pStruct39_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct39* pStruct39_0)
	{
		_003CModule_003E.smethod_153(pStruct39_0, _Built: true, 0u);
	}
}
