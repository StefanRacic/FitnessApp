using FitnessApp.Domain.Common;

namespace FitnessApp.Domain.Exercises
{
    public class Exercise : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
