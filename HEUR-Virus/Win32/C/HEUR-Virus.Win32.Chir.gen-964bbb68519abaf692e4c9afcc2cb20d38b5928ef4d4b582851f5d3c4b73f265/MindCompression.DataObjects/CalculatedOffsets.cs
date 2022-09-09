using System;
using MindCompression.Utils;

namespace MindCompression.DataObjects;

public class CalculatedOffsets
{
	public static int Calculate(Type type, int value)
	{
		if (type.Equals(typeof(PlayerOffsets)))
		{
			switch (FmMemory.Version)
			{
			case VersionInfo.v502Retail:
			case VersionInfo.v503Retail:
				if (value > 140 && 160 > value)
				{
					return value + 4;
				}
				return value;
			}
		}
		else if (!type.Equals(typeof(PositionOffsets)) && !type.Equals(typeof(SkillOffsets)) && !type.Equals(typeof(ContractOffsets)))
		{
			if (type.Equals(typeof(PlayerCoachOffsets)))
			{
				switch (FmMemory.Version)
				{
				case VersionInfo.v502Retail:
				case VersionInfo.v503Retail:
					if (value > 140 && 160 > value)
					{
						return value + 4;
					}
					return value;
				}
			}
			else if (!type.Equals(typeof(CoachOffsets)) && !type.Equals(typeof(ClubOffsets)))
			{
				type.Equals(typeof(TeamOffsets));
			}
		}
		return value;
	}
}
