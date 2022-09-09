using System.Globalization;
using System.Resources;
using System.Threading;

namespace System.Linq;

internal sealed class SR
{
	internal const string OwningTeam = "OwningTeam";

	internal const string ArgumentArrayHasTooManyElements = "ArgumentArrayHasTooManyElements";

	internal const string ArgumentNotIEnumerableGeneric = "ArgumentNotIEnumerableGeneric";

	internal const string ArgumentNotSequence = "ArgumentNotSequence";

	internal const string ArgumentNotValid = "ArgumentNotValid";

	internal const string IncompatibleElementTypes = "IncompatibleElementTypes";

	internal const string ArgumentNotLambda = "ArgumentNotLambda";

	internal const string MoreThanOneElement = "MoreThanOneElement";

	internal const string MoreThanOneMatch = "MoreThanOneMatch";

	internal const string NoArgumentMatchingMethodsInQueryable = "NoArgumentMatchingMethodsInQueryable";

	internal const string NoElements = "NoElements";

	internal const string NoMatch = "NoMatch";

	internal const string NoMethodOnType = "NoMethodOnType";

	internal const string NoMethodOnTypeMatchingArguments = "NoMethodOnTypeMatchingArguments";

	internal const string NoNameMatchingMethodsInQueryable = "NoNameMatchingMethodsInQueryable";

	internal const string EmptyEnumerable = "EmptyEnumerable";

	private static SR loader;

	private ResourceManager resources;

	private static CultureInfo Culture => null;

	public static ResourceManager Resources => GetLoader().resources;

	internal SR()
	{
		resources = new ResourceManager("System.Linq", GetType().Assembly);
	}

	private static SR GetLoader()
	{
		if (loader == null)
		{
			SR value = new SR();
			Interlocked.CompareExchange(ref loader, value, null);
		}
		return loader;
	}

	public static string GetString(string name, params object[] args)
	{
		SR sR = GetLoader();
		if (sR == null)
		{
			return null;
		}
		string @string = sR.resources.GetString(name, Culture);
		if (args != null && args.Length > 0)
		{
			for (int i = 0; i < args.Length; i++)
			{
				if (args[i] is string text && text.Length > 1024)
				{
					args[i] = text.Substring(0, 1021) + "...";
				}
			}
			return string.Format(CultureInfo.CurrentCulture, @string, args);
		}
		return @string;
	}

	public static string GetString(string name)
	{
		return GetLoader()?.resources.GetString(name, Culture);
	}

	public static object GetObject(string name)
	{
		return GetLoader()?.resources.GetObject(name, Culture);
	}
}
