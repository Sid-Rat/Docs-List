using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DocList.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rating> Ratings { get; set; }


    }
}