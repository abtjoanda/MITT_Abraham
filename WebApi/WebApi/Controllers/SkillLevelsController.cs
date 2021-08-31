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
    }
}
