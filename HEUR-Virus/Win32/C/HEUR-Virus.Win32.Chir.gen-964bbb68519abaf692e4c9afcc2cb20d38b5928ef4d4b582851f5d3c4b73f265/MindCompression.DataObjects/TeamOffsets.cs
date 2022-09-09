using System;

namespace MindCompression.DataObjects;

public sealed class TeamOffsets : CalculatedOffsets
{
	private static Type _type = typeof(TeamOffsets);

	public static int Id = CalculatedOffsets.Calculate(_type, 16);

	public static int Type = CalculatedOffsets.Calculate(_type, 48);

	public static int ClubAddress = CalculatedOffsets.Calculate(_type, 44);

	public static int PlayersAddress = CalculatedOffsets.Calculate(_type, 116);

	public static int NumberOfPlayers = CalculatedOffsets.Calculate(_type, 120);
}
