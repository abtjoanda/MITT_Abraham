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
        Task<SkillLevel> GetSkillLevel(int id);
        Task<SkillLevel> CreateSkillLevel(SkillLevel skillLevel);
        Task UpdateSkillLevel(int id, SkillLevel skillLevel);
        Task DeleteSkillLevel(int id);
    }
}
