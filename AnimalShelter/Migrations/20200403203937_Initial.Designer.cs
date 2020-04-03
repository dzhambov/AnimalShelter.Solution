﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Solution.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20200403203937_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 4,
                            Gender = "Female",
                            Name = "Lulu",
                            Type = "Bunny"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 7,
                            Gender = "Female",
                            Name = "Rexie",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 2,
                            Gender = "Female",
                            Name = "Tommy",
                            Type = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 3,
                            Gender = "Male",
                            Name = "Bunson",
                            Type = "Bunny"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 2,
                            Gender = "Male",
                            Name = "Gastone",
                            Type = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}