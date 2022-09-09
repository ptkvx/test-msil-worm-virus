using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace W3DR.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
internal class A
{
	private static ResourceManager m_A;

	private static CultureInfo m_A;

	internal A()
	{
	}

	[SpecialName]
	internal static ResourceManager A()
	{
		if (object.ReferenceEquals(W3DR.Properties.A.m_A, null))
		{
			ResourceManager resourceManager = (W3DR.Properties.A.m_A = new ResourceManager("W3DR.Properties.Resources", typeof(A).Assembly));
		}
		return W3DR.Properties.A.m_A;
	}

	[SpecialName]
	internal static CultureInfo A()
	{
		return W3DR.Properties.A.m_A;
	}

	[SpecialName]
	internal static void A(CultureInfo cultureInfo_0)
	{
		W3DR.Properties.A.m_A = cultureInfo_0;
	}

	[SpecialName]
	internal static Icon A()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = W3DR.Properties.A.A().GetObject("icon", W3DR.Properties.A.m_A);
		return (Icon)@object;
	}
}
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
internal sealed class a : ApplicationSettingsBase
{
	private static a m_A = (a)(object)SettingsBase.Synchronized((SettingsBase)(object)new a());

	public static a Default => a.m_A;

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string language
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("language");
		}
		set
		{
			((SettingsBase)this).set_Item("language", (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public long lastCheck
	{
		get
		{
			return (long)((SettingsBase)this).get_Item("lastCheck");
		}
		set
		{
			((SettingsBase)this).set_Item("lastCheck", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("80")]
	public uint delay
	{
		get
		{
			return (uint)((SettingsBase)this).get_Item("delay");
		}
		set
		{
			((SettingsBase)this).set_Item("delay", (object)value);
		}
	}

	private void A(object sender, SettingChangingEventArgs e)
	{
	}

	private void A(object sender, CancelEventArgs e)
	{
	}
}
