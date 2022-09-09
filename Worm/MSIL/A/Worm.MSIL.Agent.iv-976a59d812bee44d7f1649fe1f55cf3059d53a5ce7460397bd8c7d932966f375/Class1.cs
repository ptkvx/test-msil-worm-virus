using System.ServiceProcess;
using svchost;

internal static class Class1
{
	private static void Main()
	{
		ServiceBase[] array = (ServiceBase[])(object)new ServiceBase[1]
		{
			new Service1()
		};
		ServiceBase.Run(array);
	}
}
