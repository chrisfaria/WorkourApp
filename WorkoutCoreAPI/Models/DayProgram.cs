using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutCoreAPI.Models
{
    public class DayProgram
    {
        [Required]
        [StringLength(3)]
        public string day { get; set; }
        
        public List<string> exercises { get; set; }
        
        [Required]
        [Range(1,10)]
        public int weeks { get; set; }
    }
}
