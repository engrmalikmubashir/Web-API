using Microsoft.EntityFrameworkCore;

namespace Web_API.Models
{
    public class DonationDbContext : DbContext
    {
        public DonationDbContext(DbContextOptions<DonationDbContext> options) : base(options)
        {

        }

        public DbSet<DCandidate> DCandidates { get; set; }
    }
}
