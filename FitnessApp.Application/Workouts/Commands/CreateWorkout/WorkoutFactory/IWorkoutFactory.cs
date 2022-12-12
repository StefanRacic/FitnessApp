using FitnessApp.Domain.Programs;
using FitnessApp.Domain.Workouts;

namespace FitnessApp.Application.Workouts.Commands.CreateWorkout.WorkoutFactory
{
    public interface IWorkoutFactory
    {
        Workout Create(string name, string description, Program program);
    }
}
