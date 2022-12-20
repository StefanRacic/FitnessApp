using FitnessApp.Application.Interfaces.Repositories;
using FitnessApp.Domain.WorkoutExercises;

namespace FitnessApp.Persistence.Repositories.WorkoutExercises
{
    public class WorkoutExerciseRepository : GenericRepository<WorkoutExercise>, IWorkoutExerciseRepository
    {
        public WorkoutExerciseRepository(DatabaseService database)
            : base(database)
        {
        }
    }
}
