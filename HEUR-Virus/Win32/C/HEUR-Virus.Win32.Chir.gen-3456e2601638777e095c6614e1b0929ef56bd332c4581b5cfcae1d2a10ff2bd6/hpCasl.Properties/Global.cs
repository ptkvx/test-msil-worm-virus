using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace hpCasl.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
internal sealed class Global : ApplicationSettingsBase
{
	private static Global defaultInstance = (Global)(object)SettingsBase.Synchronized((SettingsBase)(object)new Global());

	public static Global Default => defaultInstance;

	[ApplicationScopedSetting]
	[DefaultSettingValue("51, 51, 51")]
	[DebuggerNonUserCode]
	public Color BackgroundTopColor => (Color)((SettingsBase)this).get_Item("BackgroundTopColor");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("Black")]
	public Color BackgroundBottomColor => (Color)((SettingsBase)this).get_Item("BackgroundBottomColor");

	[ApplicationScopedSetting]
	[DefaultSettingValue("0, 124, 199")]
	[DebuggerNonUserCode]
	public Color BackgroundHoverColor => (Color)((SettingsBase)this).get_Item("BackgroundHoverColor");

	[DefaultSettingValue("0, 80, 172")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public Color BackgroundTopClickedColor => (Color)((SettingsBase)this).get_Item("BackgroundTopClickedColor");

	[ApplicationScopedSetting]
	[DefaultSettingValue("4, 27, 53")]
	[DebuggerNonUserCode]
	public Color BackgroundBottomClickedColor => (Color)((SettingsBase)this).get_Item("BackgroundBottomClickedColor");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("63, 255, 255, 255")]
	public Color HighlightColor => (Color)((SettingsBase)this).get_Item("HighlightColor");

	[DebuggerNonUserCode]
	[DefaultSettingValue("69, 69, 69")]
	[ApplicationScopedSetting]
	public Color BackgroundBevelHighlightColor => (Color)((SettingsBase)this).get_Item("BackgroundBevelHighlightColor");

	[DefaultSettingValue("34, 34, 34")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public Color BackgroundBevelShadowColor => (Color)((SettingsBase)this).get_Item("BackgroundBevelShadowColor");

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("128, 255, 255, 255")]
	public Color BackgroundBorderColor => (Color)((SettingsBase)this).get_Item("BackgroundBorderColor");

	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	[ApplicationScopedSetting]
	public bool EnableHighlight => (bool)((SettingsBase)this).get_Item("EnableHighlight");
}
