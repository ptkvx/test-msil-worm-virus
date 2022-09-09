using System;

namespace MindCompression.DataObjects;

public sealed class ClubOffsets : CalculatedOffsets
{
	private static Type _type = typeof(ClubOffsets);

	public static int Status = CalculatedOffsets.Calculate(_type, 167);

	public static int TrainingGround = CalculatedOffsets.Calculate(_type, 168);

	public static int AverageAttendance = CalculatedOffsets.Calculate(_type, 172);

	public static int MinimumAttendance = CalculatedOffsets.Calculate(_type, 176);

	public static int MaximumAttendance = CalculatedOffsets.Calculate(_type, 180);

	public static int KitAddress = CalculatedOffsets.Calculate(_type, 64);

	public static int FinanceAddress = CalculatedOffsets.Calculate(_type, 212);

	public static int SponsorAddress = CalculatedOffsets.Calculate(_type, 216);
}
