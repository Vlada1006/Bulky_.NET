using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;


namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
            );

            modelBuilder.Entity<Car>().HasData(
                new Car { CarId = 1, CarName = "Audi", CarColor = "Black" },
                new Car { CarId = 2, CarName = "Porshe", CarColor = "Blue" },
                new Car { CarId = 3, CarName = "Toyota", CarColor = "White" },
                new Car { CarId = 4, CarName = "BMW", CarColor = "Pink" }

            );
        }
    }
}
