using FitnessApp.Application.Interfaces.UnitOfWork;

namespace FitnessApp.Application.Exercises.Queries.GetExerciseList
{
    public class GetExerciseListQuery : IGetExerciseListQuery
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetExerciseListQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ExerciseListItemModel>> Execute()
        {
            var exc = await _unitOfWork.ExerciseRepository.GetAllAsync();

            return exc.Select(ex => new ExerciseListItemModel
            {
                Id = ex.Id,
                Name = ex.Name,
                Description = ex.Description,
            }).ToList();
        }
    }
}
