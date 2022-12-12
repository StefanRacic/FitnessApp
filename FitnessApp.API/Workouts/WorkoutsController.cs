using FitnessApp.Application.Workouts.Commands.CreateWorkout;
using FitnessApp.Application.Workouts.Queries.GetWorkout;
using FitnessApp.Application.Workouts.Queries.GetWorkoutList;
using FitnessApp.Application.Workouts.Queries.GetWorkoutListByProgramId;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.API.Workouts
{
    [ApiController]
    [Route("[controller]")]
    public class WorkoutsController : ControllerBase
    {
        private readonly ILogger<WorkoutsController> _logger;
        private readonly IGetWorkoutListQuery _listQuery;
        private readonly IGetWorkoutListByProgramIdQuery _listByProgramIdQuery;
        private readonly IGetWorkoutQuery _itemQuery;
        private readonly ICreateWorkoutCommand _command;

        public WorkoutsController(
            ILogger<WorkoutsController> logger,
            IGetWorkoutListQuery listQuery,
            IGetWorkoutListByProgramIdQuery listByProgramIdQuery,
            IGetWorkoutQuery itemQuery,
            ICreateWorkoutCommand command)
        {
            _logger = logger;
            _listQuery = listQuery;
            _listByProgramIdQuery = listByProgramIdQuery;
            _itemQuery = itemQuery;
            _command = command;
        }

        [HttpGet]
        [Route("GetAllWorkouts")]
        public IEnumerable<WorkoutListItemModel> GetAll()
            => _listQuery.Execute();

        [HttpGet]
        [Route("GetWorkout")]
        public WorkoutModel Get(int id)
            => _itemQuery.Execute(id);

        [HttpGet]
        [Route("GetWorkoutsByProgramId")]
        public IEnumerable<WorkoutListItemByProgramIdModel> GetAllByProgramId(int programId)
            => _listByProgramIdQuery.Execute(programId);

        [HttpPost]
        [Route("CreateWorkout")]
        public void Create(CreateWorkoutModel model)
            => _command.Execute(model);


    }
}
