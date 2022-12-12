using FitnessApp.Application.Interfaces;
using FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise.WorkoutExerciseFactory;

namespace FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise
{
    public class CreateWorkoutExerciseCommand
        : ICreateWorkoutExerciseCommand
    {
        private readonly IDatabaseService _database;
        private readonly IWorkoutExerciseFactory _factory;

        public CreateWorkoutExerciseCommand(
            IDatabaseService database,
            IWorkoutExerciseFactory factory)
        {
            _database = database;
            _factory = factory;
        }

        public void Execute(CreateWorkoutExerciseModel model)
        {
            var exercise = _database.Exercises
                .Single(e => e.Id.Equals(model.ExerciseId));

            var workout = _database.Workouts
                .Single(w => w.Id.Equals(model.WorkoutId));

            var workoutExercise = _factory.Create(
                model.Sets,
                exercise,
                workout
                );

            _database.WorkoutExercises.Add(workoutExercise);

            _database.Save();
        }
    }
}
