using System;

namespace MindCompression.DataObjects;

public sealed class PlayerOffsets : CalculatedOffsets
{
	private static Type _type = typeof(PlayerOffsets);

	public static int Id = 220;

	public static int SkillsAddress = 168;

	public static int ContractAddress = 328;

	public static int InjuryAddress = 44;

	public static int Condition = 8;

	public static int Fitness = 10;

	public static int CurrentPlayingAbility = 20;

	public static int PotentialPlayingAbility = 22;

	public static int Morale = 40;

	public static int DateOfBirth = 260;

	public static int CityOfBirth = 264;

	public static int Nationality = 272;

	public static int InternationalCaps = 280;

	public static int InternationalGoals = 282;

	public static int U21InternationalCaps = 281;

	public static int U21InternationalGoals = 283;

	public static int Team = 300;

	public static int FirstName = 244;

	public static int LastName = 248;

	public static int Nickname = 252;
}
