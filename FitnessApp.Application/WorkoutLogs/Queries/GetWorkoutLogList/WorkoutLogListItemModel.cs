namespace FitnessApp.Application.WorkoutLogs.Queries.GetWorkoutLogList
{
    public class WorkoutLogListItemModel
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public TimeSpan WorkoutDuration { get; set; }
        public int WorkoutId { get; set; }
    }
}
