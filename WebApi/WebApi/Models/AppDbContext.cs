using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<SkillLevel> SkillLevel { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<UserSkills> UserSkills { get; set; }
        public DbSet<Skill> Skill { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>().HasKey(k => k.Username);
            modelBuilder.Entity<UserProfile>().HasNoKey();
        }
    }
}
