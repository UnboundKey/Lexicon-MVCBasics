using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public List<City> Cities { get; set; }


    }
}
