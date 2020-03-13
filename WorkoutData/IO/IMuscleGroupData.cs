using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutData.Models;

namespace WorkoutData.IO
{
    public interface IMuscleGroupData
    {
        List<string> GetTodaysMuscles();
        Task<List<string>> GetTodaysMusclesAsync();
        Task<List<string>> GetTodaysMuscles2Async();
        Task<DayProgram> GetDayProgramAsync();

    }
}