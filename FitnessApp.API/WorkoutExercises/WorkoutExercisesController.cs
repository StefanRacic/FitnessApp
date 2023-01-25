using FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise;
using FitnessApp.Application.WorkoutExercises.Commands.RemoveWorkoutExercise;
using FitnessApp.Application.WorkoutExercises.Commands.UpdateWorkoutExercise;
using FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExercise;
using FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExerciseList;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.API.WorkoutExercises
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkoutExercisesController : ControllerBase
    {
        private readonly ILogger<WorkoutExercisesController> _logger;
        private readonly IGetWorkoutExerciseListQuery _listQuery;
        private readonly IGetWorkoutExerciseQuery _itemQuery;
        private readonly ICreateWorkoutExerciseCommand _command;
        private readonly IRemoveWorkoutExerciseCommand _removeCommand;
        private readonly IUpdateWorkoutExerciseCommand _updateCommand;

        public WorkoutExercisesController(
            ILogger<WorkoutExercisesController> logger,
            IGetWorkoutExerciseListQuery listQuery,
            IGetWorkoutExerciseQuery itemQuery,
            ICreateWorkoutExerciseCommand command,
            IRemoveWorkoutExerciseCommand removeCommand,
            IUpdateWorkoutExerciseCommand updateCommand)
        {
            _logger = logger;
            _listQuery = listQuery;
            _itemQuery = itemQuery;
            _command = command;
            _removeCommand = removeCommand;
            _updateCommand = updateCommand;
        }

        [HttpGet("{id}")]
        public async Task<WorkoutExerciseModel> Get(int id)
            => await _itemQuery.Execute(id);

        [HttpPost]
        public async Task<WorkoutExerciseListModel> Create(CreateWorkoutExerciseModel model)
            => await _command.Execute(model);

        [HttpDelete("{id}")]
        public async Task Remove(int id)
          => await _removeCommand.Execute(id);

        [HttpPut]
        public async Task<WorkoutExerciseModel> Update(UpdateWorkoutExerciseModel model)
            => await _updateCommand.Execute(model);
    }
}
