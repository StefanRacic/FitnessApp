using FitnessApp.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FitnessApp.Infrastucture.Persistence
{
    public class DatabaseInitialiser
    {
        private readonly ILogger<DatabaseInitialiser> _logger;
        private readonly DatabaseService _context;

        public DatabaseInitialiser(
            ILogger<DatabaseInitialiser> logger,
            DatabaseService context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task InitialAsync()
        {
            try
            {
                if (_context.Database.IsSqlServer())
                    await _context.Database.MigrateAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while initialising the database.");
                throw;
            }
        }
    }
}
