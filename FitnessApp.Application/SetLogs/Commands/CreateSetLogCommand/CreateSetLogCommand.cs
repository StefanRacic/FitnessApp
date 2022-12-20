using FitnessApp.Application.Interfaces;
using FitnessApp.Application.Interfaces.UnitOfWork;
using FitnessApp.Application.SetLogs.Commands.CreateSetLogCommand.SetLogFactory;
using Microsoft.Extensions.Logging;

namespace FitnessApp.Application.LogSets.Commands.CreateLogSetCommand
{
    public class CreateSetLogCommand : ICreateSetLogCommand
    {
        private readonly ILogger<CreateSetLogCommand> _logger;
        private readonly ISetLogFactory _factory;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDatabaseService _database;

        public CreateSetLogCommand(
            ILogger<CreateSetLogCommand> logger,
            ISetLogFactory factory,
            IUnitOfWork unitOfWork,
            IDatabaseService database)
        {
            _logger = logger;
            _factory = factory;
            _unitOfWork = unitOfWork;
            _database = database;
        }

        public async Task Execute(CreateSetLogModel model)
        {
            var workoutExercise = await _unitOfWork.WorkoutExerciseRepository.GetAsync(we => we.Id == model.WorkoutExerciseId);

            var workoutLog = await _unitOfWork.WorkoutLogRepository.GetAsync(wl => wl.Id == model.WorkoutLogId);


            var logSet = _factory.Create(
                model.Reps,
                model.Weight,
                workoutExercise,
                workoutLog);

            await _unitOfWork.SetLogRepository.AddAsync(logSet);

            await _unitOfWork.CommitAsync();
        }
    }
}
