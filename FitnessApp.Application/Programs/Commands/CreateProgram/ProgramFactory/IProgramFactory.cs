using FitnessApp.Domain.Programs;

namespace FitnessApp.Application.Programs.Commands.CreateProgram.ProgramFactory
{
    public interface IProgramFactory
    {
        Program Create(string name, string description);
    }
}
