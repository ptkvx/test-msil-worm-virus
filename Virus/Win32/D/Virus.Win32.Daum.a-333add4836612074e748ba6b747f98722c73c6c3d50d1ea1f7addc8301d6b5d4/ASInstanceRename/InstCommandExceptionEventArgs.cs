using System;

namespace ASInstanceRename;

internal class InstCommandExceptionEventArgs : EventArgs
{
	private IInstCommand command;

	private Exception exception;

	private bool ignore;

	public IInstCommand Command => command;

	public Exception Exception => exception;

	public bool Ignore
	{
		get
		{
			return ignore;
		}
		set
		{
			ignore = value;
		}
	}

	public InstCommandExceptionEventArgs(IInstCommand command, Exception ex)
	{
		Argument.NullCheck(command, "command");
		Argument.NullCheck(ex, "ex");
		this.command = command;
		exception = ex;
	}
}
