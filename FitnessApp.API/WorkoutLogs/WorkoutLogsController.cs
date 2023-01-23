using FitnessApp.Application.WorkoutLogs.Commands.CreateWorkoutLog;
using FitnessApp.Application.WorkoutLogs.Queries.GetWorkoutLog;
using FitnessApp.Application.WorkoutLogs.Queries.GetWorkoutLogList;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.API.WorkoutLogs
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WorkoutLogsController : ControllerBase
    {
        private readonly ILogger<WorkoutLogsController> _logger;
        private readonly IGetWorkoutLogListQuery _listQuery;
        private readonly IGetWorkoutLogQuery _itemQuery;
        private readonly ICreateWorkoutLogCommand _command;

        public WorkoutLogsController(
            ILogger<WorkoutLogsController> logger,
            IGetWorkoutLogListQuery listQuery,
            IGetWorkoutLogQuery itemQuery,
            ICreateWorkoutLogCommand command)
        {
            _logger = logger;
            _listQuery = listQuery;
            _itemQuery = itemQuery;
            _command = command;
        }

        [HttpGet]
        public async Task<IEnumerable<WorkoutLogListItemModel>> GetAll()
           => await _listQuery.Execute();

        [HttpGet("{id}")]
        public async Task<WorkoutLogModel> Get(int id)
            => await _itemQuery.Execute(id);

        [HttpPost]
        public async Task Create(CreateWorkoutLogModel model)
            => await _command.Execute(model);
    }
}
