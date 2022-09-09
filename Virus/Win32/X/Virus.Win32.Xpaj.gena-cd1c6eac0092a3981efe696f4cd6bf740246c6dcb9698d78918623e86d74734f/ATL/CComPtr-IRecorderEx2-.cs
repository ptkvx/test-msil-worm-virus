using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace ATL;

[StructLayout(LayoutKind.Sequential, Size = 4)]
[NativeCppClass]
[DebugInfoInPDB]
[MiscellaneousBits(64)]
internal struct CComPtr_003CIRecorderEx2_003E
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(CComPtr_003CIRecorderEx2_003E* pCcomPtr_003CIRecorderEx2_003E_0, CComPtr_003CIRecorderEx2_003E* pCcomPtr_003CIRecorderEx2_003E_1)
	{
		_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bctor_007D(pCcomPtr_003CIRecorderEx2_003E_0, pCcomPtr_003CIRecorderEx2_003E_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(CComPtr_003CIRecorderEx2_003E* pCcomPtr_003CIRecorderEx2_003E_0)
	{
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)pCcomPtr_003CIRecorderEx2_003E_0);
	}
}
