namespace FitnessApp.Application.Programs.Queries.GetProgramList
{
    public interface IGetProgramListQuery
    {
        Task<List<ProgramListItemModel>> Execute();
    }
}
