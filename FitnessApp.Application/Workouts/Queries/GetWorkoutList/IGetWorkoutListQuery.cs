namespace FitnessApp.Application.Workouts.Queries.GetWorkoutList
{
    public interface IGetWorkoutListQuery
    {
        Task<List<WorkoutListItemModel>> Execute();
    }
}
