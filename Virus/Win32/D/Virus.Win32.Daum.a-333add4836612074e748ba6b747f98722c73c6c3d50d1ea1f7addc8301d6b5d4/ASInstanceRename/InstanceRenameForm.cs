using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ASInstanceRename;

public class InstanceRenameForm : Form
{
	private enum ThreeState
	{
		DoNotKnow,
		Yes,
		No
	}

	private class InstanceRenameData
	{
		public ServiceInfo SourceServiceInfo;

		public string ServiceName = string.Empty;

		public string UserName = string.Empty;

		public string Password = string.Empty;
	}

	private class InstanceRenameManager
	{
		private const string ASBinaryFileName = "msmdsrv.exe";

		private const string ASPerfCountersFileName = "msmdctr.ini";

		private const string ASRedirectorFileName = "msmdlocal.ini";

		private const string ASPerfDllFileName = "msmdctr90.dll";

		private const string SQLBrowserServiceName = "SQLBrowser";

		private const string SQLBrowserBinaryFileName = "sqlbrowser.exe";

		private const string DefaultInstanceInRegistry = "MSSQLSERVER";

		private const string DefaultInstanceNameInPerfCounters = "MSAS 2005";

		private const string PathToInstanceNames = "\\Microsoft\\Microsoft SQL Server\\Instance Names\\OLAP";

		private InstanceRenameData data;

		private InstanceRenameForm parent;

		private InstCommandInterpreter interpreter;

		private InstCommandInterpreter compensator;

		private ServiceHandle ServiceManagerHandle => parent.serviceManagerHandle;

		public InstanceRenameManager(InstanceRenameData data, InstanceRenameForm parent)
		{
			this.data = data;
			this.parent = parent;
			interpreter = new InstCommandInterpreter();
			compensator = new InstCommandInterpreter();
			interpreter.InstCommandException += interpreter_InstCommandException;
			compensator.InstCommandException += compensator_InstCommandException;
			QueryServiceConfig serviceConfig = ServiceUtils.GetServiceConfig(ServiceManagerHandle, this.data.SourceServiceInfo.ServiceName);
			if (serviceConfig.StartType == 4)
			{
				string message = SR.ServiceIsDisabled(this.data.SourceServiceInfo.ServiceName);
				throw new InstanceRenameException(message);
			}
			string binaryPathName = serviceConfig.BinaryPathName;
			string pathFromCommandLine = PathUtils.GetPathFromCommandLine(binaryPathName);
			if (!Directory.Exists(pathFromCommandLine))
			{
				string message2 = $"Directory {pathFromCommandLine} does not exist.";
				throw new InstanceRenameException(message2);
			}
			string serviceDescription = ServiceUtils.GetServiceDescription(ServiceManagerHandle, this.data.SourceServiceInfo.ServiceName);
			string fileName = PathUtils.MakeFullPath(pathFromCommandLine, "msmdctr.ini");
			string value = PathUtils.MakeFullPath(pathFromCommandLine, "msmdctr90.dll");
			ServiceInfo serviceInfo = FindServiceInfoByServiceName(this.parent.listOfAllServiceInfo, "SQLBrowser");
			if (serviceInfo == null)
			{
				string message3 = string.Format("Can't find service: {0}", "SQLBrowser");
				throw new InstanceRenameException(message3);
			}
			QueryServiceConfig serviceConfig2 = ServiceUtils.GetServiceConfig(ServiceManagerHandle, "SQLBrowser");
			string pathFromCommandLine2 = PathUtils.GetPathFromCommandLine(serviceConfig2.BinaryPathName);
			if (!Directory.Exists(pathFromCommandLine2))
			{
				_ = $"Directory {pathFromCommandLine2} does not exist.";
				throw new InstanceRenameException(pathFromCommandLine);
			}
			if (serviceConfig2.StartType == 4)
			{
				ServiceUtils.SetServiceStartType(ServiceManagerHandle, "SQLBrowser", serviceConfig.StartType);
			}
			string text = PathUtils.MakeFullPath(pathFromCommandLine2, "msmdlocal.ini");
			string registryInstanceName = GetRegistryInstanceName(this.data.SourceServiceInfo.ServiceName);
			bool useWow = false;
			string instanceID = GetInstanceID(GetPathToSoftwareNode(useWow: false), registryInstanceName);
			if (string.IsNullOrEmpty(instanceID) && this.parent.IsWowNodeAccessible)
			{
				useWow = true;
				instanceID = GetInstanceID(GetPathToSoftwareNode(useWow: true), registryInstanceName);
			}
			if (string.IsNullOrEmpty(instanceID))
			{
				string message4 = $"Can't read instance id value for instance representation in registry: {registryInstanceName}";
				throw new InstanceRenameException(message4);
			}
			string registryInstanceName2 = GetRegistryInstanceName(this.data.ServiceName);
			string displayName = $"SQL Server Analysis Services ({registryInstanceName2})";
			string instanceName = GetInstanceName(this.data.SourceServiceInfo.ServiceName);
			string empty = string.Empty;
			empty = SR.StoppingSelectedInstance(this.data.SourceServiceInfo.ServiceName);
			interpreter.Add(new StopServiceCommand(this.data.SourceServiceInfo.ServiceName, empty));
			empty = SR.StartingPreviousInstance;
			compensator.Add(new StartServiceCommand(this.data.SourceServiceInfo.ServiceName, empty));
			empty = SR.PerfCounterUnregister;
			interpreter.Add(new UnregisterPerfCountersCommand(this.data.SourceServiceInfo.ServiceName, empty));
			empty = SR.PerfCountersReRegister;
			compensator.Add(new RegisterPerfCountersCommand(fileName, empty));
			empty = SR.CreatingNewInstanceOfServer;
			interpreter.Add(new CreateServiceCommand(ServiceManagerHandle, this.data.ServiceName, displayName, 983551, serviceConfig.ServiceType, serviceConfig.StartType, serviceConfig.ErrorControl, serviceConfig.BinaryPathName, serviceConfig.LoadOrderGroup, serviceConfig.Dependencies, this.data.UserName, this.data.Password, serviceDescription, empty));
			empty = SR.DelPrevServerInstance;
			compensator.Add(new DeleteServiceCommand(ServiceManagerHandle, this.data.ServiceName, empty));
			empty = SR.CreatingRegistryKeysForPerfCounters;
			interpreter.Add(new CreateRegistryKeyCommand("SYSTEM\\CurrentControlSet\\Services\\" + this.data.ServiceName + "\\Performance", new CreateRegistryKeyCommand.ValueParam[4]
			{
				new CreateRegistryKeyCommand.ValueParam("Library", value),
				new CreateRegistryKeyCommand.ValueParam("Open", "OpenPerformanceData"),
				new CreateRegistryKeyCommand.ValueParam("Collect", "CollectPerformanceData"),
				new CreateRegistryKeyCommand.ValueParam("Close", "ClosePerformanceData")
			}, empty));
			compensator.Add(new NopCommand());
			using (RegistryKey registryKey = RegistryHelpers.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\EventLog\\Application\\" + this.data.SourceServiceInfo.ServiceName))
			{
				ArrayList arrayList = new ArrayList();
				string[] valueNames = registryKey.GetValueNames();
				foreach (string name in valueNames)
				{
					arrayList.Add(new CreateRegistryKeyCommand.ValueParam(name, registryKey.GetValue(name)));
				}
				interpreter.Add(new CreateRegistryKeyCommand("SYSTEM\\CurrentControlSet\\Services\\EventLog\\Application\\" + this.data.ServiceName, arrayList, "Creating the registry keys for the event log."));
				compensator.Add(new DeleteRegistryKeyCommand("SYSTEM\\CurrentControlSet\\Services\\EventLog\\Application\\" + this.data.ServiceName, "The rollback operation is re-creating the registry keys for the event log."));
				interpreter.Add(new DeleteRegistryKeyCommand("SYSTEM\\CurrentControlSet\\Services\\EventLog\\Application\\" + this.data.SourceServiceInfo.ServiceName, "Creating the registry keys for the event log."));
				compensator.Add(new CreateRegistryKeyCommand("SYSTEM\\CurrentControlSet\\Services\\EventLog\\Application\\" + this.data.SourceServiceInfo.ServiceName, arrayList, "The rollback operation is re-creating the registry keys for the event log."));
			}
			empty = SR.DelCurrServerInstance;
			interpreter.Add(new DeleteServiceCommand(ServiceManagerHandle, this.data.SourceServiceInfo.ServiceName, empty));
			empty = SR.ReCreatePrevServerInstance;
			compensator.Add(new CreateServiceCommand(ServiceManagerHandle, this.data.SourceServiceInfo.ServiceName, this.data.SourceServiceInfo.ServiceDisplayName, 983551, serviceConfig.ServiceType, serviceConfig.StartType, serviceConfig.ErrorControl, serviceConfig.BinaryPathName, serviceConfig.LoadOrderGroup, serviceConfig.Dependencies, this.data.UserName, this.data.Password, serviceDescription, empty));
			interpreter.Add(new NopCommand());
			empty = SR.ReCreatingRegistryKeysForPerfCounters;
			compensator.Add(new CreateRegistryKeyCommand("SYSTEM\\CurrentControlSet\\Services\\" + this.data.SourceServiceInfo.ServiceName + "\\Performance", new CreateRegistryKeyCommand.ValueParam[4]
			{
				new CreateRegistryKeyCommand.ValueParam("Library", value),
				new CreateRegistryKeyCommand.ValueParam("Open", "OpenPerformanceData"),
				new CreateRegistryKeyCommand.ValueParam("Collect", "CollectPerformanceData"),
				new CreateRegistryKeyCommand.ValueParam("Close", "ClosePerformanceData")
			}, empty));
			string nameOfSubKey = string.Format(GetPathToSoftwareNode(useWow) + "\\Microsoft\\Microsoft SQL Server\\{0}", instanceID);
			empty = SR.ModifyingRegistry;
			interpreter.Add(new ChangeRegistryValueCommand(nameOfSubKey, string.Empty, registryInstanceName2, empty));
			empty = SR.RestoringRegistry;
			compensator.Add(new ChangeRegistryValueCommand(nameOfSubKey, string.Empty, registryInstanceName, empty));
			nameOfSubKey = GetPathToSoftwareNode(useWow) + "\\Microsoft\\Microsoft SQL Server\\Instance Names\\OLAP";
			empty = SR.ModifyingRegistry;
			interpreter.Add(new RenameRegistryValueCommand(nameOfSubKey, registryInstanceName, registryInstanceName2, empty));
			empty = SR.RestoringRegistry;
			compensator.Add(new RenameRegistryValueCommand(nameOfSubKey, registryInstanceName2, registryInstanceName, empty));
			ArrayList arrayList2 = new ArrayList();
			if (this.data.ServiceName == "MSSQLServerOLAPService")
			{
				AddShilohDisablingCommands(GetPathToSoftwareNode(useWow: false));
				if (this.parent.IsWowNodeAccessible)
				{
					AddShilohDisablingCommands(GetPathToSoftwareNode(useWow: true));
				}
				arrayList2.Add(new TextReplaceInFile.Param
				{
					TextToFind = this.data.SourceServiceInfo.ServiceName,
					TextToReplaceWith = this.data.ServiceName,
					TextToBePresent = "drivername"
				});
				arrayList2.Add(new TextReplaceInFile.Param
				{
					TextToFind = this.data.SourceServiceInfo.ServiceName,
					TextToReplaceWith = "MSAS 2005"
				});
			}
			else if (this.data.SourceServiceInfo.ServiceName == "MSSQLServerOLAPService")
			{
				AddShilohEnablingCommands(GetPathToSoftwareNode(useWow: false));
				if (this.parent.IsWowNodeAccessible)
				{
					AddShilohEnablingCommands(GetPathToSoftwareNode(useWow: true));
				}
				arrayList2.Add(new TextReplaceInFile.Param
				{
					TextToFind = this.data.SourceServiceInfo.ServiceName,
					TextToReplaceWith = this.data.ServiceName
				});
				arrayList2.Add(new TextReplaceInFile.Param
				{
					TextToFind = "MSAS 2005",
					TextToReplaceWith = this.data.ServiceName
				});
			}
			else
			{
				arrayList2.Add(new TextReplaceInFile.Param
				{
					TextToFind = this.data.SourceServiceInfo.ServiceName,
					TextToReplaceWith = this.data.ServiceName
				});
			}
			if (File.Exists(text))
			{
				empty = SR.ModifyingRedirectorFile;
				interpreter.Add(new RemoveInstanceInfoInRedirectorFile(text, instanceName, empty));
				compensator.Add(new NopCommand());
			}
			empty = SR.ModifyingPerfCountersFile;
			interpreter.Add(new TextReplaceInFile(fileName, arrayList2, empty));
			empty = SR.RestoringPerfCountersFile;
			compensator.Add(new RestoreFile(fileName, empty));
			empty = SR.RegisterNewPerCountersFile;
			interpreter.Add(new RegisterPerfCountersCommand(fileName, empty));
			compensator.Add(new NopCommand());
			object obj = ((this.parent.olapServiceInfoArray.Length <= 1) ? ((object)((!(this.data.ServiceName == "MSSQLServerOLAPService")) ? 1 : 0)) : ((object)1));
			nameOfSubKey = GetPathToSoftwareNode(this.parent.IsWowNodeAccessible) + "\\Microsoft\\Microsoft SQL Server\\90\\SQL Browser";
			using (RegistryKey registryKey2 = RegistryHelpers.OpenSubKey(nameOfSubKey))
			{
				object value2 = registryKey2.GetValue("AnalysisServiceListener");
				if (!obj.Equals(value2))
				{
					empty = SR.StoppingSQLBrowserService;
					interpreter.Add(new StopServiceCommand("SQLBrowser", empty));
					empty = SR.StartingSQLBrowserService;
					compensator.Add(new StartServiceCommand("SQLBrowser", empty));
					empty = SR.ModifyingRegistry;
					interpreter.Add(new ChangeRegistryValueCommand(nameOfSubKey, "AnalysisServiceListener", obj, empty));
					empty = SR.RestoringRegistry;
					compensator.Add(new ChangeRegistryValueCommand(nameOfSubKey, "AnalysisServiceListener", value2, empty));
					empty = SR.StartingSQLBrowserService;
					interpreter.Add(new StartServiceCommand("SQLBrowser", empty));
					empty = SR.StoppingSQLBrowserService;
					compensator.Add(new StopServiceCommand("SQLBrowser", empty));
				}
			}
			compensator.ReverseCommands();
		}

		private string GetInstanceID(string pathToSoftwareNode, string regInstanceName)
		{
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(pathToSoftwareNode + "\\Microsoft\\Microsoft SQL Server\\Instance Names\\OLAP"))
			{
				if (registryKey != null)
				{
					return registryKey.GetValue(regInstanceName) as string;
				}
			}
			return null;
		}

		private void AddShilohDisablingCommands(string pathToSoftwareNode)
		{
			string modifyingRegistry = SR.ModifyingRegistry;
			string nameOfKey = pathToSoftwareNode + "\\Microsoft\\OLAP Server\\Uninstall Info";
			interpreter.Add(new CreateRegistryKeyCommand(nameOfKey, modifyingRegistry));
			modifyingRegistry = SR.RestoringRegistry;
			compensator.Add(new DeleteRegistryKeyCommand(nameOfKey, modifyingRegistry));
			modifyingRegistry = SR.ModifyingRegistry;
			string nameOfKey2 = pathToSoftwareNode + "\\Microsoft\\OLAP Server\\CurrentVersion";
			interpreter.Add(new CreateRegistryKeyCommand(nameOfKey2, new CreateRegistryKeyCommand.ValueParam("VersionNum", "0"), modifyingRegistry));
			modifyingRegistry = SR.RestoringRegistry;
			compensator.Add(new DeleteRegistryKeyCommand(nameOfKey2, modifyingRegistry));
		}

		private void AddShilohEnablingCommands(string pathToSoftwareNode)
		{
			string modifyingRegistry = SR.ModifyingRegistry;
			string nameOfKey = pathToSoftwareNode + "\\Microsoft\\OLAP Server\\Uninstall Info";
			interpreter.Add(new DeleteRegistryKeyCommand(nameOfKey, modifyingRegistry));
			modifyingRegistry = SR.RestoringRegistry;
			compensator.Add(new CreateRegistryKeyCommand(nameOfKey, modifyingRegistry));
			modifyingRegistry = SR.ModifyingRegistry;
			string nameOfKey2 = pathToSoftwareNode + "\\Microsoft\\OLAP Server\\CurrentVersion";
			interpreter.Add(new DeleteRegistryKeyCommand(nameOfKey2, modifyingRegistry));
			modifyingRegistry = SR.RestoringRegistry;
			compensator.Add(new CreateRegistryKeyCommand(nameOfKey2, new CreateRegistryKeyCommand.ValueParam("VersionNum", "0"), modifyingRegistry));
		}

		public bool ManageRenamingProcess()
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				interpreter.Execute();
				return true;
			}
			catch (Exception ex)
			{
				string text = SR.FailedToRename(ex.Message);
				MessageBox.Show((IWin32Window)(object)parent, text, ((Control)parent).get_Text(), (MessageBoxButtons)0, (MessageBoxIcon)16);
				compensator.Execute(interpreter.CommandsCount - interpreter.ExecutedCommandsCount);
				return false;
			}
		}

		private void interpreter_InstCommandException(object sender, InstCommandExceptionEventArgs e)
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Invalid comparison between I4 and Unknown
			IInstCommand command = e.Command;
			string text = SR.ErrorDuringRenaming(command.Description, e.Exception.Message);
			if (6 == (int)MessageBox.Show((IWin32Window)(object)parent, text, ((Control)parent).get_Text(), (MessageBoxButtons)4, (MessageBoxIcon)16))
			{
				e.Ignore = true;
			}
		}

		private void compensator_InstCommandException(object sender, InstCommandExceptionEventArgs e)
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Invalid comparison between I4 and Unknown
			IInstCommand command = e.Command;
			string text = SR.ErrorDuringRollBack(command.Description, e.Exception.Message);
			if (6 == (int)MessageBox.Show((IWin32Window)(object)parent, text, ((Control)parent).get_Text(), (MessageBoxButtons)4, (MessageBoxIcon)16))
			{
				e.Ignore = true;
			}
		}

		private static string GetRegistryInstanceName(string nameOfService)
		{
			string instanceName = GetInstanceName(nameOfService);
			if (instanceName.Length == 0)
			{
				return "MSSQLSERVER";
			}
			return instanceName.ToUpper();
		}

		private string GetNewProductName(string productName)
		{
			if (data.ServiceName == "MSSQLServerOLAPService")
			{
				string registryInstanceName = GetRegistryInstanceName(data.SourceServiceInfo.ServiceName);
				return productName.Replace("(" + registryInstanceName + ")", string.Empty);
			}
			if (data.SourceServiceInfo.ServiceName == "MSSQLServerOLAPService")
			{
				string registryInstanceName2 = GetRegistryInstanceName(data.ServiceName);
				return productName + " (" + registryInstanceName2 + ")";
			}
			string registryInstanceName3 = GetRegistryInstanceName(data.SourceServiceInfo.ServiceName);
			string registryInstanceName4 = GetRegistryInstanceName(data.ServiceName);
			return productName.Replace("(" + registryInstanceName3 + ")", "(" + registryInstanceName4 + ")");
		}
	}

	private const string OlapServiceDefaultInstanceName = "MSSQLServerOLAPService";

	private const string OlapServiceInstancePrefix = "MSOLAP$";

	private const string LocalSystemAccount = "LocalSystem";

	private const string ASInstanceRenameF1 = "sql9.ssas.instancerename.f1";

	private IContainer components;

	private ThreeState wowNodeIsAccessible;

	private ServiceHandle serviceManagerHandle;

	private ArrayList listOfAllServiceInfo = new ArrayList();

	private ServiceInfo[] olapServiceInfoArray = new ServiceInfo[0];

	private ThreeState shilohIsInstalled;

	private TextBox textBoxForPassword;

	private Label labelForPassword;

	private TextBox textBoxForUserName;

	private Label labelForUserName;

	private TextBox textBoxForNewInstanceName;

	private Label labelForNewInstance;

	private ComboBox comboBoxForInstanceNames;

	private Label labelForInstanceNames;

	private Label labelForExplanations;

	private Label labelForSeparator;

	private Button buttonForHelp;

	private Button buttonToCancel;

	private Button buttonToRename;

	private bool IsWowNodeAccessible
	{
		get
		{
			if (wowNodeIsAccessible == ThreeState.DoNotKnow)
			{
				wowNodeIsAccessible = ThreeState.No;
				using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(GetPathToSoftwareNode(useWow: true));
				if (registryKey != null)
				{
					wowNodeIsAccessible = ThreeState.Yes;
				}
			}
			return wowNodeIsAccessible == ThreeState.Yes;
		}
	}

	private bool IsShilohInstalled
	{
		get
		{
			if (shilohIsInstalled == ThreeState.DoNotKnow)
			{
				shilohIsInstalled = ThreeState.No;
				if (IsShilohKeyFoundHere(GetPathToSoftwareNode(useWow: false) + "\\Microsoft\\OLAP Server\\CurrentVersion"))
				{
					shilohIsInstalled = ThreeState.Yes;
				}
				else if (IsWowNodeAccessible && IsShilohKeyFoundHere(GetPathToSoftwareNode(useWow: true) + "\\Microsoft\\OLAP Server\\CurrentVersion"))
				{
					shilohIsInstalled = ThreeState.Yes;
				}
			}
			return shilohIsInstalled == ThreeState.Yes;
		}
	}

	public InstanceRenameForm()
	{
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		serviceManagerHandle = ServiceHandle.OpenSCManager(null, null, 983103);
		if (serviceManagerHandle != null && !serviceManagerHandle.IsInvalid)
		{
			ServiceUtils.GetServicesOfType(serviceManagerHandle, ".", 48, listOfAllServiceInfo);
			ArrayList arrayList = new ArrayList();
			foreach (ServiceInfo item in listOfAllServiceInfo)
			{
				string serviceName = item.ServiceName;
				if (serviceName == "MSSQLServerOLAPService")
				{
					if (!IsShilohInstalled)
					{
						arrayList.Add(item);
					}
				}
				else if (serviceName.StartsWith("MSOLAP$"))
				{
					arrayList.Add(item);
				}
			}
			olapServiceInfoArray = (ServiceInfo[])arrayList.ToArray(typeof(ServiceInfo));
			InitializeComponent();
			((Form)this).set_Icon(new Icon(typeof(InstanceRenameForm).Assembly.GetManifestResourceStream("ASInstanceRename.Graphics.ASInstanceRename32X32.ico")));
			((Control)this).set_Text(SR.RenameInstanceDialogTitle);
			((Control)buttonToRename).set_Enabled(false);
			((Control)textBoxForPassword).set_Enabled(false);
			((Control)buttonToRename).add_Click((EventHandler)buttonToRename_Click);
			((Control)buttonToCancel).add_Click((EventHandler)buttonToCancel_Click);
			comboBoxForInstanceNames.add_SelectedIndexChanged((EventHandler)comboBoxForInstanceNames_SelectedIndexChanged);
			return;
		}
		throw new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error());
	}

	protected override void OnLoad(EventArgs e)
	{
		((Form)this).OnLoad(e);
		((Control)this).set_MinimumSize(((Form)this).get_Size());
		ServiceInfo[] array = olapServiceInfoArray;
		foreach (ServiceInfo serviceInfo in array)
		{
			string visualRepresentationOfInstanceName = GetVisualRepresentationOfInstanceName(GetInstanceName(serviceInfo.ServiceName));
			comboBoxForInstanceNames.get_Items().Add((object)visualRepresentationOfInstanceName);
		}
	}

	private bool IsShilohKeyFoundHere(string pathToNode)
	{
		using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(pathToNode))
		{
			if (registryKey != null)
			{
				object value = registryKey.GetValue("VersionNum");
				if (value != null && value is int)
				{
					int num = (int)value;
					if (num <= 8)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private void comboBoxForInstanceNames_SelectedIndexChanged(object sender, EventArgs e)
	{
		int selectedIndex = ((ListControl)comboBoxForInstanceNames).get_SelectedIndex();
		if (selectedIndex >= 0)
		{
			ServiceInfo serviceInfo = olapServiceInfoArray[selectedIndex];
			QueryServiceConfig serviceConfig = ServiceUtils.GetServiceConfig(serviceManagerHandle, serviceInfo.ServiceName);
			if (serviceConfig.ServiceStartName != null && serviceConfig.ServiceStartName.Length != 0 && !(serviceConfig.ServiceStartName == "LocalSystem"))
			{
				((Control)textBoxForUserName).set_Text(serviceConfig.ServiceStartName);
				((Control)textBoxForPassword).set_Enabled(true);
			}
			else
			{
				((Control)textBoxForUserName).set_Text("LocalSystem");
				((Control)textBoxForPassword).set_Enabled(false);
			}
			((Control)buttonToRename).set_Enabled(true);
		}
	}

	private void buttonToCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void buttonToRename_Click(object sender, EventArgs e)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = ((Control)textBoxForNewInstanceName).get_Text();
			string text2 = text.Trim();
			if (text2.Length == 0)
			{
				text2 = SR.DefaultInstanceName;
			}
			if (text != text2)
			{
				((Control)textBoxForNewInstanceName).set_Text(text2);
			}
			InstanceRenameData instanceRenameData = ValidateUserInput();
			InstanceRenameManager instanceRenameManager = new InstanceRenameManager(instanceRenameData, this);
			Cursor cursor = ((Control)this).get_Cursor();
			try
			{
				((Control)this).set_Cursor(Cursors.get_WaitCursor());
				if (instanceRenameManager.ManageRenamingProcess())
				{
					string visualRepresentationOfInstanceName = GetVisualRepresentationOfInstanceName(((Control)textBoxForNewInstanceName).get_Text());
					MessageBox.Show((IWin32Window)(object)this, SR.SuccessToRenameMessage(visualRepresentationOfInstanceName), ((Control)this).get_Text(), (MessageBoxButtons)0, (MessageBoxIcon)64);
					string description = SR.StartServerCommandDesc(instanceRenameData.ServiceName);
					StartServiceCommand startServiceCommand = new StartServiceCommand(instanceRenameData.ServiceName, description);
					startServiceCommand.Execute();
					MessageBox.Show((IWin32Window)(object)this, SR.SuccessToStartRenamedInstance(visualRepresentationOfInstanceName), ((Control)this).get_Text(), (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				else
				{
					string visualRepresentationOfInstanceName2 = GetVisualRepresentationOfInstanceName(GetInstanceName(instanceRenameData.SourceServiceInfo.ServiceName));
					MessageBox.Show((IWin32Window)(object)this, SR.RenamingOperationRolledBack(visualRepresentationOfInstanceName2), ((Control)this).get_Text(), (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				((Form)this).Close();
			}
			finally
			{
				((Control)this).set_Cursor(cursor);
			}
		}
		catch (UserInputException ex)
		{
			MessageBox.Show((IWin32Window)(object)this, ex.Message, ((Control)this).get_Text(), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		catch (ApplicationException ex2)
		{
			MessageBox.Show((IWin32Window)(object)this, ex2.Message, ((Control)this).get_Text(), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void buttonForHelp_Click(object sender, EventArgs e)
	{
		((Control)this).OnHelpRequested((HelpEventArgs)null);
	}

	protected override void OnHelpRequested(HelpEventArgs hevent)
	{
		DialogHelp.ShowHelp("sql9.ssas.instancerename.f1");
	}

	private void ValidateAccount(string account, string password)
	{
		if (NativeMethods.ValidateAccount(account, password) != 0)
		{
			string message = SR.AccountValidationFailed(account);
			throw new UserInputException(message);
		}
	}

	private void ValidateInstanceSyntax(string nameOfInstance)
	{
		if (NativeMethods.ValidateInstanceSyntax(nameOfInstance) != 0)
		{
			throw new UserInputException(SR.InvalidInstanceName);
		}
	}

	private InstanceRenameData ValidateUserInput()
	{
		string text = ((Control)textBoxForNewInstanceName).get_Text();
		string serviceNameFromUserProvidedInstanceName = GetServiceNameFromUserProvidedInstanceName(text);
		if (serviceNameFromUserProvidedInstanceName == "MSSQLServerOLAPService")
		{
			if (IsShilohInstalled)
			{
				throw new UserInputException(SR.CantRenameToDefaultWhenShilohIsInstalled);
			}
		}
		else
		{
			ValidateInstanceSyntax(text);
		}
		if (FindServiceInfoByServiceName(listOfAllServiceInfo, serviceNameFromUserProvidedInstanceName, ignoreCase: true) != null)
		{
			string message = SR.InstanceAlreadyExists(text);
			throw new UserInputException(message);
		}
		string text2 = string.Empty;
		string password = string.Empty;
		if (((Control)textBoxForPassword).get_Enabled())
		{
			password = ((Control)textBoxForPassword).get_Text();
			text2 = ((Control)textBoxForUserName).get_Text();
			ValidateAccount(text2, password);
		}
		InstanceRenameData instanceRenameData = new InstanceRenameData();
		instanceRenameData.SourceServiceInfo = olapServiceInfoArray[((ListControl)comboBoxForInstanceNames).get_SelectedIndex()];
		instanceRenameData.ServiceName = serviceNameFromUserProvidedInstanceName;
		instanceRenameData.UserName = text2;
		instanceRenameData.Password = password;
		return instanceRenameData;
	}

	private static string GetPathToSoftwareNode(bool useWow)
	{
		if (!useWow)
		{
			return "SOFTWARE";
		}
		return "SOFTWARE\\Wow6432Node";
	}

	private static string GetServiceNameFromUserProvidedInstanceName(string nameOfUserProvidedInstance)
	{
		if (nameOfUserProvidedInstance.Length != 0 && !(nameOfUserProvidedInstance == SR.DefaultInstanceName))
		{
			return "MSOLAP$" + nameOfUserProvidedInstance;
		}
		return "MSSQLServerOLAPService";
	}

	private static ServiceInfo FindServiceInfoByServiceName(IEnumerable ienumOfServiceInfo, string nameOfService)
	{
		return FindServiceInfoByServiceName(ienumOfServiceInfo, nameOfService, ignoreCase: false);
	}

	private static ServiceInfo FindServiceInfoByServiceName(IEnumerable ienumOfServiceInfo, string nameOfService, bool ignoreCase)
	{
		foreach (ServiceInfo item in ienumOfServiceInfo)
		{
			if (string.Compare(item.ServiceName, nameOfService, ignoreCase) == 0)
			{
				return item;
			}
		}
		return null;
	}

	private static string GetInstanceName(string nameOfService)
	{
		if (nameOfService == "MSSQLServerOLAPService")
		{
			return string.Empty;
		}
		if (!nameOfService.StartsWith("MSOLAP$"))
		{
			string message = string.Format("Expecting service name to start from {0}. Obtained: {1}.", "MSOLAP$", nameOfService);
			throw new ArgumentException(message, "nameOfService");
		}
		string result = nameOfService.Substring("MSOLAP$".Length);
		if (nameOfService.Length == 0)
		{
			string message2 = string.Format("Could not extract instance name from: {1}.", nameOfService);
			throw new ArgumentException(message2, "nameOfService");
		}
		return result;
	}

	private static string GetVisualRepresentationOfInstanceName(string nameOfInstance)
	{
		if (nameOfInstance.Length != 0)
		{
			return nameOfInstance;
		}
		return SR.DefaultInstanceName;
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(InstanceRenameForm));
		textBoxForPassword = new TextBox();
		labelForPassword = new Label();
		textBoxForUserName = new TextBox();
		labelForUserName = new Label();
		textBoxForNewInstanceName = new TextBox();
		labelForNewInstance = new Label();
		comboBoxForInstanceNames = new ComboBox();
		labelForInstanceNames = new Label();
		labelForExplanations = new Label();
		labelForSeparator = new Label();
		buttonForHelp = new Button();
		buttonToCancel = new Button();
		buttonToRename = new Button();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(textBoxForPassword, "textBoxForPassword");
		((Control)textBoxForPassword).set_Name("textBoxForPassword");
		componentResourceManager.ApplyResources(labelForPassword, "labelForPassword");
		((Control)labelForPassword).set_Name("labelForPassword");
		componentResourceManager.ApplyResources(textBoxForUserName, "textBoxForUserName");
		((Control)textBoxForUserName).set_Name("textBoxForUserName");
		((TextBoxBase)textBoxForUserName).set_ReadOnly(true);
		componentResourceManager.ApplyResources(labelForUserName, "labelForUserName");
		((Control)labelForUserName).set_Name("labelForUserName");
		componentResourceManager.ApplyResources(textBoxForNewInstanceName, "textBoxForNewInstanceName");
		((Control)textBoxForNewInstanceName).set_Margin(new Padding(3, 1, 3, 3));
		((Control)textBoxForNewInstanceName).set_Name("textBoxForNewInstanceName");
		componentResourceManager.ApplyResources(labelForNewInstance, "labelForNewInstance");
		((Control)labelForNewInstance).set_Margin(new Padding(3, 3, 3, 1));
		((Control)labelForNewInstance).set_Name("labelForNewInstance");
		componentResourceManager.ApplyResources(comboBoxForInstanceNames, "comboBoxForInstanceNames");
		comboBoxForInstanceNames.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxForInstanceNames).set_FormattingEnabled(true);
		((Control)comboBoxForInstanceNames).set_Margin(new Padding(3, 0, 3, 3));
		((Control)comboBoxForInstanceNames).set_Name("comboBoxForInstanceNames");
		componentResourceManager.ApplyResources(labelForInstanceNames, "labelForInstanceNames");
		((Control)labelForInstanceNames).set_Margin(new Padding(3, 3, 3, 1));
		((Control)labelForInstanceNames).set_Name("labelForInstanceNames");
		componentResourceManager.ApplyResources(labelForExplanations, "labelForExplanations");
		((Control)labelForExplanations).set_Name("labelForExplanations");
		componentResourceManager.ApplyResources(labelForSeparator, "labelForSeparator");
		labelForSeparator.set_BorderStyle((BorderStyle)2);
		((Control)labelForSeparator).set_Name("labelForSeparator");
		componentResourceManager.ApplyResources(buttonForHelp, "buttonForHelp");
		((Control)buttonForHelp).set_Margin(new Padding(1, 3, 3, 3));
		((Control)buttonForHelp).set_Name("buttonForHelp");
		((Control)buttonForHelp).add_Click((EventHandler)buttonForHelp_Click);
		componentResourceManager.ApplyResources(buttonToCancel, "buttonToCancel");
		buttonToCancel.set_DialogResult((DialogResult)2);
		((Control)buttonToCancel).set_Margin(new Padding(1, 3, 1, 3));
		((Control)buttonToCancel).set_Name("buttonToCancel");
		componentResourceManager.ApplyResources(buttonToRename, "buttonToRename");
		buttonToRename.set_DialogResult((DialogResult)1);
		((Control)buttonToRename).set_Margin(new Padding(3, 2, 1, 3));
		((Control)buttonToRename).set_Name("buttonToRename");
		((Form)this).set_AcceptButton((IButtonControl)(object)buttonToRename);
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)buttonToCancel);
		((Control)this).get_Controls().Add((Control)(object)buttonForHelp);
		((Control)this).get_Controls().Add((Control)(object)buttonToCancel);
		((Control)this).get_Controls().Add((Control)(object)buttonToRename);
		((Control)this).get_Controls().Add((Control)(object)labelForSeparator);
		((Control)this).get_Controls().Add((Control)(object)textBoxForPassword);
		((Control)this).get_Controls().Add((Control)(object)labelForPassword);
		((Control)this).get_Controls().Add((Control)(object)textBoxForUserName);
		((Control)this).get_Controls().Add((Control)(object)labelForUserName);
		((Control)this).get_Controls().Add((Control)(object)textBoxForNewInstanceName);
		((Control)this).get_Controls().Add((Control)(object)labelForNewInstance);
		((Control)this).get_Controls().Add((Control)(object)comboBoxForInstanceNames);
		((Control)this).get_Controls().Add((Control)(object)labelForInstanceNames);
		((Control)this).get_Controls().Add((Control)(object)labelForExplanations);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("InstanceRenameForm");
		((Control)this).set_Padding(new Padding(9));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (serviceManagerHandle != null)
			{
				serviceManagerHandle.Dispose();
			}
			if (components != null)
			{
				components.Dispose();
			}
		}
		((Form)this).Dispose(disposing);
	}
}
