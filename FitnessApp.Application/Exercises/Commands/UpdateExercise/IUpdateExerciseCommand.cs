using FitnessApp.Application.Exercises.Queries.GetExercise;

namespace FitnessApp.Application.Exercises.Commands.UpdateExercise
{
    public interface IUpdateExerciseCommand
    {
        Task<ExerciseModel> Execute(UpdateExerciseModel model);
    }
}
