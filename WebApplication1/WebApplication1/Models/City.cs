using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Models.People;

namespace WebApplication1.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Person> people { get; set; }
    }
}