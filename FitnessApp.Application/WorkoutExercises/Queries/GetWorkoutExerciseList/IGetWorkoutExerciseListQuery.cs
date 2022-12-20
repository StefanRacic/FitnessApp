namespace FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExerciseList
{
    public interface IGetWorkoutExerciseListQuery
    {
        Task<List<WorkoutExerciseListModel>> Execute(int workoutId);
    }
}
