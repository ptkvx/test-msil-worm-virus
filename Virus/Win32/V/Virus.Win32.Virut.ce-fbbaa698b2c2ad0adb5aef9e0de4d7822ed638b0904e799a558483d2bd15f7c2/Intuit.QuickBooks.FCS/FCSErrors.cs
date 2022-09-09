namespace Intuit.QuickBooks.FCS;

public enum FCSErrors
{
	Operation_Success = 0,
	AuthFile_Invalid = 1,
	AuthFile_NotFound = 2,
	AuthFile_NotSigned = 3,
	AuthFile_NotRegistered = 4,
	File_NotFound = 10,
	File_NotAuthorized = 11,
	File_InvalidDigest = 12,
	File_FullPathRequired = 13,
	File_NamedPipesNotSupported = 14,
	File_IsaDirectory = 15,
	File_NoWritePermission = 16,
	Tx_Timeout = 20,
	Tx_AbortedByServer = 21,
	Tx_InRecovery = 22,
	Tx_AbortedByClient = 23,
	Tx_BusyInOtherTx = 24,
	DestDir_Offlimit = 30,
	DestFile_InUse = 31,
	DestFile_NoWritePermission = 32,
	DestFile_FullPathRequired = 33,
	DestFile_ExistsWithNoOverwrite = 34,
	NetError_General = 2100,
	NetError_NetNameNotFound = 2310,
	NetError_ShareTypeNotSupported = 2311,
	NetError_Access_Denied = 5,
	NetError_InvalidParameter = 87
}
