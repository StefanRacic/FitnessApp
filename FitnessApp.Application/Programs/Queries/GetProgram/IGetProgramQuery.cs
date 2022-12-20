namespace FitnessApp.Application.Programs.Queries.GetProgram
{
    public interface IGetProgramQuery
    {
        Task<ProgramModel> Execute(int id);
    }
}
