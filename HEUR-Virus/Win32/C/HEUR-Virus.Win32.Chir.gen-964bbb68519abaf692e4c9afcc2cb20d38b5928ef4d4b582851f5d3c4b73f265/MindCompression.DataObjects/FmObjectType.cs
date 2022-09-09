using System;

namespace MindCompression.DataObjects;

[Flags]
public enum FmObjectType
{
	Country = 1,
	City = 2,
	Club = 4,
	Team = 8,
	Stadium = 0x10,
	Player = 0x20,
	Coach = 0x40,
	PlayerCoach = 0x80,
	Unknown = 0x1000,
	All = 0x10FF,
	AllPeople = 0xE0
}
