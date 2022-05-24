using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Models.People;

namespace WebApplication1.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; } = 1;
        public string Name { get; set; }
        public List<Person> People { get; set; }

        public Country Country { get; set; }
        public int CountryId { get; set; }

        public City(int cityId, string name)
        {
            this.CityId = cityId;
            this.Name = name;
        }
    }
}