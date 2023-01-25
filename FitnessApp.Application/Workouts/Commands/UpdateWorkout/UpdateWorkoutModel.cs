using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Application.Workouts.Commands.UpdateWorkout
{
    public class UpdateWorkoutModel
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }
    }
}
