using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Application.Exercises.Commands.UpdateExercise
{
    public class UpdateExerciseModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }
    }
}
