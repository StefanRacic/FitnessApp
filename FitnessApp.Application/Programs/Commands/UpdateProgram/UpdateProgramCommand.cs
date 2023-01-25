using FitnessApp.Application.Interfaces.UnitOfWork;
using FitnessApp.Application.Programs.Queries.GetProgram;

namespace FitnessApp.Application.Programs.Commands.UpdateProgram
{
    public class UpdateProgramCommand : IUpdateProgramCommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateProgramCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProgramModel> Execute(UpdateProgramModel model)
        {
            var program = await _unitOfWork.ProgramRepository.GetAsync(p => p.Id == model.Id);

            program.Name = model.Name;

            program.Description = model.Description;

            _unitOfWork.ProgramRepository.Update(program);

            await _unitOfWork.CommitAsync();

            return new ProgramModel
            {
                Id = program.Id,
                Name = program.Name,
                Description = program.Description
            };
        }
    }
}
