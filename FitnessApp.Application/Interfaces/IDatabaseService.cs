using FitnessApp.Domain.Exercises;
using FitnessApp.Domain.Programs;
using FitnessApp.Domain.SetLogs;
using FitnessApp.Domain.WorkoutExercises;
using FitnessApp.Domain.WorkoutLogs;
using FitnessApp.Domain.Workouts;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Application.Interfaces
{
    public interface IDatabaseService
    {
        DbSet<Program> Programs { get; }
        DbSet<Workout> Workouts { get; }
        DbSet<WorkoutExercise> WorkoutExercises { get; }
        DbSet<Exercise> Exercises { get; }
        DbSet<WorkoutLog> WorkoutLogs { get; set; }
        DbSet<SetLog> SetLogs { get; set; }
        void Save();
    }
}
