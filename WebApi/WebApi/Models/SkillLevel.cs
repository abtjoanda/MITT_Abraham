using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class SkillLevel
    {
        [Required]
        public int SkillLevelId { get; set; }
        [Required]
        public string SkillLevelName { get; set; }
    }
}
