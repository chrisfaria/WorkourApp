using System.Collections.Generic;

namespace WorkoutData.IO
{
    public interface IMuscleGroupData
    {
        List<string> GetTodaysMuscles();
    }
}