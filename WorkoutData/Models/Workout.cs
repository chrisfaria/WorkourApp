using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutData.Models
{
    class Workout
    {
        public string name { get; set; }
        public List<DayProgram> dayprograms { get; set; }
    }
}
