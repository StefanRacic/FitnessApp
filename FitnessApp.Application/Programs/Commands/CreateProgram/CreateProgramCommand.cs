using FitnessApp.Application.Interfaces;
using FitnessApp.Application.Programs.Commands.CreateProgram.ProgramFactory;

namespace FitnessApp.Application.Programs.Commands.CreateProgram
{
    public class CreateProgramCommand : ICreateProgramCommand
    {
        private readonly IDatabaseService _context;
        private readonly IProgramFactory _factory;

        public CreateProgramCommand(
            IDatabaseService context,
            IProgramFactory factory)
        {
            _context = context;
            _factory = factory;
        }

        public void Execute(CreateProgramModel model)
        {
            var program = _factory.Create(
                model.Name,
                model.Description);

            _context.Programs.Add(program);

            _context.Save();
        }
    }
}
