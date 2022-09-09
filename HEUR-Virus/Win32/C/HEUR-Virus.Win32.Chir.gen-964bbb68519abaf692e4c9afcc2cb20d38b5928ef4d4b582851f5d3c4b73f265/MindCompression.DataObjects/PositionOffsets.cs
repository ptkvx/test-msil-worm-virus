using System;

namespace MindCompression.DataObjects;

public sealed class PositionOffsets : CalculatedOffsets
{
	private static Type _type = typeof(PositionOffsets);

	public static int Goalkeeper = CalculatedOffsets.Calculate(_type, 24);

	public static int Sweeper = CalculatedOffsets.Calculate(_type, 25);

	public static int Defender = CalculatedOffsets.Calculate(_type, 26);

	public static int DefensiveMidfielder = CalculatedOffsets.Calculate(_type, 27);

	public static int Midfielder = CalculatedOffsets.Calculate(_type, 28);

	public static int AttackingMidfielder = CalculatedOffsets.Calculate(_type, 29);

	public static int Attacker = CalculatedOffsets.Calculate(_type, 30);

	public static int WingBack = CalculatedOffsets.Calculate(_type, 31);

	public static int FreeRole = CalculatedOffsets.Calculate(_type, 32);

	public static int Right = CalculatedOffsets.Calculate(_type, 33);

	public static int Centre = CalculatedOffsets.Calculate(_type, 34);

	public static int Left = CalculatedOffsets.Calculate(_type, 35);

	public static int NewDefLeft = CalculatedOffsets.Calculate(_type, 36);

	public static int NewDefCentre = CalculatedOffsets.Calculate(_type, 37);

	public static int NewDefRight = CalculatedOffsets.Calculate(_type, 38);

	public static int NewDefMidCentre = CalculatedOffsets.Calculate(_type, 39);

	public static int NewMidLeft = CalculatedOffsets.Calculate(_type, 40);

	public static int NewMidCentre = CalculatedOffsets.Calculate(_type, 41);

	public static int NewMidRight = CalculatedOffsets.Calculate(_type, 42);

	public static int NewAttMidLeft = CalculatedOffsets.Calculate(_type, 43);

	public static int NewAttMidCentre = CalculatedOffsets.Calculate(_type, 44);

	public static int NewAttMidRight = CalculatedOffsets.Calculate(_type, 45);

	public static int NewAttCentre = CalculatedOffsets.Calculate(_type, 46);

	public static int NewWingBackLeft = CalculatedOffsets.Calculate(_type, 47);

	public static int NewWingBackRight = CalculatedOffsets.Calculate(_type, 48);
}
