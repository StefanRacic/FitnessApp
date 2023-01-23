using FitnessApp.Application.Exercises.Commands;
using FitnessApp.Application.Exercises.Queries.GetExercise;
using FitnessApp.Application.Exercises.Queries.GetExerciseList;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.API.Exercises
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExercisesController : ControllerBase
    {
        private readonly ILogger<ExercisesController> _logger;
        private readonly IGetExerciseListQuery _listQuery;
        private readonly IGetExerciseQuery _itemQuery;
        private readonly ICreateExerciseCommand _command;
        private readonly IRemoveExerciseCommand _removeCommand;

        public ExercisesController(
            ILogger<ExercisesController> logger,
            IGetExerciseListQuery listQuery,
            IGetExerciseQuery itemQuery,
            ICreateExerciseCommand command,
            IRemoveExerciseCommand removeCommand)
        {
            _logger = logger;
            _listQuery = listQuery;
            _itemQuery = itemQuery;
            _command = command;
            _removeCommand = removeCommand;
        }

        [HttpGet]
        public async Task<IEnumerable<ExerciseListItemModel>> GetAll()
            => await _listQuery.Execute();

        [HttpGet("{id}")]
        public async Task<ExerciseModel> Get(int id)
            => await _itemQuery.ExecuteAsync(id);

        [HttpPost]
        public async Task<ExerciseModel> Create(CreateExerciseModel model)
            => await _command.Execute(model);
        [HttpDelete("{id}")]
        public async Task Remove(int id)
            => await _removeCommand.Execute(id);
    }
}
