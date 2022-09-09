using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ATL;
using msclr;

namespace Microsoft.MediaCenter.TV.Tuners;

public class RemoteTunerEnumerator : MTASafeComWrapper, ITunerEnumerator
{
	private Tuner m_Current;

	private TunerManager m_Manager;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual Tuner Current
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = new @lock(m_Lock);
			Tuner tuner;
			try
			{
				@lock = lock2;
				tuner = _003CModule_003E.smethod_113(m_Current);
				if (tuner != null && !tuner.IsInvalid)
				{
					goto IL_0047;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			try
			{
				throw new ApplicationException("unexpected failure to clone tuner collection member");
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			IL_0047:
			((IDisposable)@lock).Dispose();
			return tuner;
		}
	}

	public unsafe override Guid PrimaryIID => *(Guid*)(int)(ref _003CModule_003E._GUID_8a0c6976_25a0_426c_9e20_aee694c7a6aa);

	virtual object IEnumerator.Current
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = new @lock(m_Lock);
			SafeComWrapper safeComWrapper;
			try
			{
				@lock = lock2;
				safeComWrapper = _003CModule_003E.smethod_113(m_Current);
				if (safeComWrapper != null && !safeComWrapper.IsInvalid)
				{
					goto IL_0047;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			try
			{
				throw new ApplicationException("unexpected failure to clone tuner collection member");
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			IL_0047:
			((IDisposable)@lock).Dispose();
			return safeComWrapper;
		}
	}

	private unsafe void TPReset()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			m_Current = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIEnumRecorder_003E cComPtr_003CIEnumRecorder_003E);
			CComPtr_003CIEnumRecorder_003E* ptr = TPGetEnumPtr(&cComPtr_003CIEnumRecorder_003E);
			try
			{
				int num = *(int*)ptr;
				MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, int>)(int)(*(uint*)(*(int*)num + 20)))((IntPtr)num));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIEnumRecorder_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIEnumRecorder_003E_002E_007Bdtor_007D), &cComPtr_003CIEnumRecorder_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIEnumRecorder_003E_002E_007Bdtor_007D((CComPtrBase_003CIEnumRecorder_003E*)(&cComPtr_003CIEnumRecorder_003E));
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	private unsafe bool TPMoveNext()
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderInfo_003E cComPtr_003CIRecorderInfo_003E);
		*(int*)(&cComPtr_003CIRecorderInfo_003E) = 0;
		try
		{
			uint num = 0u;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIEnumRecorder_003E cComPtr_003CIEnumRecorder_003E);
			CComPtr_003CIEnumRecorder_003E* ptr = TPGetEnumPtr(&cComPtr_003CIEnumRecorder_003E);
			try
			{
				int num2 = *(int*)ptr;
				MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint, IRecorderInfo**, uint*, int>)(int)(*(uint*)(*(int*)num2 + 12)))((IntPtr)num2, 1u, (IRecorderInfo**)(&cComPtr_003CIRecorderInfo_003E), &num));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIEnumRecorder_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIEnumRecorder_003E_002E_007Bdtor_007D), &cComPtr_003CIEnumRecorder_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIEnumRecorder_003E_002E_007Bdtor_007D((CComPtrBase_003CIEnumRecorder_003E*)(&cComPtr_003CIEnumRecorder_003E));
			if (0 != num && 0 != *(int*)(&cComPtr_003CIRecorderInfo_003E))
			{
				@lock lock2 = new @lock(m_Lock);
				try
				{
					@lock = lock2;
					Tuner tuner = (m_Current = m_Manager.TPGetTunerForIRecorderInfo(&cComPtr_003CIRecorderInfo_003E));
					if (tuner != null && !tuner.IsInvalid)
					{
						goto IL_0093;
					}
				}
				catch
				{
					//try-fault
					((IDisposable)@lock).Dispose();
					throw;
				}
				goto IL_00b2;
			}
			goto end_IL_0006;
			IL_0093:
			((IDisposable)@lock).Dispose();
			goto IL_00a9;
			end_IL_0006:;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
			throw;
		}
		try
		{
			m_Current = null;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
		return false;
		IL_00a9:
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
		return true;
		IL_00b2:
		try
		{
			try
			{
				throw new ApplicationException("unexpected failure to map enumerated IRecorderInfo to Tuner^");
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
			throw;
		}
	}

	internal unsafe RemoteTunerEnumerator(IntPtr ptr)
		: base((_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_8a0c6976_25a0_426c_9e20_aee694c7a6aa), (IUnknown*)ptr.ToPointer())
	{
	}

	[CLSCompliant(false)]
	internal unsafe RemoteTunerEnumerator(IEnumRecorder* pEnum, TunerManager manager)
	{
		m_Current = null;
		m_Manager = manager;
		base._002Ector((_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_8a0c6976_25a0_426c_9e20_aee694c7a6aa), (IUnknown*)pEnum);
	}

	private void method_2()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		Tuner current;
		TunerManager manager;
		try
		{
			@lock = lock2;
			current = m_Current;
			m_Current = null;
			manager = m_Manager;
			m_Manager = null;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		((IDisposable)current)?.Dispose();
		((IDisposable)manager)?.Dispose();
	}

	public virtual void Reset()
	{
		InteropHelper.smethod_1(new dv0(TPReset).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::RemoteTunerEnumerator::Reset");
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public virtual bool MoveNext()
	{
		return InteropHelper.smethod_55(new d0<bool>(TPMoveNext).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::RemoteTunerEnumerator::MoveNext", 60000);
	}

	protected unsafe CComPtr_003CIEnumRecorder_003E* TPGetEnumPtr(CComPtr_003CIEnumRecorder_003E* pCcomPtr_003CIEnumRecorder_003E_0)
	{
		uint num = 0u;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIEnumRecorder_003E cComPtr_003CIEnumRecorder_003E);
		CComPtr_003CIEnumRecorder_003E* nativePtr_003CIEnumRecorder_003E = SafeComWrapper.GetNativePtr_003CIEnumRecorder_003E(&cComPtr_003CIEnumRecorder_003E, this);
		try
		{
			try
			{
				_003CModule_003E.ATL_002ECComPtr_003CIEnumRecorder_003E_002E_007Bctor_007D(pCcomPtr_003CIEnumRecorder_003E_0, nativePtr_003CIEnumRecorder_003E);
				num = 1u;
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIEnumRecorder_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIEnumRecorder_003E_002E_007Bdtor_007D), &cComPtr_003CIEnumRecorder_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIEnumRecorder_003E_002E_007Bdtor_007D((CComPtrBase_003CIEnumRecorder_003E*)(&cComPtr_003CIEnumRecorder_003E));
			return pCcomPtr_003CIEnumRecorder_003E_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIEnumRecorder_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIEnumRecorder_003E_002E_007Bdtor_007D), pCcomPtr_003CIEnumRecorder_003E_0);
			}
			throw;
		}
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
