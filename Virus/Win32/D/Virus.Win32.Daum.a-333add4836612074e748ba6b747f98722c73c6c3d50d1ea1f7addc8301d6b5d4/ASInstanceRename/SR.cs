using System.Globalization;
using System.Resources;

namespace ASInstanceRename;

internal class SR
{
	public class Keys
	{
		public const string ProgramIsRunning = "ProgramIsRunning";

		public const string RenameInstanceDialogTitle = "RenameInstanceDialogTitle";

		public const string SuccessToRenameMessage = "SuccessToRenameMessage";

		public const string SuccessToStartRenamedInstance = "SuccessToStartRenamedInstance";

		public const string RenamingOperationRolledBack = "RenamingOperationRolledBack";

		public const string AccountValidationFailed = "AccountValidationFailed";

		public const string InvalidInstanceName = "InvalidInstanceName";

		public const string InstanceAlreadyExists = "InstanceAlreadyExists";

		public const string StartServerCommandDesc = "StartServerCommandDesc";

		public const string StoppingSelectedInstance = "StoppingSelectedInstance";

		public const string StartingPreviousInstance = "StartingPreviousInstance";

		public const string PerfCounterUnregister = "PerfCounterUnregister";

		public const string PerfCountersReRegister = "PerfCountersReRegister";

		public const string CreatingNewInstanceOfServer = "CreatingNewInstanceOfServer";

		public const string DelPrevServerInstance = "DelPrevServerInstance";

		public const string DelCurrServerInstance = "DelCurrServerInstance";

		public const string ReCreatePrevServerInstance = "ReCreatePrevServerInstance";

		public const string ModifyingRegistry = "ModifyingRegistry";

		public const string RestoringRegistry = "RestoringRegistry";

		public const string ModifyingRedirectorFile = "ModifyingRedirectorFile";

		public const string ModifyingPerfCountersFile = "ModifyingPerfCountersFile";

		public const string RestoringPerfCountersFile = "RestoringPerfCountersFile";

		public const string CreatingRegistryKeysForPerfCounters = "CreatingRegistryKeysForPerfCounters";

		public const string ReCreatingRegistryKeysForPerfCounters = "ReCreatingRegistryKeysForPerfCounters";

		public const string RegisterNewPerCountersFile = "RegisterNewPerCountersFile";

		public const string FailedToRename = "FailedToRename";

		public const string ErrorDuringRenaming = "ErrorDuringRenaming";

		public const string ErrorDuringRollBack = "ErrorDuringRollBack";

		public const string CantRenameToDefaultWhenShilohIsInstalled = "CantRenameToDefaultWhenShilohIsInstalled";

		public const string DefaultInstanceName = "DefaultInstanceName";

		public const string StoppingSQLBrowserService = "StoppingSQLBrowserService";

		public const string StartingSQLBrowserService = "StartingSQLBrowserService";

		public const string FailedToStopService = "FailedToStopService";

		public const string FailedToStartService = "FailedToStartService";

		public const string ServiceIsDisabled = "ServiceIsDisabled";

		private static ResourceManager resourceManager = new ResourceManager(typeof(SR).FullName, typeof(SR).Module.Assembly);

		private static CultureInfo _culture = null;

		public static CultureInfo Culture
		{
			get
			{
				return _culture;
			}
			set
			{
				_culture = value;
			}
		}

		private Keys()
		{
		}

		public static string GetString(string key)
		{
			return resourceManager.GetString(key, _culture);
		}

		public static string GetString(string key, object arg0)
		{
			return string.Format(CultureInfo.CurrentCulture, resourceManager.GetString(key, _culture), new object[1] { arg0 });
		}

		public static string GetString(string key, object arg0, object arg1)
		{
			return string.Format(CultureInfo.CurrentCulture, resourceManager.GetString(key, _culture), new object[2] { arg0, arg1 });
		}
	}

	public static CultureInfo Culture
	{
		get
		{
			return Keys.Culture;
		}
		set
		{
			Keys.Culture = value;
		}
	}

	public static string RenameInstanceDialogTitle => Keys.GetString("RenameInstanceDialogTitle");

	public static string InvalidInstanceName => Keys.GetString("InvalidInstanceName");

	public static string StartingPreviousInstance => Keys.GetString("StartingPreviousInstance");

	public static string PerfCounterUnregister => Keys.GetString("PerfCounterUnregister");

	public static string PerfCountersReRegister => Keys.GetString("PerfCountersReRegister");

	public static string CreatingNewInstanceOfServer => Keys.GetString("CreatingNewInstanceOfServer");

	public static string DelPrevServerInstance => Keys.GetString("DelPrevServerInstance");

	public static string DelCurrServerInstance => Keys.GetString("DelCurrServerInstance");

	public static string ReCreatePrevServerInstance => Keys.GetString("ReCreatePrevServerInstance");

	public static string ModifyingRegistry => Keys.GetString("ModifyingRegistry");

	public static string RestoringRegistry => Keys.GetString("RestoringRegistry");

	public static string ModifyingRedirectorFile => Keys.GetString("ModifyingRedirectorFile");

	public static string ModifyingPerfCountersFile => Keys.GetString("ModifyingPerfCountersFile");

	public static string RestoringPerfCountersFile => Keys.GetString("RestoringPerfCountersFile");

	public static string CreatingRegistryKeysForPerfCounters => Keys.GetString("CreatingRegistryKeysForPerfCounters");

	public static string ReCreatingRegistryKeysForPerfCounters => Keys.GetString("ReCreatingRegistryKeysForPerfCounters");

	public static string RegisterNewPerCountersFile => Keys.GetString("RegisterNewPerCountersFile");

	public static string CantRenameToDefaultWhenShilohIsInstalled => Keys.GetString("CantRenameToDefaultWhenShilohIsInstalled");

	public static string DefaultInstanceName => Keys.GetString("DefaultInstanceName");

	public static string StoppingSQLBrowserService => Keys.GetString("StoppingSQLBrowserService");

	public static string StartingSQLBrowserService => Keys.GetString("StartingSQLBrowserService");

	private SR()
	{
	}

	public static string ProgramIsRunning(string applicationName)
	{
		return Keys.GetString("ProgramIsRunning", applicationName);
	}

	public static string SuccessToRenameMessage(string newInstanceName)
	{
		return Keys.GetString("SuccessToRenameMessage", newInstanceName);
	}

	public static string SuccessToStartRenamedInstance(string newInstanceName)
	{
		return Keys.GetString("SuccessToStartRenamedInstance", newInstanceName);
	}

	public static string RenamingOperationRolledBack(string oldInstanceName)
	{
		return Keys.GetString("RenamingOperationRolledBack", oldInstanceName);
	}

	public static string AccountValidationFailed(string account)
	{
		return Keys.GetString("AccountValidationFailed", account);
	}

	public static string InstanceAlreadyExists(string name)
	{
		return Keys.GetString("InstanceAlreadyExists", name);
	}

	public static string StartServerCommandDesc(string newInstanceName)
	{
		return Keys.GetString("StartServerCommandDesc", newInstanceName);
	}

	public static string StoppingSelectedInstance(string oldInstanceName)
	{
		return Keys.GetString("StoppingSelectedInstance", oldInstanceName);
	}

	public static string FailedToRename(string exceptionMessage)
	{
		return Keys.GetString("FailedToRename", exceptionMessage);
	}

	public static string ErrorDuringRenaming(string commandDescription, string exceptionMessage)
	{
		return Keys.GetString("ErrorDuringRenaming", commandDescription, exceptionMessage);
	}

	public static string ErrorDuringRollBack(string commandDescription, string exceptionMessage)
	{
		return Keys.GetString("ErrorDuringRollBack", commandDescription, exceptionMessage);
	}

	public static string FailedToStopService(string nameOfService, int numberOfSeconds)
	{
		return Keys.GetString("FailedToStopService", nameOfService, numberOfSeconds);
	}

	public static string FailedToStartService(string nameOfService, int numberOfSeconds)
	{
		return Keys.GetString("FailedToStartService", nameOfService, numberOfSeconds);
	}

	public static string ServiceIsDisabled(string nameOfService)
	{
		return Keys.GetString("ServiceIsDisabled", nameOfService);
	}
}
