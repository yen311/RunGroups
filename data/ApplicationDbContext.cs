using Microsoft.EntityFrameworkCore;
using MVCPractice.Models;

namespace MVCPractice.data.Enum
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Club> Clubs { get; set; }

        public DbSet<Race> Races { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}