using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo04T1
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        //default contsructor
        public Person()
        {
        }
        
        //contructor takes person firstname and lastname as a parameter
        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        //one method what person can do
        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person!");
        }

        //return Person data as a one string, override Object class ToString()- method
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Address + " " + Age + " " + PhoneNumber; 
        }

    }
}
