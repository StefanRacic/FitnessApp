using FitnessApp.Domain.Exercises;
using FitnessApp.Domain.WorkoutExercises;
using FitnessApp.Domain.Workouts;

namespace FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise.WorkoutExerciseFactory
{
    public interface IWorkoutExerciseFactory
    {
        WorkoutExercise Create(int sets, Exercise exercise, Workout workout);
    }
}
