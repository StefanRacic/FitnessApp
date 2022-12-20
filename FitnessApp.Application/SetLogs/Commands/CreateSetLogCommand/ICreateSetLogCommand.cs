namespace FitnessApp.Application.LogSets.Commands.CreateLogSetCommand
{
    public interface ICreateSetLogCommand
    {
        Task Execute(CreateSetLogModel model);
    }
}
