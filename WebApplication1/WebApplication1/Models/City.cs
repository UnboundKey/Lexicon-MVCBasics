using System.Collections.Generic;
using WebApplication1.Models.People;

namespace WebApplication1.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Person> people { get; set; }
    }
}