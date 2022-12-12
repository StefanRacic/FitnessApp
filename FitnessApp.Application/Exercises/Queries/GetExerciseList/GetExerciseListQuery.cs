using FitnessApp.Application.Interfaces;

namespace FitnessApp.Application.Exercises.Queries.GetExerciseList
{
    public class GetExerciseListQuery : IGetExerciseListQuery
    {
        private readonly IDatabaseService _database;

        public GetExerciseListQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<ExerciseListItemModel> Execute()
        {
            var exercises = _database.Exercises
                .Select(e => new ExerciseListItemModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Description = e.Description
                })
                .ToList();

            return exercises;
        }
    }
}
