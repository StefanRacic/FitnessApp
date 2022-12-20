namespace FitnessApp.Application.Workouts.Queries.GetWorkoutListByProgramId
{
    public interface IGetWorkoutListByProgramIdQuery
    {
        Task<List<WorkoutListItemByProgramIdModel>> ExecuteAsync(int programId);
    }
}
