using System;

namespace MindCompression.DataObjects;

public interface IPerson
{
	string FirstName { get; }

	string LastName { get; }

	string Nickname { get; }

	DateTime DateOfBirth { get; set; }

	byte InternationalCaps { get; set; }

	byte InternationalGoals { get; set; }

	byte U21InternationalCaps { get; set; }

	byte U21InternationalGoals { get; set; }

	int Nationality { get; set; }

	int CityOfBirth { get; set; }
}
