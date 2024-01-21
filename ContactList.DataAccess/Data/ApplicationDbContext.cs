using ContactListWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactListWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Family", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Friend", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Work", DisplayOrder = 3 }
                );
        }

    }
}
