namespace FitnessApp.Application.Programs.Queries.GetProgram
{
    public interface IGetProgramQuery
    {
        ProgramModel Execute(int id);
    }
}
