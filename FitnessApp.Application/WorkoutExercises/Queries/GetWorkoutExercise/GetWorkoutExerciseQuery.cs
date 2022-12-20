using FitnessApp.Application.Interfaces.UnitOfWork;

namespace FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExercise
{
    public class GetWorkoutExerciseQuery : IGetWorkoutExerciseQuery
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetWorkoutExerciseQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<WorkoutExerciseModel> Execute(int id)
        {
            var workoutExercise = await _unitOfWork.WorkoutExerciseRepository.GetAsync(we => we.Id == id);

            if (workoutExercise is null)
                throw new Exception();

            return new WorkoutExerciseModel
            {
                Id = id,
                ExerciseId = workoutExercise.ExerciseId,
                Sets = workoutExercise.Sets,
                WorkoutId = workoutExercise.WorkoutId,
            };
        }
    }
}
