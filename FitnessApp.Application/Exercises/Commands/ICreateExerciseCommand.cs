namespace FitnessApp.Application.Exercises.Commands
{
    public interface ICreateExerciseCommand
    {
        void Execute(CreateExerciseModel model);
    }
}
