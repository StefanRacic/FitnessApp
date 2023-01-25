using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise
{
    public class CreateWorkoutExerciseModel
    {
        [Range(1, int.MaxValue)]
        public int Sets { get; set; }
        public int ExerciseId { get; set; }
        public int WorkoutId { get; set; }
    }
}
