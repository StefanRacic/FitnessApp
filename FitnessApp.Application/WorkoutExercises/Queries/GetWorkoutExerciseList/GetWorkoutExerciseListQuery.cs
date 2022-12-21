using FitnessApp.Application.Interfaces.UnitOfWork;

namespace FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExerciseList
{
    public class GetWorkoutExerciseListQuery : IGetWorkoutExerciseListQuery
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetWorkoutExerciseListQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IReadOnlyList<WorkoutExerciseListModel>> Execute(int workoutId)
        {
            var workoutExercises = await _unitOfWork.WorkoutExerciseRepository.GetAllAsync();

            return workoutExercises.Select(we => new WorkoutExerciseListModel
            {
                Id = we.Id,
                ExerciseId = we.ExerciseId,
                WorkoutId = we.WorkoutId,
                Sets = we.Sets,
            }).ToList();
        }
    }
}
