using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Persons
    {
        //persons collection stores Person Object
        private List<Person> persons;

        //constructor
        public Persons()
        {
            persons = new List<Person>();
        }
        
        /// <summary>
        /// Add persons to collection
        /// </summary>
        /// <param name="person">person to add</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Person GetPerson(int index)
        {
            if (index < persons.Count) return persons.ElementAt(index);
            else return null;
        }

        public Person FindPerson(string SocialSecurityNumber)
        {
            foreach (Person person in persons)
            {
                //compare to string
                if (SocialSecurityNumber.Equals(person.SocialSecurityNumber))
                {
                    return person;
                }
            }
            return null; //person with search socialsecuritynumber not found in collection
        }

        public void PrintData()
        {
            foreach(Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }        
        }

    }
}
