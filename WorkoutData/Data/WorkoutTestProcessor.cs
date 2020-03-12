﻿using System;
using System.Collections.Generic;
using System.Text;
using WorkoutData.Models;

namespace WorkoutData.Data
{
    public class WorkoutTestProcessor : IWorkoutProcessor
    {
        public List<Program> GetWorkout(string name)
        {
            List<Workout> workouts = new List<Workout>();
            List<Program> programs = new List<Program>();

            List<Exercise> exercises1 = new List<Exercise>();
            exercises1.Add(new Exercise { name = "Squat", weight = 100, sets = 4, reps = 10 });
            exercises1.Add(new Exercise { name = "Calf Raise", weight = 200, sets = 4, reps = 13 });
            exercises1.Add(new Exercise { name = "Leg Extension", weight = 300, sets = 5, reps = 10 });
            programs.Add(new Program { day = "Mon", exercises = exercises1 });

            List<Exercise> exercises2 = new List<Exercise>();
            exercises2.Add(new Exercise { name = "Bench Press", weight = 200, sets = 4, reps = 7 });
            exercises2.Add(new Exercise { name = "Pull Up", weight = 0, sets = 4, reps = 6 });
            exercises2.Add(new Exercise { name = "Cable Flys", weight = 50, sets = 5, reps = 13 });
            programs.Add(new Program { day = "Wed", exercises = exercises2 });

            return programs;
        }
    }
}
