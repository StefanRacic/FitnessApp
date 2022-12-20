using FitnessApp.Application.Interfaces.Repositories;
using FitnessApp.Domain.SetLogs;

namespace FitnessApp.Persistence.Repositories.SetLogs
{
    public class SetLogRepository : GenericRepository<SetLog>, ISetLogRepository
    {
        public SetLogRepository(
            DatabaseService database)
            : base(database)
        {
        }
    }
}
