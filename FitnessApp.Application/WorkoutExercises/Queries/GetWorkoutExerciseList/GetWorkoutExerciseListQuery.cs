using FitnessApp.Application.Interfaces;

namespace FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExerciseList
{
    public class GetWorkoutExerciseListQuery : IGetWorkoutExerciseListQuery
    {
        private readonly IDatabaseService _database;

        public GetWorkoutExerciseListQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<WorkoutExerciseListModel> Execute(int workoutId)
        {
            var workoutExercises = _database.WorkoutExercises
                .Where(we => we.WorkoutId.Equals(workoutId))
                .Select(we => new WorkoutExerciseListModel
                {
                    Id = we.Id,
                    Sets = we.Sets,
                    ExerciseId = we.ExerciseId,
                    WorkoutId = we.WorkoutId
                })
                .ToList();

            return workoutExercises;
        }
    }
}
