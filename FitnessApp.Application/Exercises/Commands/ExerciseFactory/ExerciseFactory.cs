using FitnessApp.Domain.Exercises;

namespace FitnessApp.Application.Exercises.Commands.ExerciseFactory
{
    public class ExerciseFactory : IExerciseFactory
    {
        public Exercise Create(string name, string description)
        {
            var exercise = new Exercise
            {
                Name = name,
                Description = description
            };

            return exercise;
        }
    }
}
