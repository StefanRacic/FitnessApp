namespace FitnessApp.Application.Exercises.Commands
{
    public interface IRemoveExerciseCommand
    {
        Task Execute(int id);
    }
}
