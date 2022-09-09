using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace hpCasl.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
internal sealed class ProgressBar : ApplicationSettingsBase
{
	private static ProgressBar defaultInstance = (ProgressBar)(object)SettingsBase.Synchronized((SettingsBase)(object)new ProgressBar());

	public static ProgressBar Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("300")]
	public int Width => (int)((SettingsBase)this).get_Item("Width");

	[DefaultSettingValue("48")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public int Height => (int)((SettingsBase)this).get_Item("Height");

	[DebuggerNonUserCode]
	[DefaultSettingValue("8, 8")]
	[ApplicationScopedSetting]
	public Point LeftIconLocation => (Point)((SettingsBase)this).get_Item("LeftIconLocation");

	[ApplicationScopedSetting]
	[DefaultSettingValue("260, 8")]
	[DebuggerNonUserCode]
	public Point RightIconLocation => (Point)((SettingsBase)this).get_Item("RightIconLocation");

	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	[ApplicationScopedSetting]
	public int BottomMargin => (int)((SettingsBase)this).get_Item("BottomMargin");

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("48, 8, 203, 31")]
	public Rectangle BarRectangle => (Rectangle)((SettingsBase)this).get_Item("BarRectangle");

	[DefaultSettingValue("500")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public int OpacityFadeSpeed => (int)((SettingsBase)this).get_Item("OpacityFadeSpeed");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("5")]
	public int OpacityStepPercent => (int)((SettingsBase)this).get_Item("OpacityStepPercent");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("90")]
	public int OpacityNormalPercent => (int)((SettingsBase)this).get_Item("OpacityNormalPercent");

	[DefaultSettingValue("100")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public int OpacityHoverPercent => (int)((SettingsBase)this).get_Item("OpacityHoverPercent");

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("8")]
	public int MoveDivisor => (int)((SettingsBase)this).get_Item("MoveDivisor");

	[ApplicationScopedSetting]
	[DefaultSettingValue("30")]
	[DebuggerNonUserCode]
	public int MoveDuration => (int)((SettingsBase)this).get_Item("MoveDuration");

	[DefaultSettingValue("2")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public int BarMargin => (int)((SettingsBase)this).get_Item("BarMargin");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("128, 255, 255, 255")]
	public Color BarBorderColor => (Color)((SettingsBase)this).get_Item("BarBorderColor");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("")]
	public string BackgroundImage => (string)((SettingsBase)this).get_Item("BackgroundImage");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("True")]
	public bool EnablePopUpEffect => (bool)((SettingsBase)this).get_Item("EnablePopUpEffect");

	[ApplicationScopedSetting]
	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	public bool EnablePopDownEffect => (bool)((SettingsBase)this).get_Item("EnablePopDownEffect");

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public uint BarSegments => (uint)((SettingsBase)this).get_Item("BarSegments");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("Black")]
	public Color BarBackgroundColor => (Color)((SettingsBase)this).get_Item("BarBackgroundColor");

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("35, 125, 197")]
	public Color BarColor => (Color)((SettingsBase)this).get_Item("BarColor");

	[ApplicationScopedSetting]
	[DefaultSettingValue("3, 54, 118")]
	[DebuggerNonUserCode]
	public Color BarCapStartColor => (Color)((SettingsBase)this).get_Item("BarCapStartColor");

	[DebuggerNonUserCode]
	[DefaultSettingValue("0, 35, 125, 197")]
	[ApplicationScopedSetting]
	public Color BarCapEndColor => (Color)((SettingsBase)this).get_Item("BarCapEndColor");

	[DebuggerNonUserCode]
	[DefaultSettingValue("164, 220, 255")]
	[ApplicationScopedSetting]
	public Color BarGlowColor => (Color)((SettingsBase)this).get_Item("BarGlowColor");

	[DebuggerNonUserCode]
	[DefaultSettingValue("132, 188, 255")]
	[ApplicationScopedSetting]
	public Color BarGlowAccentColor => (Color)((SettingsBase)this).get_Item("BarGlowAccentColor");

	[ApplicationScopedSetting]
	[DefaultSettingValue("14, 86, 176")]
	[DebuggerNonUserCode]
	public Color BarCapEndGlowColor => (Color)((SettingsBase)this).get_Item("BarCapEndGlowColor");
}
