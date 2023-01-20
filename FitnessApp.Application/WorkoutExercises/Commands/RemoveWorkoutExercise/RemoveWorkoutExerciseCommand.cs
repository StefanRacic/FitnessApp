using FitnessApp.Application.Interfaces.UnitOfWork;

namespace FitnessApp.Application.WorkoutExercises.Commands.RemoveWorkoutExercise
{
    public class RemoveWorkoutExerciseCommand : IRemoveWorkoutExerciseCommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public RemoveWorkoutExerciseCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Execute(int id)
        {
            var workoutExercise = await _unitOfWork.WorkoutExerciseRepository.GetAsync(we => we.Id == id);
            _unitOfWork.WorkoutExerciseRepository.Remove(workoutExercise);
            await _unitOfWork.CommitAsync();
        }
    }
}
