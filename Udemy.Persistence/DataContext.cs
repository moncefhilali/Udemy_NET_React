using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Udemy.Domain;

namespace Udemy.Persistence
{
    public  class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Activity> Activities { get; set; }
    }
}
