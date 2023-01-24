using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Application.Programs.Commands.CreateProgram
{
    public class CreateProgramModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }
    }
}
