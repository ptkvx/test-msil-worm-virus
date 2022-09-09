using System;

namespace ICSharpCode.SharpZipLib;

public class ZipException : Exception
{
	public ZipException()
	{
	}

	public ZipException(string msg)
		: base(msg)
	{
	}
}
