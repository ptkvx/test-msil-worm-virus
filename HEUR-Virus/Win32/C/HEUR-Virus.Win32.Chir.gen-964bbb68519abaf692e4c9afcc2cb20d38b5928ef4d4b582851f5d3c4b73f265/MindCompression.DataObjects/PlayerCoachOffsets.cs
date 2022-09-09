using System;

namespace MindCompression.DataObjects;

public sealed class PlayerCoachOffsets : CalculatedOffsets
{
	private static Type _type = typeof(PlayerCoachOffsets);

	public static int Id = 284;

	public static int SkillsAddress = 168;

	public static int ContractAddress = 392;

	public static int InjuryAddress = 44;

	public static int Condition = 8;

	public static int Fitness = 10;

	public static int CurrentPlayingAbility = 20;

	public static int PotentialPlayingAbility = 22;

	public static int Morale = 40;

	public static int DateOfBirth = 324;

	public static int CityOfBirth = 328;

	public static int Nationality = 336;

	public static int InternationalCaps = 344;

	public static int InternationalGoals = 346;

	public static int U21InternationalCaps = 345;

	public static int U21InternationalGoals = 347;

	public static int FirstName = 308;

	public static int LastName = 312;

	public static int Nickname = 316;
}
