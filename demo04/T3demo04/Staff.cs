using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3demo04
{
    class Staff
    {
        //properties
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        //default constructor
        public Staff()
        {
        }

        //constuctor takes Staff name, profession and salary parameters
        public Staff(string name, string profession, int salary)
        {
            Name = name;
            Profession = profession;
            Salary = salary;
        }

        //one method what staff can do
        public void StaffMethod()
        {
            Console.WriteLine("This method belongs to Staff!");
        }

        //return Staff data as a one string, override Object class ToString()- method
        public override string ToString()
        {
            return Name + ":" + Profession + ":" + Salary;
        }
    }
}
