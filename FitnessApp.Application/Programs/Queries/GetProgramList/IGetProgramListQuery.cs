namespace FitnessApp.Application.Programs.Queries.GetProgramList
{
    public interface IGetProgramListQuery
    {
        Task<IReadOnlyList<ProgramListItemModel>> Execute();
    }
}
