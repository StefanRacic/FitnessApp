namespace FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExerciseList
{
    public interface IGetWorkoutExerciseListQuery
    {
        Task<IReadOnlyList<WorkoutExerciseListModel>> Execute(int workoutId);
    }
}
