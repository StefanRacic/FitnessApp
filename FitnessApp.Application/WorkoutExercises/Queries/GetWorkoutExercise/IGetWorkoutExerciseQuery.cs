namespace FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExercise
{
    public interface IGetWorkoutExerciseQuery
    {
        Task<WorkoutExerciseModel> Execute(int id);
    }
}
