namespace FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExerciseList
{
    public interface IGetWorkoutExerciseListQuery
    {
        List<WorkoutExerciseListModel> Execute(int workoutId);
    }
}
