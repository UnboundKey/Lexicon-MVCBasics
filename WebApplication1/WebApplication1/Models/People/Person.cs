using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models.People
{
    public class Person
    {
        private static int _personIdCount = 1;
        [Key]
        public int Id { get; set; }
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
            this.Id = _personIdCount;
            _personIdCount++;
        }

        public Person(int id, string name, int phonenumber, string city)
        {
            this.Id = id;
            this.Name = name;
            this.City = city;
            this.PhoneNumber = phonenumber;
        }

        public static void Delete(int personId,Controller controller)
        {
            PeopleViewModel pwm = new PeopleViewModel();
            foreach (Person p in pwm.getPeople())
            {
                if (personId == p.Id)
                {
                    pwm.getPeople().Remove(p);
                    controller.TempData["Message"] = "Person Removed Successfully";
                    break;
                }
                controller.TempData["Message"] = "Could not remove Person";
            }   
        }

    }
}
