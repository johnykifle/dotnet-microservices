using Microsoft.EntityFrameworkCore;
using Platformservice.Models;

namespace Platformservice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Platform> Platforms { get; set; }

        // ...existing code...
    }
}
