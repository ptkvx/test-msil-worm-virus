#define TRACE
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Arbus.Client.Base;
using Arbus.Client.BusinessObjects;
using Arbus.Client.PersonalArchivalEngine.Base;
using Arbus.Client.PersonalArchivalEngine.BusinessObjects;
using Arbus.Common;

namespace MBackMonitor;

public class PAEAgent : IDisposable
{
	private static PAEAgent objPAEAgent;

	private ArchivalJobManager objArchivalJobManager;

	private ArchivalListManager objArchivalListManager;

	private WatchManager objWatchManager;

	private object syncRoot;

	private string strArchivalJobID;

	public WatchManager WatchManager => objWatchManager;

	public event EventHandler OnWatcherError;

	private PAEAgent()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		syncRoot = new object();
		objArchivalListManager = ArchivalListManager.CreateArchivalListManager();
		objArchivalJobManager = new ArchivalJobManager();
		objWatchManager = new WatchManager();
		try
		{
			Initialize();
		}
		catch (Exception ex)
		{
			objArchivalListManager.Dispose();
			objArchivalListManager = null;
			objArchivalJobManager.Dispose();
			objArchivalJobManager = null;
			DettachWatchManagerEvents();
			objWatchManager.DeleteAllWatchers();
			objWatchManager.RemoveDrivewatcher();
			objWatchManager = null;
			objPAEAgent = null;
			throw ex;
		}
	}

	public static PAEAgent CreatePAEAgent()
	{
		if (objPAEAgent == null)
		{
			objPAEAgent = new PAEAgent();
		}
		return objPAEAgent;
	}

	private void Initialize()
	{
		ArchivalJob archivalJob = objArchivalJobManager.GetArchivalJob();
		if (archivalJob == null)
		{
			throw new InvalidOperationException("No Archival Job Exists to Monitor");
		}
		strArchivalJobID = archivalJob.get_ArchivalJobID();
		WatchLocations watchLocations = GetWatchLocations();
		WatchLocations excludedWatchLocations = GetExcludedWatchLocations();
		Filters filters = GetFilters();
		CreateWatchers(watchLocations, excludedWatchLocations, filters);
		AttachWatchManagerEvents();
	}

	private void CreateWatchers(WatchLocations objSourcelocations, WatchLocations objExclusionLocations, Filters objFilters)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		IEnumerator enumerator = ((CollectionBase)(object)objSourcelocations).GetEnumerator();
		while (enumerator.MoveNext())
		{
			WatchLocation val = (WatchLocation)enumerator.Current;
			WatchInfo val2 = new WatchInfo(val);
			val2.AddExcludedWatchLocation(objExclusionLocations);
			val2.AddFilter(objFilters);
			val2.AddChangeType(WatcherChangeTypes.All);
			val2.AddNotifyFilter(NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite);
			val2.AddAttribute(FileAttributes.Hidden | FileAttributes.System | FileAttributes.Directory | FileAttributes.Temporary);
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

	private WatchLocations GetWatchLocations()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		WatchLocations val = new WatchLocations();
		SourceLocation[] array = (SourceLocation[])(object)objArchivalJobManager.GetSourceLocations(strArchivalJobID);
		if (array != null && array.Length != 0)
		{
			for (int i = 0; i < array.Length; i++)
			{
				WatchLocation val2 = new WatchLocation(((Location)array[i]).get_Path());
				((Location)val2).set_IncludeSubDirectories(((Location)array[i]).get_IncludeSubDirectories());
				val.Add(val2);
			}
		}
		return val;
	}

	private Filters GetFilters()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		Filters val = new Filters();
		ArchivalJobManager val2 = new ArchivalJobManager();
		Filter[] filters = val2.GetFilters(strArchivalJobID);
		if (filters != null)
		{
			for (int i = 0; i < filters.Length; i++)
			{
				val.Add(filters[i]);
			}
		}
		return val;
	}

	private WatchLocations GetExcludedWatchLocations()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		WatchLocations val = new WatchLocations();
		Location[] exclusionLocations = objArchivalJobManager.GetExclusionLocations(strArchivalJobID);
		for (int i = 0; i < exclusionLocations.Length; i++)
		{
			ExclusionLocation val2 = (ExclusionLocation)exclusionLocations[i];
			if (File.Exists(((Location)val2).get_Path()) || Directory.Exists(((Location)val2).get_Path()))
			{
				WatchLocation val3 = new WatchLocation(((Location)val2).get_Path());
				((Location)val3).set_IncludeSubDirectories(((Location)val2).get_IncludeSubDirectories());
				val.Add(val3);
			}
		}
		return val;
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
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		lock (syncRoot)
		{
			try
			{
				ArchivalListManager val = ArchivalListManager.CreateArchivalListManager();
				ArchivalFile archiveFileByPath = val.GetArchiveFileByPath(e.get_Path());
				if (archiveFileByPath == null)
				{
					return;
				}
				ArchivalFile val2 = archiveFileByPath;
				if (val2 != null)
				{
					ArchivalFile val3 = (ArchivalFile)val2.Clone();
					if (File.Exists(val3.get_ClientLocation()) && val3.Invalidate())
					{
						SetFileInfoEntries(val3);
						val.UpdateArchivalFile(val3);
					}
					val3 = null;
				}
			}
			catch (Exception ex)
			{
				ExceptionPublisher.Publish(ex);
			}
		}
	}

	private void objWatchManager_OnFileCreate(object sender, WatchEventArgs e)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		lock (syncRoot)
		{
			try
			{
				Trace.WriteLine("File Created. Change Type : " + e.get_ChangeTypes().ToString() + "File Name :" + e.get_Name());
				ArchivalListManager val = ArchivalListManager.CreateArchivalListManager();
				ArchivalFile archivalFileByPath = val.GetArchivalFileByPath(e.get_Path());
				if (archivalFileByPath != null)
				{
					Trace.WriteLine("No existing Archival File Found");
					ArchivalFile val2 = null;
					val2 = (ArchivalFile)archivalFileByPath.Clone();
					val2.set_ClientLocation(e.get_Path());
					if (val2.Invalidate())
					{
						SetFileInfoEntries(val2);
						val.SetTag(val2);
						val.SetWatchLocation(val2);
						val.UpdateArchivalFile(val2);
					}
					val2 = null;
					archivalFileByPath = null;
					return;
				}
				RecycleArchivalFile val3 = null;
				archivalFileByPath = val.GetRealArchivalFile(e.get_Path());
				if (archivalFileByPath != null)
				{
					Trace.WriteLine("Real Archival File Found having same name and creation time.");
					ArchivalFile val4 = null;
					val4 = (ArchivalFile)archivalFileByPath.Clone();
					val4.set_ClientLocation(e.get_Path());
					if (val4.Invalidate())
					{
						val.SetTag(val4);
						val.SetWatchLocation(val4);
						SetFileInfoEntries(val4);
						val.UpdateArchivalFile(val4);
					}
					val4 = null;
				}
				else
				{
					if (archivalFileByPath != null)
					{
						return;
					}
					Trace.WriteLine("No Real Archival File Found having same name and creation time.");
					val3 = val.GetRealRecycleArchivalFile(e.get_Path());
					if (val3 != null)
					{
						Trace.WriteLine("Recycle Archival File Found having same name and creation time.");
						ArchivalFile val5 = null;
						RecycleArchivalFile val6 = (RecycleArchivalFile)val3.Clone();
						val5 = val.ConvertTo(val6);
						val5.set_ClientLocation(e.get_Path());
						val5.Invalidate();
						val.SetTag(val5);
						val.SetWatchLocation(val5);
						SetFileInfoEntries(val5);
						val.AddArchivalFile(val5);
						val5 = null;
					}
					else
					{
						Trace.WriteLine("Archival File Found anywhere.");
						ArchivalJobManager val7 = new ArchivalJobManager();
						SourceLocation val8 = (SourceLocation)val7.ContainsSourceLocations(e.get_Path());
						if (val8 != null)
						{
							val.AddNewAcrhivalFile(e.get_Path(), val8.get_ArchivalJobID());
						}
					}
				}
			}
			catch (Exception ex)
			{
				ExceptionPublisher.Publish(ex);
			}
		}
	}

	private void objWatchManager_OnFileDelete(object sender, WatchEventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0065: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		lock (syncRoot)
		{
			try
			{
				Trace.WriteLine("File Deleted. Change Type : " + e.get_ChangeTypes().ToString() + "File Name :" + e.get_Name());
				ArchivalListManager val = ArchivalListManager.CreateArchivalListManager();
				ArchivalFile val2 = new ArchivalFile();
				val2 = val.GetArchivalFileByPath(e.get_Path());
				if (val2 == null)
				{
					return;
				}
				try
				{
					if (val.DeleteArchivalFile(val2, true) == 0)
					{
						return;
					}
				}
				catch (ArchivalListManagerException val3)
				{
					ArchivalListManagerException val4 = val3;
					ExceptionPublisher.Publish((Exception)(object)val4);
					return;
				}
				if (IsPAEShallowWatched(val2))
				{
					WatchLocation val5 = new WatchLocation(val2.get_ClientLocation());
					((Location)val5).set_Path(val2.get_ClientLocation());
					Thread.Sleep(500);
					if (!File.Exists(val2.get_ClientLocation()))
					{
						DeleteWatch(val5);
					}
				}
			}
			catch (Exception)
			{
				if (this.OnWatcherError != null)
				{
					this.OnWatcherError(this, EventArgs.Empty);
				}
			}
		}
	}

	private bool IsPAEShallowWatched(ArchivalFile objArchivalFile)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ArchivalJobManager val = new ArchivalJobManager();
		SourceLocation[] array = (SourceLocation[])(object)val.GetSourceLocations(objArchivalFile.get_ArchivalJobID());
		if (array != null && array.Length != 0)
		{
			lock (array.SyncRoot)
			{
				SourceLocation[] array2 = array;
				foreach (SourceLocation val2 in array2)
				{
					if (!((Location)val2).get_IncludeSubDirectories() && ((Location)val2).get_Path() == objArchivalFile.get_ClientLocation())
					{
						return true;
					}
				}
			}
			array = null;
		}
		return false;
	}

	private void objWatchManager_OnFileRename(object sender, WatchRenameEventArgs e)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02d3: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		Trace.WriteLine("File Renamed. Change Type : " + ((WatchEventArgs)e).get_ChangeTypes().ToString() + "File Name :" + ((WatchEventArgs)e).get_Name() + " to " + e.get_NewPath());
		ArchivalListManager val = ArchivalListManager.CreateArchivalListManager();
		ArchivalJobManager val2 = new ArchivalJobManager();
		Location[] sourceLocations = val2.GetSourceLocations();
		SourceLocation val3 = null;
		for (int i = 0; i < sourceLocations.Length; i++)
		{
			string path = ((WatchEventArgs)e).get_Path().ToLower();
			if (MendYourWays(sourceLocations[i].get_Path().ToLower()) == MendYourWays(path))
			{
				val3 = (SourceLocation)sourceLocations[i];
				break;
			}
		}
		ArchivalFile val4 = val.GetArchiveFileByPath(((WatchEventArgs)e).get_Path());
		string extension = Path.GetExtension(((WatchEventArgs)e).get_Path());
		string text = Path.GetExtension(e.get_NewPath());
		if (val4 != null)
		{
			Trace.WriteLine("File found by Path.");
			if (extension == text)
			{
				Trace.WriteLine("extInitial = extFinal");
				if (val3 != null)
				{
					((Location)val3).set_Path(e.get_NewPath());
					val2.UpdateSourceLocation((Location)(object)val3);
				}
				ArchivalFile val5 = (ArchivalFile)val4.Clone();
				val5.set_ClientLocation(e.get_NewPath());
				val5.set_Name(Path.GetFileName(val5.get_ClientLocation()));
				val.SetTag(val5);
				val.SetWatchLocation(val5);
				val5.Invalidate();
				SetFileInfoEntries(val5);
				val.UpdateArchivalFile(val5);
				if (val3 != null)
				{
					WatchLocation val6 = new WatchLocation(e.get_NewPath());
					((Location)val6).set_IncludeSubDirectories(((Location)val3).get_IncludeSubDirectories());
					WatchLocation val7 = new WatchLocation(((WatchEventArgs)e).get_Path());
					((Location)val7).set_IncludeSubDirectories(false);
					DeleteWatch(val7);
					AddWatcher(val6);
				}
				return;
			}
			Trace.WriteLine("extInitial != extFinal");
			if (text.StartsWith("."))
			{
				text = text.TrimStart(new char[1] { '.' });
			}
			if (GetPersistedFilters().Contains(text))
			{
				if (val3 != null)
				{
					((Location)val3).set_Path(e.get_NewPath());
					val2.UpdateSourceLocation((Location)(object)val3);
				}
				ArchivalFile val8 = (ArchivalFile)val4.Clone();
				val8.set_Name(Path.GetFileName(e.get_NewPath()));
				val8.set_ClientLocation(e.get_NewPath());
				if (File.Exists(val8.get_ClientLocation()))
				{
					val.SetTag(val8);
					val.SetWatchLocation(val8);
					val8.Invalidate();
					SetFileInfoEntries(val8);
					val.UpdateArchivalFile(val8);
				}
				if (val3 != null)
				{
					WatchLocation val9 = new WatchLocation(e.get_NewPath());
					((Location)val9).set_IncludeSubDirectories(((Location)val3).get_IncludeSubDirectories());
					WatchLocation val10 = new WatchLocation(((WatchEventArgs)e).get_Path());
					((Location)val10).set_IncludeSubDirectories(false);
					DeleteWatch(val10);
					AddWatcher(val9);
				}
				return;
			}
			ArchivalFile val11 = (ArchivalFile)val4.Clone();
			try
			{
				val.DeleteArchivalFile(val11);
			}
			catch (ArchivalListManagerException val12)
			{
				ArchivalListManagerException val13 = val12;
				ExceptionPublisher.Publish((Exception)(object)val13);
			}
			PAEParkingLotManager val14 = new PAEParkingLotManager();
			if (!(val11.get_ArchivalSetWriteTime() != default(DateTime)))
			{
				return;
			}
			try
			{
				val14.UpdateParkingFile(val11);
				return;
			}
			catch (Exception ex)
			{
				ExceptionPublisher.Publish(ex);
				return;
			}
		}
		Trace.WriteLine("No File found by Path.");
		ArchivalFile archiveFileByPath = val.GetArchiveFileByPath(e.get_NewPath());
		if (archiveFileByPath != null)
		{
			val4 = archiveFileByPath;
		}
		if (val4 != null)
		{
			Trace.WriteLine("File found by New Path.");
			ArchivalFile val15 = (ArchivalFile)val4.Clone();
			val15.set_ClientLocation(e.get_NewPath());
			val15.set_Name(Path.GetFileName(val15.get_ClientLocation()));
			if (File.Exists(val15.get_ClientLocation()))
			{
				val.SetTag(val15);
				val.SetWatchLocation(val15);
				val15.Invalidate();
				SetFileInfoEntries(val15);
				val.UpdateArchivalFile(val15);
			}
			return;
		}
		Trace.WriteLine("No File found by New Path.");
		if (text.StartsWith("."))
		{
			text = text.TrimStart(new char[1] { '.' });
		}
		else
		{
			Trace.WriteLine("Filter does not start with '.' extFinal : " + text.ToString());
		}
		if (GetPersistedFilters().Contains(text))
		{
			Trace.WriteLine("Persisted filters contains the new extension of the file.");
			ArchivalJobManager val16 = new ArchivalJobManager();
			SourceLocation val17 = (SourceLocation)val16.ContainsSourceLocations(e.get_NewPath());
			if (val17 != null)
			{
				Trace.WriteLine("Source Location is not null");
				ArchivalFile val18 = new ArchivalFile();
				val18.set_ClientLocation(e.get_NewPath());
				val18.set_ArchivalJobID(val17.get_ArchivalJobID());
				val.AddArchivalFileWithValidation(val18, true);
				Trace.WriteLine("Archival File Attribute " + ((Enum)val18.get_FileState()).ToString());
			}
			return;
		}
		Trace.WriteLine("File type not found in persisted filters.");
		Trace.WriteLine("Filters Are :-");
		Filters persistedFilters = GetPersistedFilters();
		foreach (Filter item in (CollectionBase)(object)persistedFilters)
		{
			Filter val19 = item;
			Trace.WriteLine("Filter type : " + val19.get_FilterName());
		}
		Trace.WriteLine("Filter to found was : " + text.ToString());
	}

	private void objWatchManager_OnFolderChange(object sender, WatchEventArgs e)
	{
		Trace.WriteLine("PAE Folder Change event caught");
	}

	private void objWatchManager_OnFolderCreate(object sender, WatchEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		lock (syncRoot)
		{
			ArchivalJobManager val = new ArchivalJobManager();
			SourceLocation val2 = (SourceLocation)val.ContainsSourceLocations(e.get_Path());
			if (val2 != null)
			{
				string archivalJobID = val2.get_ArchivalJobID();
				if (((Location)e.get_WatchLocation()).get_IncludeSubDirectories())
				{
					AddFolder(e.get_Path(), IsScanDeep: true, archivalJobID);
				}
			}
		}
	}

	private void objWatchManager_OnFolderDelete(object sender, WatchEventArgs e)
	{
		//IL_0036: Expected O, but got Unknown
		lock (syncRoot)
		{
			try
			{
				ArchivalListManager val = ArchivalListManager.CreateArchivalListManager();
				ArchivalFiles allArchivalFiles = val.GetAllArchivalFiles(e.get_Path(), (QueryType)1);
				if (allArchivalFiles != null && ((IndexedCollectionBase)allArchivalFiles).get_Count() != 0)
				{
					val.DeleteArchivalFiles(allArchivalFiles);
				}
			}
			catch (ArchivalListManagerException val2)
			{
				ArchivalListManagerException val3 = val2;
				ExceptionPublisher.Publish((Exception)(object)val3);
			}
		}
	}

	private void objWatchManager_OnFolderRename(object sender, WatchRenameEventArgs e)
	{
		lock (syncRoot)
		{
			ArchivalListManager val = ArchivalListManager.CreateArchivalListManager();
			val.RenameArbusFolder(((WatchEventArgs)e).get_Path(), e.get_NewPath());
		}
	}

	private void objWatchManager_OnWatcherCreation(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		WatcherEventArgs val = (WatcherEventArgs)e;
		WatchLocation val2 = val.get_WatchInfo().get_WatchLocation();
		if (e == null)
		{
			return;
		}
		WatchLocations persistedWatchLocations = GetPersistedWatchLocations();
		for (int i = 0; i < ((CollectionBase)(object)persistedWatchLocations).Count; i++)
		{
			if (MendYourWays(((Location)persistedWatchLocations.get_Item(i)).get_Path()) == MendYourWays(((Location)val.get_WatchInfo().get_WatchLocation()).get_Path()) || MendYourWays(((Location)val.get_WatchInfo().get_WatchLocation()).get_Path()).StartsWith(MendYourWays(((Location)persistedWatchLocations.get_Item(i)).get_Path())))
			{
				val2 = null;
				break;
			}
		}
		if (val.get_WatchInfo().get_IsReCreated() && val2 != null)
		{
			Trace.WriteLine("Watch location is recreated");
			val2 = val.get_WatchInfo().get_WatchLocation();
			SourceLocation val3 = new SourceLocation(((Location)val2).get_Path());
			((Location)val3).set_IncludeSubDirectories(((Location)val2).get_IncludeSubDirectories());
			val3.set_SourceLocationID(Guid.NewGuid().ToString());
			val3.set_ArchivalJobID(GetDefaultArchivalJob().get_ArchivalJobID());
			ArchivalJobManager val4 = new ArchivalJobManager();
			val4.AddSourceLocation((Location)(object)val3);
			if (!val.get_WatchInfo().get_IsReCreated())
			{
				return;
			}
			Trace.WriteLine("Watch location is recreated");
			ArchivalListManager val5 = ArchivalListManager.CreateArchivalListManager();
			RecycleArchivalFiles allRecycleArchivalFiles = val5.GetAllRecycleArchivalFiles(Location.op_Implicit((Location)(object)val.get_WatchInfo().get_WatchLocation()), (QueryType)1);
			if (allRecycleArchivalFiles != null)
			{
				foreach (RecycleArchivalFile item in (IndexedCollectionBase)allRecycleArchivalFiles)
				{
					RecycleArchivalFile val6 = item;
					if (File.Exists(val6.get_ClientLocation()))
					{
						try
						{
							val5.AddArchivalFile(val5.ConvertTo(val6));
						}
						catch
						{
						}
					}
				}
			}
			else
			{
				Trace.WriteLine("No file found in location");
			}
			if (File.Exists(((Location)val.get_WatchInfo().get_WatchLocation()).get_Path()))
			{
				ArrayList arrayList = new ArrayList();
				ArchivalFile val7 = new ArchivalFile();
				val7.set_ClientLocation(((Location)val.get_WatchInfo().get_WatchLocation()).get_Path());
				arrayList.Add(val7);
				val5.bAddFiles = true;
				try
				{
					val5.InsertArchivalFilesAfterValidate(arrayList);
					return;
				}
				catch (Exception ex)
				{
					ExceptionPublisher.Publish(ex);
					return;
				}
				finally
				{
					val5.bAddFiles = false;
				}
			}
			AddFolder(((Location)val.get_WatchInfo().get_WatchLocation()).get_Path(), ((Location)val.get_WatchInfo().get_WatchLocation()).get_IncludeSubDirectories(), GetDefaultArchivalJob().get_ArchivalJobID());
		}
		else if (val2 != null)
		{
			SourceLocation val8 = new SourceLocation(((Location)val2).get_Path());
			((Location)val8).set_IncludeSubDirectories(((Location)val2).get_IncludeSubDirectories());
			val8.set_SourceLocationID(Guid.NewGuid().ToString());
			val8.set_ArchivalJobID(GetDefaultArchivalJob().get_ArchivalJobID());
			ArchivalJobManager val9 = new ArchivalJobManager();
			val9.AddSourceLocation((Location)(object)val8);
		}
	}

	private void objWatchManager_OnWatcherDeletion(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		lock (syncRoot)
		{
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
						ArchivalJobManager val3 = new ArchivalJobManager();
						val3.DeleteSourceLocationByPath((Location)(object)ConvertTo(val2));
					}
				}
				DeleteSourceLocationFiles(val.get_WatchInfo().get_WatchLocation());
			}
			catch (Exception ex)
			{
				ExceptionPublisher.Publish(ex);
				Console.WriteLine(ex.Message);
			}
		}
	}

	private void objWatchManager_OnWatcherError(object sender, EventArgs e)
	{
		lock (syncRoot)
		{
			ErrorEventArgs errorEventArgs = (ErrorEventArgs)e;
			if ((object)((object)errorEventArgs.GetException().GetBaseException()).GetType() == typeof(InternalBufferOverflowException) && this.OnWatcherError != null)
			{
				this.OnWatcherError(this, EventArgs.Empty);
			}
		}
	}

	private void objWatchManager_OnWatcherRename(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		lock (syncRoot)
		{
			WatcherRenameEventArgs val = (WatcherRenameEventArgs)e;
			if (e == null)
			{
				return;
			}
			ArchivalJobManager val2 = new ArchivalJobManager();
			SourceLocation val3 = (SourceLocation)val2.GetSourceLocationByPath(((Location)((WatcherEventArgs)val).get_WatchInfo().get_WatchLocation()).get_Path());
			if (val3 != null)
			{
				((Location)val3).set_Path(Location.op_Implicit((Location)(object)val.get_NewWatchInfo().get_WatchLocation()));
				val2.UpdateSourceLocation((Location)(object)val3);
				try
				{
					ArchivalListManager val4 = ArchivalListManager.CreateArchivalListManager();
					val4.RenameArbusFolder(((Location)((WatcherEventArgs)val).get_WatchInfo().get_WatchLocation()).get_Path(), ((Location)val.get_NewWatchInfo().get_WatchLocation()).get_Path());
					val4 = null;
					return;
				}
				catch (Exception ex)
				{
					ExceptionPublisher.Publish(ex);
					return;
				}
			}
		}
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

	private void SetFileInfoEntries(ArchivalFile objArchivalFile)
	{
		if (File.Exists(objArchivalFile.get_ClientLocation()))
		{
			FileInfo fileInfo = new FileInfo(objArchivalFile.get_ClientLocation());
			objArchivalFile.set_Name(fileInfo.Name);
			objArchivalFile.set_FileSize(fileInfo.Length);
			objArchivalFile.set_ClientLocation(Path.GetFullPath(objArchivalFile.get_ClientLocation()));
			objArchivalFile.set_Accessed(GetDateTimeUptoSeconds(fileInfo.LastAccessTime));
			objArchivalFile.set_Created(GetDateTimeUptoSeconds(fileInfo.CreationTime));
			objArchivalFile.set_Modified(GetDateTimeUptoSeconds(fileInfo.LastWriteTime));
		}
	}

	private void DeleteSourceLocationFiles(WatchLocation objLocationToDelete)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00e1: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_016d: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01cd: Expected O, but got Unknown
		ArchivalListManager val = ArchivalListManager.CreateArchivalListManager();
		if (((Location)objLocationToDelete).get_IncludeSubDirectories())
		{
			bool flag = false;
			if (!Directory.Exists(((Location)objLocationToDelete).get_Path()))
			{
				flag = true;
			}
			if (flag)
			{
				ArchivalFiles allArchivalFiles = val.GetAllArchivalFiles(((Location)objLocationToDelete).get_Path(), (QueryType)1);
				bool flag2 = false;
				foreach (ArchivalFile item in (IndexedCollectionBase)allArchivalFiles)
				{
					ArchivalFile val2 = item;
					try
					{
						val.DeleteArchivalFile(val2, true);
					}
					catch (ArchivalListManagerException)
					{
						flag2 = true;
					}
					catch (Exception)
					{
						flag2 = true;
					}
				}
				if (flag2 && this.OnWatcherError != null)
				{
					this.OnWatcherError(this, EventArgs.Empty);
				}
				return;
			}
			ArchivalFiles allArchivalFiles2 = val.GetAllArchivalFiles(((Location)objLocationToDelete).get_Path(), (QueryType)1);
			{
				foreach (ArchivalFile item2 in (IndexedCollectionBase)allArchivalFiles2)
				{
					ArchivalFile val4 = item2;
					try
					{
						val.DeleteArchivalFile(val4, false, false);
					}
					catch (ArchivalListManagerException val5)
					{
						ArchivalListManagerException val6 = val5;
						ExceptionPublisher.Publish((Exception)(object)val6);
					}
				}
				return;
			}
		}
		bool flag3 = true;
		if (Directory.Exists(((Location)objLocationToDelete).get_Path()))
		{
			flag3 = false;
		}
		else if (File.Exists(((Location)objLocationToDelete).get_Path()))
		{
			flag3 = false;
		}
		if (flag3)
		{
			ArchivalFiles allArchivalFiles3 = val.GetAllArchivalFiles(((Location)objLocationToDelete).get_Path(), (QueryType)1);
			{
				foreach (ArchivalFile item3 in (IndexedCollectionBase)allArchivalFiles3)
				{
					ArchivalFile val7 = item3;
					try
					{
						val.DeleteArchivalFile(val7, true);
					}
					catch (ArchivalListManagerException val8)
					{
						ArchivalListManagerException val9 = val8;
						ExceptionPublisher.Publish((Exception)(object)val9);
					}
				}
				return;
			}
		}
		ArchivalFiles allArchivalFiles4 = val.GetAllArchivalFiles(((Location)objLocationToDelete).get_Path(), (QueryType)1);
		foreach (ArchivalFile item4 in (IndexedCollectionBase)allArchivalFiles4)
		{
			ArchivalFile val10 = item4;
			try
			{
				val.DeleteArchivalFile(val10, false, false);
			}
			catch (ArchivalListManagerException val11)
			{
				ArchivalListManagerException val12 = val11;
				ExceptionPublisher.Publish((Exception)(object)val12);
			}
		}
	}

	private DateTime GetDateTimeUptoSeconds(DateTime dtTime)
	{
		return new DateTime(dtTime.Year, dtTime.Month, dtTime.Day, dtTime.Hour, dtTime.Minute, dtTime.Second);
	}

	private void AddFolder(string Path, bool IsScanDeep, string sArchivalJobID)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		if (!Directory.Exists(Path))
		{
			return;
		}
		DirectoryInfo objDI = new DirectoryInfo(Path);
		ArchivalJobManager val = new ArchivalJobManager();
		Filters allFilters = val.GetAllFilters();
		string[] array = allFilters.ToArray();
		new ArrayList();
		string[] array2 = array;
		foreach (string text in array2)
		{
			string filterSearchPattern = "*." + text;
			FileInfo[] filesOnDisk = GetFilesOnDisk(objDI, filterSearchPattern);
			if (filesOnDisk != null && filesOnDisk.Length > 0)
			{
				FileInfo[] array3 = filesOnDisk;
				foreach (FileInfo fileInfo in array3)
				{
					ArchivalFile val2 = new ArchivalFile();
					val2.set_ClientLocation(fileInfo.FullName);
					val2.set_ArchivalJobID(sArchivalJobID);
					ArchivalListManager val3 = ArchivalListManager.CreateArchivalListManager();
					val3.AddArchivalFileWithValidation(val2, true);
					val2 = null;
				}
			}
		}
		if (IsScanDeep)
		{
			string[] directories = Directory.GetDirectories(Path);
			array2 = directories;
			foreach (string path in array2)
			{
				AddFolder(path, IsScanDeep: true, sArchivalJobID);
			}
		}
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

	private void AddWatcher(WatchLocation watchLocation)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002b: Expected O, but got Unknown
		//IL_0035: Expected O, but got Unknown
		//IL_0040: Expected O, but got Unknown
		ArchivalJobManager val = new ArchivalJobManager();
		ArchivalJob archivalJob = val.GetArchivalJob(strArchivalJobID);
		WatchInfo val2 = CreateDefaultWatchInfo(watchLocation, archivalJob);
		try
		{
			objWatchManager.AddWatch(val2);
		}
		catch (WatcherDeletionException val3)
		{
			WatcherDeletionException val4 = val3;
			ExceptionPublisher.Publish((Exception)(object)val4);
		}
		catch (InvalidWatchLocationException val5)
		{
			InvalidWatchLocationException val6 = val5;
			ExceptionPublisher.Publish((Exception)(object)val6);
		}
		catch (WatchLocationNotFoundException val7)
		{
			WatchLocationNotFoundException val8 = val7;
			ExceptionPublisher.Publish((Exception)(object)val8);
		}
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

	private SourceLocation ConvertTo(WatchLocation objWatchLocation)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		SourceLocation val = new SourceLocation(((Location)objWatchLocation).get_Path());
		((Location)val).set_IncludeSubDirectories(((Location)objWatchLocation).get_IncludeSubDirectories());
		return val;
	}

	private WatchInfo CreateDefaultWatchInfo(WatchLocation watchLocation, ArchivalJob objArchivalJob)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		WatchInfo val = new WatchInfo(watchLocation);
		ArchivalJobManager val2 = new ArchivalJobManager();
		Filter[] filters = val2.GetFilters(objArchivalJob.get_ArchivalJobID());
		Filters val3 = new Filters();
		for (int i = 0; i < filters.Length; i++)
		{
			val3.Add(filters[i]);
		}
		val.AddFilter(val3);
		WatchLocations val4 = new WatchLocations();
		ExclusionLocation[] array = (ExclusionLocation[])(object)val2.GetExclusionLocations(objArchivalJob.get_ArchivalJobID());
		for (int j = 0; j < array.Length; j++)
		{
			WatchLocation val5 = new WatchLocation(((Location)array[j]).get_Path());
			((Location)val5).set_IncludeSubDirectories(((Location)array[j]).get_IncludeSubDirectories());
			val4.Add(val5);
		}
		val.AddExcludedWatchLocation(val4);
		val.AddChangeType(WatcherChangeTypes.All);
		val.AddNotifyFilter(NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite);
		val.AddAttribute(FileAttributes.Hidden | FileAttributes.System | FileAttributes.Directory | FileAttributes.Temporary);
		return val;
	}

	private WatchLocations GetPersistedWatchLocations()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		ArchivalJobManager val = new ArchivalJobManager();
		WatchLocations val2 = new WatchLocations();
		SourceLocation[] array = (SourceLocation[])(object)val.GetSourceLocations();
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				WatchLocation val3 = new WatchLocation(((Location)array[i]).get_Path());
				((Location)val3).set_IncludeSubDirectories(((Location)array[i]).get_IncludeSubDirectories());
				val2.Add(val3);
			}
		}
		return val2;
	}

	private Filters GetPersistedFilters()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ArchivalJobManager val = new ArchivalJobManager();
		return val.GetAllFilters();
	}

	private string GetDefaultArchivalJobID()
	{
		ArchivalJob defaultArchivalJob = GetDefaultArchivalJob();
		if (defaultArchivalJob != null)
		{
			return defaultArchivalJob.get_ArchivalJobID();
		}
		return string.Empty;
	}

	private ArchivalJob GetDefaultArchivalJob()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ArchivalJobManager val = new ArchivalJobManager();
		ArchivalJob result = null;
		try
		{
			result = val.GetArchivalJob();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public void Dispose()
	{
		lock (syncRoot)
		{
			objArchivalListManager.Dispose();
			objArchivalListManager = null;
			objArchivalJobManager.Dispose();
			objArchivalJobManager = null;
			DettachWatchManagerEvents();
			objWatchManager.DeleteAllWatchers();
			objWatchManager.RemoveDrivewatcher();
			objWatchManager = null;
			objPAEAgent = null;
		}
	}
}
