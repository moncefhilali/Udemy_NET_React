using Microsoft.EntityFrameworkCore;
using Udemy.Domain;

namespace Udemy.Persistence
{
    public  class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Activity> Activities { get; set; }
    }
}
