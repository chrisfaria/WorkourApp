using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WorkoutCoreMVC.Models;
using WorkoutData.IO;
using WorkoutData.Models;

namespace WorkoutCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IMuscleGroupData _mgdata;
        private DayProgram dp;

        public HomeController(ILogger<HomeController> logger, IMuscleGroupData mgdata)
        {
            _logger = logger;
            _mgdata = mgdata;
            dp = new DayProgram();
        }

        public async Task<IActionResult> IndexAsync()
        {
            // user from command line: "dotnet watch run" to run this. On rebuild it will save it. You must still refresh the browser
            // Can fix the browser to auto refresh: https://weblog.west-wind.com/posts/2019/May/18/Live-Reloading-Server-Side-ASPNET-Core-Apps

            var dp = await _mgdata.GetDayProgramAsync();

            // not sent to the View through "@model"
            List<string> workouts = new List<string>();
            workouts.Add("Biceps2");
            workouts.Add("Triceps2");

            return View(dp);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
