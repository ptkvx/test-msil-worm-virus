namespace MindCompression.DataObjects;

public interface ICoach
{
	int CurrentCoachingAbility { get; set; }

	int PotentialCoachingAbility { get; set; }

	CoachingSkills CoachingSkills { get; }

	CoachMentalSkills CoachMentalSkills { get; }
}
