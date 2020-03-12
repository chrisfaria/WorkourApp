using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutData.Models
{
    public class Exercise
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int sets { get; set; }
        public int reps { get; set; }
    }
}
