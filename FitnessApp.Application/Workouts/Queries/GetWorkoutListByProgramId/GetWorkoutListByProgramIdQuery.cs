using FitnessApp.Application.Interfaces.UnitOfWork;

namespace FitnessApp.Application.Workouts.Queries.GetWorkoutListByProgramId
{
    public class GetWorkoutListByProgramIdQuery : IGetWorkoutListByProgramIdQuery
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetWorkoutListByProgramIdQuery(
            IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<WorkoutListItemByProgramIdModel>> ExecuteAsync(int programId)
        {
            var wrks = await _unitOfWork.WorkoutRepository.GetAllAsync(w => w.Program.Id == programId);

            return wrks.Select(w => new WorkoutListItemByProgramIdModel
            {
                Id = w.Id,
                Name = w.Name,
                Description = w.Description
            }).ToList();
        }
    }
}
