
using Microsoft.EntityFrameworkCore;
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

        public ApplicationDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=PeopleDb;Trusted_Connection=True");
            
        }


        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(new City() { Id = 1, Name = "Gothenburg" });

            modelBuilder.Entity<Person>().HasData(

            new Person(1,"Benjamin Nordin", 555123, "Gothenburg"),
            new Person(2,"Eda Clawthorn", 6694875, "Bones Burrow"),
            new Person(3,"King Clawthorn", 555213345, "Bones Burrow"),
            new Person(4,"Marcy Wou",777485632,"Newtopia"),
            new Person(5,"Jonas Edenstav",031222666,"Gothenburg")

                );
        }
        

    }
}
