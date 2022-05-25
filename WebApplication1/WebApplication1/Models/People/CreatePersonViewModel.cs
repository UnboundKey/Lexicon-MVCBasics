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

        public CreatePersonViewModel()
        {

        }
        
        [Required]
        [StringLength(20)]
        public string PersonName { get; set; }
        [Required]
        [Range(0, 9999999999)]
        public int PersonPhoneNumber { get; set; }
        
        [StringLength(40)]
        public string PersonCity { get; set; }
        [Required]
        public int personCityId { get; set; }

        public Person Create(string name, int phoneNumber, string city)
        {

            //Person p = new Person(name, phoneNumber, city);
            //PeopleViewModel.PeopleList.Add(p);
            //return p;
            return null;
        }

        public Person Create()
        {
            Person p = new Person(PersonName, PersonPhoneNumber, PersonCity);
            PeopleViewModel.PeopleList.Add(p);
            //ApplicationDbContext.People.Add(p);
            return p;
            //return null;
        }

        public Person Create(ApplicationDbContext db,int cityId)
        {
            Person p = new Person(PersonName, PersonPhoneNumber, cityId);
            db.People.Add(p);
            db.SaveChanges();
            return p;
        }

        public Person Create(ApplicationDbContext db)
        {
            Person p = new Person(PersonName, PersonPhoneNumber, PersonCity);
            db.People.Add(p);
            db.SaveChanges();
            return p;
        }

    }
}
