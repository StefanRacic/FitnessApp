using FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExerciseList;
using FitnessApp.Application.Workouts.Commands.CreateWorkout;
using FitnessApp.Application.Workouts.Commands.RemoveWorkout;
using FitnessApp.Application.Workouts.Queries.GetWorkout;
using FitnessApp.Application.Workouts.Queries.GetWorkoutList;
using FitnessApp.Application.Workouts.Queries.GetWorkoutListByProgramId;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.API.Workouts
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkoutsController : ControllerBase
    {
        private readonly ILogger<WorkoutsController> _logger;
        private readonly IGetWorkoutListQuery _listQuery;
        private readonly IGetWorkoutQuery _itemQuery;
        private readonly ICreateWorkoutCommand _command;
        private readonly IRemoveWorkoutCommand _removeCommand;
        private readonly IGetWorkoutExerciseListQuery _workoutExercisesQuery;

        public WorkoutsController(
            ILogger<WorkoutsController> logger,
            IGetWorkoutListQuery listQuery,
            IGetWorkoutQuery itemQuery,
            ICreateWorkoutCommand command,
            IRemoveWorkoutCommand removeCommand,
            IGetWorkoutExerciseListQuery workoutExercisesQuery)
        {
            _logger = logger;
            _listQuery = listQuery;
            _itemQuery = itemQuery;
            _command = command;
            _removeCommand = removeCommand;
            _workoutExercisesQuery = workoutExercisesQuery;
        }

        [HttpGet]
        public async Task<IEnumerable<WorkoutListItemModel>> GetAllAsync()
            => await _listQuery.Execute();

        [HttpGet("{id}")]
        public async Task<WorkoutModel> Get(int id)
            => await _itemQuery.Execute(id);

        [HttpGet("{id}/workoutExercises")]
        public async Task<IEnumerable<WorkoutExerciseListModel>> GetAll(int id)
            => await _workoutExercisesQuery.Execute(id);

        [HttpPost]
        public async Task<WorkoutListItemByProgramIdModel> CreateAsync(CreateWorkoutModel model)
            => await _command.Execute(model);

        [HttpDelete("{id}")]
        public async Task Remove(int id)
           => await _removeCommand.Execute(id);
    }
}
