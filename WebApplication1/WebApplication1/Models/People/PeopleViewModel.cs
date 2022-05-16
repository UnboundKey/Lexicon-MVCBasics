using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.People
{
    public class PeopleViewModel
    {
        public static List<Person> PeopleList = new List<Person> {};
        public List<Person> getPeople()
        {
            return PeopleList;
        }

        public List<Person> getPeople(string searchTerm)
        {
            List<Person> sortedPeople = new List<Person>();
            foreach(Person person in PeopleList)
            {
                if(person.Name.Contains(searchTerm) || person.City.Contains(searchTerm))
                {
                    sortedPeople.Add(person);
                }
            }
            return sortedPeople;
        }
    }
}
