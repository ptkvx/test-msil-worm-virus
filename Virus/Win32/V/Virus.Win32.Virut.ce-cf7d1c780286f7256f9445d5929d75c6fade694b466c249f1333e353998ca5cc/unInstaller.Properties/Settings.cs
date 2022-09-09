using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace unInstaller.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[DefaultSettingValue("http://urdrive.fuhu.org/webservices/set-uninstall?apikey=37ed9e04-8a52-4464-8f78-7d7b0e88ea57")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public string UnInstallV2_URL => (string)((SettingsBase)this).get_Item("UnInstallV2_URL");
}
