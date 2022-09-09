using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Autodesk.AutoCAD.CustomMigrator;
using Autodesk.AutoCAD.Customization;
using Microsoft.Win32;

namespace Autodesk.AutoCAD.ADMigrator;

public class CustomizationHostServices : IHostServices
{
	private string _regProdRootKey;

	private string _enterpriseCUI;

	private string _mainCUI;

	internal string RegProdRootKey
	{
		get
		{
			return _regProdRootKey;
		}
		set
		{
			_regProdRootKey = value;
		}
	}

	internal string EnterpriseCuiFile
	{
		get
		{
			return _enterpriseCUI;
		}
		set
		{
			_enterpriseCUI = value;
		}
	}

	internal string MainCuiFile
	{
		get
		{
			return _mainCUI;
		}
		set
		{
			_mainCUI = value;
		}
	}

	public string GetDieselEvalString(string dieselExpression)
	{
		return dieselExpression;
	}

	public string RegistryProductRootKey()
	{
		return RegProdRootKey;
	}

	public void DisplayMessage(string message, string title)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(message, title);
	}

	public void WriteMessage(string message)
	{
		MainForm.Log2File(message);
	}

	public int QueryMode()
	{
		return 0;
	}

	public bool IsOEM()
	{
		return false;
	}

	public string FindFile(string fileName)
	{
		string text = null;
		string text2 = (MainForm.isTarget ? MainForm.CurrentTargetProfilePath : MainForm.CurrentSourceProfilePath);
		try
		{
			text = ((text2 == null) ? Migrator.FindFirstDefaultSupportFile(MainForm.isACAD, fileName, RegProdRootKey) : Migrator.FindFirstProfileSupportFile(MainForm.isACAD, fileName, text2));
			if (string.IsNullOrEmpty(text))
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Migrator.StripWOWFromCURegKey(text2) + "\\General Configuration");
				string text3 = registryKey.GetValue("IconFilePath") as string;
				registryKey.Close();
				if (string.IsNullOrEmpty(text3) && MainForm._theForm._Migrator.get_SourceProdInfo() != null)
				{
					string text4 = (MainForm.isTarget ? MainForm._theForm.ProductRegistryRootKey : MainForm._theForm._Migrator.get_SourceProdInfo().m_regRootKey);
					string roamableRootFolder = Migrator.GetRoamableRootFolder(text4);
					text3 = Path.Combine(roamableRootFolder, "support\\icons");
				}
				if (!string.IsNullOrEmpty(text3))
				{
					string text5 = Path.Combine(text3, fileName);
					if (File.Exists(text5))
					{
						text = text5;
						return text;
					}
					return text;
				}
				return text;
			}
			return text;
		}
		catch (Exception)
		{
			return text;
		}
	}

	public CustomizationSection EnterpriseCUIFile()
	{
		return null;
	}

	public CustomizationSection MainCUIFile()
	{
		return null;
	}

	public void InsertMenuOnMenuBar(string menuGroupName, string alias)
	{
	}

	public ArrayList GetLoadedMenuGroupNames()
	{
		return new ArrayList();
	}

	public void GeneratePropertyCollection(ObjectType ot)
	{
	}

	public Bitmap GetCachedImage(string imageId, bool return_null)
	{
		return null;
	}
}
