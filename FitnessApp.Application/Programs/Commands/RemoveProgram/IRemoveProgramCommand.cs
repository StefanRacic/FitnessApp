namespace FitnessApp.Application.Programs.Commands.RemoveProgram
{
    public interface IRemoveProgramCommand
    {
        Task Execute(int id);
    }
}
