using System;
using System.ServiceProcess;

namespace ASInstanceRename;

internal class StartServiceCommand : WaitForService, IInstCommand
{
	private string nameOfService;

	private string description = string.Empty;

	public string Description => description;

	public StartServiceCommand(string nameOfService, string description)
	{
		Argument.NullCheck(nameOfService, "nameOfService");
		Argument.NullCheck(description, "description");
		this.nameOfService = nameOfService;
		this.description = description;
	}

	public void Execute()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		ServiceController val = new ServiceController(nameOfService);
		try
		{
			val.Start();
			if (!WaitForService.Wait(val, (ServiceControllerStatus)4))
			{
				throw new InstanceRenameException(SR.FailedToStartService(nameOfService, 15));
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
