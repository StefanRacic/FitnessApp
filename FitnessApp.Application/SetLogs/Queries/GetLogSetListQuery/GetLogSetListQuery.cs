using FitnessApp.Application.Interfaces;
using Microsoft.Extensions.Logging;

namespace FitnessApp.Application.LogSets.Queries.GetLogSetListQuery
{
    public class GetLogSetListQuery : IGetLogSetListQuery
    {
        private readonly ILogger<GetLogSetListQuery> _logger;
        private readonly IDatabaseService _database;

        public GetLogSetListQuery(
            ILogger<GetLogSetListQuery> logger,
            IDatabaseService database)
        {
            _logger = logger;
            _database = database;
        }

        public List<LogSetListItemModel> Execute(int workoutLogId)
        {
            var logSets = _database.SetLogs
                .Where(ls => ls.WorkoutLog.Id == workoutLogId)
                .Select(ls => new LogSetListItemModel
                {
                    Id = ls.Id,
                    Reps = ls.Reps,
                    Weight = ls.Weight
                })
                .ToList();

            return logSets;
        }
    }
}
