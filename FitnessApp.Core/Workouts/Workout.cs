using FitnessApp.Domain.Common;
using FitnessApp.Domain.Programs;
using FitnessApp.Domain.WorkoutExercises;

namespace FitnessApp.Domain.Workouts
{
    public class Workout : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
        public Program Program { get; set; }
    }
}
