using Microsoft.EntityFrameworkCore;

namespace Mission10_Cruz.Data
{
    public class BowlerContext : DbContext
    {
        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options) 
        { 
        }

        // information for bowlers
        public DbSet<BowlingCrew> Bowlers { get; set; }

        // information for the team 
        public DbSet<Team> Teams { get; set; }
    }
}
