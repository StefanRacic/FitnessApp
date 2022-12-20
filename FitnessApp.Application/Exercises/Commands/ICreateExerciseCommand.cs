namespace FitnessApp.Application.Exercises.Commands
{
    public interface ICreateExerciseCommand
    {
        Task Execute(CreateExerciseModel model);
    }
}
