using FitnessApp.Application.Interfaces.UnitOfWork;
using FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise.WorkoutExerciseFactory;

namespace FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise
{
    public class CreateWorkoutExerciseCommand
        : ICreateWorkoutExerciseCommand
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWorkoutExerciseFactory _factory;

        public CreateWorkoutExerciseCommand(
            IUnitOfWork unitOfWork,
            IWorkoutExerciseFactory factory)
        {
            _unitOfWork = unitOfWork;
            _factory = factory;
        }

        public async Task Execute(CreateWorkoutExerciseModel model)
        {
            var exercise = await _unitOfWork.ExerciseRepository.GetAsync(e => e.Id == model.ExerciseId);

            var workout = await _unitOfWork.WorkoutRepository.GetAsync(w => w.Id == model.WorkoutId);

            var workoutExercise = _factory.Create(
                model.Sets,
                exercise,
                workout
                );

            await _unitOfWork.WorkoutExerciseRepository.AddAsync(workoutExercise);

            await _unitOfWork.CommitAsync();
        }
    }
}
