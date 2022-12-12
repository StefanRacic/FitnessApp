namespace FitnessApp.Application.WorkoutLogs.Queries.GetWorkoutLogList
{
    public interface IGetWorkoutLogListQuery
    {
        List<WorkoutLogListItemModel> Execute();
    }
}
