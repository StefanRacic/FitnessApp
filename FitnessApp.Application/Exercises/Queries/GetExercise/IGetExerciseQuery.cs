namespace FitnessApp.Application.Exercises.Queries.GetExercise
{
    public interface IGetExerciseQuery
    {
        ExerciseModel Execute(int id);
    }
}
