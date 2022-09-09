using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class Class2 : ApplicationSettingsBase
{
	private static Class2 class2_0 = (Class2)(object)SettingsBase.Synchronized((SettingsBase)(object)new Class2());

	private static bool bool_0;

	private static object object_0 = RuntimeHelpers.GetObjectValue(new object());

	public static Class2 Class2_0
	{
		get
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			if (!bool_0)
			{
				object obj = object_0;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				Monitor.Enter(obj);
				try
				{
					if (!bool_0)
					{
						((WindowsFormsApplicationBase)Class3.Form0_0).add_Shutdown((ShutdownEventHandler)delegate
						{
							if (((WindowsFormsApplicationBase)Class3.Form0_0).get_SaveMySettingsOnExit())
							{
								((ApplicationSettingsBase)Class1.Class2_0).Save();
							}
						});
						bool_0 = true;
					}
				}
				finally
				{
					Monitor.Exit(obj);
				}
			}
			return class2_0;
		}
	}

	[DebuggerNonUserCode]
	public Class2()
	{
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void smethod_0(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)Class3.Form0_0).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)Class1.Class2_0).Save();
		}
	}
}
