using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace Microsoft.Exchange.OMA.Unsupported.OmaBrowseInstall;

public class ServerStrings
{
	private static CultureInfo m_Culture = null;

	private static bool loading = false;

	private static ServerStrings loader = null;

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

	public static string Perf_CategoryName => GetString(Culture, "Perf_CategoryName");

	public static string Perf_CategoryHelp => GetString(Culture, "Perf_CategoryHelp");

	public static string Perf_BrowseCount => GetString(Culture, "Perf_BrowseCount");

	public static string Perf_BrowseCountHelp => GetString(Culture, "Perf_BrowseCountHelp");

	public static string Perf_BrowsesRate => GetString(Culture, "Perf_BrowsesRate");

	public static string Perf_BrowsesRateHelp => GetString(Culture, "Perf_BrowsesRateHelp");

	public static string Perf_ResponseTime => GetString(Culture, "Perf_ResponseTime");

	public static string Perf_ResponseTimeHelp => GetString(Culture, "Perf_ResponseTimeHelp");

	public static string Perf_ResponseTimeAverage => GetString(Culture, "Perf_ResponseTimeAverage");

	public static string Perf_ResponseTimeAverageHelp => GetString(Culture, "Perf_ResponseTimeAverageHelp");

	public static string Perf_InternalResponseTimeAverage => GetString(Culture, "Perf_InternalResponseTimeAverage");

	public static string Perf_InternalResponseTimeAverageHelp => GetString(Culture, "Perf_InternalResponseTimeAverageHelp");

	public static string Perf_CalendarCount => GetString(Culture, "Perf_CalendarCount");

	public static string Perf_CalendarCountHelp => GetString(Culture, "Perf_CalendarCountHelp");

	public static string Perf_CalendarRate => GetString(Culture, "Perf_CalendarRate");

	public static string Perf_CalendarRateHelp => GetString(Culture, "Perf_CalendarRateHelp");

	public static string Perf_InboxCount => GetString(Culture, "Perf_InboxCount");

	public static string Perf_InboxCountHelp => GetString(Culture, "Perf_InboxCountHelp");

	public static string Perf_InboxRate => GetString(Culture, "Perf_InboxRate");

	public static string Perf_InboxRateHelp => GetString(Culture, "Perf_InboxRateHelp");

	public static string Perf_ContactCount => GetString(Culture, "Perf_ContactCount");

	public static string Perf_ContactCountHelp => GetString(Culture, "Perf_ContactCountHelp");

	public static string Perf_ContactRate => GetString(Culture, "Perf_ContactRate");

	public static string Perf_ContactRateHelp => GetString(Culture, "Perf_ContactRateHelp");

	public static string Perf_TaskCount => GetString(Culture, "Perf_TaskCount");

	public static string Perf_TaskCountHelp => GetString(Culture, "Perf_TaskCountHelp");

	public static string Perf_TaskRate => GetString(Culture, "Perf_TaskRate");

	public static string Perf_TaskRateHelp => GetString(Culture, "Perf_TaskRateHelp");

	public static string Perf_CurrentBrowses => GetString(Culture, "Perf_CurrentBrowses");

	public static string Perf_CurrentBrowsesHelp => GetString(Culture, "Perf_CurrentBrowsesHelp");

	public static string Perf_MaximumBrowses => GetString(Culture, "Perf_MaximumBrowses");

	public static string Perf_MaximumBrowsesHelp => GetString(Culture, "Perf_MaximumBrowsesHelp");

	public static string Perf_Status100Count => GetString(Culture, "Perf_Status100Count");

	public static string Perf_Status100CountHelp => GetString(Culture, "Perf_Status100CountHelp");

	public static string Perf_Status200Count => GetString(Culture, "Perf_Status200Count");

	public static string Perf_Status200CountHelp => GetString(Culture, "Perf_Status200CountHelp");

	public static string Perf_Status300Count => GetString(Culture, "Perf_Status300Count");

	public static string Perf_Status300CountHelp => GetString(Culture, "Perf_Status300CountHelp");

	public static string Perf_Status400Count => GetString(Culture, "Perf_Status400Count");

	public static string Perf_Status400CountHelp => GetString(Culture, "Perf_Status400CountHelp");

	public static string Perf_Status500Count => GetString(Culture, "Perf_Status500Count");

	public static string Perf_Status500CountHelp => GetString(Culture, "Perf_Status500CountHelp");

	public static string Log_EventSource => GetString(Culture, "Log_EventSource");

	public static string Log_EventCategory => GetString(Culture, "Log_EventCategory");

	public static string Log_EventCategoryId => GetString(Culture, "Log_EventCategoryId");

	public static string Log_OmaStart => GetString(Culture, "Log_OmaStart");

	public static string Log_OmaStartId => GetString(Culture, "Log_OmaStartId");

	public static string Log_OmaEnd => GetString(Culture, "Log_OmaEnd");

	public static string Log_OmaEndId => GetString(Culture, "Log_OmaEndId");

	public static string Log_OmaNoPerfCountersId => GetString(Culture, "Log_OmaNoPerfCountersId");

	public static string Log_OmaBadUserForSessionId => GetString(Culture, "Log_OmaBadUserForSessionId");

	public static string Log_OmaNoCredentials => GetString(Culture, "Log_OmaNoCredentials");

	public static string Log_OmaNoCredentialsId => GetString(Culture, "Log_OmaNoCredentialsId");

	public static string Log_OmaInvalidCredentials => GetString(Culture, "Log_OmaInvalidCredentials");

	public static string Log_OmaInvalidCredentialsId => GetString(Culture, "Log_OmaInvalidCredentialsId");

	public static string Log_OmaUnknownErrorId => GetString(Culture, "Log_OmaUnknownErrorId");

	public static string Log_OmaBadCredentialsId => GetString(Culture, "Log_OmaBadCredentialsId");

	public static string Log_OmaNoShortDomainId => GetString(Culture, "Log_OmaNoShortDomainId");

	public static string Log_OmaUnknownErrorOneInnerId => GetString(Culture, "Log_OmaUnknownErrorOneInnerId");

	public static string Log_OmaUnknownErrorTwoInnerId => GetString(Culture, "Log_OmaUnknownErrorTwoInnerId");

	public static string Log_OmaUserNotEnabledId => GetString(Culture, "Log_OmaUserNotEnabledId");

	public static string Log_OmaErrorNoInfo => GetString(Culture, "Log_OmaErrorNoInfo");

	public static string Log_OmaErrorNoInfoId => GetString(Culture, "Log_OmaErrorNoInfoId");

	public static string Log_OmaNoDefaultDomainId => GetString(Culture, "Log_OmaNoDefaultDomainId");

	public static string Log_OmaMetabaseReadId => GetString(Culture, "Log_OmaMetabaseReadId");

	public static string Log_InvalidAuthorizationHeader => GetString(Culture, "Log_InvalidAuthorizationHeader");

	public static string Log_InvalidAuthorizationHeaderId => GetString(Culture, "Log_InvalidAuthorizationHeaderId");

	public static string Log_ExceptionDecodeAuthorizationHeader => GetString(Culture, "Log_ExceptionDecodeAuthorizationHeader");

	public static string Log_ExceptionDecodeAuthorizationHeaderId => GetString(Culture, "Log_ExceptionDecodeAuthorizationHeaderId");

	public static string ErrorPage_DefaultIdForServerErrors => GetString(Culture, "ErrorPage_DefaultIdForServerErrors");

	public static string ErrorPage_SystemErrorTitle => GetString(Culture, "ErrorPage_SystemErrorTitle");

	public static string ErrorPage_SystemErrorMessage => GetString(Culture, "ErrorPage_SystemErrorMessage");

	public static string ErrorPage_NotEnabledTitle => GetString(Culture, "ErrorPage_NotEnabledTitle");

	public static string ErrorPage_NotEnabledMessage => GetString(Culture, "ErrorPage_NotEnabledMessage");

	public static string Log_EventFWLinkMessage(object arg)
	{
		return GetString(Culture, "Log_EventFWLinkMessage", arg);
	}

	public static string Log_OmaNoPerfCounters(object arg)
	{
		return GetString(Culture, "Log_OmaNoPerfCounters", arg);
	}

	public static string Log_OmaBadUserForSession(object arg, object arg1)
	{
		return GetString(Culture, "Log_OmaBadUserForSession", arg, arg1);
	}

	public static string Log_OmaUnknownError(object arg, object arg1)
	{
		return GetString(Culture, "Log_OmaUnknownError", arg, arg1);
	}

	public static string Log_OmaBadCredentials(object arg)
	{
		return GetString(Culture, "Log_OmaBadCredentials", arg);
	}

	public static string Log_OmaNoShortDomain(object arg, object arg1)
	{
		return GetString(Culture, "Log_OmaNoShortDomain", arg, arg1);
	}

	public static string Log_OmaUnknownErrorOneInner(object arg, object arg1, object arg2, object arg3)
	{
		return GetString(Culture, "Log_OmaUnknownErrorOneInner", arg, arg1, arg2, arg3);
	}

	public static string Log_OmaUnknownErrorTwoInner(object arg, object arg1, object arg2, object arg3, object arg4, object arg5)
	{
		return GetString(Culture, "Log_OmaUnknownErrorTwoInner", arg, arg1, arg2, arg3, arg4, arg5);
	}

	public static string Log_OmaUserNotEnabled(object arg)
	{
		return GetString(Culture, "Log_OmaUserNotEnabled", arg);
	}

	public static string Log_OmaNoDefaultDomain(object arg, object arg1, object arg2)
	{
		return GetString(Culture, "Log_OmaNoDefaultDomain", arg, arg1, arg2);
	}

	public static string Log_OmaMetabaseRead(object arg, object arg1)
	{
		return GetString(Culture, "Log_OmaMetabaseRead", arg, arg1);
	}

	protected ServerStrings()
	{
		resources = new ResourceManager("ServerStrings", Assembly.Load("Microsoft.Exchange.OMA.UISvr"));
	}

	private static ServerStrings GetLoader()
	{
		if (loader == null && !loading)
		{
			lock (typeof(ServerStrings))
			{
				if (loader == null && !loading)
				{
					loading = true;
					try
					{
						loader = new ServerStrings();
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
		ServerStrings serverStrings = GetLoader();
		if (serverStrings == null)
		{
			return null;
		}
		string @string = serverStrings.resources.GetString(name, culture);
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
