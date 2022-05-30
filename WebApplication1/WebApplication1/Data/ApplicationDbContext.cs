
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using WebApplication1.Models;
using WebApplication1.Models.People;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext 
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=PeopleDb;Trusted_Connection=True");
            
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Person> People { get; set; }

        Language english = new Language() { Id = 1, Name = "English" };
        Language swedish = new Language() { Id = 2, Name = "Swedish" };
        Language japanese = new Language() { Id = 3, Name = "Japanese" };

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Language>().HasData(english, swedish, japanese);

            modelBuilder.Entity<Country>().HasData(new Country() { Id = 1, Name = "Sweden" }, new Country() { Id=2, Name="Denmark"});

            modelBuilder.Entity<City>().HasData(new City() { Id = 1, Name = "Gothenburg", CountryId=1 }, new City() { Id = 2, Name = "Stockholm", CountryId=1 }, new City() { Id = 3, Name = "Kopenhagen", CountryId = 2 });


            modelBuilder.Entity<Person>().HasData(

           new Person(1, "Benjamin Nordin", 555123, 1) { },
           new Person(2, "Eda Clawthorn", 6694875, 1) {  },
           new Person(3, "King Clawthorn", 555213345, 1),
           new Person(4, "Marcy Wou", 777485632, 1),
           new Person(5, "Jonas Edenstav", 031222666, 1)
           /*僕の日本語が悪い、ごめんなさい*/

               );
        }

           
     }
        

}
