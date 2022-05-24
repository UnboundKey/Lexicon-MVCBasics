using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Models.People
{
    public class CreatePersonViewModel
    {
        //TODO Fix bug where leading zero in phone numbers are removed.
        
        [Required]
        [StringLength(20)]
        public string PersonName { get; set; }
        [Required]
        [Range(0, 9999999999)]
        public int PersonPhoneNumber { get; set; }
        [Required]
        [StringLength(40)]
        public string PersonCity { get; set; }

        public Person Create(string name, int phoneNumber, string city)
        {

            //Person p = new Person(name, phoneNumber, city);
            //PeopleViewModel.PeopleList.Add(p);
            //return p;
            return null;
        }

        public Person Create()
        {
            // ToFIX

            //Person p = new Person(PersonName, PersonPhoneNumber, PersonCity);
            //PeopleViewModel.PeopleList.Add(p);
            return null;
        }

        public Person Create(ApplicationDbContext db)
        {
            Person p = new Person(PersonName, PersonPhoneNumber, db.Cities.Where(c => c.CityName == PersonCity).ToList().First());
            db.People.Add(p);
            db.SaveChanges();
            return p;
        }

    }
}
