using FitnessApp.Application.Interfaces.UnitOfWork;

namespace FitnessApp.Application.Programs.Commands.RemoveProgram
{
    public class RemoveProgramCommand : IRemoveProgramCommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public RemoveProgramCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Execute(int id)
        {
            var program = await _unitOfWork.ProgramRepository.GetAsync(p => p.Id == id);
            _unitOfWork.ProgramRepository.Remove(program);

            await _unitOfWork.CommitAsync();
        }
    }
}
