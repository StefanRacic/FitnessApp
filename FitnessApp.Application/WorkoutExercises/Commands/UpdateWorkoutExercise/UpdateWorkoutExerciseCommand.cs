using FitnessApp.Application.Interfaces.UnitOfWork;
using FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExercise;

namespace FitnessApp.Application.WorkoutExercises.Commands.UpdateWorkoutExercise
{
    public class UpdateWorkoutExerciseCommand : IUpdateWorkoutExerciseCommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateWorkoutExerciseCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<WorkoutExerciseModel> Execute(int id, UpdateWorkoutExerciseModel model)
        {
            var workoutExercise = await _unitOfWork.WorkoutExerciseRepository.GetAsync(we => we.Id == id);

            workoutExercise.Sets = model.Sets;

            _unitOfWork.WorkoutExerciseRepository.Update(workoutExercise);

            var exercise = await _unitOfWork.ExerciseRepository.GetAsync(e => e.Id == workoutExercise.ExerciseId);

            await _unitOfWork.CommitAsync();

            return new WorkoutExerciseModel
            {
                Id = workoutExercise.Id,
                Sets = workoutExercise.Sets,
                ExerciseName = exercise.Name,
                ExerciseId = workoutExercise.ExerciseId,
                WorkoutId = workoutExercise.WorkoutId
            };
        }
    }
}
