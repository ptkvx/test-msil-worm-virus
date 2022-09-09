namespace Microsoft.MediaCenter.TV.Tuners;

public enum DrmPairingStatus
{
	DrmPairing_NeedSDKUpdate = 9,
	DrmPairing_Aborted = 8,
	DrmPairing_DrmRePairSoon = 7,
	DrmPairing_DrmNotPaired = 6,
	DrmPairing_DrmInitFailed = 5,
	DrmPairing_Other = 4,
	DrmPairing_NeedIndiv = 3,
	DrmPairing_NeedRevocationData = 2,
	DrmPairing_HardwareFailure = 1,
	DrmPairing_Succeeded = 0
}
