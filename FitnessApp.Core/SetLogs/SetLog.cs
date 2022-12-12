using FitnessApp.Domain.Common;
using FitnessApp.Domain.WorkoutExercises;
using FitnessApp.Domain.WorkoutLogs;

namespace FitnessApp.Domain.SetLogs
{
    public class SetLog : IEntity
    {
        public int Id { get; set; }
        public int Reps { get; set; }
        public int Weight { get; set; }
        public WorkoutExercise WorkoutExercise { get; set; }
        public WorkoutLog WorkoutLog { get; set; }
    }
}
