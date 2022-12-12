using FitnessApp.Domain.Exercises;

namespace FitnessApp.Application.Exercises.Commands.ExerciseFactory
{
    public interface IExerciseFactory
    {
        Exercise Create(string name, string description);
    }
}
