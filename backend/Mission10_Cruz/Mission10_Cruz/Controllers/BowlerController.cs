using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10_Cruz.Data;
using Mission10_Cruz.Models;

namespace Mission10_Cruz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlerCrewController : ControllerBase
    {
        private BowlingLeagueContext _bowlerContext;

        public BowlerCrewController(BowlingLeagueContext temp) 
        { 
            _bowlerContext = temp;
        }

        [HttpGet(Name = "GetBowlingCrew")]
        public IEnumerable<Bowler> Get()
        {
            // This is the informatoion about the bowlers 
            var bowlerList = _bowlerContext.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team != null && (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))  // Null check for Team
                .ToList();

            return bowlerList;
        }

    }
}