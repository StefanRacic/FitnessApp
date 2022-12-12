using FitnessApp.Application.Interfaces;
using Microsoft.Extensions.Logging;

namespace FitnessApp.Application.WorkoutLogs.Queries.GetWorkoutLogList
{
    public class GetWorkoutLogListQuery : IGetWorkoutLogListQuery
    {
        private readonly ILogger<GetWorkoutLogListQuery> _logger;
        private readonly IDatabaseService _database;

        public GetWorkoutLogListQuery(
            ILogger<GetWorkoutLogListQuery> logger,
            IDatabaseService database)
        {
            _logger = logger;
            _database = database;
        }

        public List<WorkoutLogListItemModel> Execute()
        {
            var workoutLogs = _database.WorkoutLogs
                .Select(wl => new WorkoutLogListItemModel
                {
                    Id = wl.Id,
                    Note = wl.Note,
                    WorkoutDuration = wl.WorkoutDuration,
                    WorkoutId = wl.Workout.Id
                })
                .ToList();

            return workoutLogs;
        }
    }
}
