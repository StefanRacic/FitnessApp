namespace FitnessApp.Application.Workouts.Commands.CreateWorkout
{
    public interface ICreateWorkoutCommand
    {
        void Execute(CreateWorkoutModel model);
    }
}
