using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace hpCasl.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
[CompilerGenerated]
internal sealed class Toast : ApplicationSettingsBase
{
	private static Toast defaultInstance = (Toast)(object)SettingsBase.Synchronized((SettingsBase)(object)new Toast());

	public static Toast Default => defaultInstance;

	[DefaultSettingValue("250")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public int Width => (int)((SettingsBase)this).get_Item("Width");

	[ApplicationScopedSetting]
	[DefaultSettingValue("96")]
	[DebuggerNonUserCode]
	public int Height => (int)((SettingsBase)this).get_Item("Height");

	[DefaultSettingValue("8")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public int Margin => (int)((SettingsBase)this).get_Item("Margin");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("Arial")]
	public string TitleFontName => (string)((SettingsBase)this).get_Item("TitleFontName");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("13")]
	public int TitleFontSize => (int)((SettingsBase)this).get_Item("TitleFontSize");

	[ApplicationScopedSetting]
	[DefaultSettingValue("Regular")]
	[DebuggerNonUserCode]
	public FontStyle TitleFontStyle => (FontStyle)((SettingsBase)this).get_Item("TitleFontStyle");

	[DefaultSettingValue("White")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public Color TitleColor => (Color)((SettingsBase)this).get_Item("TitleColor");

	[DebuggerNonUserCode]
	[DefaultSettingValue("48, 8, 170, 32")]
	[ApplicationScopedSetting]
	public Rectangle TitleRect => (Rectangle)((SettingsBase)this).get_Item("TitleRect");

	[DebuggerNonUserCode]
	[DefaultSettingValue("Arial")]
	[ApplicationScopedSetting]
	public string TextFontName => (string)((SettingsBase)this).get_Item("TextFontName");

	[DefaultSettingValue("Regular")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public FontStyle TextFontStyle => (FontStyle)((SettingsBase)this).get_Item("TextFontStyle");

	[DefaultSettingValue("White")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public Color TextColor => (Color)((SettingsBase)this).get_Item("TextColor");

	[ApplicationScopedSetting]
	[DefaultSettingValue("48, 40, 194, 50")]
	[DebuggerNonUserCode]
	public Rectangle TextRect => (Rectangle)((SettingsBase)this).get_Item("TextRect");

	[ApplicationScopedSetting]
	[DefaultSettingValue("8, 28")]
	[DebuggerNonUserCode]
	public Point IconLocation => (Point)((SettingsBase)this).get_Item("IconLocation");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("222, 4")]
	public Point CloseButtonLocation => (Point)((SettingsBase)this).get_Item("CloseButtonLocation");

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int OpacityFadeSpeed => (int)((SettingsBase)this).get_Item("OpacityFadeSpeed");

	[DefaultSettingValue("5")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public int OpacityStepPercent => (int)((SettingsBase)this).get_Item("OpacityStepPercent");

	[DefaultSettingValue("100")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public int OpacityHoverPercent => (int)((SettingsBase)this).get_Item("OpacityHoverPercent");

	[DefaultSettingValue("8")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public int MoveDivisor => (int)((SettingsBase)this).get_Item("MoveDivisor");

	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	[ApplicationScopedSetting]
	public int MoveDuration => (int)((SettingsBase)this).get_Item("MoveDuration");

	[ApplicationScopedSetting]
	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	public bool EnablePopUpEffect => (bool)((SettingsBase)this).get_Item("EnablePopUpEffect");

	[ApplicationScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string BackgroundImage => (string)((SettingsBase)this).get_Item("BackgroundImage");

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[ApplicationScopedSetting]
	public string CloseIcon => (string)((SettingsBase)this).get_Item("CloseIcon");

	[DefaultSettingValue("")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public string CloseHoverIcon => (string)((SettingsBase)this).get_Item("CloseHoverIcon");

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[ApplicationScopedSetting]
	public string CloseClickedIcon => (string)((SettingsBase)this).get_Item("CloseClickedIcon");

	[DebuggerNonUserCode]
	[DefaultSettingValue("11")]
	[ApplicationScopedSetting]
	public int TextFontSize => (int)((SettingsBase)this).get_Item("TextFontSize");

	[DebuggerNonUserCode]
	[DefaultSettingValue("90")]
	[ApplicationScopedSetting]
	public int OpacityNormalPercent => (int)((SettingsBase)this).get_Item("OpacityNormalPercent");
}
