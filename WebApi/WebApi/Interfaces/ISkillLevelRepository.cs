using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface ISkillLevelRepository
    {
        Task<IEnumerable<SkillLevel>> GetSkillLevels();
        Task<SkillLevel> GetSkillLevel(string id);
        Task CreateSkillLevel(SkillLevel skillLevel);
        Task UpdateSkillLevel(SkillLevel skillLevel);
        Task DeleteSkillLevel(string id);
    }
}
