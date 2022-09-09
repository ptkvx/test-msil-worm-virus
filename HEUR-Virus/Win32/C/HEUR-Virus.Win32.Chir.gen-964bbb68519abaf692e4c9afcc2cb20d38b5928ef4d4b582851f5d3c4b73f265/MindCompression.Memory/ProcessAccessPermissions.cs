using System;

namespace MindCompression.Memory;

[Flags]
internal enum ProcessAccessPermissions
{
	Terminate = 1,
	CreateThread = 2,
	SetSessionId = 4,
	VmOperation = 8,
	VmRead = 0x10,
	VmWrite = 0x20,
	DuplicateHandle = 0x40,
	CreateProcess = 0x80,
	SetQuota = 0x100,
	SetInformation = 0x200,
	QueryInformation = 0x400
}
