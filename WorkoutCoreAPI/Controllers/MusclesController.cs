using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkoutData.IO;

namespace WorkoutCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusclesController : ControllerBase
    {
        private IMuscleGroupData _muscleGroupData;
        public MusclesController(IMuscleGroupData muscleGroupData)
        {
            _muscleGroupData = muscleGroupData;
        }

        // GET: api/Muscles
        [HttpGet]
        [Route("")]
        public IEnumerable<string> GetAll()
        {
            return _muscleGroupData.GetTodaysMuscles();
        }

        // GET: api/Muscles/Sat
        [HttpGet]
        [Route("date/{day}")]
        public IEnumerable<string> GetForDate(string day)
        {
            string[] musclesForDate;

            if (day.ToLower() == "today")
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
