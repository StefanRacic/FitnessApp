using FitnessApp.Application.Interfaces;
using FitnessApp.Domain.Exercises;
using FitnessApp.Domain.Programs;
using FitnessApp.Domain.SetLogs;
using FitnessApp.Domain.WorkoutExercises;
using FitnessApp.Domain.WorkoutLogs;
using FitnessApp.Domain.Workouts;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Persistence
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public DatabaseService(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Program> Programs { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<WorkoutLog> WorkoutLogs { get; set; }
        public DbSet<SetLog> SetLogs { get; set; }

        public void Save()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkoutLog>()
                .HasMany(wl => wl.SetLogs)
                .WithOne(sl => sl.WorkoutLog)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
