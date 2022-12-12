using FitnessApp.Domain.SetLogs;
using FitnessApp.Domain.WorkoutExercises;
using FitnessApp.Domain.WorkoutLogs;

namespace FitnessApp.Application.SetLogs.Commands.CreateSetLogCommand.SetLogFactory
{
    public interface ISetLogFactory
    {
        SetLog Create(int reps, int weight, WorkoutExercise workoutExercise, WorkoutLog workoutLog);
    }
}
