using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using Autodesk.AutoCAD.CustomMigrator;
using Autodesk.AutoCAD.Customization;

namespace Autodesk.AutoCAD.ADMigrator;

public class CUIFileMigrator : IDisposable
{
	public static ILogXML _logger;

	private bool _deleteGeneratedPackage;

	private bool _adskSourceFile;

	private bool LTConversion;

	public static ArrayList TargetFiles;

	private CustomizationSection sourceCUI;

	private CustomizationSection targetCUI;

	private ProductInfo _sourceInfo;

	private ProductInfo _destInfo;

	public bool AutodeskSourceFile => _adskSourceFile;

	public string SourceFile
	{
		get
		{
			if (sourceCUI != null)
			{
				return sourceCUI.get_CUIFileName();
			}
			return null;
		}
	}

	public string TargetFile
	{
		get
		{
			if (targetCUI != null)
			{
				return targetCUI.get_CUIFileName();
			}
			return null;
		}
	}

	public CUIFileMigrator(string source, ILogXML mainFormLogger, ProductInfo srcInfo, ProductInfo dstInfo)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		if (source == null || source.Length < 1)
		{
			return;
		}
		_logger = mainFormLogger;
		_sourceInfo = srcInfo;
		_destInfo = dstInfo;
		try
		{
			sourceCUI = new CustomizationSection(source, true, false);
			string sourceFile = SourceFile;
			string extension = Path.GetExtension(sourceFile);
			if (string.Compare(extension, CustomizationSection.EXTENSION_XML, ignoreCase: true) == 0)
			{
				string text = Path.ChangeExtension(SourceFile, CustomizationSection.EXTENSION_OPC);
				_deleteGeneratedPackage = sourceCUI.SaveAs(text);
				sourceCUI = new CustomizationSection(text, true, false);
			}
		}
		catch (FileNotFoundException)
		{
			string text2 = string.Format(LocalResources.GetString("ERROR_CUI_FILE_NOT_FOUND"), source);
			MainForm.Log2File(text2);
			_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text2);
		}
	}

	public void Dispose()
	{
		if (_deleteGeneratedPackage && sourceCUI != null && string.Compare(sourceCUI.get_CUIFileName(), targetCUI.get_CUIFileName(), ignoreCase: true, CultureInfo.InvariantCulture) != 0 && string.Compare(Path.GetExtension(SourceFile), CustomizationSection.EXTENSION_OPC, ignoreCase: true) == 0)
		{
			File.Delete(SourceFile);
			sourceCUI = null;
			_deleteGeneratedPackage = false;
		}
	}

	public static void SetTargetFiles(StringCollection targetFiles)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		if (TargetFiles == null)
		{
			TargetFiles = new ArrayList();
		}
		StringEnumerator enumerator = targetFiles.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				CustomizationSection val = null;
				try
				{
					MainForm.isTarget = true;
					val = new CustomizationSection(current, true, false);
				}
				catch (FileNotFoundException)
				{
					string text = string.Format(LocalResources.GetString("ERROR_CUI_FILE_NOT_FOUND"), current);
					MainForm.Log2File(text);
					_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text);
					break;
				}
				finally
				{
					MainForm.isTarget = false;
				}
				if (val != null)
				{
					TargetFiles.Add(val);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
	}

	public bool FindInitialTarget()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		if (sourceCUI != null && sourceCUI.get_CuiFileVersion().get_UserVersion() == 0)
		{
			string text = null;
			foreach (MacroGroup item in (CollectionBase)(object)sourceCUI.get_MenuGroup().get_MacroGroups())
			{
				MacroGroup val = item;
				if (val.IsClassA())
				{
					text = val.get_Name();
				}
			}
			if (text != null)
			{
				CUIFileMap fileMapFromMacroGroup = MainForm.GetFileMapFromMacroGroup(text);
				if (fileMapFromMacroGroup != null)
				{
					text = fileMapFromMacroGroup.TargetMacroGroupName;
				}
				_adskSourceFile = true;
				foreach (CustomizationSection targetFile in TargetFiles)
				{
					CustomizationSection val2 = targetFile;
					if (val2.get_MenuGroup().get_MacroGroups().Contains(text))
					{
						targetCUI = val2;
						break;
					}
				}
			}
		}
		if (targetCUI != null)
		{
			return true;
		}
		return false;
	}

	public bool MergeFiles()
	{
		if (sourceCUI != null && targetCUI != null)
		{
			if (!_adskSourceFile)
			{
				return true;
			}
			MergeMacros();
			MergeMenuGroup();
			MergeWorkspaces();
			MergePartialFiles();
			MergeLSPFiles();
			if (sourceCUI.get_MenuGroup().get_Name() != targetCUI.get_MenuGroup().get_Name())
			{
				CUIFileMap fileMapFromMenuGroup = MainForm.GetFileMapFromMenuGroup(sourceCUI.get_MenuGroup().get_Name());
				if (fileMapFromMenuGroup != null && targetCUI.get_MenuGroup().get_Name() == fileMapFromMenuGroup.TargetMenuGroupName)
				{
					targetCUI.get_MenuGroup().set_Name(fileMapFromMenuGroup.SourceMenuGroupName);
					targetCUI.get_MenuGroup().set_Name(fileMapFromMenuGroup.TargetMenuGroupName);
				}
			}
			try
			{
				MainForm.isTarget = true;
				targetCUI.Save();
				if (targetCUI.get_ParentCUI() != null && targetCUI.get_ParentCUI().get_IsModified())
				{
					targetCUI.get_ParentCUI().Save();
				}
			}
			catch (FileSaveException)
			{
				string text = string.Format(LocalResources.GetString("ERROR_FILE_ACCESS_DENIED"), targetCUI.get_CUIFileName());
				MainForm.Log2File(text);
				_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text);
				return false;
			}
			finally
			{
				MainForm.isTarget = false;
			}
			return true;
		}
		return false;
	}

	private void MergeMacros()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		foreach (MacroGroup item in (CollectionBase)(object)sourceCUI.get_MenuGroup().get_MacroGroups())
		{
			MacroGroup val = item;
			StringCollection stringCollection = new StringCollection();
			MacroGroup val2 = null;
			CUIFileMap fileMapFromMacroGroup = MainForm.GetFileMapFromMacroGroup(val.get_Name());
			foreach (MacroGroup item2 in (CollectionBase)(object)targetCUI.get_MenuGroup().get_MacroGroups())
			{
				MacroGroup val3 = item2;
				if (string.Compare(val.get_Name(), val3.get_Name(), ignoreCase: true, CultureInfo.InvariantCulture) != 0)
				{
					if (fileMapFromMacroGroup != null && fileMapFromMacroGroup.TargetMacroGroupName.Equals(val3.get_Name(), StringComparison.InvariantCultureIgnoreCase))
					{
						val2 = val3;
						if (!MainForm.isACAD)
						{
							LTConversion = true;
						}
						break;
					}
					continue;
				}
				val2 = val3;
				break;
			}
			if (val2 != null)
			{
				foreach (MenuMacro item3 in (CollectionBase)(object)val.MenuMacros)
				{
					MenuMacro val4 = item3;
					bool flag = false;
					foreach (Macro macro in val4.Macros)
					{
						Macro val5 = macro;
						if (((VersionableElement)val5).UserModified())
						{
							flag = true;
						}
					}
					if (!flag)
					{
						continue;
					}
					MenuMacro val6 = targetCUI.FindMenuMacro(((CustomizationElement)val4).get_ElementID());
					if (val6 == null)
					{
						continue;
					}
					foreach (Macro macro2 in val4.Macros)
					{
						Macro val7 = macro2;
						if (((VersionableElement)val7).UserModified())
						{
							val6.Macros.Add(val7);
							if (!string.IsNullOrEmpty(val7.get_SmallImage()) && val7.get_SmallImage().IndexOf('.') >= 0 && !StringArrayUtilities.Contains(stringCollection, val7.get_SmallImage(), true))
							{
								stringCollection.Add(val7.get_SmallImage());
							}
							if (!string.IsNullOrEmpty(val7.get_LargeImage()) && val7.get_LargeImage().IndexOf('.') >= 0 && !StringArrayUtilities.Contains(stringCollection, val7.get_LargeImage(), true))
							{
								stringCollection.Add(val7.get_LargeImage());
							}
						}
					}
				}
			}
			else
			{
				targetCUI.get_MenuGroup().get_MacroGroups().Clone(val);
				foreach (MenuMacro item4 in (CollectionBase)(object)val.MenuMacros)
				{
					MenuMacro val8 = item4;
					foreach (Macro macro3 in val8.Macros)
					{
						Macro val9 = macro3;
						if (!string.IsNullOrEmpty(val9.get_SmallImage()) && val9.get_SmallImage().IndexOf('.') >= 0 && !StringArrayUtilities.Contains(stringCollection, val9.get_SmallImage(), true))
						{
							stringCollection.Add(val9.get_SmallImage());
						}
						if (!string.IsNullOrEmpty(val9.get_LargeImage()) && val9.get_LargeImage().IndexOf('.') >= 0 && !StringArrayUtilities.Contains(stringCollection, val9.get_LargeImage(), true))
						{
							stringCollection.Add(val9.get_LargeImage());
						}
					}
				}
			}
			if (stringCollection.Count > 0)
			{
				string[] array = new string[stringCollection.Count];
				for (int i = 0; i < stringCollection.Count; i++)
				{
					array[i] = stringCollection[i];
				}
				MenuPackage.CopyPartsBetweenPackages(sourceCUI.get_CUIFileName(), targetCUI.get_CUIFileName(), array, true);
			}
		}
	}

	private void MergeMenuGroup()
	{
		if (LTConversion)
		{
			LTConvertMenuGroup();
			return;
		}
		if (sourceCUI.get_MenuGroup().get_Accelerators() != null)
		{
			GenericMigration((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_Accelerators(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_Accelerators());
		}
		if (sourceCUI.get_MenuGroup().get_TemporaryOverrides() != null)
		{
			GenericMigration((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_TemporaryOverrides(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_TemporaryOverrides());
		}
		if (sourceCUI.get_MenuGroup().get_MouseButtons() != null)
		{
			GenericMigration((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_MouseButtons(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_MouseButtons());
		}
		if (sourceCUI.get_MenuGroup().get_DigitizerButtons() != null)
		{
			GenericMigration((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_DigitizerButtons(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_DigitizerButtons());
		}
		if (sourceCUI.get_MenuGroup().get_PopMenus() != null)
		{
			GenericMigration((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_PopMenus(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_PopMenus());
		}
		if (sourceCUI.get_MenuGroup().get_Toolbars() != null)
		{
			GenericMigration((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_Toolbars(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_Toolbars());
		}
		if (sourceCUI.get_MenuGroup().get_ScreenMenus() != null)
		{
			GenericMigration((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_ScreenMenus(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_ScreenMenus());
		}
		if (sourceCUI.get_MenuGroup().get_TabletMenus() != null)
		{
			GenericMigration((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_TabletMenus(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_TabletMenus());
		}
		if (sourceCUI.get_MenuGroup().get_QuickAccessToolbars() != null)
		{
			GenericMigration((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_QuickAccessToolbars(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_QuickAccessToolbars());
		}
		if (sourceCUI.get_MenuGroup().get_QuickPropertiesObjectTypes() != null)
		{
			GenericObjectTypes((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_QuickPropertiesObjectTypes(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_QuickPropertiesObjectTypes());
		}
		if (sourceCUI.get_MenuGroup().get_RolloverTooltipObjectTypes() != null)
		{
			GenericObjectTypes((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_RolloverTooltipObjectTypes(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_RolloverTooltipObjectTypes());
		}
		if (sourceCUI.get_MenuGroup().get_ImageMenus() != null)
		{
			GenericMigration((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_ImageMenus(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_ImageMenus());
		}
		if (sourceCUI.get_MenuGroup().get_DoubleClickActions() != null)
		{
			GenericMigration((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_DoubleClickActions(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_DoubleClickActions());
		}
	}

	private void MergeObjectProperty(ICustomizationContainer scontainer, ICustomizationContainer tcontainer)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Invalid comparison between Unknown and I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Invalid comparison between Unknown and I4
		if (scontainer == null || tcontainer == null)
		{
			return;
		}
		foreach (CustomizationElement item in (CollectionBase)(object)scontainer.get_ContainerCollection())
		{
			CustomizationElement val = item;
			if (val == null || !((VersionableElement)val).UserModified())
			{
				continue;
			}
			ObjectPropertyCategory val2 = (ObjectPropertyCategory)(object)((val is ObjectPropertyCategory) ? val : null);
			ObjectProperty val3 = (ObjectProperty)(object)((val is ObjectProperty) ? val : null);
			if (val2 == null && val3 == null)
			{
				continue;
			}
			if (val2 != null)
			{
				PropertyCollection propertyList = val2.get_PropertyList();
				if (propertyList == null)
				{
					continue;
				}
				foreach (ObjectProperty item2 in (CollectionBase)(object)propertyList)
				{
					ObjectProperty val4 = item2;
					if (val4 == null || !((VersionableElement)val4).UserModified())
					{
						continue;
					}
					ObjectPropertyCategory val5 = null;
					foreach (CustomizationElement item3 in (CollectionBase)(object)tcontainer.get_ContainerCollection())
					{
						CustomizationElement val6 = item3;
						ObjectPropertyCategory val7 = (ObjectPropertyCategory)(object)((val6 is ObjectPropertyCategory) ? val6 : null);
						if (val7 != null && val7.get_categoryId() == val2.get_categoryId())
						{
							val5 = val7;
							break;
						}
					}
					if (val5 != null && val5.get_PropertyList() != null)
					{
						if (!val5.get_PropertyList().Contains(((ObjectPropertyBase)val4).get_Name()))
						{
							val5.get_PropertyList().Add((ObjectPropertyBase)(object)val4);
						}
					}
					else if (val5 == null)
					{
						((IList)tcontainer.get_ContainerCollection()).Add((object?)val2);
						break;
					}
				}
			}
			else
			{
				if (val3 == null || !((VersionableElement)val3).UserModified())
				{
					continue;
				}
				bool flag = false;
				foreach (CustomizationElement item4 in (CollectionBase)(object)tcontainer.get_ContainerCollection())
				{
					CustomizationElement val8 = item4;
					ObjectProperty val9 = (ObjectProperty)(object)((val8 is ObjectProperty) ? val8 : null);
					if (val9 != null && ((ObjectPropertyBase)val3).get_Name() == ((ObjectPropertyBase)val9).get_Name())
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					((IList)tcontainer.get_ContainerCollection()).Add((object?)val3);
				}
			}
		}
		ArrayList arrayList = new ArrayList();
		ArrayList arrayList2 = new ArrayList();
		foreach (CustomizationElement item5 in (CollectionBase)(object)tcontainer.get_ContainerCollection())
		{
			CustomizationElement val10 = item5;
			ObjectPropertyCategory val11 = (ObjectPropertyCategory)(object)((val10 is ObjectPropertyCategory) ? val10 : null);
			ObjectProperty val12 = (ObjectProperty)(object)((val10 is ObjectProperty) ? val10 : null);
			if (val11 == null && val12 == null)
			{
				continue;
			}
			if (val11 != null && (int)((VersionableElement)val11).get_ModifiedRevision() < 4)
			{
				ObjectPropertyCategory val13 = null;
				foreach (CustomizationElement item6 in (CollectionBase)(object)scontainer.get_ContainerCollection())
				{
					CustomizationElement val14 = item6;
					ObjectPropertyCategory val15 = (ObjectPropertyCategory)(object)((val14 is ObjectPropertyCategory) ? val14 : null);
					if (val15 != null && val15.get_categoryId() == val11.get_categoryId())
					{
						val13 = val15;
						break;
					}
				}
				if (val13 == null)
				{
					arrayList.Add(((CustomizationElement)val11).get_ElementID());
				}
				else
				{
					if (val13.get_PropertyList() == null)
					{
						continue;
					}
					PropertyCollection propertyList2 = val11.get_PropertyList();
					if (propertyList2 == null)
					{
						continue;
					}
					ArrayList arrayList3 = new ArrayList();
					foreach (ObjectProperty item7 in (CollectionBase)(object)propertyList2)
					{
						ObjectProperty val16 = item7;
						if (val16 != null && !val13.get_PropertyList().Contains(((ObjectPropertyBase)val16).get_Name()))
						{
							arrayList3.Add(val16);
						}
					}
					foreach (ObjectProperty item8 in arrayList3)
					{
						ObjectProperty val17 = item8;
						propertyList2.Remove((ObjectPropertyBase)(object)val17);
					}
				}
			}
			else if (val12 != null && (int)((VersionableElement)val12).get_ModifiedRevision() < 4)
			{
				int num = scontainer.get_ContainerCollection().IndexOf(((ObjectPropertyBase)val12).get_Name());
				if (num < 0)
				{
					arrayList2.Add(((ObjectPropertyBase)val12).get_Name());
				}
			}
		}
		foreach (string item9 in arrayList)
		{
			int num2 = tcontainer.get_ContainerCollection().IndexOf(item9);
			if (num2 >= 0)
			{
				((CollectionBase)(object)tcontainer.get_ContainerCollection()).RemoveAt(num2);
			}
		}
		foreach (string item10 in arrayList2)
		{
			int num3 = tcontainer.get_ContainerCollection().IndexOf(item10);
			if (num3 >= 0)
			{
				((CollectionBase)(object)tcontainer.get_ContainerCollection()).RemoveAt(num3);
			}
		}
	}

	private void GenericObjectTypes(MenuGroupItemsCollection smgCollection, MenuGroupItemsCollection tmgCollection)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		foreach (CustomizationElement item in (CollectionBase)(object)smgCollection)
		{
			CustomizationElement val = item;
			ObjectType val2 = (ObjectType)(object)((val is ObjectType) ? val : null);
			ObjectTypeCollection val3 = (ObjectTypeCollection)(object)((tmgCollection is ObjectTypeCollection) ? tmgCollection : null);
			CustomizationElement val4 = (CustomizationElement)(object)val3.FindWithName(val2.get_ClassName());
			ICustomizationContainer val5 = (ICustomizationContainer)(object)val2;
			ICustomizationContainer val6 = (ICustomizationContainer)(object)((val4 is ICustomizationContainer) ? val4 : null);
			if (((VersionableElement)val2).UserModified())
			{
				if (val4 == null)
				{
					ContainerCloneAction val7 = (ContainerCloneAction)1;
					tmgCollection.Clone((CustomizationElement)(object)val2, (CustomizationElement)null, ref val7);
				}
				else if (val5 != null)
				{
					MergeObjectProperty(val5, val6);
				}
				else
				{
					val4.Replace((CustomizationElement)(object)val2);
				}
			}
			else if (val5 != null && val6 != null)
			{
				MergeObjectProperty(val5, val6);
			}
		}
	}

	private void GenericMigration(MenuGroupItemsCollection smgCollection, MenuGroupItemsCollection tmgCollection)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Invalid comparison between Unknown and I4
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		int num = -1;
		foreach (CustomizationElement item in (CollectionBase)(object)smgCollection)
		{
			CustomizationElement val = item;
			CustomizationElement val2 = (CustomizationElement)targetCUI.getMenuObj(val.get_ElementID());
			ICustomizationContainer val3 = (ICustomizationContainer)(object)((val is ICustomizationContainer) ? val : null);
			ICustomizationContainer val4 = (ICustomizationContainer)(object)((val2 is ICustomizationContainer) ? val2 : null);
			if (((VersionableElement)val).UserModified())
			{
				if (val2 == null)
				{
					ContainerCloneAction val5 = (ContainerCloneAction)1;
					tmgCollection.Clone(val, (CustomizationElement)null, ref val5);
				}
				else if (val3 != null)
				{
					SortedList sortedList = FindNewItems(val3.get_ContainerCollection(), val4.get_ContainerCollection());
					val2.Replace(val);
					foreach (CustomizationElement item2 in (CollectionBase)(object)val3.get_ContainerCollection())
					{
						CustomizationElement val6 = item2;
						if (ValidReference(val6))
						{
							((IList)val4.get_ContainerCollection()).Add((object?)val6);
						}
					}
					if (sortedList.Count <= 0)
					{
						continue;
					}
					foreach (DictionaryEntry item3 in sortedList)
					{
						if (!(item3.Value is CustElementLocation custElementLocation))
						{
							continue;
						}
						num = val4.get_ContainerCollection().IndexOf(custElementLocation.CustElement.get_ElementID());
						if (num > -1)
						{
							CustomizationElement val7 = val4.get_ContainerCollection().get_Item(num);
							if (!((VersionableElement)val7).UserModified())
							{
								val4.get_ContainerCollection().Replace(val7, custElementLocation.CustElement);
							}
							continue;
						}
						if (custElementLocation.insertAfter == null)
						{
							num = custElementLocation.offset;
						}
						else
						{
							num = val4.get_ContainerCollection().IndexOf(custElementLocation.insertAfter.get_ElementID());
							num += custElementLocation.offset;
						}
						if (num > ((CollectionBase)(object)val4.get_ContainerCollection()).Count)
						{
							num = ((CollectionBase)(object)val4.get_ContainerCollection()).Count;
						}
						((IList)val4.get_ContainerCollection()).Insert(num, (object?)custElementLocation.CustElement);
					}
				}
				else
				{
					val2.Replace(val);
				}
			}
			else
			{
				if (val3 == null || val4 == null)
				{
					continue;
				}
				foreach (CustomizationElement item4 in (CollectionBase)(object)val3.get_ContainerCollection())
				{
					CustomizationElement val8 = item4;
					if (!ValidReference(val8))
					{
						continue;
					}
					CustomizationElement val9 = (CustomizationElement)targetCUI.getMenuObj(val8.get_ElementID());
					if (val9 != null)
					{
						if (((VersionableElement)val8).UserModified())
						{
							val4.get_ContainerCollection().Replace(val9, val8);
						}
						if (!val4.get_ContainerCollection().Contains(val9) && ((VersionableElement)val8).UserModified())
						{
							num = val3.get_ContainerCollection().IndexOf(val8.get_ElementID());
							if (num > ((CollectionBase)(object)val4.get_ContainerCollection()).Count)
							{
								num = ((CollectionBase)(object)val4.get_ContainerCollection()).Count;
							}
							ElementBase parent = ((ElementBase)val9).get_Parent();
							ICustomizationContainer val10 = (ICustomizationContainer)(object)((parent is ICustomizationContainer) ? parent : null);
							if (val10 != null)
							{
								((IList)val10.get_ContainerCollection()).Remove((object?)val9);
								((IList)val4.get_ContainerCollection()).Insert(num, (object?)val8);
							}
						}
					}
					else if (val8.get_ElementID() != null && ((VersionableElement)val8).UserModified())
					{
						num = val3.get_ContainerCollection().IndexOf(val8.get_ElementID());
						if (num > ((CollectionBase)(object)val4.get_ContainerCollection()).Count)
						{
							num = ((CollectionBase)(object)val4.get_ContainerCollection()).Count;
						}
						((IList)val4.get_ContainerCollection()).Insert(num, (object?)val8);
					}
				}
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < ((CollectionBase)(object)val4.get_ContainerCollection()).Count; i++)
				{
					CustomizationElement val11 = val4.get_ContainerCollection().get_Item(i);
					if (val11.get_ElementID() != null && val3.get_ContainerCollection().IndexOf(val11.get_ElementID()) < 0 && (int)((VersionableElement)val11).get_ModifiedRevision() < 4)
					{
						arrayList.Add(val4.get_ContainerCollection().get_Item(i));
					}
				}
				foreach (CustomizationElement item5 in arrayList)
				{
					CustomizationElement val12 = item5;
					int num2 = val4.get_ContainerCollection().IndexOf(val12.get_ElementID());
					if (num2 >= 0)
					{
						((CollectionBase)(object)val4.get_ContainerCollection()).RemoveAt(num2);
					}
				}
			}
		}
	}

	private bool ValidReference(CustomizationElement ce)
	{
		IReference val = (IReference)(object)((ce is IReference) ? ce : null);
		if (val != null && val.get_MacroID() != null)
		{
			MenuMacro val2 = targetCUI.FindMenuMacro(val.get_MacroID());
			if (val2 == null)
			{
				return false;
			}
		}
		return true;
	}

	private void MergeWorkspaces()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		string currentProfileWorkspaceName = Migrator.GetCurrentProfileWorkspaceName(_sourceInfo.m_regRootKey);
		bool flag = false;
		foreach (Workspace item in (CollectionBase)(object)sourceCUI.get_Workspaces())
		{
			Workspace val = item;
			if (((VersionableElement)val).UserModified())
			{
				string name = val.get_Name();
				string text = string.Format(LocalResources.GetString("RENAMED_WORKSPACE_SUFFIX"), val.get_Name(), _sourceInfo.m_productName);
				int num = 1;
				while (((CustomizationCollection)targetCUI.get_Workspaces()).IndexOf(text) >= 0)
				{
					text = text + " [" + num++.ToString() + ']';
				}
				val.set_Name(text);
				ContainerCloneAction val2 = (ContainerCloneAction)1;
				targetCUI.get_Workspaces().MigrateWorkspace(val, (Workspace)null, ref val2);
				val.set_Name(name);
				if (string.Compare(name, currentProfileWorkspaceName, ignoreCase: true) == 0)
				{
					Migrator.SetCurrentProfileWorkspaceName(_destInfo.m_regRootKey, text);
					flag = true;
				}
			}
		}
		if (flag)
		{
			return;
		}
		Workspace val3 = null;
		foreach (Workspace item2 in (CollectionBase)(object)sourceCUI.get_Workspaces())
		{
			Workspace val4 = item2;
			if (val4.get_DefaultWorkspace())
			{
				val3 = val4;
				break;
			}
		}
		if (val3 != null)
		{
			Migrator.SetCurrentProfileWorkspaceName(_destInfo.m_regRootKey, val3.get_Name());
		}
	}

	private void MergePartialFiles()
	{
		if (sourceCUI.get_PartialCuiFiles() == null || ((StringCollection)(object)sourceCUI.get_PartialCuiFiles()).Count <= 0)
		{
			return;
		}
		StringEnumerator enumerator = ((StringCollection)(object)sourceCUI.get_PartialCuiFiles()).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				string fileNameWithoutExtension;
				try
				{
					fileNameWithoutExtension = Path.GetFileNameWithoutExtension(current);
				}
				catch (ArgumentException)
				{
					continue;
				}
				if (Util.IsEmpty(fileNameWithoutExtension) || (_sourceInfo.IsBeforeGator() && (fileNameWithoutExtension.Equals("ContentSearch", StringComparison.OrdinalIgnoreCase) || fileNameWithoutExtension.Equals("AcImpression", StringComparison.OrdinalIgnoreCase) || fileNameWithoutExtension.Equals("Acetmain", StringComparison.OrdinalIgnoreCase))))
				{
					continue;
				}
				bool flag = false;
				CUIFileMap fileMapFromFileName = MainForm.GetFileMapFromFileName(fileNameWithoutExtension);
				if (fileMapFromFileName != null)
				{
					fileNameWithoutExtension = fileMapFromFileName.TargetFileName;
					fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileNameWithoutExtension);
				}
				StringEnumerator enumerator2 = ((StringCollection)(object)targetCUI.get_PartialCuiFiles()).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						string current2 = enumerator2.Current;
						string fileNameWithoutExtension2;
						try
						{
							fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(current2);
						}
						catch (ArgumentException)
						{
							continue;
						}
						if (!Util.IsEmpty(fileNameWithoutExtension2) && fileNameWithoutExtension.Equals(fileNameWithoutExtension2, StringComparison.InvariantCultureIgnoreCase))
						{
							flag = true;
							break;
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable disposable)
					{
						disposable.Dispose();
					}
				}
				if (!flag)
				{
					((CuiFileCollectionBase)targetCUI.get_PartialCuiFiles()).Add(Path.ChangeExtension(fileNameWithoutExtension, CustomizationSection.EXTENSION_OPC));
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable2)
			{
				disposable2.Dispose();
			}
		}
	}

	private void MergeLSPFiles()
	{
		if (sourceCUI.get_MenuGroup().get_LspFiles() == null || ((StringCollection)(object)sourceCUI.get_MenuGroup().get_LspFiles()).Count <= 0)
		{
			return;
		}
		StringEnumerator enumerator = ((StringCollection)(object)sourceCUI.get_MenuGroup().get_LspFiles()).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				if (!((CuiFileCollectionBase)targetCUI.get_MenuGroup().get_LspFiles()).Contains(current))
				{
					((CuiFileCollectionBase)targetCUI.get_MenuGroup().get_LspFiles()).Add(current);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
	}

	private SortedList FindNewItems(CustomizationCollection sourceCollection, CustomizationCollection targetCollection)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and I4
		SortedList sortedList = new SortedList();
		foreach (CustomizationElement item in (CollectionBase)(object)targetCollection)
		{
			CustomizationElement val = item;
			int num = sourceCollection.IndexOf(val.get_ElementID());
			if ((int)((VersionableElement)val).get_ModifiedRevision() != 4)
			{
				continue;
			}
			CustElementLocation custElementLocation = new CustElementLocation(val);
			int num2 = targetCollection.IndexOf(val.get_ElementID());
			if (num < 0)
			{
				CustomizationElement val2 = null;
				int num3 = 0;
				while (num < 0)
				{
					num3++;
					if (num2 - num3 < 0)
					{
						break;
					}
					val2 = targetCollection.get_Item(num2 - num3);
					if (val2 != null && val2.get_ElementID() != null)
					{
						num = sourceCollection.IndexOf(val2.get_ElementID());
					}
				}
				if (num > -1)
				{
					custElementLocation.insertAfter = sourceCollection.get_Item(num);
					custElementLocation.offset = num3;
				}
				else
				{
					custElementLocation.offset = num2;
				}
			}
			else
			{
				custElementLocation.offset = 0;
			}
			try
			{
				sortedList.Add(num2, custElementLocation);
			}
			catch (ArgumentException)
			{
			}
		}
		return sortedList;
	}

	public static StringCollection FindTargetCUIFiles(string regRoot)
	{
		StringCollection stringCollection = new StringCollection();
		string appInstallDir = Migrator.GetAppInstallDir(regRoot);
		appInstallDir += "UserDataCache";
		FindCUIFiles(appInstallDir, stringCollection);
		SetTargetFiles(stringCollection);
		return stringCollection;
	}

	public static void FindCUIFiles(string rootPath, StringCollection installedFiles)
	{
		try
		{
			string searchPattern = $"*{CustomizationSection.EXTENSION_OPC}";
			string[] files = Directory.GetFiles(rootPath, searchPattern);
			if (files.Length > 0)
			{
				string[] array = files;
				foreach (string text in array)
				{
					if (string.Compare(Path.GetExtension(text), CustomizationSection.EXTENSION_OPC, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
					{
						installedFiles.Add(text);
					}
				}
			}
			string[] directories = Directory.GetDirectories(rootPath);
			if (directories.Length > 0)
			{
				string[] array2 = directories;
				foreach (string rootPath2 in array2)
				{
					FindCUIFiles(rootPath2, installedFiles);
				}
			}
		}
		catch (Exception)
		{
			string text2 = string.Format(LocalResources.GetString("ERROR_USERDATACACHE_NOT_FOUND"));
			MainForm.Log2File(text2);
			_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text2);
		}
	}

	public bool SetFinalTarget(ProfileMigrator pm, string targetRootKey)
	{
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		string text = Migrator.GetRoamableRootFolder(targetRootKey) + "Backup\\";
		string text2 = pm.SourceEncode(SourceFile);
		string text3 = pm.TargetExpand(text2);
		if (File.Exists(text3))
		{
			string text4 = Path.GetExtension(text3);
			if (Util.IsEmpty(text4))
			{
				text4 = CustomizationSection.EXTENSION_XML;
			}
			string directoryName = Path.GetDirectoryName(text3);
			directoryName = directoryName + "\\" + Path.GetFileNameWithoutExtension(text3);
			directoryName = directoryName + ".bak" + text4;
			try
			{
				File.Copy(text3, directoryName, overwrite: true);
				if ((File.GetAttributes(directoryName) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					File.SetAttributes(directoryName, File.GetAttributes(directoryName) ^ FileAttributes.ReadOnly);
				}
			}
			catch (UnauthorizedAccessException)
			{
				string text5 = string.Format(LocalResources.GetString("ERROR_FILE_ACCESS_DENIED"), directoryName);
				MainForm.Log2File(text5);
				_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text5);
			}
		}
		if (_adskSourceFile && TargetFile != null)
		{
			if (string.Compare(SourceFile, text3, ignoreCase: true, CultureInfo.InvariantCulture) != 0)
			{
				string text6 = text + Path.GetFileName(SourceFile);
				try
				{
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					File.Copy(SourceFile, text6, overwrite: true);
					if ((File.GetAttributes(text6) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
					{
						File.SetAttributes(text6, File.GetAttributes(text6) ^ FileAttributes.ReadOnly);
					}
				}
				catch (Exception)
				{
					string text7 = string.Format(LocalResources.GetString("ERROR_FILE_ACCESS_DENIED"), text6);
					MainForm.Log2File(text7);
					_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text7);
				}
				if (MainForm.CUIFileMapArray.Count > 0)
				{
					CUIFileMap fileMapFromFileName = MainForm.GetFileMapFromFileName(Path.GetFileName(SourceFile));
					if (fileMapFromFileName != null)
					{
						text3 = text3.ToLower().Replace(fileMapFromFileName.SourceFileName.ToLower(), fileMapFromFileName.TargetFileName.ToLower());
					}
				}
				if (File.Exists(text3))
				{
					string text8 = text + Path.GetFileName(text3);
					if (!File.Exists(text8))
					{
						try
						{
							if (!Directory.Exists(text))
							{
								Directory.CreateDirectory(text);
							}
							File.Copy(text3, text8, overwrite: false);
							if ((File.GetAttributes(text8) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
							{
								File.SetAttributes(text8, File.GetAttributes(text8) ^ FileAttributes.ReadOnly);
							}
						}
						catch (UnauthorizedAccessException)
						{
							string text9 = string.Format(LocalResources.GetString("ERROR_FILE_ACCESS_DENIED"), text8);
							MainForm.Log2File(text9);
							_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text9);
						}
					}
				}
				try
				{
					if (!Directory.Exists(Path.GetDirectoryName(text3)))
					{
						Directory.CreateDirectory(Path.GetDirectoryName(text3));
					}
					File.Copy(TargetFile, text3, overwrite: true);
					if ((File.GetAttributes(text3) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
					{
						File.SetAttributes(text3, File.GetAttributes(text3) ^ FileAttributes.ReadOnly);
					}
				}
				catch (Exception)
				{
					string text10 = string.Format(LocalResources.GetString("ERROR_FILE_ACCESS_DENIED"), text3);
					MainForm.Log2File(text10);
					_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text10);
				}
			}
			else
			{
				string productMarketReleaseVersion = GetProductMarketReleaseVersion(_destInfo);
				int num = text3.LastIndexOf(CustomizationSection.EXTENSION_OPC);
				text3 = ((num <= -1) ? (text3 + "_" + productMarketReleaseVersion + CustomizationSection.EXTENSION_OPC) : (text3.Substring(0, num) + "_" + productMarketReleaseVersion + CustomizationSection.EXTENSION_OPC));
				try
				{
					if (!Directory.Exists(Path.GetDirectoryName(text3)))
					{
						Directory.CreateDirectory(Path.GetDirectoryName(text3));
					}
					File.Copy(TargetFile, text3, overwrite: true);
					if ((File.GetAttributes(text3) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
					{
						File.SetAttributes(text3, File.GetAttributes(text3) ^ FileAttributes.ReadOnly);
					}
				}
				catch (Exception)
				{
					string text11 = string.Format(LocalResources.GetString("ERROR_FILE_ACCESS_DENIED"), text3);
					MainForm.Log2File(text11);
					_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text11);
				}
			}
		}
		else if (string.Compare(text2, text3, ignoreCase: true, CultureInfo.InvariantCulture) != 0)
		{
			if (File.Exists(text3))
			{
				string text12 = text + Path.GetFileName(text3);
				if (!File.Exists(text12))
				{
					try
					{
						if (!Directory.Exists(Path.GetDirectoryName(text)))
						{
							Directory.CreateDirectory(Path.GetDirectoryName(text));
						}
						File.Copy(text3, text12, overwrite: false);
						if ((File.GetAttributes(text12) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
						{
							File.SetAttributes(text12, File.GetAttributes(text12) ^ FileAttributes.ReadOnly);
						}
					}
					catch (UnauthorizedAccessException)
					{
						string text13 = string.Format(LocalResources.GetString("ERROR_FILE_ACCESS_DENIED"), text12);
						MainForm.Log2File(text13);
						_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text13);
					}
				}
			}
			try
			{
				if (!Directory.Exists(Path.GetDirectoryName(text3)))
				{
					Directory.CreateDirectory(Path.GetDirectoryName(text3));
				}
				File.Copy(SourceFile, text3, overwrite: true);
				if ((File.GetAttributes(text3) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					File.SetAttributes(text3, File.GetAttributes(text3) ^ FileAttributes.ReadOnly);
				}
			}
			catch (Exception)
			{
				string text14 = string.Format(LocalResources.GetString("ERROR_FILE_ACCESS_DENIED"), text3);
				MainForm.Log2File(text14);
				_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text14);
			}
		}
		try
		{
			MainForm.isTarget = true;
			targetCUI = new CustomizationSection(text3, true, false);
		}
		catch (FileNotFoundException)
		{
			string text15 = string.Format(LocalResources.GetString("ERROR_CUI_FILE_NOT_FOUND"), SourceFile);
			MainForm.Log2File(text15);
			_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text15);
			return false;
		}
		finally
		{
			MainForm.isTarget = false;
		}
		return true;
	}

	internal string GetProductMarketReleaseVersion(ProductInfo prod)
	{
		int num = prod.m_productName.LastIndexOf(" ");
		if (num != -1)
		{
			string text = prod.m_productName.Substring(num + 1).Trim();
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
		}
		return prod.m_productName;
	}

	public StringCollection GetPartialsFromSource()
	{
		StringCollection stringCollection = new StringCollection();
		if (sourceCUI.get_PartialCuiFiles() != null && ((StringCollection)(object)sourceCUI.get_PartialCuiFiles()).Count > 0)
		{
			StringEnumerator enumerator = ((StringCollection)(object)sourceCUI.get_PartialCuiFiles()).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					stringCollection.Add(current);
				}
				return stringCollection;
			}
			finally
			{
				if (enumerator is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
		}
		return stringCollection;
	}

	public void CopyImagesDll()
	{
		if (AutodeskSourceFile)
		{
			return;
		}
		CUIFileMap cUIFileMap = null;
		if (sourceCUI != null && sourceCUI.get_MenuGroup() != null)
		{
			cUIFileMap = MainForm.GetFileMapFromMenuGroup(sourceCUI.get_MenuGroup().get_Name());
		}
		string text = Path.GetDirectoryName(SourceFile) + "\\" + Path.GetFileNameWithoutExtension(SourceFile) + ".dll";
		if (!File.Exists(text))
		{
			return;
		}
		string text2 = Path.GetDirectoryName(TargetFile) + "\\" + Path.GetFileNameWithoutExtension((cUIFileMap == null) ? SourceFile : cUIFileMap.TargetFileName) + ".dll";
		try
		{
			File.Copy(text, text2, overwrite: false);
			string text3 = string.Format(LocalResources.GetString("LOG_FILE_COPY"), text, text2);
			_logger.LogXMLElement((LogOperation)1, (LogCategory)3, text3);
		}
		catch (Exception)
		{
			string text4 = string.Format(LocalResources.GetString("ERROR_FILE_ACCESS_DENIED"), text2);
			_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text4);
		}
	}

	public static void RemoveUnresolvedReferences(CUIFileMigrator main, IList<CUIFileMigrator> partials)
	{
		if (main._sourceInfo.IsRaptor())
		{
			RemoveUnresolvedRibbonTabReferences(main, partials);
		}
	}

	public static void RemoveUnresolvedRibbonTabReferences(CUIFileMigrator main, IList<CUIFileMigrator> partials)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		CustomizationSection val = main.targetCUI;
		foreach (Workspace item in (CollectionBase)(object)val.get_Workspaces())
		{
			Workspace val2 = item;
			IList<WSRibbonTabSourceReference> list = new List<WSRibbonTabSourceReference>();
			foreach (WSRibbonTabSourceReference item2 in (CollectionBase)(object)val2.get_WorkspaceRibbonRoot().get_WorkspaceTabs())
			{
				WSRibbonTabSourceReference val3 = item2;
				bool flag = false;
				if (!(flag = null != val.get_MenuGroup().get_RibbonRoot().FindTab(val3.TabId)))
				{
					foreach (CUIFileMigrator partial in partials)
					{
						CustomizationSection val4 = partial.targetCUI;
						if (val4 != null && val4.get_MenuGroup().get_RibbonRoot().FindTab(val3.TabId) != null)
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					list.Add(val3);
				}
			}
			foreach (WSRibbonTabSourceReference item3 in list)
			{
				val2.get_WorkspaceRibbonRoot().get_WorkspaceTabs().Remove(item3);
			}
		}
		if (val.get_IsModified())
		{
			val.Save();
		}
	}

	internal static void AddSldOrSlbPath(string s, StringCollection sArray)
	{
		if (s == null || s == string.Empty || s.IndexOf(".") == -1)
		{
			return;
		}
		string text = Path.GetExtension(s)!.ToLower();
		if (text != ".sld" && text != ".slb")
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < sArray.Count; i++)
		{
			if (string.Compare(sArray[i], s, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			sArray.Add(s);
		}
	}

	internal void CopySldAndSlbFiles()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		if (targetCUI.get_MenuGroup().get_ImageMenus() == null)
		{
			return;
		}
		StringCollection stringCollection = new StringCollection();
		foreach (ImageMenu item in (CollectionBase)(object)targetCUI.get_MenuGroup().get_ImageMenus())
		{
			ImageMenu val = item;
			foreach (ImageMenuItem item2 in (CollectionBase)(object)val.get_ImageMenuItems())
			{
				ImageMenuItem val2 = item2;
				AddSldOrSlbPath(val2.get_SlideName(), stringCollection);
				AddSldOrSlbPath(val2.get_SlideLibrary(), stringCollection);
			}
		}
		StringEnumerator enumerator3 = stringCollection.GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				string current = enumerator3.Current;
				string text = null;
				string text2 = null;
				if (File.Exists(current))
				{
					continue;
				}
				string text3 = Path.GetDirectoryName(SourceFile) + Path.DirectorySeparatorChar + Path.GetFileName(current);
				if (File.Exists(text3))
				{
					text = text3;
					text2 = Path.GetDirectoryName(TargetFile) + Path.DirectorySeparatorChar + Path.GetFileName(current);
				}
				if (text == null)
				{
					text = Migrator.FindFirstProfileSupportFile(MainForm.isACAD, Path.GetFileName(current), MainForm.CurrentSourceProfilePath);
					text2 = Migrator.GetRoamableRootFolder(MainForm.customizationHostServices.RegProdRootKey) + "Support" + Path.DirectorySeparatorChar + Path.GetFileName(current);
				}
				if (text != null && text2 != null && File.Exists(text))
				{
					try
					{
						File.Copy(text, text2, overwrite: false);
						string text4 = string.Format(LocalResources.GetString("LOG_FILE_COPY"), text, text2);
						_logger.LogXMLElement((LogOperation)1, (LogCategory)3, text4);
					}
					catch (IOException)
					{
						string text5 = string.Format(LocalResources.GetString("ERROR_FILE_ACCESS_DENIED"), text2);
						_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text5);
					}
				}
			}
		}
		finally
		{
			if (enumerator3 is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
	}

	private void LTConvertMenuGroup()
	{
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected O, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected O, but got Unknown
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected O, but got Unknown
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Expected O, but got Unknown
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		if (sourceCUI.get_MenuGroup().get_Accelerators() != null)
		{
			SimpleCloneModifiedItems((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_Accelerators(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_Accelerators());
		}
		if (sourceCUI.get_MenuGroup().get_TemporaryOverrides() != null)
		{
			SimpleCloneModifiedItems((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_TemporaryOverrides(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_TemporaryOverrides());
		}
		if (sourceCUI.get_MenuGroup().get_MouseButtons() != null)
		{
			SimpleCloneModifiedItems((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_MouseButtons(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_MouseButtons());
		}
		if (sourceCUI.get_MenuGroup().get_DigitizerButtons() != null)
		{
			SimpleCloneModifiedItems((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_DigitizerButtons(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_DigitizerButtons());
		}
		if (sourceCUI.get_MenuGroup().get_QuickAccessToolbars() != null)
		{
			GenericMigration((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_QuickAccessToolbars(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_QuickAccessToolbars());
		}
		if (sourceCUI.get_MenuGroup().get_PopMenus() != null)
		{
			foreach (PopMenu item in (CollectionBase)(object)sourceCUI.get_MenuGroup().get_PopMenus())
			{
				PopMenu val = item;
				PopMenu val2 = targetCUI.get_MenuGroup().get_PopMenus().FindPopWithName(val.get_Name());
				if (val2 == null && !LTExcluded(val.get_Name()))
				{
					ContainerCloneAction val3 = (ContainerCloneAction)1;
					targetCUI.get_MenuGroup().get_PopMenus().Clone(val, (PopMenu)null, ref val3);
				}
			}
			foreach (PopMenu item2 in (CollectionBase)(object)sourceCUI.get_MenuGroup().get_PopMenus())
			{
				PopMenu val4 = item2;
				PopMenu val5 = targetCUI.get_MenuGroup().get_PopMenus().FindPopWithName(val4.get_Name());
				if (val5 == null)
				{
					continue;
				}
				foreach (PopMenuItemBase item3 in (CollectionBase)(object)val4.get_PopMenuItems())
				{
					PopMenuItemBase val6 = item3;
					PopMenuItem val7 = (PopMenuItem)(object)((val6 is PopMenuItem) ? val6 : null);
					if (val7 == null || !((VersionableElement)val7).UserModified() || val7.get_IsSeparator())
					{
						continue;
					}
					bool flag = false;
					foreach (PopMenuItemBase item4 in (CollectionBase)(object)val5.get_PopMenuItems())
					{
						PopMenuItemBase val8 = item4;
						PopMenuItem val9 = (PopMenuItem)(object)((val8 is PopMenuItem) ? val8 : null);
						if (val9 != null && !val9.get_IsSeparator() && val7.get_Name().Equals(val9.get_Name(), StringComparison.CurrentCultureIgnoreCase))
						{
							((CustomizationElement)val9).Replace((CustomizationElement)(object)val7);
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						val5.get_PopMenuItems().Insert(val4.get_PopMenuItems().IndexOf((PopMenuItemBase)(object)val7), (PopMenuItemBase)(object)val7);
					}
				}
				foreach (PopMenuItemBase item5 in (CollectionBase)(object)val4.get_PopMenuItems())
				{
					PopMenuItemBase val10 = item5;
					PopMenuRef val11 = (PopMenuRef)(object)((val10 is PopMenuRef) ? val10 : null);
					if (val11 == null || !((VersionableElement)val11).UserModified())
					{
						continue;
					}
					bool flag2 = false;
					PopMenu popMenu = sourceCUI.getPopMenu(val11.get_MenuReference());
					if (popMenu == null)
					{
						continue;
					}
					foreach (PopMenuItemBase item6 in (CollectionBase)(object)val5.get_PopMenuItems())
					{
						PopMenuItemBase val12 = item6;
						PopMenuRef val13 = (PopMenuRef)(object)((val12 is PopMenuRef) ? val12 : null);
						if (val13 != null)
						{
							PopMenu popMenu2 = targetCUI.getPopMenu(val13.get_MenuReference());
							if (popMenu2 != null && popMenu.get_Name().Equals(popMenu2.get_Name(), StringComparison.CurrentCultureIgnoreCase))
							{
								flag2 = true;
							}
						}
					}
					if (!flag2)
					{
						val5.get_PopMenuItems().Insert(val4.get_PopMenuItems().IndexOf((PopMenuItemBase)(object)val11), (PopMenuItemBase)(object)val11);
					}
				}
			}
		}
		if (sourceCUI.get_MenuGroup().get_Toolbars() != null)
		{
			foreach (Toolbar item7 in (CollectionBase)(object)sourceCUI.get_MenuGroup().get_Toolbars())
			{
				Toolbar val14 = item7;
				Toolbar val15 = targetCUI.get_MenuGroup().get_Toolbars().FindToolbarWithName(val14.get_Name());
				if (val15 == null)
				{
					ContainerCloneAction val16 = (ContainerCloneAction)1;
					targetCUI.get_MenuGroup().get_Toolbars().Clone(val14, (Toolbar)null, ref val16);
				}
			}
			foreach (Toolbar item8 in (CollectionBase)(object)sourceCUI.get_MenuGroup().get_Toolbars())
			{
				Toolbar val17 = item8;
				Toolbar val18 = targetCUI.get_MenuGroup().get_Toolbars().FindToolbarWithName(val17.get_Name());
				if (val18 == null)
				{
					continue;
				}
				foreach (ToolbarItemBase item9 in (CollectionBase)(object)val17.get_ToolbarItems())
				{
					ToolbarItemBase val19 = item9;
					ToolbarButton val20 = (ToolbarButton)(object)((val19 is ToolbarButton) ? val19 : null);
					if (val20 == null || !((VersionableElement)val20).UserModified() || val20.get_IsSeparator())
					{
						continue;
					}
					bool flag3 = false;
					foreach (ToolbarItemBase item10 in (CollectionBase)(object)val18.get_ToolbarItems())
					{
						ToolbarItemBase val21 = item10;
						ToolbarButton val22 = (ToolbarButton)(object)((val21 is ToolbarButton) ? val21 : null);
						if (val22 != null && !val22.get_IsSeparator() && val20.get_Name().Equals(val22.get_Name(), StringComparison.CurrentCultureIgnoreCase))
						{
							((CustomizationElement)val22).Replace((CustomizationElement)(object)val20);
							flag3 = true;
							break;
						}
					}
					if (!flag3)
					{
						val18.get_ToolbarItems().Insert(val17.get_ToolbarItems().IndexOf((ToolbarItemBase)(object)val20), (ToolbarItemBase)(object)val20);
					}
				}
				foreach (ToolbarItemBase item11 in (CollectionBase)(object)val17.get_ToolbarItems())
				{
					ToolbarItemBase val23 = item11;
					ToolbarFlyout val24 = (ToolbarFlyout)(object)((val23 is ToolbarFlyout) ? val23 : null);
					if (val24 == null || !((VersionableElement)val24).UserModified())
					{
						continue;
					}
					bool flag4 = false;
					Toolbar toolbar = sourceCUI.getToolbar(val24.get_ToolbarReference());
					if (toolbar == null)
					{
						continue;
					}
					foreach (ToolbarItemBase item12 in (CollectionBase)(object)val18.get_ToolbarItems())
					{
						ToolbarItemBase val25 = item12;
						ToolbarFlyout val26 = (ToolbarFlyout)(object)((val25 is ToolbarFlyout) ? val25 : null);
						if (val26 != null)
						{
							Toolbar toolbar2 = targetCUI.getToolbar(val26.get_ToolbarReference());
							if (toolbar2 != null && toolbar.get_Name().Equals(toolbar2.get_Name(), StringComparison.CurrentCultureIgnoreCase))
							{
								flag4 = true;
							}
						}
					}
					if (!flag4)
					{
						val18.get_ToolbarItems().Insert(val17.get_ToolbarItems().IndexOf((ToolbarItemBase)(object)val24), (ToolbarItemBase)(object)val24);
					}
				}
				foreach (ToolbarItemBase item13 in (CollectionBase)(object)val17.get_ToolbarItems())
				{
					ToolbarItemBase val27 = item13;
					ToolbarControl val28 = (ToolbarControl)(object)((val27 is ToolbarControl) ? val27 : null);
					if (val28 == null)
					{
						continue;
					}
					bool flag5 = false;
					foreach (ToolbarItemBase item14 in (CollectionBase)(object)val18.get_ToolbarItems())
					{
						ToolbarItemBase val29 = item14;
						ToolbarControl val30 = (ToolbarControl)(object)((val29 is ToolbarControl) ? val29 : null);
						if (val30 != null && val28.get_ControlType() == val30.get_ControlType())
						{
							flag5 = true;
						}
					}
					if (!flag5)
					{
						val18.get_ToolbarItems().Insert(val17.get_ToolbarItems().IndexOf((ToolbarItemBase)(object)val28), (ToolbarItemBase)(object)val28);
					}
				}
			}
		}
		if (sourceCUI.get_MenuGroup().get_ScreenMenus() != null)
		{
			GenericMigration((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_ScreenMenus(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_ScreenMenus());
		}
		if (sourceCUI.get_MenuGroup().get_ImageMenus() != null)
		{
			GenericMigration((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_ImageMenus(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_ImageMenus());
		}
		if (sourceCUI.get_MenuGroup().get_DoubleClickActions() != null)
		{
			GenericMigration((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_DoubleClickActions(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_DoubleClickActions());
		}
		if (sourceCUI.get_MenuGroup().get_QuickPropertiesObjectTypes() != null)
		{
			GenericObjectTypes((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_QuickPropertiesObjectTypes(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_QuickPropertiesObjectTypes());
		}
		if (sourceCUI.get_MenuGroup().get_RolloverTooltipObjectTypes() != null)
		{
			GenericObjectTypes((MenuGroupItemsCollection)(object)sourceCUI.get_MenuGroup().get_RolloverTooltipObjectTypes(), (MenuGroupItemsCollection)(object)targetCUI.get_MenuGroup().get_RolloverTooltipObjectTypes());
		}
	}

	private bool LTExcluded(string menuName)
	{
		if (!menuName.Equals("Block Objects Menu", StringComparison.CurrentCultureIgnoreCase) && !menuName.Equals("&Viewports", StringComparison.CurrentCultureIgnoreCase) && !menuName.Equals("&Layout", StringComparison.CurrentCultureIgnoreCase) && !menuName.Equals("Ne&w UCS", StringComparison.CurrentCultureIgnoreCase) && !menuName.Equals("Unmaximized Viewport Menu", StringComparison.CurrentCultureIgnoreCase) && !menuName.Equals("L&ayer tools", StringComparison.CurrentCultureIgnoreCase))
		{
			return false;
		}
		return true;
	}

	private void SimpleCloneModifiedItems(MenuGroupItemsCollection smgCollection, MenuGroupItemsCollection tmgCollection)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		foreach (CustomizationElement item in (CollectionBase)(object)smgCollection)
		{
			CustomizationElement val = item;
			if (((VersionableElement)val).UserModified())
			{
				ContainerCloneAction val2 = (ContainerCloneAction)1;
				tmgCollection.Clone(val, (CustomizationElement)null, ref val2);
			}
		}
	}

	internal void setParentCUIFile(CUIFileMigrator parent)
	{
		if (parent != null && parent.targetCUI != null && targetCUI != null)
		{
			targetCUI.set_ParentCUI(parent.targetCUI);
		}
	}
}
