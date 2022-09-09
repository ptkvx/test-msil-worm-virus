using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace hpCasl.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
[CompilerGenerated]
internal sealed class MultiIcon : ApplicationSettingsBase
{
	private static MultiIcon defaultInstance = (MultiIcon)(object)SettingsBase.Synchronized((SettingsBase)(object)new MultiIcon());

	public static MultiIcon Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("176")]
	public int Width => (int)((SettingsBase)this).get_Item("Width");

	[DefaultSettingValue("64")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public int Height => (int)((SettingsBase)this).get_Item("Height");

	[DebuggerNonUserCode]
	[DefaultSettingValue("8")]
	[ApplicationScopedSetting]
	public int Margin => (int)((SettingsBase)this).get_Item("Margin");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("32, 16")]
	public Point IconLocation => (Point)((SettingsBase)this).get_Item("IconLocation");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("148, 4")]
	public Point CloseButtonLocation => (Point)((SettingsBase)this).get_Item("CloseButtonLocation");

	[DefaultSettingValue("1000")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public int OpacityFadeSpeed => (int)((SettingsBase)this).get_Item("OpacityFadeSpeed");

	[ApplicationScopedSetting]
	[DefaultSettingValue("5")]
	[DebuggerNonUserCode]
	public int OpacityStepPercent => (int)((SettingsBase)this).get_Item("OpacityStepPercent");

	[DefaultSettingValue("90")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public int OpacityNormalPercent => (int)((SettingsBase)this).get_Item("OpacityNormalPercent");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("100")]
	public int OpacityHoverPercent => (int)((SettingsBase)this).get_Item("OpacityHoverPercent");

	[DebuggerNonUserCode]
	[DefaultSettingValue("8")]
	[ApplicationScopedSetting]
	public int MoveDivisor => (int)((SettingsBase)this).get_Item("MoveDivisor");

	[DefaultSettingValue("30")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public int MoveDuration => (int)((SettingsBase)this).get_Item("MoveDuration");

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool EnablePopUpEffect => (bool)((SettingsBase)this).get_Item("EnablePopUpEffect");

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[ApplicationScopedSetting]
	public string BackgroundImage => (string)((SettingsBase)this).get_Item("BackgroundImage");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("")]
	public string CloseIcon => (string)((SettingsBase)this).get_Item("CloseIcon");

	[ApplicationScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string CloseHoverIcon => (string)((SettingsBase)this).get_Item("CloseHoverIcon");

	[DefaultSettingValue("")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public string CloseClickedIcon => (string)((SettingsBase)this).get_Item("CloseClickedIcon");

	[DefaultSettingValue("40")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public int IconSpacing => (int)((SettingsBase)this).get_Item("IconSpacing");
}
