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
            var workoutExercises = await _unitOfWork.WorkoutExerciseRepository.GetAllAsync(we => we.WorkoutId == workoutId);

            return workoutExercises.Select(we => new WorkoutExerciseListModel
            {
                Id = we.Id,
                ExerciseName = _unitOfWork.ExerciseRepository.Get(e => e.Id == we.ExerciseId).Name,
                ExerciseId = we.ExerciseId,
                WorkoutId = we.WorkoutId,
                Sets = we.Sets,
            }).ToList();
        }
    }
}
