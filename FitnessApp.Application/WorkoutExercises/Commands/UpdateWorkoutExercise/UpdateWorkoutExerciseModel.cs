using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Application.WorkoutExercises.Commands.UpdateWorkoutExercise
{
    public class UpdateWorkoutExerciseModel
    {
        [Range(1, int.MaxValue)]
        public int Sets { get; set; }
    }
}
