using FitnessApp.Application.Interfaces;

namespace FitnessApp.Application.Programs.Queries.GetProgram
{
    public class GetProgramQuery : IGetProgramQuery
    {
        private readonly IDatabaseService _database;

        public GetProgramQuery(IDatabaseService database)
        {
            _database = database;
        }

        public ProgramModel Execute(int id)
        {
            var program = _database.Programs
                .Where(p => p.Id.Equals(id))
                .Select(p => new ProgramModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                })
                .Single();

            return program;
        }
    }
}
