using Microsoft.EntityFrameworkCore;
using EFLabAssignment.Models;

namespace EFLabAssignment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Electronics",
                    Description = "Electronic devices and accessories",
                    CreatedDate = DateTime.Now
                },
                new Category
                {
                    Id = 2,
                    Name = "Books",
                    Description = "Physical and digital books",
                    CreatedDate = DateTime.Now
                },
                new Category
                {
                    Id = 3,
                    Name = "Clothing",
                    Description = "Apparel and fashion items",
                    CreatedDate = DateTime.Now
                }
            );
        }
    }
}
