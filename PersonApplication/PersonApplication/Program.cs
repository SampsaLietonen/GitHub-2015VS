using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create persons (collection)
            Persons myFriends = new Persons();

            //create few persons Object
            Person person1 = new Person { Firstname = "Kirsi", Lastname = "Kernell", SocialSecurityNumber = "123456-123A"};

            Person person2 = new Person { Firstname = "Matti", Lastname = "Kattinen", SocialSecurityNumber = "123457-127B" };
            Person person3 = new Person { Firstname = "Veikko", Lastname = "Peikko", SocialSecurityNumber = "123458-127C" };

            //add Person Object to Persons (myFriends)
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            //get one person
            Person person4 = myFriends.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("There is no person at that position!");
            }

            //print collection
            myFriends.PrintData();

            //find person
            string SocialSecurityNumber = "123457-127";
            Console.WriteLine("Find person with SocialSecurityNumber:" + SocialSecurityNumber);
            Person person5 = myFriends.FindPerson(SocialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Can´t find person with that SocialSecurityNumber!");
            }
        }
    }
}
