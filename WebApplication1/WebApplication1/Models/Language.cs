using System.Collections.Generic;
using WebApplication1.Models.People;

namespace WebApplication1.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Person> People { get; set; }
    }
}
