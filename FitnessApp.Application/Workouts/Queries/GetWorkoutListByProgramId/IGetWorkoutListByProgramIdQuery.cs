namespace FitnessApp.Application.Workouts.Queries.GetWorkoutListByProgramId
{
    public interface IGetWorkoutListByProgramIdQuery
    {
        Task<IReadOnlyList<WorkoutListItemByProgramIdModel>> ExecuteAsync(int programId);
    }
}
