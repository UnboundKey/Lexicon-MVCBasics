﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApplication1.Models.People.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 17,
                            City = "Gondor",
                            Name = "A",
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 18,
                            City = "Gondor",
                            Name = "B",
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 19,
                            City = "Gondor",
                            Name = "C",
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 20,
                            City = "Gondor",
                            Name = "D",
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 21,
                            City = "Gondor",
                            Name = "E",
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 22,
                            City = "Gondor",
                            Name = "F",
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 23,
                            City = "Gondor",
                            Name = "G",
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 24,
                            City = "Gondor",
                            Name = "H",
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 25,
                            City = "Gondor",
                            Name = "I",
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 26,
                            City = "Gondor",
                            Name = "J",
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 27,
                            City = "Gondor",
                            Name = "K",
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 28,
                            City = "Gondor",
                            Name = "L",
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 29,
                            City = "Gondor",
                            Name = "M",
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 30,
                            City = "Gondor",
                            Name = "N",
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 31,
                            City = "Gondor",
                            Name = "O",
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 32,
                            City = "Gondor",
                            Name = "P",
                            PhoneNumber = 555213345
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
