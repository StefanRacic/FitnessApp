using FitnessApp.Application.Interfaces.Repositories;

namespace FitnessApp.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProgramRepository ProgramRepository { get; }
        IWorkoutRepository WorkoutRepository { get; }
        IExerciseRepository ExerciseRepository { get; }
        IWorkoutExerciseRepository WorkoutExerciseRepository { get; }
        IWorkoutLogRepository WorkoutLogRepository { get; }
        ISetLogRepository SetLogRepository { get; }
        void Commit();
        void Rollback();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
