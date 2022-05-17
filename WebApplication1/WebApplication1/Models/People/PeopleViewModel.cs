using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.People
{
    public class PeopleViewModel
    {
        public static List<Person> PeopleList = new List<Person> {
            new Person("Benjamin", 555213345,"Gondor"),
            new Person("Luz Nozeda", 555112385,"Bones Burrow"),
            new Person("Eda Clawthorn", 222876988,"Bones Burrow"),
            new Person("King Clawthorn", 222876988,"Bones Burrow"),
            new Person("Legolas", 2000000,"Eraborn"),
        };
        public string searchTerm;

        public List<Person> getPeople()
        {
            return PeopleList;
        }

        public List<Person> getPeople(string searchTerm)
        {
            List<Person> sortedPeople = new List<Person>();
            foreach(Person person in PeopleList)
            {
                if (searchTerm == null)
                {
                    sortedPeople = getPeople();
                    break;
                }
                if (person.Name.Contains(searchTerm) || person.City.Contains(searchTerm))
                {
                    sortedPeople.Add(person);
                }
            }
            return sortedPeople;
        }

        public List<Person> getPeople(int searchTerm)
        {
            List<Person> sortedPeople = new List<Person>();
            foreach (Person person in PeopleList)
            {
                if (searchTerm == 0)
                {
                    sortedPeople = getPeople();
                    break;
                }
                if (person.Id == searchTerm)
                {
                    sortedPeople.Add(person);
                }
            }
            return sortedPeople;
        }
    }
}
