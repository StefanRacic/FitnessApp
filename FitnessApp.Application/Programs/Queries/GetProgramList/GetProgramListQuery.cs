using FitnessApp.Application.Interfaces.UnitOfWork;

namespace FitnessApp.Application.Programs.Queries.GetProgramList
{
    public class GetProgramListQuery
        : IGetProgramListQuery
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProgramListQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IReadOnlyList<ProgramListItemModel>> Execute()
        {
            var programs = await _unitOfWork.ProgramRepository.GetAllAsync();

            return programs.Select(p => new ProgramListItemModel
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description
            }).ToList();
        }
    }
}
