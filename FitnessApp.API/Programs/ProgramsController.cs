using FitnessApp.Application.Programs.Commands.CreateProgram;
using FitnessApp.Application.Programs.Queries.GetProgram;
using FitnessApp.Application.Programs.Queries.GetProgramList;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.API.Programs
{
    [ApiController]
    [Route("[controller]")]
    public class ProgramsController : ControllerBase
    {
        private ILogger<ProgramsController> _logger;
        private readonly IGetProgramListQuery _listQuery;
        private readonly IGetProgramQuery _itemQuery;
        private readonly ICreateProgramCommand _command;

        public ProgramsController(
            ILogger<ProgramsController> logger,
            IGetProgramListQuery listQuery,
            IGetProgramQuery itemQuery,
            ICreateProgramCommand command)
        {
            _logger = logger;
            _listQuery = listQuery;
            _itemQuery = itemQuery;
            _command = command;
        }

        [HttpGet]
        [Route("GetAllPrograms")]
        public async Task<IEnumerable<ProgramListItemModel>> GetAll()
            => await _listQuery.Execute();

        [HttpGet]
        [Route("GetProgram")]
        public async Task<ProgramModel> Get(int id)
            => await _itemQuery.Execute(id);

        [HttpPost]
        [Route("CreateProgram")]
        public async Task Create(CreateProgramModel model)
            => await _command.Execute(model);
    }
}