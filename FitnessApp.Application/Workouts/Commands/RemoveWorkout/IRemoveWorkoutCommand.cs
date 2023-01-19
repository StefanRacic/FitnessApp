namespace FitnessApp.Application.Workouts.Commands.RemoveWorkout
{
    public interface IRemoveWorkoutCommand
    {
        Task Execute(int id);
    }
}
