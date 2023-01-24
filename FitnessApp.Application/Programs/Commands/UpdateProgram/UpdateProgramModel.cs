using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Application.Programs.Commands.UpdateProgram
{
    public class UpdateProgramModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }
    }
}
