using FitnessApp.Application.Interfaces;
using Microsoft.Extensions.Logging;

namespace FitnessApp.Application.WorkoutLogs.Queries.GetWorkoutLog
{
    public class GetWorkoutLogQuery : IGetWorkoutLogQuery
    {
        private readonly ILogger<GetWorkoutLogQuery> _logger;
        private readonly IDatabaseService _database;

        public GetWorkoutLogQuery(
            ILogger<GetWorkoutLogQuery> logger,
            IDatabaseService database)
        {
            _logger = logger;
            _database = database;
        }

        public WorkoutLogModel Execute(int id)
        {
            var workoutLog = _database.WorkoutLogs
                .FirstOrDefault(wl => wl.Id == id);

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
