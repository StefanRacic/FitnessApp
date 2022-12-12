namespace FitnessApp.Application.Workouts.Queries.GetWorkoutList
{
    public interface IGetWorkoutListQuery
    {
        List<WorkoutListItemModel> Execute();
    }
}
