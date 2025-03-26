using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        // Define your DbSets here
        // public DbSet<YourEntity> YourEntities { get; set; }

        public DbSet<AppUser> Users { get; set; }
    }
}