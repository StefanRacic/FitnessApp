using FitnessApp.Application.Interfaces.Repositories;

namespace FitnessApp.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProgramRepository ProgramRepository { get; }
        IWorkoutRepository WorkoutRepository { get; }
        IExerciseRepository ExerciseRepository { get; }
        IWorkoutExerciseRepository WorkoutExerciseRepository { get; }
        void Commit();
        void Rollback();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
