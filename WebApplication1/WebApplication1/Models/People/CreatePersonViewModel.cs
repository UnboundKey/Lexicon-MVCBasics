using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.People
{
    public class CreatePersonViewModel
    {
        public Person Create(string name, int phoneNumber, string city)
        {

            Person p = new Person(name, phoneNumber, city);
            PeopleViewModel.PeopleList.Add(p);
            return new Person("Test", 500000000, "32");
        }
    }
}
