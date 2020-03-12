using System;
using System.Collections.Generic;
using System.Text;
using WorkoutData.DataLayer;
using WorkoutData.Models;

namespace WorkoutData.IO
{
    class WorkoutData
    {

        public List<DayProgram> GetWorkout(string DayProgramName, string day)
        {
            return XmlProcessor.GetWorkout(DayProgramName, day);
        }
    }
}
