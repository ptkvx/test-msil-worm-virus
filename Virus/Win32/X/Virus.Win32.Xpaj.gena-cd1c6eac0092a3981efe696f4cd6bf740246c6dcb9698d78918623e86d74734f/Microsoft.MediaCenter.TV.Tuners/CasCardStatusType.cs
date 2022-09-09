namespace Microsoft.MediaCenter.TV.Tuners;

public enum CasCardStatusType
{
	CasCardStatusUnknown = 5,
	CasCardFirmwareDownload = 4,
	CasCardDataChanged = 3,
	CasCardError = 2,
	CasCardRemoved = 1,
	CasCardInserted = 0
}
