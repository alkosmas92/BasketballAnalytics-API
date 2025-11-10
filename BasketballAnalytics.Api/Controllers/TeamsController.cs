using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasketballAnalytics.Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BasketballAnalytics.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BasketballAnalytics.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamsController : ControllerBase
    {
        private readonly IApplicationDbContext _context;

        public TeamsController(IApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Team>>> GetTeams()
        {
            return await _context.Teams.ToListAsync();
        }
    }
}