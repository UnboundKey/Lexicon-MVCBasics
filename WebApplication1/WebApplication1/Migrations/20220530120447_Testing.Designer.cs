﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220530120447_Testing")]
    partial class Testing
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LanguagePerson", b =>
                {
                    b.Property<int>("PeopleId")
                        .HasColumnType("int");

                    b.Property<int>("PersonLanguagesId")
                        .HasColumnType("int");

                    b.HasKey("PeopleId", "PersonLanguagesId");

                    b.HasIndex("PersonLanguagesId");

                    b.ToTable("LanguagePerson");

                    b.HasData(
                        new
                        {
                            PeopleId = 1,
                            PersonLanguagesId = 1
                        },
                        new
                        {
                            PeopleId = 1,
                            PersonLanguagesId = 2
                        },
                        new
                        {
                            PeopleId = 2,
                            PersonLanguagesId = 1
                        },
                        new
                        {
                            PeopleId = 3,
                            PersonLanguagesId = 1
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Gothenburg"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Stockholm"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 2,
                            Name = "Kopenhagen"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CitiesId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sweden"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Denmark"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "English"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Swedish"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Japanese"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.People.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PersonCityId")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonCityId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Benjamin Nordin",
                            PersonCityId = 1,
                            PhoneNumber = 555123
                        },
                        new
                        {
                            Id = 2,
                            Name = "Eda Clawthorn",
                            PersonCityId = 1,
                            PhoneNumber = 6694875
                        },
                        new
                        {
                            Id = 3,
                            Name = "King Clawthorn",
                            PersonCityId = 1,
                            PhoneNumber = 555213345
                        },
                        new
                        {
                            Id = 4,
                            Name = "Marcy Wou",
                            PersonCityId = 1,
                            PhoneNumber = 777485632
                        },
                        new
                        {
                            Id = 5,
                            Name = "Jonas Edenstav",
                            PersonCityId = 1,
                            PhoneNumber = 31222666
                        });
                });

            modelBuilder.Entity("LanguagePerson", b =>
                {
                    b.HasOne("WebApplication1.Models.People.Person", null)
                        .WithMany()
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Language", null)
                        .WithMany()
                        .HasForeignKey("PersonLanguagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.City", b =>
                {
                    b.HasOne("WebApplication1.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Country");
                });

            modelBuilder.Entity("WebApplication1.Models.People.Person", b =>
                {
                    b.HasOne("WebApplication1.Models.City", "PersonCity")
                        .WithMany("People")
                        .HasForeignKey("PersonCityId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("PersonCity");
                });

            modelBuilder.Entity("WebApplication1.Models.City", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("WebApplication1.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
