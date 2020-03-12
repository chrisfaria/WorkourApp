using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutData.Models
{
    public class DayProgram
    {
        public string day { get; set; }
        public List<Exercise> exercises { get; set; }
    }
}
