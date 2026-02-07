using FlatMeat_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlatMeat_Backend.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

        public DbSet<Users> Users { get; set; }

        public DbSet<OwnerPersonalInfo> OwnerPersonalInfo { get; set; }

        public DbSet<RoomData> RoomData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OwnerPersonalInfo>()
                .HasMany(o => o.Rooms)
                .WithOne(r => r.Owner)
                .HasForeignKey(r => r.OwnerId);
        }
    }
}
