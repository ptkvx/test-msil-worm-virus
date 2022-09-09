using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;
using ns13;

namespace ns11;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
[CompilerGenerated]
internal sealed class Class31 : ApplicationSettingsBase
{
	private static Class31 class31_0;

	public static Class31 Class31_0 => class31_0;

	public Class31()
	{
		Class33.smethod_0();
		((ApplicationSettingsBase)this)._002Ector();
	}

	static Class31()
	{
		Class33.smethod_0();
		class31_0 = (Class31)(object)SettingsBase.Synchronized((SettingsBase)(object)new Class31());
	}
}
