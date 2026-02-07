using FlatMeat_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlatMeat_Backend.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

        public DbSet<Users> Users { get; set; }
    }
}
