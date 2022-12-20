using FitnessApp.Application.Interfaces.Repositories;
using FitnessApp.Domain.WorkoutLogs;

namespace FitnessApp.Persistence.Repositories.WorkoutLogs
{
    public class WorkoutLogRepository : GenericRepository<WorkoutLog>, IWorkoutLogRepository
    {
        public WorkoutLogRepository(
            DatabaseService database)
            : base(database)
        {
        }
    }
}
