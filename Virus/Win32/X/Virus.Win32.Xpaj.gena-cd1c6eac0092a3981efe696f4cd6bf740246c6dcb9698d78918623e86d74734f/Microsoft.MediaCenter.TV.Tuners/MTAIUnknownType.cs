using System;
using System.Runtime.CompilerServices;

namespace Microsoft.MediaCenter.TV.Tuners;

internal class MTAIUnknownType : MTASafeComWrapper
{
	public unsafe override Guid PrimaryIID => *(Guid*)(int)(ref _003CModule_003E._GUID_00000000_0000_0000_c000_000000000046);

	public static void Delete(MTAIUnknownType u)
	{
		((IDisposable)u)?.Dispose();
	}

	public unsafe MTAIUnknownType(IntPtr ptr)
		: base((_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_00000000_0000_0000_c000_000000000046), (IUnknown*)ptr.ToPointer())
	{
	}

	public unsafe MTAIUnknownType(IUnknown* pUnk)
		: base((_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_00000000_0000_0000_c000_000000000046), pUnk)
	{
	}
}
