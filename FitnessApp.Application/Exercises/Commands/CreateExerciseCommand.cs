using FitnessApp.Application.Exercises.Commands.ExerciseFactory;
using FitnessApp.Application.Interfaces.UnitOfWork;

namespace FitnessApp.Application.Exercises.Commands
{
    public class CreateExerciseCommand : ICreateExerciseCommand
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IExerciseFactory _factory;

        public CreateExerciseCommand(
            IUnitOfWork unitOfWork,
            IExerciseFactory factory)
        {
            _unitOfWork = unitOfWork;
            _factory = factory;
        }

        public async Task Execute(CreateExerciseModel model)
        {
            var exercise = _factory.Create(
                model.Name,
                model.Description);

            await _unitOfWork.ExerciseRepository.AddAsync(exercise);

            await _unitOfWork.CommitAsync();
        }
    }
}
