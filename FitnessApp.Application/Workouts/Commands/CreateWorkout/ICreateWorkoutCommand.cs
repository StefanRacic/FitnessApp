using FitnessApp.Application.Workouts.Queries.GetWorkoutListByProgramId;

namespace FitnessApp.Application.Workouts.Commands.CreateWorkout
{
    public interface ICreateWorkoutCommand
    {
        Task<WorkoutListItemByProgramIdModel> Execute(CreateWorkoutModel model);
    }
}
