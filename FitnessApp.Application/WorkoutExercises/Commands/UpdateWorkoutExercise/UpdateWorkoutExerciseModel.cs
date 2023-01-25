using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Application.WorkoutExercises.Commands.UpdateWorkoutExercise
{
    public class UpdateWorkoutExerciseModel
    {
        public int Id { get; set; }
        [Range(1, int.MaxValue)]
        public int Sets { get; set; }
    }
}
