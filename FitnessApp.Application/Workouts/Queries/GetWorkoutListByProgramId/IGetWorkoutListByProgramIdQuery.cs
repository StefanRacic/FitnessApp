namespace FitnessApp.Application.Workouts.Queries.GetWorkoutListByProgramId
{
    public interface IGetWorkoutListByProgramIdQuery
    {
        List<WorkoutListItemByProgramIdModel> Execute(int programId);
    }
}
