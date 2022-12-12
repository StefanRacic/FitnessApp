using FitnessApp.Application.Exercises.Commands.ExerciseFactory;
using FitnessApp.Application.Interfaces;

namespace FitnessApp.Application.Exercises.Commands
{
    public class CreateExerciseCommand : ICreateExerciseCommand
    {
        private readonly IDatabaseService _database;
        private readonly IExerciseFactory _factory;

        public CreateExerciseCommand(
            IDatabaseService database,
            IExerciseFactory factory)
        {
            _database = database;
            _factory = factory;
        }

        public void Execute(CreateExerciseModel model)
        {
            var exercise = _factory.Create(
                model.Name,
                model.Description);

            _database.Exercises.Add(exercise);

            _database.Save();
        }
    }
}
