using FitnessApp.Application.Interfaces;
using Microsoft.Extensions.Logging;

namespace FitnessApp.Application.LogSets.Queries.GetLogSetQuery
{
    public class GetLogSetQuery : IGetLogSetQuery
    {
        private readonly ILogger<GetLogSetQuery> _logger;
        private readonly IDatabaseService _database;

        public GetLogSetQuery(
            ILogger<GetLogSetQuery> logger,
            IDatabaseService database)
        {
            _logger = logger;
            _database = database;
        }

        public LogSetModel Execute(int id)
        {
            var logSet = _database.SetLogs.FirstOrDefault(ls => ls.Id == id);

            return new LogSetModel
            {
                Id = logSet.Id,
                Reps = logSet.Reps,
                Weight = logSet.Weight
            };
        }
    }
}
