using FitnessApp.Domain.Common;
using FitnessApp.Domain.Exercises;
using FitnessApp.Domain.Workouts;

namespace FitnessApp.Domain.WorkoutExercises
{
    public class WorkoutExercise : IEntity
    {
        public int Id { get; set; }
        public int Sets { get; set; }
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
    }
}
