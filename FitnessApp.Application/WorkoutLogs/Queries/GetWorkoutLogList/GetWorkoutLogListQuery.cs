using FitnessApp.Application.Interfaces.UnitOfWork;
using Microsoft.Extensions.Logging;

namespace FitnessApp.Application.WorkoutLogs.Queries.GetWorkoutLogList
{
    public class GetWorkoutLogListQuery : IGetWorkoutLogListQuery
    {
        private readonly ILogger<GetWorkoutLogListQuery> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public GetWorkoutLogListQuery(
            ILogger<GetWorkoutLogListQuery> logger,
            IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<WorkoutLogListItemModel>> Execute()
        {
            var wrl = await _unitOfWork.WorkoutLogRepository.GetAllAsync();

            return wrl.Select(wl => new WorkoutLogListItemModel
            {
                Id = wl.Id,
                Note = wl.Note,
                WorkoutDuration = wl.WorkoutDuration,
                WorkoutId = wl.WorkoutId,
            }).ToList();
        }
    }
}
