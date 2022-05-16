using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Person
    {
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
        }
    }
}
