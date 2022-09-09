namespace System.Diagnostics.Eventing.Reader;

internal class EventLogPermissionHolder
{
	public static EventLogPermission GetEventLogPermission()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		EventLogPermission val = new EventLogPermission();
		EventLogPermissionEntry val2 = new EventLogPermissionEntry((EventLogPermissionAccess)48, ".");
		val.get_PermissionEntries().Add(val2);
		return val;
	}
}
