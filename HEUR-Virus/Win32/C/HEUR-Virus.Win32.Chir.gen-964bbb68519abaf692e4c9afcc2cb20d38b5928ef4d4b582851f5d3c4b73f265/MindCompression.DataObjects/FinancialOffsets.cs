using System;

namespace MindCompression.DataObjects;

public sealed class FinancialOffsets : CalculatedOffsets
{
	private static Type _type = typeof(FinancialOffsets);

	public static int Balance = CalculatedOffsets.Calculate(_type, 4);

	public static int RemainingTransferBudget = CalculatedOffsets.Calculate(_type, 16);

	public static int SeasonTransferBudget = CalculatedOffsets.Calculate(_type, 20);

	public static int TransferRevenueMadeAvailable = CalculatedOffsets.Calculate(_type, 24);

	public static int WageBudget = CalculatedOffsets.Calculate(_type, 116);
}
