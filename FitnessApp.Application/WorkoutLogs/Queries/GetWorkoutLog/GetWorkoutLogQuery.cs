using FitnessApp.Application.Interfaces.UnitOfWork;
using Microsoft.Extensions.Logging;

namespace FitnessApp.Application.WorkoutLogs.Queries.GetWorkoutLog
{
    public class GetWorkoutLogQuery : IGetWorkoutLogQuery
    {
        private readonly ILogger<GetWorkoutLogQuery> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public GetWorkoutLogQuery(
            ILogger<GetWorkoutLogQuery> logger,
            IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<WorkoutLogModel> Execute(int id)
        {
            var workoutLog = await _unitOfWork.WorkoutLogRepository.GetAsync(wl => wl.Id == id);

            if (workoutLog is null)
                throw new Exception();

            return new WorkoutLogModel
            {
                Id = workoutLog.Id,
                Note = workoutLog.Note,
                WorkoutDuration = workoutLog.WorkoutDuration,
                WorkoutId = workoutLog.WorkoutId
            };
        }
    }
}
