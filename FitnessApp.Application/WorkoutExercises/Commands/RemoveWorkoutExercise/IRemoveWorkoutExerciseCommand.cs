namespace FitnessApp.Application.WorkoutExercises.Commands.RemoveWorkoutExercise
{
    public interface IRemoveWorkoutExerciseCommand
    {
        Task Execute(int id);
    }
}
