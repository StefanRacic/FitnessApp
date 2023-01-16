using FitnessApp.Application.Programs.Queries.GetProgram;

namespace FitnessApp.Application.Programs.Commands.CreateProgram
{
    public interface ICreateProgramCommand
    {
        Task<ProgramModel> Execute(CreateProgramModel model);
    }
}
