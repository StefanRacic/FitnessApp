using FitnessApp.Application.Workouts.Commands.CreateWorkout;
using FitnessApp.Application.Workouts.Commands.RemoveWorkout;
using FitnessApp.Application.Workouts.Queries.GetWorkout;
using FitnessApp.Application.Workouts.Queries.GetWorkoutList;
using FitnessApp.Application.Workouts.Queries.GetWorkoutListByProgramId;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.API.Workouts
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WorkoutsController : ControllerBase
    {
        private readonly ILogger<WorkoutsController> _logger;
        private readonly IGetWorkoutListQuery _listQuery;
        private readonly IGetWorkoutListByProgramIdQuery _listByProgramIdQuery;
        private readonly IGetWorkoutQuery _itemQuery;
        private readonly ICreateWorkoutCommand _command;
        private readonly IRemoveWorkoutCommand _removeCommand;

        public WorkoutsController(
            ILogger<WorkoutsController> logger,
            IGetWorkoutListQuery listQuery,
            IGetWorkoutListByProgramIdQuery listByProgramIdQuery,
            IGetWorkoutQuery itemQuery,
            ICreateWorkoutCommand command,
            IRemoveWorkoutCommand removeCommand)
        {
            _logger = logger;
            _listQuery = listQuery;
            _listByProgramIdQuery = listByProgramIdQuery;
            _itemQuery = itemQuery;
            _command = command;
            _removeCommand = removeCommand;
        }

        [HttpGet]
        public async Task<IEnumerable<WorkoutListItemModel>> GetAllAsync()
            => await _listQuery.Execute();

        [HttpGet]
        public async Task<WorkoutModel> Get(int id)
            => await _itemQuery.Execute(id);

        [HttpGet]
        public async Task<IEnumerable<WorkoutListItemByProgramIdModel>> GetAllByProgramIdAsync(int programId)
            => await _listByProgramIdQuery.ExecuteAsync(programId);

        [HttpPost]
        public async Task<WorkoutListItemByProgramIdModel> CreateAsync(CreateWorkoutModel model)
            => await _command.Execute(model);

        [HttpDelete]
        public async Task Remove(int id)
           => await _removeCommand.Execute(id);
    }
}
