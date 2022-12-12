namespace FitnessApp.Application.Workouts.Queries.GetWorkout
{
    public interface IGetWorkoutQuery
    {
        WorkoutModel Execute(int id);
    }
}
