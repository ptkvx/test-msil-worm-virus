namespace MindCompression.DataObjects;

public interface ITeam
{
	byte Status { get; set; }

	byte TrainingGround { get; set; }

	int AverageAttendance { get; set; }

	int MinimumAttendance { get; set; }

	int MaximumAttendance { get; set; }
}
