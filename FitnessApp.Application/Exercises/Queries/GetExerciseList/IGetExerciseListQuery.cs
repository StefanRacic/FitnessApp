namespace FitnessApp.Application.Exercises.Queries.GetExerciseList
{
    public interface IGetExerciseListQuery
    {
        Task<List<ExerciseListItemModel>> Execute();
    }
}
