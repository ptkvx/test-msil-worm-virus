using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ATL;
using Microsoft.MediaCenter.TV.Tuning;
using msclr;

namespace Microsoft.MediaCenter.TV.Tuners;

public class TunerManager : MTASafeComWrapper
{
	public class TunerNotificationEventArgs : EventArgs
	{
		public Guid TunerId;

		public TunerNotificationEventArgs()
		{
			TunerId = Guid.Empty;
			base._002Ector();
		}

		public TunerNotificationEventArgs(Guid g)
		{
			TunerId = g;
			base._002Ector();
		}
	}

	private EventHandler<TunerNotificationEventArgs> _003Cbacking_store_003ETunerArrivedEvent;

	private EventHandler<TunerNotificationEventArgs> _003Cbacking_store_003ETunerDepartedEvent;

	private EventHandler<TunerNotificationEventArgs> _003Cbacking_store_003ETunerConfigChangedEvent;

	private string m_ClientID;

	private SafeRecorderMgrEventHandler m_pEventHandler;

	private uint m_dwMgrConnPtCookie;

	private static object m_CacheLock = new object();

	private static bool m_SuppressConfigEvents = false;

	private static RecorderMgrFlags m_CacheFlags = RecorderMgrFlags.rmf_WaitNone;

	private static Dictionary<IntPtr, Tuner> m_RecorderDictionary;

	private static Dictionary<Guid, Tuner> m_RecorderIDDictionary;

	private static Dictionary<IntPtr, KeyValuePair<MTAIUnknownType, Tuner>> m_RecorderInfoDictionary;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool NetworkRecordersEnabled
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			return InteropHelper.smethod_38(new d0<bool>(TPNetworkRecordersEnabled).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::NetworkRecordersEnabled::get");
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Tuner SystemTuners
	{
		get
		{
			@lock @lock = null;
			Tuner value = null;
			d1<Tuner, Guid> d5 = null;
			IAsyncResult asyncResult = null;
			Tuner tuner = null;
			FillCache(RecorderMgrFlags.rmf_WaitAll);
			@lock lock2 = new @lock(m_CacheLock);
			Tuner result;
			try
			{
				@lock = lock2;
				if (m_RecorderIDDictionary != null && m_RecorderIDDictionary.TryGetValue(g, out value))
				{
					result = (Tuner)value.ReferenceClone();
					goto IL_0053;
				}
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
				d5 = TPFindRecorderByID;
				asyncResult = d5.BeginInvoke(g, null, null);
				tuner = InteropHelper.smethod_101(asyncResult, "Microsoft::MediaCenter::TV::Tuners::TunerManager::SystemTuners::get", 60000);
				return (Tuner)tuner.ReferenceClone();
			}
			catch (COMException)
			{
			}
			return null;
			IL_0053:
			((IDisposable)@lock).Dispose();
			return result;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public ITunerCollection AllTuners => new TunerCollection(this);

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public string ClientID
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = new @lock(m_Lock);
			string result;
			try
			{
				@lock = lock2;
				result = _003CModule_003E.smethod_65(m_ClientID);
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
		set
		{
			@lock @lock = null;
			@lock lock2 = new @lock(m_Lock);
			try
			{
				@lock = lock2;
				m_ClientID = value;
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public uint Count => FillCache(RecorderMgrFlags.rmf_WaitAll);

	public unsafe override Guid PrimaryIID => *(Guid*)(int)(ref _003CModule_003E._GUID_a43cf053_d95a_4720_aa5d_6277aacff043);

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string FullClientID
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = new @lock(m_Lock);
			string result;
			try
			{
				@lock = lock2;
				Process currentProcess = Process.GetCurrentProcess();
				result = string.Concat(str1: currentProcess.Id.ToString(), str0: string.Concat(string.Concat(m_ClientID + "&", currentProcess.MainModule!.ModuleName), "&"));
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
	}

	[SpecialName]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event EventHandler<TunerNotificationEventArgs> TunerConfigChangedEvent
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			_003Cbacking_store_003ETunerConfigChangedEvent = (EventHandler<TunerNotificationEventArgs>)Delegate.Combine(_003Cbacking_store_003ETunerConfigChangedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			_003Cbacking_store_003ETunerConfigChangedEvent = (EventHandler<TunerNotificationEventArgs>)Delegate.Remove(_003Cbacking_store_003ETunerConfigChangedEvent, value);
		}
	}

	[SpecialName]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event EventHandler<TunerNotificationEventArgs> TunerDepartedEvent
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			_003Cbacking_store_003ETunerDepartedEvent = (EventHandler<TunerNotificationEventArgs>)Delegate.Combine(_003Cbacking_store_003ETunerDepartedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			_003Cbacking_store_003ETunerDepartedEvent = (EventHandler<TunerNotificationEventArgs>)Delegate.Remove(_003Cbacking_store_003ETunerDepartedEvent, value);
		}
	}

	[SpecialName]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event EventHandler<TunerNotificationEventArgs> TunerArrivedEvent
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			_003Cbacking_store_003ETunerArrivedEvent = (EventHandler<TunerNotificationEventArgs>)Delegate.Combine(_003Cbacking_store_003ETunerArrivedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			_003Cbacking_store_003ETunerArrivedEvent = (EventHandler<TunerNotificationEventArgs>)Delegate.Remove(_003Cbacking_store_003ETunerArrivedEvent, value);
		}
	}

	private unsafe CComPtr_003CINetworkRecorderMgr_003E* TPGetRecMgr(CComPtr_003CINetworkRecorderMgr_003E* pCcomPtr_003CINetworkRecorderMgr_003E_0)
	{
		uint num = 0u;
		SafeComWrapper.GetNativePtr_003CINetworkRecorderMgr_003E(pCcomPtr_003CINetworkRecorderMgr_003E_0, this);
		try
		{
			num = 1u;
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

	private unsafe void TPCtor()
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CINetworkRecorderMgr_003E cComPtr_003CINetworkRecorderMgr_003E);
		*(int*)(&cComPtr_003CINetworkRecorderMgr_003E) = 0;
		try
		{
			MarshalHelper.ComException(_003CModule_003E.CoCreateInstance((_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CLSID_RecorderManager), null, 4u, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_a43cf053_d95a_4720_aa5d_6277aacff043), (void**)(&cComPtr_003CINetworkRecorderMgr_003E)));
			SetObject((_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_a43cf053_d95a_4720_aa5d_6277aacff043), (IUnknown*)(int)(*(uint*)(&cComPtr_003CINetworkRecorderMgr_003E)));
			@lock lock2 = new @lock(m_Lock);
			try
			{
				@lock = lock2;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderMgrEvents_003E cComPtr_003CIRecorderMgrEvents_003E);
				*(int*)(&cComPtr_003CIRecorderMgrEvents_003E) = 0;
				try
				{
					RecorderMgrEventHandler* ptr = (RecorderMgrEventHandler*)_003CModule_003E.@new(32u);
					RecorderMgrEventHandler* ptr2;
					try
					{
						ptr2 = ((ptr == null) ? null : _003CModule_003E.Microsoft_002EMediaCenter_002ETV_002ETuners_002ERecorderMgrEventHandler_002E_007Bctor_007D(ptr, this));
					}
					catch
					{
						//try-fault
						_003CModule_003E.delete(ptr);
						throw;
					}
					RecorderMgrEventHandler* lp = (RecorderMgrEventHandler*)((ptr2 == null) ? null : ((byte*)ptr2 + 12));
					_003CModule_003E.smethod_110(&cComPtr_003CIRecorderMgrEvents_003E, (IRecorderMgrEvents*)lp);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out uint dwMgrConnPtCookie);
					MarshalHelper.ComException(_003CModule_003E.smethod_115((INetworkRecorderMgr*)(int)(*(uint*)(&cComPtr_003CINetworkRecorderMgr_003E)), (IRecorderMgrEvents*)(int)(*(uint*)(&cComPtr_003CIRecorderMgrEvents_003E)), &dwMgrConnPtCookie));
					m_pEventHandler = new SafeRecorderMgrEventHandler((IRecorderMgrEvents*)(int)(*(uint*)(&cComPtr_003CIRecorderMgrEvents_003E)));
					m_dwMgrConnPtCookie = dwMgrConnPtCookie;
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderMgrEvents_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderMgrEvents_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderMgrEvents_003E);
					throw;
				}
				_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderMgrEvents_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderMgrEvents_003E*)(&cComPtr_003CIRecorderMgrEvents_003E));
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CINetworkRecorderMgr_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D), &cComPtr_003CINetworkRecorderMgr_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D((CComPtrBase_003CINetworkRecorderMgr_003E*)(&cComPtr_003CINetworkRecorderMgr_003E));
	}

	private unsafe void TPDtor(IntPtr hMgr, uint cookie, SafeRecorderMgrEventHandler eventhandler)
	{
		try
		{
			INetworkRecorderMgr* ptr = (INetworkRecorderMgr*)hMgr.ToPointer();
			uint dwMgrConnPtCookie = m_dwMgrConnPtCookie;
			if (ptr != null)
			{
				if (dwMgrConnPtCookie != 0)
				{
					m_dwMgrConnPtCookie = 0u;
					_003CModule_003E.smethod_114(ptr, &dwMgrConnPtCookie);
				}
				((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint>)(int)(*(uint*)(*(int*)ptr + 8)))((nint)ptr);
			}
			((IDisposable)eventhandler)?.Dispose();
		}
		catch (COMException)
		{
		}
	}

	private void method_2()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		IntPtr intPtr;
		uint dwMgrConnPtCookie;
		SafeRecorderMgrEventHandler pEventHandler;
		try
		{
			@lock = lock2;
			intPtr = handle;
			handle = IntPtr.Zero;
			dwMgrConnPtCookie = m_dwMgrConnPtCookie;
			m_dwMgrConnPtCookie = 0u;
			pEventHandler = m_pEventHandler;
			m_pEventHandler = null;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		if (intPtr != IntPtr.Zero)
		{
			TPDtor(intPtr, dwMgrConnPtCookie, pEventHandler);
		}
	}

	private unsafe Tuner TPSelectRecorder(TuneRequest tuneRequest, RecorderUse recorderUse, RecorderMgrFlags flags)
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CITuneRequest_003E cComPtr_003CITuneRequest_003E);
		*(int*)(&cComPtr_003CITuneRequest_003E) = 0;
		Tuner result;
		try
		{
			if (tuneRequest != null)
			{
				MarshalHelper.ComException(MTASafeComWrapper.GetNativePtrFromSafeHandle((SafeHandle)(object)tuneRequest, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_07ddc146_fc3d_11d2_9d8c_00c04f72d980), (void**)(&cComPtr_003CITuneRequest_003E)));
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorder_003E cComPtr_003CIRecorder_003E);
			*(int*)(&cComPtr_003CIRecorder_003E) = 0;
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct21 @struct);
				_003CModule_003E.smethod_111(&@struct);
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
					_003CModule_003E.ATL_002ECComBSTR_002E_007Bctor_007D(&cComBSTR, MarshalHelper.StringToBSTR(FullClientID));
					try
					{
						System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CINetworkRecorderMgr_003E cComPtr_003CINetworkRecorderMgr_003E);
						CComPtr_003CINetworkRecorderMgr_003E* ptr = TPGetRecMgr(&cComPtr_003CINetworkRecorderMgr_003E);
						try
						{
							int num = *(int*)ptr;
							int num2 = *(int*)(&cComPtr_003CITuneRequest_003E);
							int num3 = *(int*)(&cComBSTR);
							MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ITuneRequest*, global::RecorderUse, global::RecorderMgrFlags, ushort*, IRecorder**, int>)(int)(*(uint*)(*(int*)num + 12)))((IntPtr)num, (ITuneRequest*)num2, (global::RecorderUse)recorderUse, (global::RecorderMgrFlags)flags, (ushort*)num3, (IRecorder**)(&cComPtr_003CIRecorder_003E)));
						}
						catch
						{
							//try-fault
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CINetworkRecorderMgr_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D), &cComPtr_003CINetworkRecorderMgr_003E);
							throw;
						}
						_003CModule_003E.ATL_002ECComPtrBase_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D((CComPtrBase_003CINetworkRecorderMgr_003E*)(&cComPtr_003CINetworkRecorderMgr_003E));
						_003CModule_003E.smethod_112(&@struct, (IUnknown*)(int)(*(uint*)(&cComPtr_003CIRecorder_003E)));
						@lock lock2 = new @lock(m_CacheLock);
						try
						{
							@lock = lock2;
							result = TPNLGetTunerForIRecorder((CComPtr_003CIRecorderEx2_003E*)(&@struct), recorderUse);
						}
						catch
						{
							//try-fault
							((IDisposable)@lock).Dispose();
							throw;
						}
						((IDisposable)@lock).Dispose();
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
						throw;
					}
					_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct21*, void>)(&_003CModule_003E.smethod_105), &@struct);
					throw;
				}
				_003CModule_003E.smethod_105(&@struct);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorder_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorder_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorder_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorder_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorder_003E*)(&cComPtr_003CIRecorder_003E));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CITuneRequest_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CITuneRequest_003E_002E_007Bdtor_007D), &cComPtr_003CITuneRequest_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CITuneRequest_003E_002E_007Bdtor_007D((CComPtrBase_003CITuneRequest_003E*)(&cComPtr_003CITuneRequest_003E));
		return result;
	}

	private unsafe Tuner TPAcquireRecorder(RecorderUse recorderUse, Tuner acquisitionTarget, string clientName)
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderInfo_003E cComPtr_003CIRecorderInfo_003E);
		*(int*)(&cComPtr_003CIRecorderInfo_003E) = 0;
		Tuner result;
		try
		{
			MarshalHelper.ComException(SafeComWrapper.GetNativePtrFromWrapper(acquisitionTarget, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_379848e6_2751_42c0_8de6_9457cdc61d60), (void**)(&cComPtr_003CIRecorderInfo_003E)));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorder_003E cComPtr_003CIRecorder_003E);
			*(int*)(&cComPtr_003CIRecorder_003E) = 0;
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct21 @struct);
				_003CModule_003E.smethod_111(&@struct);
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
					_003CModule_003E.ATL_002ECComBSTR_002E_007Bctor_007D(&cComBSTR, MarshalHelper.StringToBSTR(clientName));
					try
					{
						System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CINetworkRecorderMgr_003E cComPtr_003CINetworkRecorderMgr_003E);
						CComPtr_003CINetworkRecorderMgr_003E* ptr = TPGetRecMgr(&cComPtr_003CINetworkRecorderMgr_003E);
						try
						{
							int num = *(int*)ptr;
							int num2 = *(int*)(&cComBSTR);
							int num3 = *(int*)(&cComPtr_003CIRecorderInfo_003E);
							MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, global::RecorderUse, ushort*, IRecorderInfo*, IRecorder**, int>)(int)(*(uint*)(*(int*)num + 16)))((IntPtr)num, (global::RecorderUse)recorderUse, (ushort*)num2, (IRecorderInfo*)num3, (IRecorder**)(&cComPtr_003CIRecorder_003E)));
						}
						catch
						{
							//try-fault
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CINetworkRecorderMgr_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D), &cComPtr_003CINetworkRecorderMgr_003E);
							throw;
						}
						_003CModule_003E.ATL_002ECComPtrBase_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D((CComPtrBase_003CINetworkRecorderMgr_003E*)(&cComPtr_003CINetworkRecorderMgr_003E));
						_003CModule_003E.smethod_112(&@struct, (IUnknown*)(int)(*(uint*)(&cComPtr_003CIRecorder_003E)));
						@lock lock2 = new @lock(m_CacheLock);
						try
						{
							@lock = lock2;
							result = TPNLGetTunerForIRecorder((CComPtr_003CIRecorderEx2_003E*)(&@struct), recorderUse);
						}
						catch
						{
							//try-fault
							((IDisposable)@lock).Dispose();
							throw;
						}
						((IDisposable)@lock).Dispose();
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
						throw;
					}
					_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct21*, void>)(&_003CModule_003E.smethod_105), &@struct);
					throw;
				}
				_003CModule_003E.smethod_105(&@struct);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorder_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorder_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorder_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorder_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorder_003E*)(&cComPtr_003CIRecorder_003E));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
		return result;
	}

	private unsafe Tuner TPAcquireRecorder(RecorderUse recorderUse, Tuner acquisitionTarget)
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderInfo_003E cComPtr_003CIRecorderInfo_003E);
		*(int*)(&cComPtr_003CIRecorderInfo_003E) = 0;
		Tuner result;
		try
		{
			MarshalHelper.ComException(SafeComWrapper.GetNativePtrFromWrapper(acquisitionTarget, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_379848e6_2751_42c0_8de6_9457cdc61d60), (void**)(&cComPtr_003CIRecorderInfo_003E)));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorder_003E cComPtr_003CIRecorder_003E);
			*(int*)(&cComPtr_003CIRecorder_003E) = 0;
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct21 @struct);
				*(int*)(&@struct) = 0;
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
					_003CModule_003E.ATL_002ECComBSTR_002E_007Bctor_007D(&cComBSTR, MarshalHelper.StringToBSTR(FullClientID));
					try
					{
						System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CINetworkRecorderMgr_003E cComPtr_003CINetworkRecorderMgr_003E);
						CComPtr_003CINetworkRecorderMgr_003E* ptr = TPGetRecMgr(&cComPtr_003CINetworkRecorderMgr_003E);
						try
						{
							int num = *(int*)ptr;
							int num2 = *(int*)(&cComBSTR);
							int num3 = *(int*)(&cComPtr_003CIRecorderInfo_003E);
							MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, global::RecorderUse, ushort*, IRecorderInfo*, IRecorder**, int>)(int)(*(uint*)(*(int*)num + 16)))((IntPtr)num, (global::RecorderUse)recorderUse, (ushort*)num2, (IRecorderInfo*)num3, (IRecorder**)(&cComPtr_003CIRecorder_003E)));
						}
						catch
						{
							//try-fault
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CINetworkRecorderMgr_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D), &cComPtr_003CINetworkRecorderMgr_003E);
							throw;
						}
						_003CModule_003E.ATL_002ECComPtrBase_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D((CComPtrBase_003CINetworkRecorderMgr_003E*)(&cComPtr_003CINetworkRecorderMgr_003E));
						_003CModule_003E.smethod_112(&@struct, (IUnknown*)(int)(*(uint*)(&cComPtr_003CIRecorder_003E)));
						@lock lock2 = new @lock(m_CacheLock);
						try
						{
							@lock = lock2;
							result = TPNLGetTunerForIRecorder((CComPtr_003CIRecorderEx2_003E*)(&@struct), recorderUse);
						}
						catch
						{
							//try-fault
							((IDisposable)@lock).Dispose();
							throw;
						}
						((IDisposable)@lock).Dispose();
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
						throw;
					}
					_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct21*, void>)(&_003CModule_003E.smethod_105), &@struct);
					throw;
				}
				_003CModule_003E.smethod_105(&@struct);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorder_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorder_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorder_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorder_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorder_003E*)(&cComPtr_003CIRecorder_003E));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
		return result;
	}

	private unsafe Tuner TPReleaseTuner(Tuner acquisitionTarget)
	{
		@lock @lock = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderInfo_003E cComPtr_003CIRecorderInfo_003E);
		*(int*)(&cComPtr_003CIRecorderInfo_003E) = 0;
		Tuner result;
		try
		{
			MarshalHelper.ComException(SafeComWrapper.GetNativePtrFromWrapper(acquisitionTarget, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_379848e6_2751_42c0_8de6_9457cdc61d60), (void**)(&cComPtr_003CIRecorderInfo_003E)));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorder_003E cComPtr_003CIRecorder_003E);
			*(int*)(&cComPtr_003CIRecorder_003E) = 0;
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct21 @struct);
				*(int*)(&@struct) = 0;
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
					_003CModule_003E.ATL_002ECComBSTR_002E_007Bctor_007D(&cComBSTR, MarshalHelper.StringToBSTR(FullClientID));
					try
					{
						System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CINetworkRecorderMgr_003E cComPtr_003CINetworkRecorderMgr_003E);
						CComPtr_003CINetworkRecorderMgr_003E* ptr = TPGetRecMgr(&cComPtr_003CINetworkRecorderMgr_003E);
						try
						{
							int num = *(int*)ptr;
							int num2 = *(int*)(&cComBSTR);
							int num3 = *(int*)(&cComPtr_003CIRecorderInfo_003E);
							MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, global::RecorderUse, ushort*, IRecorderInfo*, IRecorder**, int>)(int)(*(uint*)(*(int*)num + 16)))((IntPtr)num, (global::RecorderUse)6, (ushort*)num2, (IRecorderInfo*)num3, (IRecorder**)(&cComPtr_003CIRecorder_003E)));
						}
						catch
						{
							//try-fault
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CINetworkRecorderMgr_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D), &cComPtr_003CINetworkRecorderMgr_003E);
							throw;
						}
						_003CModule_003E.ATL_002ECComPtrBase_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D((CComPtrBase_003CINetworkRecorderMgr_003E*)(&cComPtr_003CINetworkRecorderMgr_003E));
						@lock lock2 = new @lock(m_CacheLock);
						try
						{
							@lock = lock2;
							SafeRecorder recorder = acquisitionTarget.Recorder;
							TPNLRemoveIRecorder(recorder);
							((IDisposable)recorder)?.Dispose();
							_003CModule_003E.smethod_112(&@struct, (IUnknown*)(int)(*(uint*)(&cComPtr_003CIRecorder_003E)));
							result = TPNLGetTunerForIRecorder((CComPtr_003CIRecorderEx2_003E*)(&@struct), RecorderUse.ru_AdviseOnly);
						}
						catch
						{
							//try-fault
							((IDisposable)@lock).Dispose();
							throw;
						}
						((IDisposable)@lock).Dispose();
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
						throw;
					}
					_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct21*, void>)(&_003CModule_003E.smethod_105), &@struct);
					throw;
				}
				_003CModule_003E.smethod_105(&@struct);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorder_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorder_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorder_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorder_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorder_003E*)(&cComPtr_003CIRecorder_003E));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
		return result;
	}

	private unsafe Tuner TPFindRecorderByID(Guid g)
	{
		@lock @lock = null;
		Tuner value = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderInfo_003E cComPtr_003CIRecorderInfo_003E);
		*(int*)(&cComPtr_003CIRecorderInfo_003E) = 0;
		Tuner result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CINetworkRecorderMgr_003E cComPtr_003CINetworkRecorderMgr_003E);
			CComPtr_003CINetworkRecorderMgr_003E* ptr = TPGetRecMgr(&cComPtr_003CINetworkRecorderMgr_003E);
			try
			{
				int num = *(int*)ptr;
				_GUID gUID = *(_GUID*)(int)(ref g);
				MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, _GUID, IRecorderInfo**, int>)(int)(*(uint*)(*(int*)num + 20)))((IntPtr)num, gUID, (IRecorderInfo**)(&cComPtr_003CIRecorderInfo_003E)));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CINetworkRecorderMgr_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D), &cComPtr_003CINetworkRecorderMgr_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D((CComPtrBase_003CINetworkRecorderMgr_003E*)(&cComPtr_003CINetworkRecorderMgr_003E));
			@lock lock2 = new @lock(m_CacheLock);
			try
			{
				@lock = lock2;
				if (m_RecorderIDDictionary != null && m_RecorderIDDictionary.TryGetValue(g, out value))
				{
					result = value;
					goto IL_007e;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			goto end_IL_0009;
			IL_007e:
			((IDisposable)@lock).Dispose();
			goto IL_0094;
			end_IL_0009:;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
			throw;
		}
		Tuner result2;
		try
		{
			try
			{
				result2 = TPNLGetTunerForIRecorderInfo(&cComPtr_003CIRecorderInfo_003E);
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
		return result2;
		IL_0094:
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
		return result;
	}

	private unsafe RemoteTunerCollection TPEnumRecorders(TuneRequest tuneRequest, RecorderUse recorderUse, RecorderMgrFlags flags)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CITuneRequest_003E cComPtr_003CITuneRequest_003E);
		*(int*)(&cComPtr_003CITuneRequest_003E) = 0;
		RemoteTunerCollection result;
		try
		{
			if (tuneRequest != null)
			{
				MarshalHelper.ComException(MTASafeComWrapper.GetNativePtrFromSafeHandle((SafeHandle)(object)tuneRequest, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_07ddc146_fc3d_11d2_9d8c_00c04f72d980), (void**)(&cComPtr_003CITuneRequest_003E)));
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIEnumRecorder_003E cComPtr_003CIEnumRecorder_003E);
			*(int*)(&cComPtr_003CIEnumRecorder_003E) = 0;
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CINetworkRecorderMgr_003E cComPtr_003CINetworkRecorderMgr_003E);
				CComPtr_003CINetworkRecorderMgr_003E* ptr = TPGetRecMgr(&cComPtr_003CINetworkRecorderMgr_003E);
				try
				{
					int num = *(int*)ptr;
					int num2 = *(int*)(&cComPtr_003CITuneRequest_003E);
					MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ITuneRequest*, global::RecorderUse, global::RecorderMgrFlags, IEnumRecorder**, int>)(int)(*(uint*)(*(int*)num + 24)))((IntPtr)num, (ITuneRequest*)num2, (global::RecorderUse)recorderUse, (global::RecorderMgrFlags)flags, (IEnumRecorder**)(&cComPtr_003CIEnumRecorder_003E)));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CINetworkRecorderMgr_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D), &cComPtr_003CINetworkRecorderMgr_003E);
					throw;
				}
				_003CModule_003E.ATL_002ECComPtrBase_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D((CComPtrBase_003CINetworkRecorderMgr_003E*)(&cComPtr_003CINetworkRecorderMgr_003E));
				result = new RemoteTunerCollection((IEnumRecorder*)(int)(*(uint*)(&cComPtr_003CIEnumRecorder_003E)), (TunerManager)ReferenceClone());
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CITuneRequest_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CITuneRequest_003E_002E_007Bdtor_007D), &cComPtr_003CITuneRequest_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CITuneRequest_003E_002E_007Bdtor_007D((CComPtrBase_003CITuneRequest_003E*)(&cComPtr_003CITuneRequest_003E));
		return result;
	}

	private unsafe RemoteTunerCollection TPEnumConfiguredRecorders(TuneRequest tuneRequest, RecorderUse recorderUse, RecorderMgrFlags flags)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CITuneRequest_003E cComPtr_003CITuneRequest_003E);
		*(int*)(&cComPtr_003CITuneRequest_003E) = 0;
		RemoteTunerCollection result;
		try
		{
			if (tuneRequest != null)
			{
				MarshalHelper.ComException(MTASafeComWrapper.GetNativePtrFromSafeHandle((SafeHandle)(object)tuneRequest, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_07ddc146_fc3d_11d2_9d8c_00c04f72d980), (void**)(&cComPtr_003CITuneRequest_003E)));
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIEnumRecorder_003E cComPtr_003CIEnumRecorder_003E);
			*(int*)(&cComPtr_003CIEnumRecorder_003E) = 0;
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CINetworkRecorderMgr_003E cComPtr_003CINetworkRecorderMgr_003E);
				CComPtr_003CINetworkRecorderMgr_003E* ptr = TPGetRecMgr(&cComPtr_003CINetworkRecorderMgr_003E);
				try
				{
					int num = *(int*)ptr;
					int num2 = *(int*)(&cComPtr_003CITuneRequest_003E);
					MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ITuneRequest*, global::RecorderUse, global::RecorderMgrFlags, IEnumRecorder**, int>)(int)(*(uint*)(*(int*)num + 28)))((IntPtr)num, (ITuneRequest*)num2, (global::RecorderUse)recorderUse, (global::RecorderMgrFlags)flags, (IEnumRecorder**)(&cComPtr_003CIEnumRecorder_003E)));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CINetworkRecorderMgr_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D), &cComPtr_003CINetworkRecorderMgr_003E);
					throw;
				}
				_003CModule_003E.ATL_002ECComPtrBase_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D((CComPtrBase_003CINetworkRecorderMgr_003E*)(&cComPtr_003CINetworkRecorderMgr_003E));
				result = new RemoteTunerCollection((IEnumRecorder*)(int)(*(uint*)(&cComPtr_003CIEnumRecorder_003E)), (TunerManager)ReferenceClone());
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CITuneRequest_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CITuneRequest_003E_002E_007Bdtor_007D), &cComPtr_003CITuneRequest_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CITuneRequest_003E_002E_007Bdtor_007D((CComPtrBase_003CITuneRequest_003E*)(&cComPtr_003CITuneRequest_003E));
		return result;
	}

	private unsafe void TPResetAllTunerSettings()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CINetworkRecorderMgr_003E cComPtr_003CINetworkRecorderMgr_003E);
		CComPtr_003CINetworkRecorderMgr_003E* ptr = TPGetRecMgr(&cComPtr_003CINetworkRecorderMgr_003E);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, int>)(int)(*(uint*)(*(int*)num + 36)))((IntPtr)num));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CINetworkRecorderMgr_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D), &cComPtr_003CINetworkRecorderMgr_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D((CComPtrBase_003CINetworkRecorderMgr_003E*)(&cComPtr_003CINetworkRecorderMgr_003E));
	}

	private unsafe void TPResetAllRecorders(RecorderMgrFlags flags)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CINetworkRecorderMgr_003E cComPtr_003CINetworkRecorderMgr_003E);
		CComPtr_003CINetworkRecorderMgr_003E* ptr = TPGetRecMgr(&cComPtr_003CINetworkRecorderMgr_003E);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint, int>)(int)(*(uint*)(*(int*)num + 48)))((IntPtr)num, (uint)flags));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CINetworkRecorderMgr_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D), &cComPtr_003CINetworkRecorderMgr_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D((CComPtrBase_003CINetworkRecorderMgr_003E*)(&cComPtr_003CINetworkRecorderMgr_003E));
	}

	private void TPNLClearCache()
	{
		dv1<Tuner> dv11 = null;
		dv1<Tuner> dv12 = null;
		dv1<MTAIUnknownType> dv13 = null;
		dv1<Tuner> dv14 = null;
		m_CacheFlags = RecorderMgrFlags.rmf_WaitNone;
		if (m_RecorderDictionary != null)
		{
			Dictionary<IntPtr, Tuner>.Enumerator enumerator = m_RecorderDictionary.GetEnumerator();
			while (enumerator.MoveNext())
			{
				KeyValuePair<IntPtr, Tuner> current = enumerator.Current;
				try
				{
					if (current.Value != null)
					{
						dv11 = Tuner.Delete;
						dv11.BeginInvoke(current.Value, InteropHelper.smethod_111, dv11);
					}
				}
				catch (NullReferenceException)
				{
				}
			}
			m_RecorderDictionary.Clear();
			if (m_RecorderDictionary is IDisposable disposable)
			{
				disposable.Dispose();
			}
			m_RecorderDictionary = null;
		}
		if (m_RecorderIDDictionary != null)
		{
			Dictionary<Guid, Tuner>.Enumerator enumerator2 = m_RecorderIDDictionary.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				KeyValuePair<Guid, Tuner> current2 = enumerator2.Current;
				try
				{
					if (current2.Value != null)
					{
						dv12 = Tuner.Delete;
						dv12.BeginInvoke(current2.Value, InteropHelper.smethod_111, dv12);
					}
				}
				catch (NullReferenceException)
				{
				}
			}
			m_RecorderIDDictionary.Clear();
			if (m_RecorderIDDictionary is IDisposable disposable2)
			{
				disposable2.Dispose();
			}
			m_RecorderIDDictionary = null;
		}
		if (m_RecorderInfoDictionary == null)
		{
			return;
		}
		Dictionary<IntPtr, KeyValuePair<MTAIUnknownType, Tuner>>.Enumerator enumerator3 = m_RecorderInfoDictionary.GetEnumerator();
		while (enumerator3.MoveNext())
		{
			KeyValuePair<IntPtr, KeyValuePair<MTAIUnknownType, Tuner>> current3 = enumerator3.Current;
			try
			{
				if (current3.Value.Value != null)
				{
					dv13 = MTAIUnknownType.Delete;
					dv13.BeginInvoke(current3.Value.Key, InteropHelper.smethod_112, dv13);
					dv14 = Tuner.Delete;
					dv14.BeginInvoke(current3.Value.Value, InteropHelper.smethod_111, dv14);
				}
			}
			catch (NullReferenceException)
			{
			}
		}
		m_RecorderInfoDictionary.Clear();
		if (m_RecorderInfoDictionary is IDisposable disposable3)
		{
			disposable3.Dispose();
		}
		m_RecorderInfoDictionary = null;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	private unsafe bool TPNetworkRecordersEnabled()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CINetworkRecorderMgr_003E cComPtr_003CINetworkRecorderMgr_003E);
		CComPtr_003CINetworkRecorderMgr_003E* ptr = TPGetRecMgr(&cComPtr_003CINetworkRecorderMgr_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num2);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, short*, int>)(int)(*(uint*)(*(int*)num + 52)))((IntPtr)num, &num2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CINetworkRecorderMgr_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D), &cComPtr_003CINetworkRecorderMgr_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D((CComPtrBase_003CINetworkRecorderMgr_003E*)(&cComPtr_003CINetworkRecorderMgr_003E));
		return num2 == -1;
	}

	private unsafe void TPStartSearch([MarshalAs(UnmanagedType.U1)] bool block, uint dwTimeout)
	{
		int num = -1;
		if (!block)
		{
			num = ~num;
		}
		short num2 = (short)num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CINetworkRecorderMgr_003E cComPtr_003CINetworkRecorderMgr_003E);
		CComPtr_003CINetworkRecorderMgr_003E* ptr = TPGetRecMgr(&cComPtr_003CINetworkRecorderMgr_003E);
		try
		{
			int num3 = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, short, uint, int>)(int)(*(uint*)(*(int*)num3 + 56)))((IntPtr)num3, num2, dwTimeout));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CINetworkRecorderMgr_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D), &cComPtr_003CINetworkRecorderMgr_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D((CComPtrBase_003CINetworkRecorderMgr_003E*)(&cComPtr_003CINetworkRecorderMgr_003E));
	}

	private unsafe void TPCancelSearch()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CINetworkRecorderMgr_003E cComPtr_003CINetworkRecorderMgr_003E);
		CComPtr_003CINetworkRecorderMgr_003E* ptr = TPGetRecMgr(&cComPtr_003CINetworkRecorderMgr_003E);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, int>)(int)(*(uint*)(*(int*)num + 60)))((IntPtr)num));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CINetworkRecorderMgr_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D), &cComPtr_003CINetworkRecorderMgr_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D((CComPtrBase_003CINetworkRecorderMgr_003E*)(&cComPtr_003CINetworkRecorderMgr_003E));
	}

	private unsafe void TPWaitForSearchComplete(uint dwTimeout)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CINetworkRecorderMgr_003E cComPtr_003CINetworkRecorderMgr_003E);
		CComPtr_003CINetworkRecorderMgr_003E* ptr = TPGetRecMgr(&cComPtr_003CINetworkRecorderMgr_003E);
		try
		{
			int num = *(int*)ptr;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, uint, int>)(int)(*(uint*)(*(int*)num + 64)))((IntPtr)num, dwTimeout));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CINetworkRecorderMgr_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D), &cComPtr_003CINetworkRecorderMgr_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CINetworkRecorderMgr_003E_002E_007Bdtor_007D((CComPtrBase_003CINetworkRecorderMgr_003E*)(&cComPtr_003CINetworkRecorderMgr_003E));
	}

	private uint FillCache(RecorderMgrFlags flags)
	{
		@lock @lock = null;
		@lock lock2 = null;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		bool flag = false;
		bool flag2 = false;
		@lock lock3 = new @lock(m_CacheLock);
		RecorderMgrFlags cacheFlags;
		try
		{
			@lock = lock3;
			cacheFlags = m_CacheFlags;
			if (m_RecorderInfoDictionary != null)
			{
				flag2 = true;
				num = m_RecorderInfoDictionary.Count;
			}
			if (m_RecorderIDDictionary != null)
			{
				flag = true;
				num2 = m_RecorderIDDictionary.Count;
			}
			if (m_RecorderDictionary != null)
			{
				num3 = m_RecorderDictionary.Count;
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		if ((uint)flags <= (uint)cacheFlags && flag && flag2)
		{
			if (num == 0)
			{
				goto IL_009f;
			}
			if (num >= num2)
			{
				return (uint)m_RecorderIDDictionary.Count;
			}
		}
		if (num == 0)
		{
			goto IL_009f;
		}
		goto IL_00a7;
		IL_009f:
		if (num2 != 0 || num3 != 0)
		{
			goto IL_00a7;
		}
		goto IL_00ad;
		IL_00a7:
		ClearCache();
		goto IL_00ad;
		IL_00ad:
		flags |= RecorderMgrFlags.rmf_EnumMissingConfiguredRecorders;
		RemoteTunerCollection remoteTunerCollection = InteropHelper.smethod_102(new d3<RemoteTunerCollection, TuneRequest, RecorderUse, RecorderMgrFlags>(TPEnumRecorders).BeginInvoke(null, RecorderUse.ru_Any, flags, null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::FillCache", 60000);
		uint num4 = 0u;
		foreach (Tuner item in (IEnumerable<Tuner>)remoteTunerCollection)
		{
			((IDisposable)item)?.Dispose();
			num4++;
		}
		((IDisposable)remoteTunerCollection)?.Dispose();
		@lock lock4 = new @lock(m_CacheLock);
		try
		{
			lock2 = lock4;
			if ((uint)flags > (uint)m_CacheFlags)
			{
				m_CacheFlags = flags;
			}
		}
		catch
		{
			//try-fault
			((IDisposable)lock2).Dispose();
			throw;
		}
		((IDisposable)lock2).Dispose();
		return num4;
	}

	private unsafe Tuner TPNLRegisterNewIRecorder(CComPtr_003CIRecorderEx2_003E* pRecorder, IntPtr u, RecorderUse ru)
	{
		if (*(int*)pRecorder == 0)
		{
			throw new InvalidOperationException("can't add NULL Recorder to Tuner^");
		}
		if (u == IntPtr.Zero)
		{
			throw new InvalidOperationException("can't add empty wrapper");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderInfo_003E cComPtr_003CIRecorderInfo_003E);
		*(int*)(&cComPtr_003CIRecorderInfo_003E) = 0;
		Tuner tuner;
		try
		{
			uint num = *(uint*)pRecorder;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, IRecorderInfo**, int>)(int)(*(uint*)(*(int*)(int)num + 12)))((IntPtr)(int)num, (IRecorderInfo**)(&cComPtr_003CIRecorderInfo_003E)));
			tuner = TPNLGetTunerForIRecorderInfo(&cComPtr_003CIRecorderInfo_003E);
			if (m_RecorderDictionary == null)
			{
				m_RecorderDictionary = new Dictionary<IntPtr, Tuner>();
			}
			if (!m_RecorderDictionary.ContainsKey(u))
			{
				m_RecorderDictionary.Add(u, tuner);
				goto IL_00a4;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
			throw;
		}
		try
		{
			throw new ApplicationException("cache inconsistency");
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderInfo_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderInfo_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderInfo_003E);
			throw;
		}
		IL_00a4:
		_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderInfo_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderInfo_003E*)(&cComPtr_003CIRecorderInfo_003E));
		return tuner;
	}

	private unsafe Tuner TPNLRegisterNewIRecorderInfo(CComPtr_003CIRecorderInfo_003E* pRecorderInfo, IntPtr RIUnk)
	{
		Tuner tuner = null;
		uint num = *(uint*)pRecorderInfo;
		if (num == 0)
		{
			throw new InvalidOperationException("can't make NULL RecInfo into Tuner^");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _GUID gUID);
		MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, _GUID*, int>)(int)(*(uint*)(*(int*)(int)num + 16)))((IntPtr)(int)num, &gUID));
		tuner = null;
		if (m_RecorderIDDictionary == null)
		{
			m_RecorderIDDictionary = new Dictionary<Guid, Tuner>();
		}
		bool flag;
		if ((flag = m_RecorderIDDictionary.TryGetValue(*(Guid*)(int)(ref gUID), out tuner)) && (tuner == null || tuner.IsInvalid))
		{
			throw new ApplicationException("unexpected bad tuner in RecorderIDDictionary");
		}
		if (m_RecorderInfoDictionary == null)
		{
			m_RecorderInfoDictionary = new Dictionary<IntPtr, KeyValuePair<MTAIUnknownType, Tuner>>();
		}
		KeyValuePair<MTAIUnknownType, Tuner> keyValuePair = new KeyValuePair<MTAIUnknownType, Tuner>(null, null);
		KeyValuePair<MTAIUnknownType, Tuner> value = keyValuePair;
		if (!m_RecorderInfoDictionary.TryGetValue(RIUnk, out value))
		{
			if (tuner == null)
			{
				tuner = new Tuner((IRecorderInfo*)(int)(*(uint*)pRecorderInfo), *(Guid*)(int)(ref gUID));
			}
			MTAIUnknownType key = new MTAIUnknownType((IUnknown*)RIUnk.ToPointer());
			KeyValuePair<MTAIUnknownType, Tuner> keyValuePair2 = new KeyValuePair<MTAIUnknownType, Tuner>(key, tuner);
			value = keyValuePair2;
			m_RecorderInfoDictionary.Add(RIUnk, value);
		}
		if (tuner != null && !tuner.IsInvalid && value.Key != null && value.Value != null && object.ReferenceEquals(tuner, value.Value))
		{
			if (!flag)
			{
				m_RecorderIDDictionary.Add(*(Guid*)(int)(ref gUID), tuner);
			}
			if (m_RecorderInfoDictionary.Count < m_RecorderIDDictionary.Count)
			{
				throw new ApplicationException("unexpected count mismatch between recorderinfo dictionaries in tuner manager cache");
			}
			return tuner;
		}
		throw new ApplicationException("tuner cache inconsistent");
	}

	private unsafe void TPNLRemoveIRecorder(SafeRecorder r)
	{
		Tuner tuner = null;
		if (m_RecorderDictionary == null)
		{
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIUnknown_003E cComPtr_003CIUnknown_003E);
		*(int*)(&cComPtr_003CIUnknown_003E) = 0;
		try
		{
			MarshalHelper.ComException(SafeComWrapper.GetNativePtrFromWrapper(r, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_00000000_0000_0000_c000_000000000046), (void**)(&cComPtr_003CIUnknown_003E)));
			IntPtr key = (IntPtr)(void*)(int)(*(uint*)(&cComPtr_003CIUnknown_003E));
			tuner = null;
			if (m_RecorderDictionary.TryGetValue(key, out tuner))
			{
				m_RecorderDictionary.Remove(key);
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

	private Tuner CompareViewingPriority(Tuner t1, Tuner t2)
	{
		if (t1 != null)
		{
			if (t2 != null)
			{
				if (!t1.PrefView && !t2.PrefView)
				{
					return (t1.RecordOrder <= t2.RecordOrder) ? t2 : t1;
				}
				if (t1.PrefView && t2.PrefView)
				{
					return (t1.ViewOrder >= t2.ViewOrder) ? t2 : t1;
				}
				return (!t1.PrefView) ? t2 : t1;
			}
			return t1;
		}
		return t2;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool ConfiguredPredicate(Tuner t)
	{
		return t.IsConfigured;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool AllPredicate(Tuner t)
	{
		return true;
	}

	internal unsafe Tuner[] GetCachedCollection(delegate*<Tuner, byte> pred, RecorderMgrFlags flags)
	{
		@lock @lock = null;
		FillCache(flags);
		@lock lock2 = new @lock(m_CacheLock);
		Tuner[] result;
		try
		{
			@lock = lock2;
			if (m_RecorderIDDictionary == null)
			{
				result = new Tuner[0];
				goto IL_0033;
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		Tuner[] array;
		try
		{
			int num = 0;
			Dictionary<Guid, Tuner>.Enumerator enumerator = m_RecorderIDDictionary.GetEnumerator();
			if (enumerator.MoveNext())
			{
				do
				{
					KeyValuePair<Guid, Tuner> current = enumerator.Current;
					if (!current.Value.IsInvalid)
					{
						if (pred(current.Value) != 0)
						{
							num++;
						}
						continue;
					}
					throw new ApplicationException("RecorderIDDictionary is corrupt");
				}
				while (enumerator.MoveNext());
			}
			array = new Tuner[num];
			int num2 = 0;
			Dictionary<Guid, Tuner>.Enumerator enumerator2 = m_RecorderIDDictionary.GetEnumerator();
			if (enumerator2.MoveNext())
			{
				do
				{
					KeyValuePair<Guid, Tuner> current2 = enumerator2.Current;
					if (!current2.Value.IsInvalid)
					{
						if (pred(current2.Value) != 0)
						{
							Tuner tuner = _003CModule_003E.smethod_113(current2.Value);
							if (tuner == null || tuner.IsInvalid)
							{
								throw new ApplicationException("unexpected failure cloning tuner");
							}
							array.SetValue(tuner, num2);
							num2++;
						}
						continue;
					}
					throw new ApplicationException("RecorderIDDictionary is corrupt");
				}
				while (enumerator2.MoveNext());
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return array;
		IL_0033:
		((IDisposable)@lock).Dispose();
		return result;
	}

	internal unsafe Tuner[] GetCachedCollection(RecorderMgrFlags flags)
	{
		return GetCachedCollection((delegate*<Tuner, byte>)(delegate*<Tuner, bool>)(&AllPredicate), flags);
	}

	internal unsafe Tuner TPNLGetTunerForIRecorderPtr(uint cookie, RecorderUse ru)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComGITPtr_003CIRecorderEx2_003E cComGITPtr_003CIRecorderEx2_003E);
		*(uint*)(&cComGITPtr_003CIRecorderEx2_003E) = cookie;
		Tuner result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
			*(int*)(&cComPtr_003CIRecorderEx2_003E) = 0;
			try
			{
				_003CModule_003E.ATL_002ECComGITPtr_003CIRecorderEx2_003E_002ECopyTo(&cComGITPtr_003CIRecorderEx2_003E, (IRecorderEx2**)(&cComPtr_003CIRecorderEx2_003E));
				result = TPNLGetTunerForIRecorder(&cComPtr_003CIRecorderEx2_003E, ru);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtrBase_003CIRecorderEx2_003E_002E_007Bdtor_007D((CComPtrBase_003CIRecorderEx2_003E*)(&cComPtr_003CIRecorderEx2_003E));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComGITPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComGITPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComGITPtr_003CIRecorderEx2_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComGITPtr_003CIRecorderEx2_003E_002ERevoke(&cComGITPtr_003CIRecorderEx2_003E);
		return result;
	}

	internal unsafe Tuner TPNLGetTunerForIRecorder(CComPtr_003CIRecorderEx2_003E* pRecorder, RecorderUse ru)
	{
		Tuner tuner = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIUnknown_003E cComPtr_003CIUnknown_003E);
		*(int*)(&cComPtr_003CIUnknown_003E) = 0;
		Tuner tuner2;
		try
		{
			int num = *(int*)pRecorder;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, _GUID*, void**, int>)(int)(*(uint*)(int)(*(uint*)num)))((IntPtr)num, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_00000000_0000_0000_c000_000000000046), (void**)(&cComPtr_003CIUnknown_003E)));
			if (*(int*)(&cComPtr_003CIUnknown_003E) == 0)
			{
				throw new ApplicationException("unexpected failure to QI for IUnknown");
			}
			SafeRecorder safeRecorder = new SafeRecorder((IRecorderEx2*)(int)(*(uint*)pRecorder));
			tuner = null;
			if (m_RecorderDictionary != null)
			{
				IntPtr key = (IntPtr)(void*)(int)(*(uint*)(&cComPtr_003CIUnknown_003E));
				if (m_RecorderDictionary.TryGetValue(key, out tuner))
				{
					goto IL_0072;
				}
			}
			IntPtr u = (IntPtr)(void*)(int)(*(uint*)(&cComPtr_003CIUnknown_003E));
			tuner = TPNLRegisterNewIRecorder(pRecorder, u, ru);
			goto IL_0072;
			IL_0072:
			switch (ru)
			{
			case RecorderUse.ru_AdviseOnly:
				tuner.TPSetRecorder(safeRecorder);
				tuner.SetCurrentUse(RecorderUse.ru_AdviseOnly);
				tuner2 = (Tuner)tuner.ReferenceClone();
				break;
			case RecorderUse.ru_Exclusive:
				tuner2 = (Tuner)tuner.ReferenceClone();
				tuner2.SetCurrentUse(RecorderUse.ru_Exclusive);
				tuner2.TPSetRecorder(safeRecorder);
				break;
			default:
				tuner2 = (Tuner)tuner.ReferenceClone();
				tuner2.ClearCurrentUse();
				tuner2.TPSetRecorder(safeRecorder);
				break;
			}
			((IDisposable)safeRecorder)?.Dispose();
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIUnknown_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIUnknown_003E_002E_007Bdtor_007D), &cComPtr_003CIUnknown_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIUnknown_003E_002E_007Bdtor_007D((CComPtrBase_003CIUnknown_003E*)(&cComPtr_003CIUnknown_003E));
		return tuner2;
	}

	internal unsafe Tuner TPNLGetTunerForIRecorderInfo(CComPtr_003CIRecorderInfo_003E* pRecorderInfo)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIUnknown_003E cComPtr_003CIUnknown_003E);
		*(int*)(&cComPtr_003CIUnknown_003E) = 0;
		Tuner value2;
		try
		{
			int num = *(int*)pRecorderInfo;
			MarshalHelper.ComException(((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, _GUID*, void**, int>)(int)(*(uint*)(int)(*(uint*)num)))((IntPtr)num, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_00000000_0000_0000_c000_000000000046), (void**)(&cComPtr_003CIUnknown_003E)));
			if (*(int*)(&cComPtr_003CIUnknown_003E) == 0)
			{
				throw new ApplicationException("unexpected failure to QI for IUnknown");
			}
			IntPtr intPtr = (IntPtr)(void*)(int)(*(uint*)(&cComPtr_003CIUnknown_003E));
			KeyValuePair<MTAIUnknownType, Tuner> value = default(KeyValuePair<MTAIUnknownType, Tuner>);
			if (m_RecorderInfoDictionary == null || !m_RecorderInfoDictionary.TryGetValue(intPtr, out value))
			{
				KeyValuePair<MTAIUnknownType, Tuner> keyValuePair = new KeyValuePair<MTAIUnknownType, Tuner>(null, TPNLRegisterNewIRecorderInfo(pRecorderInfo, intPtr));
				value = keyValuePair;
			}
			value2 = value.Value;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIUnknown_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIUnknown_003E_002E_007Bdtor_007D), &cComPtr_003CIUnknown_003E);
			throw;
		}
		_003CModule_003E.ATL_002ECComPtrBase_003CIUnknown_003E_002E_007Bdtor_007D((CComPtrBase_003CIUnknown_003E*)(&cComPtr_003CIUnknown_003E));
		return value2;
	}

	internal unsafe Tuner TPGetTunerForIRecorderInfo(CComPtr_003CIRecorderInfo_003E* pRecInfo)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_CacheLock);
		Tuner result;
		try
		{
			@lock = lock2;
			result = TPNLGetTunerForIRecorderInfo(pRecInfo);
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

	public TunerManager(string client)
	{
		m_ClientID = client;
		m_dwMgrConnPtCookie = 0u;
		base._002Ector();
		try
		{
			InteropHelper.smethod_17(new dv0(TPCtor).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::TunerManager", 60000);
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(disposing: true);
			throw;
		}
	}

	public TunerManager()
	{
		m_dwMgrConnPtCookie = 0u;
		base._002Ector();
		try
		{
			InteropHelper.smethod_17(new dv0(TPCtor).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::TunerManager", 60000);
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(disposing: true);
			throw;
		}
	}

	public unsafe TunerManager(IntPtr ptr)
		: base((_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_a43cf053_d95a_4720_aa5d_6277aacff043), (IUnknown*)ptr.ToPointer())
	{
	}

	private void method_3()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		IntPtr intPtr;
		uint dwMgrConnPtCookie;
		SafeRecorderMgrEventHandler pEventHandler;
		try
		{
			@lock = lock2;
			intPtr = handle;
			handle = IntPtr.Zero;
			dwMgrConnPtCookie = m_dwMgrConnPtCookie;
			m_dwMgrConnPtCookie = 0u;
			pEventHandler = m_pEventHandler;
			m_pEventHandler = null;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		if (intPtr != IntPtr.Zero)
		{
			dv3<IntPtr, uint, SafeRecorderMgrEventHandler> dv11 = TPDtor;
			dv11.BeginInvoke(intPtr, dwMgrConnPtCookie, pEventHandler, InteropHelper.smethod_109, dv11);
		}
	}

	public Tuner Connect(Tuner t)
	{
		if (t.IsConnected)
		{
			return _003CModule_003E.smethod_113(t);
		}
		return InteropHelper.smethod_97(new d2<Tuner, RecorderUse, Tuner>(TPAcquireRecorder).BeginInvoke(RecorderUse.ru_AdviseOnly, t, null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::Connect");
	}

	public Tuner Disconnect(Tuner t)
	{
		try
		{
			if (t.IsConnected)
			{
				t.Disconnect();
			}
		}
		catch (COMException)
		{
		}
		return _003CModule_003E.smethod_113(t);
	}

	public Tuner AcquireTunerExclusive(Tuner acquisitionTarget)
	{
		if (acquisitionTarget == null)
		{
			throw new ArgumentException("can't be null", "acquisitionTarget");
		}
		if (acquisitionTarget.IsExclusive)
		{
			return _003CModule_003E.smethod_113(acquisitionTarget);
		}
		return InteropHelper.smethod_97(new d2<Tuner, RecorderUse, Tuner>(TPAcquireRecorder).BeginInvoke(RecorderUse.ru_Exclusive, acquisitionTarget, null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::AcquireTunerExclusive");
	}

	public Tuner AcquireTunerActive(Tuner acquisitionTarget)
	{
		if (acquisitionTarget == null)
		{
			throw new ArgumentException("can't be null", "acquisitionTarget");
		}
		if (!acquisitionTarget.IsExclusive && !acquisitionTarget.IsActive)
		{
			return InteropHelper.smethod_97(new d2<Tuner, RecorderUse, Tuner>(TPAcquireRecorder).BeginInvoke(RecorderUse.ru_Active, acquisitionTarget, null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::AcquireTunerActive");
		}
		return _003CModule_003E.smethod_113(acquisitionTarget);
	}

	public Tuner AcquireTunerPassive(Tuner acquisitionTarget)
	{
		if (acquisitionTarget == null)
		{
			throw new ArgumentException("can't be null", "acquisitionTarget");
		}
		if (!acquisitionTarget.IsExclusive && !acquisitionTarget.IsActive && !acquisitionTarget.IsPassive)
		{
			return InteropHelper.smethod_97(new d2<Tuner, RecorderUse, Tuner>(TPAcquireRecorder).BeginInvoke(RecorderUse.ru_Passive, acquisitionTarget, null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::AcquireTunerPassive");
		}
		return _003CModule_003E.smethod_113(acquisitionTarget);
	}

	public Tuner AcquireTunerScanning(Tuner acquisitionTarget)
	{
		if (acquisitionTarget == null)
		{
			throw new ArgumentException("can't be null", "acquisitionTarget");
		}
		if (acquisitionTarget.IsScanning)
		{
			return _003CModule_003E.smethod_113(acquisitionTarget);
		}
		return InteropHelper.smethod_97(new d2<Tuner, RecorderUse, Tuner>(TPAcquireRecorder).BeginInvoke(RecorderUse.ru_Scanning, acquisitionTarget, null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::AcquireTunerScanning");
	}

	public Tuner AcquireTuner(Tuner acquisitionTarget, RecorderUse mode, string clientName)
	{
		d3<Tuner, RecorderUse, Tuner, string> d5 = null;
		IAsyncResult asyncResult = null;
		if (acquisitionTarget == null)
		{
			throw new ArgumentException("can't be null", "acquisitionTarget");
		}
		try
		{
			d5 = TPAcquireRecorder;
			asyncResult = d5.BeginInvoke(mode, acquisitionTarget, clientName, null, null);
			return InteropHelper.smethod_98(asyncResult, "Microsoft::MediaCenter::TV::Tuners::TunerManager::AcquireTuner");
		}
		catch (COMException ex)
		{
			if (ex.ErrorCode != Errors.HR_DEVICE_IN_USE)
			{
				throw;
			}
		}
		return null;
	}

	public Tuner AcquireTuner(Tuner acquisitionTarget, RecorderUse mode)
	{
		d2<Tuner, RecorderUse, Tuner> d5 = null;
		IAsyncResult asyncResult = null;
		if (acquisitionTarget == null)
		{
			throw new ArgumentException("can't be null", "acquisitionTarget");
		}
		try
		{
			d5 = TPAcquireRecorder;
			asyncResult = d5.BeginInvoke(mode, acquisitionTarget, null, null);
			return InteropHelper.smethod_97(asyncResult, "Microsoft::MediaCenter::TV::Tuners::TunerManager::AcquireTuner");
		}
		catch (COMException ex)
		{
			if (ex.ErrorCode != Errors.HR_DEVICE_IN_USE)
			{
				throw;
			}
		}
		return null;
	}

	public unsafe Tuner GetTunerFromIRecorderPtr(IntPtr rawRecorder, RecorderUse mode)
	{
		d2<Tuner, uint, RecorderUse> d5 = null;
		IAsyncResult asyncResult = null;
		if (rawRecorder == IntPtr.Zero)
		{
			throw new ArgumentException("can't be null", "rawRecorder");
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComPtr_003CIRecorderEx2_003E cComPtr_003CIRecorderEx2_003E);
			*(int*)(&cComPtr_003CIRecorderEx2_003E) = 0;
			Tuner result;
			try
			{
				if (rawRecorder != IntPtr.Zero)
				{
					MarshalHelper.ComException(MTASafeComWrapper.GetNativePtrFromIntPtr(rawRecorder, (_GUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._GUID_706a52d5_e700_4353_8f1c_aa5c5dbb7339), (void**)(&cComPtr_003CIRecorderEx2_003E)));
				}
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CComGITPtr_003CIRecorderEx2_003E cComGITPtr_003CIRecorderEx2_003E);
				_003CModule_003E.ATL_002ECComGITPtr_003CIRecorderEx2_003E_002E_007Bctor_007D(&cComGITPtr_003CIRecorderEx2_003E, (IRecorderEx2*)(int)(*(uint*)(&cComPtr_003CIRecorderEx2_003E)));
				try
				{
					uint a = *(uint*)(&cComGITPtr_003CIRecorderEx2_003E);
					*(int*)(&cComGITPtr_003CIRecorderEx2_003E) = 0;
					d5 = TPNLGetTunerForIRecorderPtr;
					asyncResult = d5.BeginInvoke(a, mode, null, null);
					result = InteropHelper.smethod_99(asyncResult, "Microsoft::MediaCenter::TV::Tuners::TunerManager::GetTunerFromIRecorderPtr");
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComGITPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComGITPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComGITPtr_003CIRecorderEx2_003E);
					throw;
				}
				_003CModule_003E.ATL_002ECComGITPtr_003CIRecorderEx2_003E_002ERevoke(&cComGITPtr_003CIRecorderEx2_003E);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComPtr_003CIRecorderEx2_003E*, void>)(&_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D), &cComPtr_003CIRecorderEx2_003E);
				throw;
			}
			_003CModule_003E.ATL_002ECComPtr_003CIRecorderEx2_003E_002E_007Bdtor_007D(&cComPtr_003CIRecorderEx2_003E);
			return result;
		}
		catch (COMException ex)
		{
			if (ex.ErrorCode != Errors.HR_DEVICE_IN_USE)
			{
				throw;
			}
		}
		return null;
	}

	public Tuner ReleaseTuner(Tuner acquisitionTarget)
	{
		if (acquisitionTarget == null)
		{
			throw new ArgumentException("can't be null", "acquisitionTarget");
		}
		if (!acquisitionTarget.IsConnected)
		{
			return (Tuner)acquisitionTarget.ReferenceClone();
		}
		return InteropHelper.smethod_100(new d1<Tuner, Tuner>(TPReleaseTuner).BeginInvoke(acquisitionTarget, null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::ReleaseTuner");
	}

	public Tuner FindTunerByPbdaTunerId(string pbdaTunerId)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_CacheLock);
		Tuner result;
		try
		{
			@lock = lock2;
			if (m_RecorderIDDictionary != null)
			{
				Dictionary<Guid, Tuner>.Enumerator enumerator = m_RecorderIDDictionary.GetEnumerator();
				if (enumerator.MoveNext())
				{
					while (true)
					{
						Tuner value = enumerator.Current.Value;
						if (!(value.PbdaTunerId == pbdaTunerId))
						{
							if (!enumerator.MoveNext())
							{
								break;
							}
							continue;
						}
						result = (Tuner)value.ReferenceClone();
						goto IL_0072;
					}
				}
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		Tuner result2;
		try
		{
			result2 = null;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return result2;
		IL_0072:
		((IDisposable)@lock).Dispose();
		return result;
	}

	public Tuner FindTunerByDeviceID(Guid deviceId)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_CacheLock);
		Tuner result;
		try
		{
			@lock = lock2;
			if (m_RecorderIDDictionary != null)
			{
				Dictionary<Guid, Tuner>.Enumerator enumerator = m_RecorderIDDictionary.GetEnumerator();
				if (enumerator.MoveNext())
				{
					while (true)
					{
						Tuner value = enumerator.Current.Value;
						if (!(value.DeviceId == deviceId))
						{
							if (!enumerator.MoveNext())
							{
								break;
							}
							continue;
						}
						result = (Tuner)value.ReferenceClone();
						goto IL_0072;
					}
				}
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		Tuner result2;
		try
		{
			result2 = null;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		return result2;
		IL_0072:
		((IDisposable)@lock).Dispose();
		return result;
	}

	public ITunerCollection EnumTuners(TuneRequest tuneRequest, RecorderUse recorderUse, RecorderMgrFlags flags)
	{
		if (tuneRequest == null && recorderUse == RecorderUse.ru_Any)
		{
			FillCache(flags);
			return new TunerCollection(this);
		}
		return InteropHelper.smethod_102(new d3<RemoteTunerCollection, TuneRequest, RecorderUse, RecorderMgrFlags>(TPEnumRecorders).BeginInvoke(tuneRequest, recorderUse, flags, null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::EnumTuners", 60000);
	}

	public unsafe ITunerCollection EnumConfiguredTuners(TuneRequest tuneRequest, RecorderUse recorderUse, RecorderMgrFlags flags)
	{
		if (tuneRequest == null && recorderUse == RecorderUse.ru_Any)
		{
			FillCache(flags);
			return new TunerCollection(this, (delegate*<Tuner, byte>)(delegate*<Tuner, bool>)(&ConfiguredPredicate));
		}
		return InteropHelper.smethod_102(new d3<RemoteTunerCollection, TuneRequest, RecorderUse, RecorderMgrFlags>(TPEnumConfiguredRecorders).BeginInvoke(tuneRequest, recorderUse, flags, null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::EnumConfiguredTuners", 60000);
	}

	public void ResetAllTunerSettings()
	{
		InteropHelper.smethod_1(new dv0(TPResetAllTunerSettings).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::ResetAllTunerSettings");
	}

	public void ResetAllTuners(RecorderMgrFlags flags)
	{
		InteropHelper.smethod_93(new dv1<RecorderMgrFlags>(TPResetAllRecorders).BeginInvoke(flags, null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::ResetAllTuners");
		ClearCache();
	}

	public void StartSearch([MarshalAs(UnmanagedType.U1)] bool block, uint timeOut)
	{
		InteropHelper.smethod_6(new dv2<bool, uint>(TPStartSearch).BeginInvoke(block, timeOut, null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::StartSearch");
	}

	public void CancelSearch()
	{
		InteropHelper.smethod_1(new dv0(TPCancelSearch).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::CancelSearch");
	}

	public void WaitForSearchComplete(uint timeOut)
	{
		InteropHelper.smethod_7(new dv1<uint>(TPWaitForSearchComplete).BeginInvoke(timeOut, null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::WaitForSearchComplete");
	}

	public void ResetAllTunerCaches()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_CacheLock);
		try
		{
			@lock = lock2;
			if (m_RecorderIDDictionary != null)
			{
				Dictionary<Guid, Tuner>.Enumerator enumerator = m_RecorderIDDictionary.GetEnumerator();
				if (enumerator.MoveNext())
				{
					do
					{
						enumerator.Current.Value.ClearCache();
					}
					while (enumerator.MoveNext());
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
	}

	public uint NumConfiguredTuners(TuneRequest tr)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_CacheLock);
		uint num;
		try
		{
			@lock = lock2;
			num = 0u;
			FillCache(RecorderMgrFlags.rmf_WaitAll);
			if (m_RecorderIDDictionary != null)
			{
				Dictionary<Guid, Tuner>.Enumerator enumerator = m_RecorderIDDictionary.GetEnumerator();
				if (enumerator.MoveNext())
				{
					do
					{
						Tuner value = enumerator.Current.Value;
						int num2 = ((tr == null || value.IsConfiguredTuningSpace(tr.get_TuningSpace().get_UniqueName())) ? 1 : 0);
						bool flag = (byte)num2 != 0;
						if (value.IsConfigured && value.Ready && flag)
						{
							num++;
						}
					}
					while (enumerator.MoveNext());
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
		return num;
	}

	public static void DisableConfigChangeNotification()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_CacheLock);
		try
		{
			@lock = lock2;
			m_SuppressConfigEvents = true;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	public static void EnableConfigChangeNotification()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_CacheLock);
		try
		{
			@lock = lock2;
			m_SuppressConfigEvents = false;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	public void ClearCache()
	{
		@lock @lock = null;
		ResetAllTunerCaches();
		@lock lock2 = new @lock(m_CacheLock);
		try
		{
			@lock = lock2;
			InteropHelper.smethod_1(new dv0(TPNLClearCache).BeginInvoke(null, null), "Microsoft::MediaCenter::TV::Tuners::TunerManager::ClearCache");
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	[SpecialName]
	protected void raise_TunerArrivedEvent(object sender, TunerNotificationEventArgs e)
	{
		_003Cbacking_store_003ETunerArrivedEvent?.Invoke(sender, e);
	}

	[SpecialName]
	protected void raise_TunerDepartedEvent(object sender, TunerNotificationEventArgs e)
	{
		_003Cbacking_store_003ETunerDepartedEvent?.Invoke(sender, e);
	}

	[SpecialName]
	protected void raise_TunerConfigChangedEvent(object sender, TunerNotificationEventArgs e)
	{
		_003Cbacking_store_003ETunerConfigChangedEvent?.Invoke(sender, e);
	}

	internal void OnRecorderArrived(Guid guid)
	{
		ResetTunerCache(guid);
		TunerNotificationEventArgs e = new TunerNotificationEventArgs(guid);
		raise_TunerArrivedEvent(this, e);
	}

	internal void OnRecorderDeparted(Guid guid)
	{
		ResetTunerCache(guid);
		TunerNotificationEventArgs e = new TunerNotificationEventArgs(guid);
		raise_TunerDepartedEvent(this, e);
	}

	internal void OnRecorderConfigChanged(Guid guid)
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_CacheLock);
		try
		{
			@lock = lock2;
			if (!m_SuppressConfigEvents)
			{
				goto IL_0029;
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
		IL_0029:
		((IDisposable)@lock).Dispose();
		ResetTunerCache(guid);
		TunerNotificationEventArgs e = new TunerNotificationEventArgs(guid);
		raise_TunerConfigChangedEvent(this, e);
	}

	internal void ResetTunerCache(Guid Id)
	{
		@lock @lock = null;
		bool flag = false;
		Tuner value = null;
		@lock lock2 = new @lock(m_CacheLock);
		try
		{
			@lock = lock2;
			if (m_RecorderIDDictionary != null)
			{
				flag = m_RecorderIDDictionary.TryGetValue(Id, out value);
			}
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
		if (flag)
		{
			value.ClearCache();
		}
	}

	internal int NativeRecorderArrived(_GUID guid)
	{
		dv1<Guid> dv11 = OnRecorderArrived;
		Guid a = default(Guid);
		// IL cpblk instruction
		System.Runtime.CompilerServices.Unsafe.CopyBlock((int)(ref a), ref guid, 16);
		dv11.BeginInvoke(a, InteropHelper.smethod_110, dv11);
		return 0;
	}

	internal int NativeRecorderDeparted(_GUID guid)
	{
		dv1<Guid> dv11 = OnRecorderDeparted;
		Guid a = default(Guid);
		// IL cpblk instruction
		System.Runtime.CompilerServices.Unsafe.CopyBlock((int)(ref a), ref guid, 16);
		dv11.BeginInvoke(a, InteropHelper.smethod_110, dv11);
		return 0;
	}

	internal int NativeRecorderConfigChanged(_GUID guid)
	{
		dv1<Guid> dv11 = OnRecorderConfigChanged;
		Guid a = default(Guid);
		// IL cpblk instruction
		System.Runtime.CompilerServices.Unsafe.CopyBlock((int)(ref a), ref guid, 16);
		dv11.BeginInvoke(a, InteropHelper.smethod_110, dv11);
		return 0;
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool disposing)
	{
		if (disposing)
		{
			try
			{
				method_3();
				return;
			}
			finally
			{
				base.Dispose(disposing: true);
			}
		}
		try
		{
			method_2();
		}
		finally
		{
			base.Dispose(disposing: false);
		}
	}

	~TunerManager()
	{
		Dispose(disposing: false);
	}
}
