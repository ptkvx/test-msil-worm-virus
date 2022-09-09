namespace Microsoft.MediaCenter.TV.Tuners;

public enum MMICloseReasonType
{
	MMIError = 4,
	MMIDeviceRequestedClose = 3,
	MMISystemClose = 2,
	MMIUserClose = 1,
	MMINotReady = 0
}
