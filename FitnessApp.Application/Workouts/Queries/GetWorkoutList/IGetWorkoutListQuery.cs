namespace FitnessApp.Application.Workouts.Queries.GetWorkoutList
{
    public interface IGetWorkoutListQuery
    {
        Task<IReadOnlyList<WorkoutListItemModel>> Execute();
    }
}
