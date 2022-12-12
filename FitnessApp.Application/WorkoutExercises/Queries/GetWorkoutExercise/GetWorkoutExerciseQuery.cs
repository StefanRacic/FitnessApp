using FitnessApp.Application.Interfaces;

namespace FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExercise
{
    public class GetWorkoutExerciseQuery : IGetWorkoutExerciseQuery
    {
        private readonly IDatabaseService _database;

        public GetWorkoutExerciseQuery(IDatabaseService database)
        {
            _database = database;
        }

        public WorkoutExerciseModel Execute(int id)
        {
            var workoutExercise = _database.WorkoutExercises
                .Where(we => we.Id.Equals(id))
                .Select(we => new WorkoutExerciseModel
                {
                    Id = we.Id,
                    Sets = we.Sets,
                    ExerciseId = we.ExerciseId,
                    WorkoutId = we.WorkoutId
                })
                .Single();

            return workoutExercise;
        }
    }
}
