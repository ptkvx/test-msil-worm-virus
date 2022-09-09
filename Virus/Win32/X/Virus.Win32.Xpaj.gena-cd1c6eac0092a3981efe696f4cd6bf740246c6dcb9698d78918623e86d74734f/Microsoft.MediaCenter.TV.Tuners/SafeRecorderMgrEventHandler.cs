using System;
using System.Runtime.CompilerServices;

namespace Microsoft.MediaCenter.TV.Tuners;

internal class SafeRecorderMgrEventHandler : MTASafeComWrapper
{
	public unsafe override Guid PrimaryIID => *(Guid*)(int)(ref _003CModule_003E._GUID_07f3961a_f626_4bbc_a24f_1e72175f84fb);

	public unsafe SafeRecorderMgrEventHandler(IntPtr ptr)
		: base((_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_07f3961a_f626_4bbc_a24f_1e72175f84fb), ptr)
	{
	}

	public unsafe SafeRecorderMgrEventHandler(IRecorderMgrEvents* pEvents)
		: base((_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_07f3961a_f626_4bbc_a24f_1e72175f84fb), (IUnknown*)pEvents)
	{
	}

	private SafeRecorderMgrEventHandler()
	{
	}
}
