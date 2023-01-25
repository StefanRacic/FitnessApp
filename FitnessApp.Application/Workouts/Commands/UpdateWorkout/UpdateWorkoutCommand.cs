using FitnessApp.Application.Interfaces.UnitOfWork;
using FitnessApp.Application.Workouts.Queries.GetWorkout;

namespace FitnessApp.Application.Workouts.Commands.UpdateWorkout
{
    public class UpdateWorkoutCommand : IUpdateWorkoutCommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateWorkoutCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<WorkoutModel> Execute(int id, UpdateWorkoutModel model)
        {
            var workout = await _unitOfWork.WorkoutRepository.GetAsync(w => w.Id == id);

            workout.Name = model.Name;

            workout.Description = model.Description;

            _unitOfWork.WorkoutRepository.Update(workout);

            await _unitOfWork.CommitAsync();

            return new WorkoutModel
            {
                Id = workout.Id,
                Name = model.Name,
                Description = model.Description
            };
        }
    }
}
