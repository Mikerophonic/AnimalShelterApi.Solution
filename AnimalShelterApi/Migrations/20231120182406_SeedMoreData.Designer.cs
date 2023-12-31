﻿// <auto-generated />
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    [Migration("20231120182406_SeedMoreData")]
    partial class SeedMoreData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Species")
                        .HasColumnType("longtext");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 2,
                            Name = "Luna",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 3,
                            Name = "Rocky",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 1,
                            Name = "Sparkle",
                            Species = "Rabbit"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 5,
                            Name = "Ziggy",
                            Species = "Parrot"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 1,
                            Name = "Whiskers",
                            Species = "Hamster"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 4,
                            Name = "Shadow",
                            Species = "Snake"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 2,
                            Name = "Mochi",
                            Species = "Guinea Pig"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = 2,
                            Name = "Tinker",
                            Species = "Ferret"
                        },
                        new
                        {
                            AnimalId = 9,
                            Age = 1,
                            Name = "Nala",
                            Species = "Fish"
                        },
                        new
                        {
                            AnimalId = 10,
                            Age = 1,
                            Name = "Blizzard",
                            Species = "Hedgehog"
                        },
                        new
                        {
                            AnimalId = 11,
                            Age = 2,
                            Name = "Milo",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 12,
                            Age = 1,
                            Name = "Daisy",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 13,
                            Age = 3,
                            Name = "Simba",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 14,
                            Age = 4,
                            Name = "Cooper",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 15,
                            Age = 2,
                            Name = "Lily",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 16,
                            Age = 3,
                            Name = "Riley",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 17,
                            Age = 1,
                            Name = "Sasha",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 18,
                            Age = 2,
                            Name = "Teddy",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 19,
                            Age = 4,
                            Name = "Cleo",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 20,
                            Age = 1,
                            Name = "Bentley",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
