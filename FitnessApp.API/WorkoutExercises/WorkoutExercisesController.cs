using FitnessApp.Application.WorkoutExercises.Commands.CreateWorkoutExercise;
using FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExercise;
using FitnessApp.Application.WorkoutExercises.Queries.GetWorkoutExerciseList;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.API.WorkoutExercises
{
    [ApiController]
    [Route("[controller]")]
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
        [Route("GetAllWorkoutExercisesByWorkoutId")]
        public IEnumerable<WorkoutExerciseListModel> GetAll(int workoutId) => _listQuery.Execute(workoutId);

        [HttpGet]
        [Route("GetWorkoutExercise")]
        public WorkoutExerciseModel Get(int id) => _itemQuery.Execute(id);

        [HttpPost]
        [Route("CreateWorkoutExercise")]
        public void Create(CreateWorkoutExerciseModel model) => _command.Execute(model);
    }
}
