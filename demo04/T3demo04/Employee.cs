using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3demo04
{
    class Employee : Staff
    {
        //default constructor
        public Employee()
        {
        }

        //parametric constructor
        public Employee(string name, string profession, int salary)
            : base (name, profession, salary)
        {
        }

        //one method what employee can do
        public void EmployeeMethod()
        {
            Console.WriteLine("This method belongs to Employee!");
        }

        public override string ToString()
        {
            //Staff- luokan ToString + Salary
            //palauttaa name:profession:salary
            //base viittaa ylikuokkaan eli nyt Staff- luokkaan
            return base.ToString();
        }
    }
}
