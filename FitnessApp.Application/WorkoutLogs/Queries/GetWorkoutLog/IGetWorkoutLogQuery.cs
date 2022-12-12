namespace FitnessApp.Application.WorkoutLogs.Queries.GetWorkoutLog
{
    public interface IGetWorkoutLogQuery
    {
        WorkoutLogModel Execute(int id);
    }
}
