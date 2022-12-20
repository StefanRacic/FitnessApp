namespace FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise
{
    public interface ICreateWorkoutExerciseCommand
    {
        Task Execute(CreateWorkoutExerciseModel model);
    }
}
