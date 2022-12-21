namespace FitnessApp.Application.WorkoutLogs.Queries.GetWorkoutLogList
{
    public interface IGetWorkoutLogListQuery
    {
        Task<IReadOnlyList<WorkoutLogListItemModel>> Execute();
    }
}
