using Microsoft.EntityFrameworkCore;
using Enfer.Shared.Entities;

namespace Enfer.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Country> Countries { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();

            modelBuilder.Entity<Category>().HasIndex(y => y.Name).IsUnique();
        }
    }
}

