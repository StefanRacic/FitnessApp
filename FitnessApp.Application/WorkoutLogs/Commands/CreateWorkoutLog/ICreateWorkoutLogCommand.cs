namespace FitnessApp.Application.WorkoutLogs.Commands.CreateWorkoutLog
{
    public interface ICreateWorkoutLogCommand
    {
        Task Execute(CreateWorkoutLogModel model);
    }
}
