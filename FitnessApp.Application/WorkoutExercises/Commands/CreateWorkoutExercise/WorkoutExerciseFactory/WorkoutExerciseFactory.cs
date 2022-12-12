using FitnessApp.Domain.Exercises;
using FitnessApp.Domain.WorkoutExercises;
using FitnessApp.Domain.Workouts;

namespace FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise.WorkoutExerciseFactory
{
    public class WorkoutExerciseFactory : IWorkoutExerciseFactory
    {
        public WorkoutExercise Create(int sets, Exercise exercise, Workout workout)
        {
            var workoutExercise = new WorkoutExercise();

            workoutExercise.Sets = sets;

            workoutExercise.Exercise = exercise;

            workoutExercise.Workout = workout;

            return workoutExercise;
        }
    }
}
