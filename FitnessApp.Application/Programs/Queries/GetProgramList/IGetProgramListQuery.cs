namespace FitnessApp.Application.Programs.Queries.GetProgramList
{
    public interface IGetProgramListQuery
    {
        List<ProgramListItemModel> Execute();
    }
}
