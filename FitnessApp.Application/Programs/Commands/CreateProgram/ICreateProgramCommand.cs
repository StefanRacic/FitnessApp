namespace FitnessApp.Application.Programs.Commands.CreateProgram
{
    public interface ICreateProgramCommand
    {
        Task Execute(CreateProgramModel model);
    }
}
