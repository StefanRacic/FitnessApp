using FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExerciseList;

namespace FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise
{
    public interface ICreateWorkoutExerciseCommand
    {
        Task<WorkoutExerciseListModel> Execute(CreateWorkoutExerciseModel model);
    }
}
