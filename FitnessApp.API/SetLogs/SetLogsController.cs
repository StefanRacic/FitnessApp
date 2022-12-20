using FitnessApp.Application.LogSets.Commands.CreateLogSetCommand;
using FitnessApp.Application.LogSets.Queries.GetLogSetListQuery;
using FitnessApp.Application.LogSets.Queries.GetLogSetQuery;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.API.SetLogs
{
    [ApiController]
    [Route("[controller]")]
    public class SetLogsController : ControllerBase
    {
        private readonly ILogger<SetLogsController> _logger;
        private readonly IGetLogSetListQuery _listQuery;
        private readonly IGetLogSetQuery _itemQuery;
        private readonly ICreateSetLogCommand _command;

        public SetLogsController(
            ILogger<SetLogsController> logger,
            IGetLogSetListQuery listQuery,
            IGetLogSetQuery itemQuery,
            ICreateSetLogCommand command)
        {
            _logger = logger;
            _listQuery = listQuery;
            _itemQuery = itemQuery;
            _command = command;
        }

        [HttpGet]
        [Route("GetAllSetLogs")]
        public async Task<IEnumerable<LogSetListItemModel>> GetAll(int workoutLogId)
            => await _listQuery.Execute(workoutLogId);

        [HttpGet]
        [Route("GetSetLog")]
        public async Task<LogSetModel> Get(int id)
            => await _itemQuery.Execute(id);

        [HttpPost]
        [Route("CreateSetLog")]
        public async Task Create(CreateSetLogModel model)
            => await _command.Execute(model);
    }
}
