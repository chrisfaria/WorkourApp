using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WorkoutData.Models;

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

        public async Task<List<string>> GetTodaysMusclesAsync()
        {
            List<string> muscleGroups = new List<string>();
            muscleGroups.Add("Biceps1");
            muscleGroups.Add("Triceps1");

            // In the Real World, we would actually do something...
            // For this example, we're just going to (asynchronously) wait 100ms.
            await Task.Delay(3000);

            return muscleGroups;
        }

        public async Task<List<string>> GetTodaysMuscles2Async()
        {
            List<string> muscleGroups = new List<string>();
            muscleGroups.Add("Biceps2");
            muscleGroups.Add("Triceps2");

            // In the Real World, we would actually do something...
            // For this example, we're just going to (asynchronously) wait 100ms.
            await Task.Delay(6000);

            return muscleGroups;
        }

        public async Task<DayProgram> GetDayProgramAsync()
        {
            await Task.Delay(2000);

            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(new Exercise { name = "squat", weight = 200, sets = 4, reps = 7 });
            exercises.Add(new Exercise { name = "bench", weight = 150, sets = 4, reps = 13 });
            exercises.Add(new Exercise { name = "crunch", weight = 0, sets = 5, reps = 25 });

            DayProgram dp = new DayProgram { day = "wed", exercises = exercises };

            return dp;
        }
    }
}
