using System.Reflection;
using FlowerStore.Core;
using FlowerStore.Core.Entities;
using FlowerStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlowerStore.Infrastructure.Persistence
{
    public class FlowerStoreDbContext : DbContext
    {
        public FlowerStoreDbContext(DbContextOptions<FlowerStoreDbContext> options) : base(options)
        {
        }

        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

