using Microsoft.EntityFrameworkCore;

namespace CH04.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Family" },
            new Category { Id = 2, Name = "Friend" },
            new Category { Id = 3, Name = "Work" }
        );

        modelBuilder.Entity<Contact>().HasData(
            new Contact { Id = 1, FirstName = "J", LastName = "Smith", Email = "ooo@ll.com", CategoryId = 1, DateAdded = new DateTime(2025, 2, 6) },
            new Contact { Id = 2, FirstName = "Avell", LastName = "Novel", Email = "iii@yy.com", CategoryId = 2, DateAdded =new DateTime(2025, 2, 6) },
            new Contact { Id = 3, FirstName = "T", LastName = "Shirt", Email = "pp@hh.com", CategoryId = 3, DateAdded = new DateTime(2025, 2, 6) }
        );
    }
}
