using Microsoft.EntityFrameworkCore;

namespace Job_serach.Models
{
    public class EVSDbContext : DbContext
    {
        public EVSDbContext(DbContextOptions<EVSDbContext> options) : base(options)
        { 
        }
            public DbSet<Address> Addresses{ get; set; }
        public DbSet<candidate> candidates { get; set; }

        public DbSet<Candidate_type> Candidate_types{ get; set; }
        public DbSet<election> elections { get; set; }
        public DbSet<party> partys { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<user_type> user_type{ get; set; }
        public DbSet<vote> votes { get; set; }
        public DbSet<voter> voters { get; set; }

    }
}
