using FitnessApp.Application.Interfaces;
using FitnessApp.Application.Workouts.Commands.CreateWorkout.WorkoutFactory;

namespace FitnessApp.Application.Workouts.Commands.CreateWorkout
{
    public class CreateWorkoutCommand : ICreateWorkoutCommand
    {
        private readonly IDatabaseService _database;
        private readonly IWorkoutFactory _factory;

        public CreateWorkoutCommand(
            IDatabaseService database,
            IWorkoutFactory factory)
        {
            _database = database;
            _factory = factory;
        }

        public void Execute(CreateWorkoutModel model)
        {
            var program = _database.Programs.First(p => p.Id == model.ProgramId);

            var workout = _factory.Create(
                model.Name,
                model.Description,
                program);

            _database.Workouts.Add(workout);

            _database.Save();
        }
    }
}
