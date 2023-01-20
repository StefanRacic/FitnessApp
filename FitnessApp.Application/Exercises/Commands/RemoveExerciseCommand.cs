using FitnessApp.Application.Interfaces.UnitOfWork;

namespace FitnessApp.Application.Exercises.Commands
{
    public class RemoveExerciseCommand : IRemoveExerciseCommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public RemoveExerciseCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Execute(int id)
        {
            var exercise = await _unitOfWork.ExerciseRepository.GetAsync(e => e.Id == id);
            _unitOfWork.ExerciseRepository.Remove(exercise);
            await _unitOfWork.CommitAsync();
        }
    }
}
