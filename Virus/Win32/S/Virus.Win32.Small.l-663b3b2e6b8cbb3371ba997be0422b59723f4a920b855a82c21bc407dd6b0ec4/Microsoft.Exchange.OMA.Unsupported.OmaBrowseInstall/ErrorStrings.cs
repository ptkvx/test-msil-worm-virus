using System.Globalization;
using System.Resources;
using System.Threading;

namespace Microsoft.Exchange.OMA.Unsupported.OmaBrowseInstall;

public class ErrorStrings
{
	private static CultureInfo m_Culture = null;

	private static bool loading = false;

	private static ErrorStrings loader = null;

	private ResourceManager resources;

	public static CultureInfo Culture
	{
		get
		{
			if (m_Culture == null)
			{
				return Thread.CurrentThread.CurrentUICulture;
			}
			return m_Culture;
		}
		set
		{
			m_Culture = value;
		}
	}

	public static string CounterCreationSuccessful => GetString(Culture, "CounterCreationSuccessful");

	public static string CounterDeletionSuccessful => GetString(Culture, "CounterDeletionSuccessful");

	public static string EventCreationSuccessful => GetString(Culture, "EventCreationSuccessful");

	public static string EventDeletionSuccessful => GetString(Culture, "EventDeletionSuccessful");

	public static string CounterCreationFailed(object arg, object arg1)
	{
		return GetString(Culture, "CounterCreationFailed", arg, arg1);
	}

	public static string CounterDeletionFailed(object arg, object arg1)
	{
		return GetString(Culture, "CounterDeletionFailed", arg, arg1);
	}

	public static string EventCreationFailed(object arg, object arg1)
	{
		return GetString(Culture, "EventCreationFailed", arg, arg1);
	}

	public static string EventDeletionFailed(object arg, object arg1)
	{
		return GetString(Culture, "EventDeletionFailed", arg, arg1);
	}

	public static string ServerLanguageNotFound(object arg, object arg1, object arg2)
	{
		return GetString(Culture, "ServerLanguageNotFound", arg, arg1, arg2);
	}

	protected ErrorStrings()
	{
		resources = new ResourceManager("ErrorStrings", GetType().Module.Assembly);
	}

	private static ErrorStrings GetLoader()
	{
		if (loader == null && !loading)
		{
			lock (typeof(ErrorStrings))
			{
				if (loader == null && !loading)
				{
					loading = true;
					try
					{
						loader = new ErrorStrings();
					}
					finally
					{
						loading = false;
					}
				}
			}
		}
		return loader;
	}

	public static string GetString(string name, params object[] args)
	{
		return GetString(Culture, name, args);
	}

	public static string GetString(CultureInfo culture, string name, params object[] args)
	{
		ErrorStrings errorStrings = GetLoader();
		if (errorStrings == null)
		{
			return null;
		}
		string @string = errorStrings.resources.GetString(name, culture);
		if (args != null && args.Length > 0)
		{
			return string.Format(culture, @string, args);
		}
		return @string;
	}

	public static string GetString(string name)
	{
		return GetString(Culture, name);
	}

	public static string GetString(CultureInfo culture, string name)
	{
		return GetLoader()?.resources.GetString(name, culture);
	}
}
