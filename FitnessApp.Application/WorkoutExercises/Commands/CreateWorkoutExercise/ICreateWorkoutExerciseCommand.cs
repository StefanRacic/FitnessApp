namespace FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise
{
    public interface ICreateWorkoutExerciseCommand
    {
        void Execute(CreateWorkoutExerciseModel model);
    }
}
