using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Autodesk.AutoCAD.ADMigrator.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string ImportInitialDirectory
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("ImportInitialDirectory");
		}
		set
		{
			((SettingsBase)this).set_Item("ImportInitialDirectory", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string ExportInitialDirectory
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("ExportInitialDirectory");
		}
		set
		{
			((SettingsBase)this).set_Item("ExportInitialDirectory", (object)value);
		}
	}

	private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
	{
	}

	private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
	{
	}
}
