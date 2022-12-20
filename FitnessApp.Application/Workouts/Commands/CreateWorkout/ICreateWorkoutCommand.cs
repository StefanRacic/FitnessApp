namespace FitnessApp.Application.Workouts.Commands.CreateWorkout
{
    public interface ICreateWorkoutCommand
    {
        Task Execute(CreateWorkoutModel model);
    }
}
