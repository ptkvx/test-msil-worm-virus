using System;
using System.Runtime.InteropServices;
using msclr;

namespace Microsoft.MediaCenter.TV.Tuners;

public abstract class MTASafeComWrapper : SafeComWrapper
{
	private void TPSetObject(Guid riid, IntPtr punkObj)
	{
		base.SetObject(riid, punkObj);
	}

	protected unsafe void TPDtor(IntPtr h)
	{
		if (h != IntPtr.Zero)
		{
			try
			{
				void* intPtr = h.ToPointer();
				((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint>)(int)(*(uint*)(*(int*)intPtr + 8)))((nint)intPtr);
			}
			catch (COMException)
			{
			}
		}
	}

	protected unsafe MTASafeComWrapper(_GUID* riid, IntPtr ptr)
		: base(*(Guid*)(int)riid, ptr)
	{
	}

	protected unsafe MTASafeComWrapper(_GUID* riid, IUnknown* punkObj)
		: base(punkObj: (IntPtr)punkObj, riid: *(Guid*)(int)riid)
	{
	}

	protected MTASafeComWrapper()
	{
	}

	private void method_0()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			if (!(IntPtr.Zero == handle))
			{
				goto IL_003a;
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return;
		IL_003a:
		IntPtr a;
		try
		{
			a = handle;
			handle = IntPtr.Zero;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		dv1<IntPtr> dv11 = TPDtor;
		dv11.BeginInvoke(a, InteropHelper.smethod_66, dv11);
	}

	private void method_1()
	{
		@lock @lock = null;
		try
		{
			IntPtr zero = IntPtr.Zero;
			@lock lock2 = new @lock(m_Lock);
			try
			{
				@lock = lock2;
				if (!(IntPtr.Zero == handle))
				{
					goto IL_0040;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			return;
			IL_0040:
			try
			{
				zero = handle;
				handle = IntPtr.Zero;
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			TPDtor(zero);
		}
		catch (COMException)
		{
		}
	}

	protected unsafe void SetObject(_GUID* riid, IUnknown* punkObj)
	{
		IntPtr punkObj2 = (IntPtr)punkObj;
		SetObject(*(Guid*)(int)riid, punkObj2);
	}

	protected override void SetObject(Guid riid, IntPtr punkObj)
	{
		InteropHelper.smethod_0(new dv2<Guid, IntPtr>(TPSetObject).BeginInvoke(riid, punkObj, null, null), "Microsoft::MediaCenter::TV::Tuners::MTASafeComWrapper::SetObject");
	}

	internal unsafe static int GetNativePtrFromSafeHandle(SafeHandle wrapper, _GUID* riid, void** ppv)
	{
		IUnknown* ptr = (IUnknown*)wrapper.DangerousGetHandle().ToPointer();
		if (ptr == null)
		{
			return -2147467259;
		}
		return ((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, _GUID*, void**, int>)(int)(*(uint*)(int)(*(uint*)ptr)))((nint)ptr, riid, ppv);
	}

	internal unsafe static int GetNativePtrFromSafeHandle(object obj, _GUID* riid, void** ppv)
	{
		if (!typeof(SafeHandle).IsAssignableFrom(obj.GetType()))
		{
			throw new ArgumentException("obj");
		}
		return GetNativePtrFromSafeHandle((SafeHandle)obj, riid, ppv);
	}

	internal unsafe static int GetNativePtrFromIntPtr(IntPtr pointer, _GUID* riid, void** ppv)
	{
		IUnknown* ptr = (IUnknown*)pointer.ToPointer();
		if (ptr == null)
		{
			return -2147467259;
		}
		return ((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, _GUID*, void**, int>)(int)(*(uint*)(int)(*(uint*)ptr)))((nint)ptr, riid, ppv);
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool disposing)
	{
		if (disposing)
		{
			try
			{
				method_0();
				return;
			}
			finally
			{
				base.Dispose(disposing: true);
			}
		}
		try
		{
			method_1();
		}
		finally
		{
			base.Dispose(disposing: false);
		}
	}
}
