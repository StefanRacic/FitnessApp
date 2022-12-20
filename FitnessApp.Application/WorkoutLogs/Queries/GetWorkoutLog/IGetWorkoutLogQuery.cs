namespace FitnessApp.Application.WorkoutLogs.Queries.GetWorkoutLog
{
    public interface IGetWorkoutLogQuery
    {
        Task<WorkoutLogModel> Execute(int id);
    }
}
