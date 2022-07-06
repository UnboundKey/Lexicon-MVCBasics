using System.Collections.Generic;
using WebApplication1.Models.Languages;

namespace WebApplication1.Models.People
{
    // A Translation object to help with cleaning up JSON database requests
    public class PersonTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int PhoneNumber { get; set; }
        public string? Country{ get; set; }
        public Language[] Languages;


        public PersonTO(Person p) {
            this.Id = p.Id;
            this.Name = p.Name;
            if(p.PersonCity.Country != null)this.Country = p.PersonCity.Country.Name;
            this.City = p.PersonCity.Name;
            this.PhoneNumber = p.PhoneNumber;
            var tempLanguageList =  new List<Language>() { new Language() {Id = 1, Name = "GOGO"}};
            this.Languages = tempLanguageList.ToArray();
        }
    }
}
