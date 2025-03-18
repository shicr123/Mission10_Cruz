using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10_Cruz.Data;

namespace Mission10_Cruz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlerCrewController : ControllerBase
    {
        private BowlerContext _bowlerContext;

        public BowlerCrewController(BowlerContext temp) 
        { 
            _bowlerContext = temp;
        }

        [HttpGet(Name = "GetBowlingCrew")]
        public IEnumerable<BowlingCrew> Get()
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