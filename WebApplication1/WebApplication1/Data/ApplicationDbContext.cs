
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Models.People;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext 
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        


        public DbSet<Person> People { get; set; }
        public DbSet<City> Cities { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            City city1 = new City(1, "Gothenburg");
            City city2 = new City(2, "Trelleborg");
            City city3 = new City(1, "Malmo");
            City city4 = new City(1, "Jönsköping");
            modelBuilder.Entity<City>().HasData (
                city1,
                city2,
                city3,
                city4
                    
            );

            modelBuilder.Entity<Person>().HasData(
            new Person(1,"Benjamin Nordin", 555123, city1),
            new Person(2,"Eda Clawthorn", 6694875, city2),
            new Person(3,"King Clawthorn", 555213345, city2),
            new Person(4,"Marcy Wou",777485632,city3),
            new Person(5,"Jonas Edenstav",031222666,city4)

                );
        }
        

    }
}
