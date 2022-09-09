using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ATL;
using msclr;

namespace Microsoft.MediaCenter.TV.Tuners;

public class RemoteTunerCollection : MTASafeComWrapper, ITunerCollection
{
	private object m_SyncRoot;

	private bool m_bEnumRetrieved;

	private TunerManager m_Manager;

	public virtual object SyncRoot => m_SyncRoot;

	public virtual bool IsSynchronized
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			return false;
		}
	}

	public virtual bool IsReadOnly
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			return true;
		}
	}

	public virtual int Count
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public unsafe override Guid PrimaryIID => *(Guid*)(int)(ref _003CModule_003E._GUID_8a0c6976_25a0_426c_9e20_aee694c7a6aa);

	private unsafe object TPClone()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIEnumRecorder_003E cComPtr_003CIEnumRecorder_003E);
		SafeComWrapper.GetNativePtr_003CIEnumRecorder_003E(&cComPtr_003CIEnumRecorder_003E, this);
		object result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIEnumRecorder_003E cComPtr_003CIEnumRecorder_003E2);
			*(int*)(&cComPtr_003CIEnumRecorder_003E2) = 0;
			try
			{
				int num = *(int*)(&cComPtr_003CIEnumRecorder_003E);
				MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, IEnumRecorder**, int>)(int)(*(uint*)(*(int*)(int)(*(uint*)(&cComPtr_003CIEnumRecorder_003E)) + 24)))((IntPtr)num, (IEnumRecorder**)(&cComPtr_003CIEnumRecorder_003E2)));
				result = new RemoteTunerCollection((IEnumRecorder*)(int)(*(uint*)(&cComPtr_003CIEnumRecorder_003E2)), m_Manager);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIEnumRecorder_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIEnumRecorder_003E_002E_007Bdtor_007D), &cComPtr_003CIEnumRecorder_003E2);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIEnumRecorder_003E_002E_007Bdtor_007D((CComPtrBase_003CIEnumRecorder_003E*)(&cComPtr_003CIEnumRecorder_003E2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIEnumRecorder_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIEnumRecorder_003E_002E_007Bdtor_007D), &cComPtr_003CIEnumRecorder_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIEnumRecorder_003E_002E_007Bdtor_007D((CComPtrBase_003CIEnumRecorder_003E*)(&cComPtr_003CIEnumRecorder_003E));
		return result;
	}

	private unsafe RemoteTunerEnumerator TPBuildEnumerator()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIUnknown_003E cComPtr_003CIUnknown_003E);
		CComPtr_003CIUnknown_003E* ptr = GetPtr(&cComPtr_003CIUnknown_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct20 @struct);
		try
		{
			IUnknown* lp = (IUnknown*)(int)(*(uint*)ptr);
			_003CModule_003E.smethod_107(&@struct, lp);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIUnknown_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIUnknown_003E_002E_007Bdtor_007D), &cComPtr_003CIUnknown_003E);
			throw;
		}
		RemoteTunerEnumerator result;
		try
		{
			_003CModule_003E.ATL_002ECComPtrBase_003CIUnknown_003E_002E_007Bdtor_007D((CComPtrBase_003CIUnknown_003E*)(&cComPtr_003CIUnknown_003E));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIEnumRecorder_003E cComPtr_003CIEnumRecorder_003E);
			*(int*)(&cComPtr_003CIEnumRecorder_003E) = 0;
			try
			{
				if (m_bEnumRetrieved)
				{
					int num = *(int*)(&@struct);
					MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, IEnumRecorder**, int>)(int)(*(uint*)(*(int*)(int)(*(uint*)(&@struct)) + 24)))((IntPtr)num, (IEnumRecorder**)(&cComPtr_003CIEnumRecorder_003E)));
					int num2 = *(int*)(&cComPtr_003CIEnumRecorder_003E);
					MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, int>)(int)(*(uint*)(*(int*)(int)(*(uint*)(&cComPtr_003CIEnumRecorder_003E)) + 20)))((IntPtr)num2));
					m_bEnumRetrieved = true;
				}
				else
				{
					_003CModule_003E.smethod_106(&cComPtr_003CIEnumRecorder_003E, (CComPtr_003CIEnumRecorder_003E*)(&@struct));
				}
				result = new RemoteTunerEnumerator((IEnumRecorder*)(int)(*(uint*)(&cComPtr_003CIEnumRecorder_003E)), m_Manager);
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct20*, void>)(&_003CModule_003E.smethod_104), &@struct);
			throw;
		}
		_003CModule_003E.smethod_104(&@struct);
		return result;
	}

	private RemoteTunerEnumerator BuildEnumerator()
	{
		return InteropHelper.smethod_95(new d0<RemoteTunerEnumerator>(TPBuildEnumerator).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::RemoteTunerCollection::BuildEnumerator");
	}

	internal unsafe RemoteTunerCollection(IntPtr ptr)
		: base((_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_8a0c6976_25a0_426c_9e20_aee694c7a6aa), (IUnknown*)ptr.ToPointer())
	{
	}

	internal unsafe RemoteTunerCollection(IEnumRecorder* pCollection, TunerManager manager)
	{
		m_bEnumRetrieved = false;
		m_Manager = manager;
		base._002Ector((_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_8a0c6976_25a0_426c_9e20_aee694c7a6aa), (IUnknown*)pCollection);
	}

	private void method_2()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		TunerManager manager;
		try
		{
			@lock = lock2;
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
		((IDisposable)manager)?.Dispose();
	}

	public virtual IEnumerator<Tuner> Generic_GetEnumerator()
	{
		return BuildEnumerator();
	}

	IEnumerator<Tuner> IEnumerable<Tuner>.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Generic_GetEnumerator
		return this.Generic_GetEnumerator();
	}

	public virtual IEnumerator IEnumerable_GetEnumerator()
	{
		return BuildEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in IEnumerable_GetEnumerator
		return this.IEnumerable_GetEnumerator();
	}

	public virtual void Add(Tuner t)
	{
		throw new NotSupportedException();
	}

	public virtual void Clear()
	{
		throw new NotSupportedException();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public virtual bool Contains(Tuner t)
	{
		throw new NotSupportedException();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public virtual bool Remove(Tuner t)
	{
		throw new NotSupportedException();
	}

	public virtual void CopyTo(Array a, int i)
	{
		IEnumerator enumerator = IEnumerable_GetEnumerator();
		int num = i;
		if (!enumerator.MoveNext())
		{
			return;
		}
		do
		{
			SafeComWrapper safeComWrapper = (SafeComWrapper)enumerator.Current;
			if (safeComWrapper != null && !safeComWrapper.IsInvalid)
			{
				a.SetValue(safeComWrapper, num);
				num++;
				continue;
			}
			throw new ApplicationException("unexpected failure to clone tuner collection member");
		}
		while (enumerator.MoveNext());
	}

	public virtual void CopyTo(Tuner[] a, int i)
	{
		IEnumerator<Tuner> enumerator = Generic_GetEnumerator();
		int num = i;
		if (enumerator.MoveNext())
		{
			do
			{
				a[num] = enumerator.Current;
				num++;
			}
			while (enumerator.MoveNext());
		}
	}

	public virtual object Clone()
	{
		return InteropHelper.smethod_96(new d0<object>(TPClone).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::RemoteTunerCollection::Clone");
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
