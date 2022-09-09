using System;
using System.Runtime.InteropServices;

namespace ASInstanceRename;

internal class CreateServiceCommand : IInstCommand
{
	private ServiceHandle serviceManagerHandle;

	private string nameOfService;

	private string displayName;

	private int access;

	private int serviceType;

	private int startType;

	private int errorControl;

	private string moduleFileName;

	private string loadOrderGroup;

	private string dependencies;

	private string userName;

	private string password;

	private string serviceDescription;

	private string description = string.Empty;

	public string Description => description;

	public CreateServiceCommand(ServiceHandle serviceManagerHandle, string nameOfService, string displayName, int access, int serviceType, int startType, int errorControl, string moduleFileName, string loadOrderGroup, string dependencies, string userName, string password, string serviceDescription, string description)
	{
		ServiceUtils.EnsureServiceHandleValid(serviceManagerHandle, "serviceManagerHandle");
		Argument.NullCheck(nameOfService, "nameOfService");
		Argument.NullCheck(userName, "userName");
		Argument.NullCheck(password, "password");
		Argument.NullCheck(description, "description");
		this.serviceManagerHandle = serviceManagerHandle;
		this.nameOfService = nameOfService;
		this.displayName = displayName;
		this.access = access;
		this.serviceType = serviceType;
		this.startType = startType;
		this.errorControl = errorControl;
		this.moduleFileName = moduleFileName;
		this.loadOrderGroup = loadOrderGroup;
		this.dependencies = dependencies;
		this.userName = userName;
		this.password = password;
		this.serviceDescription = serviceDescription;
		this.description = description;
		if (this.userName.Length == 0 && this.password.Length == 0)
		{
			this.userName = null;
		}
	}

	public void Execute()
	{
		ServiceHandle serviceHandle = ServiceHandle.CreateService(serviceManagerHandle, nameOfService, displayName, access, serviceType, startType, errorControl, moduleFileName, loadOrderGroup, IntPtr.Zero, dependencies, userName, password);
		try
		{
			if (serviceHandle.IsInvalid)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				throw new Win32Exception("CreateServiceCommand.Execute", lastWin32Error);
			}
		}
		finally
		{
			serviceHandle.Dispose();
		}
		bool flag = false;
		try
		{
			ServiceUtils.SetServiceDescription(serviceManagerHandle, nameOfService, serviceDescription);
			flag = true;
		}
		finally
		{
			if (!flag)
			{
				DeleteServiceCommand.DeleteService(serviceManagerHandle, nameOfService);
			}
		}
	}
}
