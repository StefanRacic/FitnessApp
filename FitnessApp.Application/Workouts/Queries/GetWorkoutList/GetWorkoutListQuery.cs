using FitnessApp.Application.Interfaces;

namespace FitnessApp.Application.Workouts.Queries.GetWorkoutList
{
    public class GetWorkoutListQuery : IGetWorkoutListQuery
    {
        private readonly IDatabaseService _database;

        public GetWorkoutListQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<WorkoutListItemModel> Execute()
        {
            var workouts = _database.Workouts
                .Select(w => new WorkoutListItemModel
                {
                    Id = w.Id,
                    Name = w.Name,
                    Description = w.Description
                })
                .ToList();

            return workouts;
        }
    }
}
