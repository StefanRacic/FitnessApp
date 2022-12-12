using FitnessApp.Application.SetLogs.Commands.CreateSetLogCommand.SetLogFactory;
using FitnessApp.Domain.SetLogs;
using FitnessApp.Domain.WorkoutExercises;
using FitnessApp.Domain.WorkoutLogs;

namespace FitnessApp.Application.LogSets.Commands.CreateLogSetCommand.LogSetFactory
{
    public class SetLogFactory : ISetLogFactory
    {
        public SetLog Create(int reps, int weight, WorkoutExercise workoutExercise, WorkoutLog workoutLog)
        {
            var logSet = new SetLog();

            logSet.Reps = reps;

            logSet.Weight = weight;

            return logSet;
        }
    }
}
