using FitnessApp.Application.Interfaces;

namespace FitnessApp.Application.Exercises.Queries.GetExercise
{
    public class GetExerciseQuery : IGetExerciseQuery
    {
        private readonly IDatabaseService _database;

        public GetExerciseQuery(IDatabaseService database)
        {
            _database = database;
        }

        public ExerciseModel Execute(int id)
        {
            var exercise = _database.Exercises
                .Where(e => e.Id.Equals(id))
                .Select(e => new ExerciseModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Description = e.Description
                })
                .SingleOrDefault();

            return exercise;
        }
    }
}
