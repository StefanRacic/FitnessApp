using FitnessApp.Application.Workouts.Queries.GetWorkout;

namespace FitnessApp.Application.Workouts.Commands.UpdateWorkout
{
    public interface IUpdateWorkoutCommand
    {
        Task<WorkoutModel> Execute(UpdateWorkoutModel model);
    }
}
