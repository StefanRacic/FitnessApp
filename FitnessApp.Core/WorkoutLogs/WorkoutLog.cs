using FitnessApp.Domain.Common;
using FitnessApp.Domain.SetLogs;
using FitnessApp.Domain.Workouts;

namespace FitnessApp.Domain.WorkoutLogs
{
    public class WorkoutLog : IEntity
    {
        private TimeSpan _workoutDuration;
        public int Id { get; set; }
        public string Note { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan WorkoutDuration
        {
            get { return _workoutDuration; }
            set
            {
                _workoutDuration = value;
                UpdateWorkoutDuration();
            }
        }
        public Workout Workout { get; set; }
        public int WorkoutId { get; set; }
        private void UpdateWorkoutDuration()
        {
            _workoutDuration = EndDate.Subtract(StartDate);
        }
        public ICollection<SetLog> SetLogs { get; set; }
    }
}
