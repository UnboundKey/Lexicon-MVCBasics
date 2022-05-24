using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WebApplication1.Data;

namespace WebApplication1.Models.People
{
    public class Person
    {
        private string personName;
        private int personPhoneNumber;

        [Key]
        public int PersonId { get; set; }
        [Required]
        [StringLength (20)]
        public string Name { get; set; }
        [Required]
        [Range (0,9999999999)]
        public int PhoneNumber { get; set; }

        [Required]
        [StringLength (40)]
        public City City { get; set; }
        public int CityId { get; set; }


        public Person(string name, int phoneNumber, int cityId)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.City = City;
            //this.Id = _personIdCount;
            //_personIdCount++;
        }

        public Person(int personId, string name, int phonenumber, City city)
        {
            this.PersonId = personId;
            this.Name = name;
            City = city;
            this.PhoneNumber = phonenumber;
        }

        public Person(string personName, int personPhoneNumber, City city)
        {
            this.personName = personName;
            this.personPhoneNumber = personPhoneNumber;
            City = city;
        }

        public static void Delete(int personId,Controller controller)
        {
            PeopleViewModel pwm = new PeopleViewModel();




            foreach (Person p in pwm.getPeople())
            {
                if (personId == p.PersonId)
                {
                    pwm.getPeople().Remove(p);
                    controller.TempData["Message"] = "Person Removed Successfully";
                    break;
                }
               controller.TempData["Message"] = "Could not remove Person";
            }   
        }

        public static void Delete(int id, Controller controller, ApplicationDbContext dbContext)
        {
            var toDelete = dbContext.People.Where(p => p.PersonId == id).Single<Person>();
            if (toDelete != null)
            {
                dbContext.People.Remove(toDelete);
                dbContext.SaveChanges();
                controller.TempData["Message"] = "Person Removed Successfully";
            } else
            {
                controller.TempData["Message"] = "Could not remove Person";
            }
        }

    }
}
