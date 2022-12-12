using FitnessApp.Application.Programs.Commands.CreateProgram;
using FitnessApp.Application.Programs.Queries.GetProgram;
using FitnessApp.Application.Programs.Queries.GetProgramList;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.API.Programs
{
    [ApiController]
    [Route("[controller]")]
    public class ProgramController : ControllerBase
    {
        private ILogger<ProgramController> _logger;
        private readonly IGetProgramListQuery _listQuery;
        private readonly IGetProgramQuery _itemQuery;
        private readonly ICreateProgramCommand _command;

        public ProgramController(
            ILogger<ProgramController> logger,
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
        public IEnumerable<ProgramListItemModel> GetAll() => _listQuery.Execute();

        [HttpGet]
        [Route("GetProgram")]
        public ProgramModel Get(int id) => _itemQuery.Execute(id);

        [HttpPost]
        [Route("CreateProgram")]
        public void Create(CreateProgramModel model) => _command.Execute(model);
    }
}