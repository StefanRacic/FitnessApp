namespace FitnessApp.Application.Exercises.Queries.GetExerciseList
{
    public interface IGetExerciseListQuery
    {
        List<ExerciseListItemModel> Execute();
    }
}
