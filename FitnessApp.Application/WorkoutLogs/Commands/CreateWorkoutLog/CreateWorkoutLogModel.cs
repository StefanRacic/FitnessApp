namespace FitnessApp.Application.WorkoutLogs.Commands.CreateWorkoutLog
{
    public class CreateWorkoutLogModel
    {
        public string Note { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int WorkoutId { get; set; }
    }
}
