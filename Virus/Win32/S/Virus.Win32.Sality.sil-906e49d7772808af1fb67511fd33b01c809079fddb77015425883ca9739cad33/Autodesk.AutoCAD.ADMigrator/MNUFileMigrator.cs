using System;
using System.Globalization;
using System.IO;
using Autodesk.AutoCAD.CustomMigrator;
using Autodesk.AutoCAD.Customization;

namespace Autodesk.AutoCAD.ADMigrator;

public class MNUFileMigrator
{
	public static ILogXML _logger;

	private string _originalSourceMNUPath;

	private string _targetCUIPath;

	private string _sourceMNUPath;

	private bool _loadTarget;

	private CustomizationSection _convertedCUI;

	public bool LoadTarget => _loadTarget;

	public string OriginalSource => _originalSourceMNUPath;

	public CustomizationSection ConvertedCUI => _convertedCUI;

	public string TargetCUIPath => _targetCUIPath;

	public MNUFileMigrator(string source, ILogXML mainFormLogger)
	{
		string text = Path.GetDirectoryName(source) + "\\" + Path.GetFileNameWithoutExtension(source) + CustomizationSection.EXTENSION_SOURCE;
		_logger = mainFormLogger;
		if (!File.Exists(text))
		{
			text = Path.ChangeExtension(text, CustomizationSection.EXTENSION_TEMPLATE);
		}
		if (File.Exists(text))
		{
			_originalSourceMNUPath = text;
		}
	}

	public bool ConvertToCUIx(ProfileMigrator pm, string targetRootKey, bool mainMNS)
	{
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_0218: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_02c9: Expected O, but got Unknown
		if (_originalSourceMNUPath != null && _originalSourceMNUPath.Length >= 1)
		{
			string text = Migrator.GetRoamableRootFolder(targetRootKey) + "Previous Version Custom Files\\";
			string text2 = text + Path.GetFileName(_originalSourceMNUPath);
			try
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.Copy(_originalSourceMNUPath, text2, overwrite: true);
				if ((File.GetAttributes(text2) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					File.SetAttributes(text2, File.GetAttributes(text2) ^ FileAttributes.ReadOnly);
				}
				_sourceMNUPath = text2;
			}
			catch (Exception)
			{
				string text3 = string.Format(LocalResources.GetString("ERROR_FILE_ACCESS_DENIED"), text2);
				MainForm.Log2File(text3);
				_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text3);
				return false;
			}
			string text4 = pm.SourceEncode(_originalSourceMNUPath);
			string text5 = pm.TargetExpand(text4);
			if (mainMNS)
			{
				_targetCUIPath = Path.GetDirectoryName(text5) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(text5) + LocalResources.GetString("MIGRATED_FILE_SUFFIX") + CustomizationSection.EXTENSION_OPC;
			}
			else
			{
				_targetCUIPath = Path.ChangeExtension(text5, CustomizationSection.EXTENSION_OPC);
			}
			if (string.Compare(_originalSourceMNUPath, text5, ignoreCase: true, CultureInfo.InvariantCulture) != 0)
			{
				try
				{
					CustomizationSection val = new CustomizationSection(_sourceMNUPath, true, false);
					if (!Directory.Exists(Path.GetDirectoryName(_targetCUIPath)))
					{
						Directory.CreateDirectory(Path.GetDirectoryName(_targetCUIPath));
					}
					if (File.Exists(_targetCUIPath))
					{
						string text6 = string.Format(LocalResources.GetString("LOG_FILE_ALREADY_EXISTS"), _targetCUIPath);
						_logger.LogXMLElement((LogOperation)1, (LogCategory)3, text6);
						_convertedCUI = val;
						_loadTarget = true;
					}
					else
					{
						val.SaveAs(_targetCUIPath);
						_convertedCUI = new CustomizationSection(_targetCUIPath, true, false);
						_loadTarget = true;
					}
				}
				catch (FileNotFoundException)
				{
					string text7 = string.Format(LocalResources.GetString("ERROR_CUI_FILE_NOT_FOUND"), _targetCUIPath);
					MainForm.Log2File(text7);
					_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text7);
					return false;
				}
				catch (FileSaveException val2)
				{
					FileSaveException val3 = val2;
					MainForm.Log2File(((Exception)(object)val3).Message);
					_logger.LogXMLElement((LogOperation)1, (LogCategory)0, ((Exception)(object)val3).Message);
					return false;
				}
				catch (Exception ex3)
				{
					MainForm.Log2File(ex3.Message);
					_logger.LogXMLElement((LogOperation)1, (LogCategory)0, ex3.Message);
					return false;
				}
			}
			else
			{
				try
				{
					_convertedCUI = new CustomizationSection(_originalSourceMNUPath, true, false);
					_targetCUIPath = _convertedCUI.get_CUIFileName();
					_loadTarget = true;
				}
				catch (FileNotFoundException)
				{
					string text8 = string.Format(LocalResources.GetString("ERROR_CUI_FILE_NOT_FOUND"), _originalSourceMNUPath);
					MainForm.Log2File(text8);
					_logger.LogXMLElement((LogOperation)1, (LogCategory)0, text8);
					return false;
				}
				catch (FileSaveException val4)
				{
					FileSaveException val5 = val4;
					MainForm.Log2File(((Exception)(object)val5).Message);
					_logger.LogXMLElement((LogOperation)1, (LogCategory)0, ((Exception)(object)val5).Message);
					return false;
				}
			}
			return true;
		}
		return false;
	}
}
