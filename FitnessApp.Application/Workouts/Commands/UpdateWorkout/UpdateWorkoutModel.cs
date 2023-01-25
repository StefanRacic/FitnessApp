using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Application.Workouts.Commands.UpdateWorkout
{
    public class UpdateWorkoutModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }
    }
}
