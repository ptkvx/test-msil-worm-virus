using System;
using System.Runtime.InteropServices;
using Microsoft.MediaCenter.TV.Tuning;

namespace Microsoft.MediaCenter.TV.Tuners;

public class SmartCardApplicationMarshaler : ICustomMarshaler
{
	private static ICustomMarshaler s_marshaler = null;

	protected SmartCardApplicationMarshaler()
	{
	}

	public static ICustomMarshaler GetInstance(string cookie)
	{
		if (null == s_marshaler)
		{
			s_marshaler = new SmartCardApplicationMarshaler();
		}
		return s_marshaler;
	}

	public unsafe virtual object MarshalNativeToManaged(IntPtr ptr)
	{
		if (IntPtr.Zero == ptr)
		{
			return null;
		}
		global::SmartCardApplication* ptr2 = (global::SmartCardApplication*)ptr.ToPointer();
		uint num = *(uint*)((byte*)ptr2 + 12);
		Uri url = ((num != 0) ? new Uri(new string((char*)(int)num)) : null);
		uint num2 = *(uint*)((byte*)ptr2 + 8);
		return new SmartCardApplication(name: (num2 != 0) ? new string((char*)(int)num2) : "", appType: (ApplicationTypeType)(*(int*)ptr2), version: *(ushort*)((byte*)ptr2 + 4), url: url);
	}

	public unsafe virtual IntPtr MarshalManagedToNative(object obj)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I4, but got Unknown
		if (null == obj)
		{
			return IntPtr.Zero;
		}
		SmartCardApplication smartCardApplication = (SmartCardApplication)obj;
		global::SmartCardApplication* ptr = (global::SmartCardApplication*)_003CModule_003E.CoTaskMemAlloc(16u);
		*(int*)ptr = (int)smartCardApplication.ApplicationType;
		*(ushort*)((byte*)ptr + 4) = smartCardApplication.Version;
		*(int*)((byte*)ptr + 8) = (int)Marshal.StringToBSTR(smartCardApplication.Name).ToPointer();
		*(int*)((byte*)ptr + 12) = (int)Marshal.StringToBSTR(smartCardApplication.URL.ToString()).ToPointer();
		return (IntPtr)ptr;
	}

	public virtual void CleanUpManagedData(object obj)
	{
	}

	public unsafe virtual void CleanUpNativeData(IntPtr ptr)
	{
		global::SmartCardApplication* ptr2 = (global::SmartCardApplication*)ptr.ToPointer();
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)((byte*)ptr2 + 8)));
		*(int*)((byte*)ptr2 + 8) = 0;
		_003CModule_003E.SysFreeString((ushort*)(int)(*(uint*)((byte*)ptr2 + 12)));
		*(int*)((byte*)ptr2 + 12) = 0;
	}

	public virtual int GetNativeDataSize()
	{
		return -1;
	}
}
