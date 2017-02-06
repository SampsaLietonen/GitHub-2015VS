using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one bike Object with parametric constructor
            Console.WriteLine("Bike info");
            Bike bike = new Bike("Tunturi", "X330", 2006, "grey", true, "Shimano");
            Console.WriteLine(bike.ToString());
            Console.WriteLine("\n");

            //create another bike Object with parametric constructor
            Console.WriteLine("Bike2 info");
            Bike bike2 = new Bike("Helkama", "500", 2010, "red", false,"");
            Console.WriteLine(bike2.ToString());
            Console.WriteLine("\n");

            //create one boat Object with parametric constructor
            Console.WriteLine("Boat info");
            Boat boat = new Boat("Ukko", "Oldboat", 1970, "brown", "Cruiser", 60);
            Console.WriteLine(boat.ToString());
            Console.WriteLine("\n");

            //create one boat Object with parametric constructor
            Console.WriteLine("Boat info");
            Boat boat2 = new Boat("Vieno", "Oldboat", 1960, "green", "Man power boat", 4);
            Console.WriteLine(boat2.ToString());

        }
    }
}
