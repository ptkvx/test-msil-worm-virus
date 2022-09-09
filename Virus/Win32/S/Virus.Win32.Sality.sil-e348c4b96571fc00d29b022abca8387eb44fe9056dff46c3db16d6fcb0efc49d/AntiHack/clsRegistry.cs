using System;
using Microsoft.Win32;

namespace AntiHack;

public class clsRegistry
{
	public string strRegError;

	public string GetStringValue(RegistryKey hiveKey, string strSubKey, string strValue)
	{
		object obj = null;
		RegistryKey registryKey = null;
		try
		{
			registryKey = hiveKey.OpenSubKey(strSubKey);
			if (registryKey == null)
			{
				strRegError = "Cannot open the specified sub-key";
				return null;
			}
			obj = registryKey.GetValue(strValue);
			if (obj == null)
			{
				strRegError = "Cannot open the specified value";
				return null;
			}
			registryKey.Close();
			hiveKey.Close();
		}
		catch (Exception ex)
		{
			strRegError = ex.Message;
			return null;
		}
		strRegError = null;
		return obj.ToString();
	}

	public uint GetDWORDValue(RegistryKey hiveKey, string strSubKey, string dwValue)
	{
		object obj = null;
		RegistryKey registryKey = null;
		try
		{
			registryKey = hiveKey.OpenSubKey(strSubKey);
			if (registryKey == null)
			{
				strRegError = "Cannot open the specified sub-key";
				return 0u;
			}
			obj = registryKey.GetValue(dwValue);
			if (obj == null)
			{
				strRegError = "Cannot open the specified value";
				return 0u;
			}
			registryKey.Close();
			hiveKey.Close();
		}
		catch (Exception ex)
		{
			strRegError = ex.Message;
			return 0u;
		}
		strRegError = null;
		return uint.Parse(obj.ToString());
	}

	public byte[] GetBinaryValue(RegistryKey hiveKey, string strSubKey, string binValue)
	{
		object obj = null;
		RegistryKey registryKey = null;
		try
		{
			registryKey = hiveKey.OpenSubKey(strSubKey);
			if (registryKey == null)
			{
				strRegError = "Cannot open the specified sub-key";
				return null;
			}
			obj = registryKey.GetValue(binValue);
			if (obj == null)
			{
				strRegError = "Cannot open the specified value";
				return null;
			}
			registryKey.Close();
			hiveKey.Close();
		}
		catch (Exception ex)
		{
			strRegError = ex.Message;
			return null;
		}
		strRegError = null;
		return (byte[])obj;
	}

	public void SetStringValue(RegistryKey hiveKey, string strSubKey, string strValue, string strData)
	{
		RegistryKey registryKey = null;
		try
		{
			registryKey = hiveKey.CreateSubKey(strSubKey);
			if (registryKey == null)
			{
				strRegError = "Cannot create/open the specified sub-key";
				return;
			}
			registryKey.SetValue(strValue, strData);
			registryKey.Close();
			hiveKey.Close();
		}
		catch (Exception ex)
		{
			strRegError = ex.Message;
			return;
		}
		strRegError = null;
	}

	public void SetDWORDValue(RegistryKey hiveKey, string strSubKey, string strValue, int dwData)
	{
		RegistryKey registryKey = null;
		try
		{
			registryKey = hiveKey.CreateSubKey(strSubKey);
			if (registryKey == null)
			{
				strRegError = "Cannot create/open the specified sub-key";
				return;
			}
			registryKey.SetValue(strValue, dwData);
			registryKey.Close();
			hiveKey.Close();
		}
		catch (Exception ex)
		{
			strRegError = ex.Message;
			return;
		}
		strRegError = null;
	}

	public void SetBinaryValue(RegistryKey hiveKey, string strSubKey, string strValue, byte[] nnData)
	{
		RegistryKey registryKey = null;
		try
		{
			registryKey = hiveKey.CreateSubKey(strSubKey);
			if (registryKey == null)
			{
				strRegError = "Cannot create/open the specified sub-key";
				return;
			}
			registryKey.SetValue(strValue, nnData);
			registryKey.Close();
			hiveKey.Close();
		}
		catch (Exception ex)
		{
			strRegError = ex.Message;
			return;
		}
		strRegError = null;
	}

	public void CreateSubKey(RegistryKey hiveKey, string strSubKey)
	{
		RegistryKey registryKey = null;
		try
		{
			registryKey = hiveKey.CreateSubKey(strSubKey);
			if (registryKey == null)
			{
				strRegError = "Cannot create the specified sub-key";
				return;
			}
			registryKey.Close();
			hiveKey.Close();
		}
		catch (Exception ex)
		{
			strRegError = ex.Message;
			return;
		}
		strRegError = null;
	}

	public void DeleteSubKeyTree(RegistryKey hiveKey, string strSubKey)
	{
		try
		{
			hiveKey.DeleteSubKeyTree(strSubKey);
			hiveKey.Close();
		}
		catch (Exception ex)
		{
			strRegError = ex.Message;
			return;
		}
		strRegError = null;
	}

	public void DeleteValue(RegistryKey hiveKey, string strSubKey, string strValue)
	{
		RegistryKey registryKey = null;
		try
		{
			registryKey = hiveKey.OpenSubKey(strSubKey, writable: true);
			if (registryKey == null)
			{
				strRegError = "Cannot open the specified sub-key";
				return;
			}
			registryKey.DeleteValue(strValue);
			registryKey.Close();
			hiveKey.Close();
		}
		catch (Exception ex)
		{
			strRegError = ex.Message;
			return;
		}
		strRegError = null;
	}

	public Type GetValueType(RegistryKey hiveKey, string strSubKey, string strValue)
	{
		RegistryKey registryKey = null;
		object obj = null;
		try
		{
			registryKey = hiveKey.OpenSubKey(strSubKey);
			if (registryKey == null)
			{
				strRegError = "Cannot open the specified sub-key";
				return null;
			}
			obj = registryKey.GetValue(strValue);
			if (obj == null)
			{
				strRegError = "Cannot retrieve the type of the specified value";
				return null;
			}
			registryKey.Close();
			hiveKey.Close();
		}
		catch (Exception ex)
		{
			strRegError = ex.Message;
			return null;
		}
		strRegError = null;
		return obj.GetType();
	}
}
