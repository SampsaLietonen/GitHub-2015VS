using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one instance of washer class
            Washer washer = new Washer();
            washer.PrintData();
            Console.WriteLine("\n");

            //
            Washer siemens = new Washer();
            siemens.IsOn = true;
            siemens.Water = true;
            siemens.Program = (1);
            siemens.Temperature = 40;
            siemens.RotationalSpeed = 1600;
            siemens.Start = true;
            siemens.PrintData();
            Console.WriteLine("\n");

            Washer samsung = new Washer();
            samsung.IsOn = true;
            samsung.Water = true;
            samsung.Program = (4);
            samsung.Temperature = 40;
            samsung.RotationalSpeed = 1200;
            samsung.Start = true;
            samsung.PrintData();
            Console.WriteLine("\n");

            //creating new instance using constructor to set values
            Washer upo = new Washer(true, true, 60, (2), 1900, false);
            upo.PrintData();

        }
    }
}
