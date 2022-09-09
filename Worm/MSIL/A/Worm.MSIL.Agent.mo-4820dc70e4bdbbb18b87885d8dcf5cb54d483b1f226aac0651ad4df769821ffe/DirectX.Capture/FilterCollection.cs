using System;
using System.Collections;
using System.Runtime.InteropServices;
using DShowNET;
using DShowNET.Device;

namespace DirectX.Capture;

public class FilterCollection : CollectionBase
{
	public Filter this[int index] => (Filter)base.InnerList[index];

	internal FilterCollection(Guid category)
	{
		getFilters(category);
	}

	protected void getFilters(Guid category)
	{
		object obj = null;
		ICreateDevEnum createDevEnum = null;
		UCOMIEnumMoniker ppEnumMoniker = null;
		UCOMIMoniker[] array = (UCOMIMoniker[])(object)new UCOMIMoniker[1];
		try
		{
			Type typeFromCLSID = Type.GetTypeFromCLSID(Clsid.SystemDeviceEnum);
			obj = Activator.CreateInstance(typeFromCLSID);
			createDevEnum = (ICreateDevEnum)obj;
			int num = createDevEnum.CreateClassEnumerator(ref category, out ppEnumMoniker, 0);
			int num2 = default(int);
			while (ppEnumMoniker.Next(1, array, ref num2) == 0 && array[0] != null)
			{
				Filter value = new Filter(array[0]);
				base.InnerList.Add(value);
				Marshal.ReleaseComObject(array[0]);
				array[0] = null;
			}
			base.InnerList.Sort();
		}
		finally
		{
			createDevEnum = null;
			if (array[0] != null)
			{
				Marshal.ReleaseComObject(array[0]);
			}
			array[0] = null;
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
}
