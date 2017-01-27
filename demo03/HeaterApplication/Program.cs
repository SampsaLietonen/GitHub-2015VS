using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//demo 03 T1
namespace HeaterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one instance of heater class
            Heater heater = new Heater();
            heater.PrintData();
            heater.IsOn = true;
            heater.Temperature = 60;
            heater.Humidity = 75;
            heater.PrintData();
            heater.Increase();
            Console.WriteLine("Temperature: " + heater.Temperature);


            Heater harvia = new Heater();
            heater.PrintData();
            heater.IsOn = true;
            heater.Temperature = 70;
            heater.Humidity = 80;
            heater.PrintData();
            heater.Decrease(10);
            Console.WriteLine("Temperature: " +heater.Temperature);

            //testing...
            Console.WriteLine("You can go to Sauna: " +heater.Temperature);
            {
                while (heater.Temperature >=70); 
            }
        }
    }
}
