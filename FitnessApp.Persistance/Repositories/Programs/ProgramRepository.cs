using FitnessApp.Application.Interfaces.Repositories;
using FitnessApp.Domain.Programs;

namespace FitnessApp.Persistence.Repositories.Programs
{
    public class ProgramRepository : GenericRepository<Program>, IProgramRepository
    {
        public ProgramRepository(
            DatabaseService database)
            : base(database)
        {
        }
    }
}
