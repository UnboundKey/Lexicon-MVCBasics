
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.People;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
            new Person("A", 555213345, "Gondor"),
            new Person("B", 555213345, "Gondor"),
            new Person("C", 555213345, "Gondor"),
            new Person("D", 555213345, "Gondor"),
            new Person("E", 555213345, "Gondor"),
            new Person("F", 555213345, "Gondor"),
            new Person("G", 555213345, "Gondor"),
            new Person("H", 555213345, "Gondor"),
            new Person("I", 555213345, "Gondor"),
            new Person("J", 555213345, "Gondor"),
            new Person("K", 555213345, "Gondor"),
            new Person("L", 555213345, "Gondor"),
            new Person("M", 555213345, "Gondor"),
            new Person("N", 555213345, "Gondor"),
            new Person("O", 555213345, "Gondor"),
            new Person("P", 555213345, "Gondor")
                );
        }
        

    }
}
