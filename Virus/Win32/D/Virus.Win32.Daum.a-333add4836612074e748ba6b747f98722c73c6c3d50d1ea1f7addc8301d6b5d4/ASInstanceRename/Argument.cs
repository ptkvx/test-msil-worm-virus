using System;

namespace ASInstanceRename;

internal class Argument
{
	public static void NullCheck(object obj, string name)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(name);
		}
	}

	public static void IntPtrZeroCheck(IntPtr handle, string name)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentNullException(name);
		}
	}
}
