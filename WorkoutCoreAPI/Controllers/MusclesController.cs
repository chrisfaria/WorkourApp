using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WorkoutData.IO;

namespace WorkoutCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusclesController : ControllerBase
    {
        private IMuscleGroupData _muscleGroupData;
        private IConfiguration _configuration;

        public MusclesController(IMuscleGroupData muscleGroupData, IConfiguration configuration)
        {
            _muscleGroupData = muscleGroupData;
            _configuration = configuration;
        }

        // GET: api/Muscles
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<string>>> GetAll()
        {
            List<string> output = _muscleGroupData.GetTodaysMuscles();

            var outputTaskList = new List<Task<List<string>>>();
            outputTaskList.Add(_muscleGroupData.GetTodaysMusclesAsync());
            outputTaskList.Add(_muscleGroupData.GetTodaysMuscles2Async());

            // EX. ASYNC/AWAIT
            Task.WaitAll(outputTaskList.ToArray());

            var result = outputTaskList.Select(t => t.Result)
                                       .SelectMany(r => r)
                                       .ToList();

            output.AddRange(result);

            return Ok(output);
        }

        // GET: api/Muscles/date/sat
        [HttpGet]
        [Route("date/{day}")]
        public IEnumerable<string> GetForDate(string day)
        {
            string[] musclesForDate;

            // EX. CONFIGURATION
            var mode = _configuration.GetConnectionString("mode");

            if (day.ToLower() == "today" && mode == "todayallowed")
            {
                musclesForDate = new[] { "tummy", "hips" };
            }
            else
            {
                musclesForDate = new[] { "date", day };
            }

            return musclesForDate;
        }

        // GET: api/Muscles/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Muscles
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Muscles/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
