using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Luna", Species = "Cat", Age = 2 },
          new Animal { AnimalId = 2, Name = "Rocky", Species = "Dog", Age = 3 },
          new Animal { AnimalId = 3, Name = "Sparkle", Species = "Rabbit", Age = 1 },
          new Animal { AnimalId = 4, Name = "Ziggy", Species = "Parrot", Age = 5 },
          new Animal { AnimalId = 5, Name = "Whiskers", Species = "Hamster", Age = 1 },
          new Animal { AnimalId = 6, Name = "Shadow", Species = "Snake", Age = 4 },
          new Animal { AnimalId = 7, Name = "Mochi", Species = "Guinea Pig", Age = 2 },
          new Animal { AnimalId = 8, Name = "Tinker", Species = "Ferret", Age = 2 },
          new Animal { AnimalId = 9, Name = "Nala", Species = "Fish", Age = 1 },
          new Animal { AnimalId = 10, Name = "Blizzard", Species = "Hedgehog", Age = 1 },
          new Animal { AnimalId = 11, Name = "Milo", Species = "Dog", Age = 2 },
          new Animal { AnimalId = 12, Name = "Daisy", Species = "Dog", Age = 1 },
          new Animal { AnimalId = 13, Name = "Simba", Species = "Cat", Age = 3 },
          new Animal { AnimalId = 14, Name = "Cooper", Species = "Dog", Age = 4 },
          new Animal { AnimalId = 15, Name = "Lily", Species = "Cat", Age = 2 },
          new Animal { AnimalId = 16, Name = "Riley", Species = "Dog", Age = 3 },
          new Animal { AnimalId = 17, Name = "Sasha", Species = "Cat", Age = 1 },
          new Animal { AnimalId = 18, Name = "Teddy", Species = "Dog", Age = 2 },
          new Animal { AnimalId = 19, Name = "Cleo", Species = "Cat", Age = 4 },
          new Animal { AnimalId = 20, Name = "Bentley", Species = "Dog", Age = 1 }
        );
    }
  }
}