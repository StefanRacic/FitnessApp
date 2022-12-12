using FitnessApp.Application.Interfaces;
using Microsoft.Extensions.Logging;

namespace FitnessApp.Application.Workouts.Queries.GetWorkoutListByProgramId
{
    public class GetWorkoutListByProgramIdQuery : IGetWorkoutListByProgramIdQuery
    {
        private readonly ILogger<GetWorkoutListByProgramIdQuery> _logger;
        private readonly IDatabaseService _database;

        public GetWorkoutListByProgramIdQuery(
            ILogger<GetWorkoutListByProgramIdQuery> logger,
            IDatabaseService database)
        {
            _logger = logger;
            _database = database;
        }
        public List<WorkoutListItemByProgramIdModel> Execute(int programId)
        {
            return _database.Workouts
                .Where(w => w.Program.Id == programId)
                .Select(w => new WorkoutListItemByProgramIdModel
                {
                    Id = w.Id,
                    Name = w.Name,
                    Description = w.Description
                }).ToList();
        }
    }
}
