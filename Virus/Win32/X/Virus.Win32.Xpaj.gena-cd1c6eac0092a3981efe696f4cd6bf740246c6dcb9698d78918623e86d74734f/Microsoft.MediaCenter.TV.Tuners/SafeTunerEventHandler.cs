using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ATL;

namespace Microsoft.MediaCenter.TV.Tuners;

internal class SafeTunerEventHandler : MTASafeComWrapper
{
	public unsafe override Guid PrimaryIID => *(Guid*)(int)(ref _003CModule_003E._GUID_7eab3a3d_0900_43a5_9189_631ac98ed822);

	public unsafe SafeTunerEventHandler(IntPtr ptr)
		: base((_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_7eab3a3d_0900_43a5_9189_631ac98ed822), ptr)
	{
	}

	public unsafe SafeTunerEventHandler(ITunerEvents2* pEvents)
		: base((_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_7eab3a3d_0900_43a5_9189_631ac98ed822), (IUnknown*)pEvents)
	{
	}

	private SafeTunerEventHandler()
	{
	}

	private unsafe CComPtr_003CITunerEvents2_003E* TPGetTEPtr(CComPtr_003CITunerEvents2_003E* pCcomPtr_003CITunerEvents2_003E_0)
	{
		uint num = 0u;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CITunerEvents2_003E cComPtr_003CITunerEvents2_003E);
		CComPtr_003CITunerEvents2_003E* nativePtr_003CITunerEvents2_003E = SafeComWrapper.GetNativePtr_003CITunerEvents2_003E(&cComPtr_003CITunerEvents2_003E, this);
		try
		{
			try
			{
				_003CModule_003E.ATL_002ECComPtr_003CITunerEvents2_003E_002E_007Bctor_007D(pCcomPtr_003CITunerEvents2_003E_0, nativePtr_003CITunerEvents2_003E);
				num = 1u;
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CITunerEvents2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CITunerEvents2_003E_002E_007Bdtor_007D), &cComPtr_003CITunerEvents2_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CITunerEvents2_003E_002E_007Bdtor_007D((CComPtrBase_003CITunerEvents2_003E*)(&cComPtr_003CITunerEvents2_003E));
			return pCcomPtr_003CITunerEvents2_003E_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CITunerEvents2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CITunerEvents2_003E_002E_007Bdtor_007D), pCcomPtr_003CITunerEvents2_003E_0);
			}
			throw;
		}
	}

	private void method_2()
	{
	}

	public unsafe void TPAdvise(Guid g)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CITunerEvents2_003E cComPtr_003CITunerEvents2_003E);
		TPGetTEPtr(&cComPtr_003CITunerEvents2_003E);
		try
		{
			MarshalHelper.ComException(_003CModule_003E.Microsoft_002EMediaCenter_002ETV_002ETuners_002ETPTunerEventHandler_002EAdvise((TPTunerEventHandler*)(int)((*(int*)(&cComPtr_003CITunerEvents2_003E) != 0) ? ((uint)(*(int*)(&cComPtr_003CITunerEvents2_003E) - 12)) : 0u), g));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CITunerEvents2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CITunerEvents2_003E_002E_007Bdtor_007D), &cComPtr_003CITunerEvents2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CITunerEvents2_003E_002E_007Bdtor_007D((CComPtrBase_003CITunerEvents2_003E*)(&cComPtr_003CITunerEvents2_003E));
	}

	public unsafe void TPAdvise(Tuner t)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CITunerEvents2_003E cComPtr_003CITunerEvents2_003E);
		TPGetTEPtr(&cComPtr_003CITunerEvents2_003E);
		try
		{
			MarshalHelper.ComException(_003CModule_003E.Microsoft_002EMediaCenter_002ETV_002ETuners_002ETPTunerEventHandler_002EAdvise((TPTunerEventHandler*)(int)((*(int*)(&cComPtr_003CITunerEvents2_003E) != 0) ? ((uint)(*(int*)(&cComPtr_003CITunerEvents2_003E) - 12)) : 0u), t));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CITunerEvents2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CITunerEvents2_003E_002E_007Bdtor_007D), &cComPtr_003CITunerEvents2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CITunerEvents2_003E_002E_007Bdtor_007D((CComPtrBase_003CITunerEvents2_003E*)(&cComPtr_003CITunerEvents2_003E));
	}

	public unsafe void TPUnadvise(Tuner t)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CITunerEvents2_003E cComPtr_003CITunerEvents2_003E);
		TPGetTEPtr(&cComPtr_003CITunerEvents2_003E);
		try
		{
			MarshalHelper.ComException(_003CModule_003E.Microsoft_002EMediaCenter_002ETV_002ETuners_002ETPTunerEventHandler_002EUnadvise((TPTunerEventHandler*)(int)((*(int*)(&cComPtr_003CITunerEvents2_003E) != 0) ? ((uint)(*(int*)(&cComPtr_003CITunerEvents2_003E) - 12)) : 0u), t));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CITunerEvents2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CITunerEvents2_003E_002E_007Bdtor_007D), &cComPtr_003CITunerEvents2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CITunerEvents2_003E_002E_007Bdtor_007D((CComPtrBase_003CITunerEvents2_003E*)(&cComPtr_003CITunerEvents2_003E));
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool disposing)
	{
		if (disposing)
		{
			try
			{
				return;
			}
			finally
			{
				base.Dispose(disposing: true);
			}
		}
		base.Dispose(disposing: false);
	}
}
