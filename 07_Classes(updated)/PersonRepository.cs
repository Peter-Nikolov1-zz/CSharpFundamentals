using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes_updated_
{
    public class PersonRepository
    {
        //Bronze
        List<Person> personList = new List<Person>();

        public void AddPerson(Person newPerson)
        {
            personList.Add(newPerson);
        }
        //Silver
        public List<Person> ReturnList()
        {
            return personList;
        }
        //Gold
        public void DelPerson(string name)
        {
            foreach (Person Individual in personList)
            {
                if (Individual.FullName == name)
                {
                    personList.Remove(Individual);
                }
            }
        }
        //Super Gold
        public void UpdatePerson(string name, string firstName, string lastName, DateTime dateOfBirth, Vehicle transport)
        {
            foreach (Person Individual in personList)
            {
                if (Individual.FullName == name)
                {
                    Individual.FirstName = firstName;
                    Individual.LastName = lastName;
                    Individual.DateOfBirth = dateOfBirth;
                    Individual.Transport = transport;
                }

            }
        }
    }
}
