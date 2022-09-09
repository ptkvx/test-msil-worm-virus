using System;

namespace MindCompression.DataObjects;

public sealed class CoachOffsets : CalculatedOffsets
{
	private static Type _type = typeof(CoachOffsets);

	public static int Id = CalculatedOffsets.Calculate(_type, 76);

	public static int SkillsAdress = CalculatedOffsets.Calculate(_type, 152);

	public static int ContractAdress = CalculatedOffsets.Calculate(_type, 184);

	public static int CurrentCoachingAbility = CalculatedOffsets.Calculate(_type, 14);

	public static int PotentialCoachingAbility = CalculatedOffsets.Calculate(_type, 16);

	public static int DateOfBirth = CalculatedOffsets.Calculate(_type, 116);

	public static int CityOfBirth = CalculatedOffsets.Calculate(_type, 120);

	public static int Nationality = CalculatedOffsets.Calculate(_type, 128);

	public static int InternationalCaps = CalculatedOffsets.Calculate(_type, 136);

	public static int InternationalGoals = CalculatedOffsets.Calculate(_type, 138);

	public static int U21InternationalCaps = CalculatedOffsets.Calculate(_type, 137);

	public static int U21InternationalGoals = CalculatedOffsets.Calculate(_type, 139);

	public static int FirstName = CalculatedOffsets.Calculate(_type, 100);

	public static int LastName = CalculatedOffsets.Calculate(_type, 104);

	public static int Nickname = CalculatedOffsets.Calculate(_type, 108);
}
