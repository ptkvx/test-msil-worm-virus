using System;

namespace MindCompression.Utils;

public class FmDateTime
{
	public static int ToFmDateTime(DateTime date)
	{
		ushort num = (ushort)date.Year;
		num = (ushort)((num << 8) + (num >> 8));
		ushort num2 = (ushort)(date.DayOfYear - 1);
		num2 = (ushort)((num2 << 8) + (num2 >> 8));
		return (num2 << 16) + num;
	}

	public static DateTime FromFmDateTime(int date)
	{
		ushort year = (ushort)(((date & 0xFF00) >> 8) + ((date & 0xFF) << 8));
		ushort num = (ushort)(Math.Abs((date & 0xFF000000L) >> 24) + ((date & 0xFF0000) >> 8));
		return new DateTime(year, 1, 1).AddDays((int)num);
	}
}
