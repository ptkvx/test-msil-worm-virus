using System;
using System.Reflection;

internal class Class2
{
	internal delegate void Delegate1(object o);

	internal static Module module_0;

	internal static void j4YU1RjjcHO43(int typemdt)
	{
		Type type = module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class2()
	{
		Class3.xfxU1RjzuVJwO();
		base._002Ector();
	}

	static Class2()
	{
		Class3.xfxU1RjzuVJwO();
		module_0 = typeof(Class2).Assembly.ManifestModule;
	}
}
