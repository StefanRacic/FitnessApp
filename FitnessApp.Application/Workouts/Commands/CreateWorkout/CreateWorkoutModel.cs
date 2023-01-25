﻿using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Application.Workouts.Commands.CreateWorkout
{
    public class CreateWorkoutModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }
        public int ProgramId { get; set; }
    }
}
