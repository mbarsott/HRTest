using Microsoft.EntityFrameworkCore;
using RVezyTest.Domain;

namespace RVezyTest.Data
{
    public class RVezyTestContext : DbContext
    {
        public RVezyTestContext(DbContextOptions<RVezyTestContext> options)
            : base(options) { }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }
    }
}
