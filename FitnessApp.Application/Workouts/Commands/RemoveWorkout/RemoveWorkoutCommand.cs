using FitnessApp.Application.Interfaces.UnitOfWork;

namespace FitnessApp.Application.Workouts.Commands.RemoveWorkout
{
    public class RemoveWorkoutCommand : IRemoveWorkoutCommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public RemoveWorkoutCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Execute(int id)
        {
            var workout = await _unitOfWork.WorkoutRepository.GetAsync(w => w.Id == id);
            _unitOfWork.WorkoutRepository.Remove(workout);
            await _unitOfWork.CommitAsync();
        }
    }
}
