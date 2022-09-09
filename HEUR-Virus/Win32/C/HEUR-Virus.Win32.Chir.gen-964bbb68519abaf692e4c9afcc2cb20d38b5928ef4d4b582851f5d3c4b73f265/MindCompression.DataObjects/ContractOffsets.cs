using System;

namespace MindCompression.DataObjects;

public sealed class ContractOffsets : CalculatedOffsets
{
	private static Type _type = typeof(ContractOffsets);

	public static int Wages = CalculatedOffsets.Calculate(_type, 16);

	public static int AppearanceBonus = CalculatedOffsets.Calculate(_type, 72);

	public static int GoalBonus = CalculatedOffsets.Calculate(_type, 76);

	public static int AssistBonus = CalculatedOffsets.Calculate(_type, 80);

	public static int CleanSheetBonus = CalculatedOffsets.Calculate(_type, 84);

	public static int ContractExpires = CalculatedOffsets.Calculate(_type, 32);

	public static int ContractStarted = CalculatedOffsets.Calculate(_type, 24);
}
