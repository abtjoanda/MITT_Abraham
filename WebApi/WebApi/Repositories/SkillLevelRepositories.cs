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
        public Task CreateSkillLevel(SkillLevel skillLevel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSkillLevel(string id)
        {
            throw new NotImplementedException();
        }

        public Task<SkillLevel> GetSkillLevel(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SkillLevel>> GetSkillLevels()
        {
            return await appDbContext.SkillLevel.ToListAsync();
        }

        public Task UpdateSkillLevel(SkillLevel skillLevel)
        {
            throw new NotImplementedException();
        }
    }
}
