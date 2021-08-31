using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class UserSkills
    {
        public string UserSkillsId { get; set; }
        public string Username { get; set; }
        public int skillId { get; set; }
        public int skillLevelId { get; set; }
    }
}
