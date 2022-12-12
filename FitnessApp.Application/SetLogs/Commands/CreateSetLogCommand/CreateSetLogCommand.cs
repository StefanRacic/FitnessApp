using FitnessApp.Application.Interfaces;
using FitnessApp.Application.SetLogs.Commands.CreateSetLogCommand.SetLogFactory;
using Microsoft.Extensions.Logging;

namespace FitnessApp.Application.LogSets.Commands.CreateLogSetCommand
{
    public class CreateSetLogCommand : ICreateSetLogCommand
    {
        private readonly ILogger<CreateSetLogCommand> _logger;
        private readonly ISetLogFactory _factory;
        private readonly IDatabaseService _database;

        public CreateSetLogCommand(
            ILogger<CreateSetLogCommand> logger,
            ISetLogFactory factory,
            IDatabaseService database)
        {
            _logger = logger;
            _factory = factory;
            _database = database;
        }

        public void Execute(CreateSetLogModel model)
        {
            var workoutExercise = _database.WorkoutExercises.FirstOrDefault(we => we.Id == model.WorkoutExerciseId);

            var workoutLog = _database.WorkoutLogs.FirstOrDefault(wl => wl.Id == model.WorkoutLogId);

            var logSet = _factory.Create(
                model.Reps,
                model.Weight,
                workoutExercise,
                workoutLog);

            _database.SetLogs.Add(logSet);

            _database.Save();
        }
    }
}
