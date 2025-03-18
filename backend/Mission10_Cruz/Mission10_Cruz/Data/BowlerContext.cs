using Microsoft.EntityFrameworkCore;

namespace Mission10_Cruz.Data
{
    public class BowlerContext : DbContext
    {
        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options) 
        { 
        }

        // for BowlingCrew
        public DbSet<BowlingCrew> Bowlers { get; set; }

        // for Team 
        public DbSet<Team> Teams { get; set; }
    }
}
