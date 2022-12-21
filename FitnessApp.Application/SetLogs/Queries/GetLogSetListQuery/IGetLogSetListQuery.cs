namespace FitnessApp.Application.LogSets.Queries.GetLogSetListQuery
{
    public interface IGetLogSetListQuery
    {
        Task<IReadOnlyList<LogSetListItemModel>> Execute(int workoutLogId);
    }
}
