using FitnessApp.Application.Interfaces.UnitOfWork;
using FitnessApp.Application.Workouts.Commands.CreateWorkout.WorkoutFactory;

namespace FitnessApp.Application.Workouts.Commands.CreateWorkout
{
    public class CreateWorkoutCommand : ICreateWorkoutCommand
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWorkoutFactory _factory;

        public CreateWorkoutCommand(
            IUnitOfWork unitOfWork,
            IWorkoutFactory factory)
        {
            _unitOfWork = unitOfWork;
            _factory = factory;
        }

        public async Task Execute(CreateWorkoutModel model)
        {
            var program = await _unitOfWork
                .ProgramRepository
                .GetAsync(p => p.Id == model.ProgramId);

            var workout = _factory.Create(
                model.Name,
                model.Description,
                program);

            await _unitOfWork.WorkoutRepository.AddAsync(workout);

            await _unitOfWork.CommitAsync();
        }
    }
}
