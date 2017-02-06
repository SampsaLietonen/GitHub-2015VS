using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one employee Object with paramteric constructor
            Console.WriteLine("Employee");
            Employee employee = new Employee ("Java Jackson", "Senior Programmer", 2500 ); 
            Console.WriteLine(employee.ToString());
            Console.WriteLine("\n");

            //create one boss Object with parametric constructor
            Console.WriteLine("Boss");
            Boss boss = new Boss ("Java Master", "Super ultimate boss", 4000, "BMW", 1000);
            Console.WriteLine(boss.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("methods just for fun!");
            employee.EmployeeMethod();
            boss.BossMethod();
        }
    }
}
