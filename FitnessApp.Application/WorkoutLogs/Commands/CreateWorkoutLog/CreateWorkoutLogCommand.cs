using FitnessApp.Application.Interfaces;
using FitnessApp.Application.Interfaces.UnitOfWork;
using FitnessApp.Application.WorkoutLogs.Commands.CreateWorkoutLog.WorkoutLogFactory;
using Microsoft.Extensions.Logging;

namespace FitnessApp.Application.WorkoutLogs.Commands.CreateWorkoutLog
{
    public class CreateWorkoutLogCommand : ICreateWorkoutLogCommand
    {
        private readonly IDatabaseService _database;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWorkoutLogFactory _factory;

        public CreateWorkoutLogCommand(
            ILogger<CreateWorkoutLogCommand> logger,
            IDatabaseService database,
            IUnitOfWork unitOfWork,
            IWorkoutLogFactory factory)
        {
            _database = database;
            _unitOfWork = unitOfWork;
            _factory = factory;
        }

        public async Task Execute(CreateWorkoutLogModel model)
        {
            var workout = await _unitOfWork.WorkoutRepository.GetAsync(w => w.Id == model.WorkoutId);

            var workoutLog = _factory.Create(
                model.Note,
                model.StartDate,
                model.EndDate,
                workout);

            await _unitOfWork.WorkoutLogRepository.AddAsync(workoutLog);

            await _unitOfWork.CommitAsync();
        }
    }
}
