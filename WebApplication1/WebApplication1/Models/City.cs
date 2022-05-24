using System.Collections.Generic;
using WebApplication1.Models.People;

namespace WebApplication1.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public ICollection<Person> People { get; set; }

        public City(int id, string cityName)
        {
            this.Id = id;
            this.CityName = cityName;
        }
    }
}