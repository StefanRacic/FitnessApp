namespace FitnessApp.Application.LogSets.Queries.GetLogSetListQuery
{
    public interface IGetLogSetListQuery
    {
        Task<List<LogSetListItemModel>> Execute(int workoutLogId);
    }
}
