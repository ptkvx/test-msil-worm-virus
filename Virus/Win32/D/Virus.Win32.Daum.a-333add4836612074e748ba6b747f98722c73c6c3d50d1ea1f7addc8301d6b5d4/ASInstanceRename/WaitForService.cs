using System.ServiceProcess;
using System.Threading;

namespace ASInstanceRename;

internal class WaitForService
{
	protected const int NumberOfSecondsToWaitForService = 15;

	protected static bool Wait(ServiceController controller, ServiceControllerStatus status)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		int num = 15;
		controller.Refresh();
		while (controller.get_Status() != status && num > 0)
		{
			Thread.Sleep(1000);
			controller.Refresh();
			num--;
		}
		return controller.get_Status() == status;
	}
}
