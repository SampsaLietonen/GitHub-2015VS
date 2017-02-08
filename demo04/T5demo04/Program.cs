using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5demo04
{
    class Program
    {
        static void Main(string[] args)
        {

            //creat one radio Object using parametric constructor
            Console.WriteLine("Radio one");
            Radio radio = new Radio(true, 8, 2000.0);
            Console.WriteLine(radio.ToString());
            Console.WriteLine("\n");

            //creat another radio Object using parametric constructor
            Console.WriteLine("Radio two");
            Radio radio2 = new Radio(true, 10, 2700.0);
            Console.WriteLine(radio2.ToString());
            Console.WriteLine("\n");

            //creat another radio Object using parametric constructor
            Console.WriteLine("Radio three");
            Radio radio3 = new Radio(true, -1, 1600.0);
            Console.WriteLine(radio3.ToString());
            Console.WriteLine("\n");
        }
    }
}
