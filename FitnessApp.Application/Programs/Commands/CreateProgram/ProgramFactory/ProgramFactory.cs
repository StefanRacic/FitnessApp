using FitnessApp.Domain.Programs;

namespace FitnessApp.Application.Programs.Commands.CreateProgram.ProgramFactory
{
    public class ProgramFactory : IProgramFactory
    {
        public Program Create(string name, string description)
        {
            var program = new Program
            {
                Name = name,

                Description = description
            };

            return program;
        }
    }
}
