using FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise;
using FitnessApp.Application.WorkoutExercises.Commands.RemoveWorkoutExercise;
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
        private readonly IRemoveWorkoutExerciseCommand _removeCommand;

        public WorkoutExercisesController(
            ILogger<WorkoutExercisesController> logger,
            IGetWorkoutExerciseListQuery listQuery,
            IGetWorkoutExerciseQuery itemQuery,
            ICreateWorkoutExerciseCommand command,
            IRemoveWorkoutExerciseCommand removeCommand)
        {
            _logger = logger;
            _listQuery = listQuery;
            _itemQuery = itemQuery;
            _command = command;
            _removeCommand = removeCommand;
        }

        [HttpGet]
        public async Task<IEnumerable<WorkoutExerciseListModel>> GetAll(int workoutId)
            => await _listQuery.Execute(workoutId);

        [HttpGet]
        public async Task<WorkoutExerciseModel> Get(int id)
            => await _itemQuery.Execute(id);

        [HttpPost]
        public async Task<WorkoutExerciseListModel> Create(CreateWorkoutExerciseModel model)
            => await _command.Execute(model);

        [HttpDelete]
        public async Task Remove(int id)
          => await _removeCommand.Execute(id);
    }
}
