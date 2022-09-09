using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using _003CCppImplementationDetails_003E;
using ATL;
using Microsoft.MediaCenter.TV.Tuning;

namespace Microsoft.MediaCenter.TV.Tuners;

internal sealed class InteropHelper
{
	private static int DEFAULT_CROSSPROC_TIMEOUT = 30000;

	private InteropHelper()
	{
	}

	public static void smethod_0(IAsyncResult r, string errmsg)
	{
		smethod_16(r, errmsg, 30000);
	}

	public static void smethod_1(IAsyncResult r, string errmsg)
	{
		smethod_17(r, errmsg, 30000);
	}

	public static void smethod_2(IAsyncResult r, string errmsg)
	{
		smethod_18(r, errmsg, 30000);
	}

	public static void smethod_3(IAsyncResult r, string errmsg)
	{
		smethod_19(r, errmsg, 30000);
	}

	public static void smethod_4(IAsyncResult r, string errmsg)
	{
		smethod_20(r, errmsg, 30000);
	}

	public static void smethod_5(IAsyncResult r, string errmsg)
	{
		smethod_21(r, errmsg, 30000);
	}

	public static void smethod_6(IAsyncResult r, string errmsg)
	{
		smethod_22(r, errmsg, 30000);
	}

	public static void smethod_7(IAsyncResult r, string errmsg)
	{
		smethod_23(r, errmsg, 30000);
	}

	public static void smethod_8(IAsyncResult r, string errmsg)
	{
		smethod_24(r, errmsg, 30000);
	}

	public static void smethod_9(IAsyncResult r, string errmsg)
	{
		smethod_25(r, errmsg, 30000);
	}

	public static void smethod_10(IAsyncResult r, string errmsg)
	{
		smethod_26(r, errmsg, 30000);
	}

	public static void smethod_11(IAsyncResult r, string errmsg)
	{
		smethod_27(r, errmsg, 30000);
	}

	public static void smethod_12(IAsyncResult r, string errmsg)
	{
		smethod_28(r, errmsg, 30000);
	}

	public static void smethod_13(IAsyncResult r, string errmsg)
	{
		smethod_29(r, errmsg, 30000);
	}

	public static void smethod_14(IAsyncResult r, string errmsg)
	{
		smethod_30(r, errmsg, 30000);
	}

	public static void smethod_15(IAsyncResult r, string errmsg)
	{
		smethod_31(r, errmsg, 30000);
	}

	public unsafe static void smethod_16(IAsyncResult r, string errmsg, int timeOut)
	{
		dv2<Guid, IntPtr> asyncDelegate = (dv2<Guid, IntPtr>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static void smethod_17(IAsyncResult r, string errmsg, int timeOut)
	{
		dv0 asyncDelegate = (dv0)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static void smethod_18(IAsyncResult r, string errmsg, int timeOut)
	{
		dv1<SafeRecorder> asyncDelegate = (dv1<SafeRecorder>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static void smethod_19(IAsyncResult r, string errmsg, int timeOut)
	{
		dv1<TuneRequest> asyncDelegate = (dv1<TuneRequest>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static void smethod_20(IAsyncResult r, string errmsg, int timeOut)
	{
		dv1<int> asyncDelegate = (dv1<int>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static void smethod_21(IAsyncResult r, string errmsg, int timeOut)
	{
		dv1<bool> asyncDelegate = (dv1<bool>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static void smethod_22(IAsyncResult r, string errmsg, int timeOut)
	{
		dv2<bool, uint> asyncDelegate = (dv2<bool, uint>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static void smethod_23(IAsyncResult r, string errmsg, int timeOut)
	{
		dv1<uint> asyncDelegate = (dv1<uint>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static void smethod_24(IAsyncResult r, string errmsg, int timeOut)
	{
		dv10<TuneRequest, bool, byte[], string, uint, uint, bool, bool, bool, string[]> asyncDelegate = (dv10<TuneRequest, bool, byte[], string, uint, uint, bool, bool, bool, string[]>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static void smethod_25(IAsyncResult r, string errmsg, int timeOut)
	{
		dv2<byte, MMICloseReasonType> asyncDelegate = (dv2<byte, MMICloseReasonType>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static void smethod_26(IAsyncResult r, string errmsg, int timeOut)
	{
		dv2<uint, string> asyncDelegate = (dv2<uint, string>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static void smethod_27(IAsyncResult r, string errmsg, int timeOut)
	{
		dv1<byte[]> asyncDelegate = (dv1<byte[]>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static void smethod_28(IAsyncResult r, string errmsg, int timeOut)
	{
		dv2<uint, byte[]> asyncDelegate = (dv2<uint, byte[]>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static void smethod_29(IAsyncResult r, string errmsg, int timeOut)
	{
		dv4<string, string, uint, bool> asyncDelegate = (dv4<string, string, uint, bool>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static void smethod_30(IAsyncResult r, string errmsg, int timeOut)
	{
		dv1<TunerUseReason> asyncDelegate = (dv1<TunerUseReason>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static void smethod_31(IAsyncResult r, string errmsg, int timeOut)
	{
		dv1<Guid> asyncDelegate = (dv1<Guid>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public static RecorderUse smethod_32(IAsyncResult r, string errmsg)
	{
		return smethod_49(r, errmsg, 30000);
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public static bool smethod_33(IAsyncResult r, string errmsg)
	{
		return smethod_50(r, errmsg, 30000);
	}

	public static string smethod_34(IAsyncResult r, string errmsg)
	{
		return smethod_51(r, errmsg, 30000);
	}

	public static ulong smethod_35(IAsyncResult r, string errmsg)
	{
		return smethod_52(r, errmsg, 30000);
	}

	public static int smethod_36(IAsyncResult r, string errmsg)
	{
		return smethod_53(r, errmsg, 30000);
	}

	public static string smethod_37(IAsyncResult r, string errmsg)
	{
		return smethod_54(r, errmsg, 30000);
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public static bool smethod_38(IAsyncResult r, string errmsg)
	{
		return smethod_55(r, errmsg, 30000);
	}

	public static SmartCardApplication[] smethod_39(IAsyncResult r, string errmsg)
	{
		return smethod_56(r, errmsg, 30000);
	}

	public static object smethod_40(IAsyncResult r, string errmsg)
	{
		return smethod_57(r, errmsg, 30000);
	}

	public static uint smethod_41(IAsyncResult r, string errmsg)
	{
		return smethod_58(r, errmsg, 30000);
	}

	public static uint smethod_42(IAsyncResult r, string errmsg)
	{
		return smethod_59(r, errmsg, 30000);
	}

	public static uint smethod_43(IAsyncResult r, string errmsg)
	{
		return smethod_60(r, errmsg, 30000);
	}

	public static string smethod_44(IAsyncResult r, string errmsg)
	{
		return smethod_61(r, errmsg, 30000);
	}

	public static string smethod_45(IAsyncResult r, string errmsg)
	{
		return smethod_62(r, errmsg, 30000);
	}

	public static uint smethod_46(IAsyncResult r, string errmsg)
	{
		return smethod_63(r, errmsg, 30000);
	}

	public static uint smethod_47(IAsyncResult r, string errmsg)
	{
		return smethod_64(r, errmsg, 30000);
	}

	public static uint smethod_48(IAsyncResult r, string errmsg)
	{
		return smethod_65(r, errmsg, 30000);
	}

	public unsafe static RecorderUse smethod_49(IAsyncResult r, string errmsg, int timeOut)
	{
		d0<RecorderUse> asyncDelegate = (d0<RecorderUse>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (RecorderUse)obj;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static bool smethod_50(IAsyncResult r, string errmsg, int timeOut)
	{
		d1<bool, TuneRequest> asyncDelegate = (d1<bool, TuneRequest>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (bool)obj;
	}

	public unsafe static string smethod_51(IAsyncResult r, string errmsg, int timeOut)
	{
		d0<string> asyncDelegate = (d0<string>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (string)obj;
	}

	public unsafe static ulong smethod_52(IAsyncResult r, string errmsg, int timeOut)
	{
		d1<ulong, RecorderStreamType> asyncDelegate = (d1<ulong, RecorderStreamType>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (ulong)obj;
	}

	public unsafe static int smethod_53(IAsyncResult r, string errmsg, int timeOut)
	{
		d0<int> asyncDelegate = (d0<int>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (int)obj;
	}

	public unsafe static string smethod_54(IAsyncResult r, string errmsg, int timeOut)
	{
		d1<string, byte> asyncDelegate = (d1<string, byte>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (string)obj;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static bool smethod_55(IAsyncResult r, string errmsg, int timeOut)
	{
		d0<bool> asyncDelegate = (d0<bool>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (bool)obj;
	}

	public unsafe static SmartCardApplication[] smethod_56(IAsyncResult r, string errmsg, int timeOut)
	{
		d0<SmartCardApplication[]> asyncDelegate = (d0<SmartCardApplication[]>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (SmartCardApplication[])obj;
	}

	public unsafe static object smethod_57(IAsyncResult r, string errmsg, int timeOut)
	{
		d1<object, string> asyncDelegate = (d1<object, string>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			return asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static uint smethod_58(IAsyncResult r, string errmsg, int timeOut)
	{
		d4<uint, BDA_CONDITIONALACCESS_REQUESTTYPE, byte[], bool, string> asyncDelegate = (d4<uint, BDA_CONDITIONALACCESS_REQUESTTYPE, byte[], bool, string>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (uint)obj;
	}

	public unsafe static uint smethod_59(IAsyncResult r, string errmsg, int timeOut)
	{
		d3<uint, uint, bool, string> asyncDelegate = (d3<uint, uint, bool, string>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (uint)obj;
	}

	public unsafe static uint smethod_60(IAsyncResult r, string errmsg, int timeOut)
	{
		d4<uint, uint, BDA_CONDITIONALACCESS_MMICLOSEREASON, bool, string> asyncDelegate = (d4<uint, uint, BDA_CONDITIONALACCESS_MMICLOSEREASON, bool, string>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (uint)obj;
	}

	public unsafe static string smethod_61(IAsyncResult r, string errmsg, int timeOut)
	{
		d1<string, uint> asyncDelegate = (d1<string, uint>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (string)obj;
	}

	public unsafe static string smethod_62(IAsyncResult r, string errmsg, int timeOut)
	{
		d2<string, string, string> asyncDelegate = (d2<string, string, string>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (string)obj;
	}

	public unsafe static uint smethod_63(IAsyncResult r, string errmsg, int timeOut)
	{
		d4<uint, string, string, bool, string> asyncDelegate = (d4<uint, string, string, bool, string>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (uint)obj;
	}

	public unsafe static uint smethod_64(IAsyncResult r, string errmsg, int timeOut)
	{
		d3<uint, bool, byte[], string> asyncDelegate = (d3<uint, bool, byte[], string>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (uint)obj;
	}

	public unsafe static uint smethod_65(IAsyncResult r, string errmsg, int timeOut)
	{
		d0<uint> asyncDelegate = (d0<uint>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (uint)obj;
	}

	public static void smethod_66(IAsyncResult r)
	{
		dv1<IntPtr> asyncState = (dv1<IntPtr>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_67(IAsyncResult r)
	{
		dv2<IntPtr, SafeRecorder> asyncState = (dv2<IntPtr, SafeRecorder>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_68(IAsyncResult r)
	{
		dv1<string> asyncState = (dv1<string>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_69(IAsyncResult r)
	{
		dv1<bool> asyncState = (dv1<bool>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_70(IAsyncResult r)
	{
		dv2<uint, uint> asyncState = (dv2<uint, uint>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_71(IAsyncResult r)
	{
		dv1<TuneRequest> asyncState = (dv1<TuneRequest>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_72(IAsyncResult r)
	{
		dv1<int> asyncState = (dv1<int>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_73(IAsyncResult r)
	{
		dv2<ushort, ushort> asyncState = (dv2<ushort, ushort>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_74(IAsyncResult r)
	{
		dv0 asyncState = (dv0)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_75(IAsyncResult r)
	{
		dv1<int> asyncState = (dv1<int>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_76(IAsyncResult r)
	{
		dv3<RecorderStreamType, RecorderBitRateChangeType, ulong> asyncState = (dv3<RecorderStreamType, RecorderBitRateChangeType, ulong>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_77(IAsyncResult r)
	{
		dv2<RecorderUse, RecorderUse> asyncState = (dv2<RecorderUse, RecorderUse>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_78(IAsyncResult r)
	{
		dv6<EnTvRat_System, EnTvRat_GenericLevel, BfEnTvRat_GenericAttributes, EnTvRat_System, EnTvRat_GenericLevel, BfEnTvRat_GenericAttributes> asyncState = (dv6<EnTvRat_System, EnTvRat_GenericLevel, BfEnTvRat_GenericAttributes, EnTvRat_System, EnTvRat_GenericLevel, BfEnTvRat_GenericAttributes>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_79(IAsyncResult r)
	{
		dv1<ProtType> asyncState = (dv1<ProtType>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_80(IAsyncResult r)
	{
		dv2<uint, EasPriorityType> asyncState = (dv2<uint, EasPriorityType>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_81(IAsyncResult r)
	{
		dv2<bool, uint> asyncState = (dv2<bool, uint>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_82(IAsyncResult r)
	{
		dv1<CasCardStatusType> asyncState = (dv1<CasCardStatusType>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_83(IAsyncResult r)
	{
		dv1<DrmPairingStatus> asyncState = (dv1<DrmPairingStatus>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_84(IAsyncResult r)
	{
		dv1<CasEntitlementType> asyncState = (dv1<CasEntitlementType>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public unsafe static void AsyncWait(void* h, string errmsg, int timeOut)
	{
		try
		{
			InternalAsyncWait(h, errmsg, timeOut);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public static bool smethod_85(Exception source)
	{
		return source is TargetInvocationException;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public static bool smethod_86(Exception source)
	{
		return source is TypeInitializationException;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public static bool smethod_87(Exception source)
	{
		return source is COMException;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public static bool smethod_88(Exception source)
	{
		return source is InvalidComObjectException;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public static bool smethod_89(Exception source)
	{
		return source is TimeoutException;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public static bool smethod_90(Exception source)
	{
		return source is OperationCanceledException;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public static bool smethod_91(Exception source)
	{
		return source is ApplicationException;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public static bool smethod_92(Exception source)
	{
		return source is UriFormatException;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public static bool FilterException(Exception e)
	{
		if (e == null)
		{
			throw new NullReferenceException();
		}
		Exception ex = e;
		if (e is TargetInvocationException || e is TypeInitializationException)
		{
			Exception innerException = e.InnerException;
			if (innerException == null)
			{
				return false;
			}
			ex = innerException;
		}
		if (!(ex is COMException) && !(ex is InvalidComObjectException))
		{
			if (ex is TimeoutException)
			{
				throw new COMException(ex.Message, -2147467260);
			}
			if (!(ex is OperationCanceledException) && !(ex is ApplicationException) && !(ex is UriFormatException))
			{
				return false;
			}
		}
		return true;
	}

	public unsafe static void InternalAsyncWait(void* h, string errmsg, int timeOut)
	{
		Exception ex = null;
		Stopwatch stopwatch = Stopwatch.StartNew();
		double num = timeOut;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out tagMSG tagMSG);
		while (true)
		{
			TimeSpan elapsed = stopwatch.Elapsed;
			uint uint_ = 0u;
			if (elapsed.TotalMilliseconds < num)
			{
				uint_ = (uint)timeOut - (uint)elapsed.TotalMilliseconds;
			}
			switch (_003CModule_003E.MsgWaitForMultipleObjectsEx(1u, &h, uint_, 1279u, 2u))
			{
			default:
				if (_003CModule_003E.PeekMessageW(&tagMSG, null, 0u, 0u, 1u) != 0)
				{
					do
					{
						if (System.Runtime.CompilerServices.Unsafe.As<tagMSG, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref tagMSG, 4)) != 18)
						{
							_003CModule_003E.DispatchMessageW(&tagMSG);
						}
						else
						{
							ex = new OperationCanceledException(errmsg + " WM_QUIT");
						}
					}
					while (_003CModule_003E.PeekMessageW(&tagMSG, null, 0u, 0u, 1u) != 0);
				}
				if (ex == null)
				{
					break;
				}
				goto IL_00d0;
			case uint.MaxValue:
				ex = new ApplicationException(errmsg + " MsgWaitMulti WAIT_FAILED");
				goto case 0u;
			case 258u:
				ex = new TimeoutException($" Timeout of {timeOut} ms exceeded for async wait in {errmsg}");
				goto case 0u;
			case 0u:
				{
					if (ex == null)
					{
						return;
					}
					goto IL_00d0;
				}
				IL_00d0:
				throw ex;
			}
		}
	}

	public unsafe static Guid BSTRToGuid(ushort* bstr)
	{
		_GUID gUID_NULL = _003CModule_003E.GUID_NULL;
		MarshalHelper.ComException(_003CModule_003E.CLSIDFromString(bstr, &gUID_NULL));
		return *(Guid*)(int)(ref gUID_NULL);
	}

	public unsafe static string[] SafeArrayToStringArray(tagSAFEARRAY** ppsa)
	{
		if (_003CModule_003E.SafeArrayGetDim((tagSAFEARRAY*)(int)(*(uint*)ppsa)) != 1)
		{
			throw new ArgumentException("must be 1 dimension");
		}
		int num = *(int*)ppsa;
		int num2 = *(int*)(num + 16);
		if (num2 == 0)
		{
			return null;
		}
		ushort** ptr = null;
		string[] array = new string[num2];
		MarshalHelper.ComException(_003CModule_003E.SafeArrayAccessData((tagSAFEARRAY*)num, (void**)(&ptr)));
		int num3 = 0;
		if (0 < num2)
		{
			do
			{
				string value = null;
				ushort** ptr2 = (ushort**)(num3 * 4 + (byte*)ptr);
				if (*(int*)ptr2 != 0)
				{
					value = new string((char*)(int)(*(uint*)ptr2));
				}
				array.SetValue(value, num3);
				num3++;
			}
			while (num3 < num2);
		}
		MarshalHelper.ComException(_003CModule_003E.SafeArrayUnaccessData((tagSAFEARRAY*)(int)(*(uint*)ppsa)));
		MarshalHelper.ComException(_003CModule_003E.SafeArrayDestroy((tagSAFEARRAY*)(int)(*(uint*)ppsa)));
		*(int*)ppsa = 0;
		return array;
	}

	public unsafe static void StringArrayToSafeArray(tagSAFEARRAY** ppsaTo, string[] strings)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct19 @struct);
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 4), 0, 4);
		System.Runtime.CompilerServices.Unsafe.As<Struct19, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 4)) = 0;
		*(int*)(&@struct) = strings.Length;
		tagSAFEARRAY* ptr = _003CModule_003E.SafeArrayCreate(8, 1u, (tagSAFEARRAYBOUND*)(&@struct));
		*(int*)ppsaTo = (int)ptr;
		if (ptr == null)
		{
			throw new OutOfMemoryException("SafeArrayCreate Failed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort** ptr2);
		MarshalHelper.ComException(_003CModule_003E.SafeArrayAccessData(ptr, (void**)(&ptr2)));
		int num = 0;
		if (0 < (nint)strings.LongLength)
		{
			do
			{
				IntPtr intPtr = Marshal.StringToBSTR((string)strings.GetValue(num));
				*(int*)(num * 4 + (byte*)ptr2) = (int)intPtr.ToPointer();
				num++;
			}
			while (num < (nint)strings.LongLength);
		}
		MarshalHelper.ComException(_003CModule_003E.SafeArrayUnaccessData((tagSAFEARRAY*)(int)(*(uint*)ppsaTo)));
	}

	public unsafe static Guid[] SafeArrayToGuidArray(tagSAFEARRAY** ppsa)
	{
		if (_003CModule_003E.SafeArrayGetDim((tagSAFEARRAY*)(int)(*(uint*)ppsa)) != 1)
		{
			throw new ArgumentException("must be 1 dimension");
		}
		int num = *(int*)ppsa;
		int num2 = *(int*)(num + 16);
		if (num2 == 0)
		{
			return null;
		}
		ushort** ptr = null;
		Guid[] array = new Guid[num2];
		MarshalHelper.ComException(_003CModule_003E.SafeArrayAccessData((tagSAFEARRAY*)num, (void**)(&ptr)));
		int num3 = 0;
		if (0 < num2)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
			do
			{
				_003CModule_003E.ATL_002ECComBSTR_002E_007Bctor_007D(&cComBSTR, (ushort*)(int)(*(uint*)(num3 * 4 + (byte*)ptr)));
				try
				{
					Guid guid = BSTRToGuid((ushort*)(int)(*(uint*)(&cComBSTR)));
					array.SetValue(guid, num3);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
					throw;
				}
				_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
				num3++;
			}
			while (num3 < num2);
		}
		MarshalHelper.ComException(_003CModule_003E.SafeArrayUnaccessData((tagSAFEARRAY*)(int)(*(uint*)ppsa)));
		MarshalHelper.ComException(_003CModule_003E.SafeArrayDestroy((tagSAFEARRAY*)(int)(*(uint*)ppsa)));
		*(int*)ppsa = 0;
		return array;
	}

	public unsafe static byte[] SafeArrayToByteArray(tagSAFEARRAY** ppsa)
	{
		if (_003CModule_003E.SafeArrayGetDim((tagSAFEARRAY*)(int)(*(uint*)ppsa)) != 1)
		{
			throw new ArgumentException("must be 1 dimension");
		}
		int num = *(int*)ppsa;
		int num2 = *(int*)(num + 16);
		if (num2 == 0)
		{
			return null;
		}
		byte* ptr = null;
		byte[] array = new byte[num2];
		MarshalHelper.ComException(_003CModule_003E.SafeArrayAccessData((tagSAFEARRAY*)num, (void**)(&ptr)));
		int num3 = 0;
		if (0 < num2)
		{
			do
			{
				array.SetValue(*(num3 + ptr), num3);
				num3++;
			}
			while (num3 < num2);
		}
		MarshalHelper.ComException(_003CModule_003E.SafeArrayUnaccessData((tagSAFEARRAY*)(int)(*(uint*)ppsa)));
		MarshalHelper.ComException(_003CModule_003E.SafeArrayDestroy((tagSAFEARRAY*)(int)(*(uint*)ppsa)));
		*(int*)ppsa = 0;
		return array;
	}

	public unsafe static void ByteArrayToSafeArray(tagSAFEARRAY** ppsaTo, byte[] value)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct19 @struct);
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 4), 0, 4);
		System.Runtime.CompilerServices.Unsafe.As<Struct19, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 4)) = 0;
		*(int*)(&@struct) = value.Length;
		tagSAFEARRAY* ptr = _003CModule_003E.SafeArrayCreate(17, 1u, (tagSAFEARRAYBOUND*)(&@struct));
		*(int*)ppsaTo = (int)ptr;
		if (ptr == null)
		{
			throw new OutOfMemoryException("SafeArrayCreate Failed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte* ptr2);
		MarshalHelper.ComException(_003CModule_003E.SafeArrayAccessData(ptr, (void**)(&ptr2)));
		int num = 0;
		if (0 < (nint)value.LongLength)
		{
			do
			{
				*(num + ptr2) = (byte)value.GetValue(num);
				num++;
			}
			while (num < (nint)value.LongLength);
		}
		MarshalHelper.ComException(_003CModule_003E.SafeArrayUnaccessData((tagSAFEARRAY*)(int)(*(uint*)ppsaTo)));
	}

	public unsafe static void ByteArrayToBSTR(ushort** to, byte[] from)
	{
		int num = from.Length;
		ushort* ptr = _003CModule_003E.SysAllocStringByteLen(null, (uint)num);
		*(int*)to = (int)ptr;
		if (null == ptr)
		{
			throw new OutOfMemoryException("SysAllocString failed");
		}
		IntPtr destination = (IntPtr)ptr;
		Marshal.Copy(from, 0, destination, num);
	}

	public unsafe static byte[] BSTRToByteArray(ushort* b)
	{
		int num = (int)_003CModule_003E.SysStringByteLen(b);
		byte[] array = new byte[num];
		Marshal.Copy((IntPtr)b, array, 0, num);
		return array;
	}

	public unsafe static string ByteArrayToString(byte[] from)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
		*(int*)(&cComBSTR) = 0;
		string result;
		try
		{
			ByteArrayToBSTR((ushort**)(&cComBSTR), from);
			if (!(*(int*)(&cComBSTR) == 0))
			{
				result = new string((char*)(int)(*(uint*)(&cComBSTR)));
				goto IL_0034;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		string result2;
		try
		{
			result2 = null;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		return result2;
		IL_0034:
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		return result;
	}

	public unsafe static byte[] StringToByteArray(string from)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
		*(int*)(&cComBSTR) = 0;
		byte[] result;
		try
		{
			ushort* ptr = (ushort*)Marshal.StringToBSTR(from).ToPointer();
			if (null != ptr)
			{
				_003CModule_003E.SysFreeString(null);
				*(int*)(&cComBSTR) = (int)ptr;
			}
			result = BSTRToByteArray((ushort*)(int)(*(uint*)(&cComBSTR)));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
			throw;
		}
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		return result;
	}

	public static void smethod_93(IAsyncResult r, string errmsg)
	{
		smethod_94(r, errmsg, 30000);
	}

	public unsafe static void smethod_94(IAsyncResult r, string errmsg, int timeOut)
	{
		dv1<RecorderMgrFlags> asyncDelegate = (dv1<RecorderMgrFlags>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public static RemoteTunerEnumerator smethod_95(IAsyncResult r, string errmsg)
	{
		return smethod_103(r, errmsg, 30000);
	}

	public static object smethod_96(IAsyncResult r, string errmsg)
	{
		return smethod_104(r, errmsg, 30000);
	}

	public static Tuner smethod_97(IAsyncResult r, string errmsg)
	{
		return smethod_105(r, errmsg, 30000);
	}

	public static Tuner smethod_98(IAsyncResult r, string errmsg)
	{
		return smethod_106(r, errmsg, 30000);
	}

	public static Tuner smethod_99(IAsyncResult r, string errmsg)
	{
		return smethod_107(r, errmsg, 30000);
	}

	public static Tuner smethod_100(IAsyncResult r, string errmsg)
	{
		return smethod_108(r, errmsg, 30000);
	}

	public unsafe static Tuner smethod_101(IAsyncResult r, string errmsg, int timeOut)
	{
		d1<Tuner, Guid> asyncDelegate = (d1<Tuner, Guid>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (Tuner)obj;
	}

	public unsafe static RemoteTunerCollection smethod_102(IAsyncResult r, string errmsg, int timeOut)
	{
		d3<RemoteTunerCollection, TuneRequest, RecorderUse, RecorderMgrFlags> asyncDelegate = (d3<RemoteTunerCollection, TuneRequest, RecorderUse, RecorderMgrFlags>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (RemoteTunerCollection)obj;
	}

	public unsafe static RemoteTunerEnumerator smethod_103(IAsyncResult r, string errmsg, int timeOut)
	{
		d0<RemoteTunerEnumerator> asyncDelegate = (d0<RemoteTunerEnumerator>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (RemoteTunerEnumerator)obj;
	}

	public unsafe static object smethod_104(IAsyncResult r, string errmsg, int timeOut)
	{
		d0<object> asyncDelegate = (d0<object>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			return asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
	}

	public unsafe static Tuner smethod_105(IAsyncResult r, string errmsg, int timeOut)
	{
		d2<Tuner, RecorderUse, Tuner> asyncDelegate = (d2<Tuner, RecorderUse, Tuner>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (Tuner)obj;
	}

	public unsafe static Tuner smethod_106(IAsyncResult r, string errmsg, int timeOut)
	{
		d3<Tuner, RecorderUse, Tuner, string> asyncDelegate = (d3<Tuner, RecorderUse, Tuner, string>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (Tuner)obj;
	}

	public unsafe static Tuner smethod_107(IAsyncResult r, string errmsg, int timeOut)
	{
		d2<Tuner, uint, RecorderUse> asyncDelegate = (d2<Tuner, uint, RecorderUse>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (Tuner)obj;
	}

	public unsafe static Tuner smethod_108(IAsyncResult r, string errmsg, int timeOut)
	{
		d1<Tuner, Tuner> asyncDelegate = (d1<Tuner, Tuner>)((AsyncResult)((r is AsyncResult) ? r : null)).get_AsyncDelegate();
		WaitHandle asyncWaitHandle = r.AsyncWaitHandle;
		object obj = null;
		AsyncWait((void*)asyncWaitHandle.Handle, errmsg, timeOut);
		try
		{
			obj = asyncDelegate.EndInvoke(r);
		}
		finally
		{
			asyncWaitHandle.Close();
		}
		return (Tuner)obj;
	}

	public static void smethod_109(IAsyncResult r)
	{
		dv3<IntPtr, uint, SafeRecorderMgrEventHandler> asyncState = (dv3<IntPtr, uint, SafeRecorderMgrEventHandler>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_110(IAsyncResult r)
	{
		dv1<Guid> asyncState = (dv1<Guid>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_111(IAsyncResult r)
	{
		dv1<Tuner> asyncState = (dv1<Tuner>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}

	public static void smethod_112(IAsyncResult r)
	{
		dv1<MTAIUnknownType> asyncState = (dv1<MTAIUnknownType>)r.AsyncState;
		try
		{
			asyncState.EndInvoke(r);
		}
		catch (Exception e)
		{
			if (!FilterException(e))
			{
				throw;
			}
		}
	}
}
