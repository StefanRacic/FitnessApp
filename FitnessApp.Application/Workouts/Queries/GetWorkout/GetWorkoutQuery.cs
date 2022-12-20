using FitnessApp.Application.Interfaces.UnitOfWork;

namespace FitnessApp.Application.Workouts.Queries.GetWorkout
{
    public class GetWorkoutQuery : IGetWorkoutQuery
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetWorkoutQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<WorkoutModel> Execute(int id)
        {
            var workout = await _unitOfWork.WorkoutRepository.GetAsync(w => w.Id == id);

            if (workout is null)
                throw new Exception();

            return new WorkoutModel
            {
                Id = workout.Id,
                Name = workout.Name,
                Description = workout.Description
            };
        }
    }
}
