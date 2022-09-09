using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ATL;
using msclr;

namespace Microsoft.MediaCenter.TV.Tuners;

public abstract class SafeComWrapper : SafeHandle
{
	protected object m_Lock = new object();

	public abstract Guid PrimaryIID { get; }

	public override bool IsInvalid
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			@lock @lock = null;
			@lock lock2 = new @lock(m_Lock);
			try
			{
				@lock = lock2;
				if (!base.IsClosed && !(IntPtr.Zero == handle))
				{
					goto IL_003c;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			return true;
			IL_003c:
			((IDisposable)@lock).Dispose();
			return false;
		}
	}

	private void SetComPtr(IntPtr punkPtr)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			if (base.IsClosed)
			{
				throw new InvalidOperationException("Cannot set a com pointer on a closed handle");
			}
			if (IntPtr.Zero != handle)
			{
				ReleaseHandle();
			}
			SetHandle(punkPtr);
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		try
		{
			return;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
	}

	private unsafe IUnknown* GetComPtr()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			if (!base.IsClosed)
			{
				goto IL_002b;
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return null;
		IL_002b:
		IUnknown* result;
		try
		{
			result = (IUnknown*)handle.ToPointer();
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return result;
	}

	private IntPtr GetHandlePtr()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		IntPtr zero;
		try
		{
			@lock = lock2;
			if (base.IsClosed)
			{
				zero = IntPtr.Zero;
				goto IL_0029;
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		IntPtr result;
		try
		{
			result = handle;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return result;
		IL_0029:
		((IDisposable)@lock).Dispose();
		return zero;
	}

	protected SafeComWrapper(Guid riid, IntPtr punkObj)
		: base(IntPtr.Zero, ownsHandle: true)
	{
		try
		{
			SetObject(riid, punkObj);
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(disposing: true);
			throw;
		}
	}

	protected SafeComWrapper()
		: base(IntPtr.Zero, ownsHandle: true)
	{
	}

	public virtual SafeComWrapper ReferenceClone()
	{
		if (IsInvalid)
		{
			throw new ApplicationException("can't clone empty wrapper. has it been disposed?");
		}
		SafeComWrapper safeComWrapper = (SafeComWrapper)CreateTypedInstance(GetType());
		Guid primaryIID = PrimaryIID;
		IntPtr handlePtr = GetHandlePtr();
		safeComWrapper.SetObject(primaryIID, handlePtr);
		return safeComWrapper;
	}

	internal unsafe static int GetNativePtrFromWrapper(SafeComWrapper wrapper, _GUID* riid, void** ppv)
	{
		IUnknown* comPtr = wrapper.GetComPtr();
		return ((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, _GUID*, void**, int>)(int)(*(uint*)(int)(*(uint*)comPtr)))((nint)comPtr, riid, ppv);
	}

	internal unsafe static int GetNativePtrFromWrapper(object obj, _GUID* riid, void** ppv)
	{
		if (!typeof(SafeComWrapper).IsAssignableFrom(obj.GetType()))
		{
			throw new ArgumentException("obj");
		}
		return GetNativePtrFromWrapper((SafeComWrapper)obj, riid, ppv);
	}

	internal unsafe static CComPtr_003CIUnknown_003E* GetNativePtr(CComPtr_003CIUnknown_003E* pCcomPtr_003CIUnknown_003E_0, SafeComWrapper w)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		try
		{
			num = 0u;
			_003CModule_003E.ATL_002ECComPtr_003CIUnknown_003E_002E_007Bctor_007D(pCcomPtr_003CIUnknown_003E_0, w.GetComPtr());
			num = 1u;
			return pCcomPtr_003CIUnknown_003E_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIUnknown_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIUnknown_003E_002E_007Bdtor_007D), pCcomPtr_003CIUnknown_003E_0);
			}
			throw;
		}
	}

	internal unsafe CComPtr_003CIUnknown_003E* GetPtr(CComPtr_003CIUnknown_003E* pCcomPtr_003CIUnknown_003E_0)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		try
		{
			num = 0u;
			_003CModule_003E.ATL_002ECComPtr_003CIUnknown_003E_002E_007Bctor_007D(pCcomPtr_003CIUnknown_003E_0, GetComPtr());
			num = 1u;
			return pCcomPtr_003CIUnknown_003E_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIUnknown_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIUnknown_003E_002E_007Bdtor_007D), pCcomPtr_003CIUnknown_003E_0);
			}
			throw;
		}
	}

	[return: MarshalAs(UnmanagedType.U1)]
	protected unsafe override bool ReleaseHandle()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			if (IntPtr.Zero != handle)
			{
				IUnknown* ptr = (IUnknown*)handle.ToPointer();
				if (null != ptr)
				{
					((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint>)(int)(*(uint*)(*(int*)ptr + 8)))((nint)ptr);
					handle = IntPtr.Zero;
				}
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return true;
	}

	[CLSCompliant(false)]
	protected unsafe void CreateObject(_GUID* clsid, _GUID* riid)
	{
		IUnknown* ptr = null;
		MarshalHelper.ComException(_003CModule_003E.CoCreateInstance(clsid, null, 3u, riid, (void**)(&ptr)));
		IntPtr comPtr = (IntPtr)ptr;
		SetComPtr(comPtr);
	}

	[CLSCompliant(false)]
	protected unsafe virtual void SetObject(Guid riid, IntPtr punkObj)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIUnknown_003E cComPtr_003CIUnknown_003E);
		*(int*)(&cComPtr_003CIUnknown_003E) = 0;
		try
		{
			if (punkObj != IntPtr.Zero)
			{
				void* ptr = punkObj.ToPointer();
				MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, _GUID*, void**, int>)(int)(*(uint*)(int)(*(uint*)ptr)))((nint)ptr, (_GUID*)(int)(ref riid), (void**)(&cComPtr_003CIUnknown_003E)));
				int num = *(int*)(&cComPtr_003CIUnknown_003E);
				*(int*)(&cComPtr_003CIUnknown_003E) = 0;
				IntPtr comPtr = (IntPtr)(void*)num;
				SetComPtr(comPtr);
			}
			else
			{
				SetComPtr(IntPtr.Zero);
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIUnknown_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIUnknown_003E_002E_007Bdtor_007D), &cComPtr_003CIUnknown_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIUnknown_003E_002E_007Bdtor_007D((CComPtrBase_003CIUnknown_003E*)(&cComPtr_003CIUnknown_003E));
	}

	protected static object CreateTypedInstance(Type baseType)
	{
		return Activator.CreateInstance(baseType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[1] { IntPtr.Zero }, null);
	}

	protected unsafe static object CreateTypedInstance(Type baseType, IUnknown* punk)
	{
		object[] array = new object[1];
		IntPtr intPtr = (IntPtr)punk;
		array[0] = intPtr;
		return Activator.CreateInstance(baseType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, array, null);
	}

	[CLSCompliant(false)]
	protected unsafe static object CreateTypedInstance(Type baseType, Guid primaryIID, IUnknown* punk)
	{
		object[] array = new object[2] { primaryIID, null };
		IntPtr intPtr = (IntPtr)punk;
		array[1] = intPtr;
		return Activator.CreateInstance(baseType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, array, null);
	}

	public unsafe static CComPtr_003CITunerEvents2_003E* GetNativePtr_003CITunerEvents2_003E(CComPtr_003CITunerEvents2_003E* pCcomPtr_003CITunerEvents2_003E_0, SafeComWrapper w)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		try
		{
			num = 0u;
			*(int*)pCcomPtr_003CITunerEvents2_003E_0 = 0;
			num = 1u;
			MarshalHelper.ComException(GetNativePtrFromWrapper(w, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_7eab3a3d_0900_43a5_9189_631ac98ed822), (void**)pCcomPtr_003CITunerEvents2_003E_0));
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

	public unsafe static CComPtr_003CIRecorderEx2_003E* GetNativePtr_003CIRecorderEx2_003E(CComPtr_003CIRecorderEx2_003E* pCcomPtr_003CIRecorderEx2_003E_0, SafeComWrapper w)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		try
		{
			num = 0u;
			*(int*)pCcomPtr_003CIRecorderEx2_003E_0 = 0;
			num = 1u;
			MarshalHelper.ComException(GetNativePtrFromWrapper(w, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_706a52d5_e700_4353_8f1c_aa5c5dbb7339), (void**)pCcomPtr_003CIRecorderEx2_003E_0));
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

	public unsafe static CComPtr_003CIRecorderInfo_003E* GetNativePtr_003CIRecorderInfo_003E(CComPtr_003CIRecorderInfo_003E* pCcomPtr_003CIRecorderInfo_003E_0, SafeComWrapper w)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		try
		{
			num = 0u;
			*(int*)pCcomPtr_003CIRecorderInfo_003E_0 = 0;
			num = 1u;
			MarshalHelper.ComException(GetNativePtrFromWrapper(w, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_379848e6_2751_42c0_8de6_9457cdc61d60), (void**)pCcomPtr_003CIRecorderInfo_003E_0));
			return pCcomPtr_003CIRecorderInfo_003E_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), pCcomPtr_003CIRecorderInfo_003E_0);
			}
			throw;
		}
	}

	public unsafe static CComPtr_003CIEnumRecorder_003E* GetNativePtr_003CIEnumRecorder_003E(CComPtr_003CIEnumRecorder_003E* pCcomPtr_003CIEnumRecorder_003E_0, SafeComWrapper w)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		try
		{
			num = 0u;
			*(int*)pCcomPtr_003CIEnumRecorder_003E_0 = 0;
			num = 1u;
			MarshalHelper.ComException(GetNativePtrFromWrapper(w, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_8a0c6976_25a0_426c_9e20_aee694c7a6aa), (void**)pCcomPtr_003CIEnumRecorder_003E_0));
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

	public unsafe static CComPtr_003CINetworkRecorderMgr_003E* GetNativePtr_003CINetworkRecorderMgr_003E(CComPtr_003CINetworkRecorderMgr_003E* pCcomPtr_003CINetworkRecorderMgr_003E_0, SafeComWrapper w)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		try
		{
			num = 0u;
			*(int*)pCcomPtr_003CINetworkRecorderMgr_003E_0 = 0;
			num = 1u;
			MarshalHelper.ComException(GetNativePtrFromWrapper(w, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_a43cf053_d95a_4720_aa5d_6277aacff043), (void**)pCcomPtr_003CINetworkRecorderMgr_003E_0));
			return pCcomPtr_003CINetworkRecorderMgr_003E_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CINetworkRecorderMgr_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D), pCcomPtr_003CINetworkRecorderMgr_003E_0);
			}
			throw;
		}
	}
}
