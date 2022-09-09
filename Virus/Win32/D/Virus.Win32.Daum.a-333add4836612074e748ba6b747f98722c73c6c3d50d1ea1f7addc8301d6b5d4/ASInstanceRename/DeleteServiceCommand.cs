using System.Runtime.InteropServices;

namespace ASInstanceRename;

internal class DeleteServiceCommand : IInstCommand
{
	private ServiceHandle serviceManagerHandle;

	private string nameOfService;

	private string description = string.Empty;

	public string Description => description;

	public DeleteServiceCommand(ServiceHandle serviceManagerHandle, string nameOfService, string description)
	{
		ServiceUtils.EnsureServiceHandleValid(serviceManagerHandle, "serviceManagerHandle");
		Argument.NullCheck(nameOfService, "nameOfService");
		Argument.NullCheck(description, "description");
		this.serviceManagerHandle = serviceManagerHandle;
		this.nameOfService = nameOfService;
		this.description = description;
	}

	public static void DeleteService(ServiceHandle serviceManagerHandle, string nameOfService)
	{
		ServiceHandle serviceHandle = ServiceUtils.GetServiceHandle(serviceManagerHandle, nameOfService, 65536);
		try
		{
			if (!NativeMethods.DeleteService(serviceHandle))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				throw new Win32Exception("DeleteServiceCommand.DeleteService", lastWin32Error);
			}
		}
		finally
		{
			serviceHandle.Dispose();
		}
	}

	public void Execute()
	{
		DeleteService(serviceManagerHandle, nameOfService);
	}
}
