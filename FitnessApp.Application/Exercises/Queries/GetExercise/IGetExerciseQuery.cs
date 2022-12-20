namespace FitnessApp.Application.Exercises.Queries.GetExercise
{
    public interface IGetExerciseQuery
    {
        Task<ExerciseModel> ExecuteAsync(int id);
    }
}
