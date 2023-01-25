using FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExercise;

namespace FitnessApp.Application.WorkoutExercises.Commands.UpdateWorkoutExercise
{
    public interface IUpdateWorkoutExerciseCommand
    {
        Task<WorkoutExerciseModel> Execute(UpdateWorkoutExerciseModel model);
    }
}
