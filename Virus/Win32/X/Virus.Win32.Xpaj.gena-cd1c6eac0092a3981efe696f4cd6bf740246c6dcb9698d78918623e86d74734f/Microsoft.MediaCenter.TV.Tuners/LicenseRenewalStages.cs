namespace Microsoft.MediaCenter.TV.Tuners;

public enum LicenseRenewalStages
{
	LRE_RenewalStage_RenewalSuccessful = 5,
	LRE_RenewalStage_StoreLicenseInDRM = 4,
	LRE_RenewalStage_RenewLicenseAtTuner = 3,
	LRE_RenewalStage_CheckForRenewableLicense = 2,
	LRE_RenewalStage_RenewalFailed = 1,
	LRE_RenewalStage_Invalid = 0
}
