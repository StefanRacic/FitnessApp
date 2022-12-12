namespace FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExercise
{
    public interface IGetWorkoutExerciseQuery
    {
        WorkoutExerciseModel Execute(int id);
    }
}
