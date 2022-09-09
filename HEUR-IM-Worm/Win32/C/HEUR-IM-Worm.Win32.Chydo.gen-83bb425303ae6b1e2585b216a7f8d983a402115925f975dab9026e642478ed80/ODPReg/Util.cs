using System;
using System.Reflection;

namespace ODPReg;

internal class Util : MarshalByRefObject
{
	internal string FullAssemblyName(string name)
	{
		return Assembly.LoadFrom(name).FullName;
	}
}
