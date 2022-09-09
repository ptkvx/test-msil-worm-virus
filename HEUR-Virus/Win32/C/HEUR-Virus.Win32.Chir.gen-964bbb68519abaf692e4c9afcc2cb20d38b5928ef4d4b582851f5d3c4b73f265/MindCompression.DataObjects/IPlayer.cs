namespace MindCompression.DataObjects;

public interface IPlayer
{
	int CurrentPlayingAbility { get; set; }

	int PotentialPlayingAbility { get; set; }

	int Condition { get; set; }

	MentalSkills MentalSkills { get; }

	PositionalSkills PositionalSkills { get; }

	GoalkeepingSkills GoalkeepingSkills { get; }

	TechnicalSkills TechnicalSkills { get; }

	PhysicalSkills PhysicalSkills { get; }

	HiddenSkills HiddenSkills { get; }

	Contract Contract { get; }
}
