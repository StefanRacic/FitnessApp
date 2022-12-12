namespace FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExercise
{
    public class WorkoutExerciseModel
    {
        public int Id { get; set; }
        public int Sets { get; set; }
        public int ExerciseId { get; set; }
        public int WorkoutId { get; set; }
    }
}
