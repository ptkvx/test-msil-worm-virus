using System.Collections.Generic;

namespace System.Linq;

internal static class TypeHelper
{
	internal static bool IsEnumerableType(Type enumerableType)
	{
		return (object)FindGenericType(typeof(IEnumerable<>), enumerableType) != null;
	}

	internal static bool IsKindOfGeneric(Type type, Type definition)
	{
		return (object)FindGenericType(definition, type) != null;
	}

	internal static Type GetElementType(Type enumerableType)
	{
		Type type = FindGenericType(typeof(IEnumerable<>), enumerableType);
		if ((object)type != null)
		{
			return type.GetGenericArguments()[0];
		}
		return enumerableType;
	}

	internal static Type FindGenericType(Type definition, Type type)
	{
		while ((object)type != null && (object)type != typeof(object))
		{
			if (!type.IsGenericType || (object)type.GetGenericTypeDefinition() != definition)
			{
				if (definition.IsInterface)
				{
					Type[] interfaces = type.GetInterfaces();
					foreach (Type type2 in interfaces)
					{
						Type type3 = FindGenericType(definition, type2);
						if ((object)type3 != null)
						{
							return type3;
						}
					}
				}
				type = type.BaseType;
				continue;
			}
			return type;
		}
		return null;
	}

	internal static bool IsNullableType(Type type)
	{
		if ((object)type != null && type.IsGenericType)
		{
			return (object)type.GetGenericTypeDefinition() == typeof(Nullable<>);
		}
		return false;
	}

	internal static Type GetNonNullableType(Type type)
	{
		if (IsNullableType(type))
		{
			return type.GetGenericArguments()[0];
		}
		return type;
	}
}
