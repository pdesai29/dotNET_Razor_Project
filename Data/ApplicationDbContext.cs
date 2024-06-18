using bulky_Razor_temp.Models;
using Microsoft.EntityFrameworkCore;


namespace bulky_Razor_temp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", Description = "Action Comic" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 2, Name = "Action", Description = "Action Comic" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 3, Name = "Action", Description = "Action Comic" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 4, Name = "Action", Description = "Action Comic" });
        }
    }
}

