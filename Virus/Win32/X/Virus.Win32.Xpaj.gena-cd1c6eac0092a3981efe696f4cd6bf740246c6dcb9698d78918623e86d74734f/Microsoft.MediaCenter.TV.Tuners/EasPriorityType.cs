namespace Microsoft.MediaCenter.TV.Tuners;

public enum EasPriorityType
{
	Maximum_priority = 5,
	Process_unconditionally = 4,
	Disregard_if_viewing_pay_per_view = 3,
	Disregard_if_viewing_access_controlled = 2,
	Priority_Unknown = 1,
	TestMessage = 0
}
