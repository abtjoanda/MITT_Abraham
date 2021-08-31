using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillLevelsController : ControllerBase
    {
        private readonly ISkillLevelRepository skillLevelRepository;
        public SkillLevelsController(ISkillLevelRepository skillLevelRepository)
        {
            this.skillLevelRepository = skillLevelRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetSkillLevels()
        {
            return Ok(await skillLevelRepository.GetSkillLevels());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<SkillLevel>> GetSkillLevel(int id)
        {
            var result = await skillLevelRepository.GetSkillLevel(id);
            if (result == null)
                return NotFound();

            return result;
        }

        [HttpPost]
        public async Task<ActionResult<SkillLevel>> CreateSkillLevel(SkillLevel skillLevel)
        {
            if (skillLevel == null)
                return BadRequest();

            var createdSkillLevel = await skillLevelRepository.CreateSkillLevel(skillLevel);

            return CreatedAtAction(nameof(GetSkillLevel), new { id = createdSkillLevel.SkillLevelId }, createdSkillLevel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<SkillLevel>> UpdateSkillLevel(int id, SkillLevel skillLevel)
        {
            if (skillLevel == null)
                return BadRequest();

            var existingSkillLevel = await skillLevelRepository.GetSkillLevel(id);

            if (existingSkillLevel == null)
                return NotFound();

            await skillLevelRepository.UpdateSkillLevel(id, skillLevel);

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteSkillLevel(int id)
        {
            var existingSkillLevel = await skillLevelRepository.GetSkillLevel(id);

            if (id == 0)
                return NotFound();
            
            await skillLevelRepository.DeleteSkillLevel(id);

            return NoContent();
        }
    }
}
