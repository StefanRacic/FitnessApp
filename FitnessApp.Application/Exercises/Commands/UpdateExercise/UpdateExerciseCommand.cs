using FitnessApp.Application.Exercises.Queries.GetExercise;
using FitnessApp.Application.Interfaces.UnitOfWork;

namespace FitnessApp.Application.Exercises.Commands.UpdateExercise
{
    public class UpdateExerciseCommand : IUpdateExerciseCommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateExerciseCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ExerciseModel> Execute(int id, UpdateExerciseModel model)
        {
            var exercise = await _unitOfWork.ExerciseRepository.GetAsync(e => e.Id == id);

            exercise.Name = model.Name;

            exercise.Description = model.Description;

            _unitOfWork.ExerciseRepository.Update(exercise);

            await _unitOfWork.CommitAsync();

            return new ExerciseModel
            {
                Id = exercise.Id,
                Name = exercise.Name,
                Description = exercise.Description,
            };
        }
    }
}
