namespace FitnessApp.Application.WorkoutLogs.Queries.GetWorkoutLogList
{
    public interface IGetWorkoutLogListQuery
    {
        Task<List<WorkoutLogListItemModel>> Execute();
    }
}
