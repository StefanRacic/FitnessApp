using FitnessApp.Application.Interfaces;
using FitnessApp.Application.WorkoutLogs.Commands.CreateWorkoutLog.WorkoutLogFactory;
using Microsoft.Extensions.Logging;

namespace FitnessApp.Application.WorkoutLogs.Commands.CreateWorkoutLog
{
    public class CreateWorkoutLogCommand : ICreateWorkoutLogCommand
    {
        private readonly IDatabaseService _database;
        private readonly IWorkoutLogFactory _factory;

        public CreateWorkoutLogCommand(
            ILogger<CreateWorkoutLogCommand> logger,
            IDatabaseService database,
            IWorkoutLogFactory factory)
        {
            _database = database;
            _factory = factory;
        }

        public void Execute(CreateWorkoutLogModel model)
        {
            var workout = _database.Workouts.FirstOrDefault(w => w.Id == model.WorkoutId);

            var workoutLog = _factory.Create(
                model.Note,
                model.StartDate,
                model.EndDate,
                workout);

            _database.WorkoutLogs.Add(workoutLog);

            _database.Save();
        }
    }
}
