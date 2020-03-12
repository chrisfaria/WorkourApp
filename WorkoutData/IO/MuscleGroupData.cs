using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutData.IO
{
    public class MuscleGroupData : IMuscleGroupData
    {
        private List<string> muscleGroupsToday = new List<string>();

        public MuscleGroupData()
        {

        }

        public List<string> GetTodaysMuscles()
        {
            muscleGroupsToday.Add("Biceps");
            muscleGroupsToday.Add("Triceps");
            muscleGroupsToday.Add("Legs");

            return muscleGroupsToday;
        }
    }
}
