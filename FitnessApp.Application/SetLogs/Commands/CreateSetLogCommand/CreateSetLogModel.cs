namespace FitnessApp.Application.LogSets.Commands.CreateLogSetCommand
{
    public class CreateSetLogModel
    {
        public int Reps { get; set; }
        public int Weight { get; set; }
        public int WorkoutExerciseId { get; set; }
        public int WorkoutLogId { get; set; }
    }
}
