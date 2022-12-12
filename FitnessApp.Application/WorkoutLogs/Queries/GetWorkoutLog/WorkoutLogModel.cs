namespace FitnessApp.Application.WorkoutLogs.Queries.GetWorkoutLog
{
    public class WorkoutLogModel
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public TimeSpan WorkoutDuration { get; set; }
        public int WorkoutId { get; set; }
    }
}
