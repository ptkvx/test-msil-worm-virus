using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.VSHelp80;

namespace ASInstanceRename;

internal class DialogHelp
{
	private delegate void DoShowHelpEventHandler(Help2 dexplorer, string helpKeyword);

	private const string defaultSqlHelpCollection = "ms-help://MS.SQLCC.v9";

	private static Help2 dexploreAppObjClass;

	private static Help2 DexploreAppObjClass
	{
		get
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			if (dexploreAppObjClass == null)
			{
				Type typeFromCLSID = Type.GetTypeFromCLSID(new Guid("{639F725F-1B2D-4831-A9FD-874847682010}"));
				if ((object)typeFromCLSID != null)
				{
					object obj = Activator.CreateInstance(typeFromCLSID);
					dexploreAppObjClass = (Help2)obj;
				}
			}
			return dexploreAppObjClass;
		}
	}

	public static void ShowHelp(string helpKeyword)
	{
		ShowHelp(null, helpKeyword, null, null);
	}

	public static void ShowHelp(Control activeControl, string helpKeyword)
	{
		ShowHelp(activeControl, helpKeyword, null, null);
	}

	public static void ShowHelp(Control activeControl, string helpKeyword, string helpCollection, string helpFilter)
	{
		if (DexploreAppObjClass != null)
		{
			if (helpCollection == null)
			{
				helpCollection = "ms-help://MS.SQLCC.v9";
			}
			if (DexploreAppObjClass.get_Collection() != helpCollection)
			{
				DexploreAppObjClass.SetCollection(helpCollection, helpFilter);
			}
			else if (DexploreAppObjClass.get_Filter() != helpFilter)
			{
				DexploreAppObjClass.set_Filter(helpFilter);
			}
			if (activeControl != null && activeControl.get_InvokeRequired())
			{
				activeControl.BeginInvoke((Delegate)new DoShowHelpEventHandler(DoShowHelp), new object[2] { DexploreAppObjClass, helpKeyword });
			}
			else
			{
				DoShowHelp(DexploreAppObjClass, helpKeyword);
			}
		}
	}

	public void ShowHelp(string helpKeyword, string helpCollection, string helpFilter)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		Type typeFromCLSID = Type.GetTypeFromCLSID(new Guid("{639F725F-1B2D-4831-A9FD-874847682010}"));
		object obj = Activator.CreateInstance(typeFromCLSID);
		Help2 val = (Help2)obj;
		if (helpCollection == null)
		{
			helpCollection = "ms-help://MS.SQLCC.v9";
		}
		if (val.get_Collection() != helpCollection)
		{
			val.SetCollection(helpCollection, helpFilter);
		}
		else if (val.get_Filter() != helpFilter)
		{
			val.set_Filter(helpFilter);
		}
		DoShowHelp(val, helpKeyword);
	}

	private static void DoShowHelp(Help2 dexplorer, string helpKeyword)
	{
		dexplorer.DisplayTopicFromF1Keyword(helpKeyword);
	}
}
