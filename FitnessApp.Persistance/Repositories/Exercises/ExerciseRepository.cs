using FitnessApp.Application.Interfaces.Repositories;
using FitnessApp.Domain.Exercises;

namespace FitnessApp.Persistence.Repositories.Exercises
{
    public class ExerciseRepository : GenericRepository<Exercise>, IExerciseRepository
    {
        public ExerciseRepository(DatabaseService database)
            : base(database)
        {
        }
    }
}
