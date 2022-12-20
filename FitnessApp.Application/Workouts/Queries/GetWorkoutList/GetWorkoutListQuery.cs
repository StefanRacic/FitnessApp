using FitnessApp.Application.Interfaces.UnitOfWork;

namespace FitnessApp.Application.Workouts.Queries.GetWorkoutList
{
    public class GetWorkoutListQuery : IGetWorkoutListQuery
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetWorkoutListQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<WorkoutListItemModel>> Execute()
        {
            var workouts = await _unitOfWork.WorkoutRepository.GetAllAsync();

            return workouts.Select(w => new WorkoutListItemModel
            {
                Id = w.Id,
                Name = w.Name,
                Description = w.Description,
            }).ToList();
        }
    }
}
