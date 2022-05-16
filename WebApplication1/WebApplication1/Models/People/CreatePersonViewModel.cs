using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.People
{
    public class CreatePersonViewModel
    {

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

            Person p = new Person(name, phoneNumber, city);
            PeopleViewModel.PeopleList.Add(p);
            return p;
        }

        public Person Create()
        {
            Person p = new Person(PersonName, PersonPhoneNumber, PersonCity);
            PeopleViewModel.PeopleList.Add(p);
            return p;
        }

    }
}
