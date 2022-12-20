namespace FitnessApp.Application.LogSets.Queries.GetLogSetQuery
{
    public interface IGetLogSetQuery
    {
        Task<LogSetModel> Execute(int id);
    }
}
