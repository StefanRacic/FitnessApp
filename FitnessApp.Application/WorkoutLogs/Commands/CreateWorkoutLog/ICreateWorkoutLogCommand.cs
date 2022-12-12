namespace FitnessApp.Application.WorkoutLogs.Commands.CreateWorkoutLog
{
    public interface ICreateWorkoutLogCommand
    {
        void Execute(CreateWorkoutLogModel model);
    }
}
