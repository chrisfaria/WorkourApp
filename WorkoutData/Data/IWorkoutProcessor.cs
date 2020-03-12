using System.Collections.Generic;
using WorkoutData.Models;

namespace WorkoutData.Data
{
    public interface IWorkoutProcessor
    {
        List<Program> GetWorkout(string name);
    }
}