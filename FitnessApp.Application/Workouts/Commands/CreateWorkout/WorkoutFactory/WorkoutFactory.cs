using FitnessApp.Domain.Programs;
using FitnessApp.Domain.Workouts;

namespace FitnessApp.Application.Workouts.Commands.CreateWorkout.WorkoutFactory
{
    public class WorkoutFactory : IWorkoutFactory
    {
        public Workout Create(string name, string description, Program program)
        {
            var workout = new Workout
            {
                Name = name,
                Description = description,
                Program = program

            };

            return workout;
        }
    }
}
