using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class SkillLevelRepositories : ISkillLevelRepository
    {
        private readonly AppDbContext appDbContext;

        public SkillLevelRepositories(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<SkillLevel> CreateSkillLevel(SkillLevel skillLevel)
        {
            var result = await appDbContext.SkillLevel.AddAsync(skillLevel);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteSkillLevel(int id)
        {
            var result = await appDbContext.SkillLevel.FirstOrDefaultAsync(s => s.SkillLevelId == id);

            if(result != null)
            {
                appDbContext.SkillLevel.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }

        public async Task<SkillLevel> GetSkillLevel(int id)
        {
            return await appDbContext.SkillLevel.FirstOrDefaultAsync(s => s.SkillLevelId == id);
        }

        public async Task<IEnumerable<SkillLevel>> GetSkillLevels()
        {
            return await appDbContext.SkillLevel.ToListAsync();
        }

        public async Task UpdateSkillLevel(int id, SkillLevel skillLevel)
        {
            var result = await appDbContext.SkillLevel.FirstOrDefaultAsync(s => s.SkillLevelId == id);

            if (result != null)
            {
                result.SkillLevelName = skillLevel.SkillLevelName;

                await appDbContext.SaveChangesAsync();
            }
        }
    }
}
