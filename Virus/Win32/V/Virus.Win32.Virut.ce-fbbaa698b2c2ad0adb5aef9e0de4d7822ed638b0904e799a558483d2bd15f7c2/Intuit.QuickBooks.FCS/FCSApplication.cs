using System.Runtime.InteropServices;
using System.ServiceProcess;

namespace Intuit.QuickBooks.FCS;

[ComVisible(false)]
internal class FCSApplication
{
	private static void Main()
	{
		ServiceBase[] array = (ServiceBase[])(object)new ServiceBase[1]
		{
			new FCService()
		};
		ServiceBase.Run(array);
	}
}
