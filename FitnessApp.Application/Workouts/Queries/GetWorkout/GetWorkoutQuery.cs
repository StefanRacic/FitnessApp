using FitnessApp.Application.Interfaces;

namespace FitnessApp.Application.Workouts.Queries.GetWorkout
{
    public class GetWorkoutQuery : IGetWorkoutQuery
    {
        private readonly IDatabaseService _database;

        public GetWorkoutQuery(IDatabaseService database)
        {
            _database = database;
        }

        public WorkoutModel Execute(int id)
        {
            var workout = _database.Workouts
                .Where(w => w.Id.Equals(id))
                .Select(w => new WorkoutModel
                {
                    Id = w.Id,
                    Name = w.Name,
                    Description = w.Description,
                })
                .Single();

            return workout;
        }
    }
}
