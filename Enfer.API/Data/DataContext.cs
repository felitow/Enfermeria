using Microsoft.EntityFrameworkCore;
using Enfer.Shared.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Enfer.API.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<History> Histories { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<MedicineCategory> MedicineCategories { get; set; }

        public DbSet<MedicineImage> MedicineImages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex("CountryId", "Name").IsUnique();
            modelBuilder.Entity<City>().HasIndex("StateId", "Name").IsUnique();

            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            //modelBuilder.Entity<MedicineCategory>().HasIndex().IsUnique();
            modelBuilder.Entity<Medicine>().HasIndex(y => y.Name).IsUnique();


            modelBuilder.Entity<History>().HasIndex(h => h.NameHistory).IsUnique();
            modelBuilder.Entity<Employee>().HasIndex(e => e.Document).IsUnique();
        }
    }
}

