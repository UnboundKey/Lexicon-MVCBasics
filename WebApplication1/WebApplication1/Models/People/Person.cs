using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.People;

namespace WebApplication1.Models
{
    public class Person
    {
        private static int PersonIDCount = 1;
        public int Id { get; private set; }
        [Required]
        [StringLength (20)]
        public string Name { get; set; }
        [Required]
        [Range (0,9999999999)]
        public int PhoneNumber { get; set; }
        [Required]
        [StringLength (40)]
        public string City { get; set; }

        public Person(string name, int phoneNumber, string city)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.City = city;
            this.Id = PersonIDCount;
            PersonIDCount++;
        }

        public static void Delete(int PersonId,Controller controller)
        {
            PeopleViewModel pwm = new PeopleViewModel();
            foreach (Person p in pwm.getPeople())
            {
                if (PersonId == p.Id)
                {
                    pwm.getPeople().Remove(p);
                    controller.TempData["Message"] = "Person Removed Successfully";
                    break;
                }
            }
            
}

    }
}
