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
            Employee employee = new Employee ("Java Jackson", "Senior Programmer", 2500 );
            Console.WriteLine(employee.ToString());

            //create one boss Object with parametric constructor
            Boss boss = new Boss ("Java Master", "Super ultimate boss", 4000, "BMW", 1000);
            Console.WriteLine(boss.ToString());

            employee.EmployeeMethod();
            boss.BossMethod();
        }
    }
}
