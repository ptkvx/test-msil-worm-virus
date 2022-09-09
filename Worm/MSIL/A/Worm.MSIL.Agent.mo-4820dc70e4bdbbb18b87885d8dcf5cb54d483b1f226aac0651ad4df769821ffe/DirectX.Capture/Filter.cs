using System;
using System.Runtime.InteropServices;
using DShowNET;
using DShowNET.Device;

namespace DirectX.Capture;

public class Filter : IComparable
{
	public string Name;

	public string MonikerString;

	public Filter(string monikerString)
	{
		Name = getName(monikerString);
		MonikerString = monikerString;
	}

	internal Filter(UCOMIMoniker moniker)
	{
		Name = getName(moniker);
		MonikerString = getMonikerString(moniker);
	}

	protected string getMonikerString(UCOMIMoniker moniker)
	{
		string result = default(string);
		moniker.GetDisplayName((UCOMIBindCtx)null, (UCOMIMoniker)null, ref result);
		return result;
	}

	protected string getName(UCOMIMoniker moniker)
	{
		object obj = null;
		IPropertyBag propertyBag = null;
		try
		{
			Guid gUID = typeof(IPropertyBag).GUID;
			moniker.BindToStorage((UCOMIBindCtx)null, (UCOMIMoniker)null, ref gUID, ref obj);
			propertyBag = (IPropertyBag)obj;
			object pVar = "";
			int num = propertyBag.Read("FriendlyName", ref pVar, IntPtr.Zero);
			if (num != 0)
			{
				Marshal.ThrowExceptionForHR(num);
			}
			return pVar as string;
		}
		catch (Exception)
		{
			return "";
		}
		finally
		{
			propertyBag = null;
			if (obj != null)
			{
				Marshal.ReleaseComObject(obj);
			}
			obj = null;
		}
	}

	protected string getName(string monikerString)
	{
		UCOMIMoniker val = null;
		UCOMIMoniker val2 = null;
		try
		{
			val = getAnyMoniker();
			int num = default(int);
			val.ParseDisplayName((UCOMIBindCtx)null, (UCOMIMoniker)null, monikerString, ref num, ref val2);
			return getName(val);
		}
		finally
		{
			if (val != null)
			{
				Marshal.ReleaseComObject(val);
			}
			val = null;
			if (val2 != null)
			{
				Marshal.ReleaseComObject(val2);
			}
			val2 = null;
		}
	}

	protected UCOMIMoniker getAnyMoniker()
	{
		Guid pType = FilterCategory.VideoCompressorCategory;
		object obj = null;
		ICreateDevEnum createDevEnum = null;
		UCOMIEnumMoniker ppEnumMoniker = null;
		UCOMIMoniker[] array = (UCOMIMoniker[])(object)new UCOMIMoniker[1];
		try
		{
			Type typeFromCLSID = Type.GetTypeFromCLSID(Clsid.SystemDeviceEnum);
			obj = Activator.CreateInstance(typeFromCLSID);
			createDevEnum = (ICreateDevEnum)obj;
			int num = createDevEnum.CreateClassEnumerator(ref pType, out ppEnumMoniker, 0);
			int num2 = default(int);
			if (ppEnumMoniker.Next(1, array, ref num2) != 0)
			{
				array[0] = null;
			}
			return array[0];
		}
		finally
		{
			createDevEnum = null;
			if (ppEnumMoniker != null)
			{
				Marshal.ReleaseComObject(ppEnumMoniker);
			}
			ppEnumMoniker = null;
			if (obj != null)
			{
				Marshal.ReleaseComObject(obj);
			}
			obj = null;
		}
	}

	public int CompareTo(object obj)
	{
		if (obj == null)
		{
			return 1;
		}
		Filter filter = (Filter)obj;
		return Name.CompareTo(filter.Name);
	}
}
