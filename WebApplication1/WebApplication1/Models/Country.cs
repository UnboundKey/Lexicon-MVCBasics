using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        ICollection<City> Cities { get; set; }
    }
}
