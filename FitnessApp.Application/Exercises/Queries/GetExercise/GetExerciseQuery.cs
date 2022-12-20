using FitnessApp.Application.Interfaces.UnitOfWork;

namespace FitnessApp.Application.Exercises.Queries.GetExercise
{
    public class GetExerciseQuery : IGetExerciseQuery
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetExerciseQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ExerciseModel> ExecuteAsync(int id)
        {
            var exercise = await _unitOfWork.ExerciseRepository.GetAsync(e => e.Id == id);

            if (exercise is null)
                throw new Exception();

            return new ExerciseModel
            {
                Id = exercise.Id,
                Name = exercise.Name,
                Description = exercise.Description,
            };
        }
    }
}
