using FitnessApp.Application.Interfaces.UnitOfWork;

namespace FitnessApp.Application.Programs.Queries.GetProgram
{
    public class GetProgramQuery : IGetProgramQuery
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProgramQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProgramModel> Execute(int id)
        {
            var program = await _unitOfWork.ProgramRepository.GetAsync(p => p.Id == id);

            // TODO: add custom exceptions and logging
            if (program is null)
                throw new Exception();

            return new ProgramModel
            {
                Id = program.Id,
                Name = program.Name,
                Description = program.Description,
            };
        }
    }
}
