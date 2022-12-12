using FitnessApp.Domain.WorkoutLogs;
using FitnessApp.Domain.Workouts;

namespace FitnessApp.Application.WorkoutLogs.Commands.CreateWorkoutLog.WorkoutLogFactory
{
    public interface IWorkoutLogFactory
    {
        WorkoutLog Create(string note, DateTime startDate, DateTime endDate, Workout workout);
    }
}
