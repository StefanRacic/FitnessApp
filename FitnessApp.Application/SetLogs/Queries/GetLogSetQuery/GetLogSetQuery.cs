using FitnessApp.Application.Interfaces.UnitOfWork;
using Microsoft.Extensions.Logging;

namespace FitnessApp.Application.LogSets.Queries.GetLogSetQuery
{
    public class GetLogSetQuery : IGetLogSetQuery
    {
        private readonly ILogger<GetLogSetQuery> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public GetLogSetQuery(
            ILogger<GetLogSetQuery> logger,
            IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<LogSetModel> Execute(int id)
        {
            var logSet = await _unitOfWork
                .SetLogRepository
                .GetAsync(ls => ls.Id == id);

            if (logSet is null)
                throw new Exception();

            return new LogSetModel
            {
                Id = logSet.Id,
                Reps = logSet.Reps,
                Weight = logSet.Weight
            };
        }
    }
}
