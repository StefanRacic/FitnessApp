using FitnessApp.Application.Interfaces.UnitOfWork;
using FitnessApp.Application.Programs.Commands.CreateProgram.ProgramFactory;
using FitnessApp.Application.Programs.Queries.GetProgram;

namespace FitnessApp.Application.Programs.Commands.CreateProgram
{
    public class CreateProgramCommand : ICreateProgramCommand
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProgramFactory _factory;

        public CreateProgramCommand(
            IUnitOfWork unitOfWork,
            IProgramFactory factory)
        {
            _unitOfWork = unitOfWork;
            _factory = factory;
        }

        public async Task<ProgramModel> Execute(CreateProgramModel model)
        {
            var program = _factory.Create(
                model.Name,
                model.Description);

            await _unitOfWork.ProgramRepository.AddAsync(program);

            await _unitOfWork.CommitAsync();

            return new ProgramModel
            {
                Id = program.Id,
                Name = program.Description,
                Description = program.Description
            };
        }
    }
}
