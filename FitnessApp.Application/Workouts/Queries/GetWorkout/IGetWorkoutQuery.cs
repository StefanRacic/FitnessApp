namespace FitnessApp.Application.Workouts.Queries.GetWorkout
{
    public interface IGetWorkoutQuery
    {
        Task<WorkoutModel> Execute(int id);
    }
}
