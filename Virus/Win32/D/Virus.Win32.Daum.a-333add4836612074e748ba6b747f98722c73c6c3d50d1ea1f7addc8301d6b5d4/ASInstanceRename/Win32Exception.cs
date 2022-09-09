using System;
using System.ComponentModel;

namespace ASInstanceRename;

internal class Win32Exception : InstanceRenameException
{
	public Win32Exception(string nameOfMethod, int errorCode)
		: base(nameOfMethod + " failed with error code: " + errorCode + Environment.NewLine + new System.ComponentModel.Win32Exception(errorCode).Message)
	{
	}

	public static void RaiseExceptionIfCodeIsNot(int errorCode, int errorCodeOK, string nameOfMethod)
	{
		if (errorCode != errorCodeOK)
		{
			throw new Win32Exception(nameOfMethod, errorCode);
		}
	}
}
