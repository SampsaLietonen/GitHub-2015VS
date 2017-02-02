using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            int input;
            //Console.WriteLine("Floor number is: " + elevator.getFloor());


            //Console.WriteLine("Elevator is on floor : " + elevator.getFloor());

            do
            {
                Console.WriteLine("Give a new floor number 1 to 5: ");
                input = int.Parse(Console.ReadLine());
                elevator.Floor = input;
                Console.WriteLine("Floor number is: " + input);


            }
            while (input != 0);

        }

    }
}
