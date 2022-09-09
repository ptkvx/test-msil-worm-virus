using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ATL;
using msclr;

namespace Microsoft.MediaCenter.TV.Tuners;

internal class SafeRecorder : MTASafeComWrapper
{
	private SafeTunerEventHandler m_EventHandler;

	public unsafe override Guid PrimaryIID => *(Guid*)(int)(ref _003CModule_003E._GUID_706a52d5_e700_4353_8f1c_aa5c5dbb7339);

	public unsafe SafeRecorder(IntPtr ptr)
	{
		m_EventHandler = null;
		Guid primaryIID = PrimaryIID;
		base._002Ector((_GUID*)(int)(ref primaryIID), (IUnknown*)ptr.ToPointer());
	}

	public unsafe SafeRecorder(IRecorderEx2* pRecorder)
	{
		m_EventHandler = null;
		base._002Ector((_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_706a52d5_e700_4353_8f1c_aa5c5dbb7339), (IUnknown*)pRecorder);
	}

	private SafeRecorder()
	{
	}

	private unsafe CComPtr_003CIRecorderEx2_003E* TPGetRecPtr(CComPtr_003CIRecorderEx2_003E* pCcomPtr_003CIRecorderEx2_003E_0)
	{
		uint num = 0u;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
		CComPtr_003CIRecorderEx2_003E* nativePtr_003CIRecorderEx2_003E = SafeComWrapper.GetNativePtr_003CIRecorderEx2_003E(&cComPtr_003CIRecorderEx2_003E, this);
		try
		{
			try
			{
				_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bctor_007D(pCcomPtr_003CIRecorderEx2_003E_0, nativePtr_003CIRecorderEx2_003E);
				num = 1u;
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
			return pCcomPtr_003CIRecorderEx2_003E_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), pCcomPtr_003CIRecorderEx2_003E_0);
			}
			throw;
		}
	}

	private void method_2()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		SafeTunerEventHandler eventHandler;
		try
		{
			@lock = lock2;
			eventHandler = m_EventHandler;
			m_EventHandler = null;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		((IDisposable)eventHandler)?.Dispose();
	}

	public void TPAdvise(Guid g)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			SafeTunerEventHandler eventHandler = m_EventHandler;
			if (eventHandler != null && !eventHandler.IsInvalid)
			{
				m_EventHandler.TPAdvise(g);
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	public unsafe void TPAdvise(Tuner t)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			if (m_EventHandler == null)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
				TPGetRecPtr(&cComPtr_003CIRecorderEx2_003E);
				try
				{
					TPTunerEventHandler* ptr = (TPTunerEventHandler*)_003CModule_003E.@new(92u);
					TPTunerEventHandler* ptr2;
					try
					{
						if (ptr != null)
						{
							System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E2);
							CComPtr_003CIRecorderEx2_003E* pRec = _003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bctor_007D(&cComPtr_003CIRecorderEx2_003E2, &cComPtr_003CIRecorderEx2_003E);
							ptr2 = _003CModule_003E.Microsoft_002EMediaCenter_002ETV_002ETuners_002ETPTunerEventHandler_002E_007Bctor_007D(ptr, pRec);
						}
						else
						{
							ptr2 = null;
						}
					}
					catch
					{
						//try-fault
						_003CModule_003E.delete(ptr);
						throw;
					}
					TPTunerEventHandler* lp = (TPTunerEventHandler*)((ptr2 == null) ? null : ((byte*)ptr2 + 12));
					System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CITunerEvents2_003E cComPtr_003CITunerEvents2_003E);
					_003CModule_003E.ATL_002ECComPtr_003CITunerEvents2_003E_002E_007Bctor_007D(&cComPtr_003CITunerEvents2_003E, (ITunerEvents2*)lp);
					try
					{
						m_EventHandler = new SafeTunerEventHandler((ITunerEvents2*)(int)(*(uint*)(&cComPtr_003CITunerEvents2_003E)));
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CITunerEvents2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CITunerEvents2_003E_002E_007Bdtor_007D), &cComPtr_003CITunerEvents2_003E);
						throw;
					}
					_003CModule_003E.ATL_002ECComPtr_003CITunerEvents2_003E_002E_007Bdtor_007D(&cComPtr_003CITunerEvents2_003E);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
					throw;
				}
				_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D(&cComPtr_003CIRecorderEx2_003E);
			}
			m_EventHandler.TPAdvise(t);
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	public void TPUnadvise(Tuner t)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			SafeTunerEventHandler eventHandler = m_EventHandler;
			if (eventHandler != null && !eventHandler.IsInvalid)
			{
				m_EventHandler.TPUnadvise(t);
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	public override SafeComWrapper ReferenceClone()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		SafeRecorder safeRecorder;
		try
		{
			@lock = lock2;
			safeRecorder = (SafeRecorder)base.ReferenceClone();
			safeRecorder.m_EventHandler = _003CModule_003E.smethod_69(m_EventHandler);
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return safeRecorder;
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool disposing)
	{
		if (disposing)
		{
			try
			{
				method_2();
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
