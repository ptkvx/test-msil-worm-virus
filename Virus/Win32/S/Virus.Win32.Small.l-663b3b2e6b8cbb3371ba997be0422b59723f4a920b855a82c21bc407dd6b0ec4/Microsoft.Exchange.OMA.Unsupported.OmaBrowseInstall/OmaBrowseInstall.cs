using System;
using System.Diagnostics;
using System.Globalization;
using Microsoft.Win32;

namespace Microsoft.Exchange.OMA.Unsupported.OmaBrowseInstall;

internal class OmaBrowseInstall
{
	[STAThread]
	private static int Main(string[] args)
	{
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		if (args.Length != 2)
		{
			Console.WriteLine("Usage: OmaBrowseInstall [events | counters] [/create | /delete]");
			return -1;
		}
		if (string.CompareOrdinal("/create", args[0]) == 0 || string.CompareOrdinal("/create", args[1]) == 0)
		{
			flag3 = true;
		}
		if (string.CompareOrdinal("/delete", args[0]) == 0 || string.CompareOrdinal("/delete", args[1]) == 0)
		{
			flag4 = true;
		}
		if (string.CompareOrdinal("events", args[0]) == 0 || string.CompareOrdinal("events", args[1]) == 0)
		{
			flag = true;
		}
		if (string.CompareOrdinal("counters", args[0]) == 0 || string.CompareOrdinal("counters", args[1]) == 0)
		{
			flag2 = true;
		}
		string text = "software\\Microsoft\\Exchange";
		string text2 = "Server Language";
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(text);
			int culture = (int)registryKey.GetValue(text2);
			ServerStrings.Culture = new CultureInfo(culture);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ErrorStrings.ServerLanguageNotFound(text + "\\" + text2, ex.Message, ex.StackTrace));
			return -6;
		}
		if (flag4 && flag2)
		{
			try
			{
				if (PerformanceCounterCategory.Exists(ServerStrings.Perf_CategoryName))
				{
					PerformanceCounterCategory.Delete(ServerStrings.Perf_CategoryName);
					Console.WriteLine(ErrorStrings.CounterDeletionSuccessful);
				}
			}
			catch (Exception ex2)
			{
				Console.WriteLine(ErrorStrings.CounterDeletionFailed(ex2.Message, ex2.StackTrace));
				return -2;
			}
		}
		else if (flag3 && flag2)
		{
			try
			{
				if (PerformanceCounterCategory.Exists(ServerStrings.Perf_CategoryName))
				{
					PerformanceCounterCategory.Delete(ServerStrings.Perf_CategoryName);
				}
				if (!PerformanceCounterCategory.Exists(ServerStrings.Perf_CategoryName))
				{
					CounterCreationDataCollection val = new CounterCreationDataCollection();
					CounterCreationData val2 = new CounterCreationData(ServerStrings.Perf_BrowseCount, ServerStrings.Perf_BrowseCountHelp, (PerformanceCounterType)65792);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_BrowsesRate, ServerStrings.Perf_BrowsesRateHelp, (PerformanceCounterType)272696320);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_CalendarCount, ServerStrings.Perf_CalendarCountHelp, (PerformanceCounterType)65792);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_CalendarRate, ServerStrings.Perf_CalendarRateHelp, (PerformanceCounterType)272696320);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_InboxCount, ServerStrings.Perf_InboxCountHelp, (PerformanceCounterType)65792);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_InboxRate, ServerStrings.Perf_InboxRateHelp, (PerformanceCounterType)272696320);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_ContactCount, ServerStrings.Perf_ContactCountHelp, (PerformanceCounterType)65792);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_ContactRate, ServerStrings.Perf_ContactRateHelp, (PerformanceCounterType)272696320);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_TaskCount, ServerStrings.Perf_TaskCountHelp, (PerformanceCounterType)65792);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_TaskRate, ServerStrings.Perf_TaskRateHelp, (PerformanceCounterType)272696320);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_ResponseTimeAverage, ServerStrings.Perf_ResponseTimeAverageHelp, (PerformanceCounterType)65536);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_InternalResponseTimeAverage, ServerStrings.Perf_InternalResponseTimeAverageHelp, (PerformanceCounterType)65792);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_ResponseTime, ServerStrings.Perf_ResponseTimeHelp, (PerformanceCounterType)65536);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_CurrentBrowses, ServerStrings.Perf_CurrentBrowsesHelp, (PerformanceCounterType)65536);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_MaximumBrowses, ServerStrings.Perf_MaximumBrowsesHelp, (PerformanceCounterType)65536);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_Status100Count, ServerStrings.Perf_Status100CountHelp, (PerformanceCounterType)65792);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_Status200Count, ServerStrings.Perf_Status200CountHelp, (PerformanceCounterType)65792);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_Status300Count, ServerStrings.Perf_Status300CountHelp, (PerformanceCounterType)65792);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_Status400Count, ServerStrings.Perf_Status400CountHelp, (PerformanceCounterType)65792);
					val.Add(val2);
					val2 = new CounterCreationData(ServerStrings.Perf_Status500Count, ServerStrings.Perf_Status500CountHelp, (PerformanceCounterType)65792);
					val.Add(val2);
					PerformanceCounterCategory.Create(ServerStrings.Perf_CategoryName, ServerStrings.Perf_CategoryHelp, val);
					Console.WriteLine(ErrorStrings.CounterCreationSuccessful);
				}
			}
			catch (Exception ex3)
			{
				Console.WriteLine(ErrorStrings.CounterCreationFailed(ex3.Message, ex3.StackTrace));
				return -3;
			}
		}
		else if (flag3 && flag)
		{
			try
			{
				if (EventLog.SourceExists(ServerStrings.Log_EventSource))
				{
					EventLog.DeleteEventSource(ServerStrings.Log_EventSource);
				}
				EventLog.CreateEventSource(ServerStrings.Log_EventSource, "", ".");
				if (!EventLog.SourceExists("aspnet_wp"))
				{
					EventLog.CreateEventSource("aspnet_wp", "", ".");
				}
				Console.WriteLine(ErrorStrings.EventCreationSuccessful);
			}
			catch (Exception ex4)
			{
				Console.WriteLine(ErrorStrings.EventCreationFailed(ex4.Message, ex4.StackTrace));
				return -4;
			}
		}
		else
		{
			if (!flag4 || !flag)
			{
				Console.WriteLine("Usage: OmaBrowseInstall [events | counters] [/create | /delete]");
				return -1;
			}
			try
			{
				if (EventLog.SourceExists(ServerStrings.Log_EventSource))
				{
					EventLog.DeleteEventSource(ServerStrings.Log_EventSource);
					Console.WriteLine(ErrorStrings.EventDeletionSuccessful);
				}
			}
			catch (Exception ex5)
			{
				Console.WriteLine(ErrorStrings.EventDeletionFailed(ex5.Message, ex5.StackTrace));
				return -5;
			}
		}
		return 0;
	}
}
