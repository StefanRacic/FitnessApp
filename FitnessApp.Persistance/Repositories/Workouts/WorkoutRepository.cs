using FitnessApp.Application.Interfaces.Repositories;
using FitnessApp.Domain.Workouts;

namespace FitnessApp.Persistence.Repositories.Workouts
{
    public class WorkoutRepository
        : GenericRepository<Workout>, IWorkoutRepository
    {
        public WorkoutRepository(DatabaseService database)
            : base(database)
        {
        }
    }
}
