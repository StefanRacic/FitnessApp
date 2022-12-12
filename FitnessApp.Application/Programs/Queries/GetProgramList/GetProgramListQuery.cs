using FitnessApp.Application.Interfaces;

namespace FitnessApp.Application.Programs.Queries.GetProgramList
{
    public class GetProgramListQuery
        : IGetProgramListQuery
    {
        private readonly IDatabaseService _context;

        public GetProgramListQuery(IDatabaseService context)
        {
            _context = context;
        }

        public List<ProgramListItemModel> Execute()
        {
            var programs = _context.Programs
                .Select(p => new ProgramListItemModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description
                });

            return programs.ToList();
        }
    }
}
