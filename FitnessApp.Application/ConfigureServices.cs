using FitnessApp.Application.Exercises.Commands;
using FitnessApp.Application.Exercises.Commands.ExerciseFactory;
using FitnessApp.Application.Exercises.Queries.GetExercise;
using FitnessApp.Application.Exercises.Queries.GetExerciseList;
using FitnessApp.Application.LogSets.Commands.CreateLogSetCommand;
using FitnessApp.Application.LogSets.Commands.CreateLogSetCommand.LogSetFactory;
using FitnessApp.Application.LogSets.Queries.GetLogSetListQuery;
using FitnessApp.Application.LogSets.Queries.GetLogSetQuery;
using FitnessApp.Application.Programs.Commands.CreateProgram;
using FitnessApp.Application.Programs.Commands.CreateProgram.ProgramFactory;
using FitnessApp.Application.Programs.Commands.RemoveProgram;
using FitnessApp.Application.Programs.Commands.UpdateProgram;
using FitnessApp.Application.Programs.Queries.GetProgram;
using FitnessApp.Application.Programs.Queries.GetProgramList;
using FitnessApp.Application.SetLogs.Commands.CreateSetLogCommand.SetLogFactory;
using FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise;
using FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise.WorkoutExerciseFactory;
using FitnessApp.Application.WorkoutExercises.Commands.RemoveWorkoutExercise;
using FitnessApp.Application.WorkoutExercises.Commands.UpdateWorkoutExercise;
using FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExercise;
using FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExerciseList;
using FitnessApp.Application.WorkoutLogs.Commands.CreateWorkoutLog;
using FitnessApp.Application.WorkoutLogs.Commands.CreateWorkoutLog.WorkoutLogFactory;
using FitnessApp.Application.WorkoutLogs.Queries.GetWorkoutLog;
using FitnessApp.Application.WorkoutLogs.Queries.GetWorkoutLogList;
using FitnessApp.Application.Workouts.Commands.CreateWorkout;
using FitnessApp.Application.Workouts.Commands.CreateWorkout.WorkoutFactory;
using FitnessApp.Application.Workouts.Commands.RemoveWorkout;
using FitnessApp.Application.Workouts.Commands.UpdateWorkout;
using FitnessApp.Application.Workouts.Queries.GetWorkout;
using FitnessApp.Application.Workouts.Queries.GetWorkoutList;
using FitnessApp.Application.Workouts.Queries.GetWorkoutListByProgramId;
using Microsoft.Extensions.DependencyInjection;

namespace FitnessApp.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            AddExerciseServices(services);

            AddProgramServices(services);

            AddWorkoutExerciseServices(services);

            AddWorkoutServices(services);

            AddWorkoutLogServices(services);

            AddLogSetServices(services);

            return services;
        }

        private static IServiceCollection AddExerciseServices(this IServiceCollection services)
        {
            services.AddScoped<IGetExerciseListQuery, GetExerciseListQuery>();
            services.AddScoped<IGetExerciseQuery, GetExerciseQuery>();
            services.AddScoped<IExerciseFactory, ExerciseFactory>();
            services.AddScoped<ICreateExerciseCommand, CreateExerciseCommand>();
            services.AddScoped<IRemoveExerciseCommand, RemoveExerciseCommand>();

            return services;
        }

        private static IServiceCollection AddProgramServices(this IServiceCollection services)
        {
            services.AddScoped<IGetProgramListQuery, GetProgramListQuery>();
            services.AddScoped<IGetProgramQuery, GetProgramQuery>();
            services.AddScoped<IProgramFactory, ProgramFactory>();
            services.AddScoped<ICreateProgramCommand, CreateProgramCommand>();
            services.AddScoped<IRemoveProgramCommand, RemoveProgramCommand>();
            services.AddScoped<IUpdateProgramCommand, UpdateProgramCommand>();

            return services;
        }

        private static IServiceCollection AddWorkoutExerciseServices(this IServiceCollection services)
        {
            services.AddScoped<IGetWorkoutExerciseListQuery, GetWorkoutExerciseListQuery>();
            services.AddScoped<IGetWorkoutExerciseQuery, GetWorkoutExerciseQuery>();
            services.AddScoped<IWorkoutExerciseFactory, WorkoutExerciseFactory>();
            services.AddScoped<ICreateWorkoutExerciseCommand, CreateWorkoutExerciseCommand>();
            services.AddScoped<IRemoveWorkoutExerciseCommand, RemoveWorkoutExerciseCommand>();
            services.AddScoped<IUpdateWorkoutExerciseCommand, UpdateWorkoutExerciseCommand>();

            return services;
        }

        private static IServiceCollection AddWorkoutServices(this IServiceCollection services)
        {
            services.AddScoped<IGetWorkoutListQuery, GetWorkoutListQuery>();
            services.AddScoped<IGetWorkoutListByProgramIdQuery, GetWorkoutListByProgramIdQuery>();
            services.AddScoped<IGetWorkoutQuery, GetWorkoutQuery>();
            services.AddScoped<IWorkoutFactory, WorkoutFactory>();
            services.AddScoped<ICreateWorkoutCommand, CreateWorkoutCommand>();
            services.AddScoped<IRemoveWorkoutCommand, RemoveWorkoutCommand>();
            services.AddScoped<IUpdateWorkoutCommand, UpdateWorkoutCommand>();

            return services;
        }

        private static IServiceCollection AddWorkoutLogServices(this IServiceCollection services)
        {
            services.AddScoped<IGetWorkoutLogListQuery, GetWorkoutLogListQuery>();
            services.AddScoped<IGetWorkoutLogQuery, GetWorkoutLogQuery>();
            services.AddScoped<IWorkoutLogFactory, WorkoutLogFactory>();
            services.AddScoped<ICreateWorkoutLogCommand, CreateWorkoutLogCommand>();

            return services;
        }

        private static IServiceCollection AddLogSetServices(this IServiceCollection services)
        {
            services.AddScoped<IGetLogSetListQuery, GetLogSetListQuery>();
            services.AddScoped<IGetLogSetQuery, GetLogSetQuery>();
            services.AddScoped<ISetLogFactory, SetLogFactory>();
            services.AddScoped<ICreateSetLogCommand, CreateSetLogCommand>();

            return services;
        }
    }
}
