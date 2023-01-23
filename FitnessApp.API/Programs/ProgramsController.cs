using FitnessApp.Application.Programs.Commands.CreateProgram;
using FitnessApp.Application.Programs.Commands.RemoveProgram;
using FitnessApp.Application.Programs.Queries.GetProgram;
using FitnessApp.Application.Programs.Queries.GetProgramList;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.API.Programs
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProgramsController : ControllerBase
    {
        private ILogger<ProgramsController> _logger;
        private readonly IGetProgramListQuery _listQuery;
        private readonly IGetProgramQuery _itemQuery;
        private readonly ICreateProgramCommand _command;
        private readonly IRemoveProgramCommand _removeCommand;

        public ProgramsController(
            ILogger<ProgramsController> logger,
            IGetProgramListQuery listQuery,
            IGetProgramQuery itemQuery,
            ICreateProgramCommand command,
            IRemoveProgramCommand removeCommand)
        {
            _logger = logger;
            _listQuery = listQuery;
            _itemQuery = itemQuery;
            _command = command;
            _removeCommand = removeCommand;
        }

        [HttpGet]
        public async Task<IEnumerable<ProgramListItemModel>> GetAll()
            => await _listQuery.Execute();

        [HttpGet("{id}")]
        public async Task<ProgramModel> Get(int id)
            => await _itemQuery.Execute(id);

        [HttpPost]
        public async Task<ProgramModel> Create(CreateProgramModel model)
            => await _command.Execute(model);

        [HttpDelete("{id}")]
        public async Task Remove(int id)
            => await _removeCommand.Execute(id);
    }
}