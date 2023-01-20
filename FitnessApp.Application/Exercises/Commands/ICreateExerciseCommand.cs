using FitnessApp.Application.Exercises.Queries.GetExercise;

namespace FitnessApp.Application.Exercises.Commands
{
    public interface ICreateExerciseCommand
    {
        Task<ExerciseModel> Execute(CreateExerciseModel model);
    }
}
