using System;
using System.Collections;
using System.IO;
using Arbus.Client.Base;
using Arbus.Client.BusinessObjects;
using Arbus.Common;

namespace MBackMonitor;

public class PCEAgent : IDisposable
{
	private static PCEAgent objPCEAgent;

	private object objSyncRoot;

	private object objSync;

	private ConfigurationManager objConfigurationManager;

	private WatchManager objWatchManager;

	private ArbusListManager objArbusListManager;

	private WatchLocations _DeepWLs = new WatchLocations();

	private WatchLocations _ShallowWLs = new WatchLocations();

	private WatchLocations _ExcludedWLs = new WatchLocations();

	public WatchManager WatchManager => objWatchManager;

	public event EventHandler OnWatcherError;

	private PCEAgent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		objSyncRoot = new object();
		objSync = new object();
		objWatchManager = new WatchManager();
		Initialize();
		objArbusListManager = ArbusListManager.CreateArbusListManager();
	}

	public static PCEAgent CreatePCEAgent()
	{
		if (objPCEAgent == null)
		{
			objPCEAgent = new PCEAgent();
		}
		return objPCEAgent;
	}

	private void Initialize()
	{
		string configXMLPath = Helper.GetConfigXMLPath();
		objConfigurationManager = ConfigurationManager.CreateConfiguration(configXMLPath);
		objConfigurationManager.Load();
		WatchLocations watchLocations = GetWatchLocations();
		WatchLocations excludedWatchLocations = GetExcludedWatchLocations();
		Filters filters = GetFilters();
		CreateWatchers(watchLocations, excludedWatchLocations, filters);
		AttachWatchManagerEvents();
	}

	private void CreateWatchers(WatchLocations objDefaultWLs, WatchLocations objExcludedWLs, Filters objFilters)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		foreach (WatchLocation item in (CollectionBase)(object)objDefaultWLs)
		{
			WatchLocation val = item;
			WatchInfo val2 = new WatchInfo(val);
			val2.AddFilter(objFilters);
			val2.AddExcludedWatchLocation(objExcludedWLs);
			val2.AddChangeType(WatcherChangeTypes.All);
			val2.AddNotifyFilter(NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite);
			val2.AddAttribute(FileAttributes.ReadOnly | FileAttributes.Archive | FileAttributes.Device | FileAttributes.SparseFile | FileAttributes.ReparsePoint | FileAttributes.Compressed | FileAttributes.Offline | FileAttributes.NotContentIndexed | FileAttributes.Encrypted);
			try
			{
				objWatchManager.AddWatch(val2);
			}
			catch (Exception ex)
			{
				if (this.OnWatcherError != null)
				{
					this.OnWatcherError(this, EventArgs.Empty);
				}
				ExceptionPublisher.Publish(ex);
			}
		}
	}

	private Filters GetFilters()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		Filters val = new Filters();
		ConfigFilter[] filtersConfiguration = objConfigurationManager.GetFiltersConfiguration();
		ConfigFilter[] array = filtersConfiguration;
		foreach (ConfigFilter val2 in array)
		{
			val.Add(new Filter(val2.FiltersName));
		}
		return val;
	}

	private WatchLocations GetDefaultWatchLocations()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		WatchLocations val = new WatchLocations();
		string[] array = new string[2]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
			Environment.GetFolderPath(Environment.SpecialFolder.Personal)
		};
		foreach (string text in array)
		{
			if (text != null && text != "")
			{
				WatchLocation val2 = new WatchLocation(text);
				((Location)val2).set_IncludeSubDirectories(true);
				val.Add(val2);
			}
		}
		return val;
	}

	private WatchLocations GetExcludedWatchLocations()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		WatchLocations val = new WatchLocations();
		try
		{
			string[] array = new string[2]
			{
				Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
				Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.System))!.FullName
			};
			foreach (string text in array)
			{
				if (text != null && text != "")
				{
					WatchLocation val2 = new WatchLocation(text);
					((Location)val2).set_IncludeSubDirectories(true);
					val.Add(val2);
				}
			}
			return val;
		}
		catch (Exception ex)
		{
			ExceptionPublisher.Publish(ex);
			return val;
		}
	}

	private void AttachWatchManagerEvents()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		objWatchManager.add_OnFileChange(new WatcherEventHandler(objWatchManager_OnFileChange));
		objWatchManager.add_OnFileCreate(new WatcherEventHandler(objWatchManager_OnFileCreate));
		objWatchManager.add_OnFileDelete(new WatcherEventHandler(objWatchManager_OnFileDelete));
		objWatchManager.add_OnFileRename(new RenameEventHandler(objWatchManager_OnFileRename));
		objWatchManager.add_OnFolderChange(new WatcherEventHandler(objWatchManager_OnFolderChange));
		objWatchManager.add_OnFolderCreate(new WatcherEventHandler(objWatchManager_OnFolderCreate));
		objWatchManager.add_OnFolderDelete(new WatcherEventHandler(objWatchManager_OnFolderDelete));
		objWatchManager.add_OnFolderRename(new RenameEventHandler(objWatchManager_OnFolderRename));
		objWatchManager.add_OnWatcherCreation((EventHandler)objWatchManager_OnWatcherCreation);
		objWatchManager.add_OnWatcherDeletion((EventHandler)objWatchManager_OnWatcherDeletion);
		objWatchManager.add_OnWatcherError((EventHandler)objWatchManager_OnWatcherError);
		objWatchManager.add_OnWatcherRename((EventHandler)objWatchManager_OnWatcherRename);
	}

	private void DettachWatchManagerEvents()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		objWatchManager.remove_OnFileChange(new WatcherEventHandler(objWatchManager_OnFileChange));
		objWatchManager.remove_OnFileCreate(new WatcherEventHandler(objWatchManager_OnFileCreate));
		objWatchManager.remove_OnFileDelete(new WatcherEventHandler(objWatchManager_OnFileDelete));
		objWatchManager.remove_OnFileRename(new RenameEventHandler(objWatchManager_OnFileRename));
		objWatchManager.remove_OnFolderChange(new WatcherEventHandler(objWatchManager_OnFolderChange));
		objWatchManager.remove_OnFolderCreate(new WatcherEventHandler(objWatchManager_OnFolderCreate));
		objWatchManager.remove_OnFolderDelete(new WatcherEventHandler(objWatchManager_OnFolderDelete));
		objWatchManager.remove_OnFolderRename(new RenameEventHandler(objWatchManager_OnFolderRename));
		objWatchManager.remove_OnWatcherCreation((EventHandler)objWatchManager_OnWatcherCreation);
		objWatchManager.remove_OnWatcherDeletion((EventHandler)objWatchManager_OnWatcherDeletion);
		objWatchManager.remove_OnWatcherError((EventHandler)objWatchManager_OnWatcherError);
		objWatchManager.remove_OnWatcherRename((EventHandler)objWatchManager_OnWatcherRename);
	}

	private void objWatchManager_OnFileChange(object sender, WatchEventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		if (objArbusListManager == null)
		{
			return;
		}
		ArbusFile arbusFileByPath = objArbusListManager.GetArbusFileByPath(e.get_Path());
		if (arbusFileByPath != null)
		{
			ArbusFile val = (ArbusFile)arbusFileByPath.Clone();
			if (File.Exists(val.get_ClientLocation()) && val.Invalidate())
			{
				SetFileInfoEntries(val);
				objArbusListManager.UpdateArbusFile(val);
			}
			val = null;
		}
	}

	private void objWatchManager_OnFileCreate(object sender, WatchEventArgs e)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		try
		{
			if (objArbusListManager == null)
			{
				return;
			}
			bool flag = false;
			ArbusFile val = objArbusListManager.GetArbusFileByPath(e.get_Path());
			if (val != null)
			{
				flag = true;
			}
			if (val == null && !flag)
			{
				val = objArbusListManager.GetRealFile(e.get_Path());
				if (val != null)
				{
					flag = true;
				}
			}
			if (val == null && !flag)
			{
				val = objArbusListManager.GetRealFileInRecycleList(e.get_Path());
				if (val != null)
				{
					flag = true;
				}
			}
			if (flag && val != null)
			{
				lock (objSyncRoot)
				{
					ArbusFile val2 = null;
					val2 = (ArbusFile)val.Clone();
					val2.set_ClientLocation(e.get_Path());
					val2.Invalidate();
					objArbusListManager.SetTag(val2);
					objArbusListManager.SetWatchLocation(val2);
					SetFileInfoEntries(val2);
					objArbusListManager.UpdateAndAddArbusFile(val2);
					if (IsArbussedBefore(val2) && val.get_ClientLocation().ToLower() != e.get_Path().ToLower())
					{
						ArbusFilesEx val3 = new ArbusFilesEx();
						val3.Add(val2);
					}
					val2 = null;
					return;
				}
			}
			objArbusListManager.AddArbusFile(e.get_Path());
		}
		catch (Exception ex)
		{
			ExceptionPublisher.Publish(ex);
		}
	}

	private void objWatchManager_OnFileDelete(object sender, WatchEventArgs e)
	{
		try
		{
			if (objArbusListManager == null)
			{
				return;
			}
			lock (objSyncRoot)
			{
				ArbusFile arbusFileByPath = objArbusListManager.GetArbusFileByPath(e.get_Path());
				if (arbusFileByPath != null)
				{
					objArbusListManager.DeleteArbusFile(arbusFileByPath);
				}
			}
		}
		catch (Exception ex)
		{
			ExceptionPublisher.Publish(ex);
		}
	}

	private void objWatchManager_OnFileRename(object sender, WatchRenameEventArgs e)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		if (objArbusListManager == null)
		{
			return;
		}
		ArbusFile arbusFileByPath = objArbusListManager.GetArbusFileByPath(((WatchEventArgs)e).get_Path());
		string extension = Path.GetExtension(((WatchEventArgs)e).get_Path());
		string text = Path.GetExtension(e.get_NewPath());
		if (arbusFileByPath != null)
		{
			if (extension == text)
			{
				ArbusFile val = (ArbusFile)arbusFileByPath.Clone();
				val.set_ClientLocation(e.get_NewPath());
				val.set_Name(Path.GetFileName(val.get_ClientLocation()));
				objArbusListManager.SetTag(val);
				objArbusListManager.SetWatchLocation(val);
				val.Invalidate();
				SetFileInfoEntries(val);
				if (IsArbussedBefore(val) && arbusFileByPath.get_ClientLocation().ToLower() != e.get_NewPath().ToLower())
				{
					ArbusFilesEx val2 = new ArbusFilesEx();
					val2.Add(val);
				}
				objArbusListManager.UpdateArbusFile(val);
				WatchLocation val3 = IsPresentInShallowWatch(((WatchEventArgs)e).get_Path());
				if (val3 != null)
				{
					WatchLocations val4 = OnlyGetPersistedWatchLocations();
					((Location)val3).set_Path(MendYourWays(((Location)val3).get_Path()));
					val4.Delete(val3);
					WatchLocation val5 = new WatchLocation(e.get_NewPath());
					((Location)val5).set_IncludeSubDirectories(false);
					val4.Add(val5);
					PersistWatchLocations(val4);
					DeleteWatch(val3);
					WatchLocation val6 = new WatchLocation(e.get_NewPath());
					((Location)val6).set_IncludeSubDirectories(false);
					AddWatcher(val6);
				}
				return;
			}
			if (text.StartsWith("."))
			{
				text = text.TrimStart(new char[1] { '.' });
			}
			if (GetFilters().Contains(text))
			{
				ArbusFile val7 = (ArbusFile)arbusFileByPath.Clone();
				val7.set_Name(Path.GetFileName(e.get_NewPath()));
				val7.set_ClientLocation(e.get_NewPath());
				if (File.Exists(val7.get_ClientLocation()))
				{
					objArbusListManager.SetTag(val7);
					objArbusListManager.SetWatchLocation(val7);
					val7.Invalidate();
					SetFileInfoEntries(val7);
					if (IsArbussedBefore(val7) && arbusFileByPath.get_ClientLocation().ToLower() != e.get_NewPath().ToLower())
					{
						ArbusFilesEx val8 = new ArbusFilesEx();
						val8.Add(val7);
					}
					objArbusListManager.UpdateArbusFile(val7);
				}
			}
			else
			{
				objArbusListManager.DeleteArbusFile(arbusFileByPath);
			}
			return;
		}
		arbusFileByPath = objArbusListManager.GetArbusFileByPath(e.get_NewPath());
		if (arbusFileByPath != null)
		{
			ArbusFile val9 = (ArbusFile)arbusFileByPath.Clone();
			val9.set_ClientLocation(e.get_NewPath());
			val9.set_Name(Path.GetFileName(val9.get_ClientLocation()));
			if (File.Exists(val9.get_ClientLocation()))
			{
				objArbusListManager.SetTag(val9);
				objArbusListManager.SetWatchLocation(val9);
				val9.Invalidate();
				SetFileInfoEntries(val9);
				if (IsArbussedBefore(val9) && arbusFileByPath.get_ClientLocation().ToLower() != e.get_NewPath())
				{
					ArbusFilesEx val10 = new ArbusFilesEx();
					val10.Add(val9);
				}
				objArbusListManager.UpdateArbusFile(val9);
			}
		}
		else
		{
			if (text.StartsWith("."))
			{
				text = text.TrimStart(new char[1] { '.' });
			}
			if (GetFilters().Contains(text))
			{
				ArbusFile val11 = new ArbusFile();
				val11.set_ClientLocation(e.get_NewPath());
				objArbusListManager.AddArbusFile(val11);
			}
		}
	}

	private void objWatchManager_OnFolderChange(object sender, WatchEventArgs e)
	{
	}

	private void objWatchManager_OnFolderCreate(object sender, WatchEventArgs e)
	{
		lock (objSync)
		{
			if (((Location)e.get_WatchLocation()).get_IncludeSubDirectories())
			{
				AddFolder(e.get_Path(), IsScanDeep: true);
			}
			else
			{
				AddFolder(e.get_Path(), IsScanDeep: false);
			}
		}
	}

	private void objWatchManager_OnFolderDelete(object sender, WatchEventArgs e)
	{
		lock (objSync)
		{
			if (objArbusListManager != null)
			{
				objArbusListManager.DeleteArbusFolder(e.get_Path(), GetFilters().ToArray());
			}
		}
	}

	private void objWatchManager_OnFolderRename(object sender, WatchRenameEventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		if (objArbusListManager == null)
		{
			return;
		}
		ArbusFilesEx val = objArbusListManager.RenameArbusFolder(((WatchEventArgs)e).get_Path(), e.get_NewPath());
		ArbusFilesEx val2 = new ArbusFilesEx();
		foreach (ArbusFile item in (IndexedCollectionBase)val)
		{
			ArbusFile val3 = item;
			if (IsArbussedBefore(val3))
			{
				val2.Add(val3);
			}
		}
		((IndexedCollectionBase)val2).get_Count();
	}

	private void objWatchManager_OnWatcherCreation(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (objConfigurationManager == null)
		{
			return;
		}
		WatcherEventArgs val = (WatcherEventArgs)e;
		WatchLocation val2 = val.get_WatchInfo().get_WatchLocation();
		if (e == null)
		{
			return;
		}
		WatchLocations watchLocations = GetWatchLocations();
		for (int i = 0; i < ((CollectionBase)(object)watchLocations).Count; i++)
		{
			if (MendYourWays(((Location)watchLocations.get_Item(i)).get_Path()) == MendYourWays(((Location)val.get_WatchInfo().get_WatchLocation()).get_Path()))
			{
				val2 = null;
				break;
			}
		}
		if (val2 != null)
		{
			watchLocations.Add(val2);
			PersistWatchLocations(watchLocations);
		}
		_DeepWLs = GetPersistedDeepwatchLocations();
		_ShallowWLs = GetPersistedShallowwatchLocations();
	}

	private void objWatchManager_OnWatcherDeletion(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (objConfigurationManager == null)
		{
			return;
		}
		try
		{
			WatcherEventArgs val = (WatcherEventArgs)e;
			WatchLocation val2 = null;
			if (e != null)
			{
				WatchLocations watchLocations = GetWatchLocations();
				for (int i = 0; i < ((CollectionBase)(object)watchLocations).Count; i++)
				{
					if (MendYourWays(((Location)watchLocations.get_Item(i)).get_Path()) == MendYourWays(((Location)val.get_WatchInfo().get_WatchLocation()).get_Path()))
					{
						val2 = watchLocations.get_Item(i);
						break;
					}
				}
				if (val2 != null)
				{
					watchLocations.Delete(val2);
					PersistWatchLocations(watchLocations);
				}
				if (((Location)val.get_WatchInfo().get_WatchLocation()).get_IncludeSubDirectories())
				{
					bool flag = true;
					if (Directory.Exists(((Location)val.get_WatchInfo().get_WatchLocation()).get_Path()))
					{
						flag = false;
					}
					if (flag)
					{
						objArbusListManager.DeleteArbusFolder(((Location)val.get_WatchInfo().get_WatchLocation()).get_Path(), GetFilters().ToArray());
					}
					else
					{
						objArbusListManager.DeleteArbusFolder(((Location)val.get_WatchInfo().get_WatchLocation()).get_Path(), GetFilters().ToArray(), false);
					}
				}
				else
				{
					bool flag2 = true;
					if (Directory.Exists(((Location)val.get_WatchInfo().get_WatchLocation()).get_Path()))
					{
						flag2 = false;
					}
					else if (File.Exists(((Location)val.get_WatchInfo().get_WatchLocation()).get_Path()))
					{
						flag2 = false;
					}
					if (flag2)
					{
						objArbusListManager.DeleteArbusShallowFolder(((Location)val.get_WatchInfo().get_WatchLocation()).get_Path(), GetFilters().ToArray());
					}
					else
					{
						objArbusListManager.DeleteArbusShallowFolder(((Location)val.get_WatchInfo().get_WatchLocation()).get_Path(), GetFilters().ToArray(), false);
					}
				}
			}
			_DeepWLs = GetPersistedDeepwatchLocations();
			_ShallowWLs = GetPersistedShallowwatchLocations();
		}
		catch (Exception ex)
		{
			ExceptionPublisher.Publish(ex);
			Console.WriteLine(ex.Message);
		}
	}

	private void objWatchManager_OnWatcherError(object sender, EventArgs e)
	{
		ErrorEventArgs errorEventArgs = (ErrorEventArgs)e;
		if ((object)((object)errorEventArgs.GetException().GetBaseException()).GetType() == typeof(InternalBufferOverflowException) && this.OnWatcherError != null)
		{
			this.OnWatcherError(this, EventArgs.Empty);
		}
	}

	private void objWatchManager_OnWatcherRename(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (objConfigurationManager == null)
		{
			return;
		}
		WatcherRenameEventArgs val = (WatcherRenameEventArgs)e;
		WatchLocation val2 = null;
		if (e == null)
		{
			return;
		}
		WatchLocations watchLocations = GetWatchLocations();
		for (int i = 0; i < ((CollectionBase)(object)watchLocations).Count; i++)
		{
			if (MendYourWays(((Location)watchLocations.get_Item(i)).get_Path()) == MendYourWays(((Location)((WatcherEventArgs)val).get_WatchInfo().get_WatchLocation()).get_Path()))
			{
				val2 = watchLocations.get_Item(i);
				break;
			}
		}
		if (val2 != null)
		{
			watchLocations.Delete(val2);
			val2 = val.get_NewWatchInfo().get_WatchLocation();
			watchLocations.Add(val2);
			PersistWatchLocations(watchLocations);
			objArbusListManager.RenameArbusFolder(((Location)((WatcherEventArgs)val).get_WatchInfo().get_WatchLocation()).get_Path(), ((Location)val.get_NewWatchInfo().get_WatchLocation()).get_Path());
		}
	}

	private void PersistWatchLocations(WatchLocations objWLs)
	{
		//IL_0024: Expected O, but got Unknown
		ConfigWatchLocation[] array = Convert.ToConfigwatchLocations(objWLs);
		if (array != null)
		{
			objConfigurationManager.SetWatchLocationsConfiguration(array);
			try
			{
				objConfigurationManager.Save();
			}
			catch (ConfigurationSaveException val)
			{
				ConfigurationSaveException val2 = val;
				ExceptionPublisher.Publish((Exception)(object)val2);
			}
		}
	}

	private void SetFileInfoEntries(ArbusFile objAF)
	{
		if (File.Exists(objAF.get_ClientLocation()))
		{
			FileInfo fileInfo = new FileInfo(objAF.get_ClientLocation());
			objAF.set_Name(fileInfo.Name);
			objAF.set_Size(fileInfo.Length);
			objAF.set_ClientLocation(Path.GetFullPath(objAF.get_ClientLocation()));
			objAF.set_Accessed(fileInfo.LastAccessTime.ToUniversalTime());
			objAF.set_Created(fileInfo.CreationTime.ToUniversalTime());
			objAF.set_Modified(fileInfo.LastWriteTime.ToUniversalTime());
		}
	}

	private bool IsArbussedBefore(ArbusFile objAF)
	{
		if (objAF.get_LastArbussed() == default(DateTime))
		{
			return false;
		}
		return true;
	}

	private string MendYourWays(string Path)
	{
		string text = Path;
		char altDirectorySeparatorChar = System.IO.Path.AltDirectorySeparatorChar;
		string oldValue = altDirectorySeparatorChar.ToString();
		altDirectorySeparatorChar = System.IO.Path.DirectorySeparatorChar;
		Path = text.Replace(oldValue, altDirectorySeparatorChar.ToString());
		if (!System.IO.Path.HasExtension(Path))
		{
			string text2 = Path;
			altDirectorySeparatorChar = System.IO.Path.DirectorySeparatorChar;
			if (!text2.EndsWith(altDirectorySeparatorChar.ToString()))
			{
				string text3 = Path;
				altDirectorySeparatorChar = System.IO.Path.DirectorySeparatorChar;
				Path = text3 + altDirectorySeparatorChar;
			}
		}
		return Path;
	}

	private WatchLocation IsPresentInShallowWatch(string sPath)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		WatchLocation result = null;
		foreach (WatchLocation item in (CollectionBase)(object)_ShallowWLs)
		{
			WatchLocation val = item;
			if (MendYourWays(((Location)val).get_Path()).ToLower() == MendYourWays(sPath).ToLower())
			{
				return val;
			}
		}
		return result;
	}

	private WatchLocations OnlyGetPersistedWatchLocations()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		WatchLocations val = new WatchLocations();
		ConfigWatchLocation[] watchLocationsConfiguration = objConfigurationManager.GetWatchLocationsConfiguration();
		ConfigWatchLocation[] array = watchLocationsConfiguration;
		foreach (ConfigWatchLocation val2 in array)
		{
			WatchLocation val3 = new WatchLocation(val2.Path);
			((Location)val3).set_IncludeSubDirectories(val2.IncludeSubDirectories);
			val.Add(val3);
		}
		return val;
	}

	private WatchLocations GetPersistedDeepwatchLocations()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		WatchLocations val = new WatchLocations();
		ConfigWatchLocation[] watchLocationsConfiguration = objConfigurationManager.GetWatchLocationsConfiguration();
		for (int i = 0; i < watchLocationsConfiguration.Length; i++)
		{
			if (watchLocationsConfiguration[i].IncludeSubDirectories)
			{
				WatchLocation val2 = new WatchLocation(watchLocationsConfiguration[i].Path);
				((Location)val2).set_IncludeSubDirectories(watchLocationsConfiguration[i].IncludeSubDirectories);
				val.Add(val2);
			}
		}
		return val;
	}

	private void DeleteWatch(WatchLocation watchLocation)
	{
		//IL_000f: Expected O, but got Unknown
		try
		{
			objWatchManager.DeleteWatch(watchLocation);
		}
		catch (WatcherDeletionException val)
		{
			WatcherDeletionException val2 = val;
			ExceptionPublisher.Publish((Exception)(object)val2);
		}
	}

	private WatchLocations GetPersistedShallowwatchLocations()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		WatchLocations val = new WatchLocations();
		ConfigWatchLocation[] watchLocationsConfiguration = objConfigurationManager.GetWatchLocationsConfiguration();
		for (int i = 0; i < watchLocationsConfiguration.Length; i++)
		{
			if (!watchLocationsConfiguration[i].IncludeSubDirectories)
			{
				WatchLocation val2 = new WatchLocation(watchLocationsConfiguration[i].Path);
				((Location)val2).set_IncludeSubDirectories(watchLocationsConfiguration[i].IncludeSubDirectories);
				val.Add(val2);
			}
		}
		return val;
	}

	private WatchInfo CreateDefaultWatchInfo(WatchLocation watchLocation)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		WatchInfo val = new WatchInfo(watchLocation);
		Filters filters = GetFilters();
		val.AddFilter(filters);
		WatchLocations val2 = new WatchLocations();
		ConfigWatchLocation[] excludedWatchLocationsConfiguration = objConfigurationManager.GetExcludedWatchLocationsConfiguration();
		for (int i = 0; i < excludedWatchLocationsConfiguration.Length; i++)
		{
			WatchLocation val3 = new WatchLocation(excludedWatchLocationsConfiguration[i].Path);
			((Location)val3).set_IncludeSubDirectories(excludedWatchLocationsConfiguration[i].IncludeSubDirectories);
			val2.Add(val3);
		}
		val.AddExcludedWatchLocation(val2);
		val.AddChangeType(WatcherChangeTypes.All);
		val.AddNotifyFilter(NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite);
		val.AddAttribute(FileAttributes.ReadOnly | FileAttributes.Archive | FileAttributes.Device | FileAttributes.SparseFile | FileAttributes.ReparsePoint | FileAttributes.Compressed | FileAttributes.Offline | FileAttributes.NotContentIndexed | FileAttributes.Encrypted);
		return val;
	}

	private void AddFolder(string Path, bool IsScanDeep)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		if (!Directory.Exists(Path))
		{
			return;
		}
		DirectoryInfo objDI = new DirectoryInfo(Path);
		string[] configFilters = GetConfigFilters();
		ArrayList arrayList = new ArrayList();
		string[] array = configFilters;
		foreach (string text in array)
		{
			string filterSearchPattern = "*." + text;
			FileInfo[] filesOnDisk = GetFilesOnDisk(objDI, filterSearchPattern);
			if (filesOnDisk != null && filesOnDisk.Length > 0)
			{
				FileInfo[] array2 = filesOnDisk;
				foreach (FileInfo fileInfo in array2)
				{
					ArbusFile val = new ArbusFile();
					val.set_ClientLocation(fileInfo.FullName);
					arrayList.Add(val);
				}
			}
		}
		if (arrayList.Count != 0)
		{
			ArbusFile[] array3 = (ArbusFile[])(object)new ArbusFile[arrayList.Count];
			lock (arrayList.SyncRoot)
			{
				arrayList.CopyTo(array3, 0);
			}
			arrayList = null;
			if (array3.Length != 0)
			{
				objArbusListManager.AddArbusFiles(array3);
			}
		}
		if (IsScanDeep)
		{
			string[] directories = Directory.GetDirectories(Path);
			array = directories;
			foreach (string path in array)
			{
				AddFolder(path, IsScanDeep: true);
			}
		}
	}

	private string[] GetConfigFilters()
	{
		ConfigFilter[] filtersConfiguration = objConfigurationManager.GetFiltersConfiguration();
		string[] array = new string[filtersConfiguration.Length];
		for (int i = 0; i < filtersConfiguration.Length; i++)
		{
			array[i] = filtersConfiguration[i].FiltersName;
		}
		return array;
	}

	private FileInfo[] GetFilesOnDisk(DirectoryInfo objDI, string FilterSearchPattern)
	{
		FileInfo[] array = null;
		try
		{
			return objDI.GetFiles(FilterSearchPattern);
		}
		catch (Exception ex)
		{
			ExceptionPublisher.Publish(ex);
			return null;
		}
	}

	private WatchLocations GetWatchLocations()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_0112: Expected O, but got Unknown
		WatchLocations val = new WatchLocations();
		ArrayList arrayList = new ArrayList();
		ConfigWatchLocation[] watchLocationsConfiguration = objConfigurationManager.GetWatchLocationsConfiguration();
		bool flag = false;
		if (watchLocationsConfiguration != null)
		{
			ConfigWatchLocation[] array = watchLocationsConfiguration;
			foreach (ConfigWatchLocation val2 in array)
			{
				if (val2.Path != null && val2.Path != "")
				{
					if (Directory.Exists(val2.Path))
					{
						WatchLocation val3 = new WatchLocation(val2.Path);
						((Location)val3).set_IncludeSubDirectories(val2.IncludeSubDirectories);
						val.Add(val3);
						arrayList.Add(val2);
					}
					else if (File.Exists(val2.Path))
					{
						WatchLocation val4 = new WatchLocation(val2.Path);
						((Location)val4).set_IncludeSubDirectories(val2.IncludeSubDirectories);
						val.Add(val4);
						arrayList.Add(val2);
					}
					else
					{
						flag = true;
					}
				}
			}
		}
		if (flag)
		{
			watchLocationsConfiguration = (ConfigWatchLocation[])(object)new ConfigWatchLocation[arrayList.Count];
			arrayList.CopyTo(watchLocationsConfiguration, 0);
			objConfigurationManager.SetWatchLocationsConfiguration(watchLocationsConfiguration);
			try
			{
				objConfigurationManager.Save();
				return val;
			}
			catch (ConfigurationSaveException val5)
			{
				ConfigurationSaveException val6 = val5;
				ExceptionPublisher.Publish((Exception)(object)val6);
				return val;
			}
		}
		return val;
	}

	private void AddWatcher(WatchLocation watchLocation)
	{
		//IL_0017: Expected O, but got Unknown
		//IL_0020: Expected O, but got Unknown
		//IL_0029: Expected O, but got Unknown
		WatchInfo val = CreateDefaultWatchInfo(watchLocation);
		try
		{
			objWatchManager.AddWatch(val);
		}
		catch (WatcherInitializationException val2)
		{
			WatcherInitializationException val3 = val2;
			ExceptionPublisher.Publish((Exception)(object)val3);
		}
		catch (InvalidWatchLocationException val4)
		{
			InvalidWatchLocationException val5 = val4;
			ExceptionPublisher.Publish((Exception)(object)val5);
		}
		catch (WatchLocationNotFoundException val6)
		{
			WatchLocationNotFoundException val7 = val6;
			ExceptionPublisher.Publish((Exception)(object)val7);
		}
	}

	public void Dispose()
	{
		DettachWatchManagerEvents();
		objWatchManager.DeleteAllWatchers();
		objWatchManager.RemoveDrivewatcher();
		objWatchManager = null;
		objPCEAgent = null;
	}
}
