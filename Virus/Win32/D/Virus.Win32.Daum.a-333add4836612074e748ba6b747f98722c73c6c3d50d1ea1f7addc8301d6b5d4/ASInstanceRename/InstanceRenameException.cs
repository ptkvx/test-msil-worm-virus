using System;

namespace ASInstanceRename;

internal class InstanceRenameException : ApplicationException
{
	public InstanceRenameException(string message)
		: base(message)
	{
	}
}
