using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace DShowNET.Device;

[ComVisible(false)]
public class DsDev
{
	public static bool GetDevicesOfCat(Guid cat, out ArrayList devs)
	{
		devs = null;
		object obj = null;
		ICreateDevEnum createDevEnum = null;
		UCOMIEnumMoniker ppEnumMoniker = null;
		UCOMIMoniker[] array = (UCOMIMoniker[])(object)new UCOMIMoniker[1];
		try
		{
			Type typeFromCLSID = Type.GetTypeFromCLSID(Clsid.SystemDeviceEnum);
			obj = Activator.CreateInstance(typeFromCLSID);
			createDevEnum = (ICreateDevEnum)obj;
			int num = createDevEnum.CreateClassEnumerator(ref cat, out ppEnumMoniker, 0);
			int num2 = 0;
			int num3 = default(int);
			while (ppEnumMoniker.Next(1, array, ref num3) == 0 && array[0] != null)
			{
				DsDevice dsDevice = new DsDevice();
				dsDevice.Name = GetFriendlyName(array[0]);
				if (devs == null)
				{
					devs = new ArrayList();
				}
				dsDevice.Mon = array[0];
				array[0] = null;
				devs.Add(dsDevice);
				dsDevice = null;
				num2++;
			}
			return num2 > 0;
		}
		catch (Exception)
		{
			if (devs != null)
			{
				foreach (DsDevice dev in devs)
				{
					dev.Dispose();
				}
				devs = null;
			}
			return false;
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

	private static string GetFriendlyName(UCOMIMoniker mon)
	{
		object obj = null;
		IPropertyBag propertyBag = null;
		try
		{
			Guid gUID = typeof(IPropertyBag).GUID;
			mon.BindToStorage((UCOMIBindCtx)null, (UCOMIMoniker)null, ref gUID, ref obj);
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
			return null;
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
}
