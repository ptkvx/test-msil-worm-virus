using System;
using System.ServiceProcess;

namespace ASInstanceRename;

internal class StopServiceCommand : WaitForService, IInstCommand
{
	private string nameOfService;

	private string description = string.Empty;

	public string Description => description;

	public StopServiceCommand(string nameOfService, string description)
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
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		ServiceController val = new ServiceController(nameOfService);
		try
		{
			if ((int)val.get_Status() != 1)
			{
				val.Stop();
				if (!WaitForService.Wait(val, (ServiceControllerStatus)1))
				{
					throw new InstanceRenameException(SR.FailedToStopService(nameOfService, 15));
				}
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
