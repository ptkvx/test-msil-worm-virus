using System;
using System.Collections;

namespace ASInstanceRename;

internal class InstCommandInterpreter
{
	private ArrayList listOfCommands = new ArrayList();

	private int countOfExecutedCommands;

	public int CommandsCount => listOfCommands.Count;

	public int ExecutedCommandsCount => countOfExecutedCommands;

	public event InstCommandExceptionEventHandler InstCommandException;

	public void Add(IInstCommand command)
	{
		listOfCommands.Add(command);
	}

	public void ReverseCommands()
	{
		listOfCommands.Reverse();
	}

	public void Execute()
	{
		Execute(0);
	}

	public void Execute(int indexOfFirstCommand)
	{
		countOfExecutedCommands = 0;
		for (int i = indexOfFirstCommand; i < listOfCommands.Count; i++)
		{
			IInstCommand instCommand = (IInstCommand)listOfCommands[i];
			try
			{
				try
				{
					instCommand.Execute();
				}
				finally
				{
					GC.Collect();
					GC.WaitForPendingFinalizers();
				}
			}
			catch (Exception ex)
			{
				InstCommandExceptionEventArgs instCommandExceptionEventArgs = new InstCommandExceptionEventArgs(instCommand, ex);
				OnInstCommandException(instCommandExceptionEventArgs);
				if (!instCommandExceptionEventArgs.Ignore)
				{
					throw;
				}
			}
			countOfExecutedCommands++;
		}
	}

	protected virtual void OnInstCommandException(InstCommandExceptionEventArgs e)
	{
		if (this.InstCommandException != null)
		{
			this.InstCommandException(this, e);
		}
	}
}
