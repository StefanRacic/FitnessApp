using FitnessApp.Domain.Common;
using FitnessApp.Domain.Workouts;

namespace FitnessApp.Domain.Programs
{
    public class Program : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Workout> Workouts { get; set; }
    }
}
