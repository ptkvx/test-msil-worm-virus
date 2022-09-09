using System.Reflection;

namespace ns0;

internal sealed class Class0
{
	private static void Main()
	{
		Assembly assembly = Assembly.Load(Class1.Class);
		assembly.GetType("ClassLibrary1.Class1")!.InvokeMember("Main", BindingFlags.InvokeMethod, null, null, null);
	}
}
