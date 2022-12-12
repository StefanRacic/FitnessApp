namespace FitnessApp.Application.Programs.Commands.CreateProgram
{
    public interface ICreateProgramCommand
    {
        void Execute(CreateProgramModel model);
    }
}
