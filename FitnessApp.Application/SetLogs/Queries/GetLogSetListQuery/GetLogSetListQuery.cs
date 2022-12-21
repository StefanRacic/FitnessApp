using FitnessApp.Application.Interfaces.UnitOfWork;
using Microsoft.Extensions.Logging;

namespace FitnessApp.Application.LogSets.Queries.GetLogSetListQuery
{
    public class GetLogSetListQuery : IGetLogSetListQuery
    {
        private readonly ILogger<GetLogSetListQuery> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public GetLogSetListQuery(
            ILogger<GetLogSetListQuery> logger,
            IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<IReadOnlyList<LogSetListItemModel>> Execute(int workoutLogId)
        {
            var logSets = await _unitOfWork.SetLogRepository.GetAllAsync(sl => sl.WorkoutLog.Id == workoutLogId);

            return logSets.Select(ls => new LogSetListItemModel
            {
                Id = ls.Id,
                Reps = ls.Reps,
                Weight = ls.Weight,
            }).ToList();
        }
    }
}
