using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._28CodingChallenge
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EyeColor { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person()
        {

        }

        public Person(string firstname, string lastname, int age, string eyecolor, DateTime dateOfBirth)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            EyeColor = eyecolor;
            DateOfBirth = dateOfBirth;
        }


    }
}
