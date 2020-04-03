using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Lulu", Type = "Bunny", Age = 4, Gender = "Female" },
          new Animal { AnimalId = 2, Name = "Rexie", Type = "Dog", Age = 7, Gender = "Female" },
          new Animal { AnimalId = 3, Name = "Tommy", Type = "Cat", Age = 2, Gender = "Female" },
          new Animal { AnimalId = 4, Name = "Bunson", Type = "Bunny", Age = 3, Gender = "Male" },
          new Animal { AnimalId = 5, Name = "Gastone", Type = "Dog", Age = 2, Gender = "Male" }
        );
    }
  }
}