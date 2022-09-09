using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ATL;

namespace Microsoft.MediaCenter.TV.Tuners;

public static class MarshalHelper
{
	public unsafe static ushort* StringToBSTR(string s)
	{
		return (ushort*)Marshal.StringToBSTR(s).ToPointer();
	}

	public unsafe static Guid GUIDToGuid(_GUID* g)
	{
		Guid result = default(Guid);
		// IL cpblk instruction
		System.Runtime.CompilerServices.Unsafe.CopyBlock(ref result, g, sizeof(Guid));
		return result;
	}

	public unsafe static Guid BSTRToGuid(ushort* b, [MarshalAs(UnmanagedType.U1)] bool fFree)
	{
		Guid empty = Guid.Empty;
		try
		{
			_GUID gUID_NULL = _003CModule_003E.GUID_NULL;
			ComException(_003CModule_003E.CLSIDFromString(b, &gUID_NULL));
			return GUIDToGuid(&gUID_NULL);
		}
		finally
		{
			if (fFree && null != b)
			{
				_003CModule_003E.SysFreeString(b);
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static int CoTaskStrCpy(ushort** ppDest, string pSrc)
	{
		if (null != ppDest && !(null == pSrc))
		{
			*(int*)ppDest = (int)Marshal.StringToCoTaskMemUni(pSrc).ToPointer();
			return 0;
		}
		return -2147467261;
	}

	[CLSCompliant(false)]
	public unsafe static byte[] BSTRToByteArray(ushort* b)
	{
		int num = (int)_003CModule_003E.SysStringByteLen(b);
		byte[] array = new byte[num];
		Marshal.Copy((IntPtr)b, array, 0, num);
		return array;
	}

	[CLSCompliant(false)]
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

	public static void ThrowExceptionForHR(string errorMessage, int hr)
	{
		switch (hr)
		{
		case -2147024809:
			throw new ArgumentException(errorMessage);
		case -2147024882:
			throw new OutOfMemoryException(errorMessage);
		case -2147352571:
			throw new ArrayTypeMismatchException(errorMessage);
		case -2147467263:
			throw new NotImplementedException();
		}
		Marshal.ThrowExceptionForHR(hr);
	}

	public unsafe static void ComException(int hr)
	{
		if (hr >= 0)
		{
			return;
		}
		string message = string.Empty;
		IErrorInfo* ptr = null;
		if (0 == _003CModule_003E.GetErrorInfo(0u, &ptr))
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CComBSTR cComBSTR);
			*(int*)(&cComBSTR) = 0;
			try
			{
				IErrorInfo* intPtr = ptr;
				if (((delegate* unmanaged[Stdcall, Stdcall]<IntPtr, ushort**, int>)(int)(*(uint*)(*(int*)ptr + 20)))((nint)intPtr, (ushort**)(&cComBSTR)) >= 0 && *(int*)(&cComBSTR) != 0)
				{
					message = Marshal.PtrToStringBSTR((IntPtr)(void*)(int)(*(uint*)(&cComBSTR)));
				}
				_003CModule_003E.SetErrorInfo(0u, null);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<CComBSTR*, void>)(&_003CModule_003E.ATL_002ECComBSTR_002E_007Bdtor_007D), &cComBSTR);
				throw;
			}
			_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)(&cComBSTR)));
		}
		throw new COMException(message, hr);
	}

	public static uint VariantTypeToPB2Type(ushort vt)
	{
		switch (vt)
		{
		case 9:
		case 13:
			return 3u;
		default:
			throw new ArgumentException("The variant type is not supported", "vt");
		case 2:
		case 3:
		case 8:
		case 16:
		case 17:
		case 18:
		case 19:
		case 20:
		case 21:
		case 4095:
			return 1u;
		}
	}

	public static ushort VariantTypeToCFType(ushort vt)
	{
		return (vt == 8) ? ((ushort)1) : ((ushort)0);
	}
}
