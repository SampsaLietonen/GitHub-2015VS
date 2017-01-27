using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//demo 03 T1
namespace HeaterApplication
{
    class Heater
    {
        //properties
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public double Humidity { get; set; }
        //constructor
        //methods
        //method to switch Power on
        public void Power(bool value)
        {
            value = true;
        }

        //method to increase Temperature
        public void Increase ()
        {
            Temperature += 10;
        }

        //method to decrease Temperature
        public void Decrease(int value)
        {
            Temperature -= value;
        }

        //method to display heater properties
        public void PrintData()
        {
            Console.WriteLine("Heater data: ");
            Console.WriteLine("- state: " + IsOn);
            Console.WriteLine("- temperature: " + Temperature);
            Console.WriteLine("- humidity: " +Humidity);
        }

    }
}
