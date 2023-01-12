using FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise;
using FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExercise;
using FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExerciseList;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.API.WorkoutExercises
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WorkoutExercisesController : ControllerBase
    {
        private readonly ILogger<WorkoutExercisesController> _logger;
        private readonly IGetWorkoutExerciseListQuery _listQuery;
        private readonly IGetWorkoutExerciseQuery _itemQuery;
        private readonly ICreateWorkoutExerciseCommand _command;

        public WorkoutExercisesController(
            ILogger<WorkoutExercisesController> logger,
            IGetWorkoutExerciseListQuery listQuery,
            IGetWorkoutExerciseQuery itemQuery,
            ICreateWorkoutExerciseCommand command)
        {
            _logger = logger;
            _listQuery = listQuery;
            _itemQuery = itemQuery;
            _command = command;
        }

        [HttpGet]
        public async Task<IEnumerable<WorkoutExerciseListModel>> GetAll(int workoutId)
            => await _listQuery.Execute(workoutId);

        [HttpGet]
        public async Task<WorkoutExerciseModel> Get(int id)
            => await _itemQuery.Execute(id);

        [HttpPost]
        public async Task Create(CreateWorkoutExerciseModel model)
            => await _command.Execute(model);
    }
}
