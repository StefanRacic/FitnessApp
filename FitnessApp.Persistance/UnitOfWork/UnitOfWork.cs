using FitnessApp.Application.Interfaces.Repositories;
using FitnessApp.Application.Interfaces.UnitOfWork;
using FitnessApp.Persistence.Repositories.Exercises;
using FitnessApp.Persistence.Repositories.Programs;
using FitnessApp.Persistence.Repositories.SetLogs;
using FitnessApp.Persistence.Repositories.WorkoutExercises;
using FitnessApp.Persistence.Repositories.WorkoutLogs;
using FitnessApp.Persistence.Repositories.Workouts;

namespace FitnessApp.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseService _database;
        private IProgramRepository _programRepository;
        private IWorkoutRepository _workoutRepository;
        private IExerciseRepository _exerciseRepository;
        private IWorkoutExerciseRepository _workoutExerciseRepository;
        private IWorkoutLogRepository _workoutLogRepository;
        private ISetLogRepository _setLogRepository;

        public UnitOfWork(DatabaseService database)
        {
            _database = database;
        }

        public IProgramRepository ProgramRepository
            => _programRepository ?? new ProgramRepository(_database);

        public IWorkoutRepository WorkoutRepository
            => _workoutRepository ?? new WorkoutRepository(_database);

        public IExerciseRepository ExerciseRepository
            => _exerciseRepository ?? new ExerciseRepository(_database);

        public IWorkoutExerciseRepository WorkoutExerciseRepository
            => _workoutExerciseRepository ?? new WorkoutExerciseRepository(_database);

        public IWorkoutLogRepository WorkoutLogRepository
            => _workoutLogRepository ?? new WorkoutLogRepository(_database);

        public ISetLogRepository SetLogRepository
            => _setLogRepository ?? new SetLogRepository(_database);

        public void Commit()
            => _database.SaveChanges();

        public Task CommitAsync()
            => _database.SaveChangesAsync();

        public void Rollback()
            => _database.Dispose();

        public async Task RollbackAsync()
            => await _database.DisposeAsync();
    }
}
