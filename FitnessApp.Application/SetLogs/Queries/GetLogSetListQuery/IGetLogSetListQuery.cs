namespace FitnessApp.Application.LogSets.Queries.GetLogSetListQuery
{
    public interface IGetLogSetListQuery
    {
        List<LogSetListItemModel> Execute(int workoutLogId);
    }
}
