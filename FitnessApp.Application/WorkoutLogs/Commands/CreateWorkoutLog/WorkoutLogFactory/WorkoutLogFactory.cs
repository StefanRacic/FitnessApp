using FitnessApp.Domain.WorkoutLogs;
using FitnessApp.Domain.Workouts;

namespace FitnessApp.Application.WorkoutLogs.Commands.CreateWorkoutLog.WorkoutLogFactory
{
    public class WorkoutLogFactory : IWorkoutLogFactory
    {
        public WorkoutLog Create(string note, DateTime startDate, DateTime endDate, Workout workout)
        {
            var workoutLog = new WorkoutLog();

            workoutLog.Note = note;

            workoutLog.StartDate = startDate;

            workoutLog.EndDate = endDate;

            workoutLog.WorkoutDuration = workoutLog.WorkoutDuration;

            workoutLog.Workout = workout;

            return workoutLog;
        }
    }
}
