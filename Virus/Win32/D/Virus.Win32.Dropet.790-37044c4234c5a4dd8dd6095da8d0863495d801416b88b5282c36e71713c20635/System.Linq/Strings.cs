namespace System.Linq;

internal static class Strings
{
	internal static string OwningTeam => SR.GetString("OwningTeam");

	internal static string IncompatibleElementTypes => SR.GetString("IncompatibleElementTypes");

	internal static string MoreThanOneElement => SR.GetString("MoreThanOneElement");

	internal static string MoreThanOneMatch => SR.GetString("MoreThanOneMatch");

	internal static string NoElements => SR.GetString("NoElements");

	internal static string NoMatch => SR.GetString("NoMatch");

	internal static string EmptyEnumerable => SR.GetString("EmptyEnumerable");

	internal static string ArgumentArrayHasTooManyElements(object p0)
	{
		return SR.GetString("ArgumentArrayHasTooManyElements", p0);
	}

	internal static string ArgumentNotIEnumerableGeneric(object p0)
	{
		return SR.GetString("ArgumentNotIEnumerableGeneric", p0);
	}

	internal static string ArgumentNotSequence(object p0)
	{
		return SR.GetString("ArgumentNotSequence", p0);
	}

	internal static string ArgumentNotValid(object p0)
	{
		return SR.GetString("ArgumentNotValid", p0);
	}

	internal static string ArgumentNotLambda(object p0)
	{
		return SR.GetString("ArgumentNotLambda", p0);
	}

	internal static string NoArgumentMatchingMethodsInQueryable(object p0)
	{
		return SR.GetString("NoArgumentMatchingMethodsInQueryable", p0);
	}

	internal static string NoMethodOnType(object p0, object p1)
	{
		return SR.GetString("NoMethodOnType", p0, p1);
	}

	internal static string NoMethodOnTypeMatchingArguments(object p0, object p1)
	{
		return SR.GetString("NoMethodOnTypeMatchingArguments", p0, p1);
	}

	internal static string NoNameMatchingMethodsInQueryable(object p0)
	{
		return SR.GetString("NoNameMatchingMethodsInQueryable", p0);
	}
}
